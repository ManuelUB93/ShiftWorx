-- 1 companies and factories ==> dbo.fp_core_Comtory
select ds.*, 	
(select minimum_activity_filter  from fp_core.activity_filters_and_modifiers where id = ds.filters_and_modifiers_id) as minimum_activity_filter,
(select minimum_inactivity_filter  from fp_core.activity_filters_and_modifiers where id = ds.filters_and_modifiers_id) as minimum_inactivity_filter,
(select minimum_activity_modifier  from fp_core.activity_filters_and_modifiers where id = ds.filters_and_modifiers_id) as minimum_activity_modifier,
(select maximum_activity_modifier  from fp_core.activity_filters_and_modifiers where id = ds.filters_and_modifiers_id) as  maximum_activity_modifier
from fp_core.data_sources as ds
where type_id = 5 



--select 	ds.id, ds.parent_id, ds.name, ds.desc, ds.str_val, ds.is_active, af.minimum_activity_filter, 
--		af.minimum_inactivity_filter, af.minimum_activity_modifier, af.maximum_activity_modifier, ds.created_at, ds.updated_at, ds.deleted_at
--	from data_sources as ds
--	inner join activity_filters_and_modifiers as af
--    on ds.filters_and_modifiers_id = af.id
--	where ds.type_id = 5 and ds.parent_id = 1;

---- add more because there some companies without filters_and_modifiers_id
--select 	ds.id, ds.parent_id, ds.name, ds.desc, ds.str_val, ds.is_active, ds.created_at, ds.updated_at, ds.deleted_at 
--	from data_sources as ds
--	where ds.type_id = 5 and ds.parent_id = 1 and ds.filters_and_modifiers_id is null;

---- 2 factories
--select 	ds.id, ds.parent_id, ds.name, ds.desc, ds.str_val, ds.is_active, af.minimum_activity_filter, 
--		af.minimum_inactivity_filter, af.minimum_activity_modifier, af.maximum_activity_modifier, ds.created_at, ds.updated_at, ds.deleted_at
--	from data_sources as ds
--	inner join activity_filters_and_modifiers as af
--    on ds.filters_and_modifiers_id = af.id
--	where ds.type_id = 5 and ds.parent_id != 1;   

-- 3. legacy box
select ds.*, 
	(select str_val from fp_core.data_sources where id = ds.parent_id) as factoryKey 
	from fp_core.data_sources as ds
	where type_id = 2

-- 4. FreePoint Hardware => dbo.fp_core_FPHardware 
select * from fp_core.data_sources where type_id = 4

-- 5. job 
select j.*, 
	(select label from time_scale_factors where j.runrate_scale_factor_id = id) as runrate, 
	(select label from time_scale_factors where j.runtime_scale_factor_id = id) as runtime 
	from jobs as j

-- 6. notes
select * from fp_core.notes



-- insert companies into dbo.Company
INSERT INTO dbo.Company 
	([Name], [Description], FactoryKey, IsActive, MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, CreatedAt, UpdatedAt, DeletedAt, fp_core_id, Latitude, Longitude)
	Select [name], [desc], str_val, is_active =  1, minimum_activity_filter, minimum_inactivity_filter, minimum_activity_modifier, maximum_activity_modifier, created_at, updated_at, deleted_at, id, '', '' 
		from dbo.fp_core_Comtory as c
		where c.parent_id = 1;

-- insert factories into dbo.Factory
Insert Into dbo.Factory
	([name], [Description], FactoryKey, IsActive, 
		MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, 
		CompanyId, CreatedAt, UpdatedAt, DeletedAt, fp_core_id, Latitude, Longitude)
	Select 
		f.[name], f.[desc], f.str_val, f.is_active, 
		f.minimum_activity_filter, f.minimum_inactivity_filter, f.minimum_activity_modifier, f.maximum_activity_modifier, 
		com.Id, f.created_at, f.updated_at, f.deleted_at, f.id, '', '' 
		from (select * from dbo.fp_core_Comtory where parent_id != 1) as f
		inner join(select * from dbo.fp_core_Comtory where parent_id = 1) as c
		on c.id = f.parent_id
		inner join dbo.Company as com
		on com.FactoryKey = c.str_val;

-- insert factories for companies without factories
Insert Into dbo.Factory
	(CompanyId, [name], [Description], FactoryKey, IsActive, 
		MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, 
		CreatedAt, UpdatedAt, DeletedAt, fp_core_id, Latitude, Longitude)

	select c1.Id,
			c1.[Name], 'default factory', c1.FactoryKey, c1.IsActive, 
			c1.MinimumActivityFilter, c1.MinimumInactivityFilter, c1.MinimumActivityModifier, c1.MaximumActivityModifier,
			c1.CreatedAt, c1.UpdatedAt, c1.DeletedAt, c1.fp_core_id, '', ''
		from dbo.Company as c1
		where c1.Id not in (select f.CompanyId from dbo.Factory as f)

-- insert factories which are using grouping
Insert Into dbo.Factory
	([name], [Description], FactoryKey, IsActive, 
		MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, 
		CompanyId, CreatedAt, UpdatedAt, DeletedAt, fp_core_Id, Latitude, Longitude, [Group])
	select 
		f.[name], f.[desc], f.str_val, f.is_active, 
		f.minimum_activity_filter, f.minimum_inactivity_filter, f.minimum_activity_modifier, f.maximum_activity_modifier,
		(select CompanyId from dbo.Factory where f.parent_id = fp_core_id),
		f.created_at, f.updated_at, f.deleted_at, f.id, '', '', 
		(select [name] from dbo.Factory where f.parent_id = fp_core_id)
		from dbo.fp_core_Comtory as f
			where f.str_val not in (select FactoryKey from dbo.Company) 
			and f.str_val not in (select FactoryKey from dbo.Factory)
-- insert factories for the companies which have job
Insert Into dbo.Factory
	(CompanyId, [name], [Description], FactoryKey, IsActive, 
		MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, 
		CreatedAt, UpdatedAt, DeletedAt, fp_core_id, Latitude, Longitude)

	select c1.Id,
			c1.[Name], 'default factory', c1.FactoryKey, c1.IsActive, 
			c1.MinimumActivityFilter, c1.MinimumInactivityFilter, c1.MinimumActivityModifier, c1.MaximumActivityModifier,
			c1.CreatedAt, c1.UpdatedAt, c1.DeletedAt, c1.fp_core_id, '', ''
		from dbo.Company as c1
		where c1.fp_core_id = 8466 or c1.fp_core_Id = 14

-- insert factories for the companies which have ReportDefinition
Insert Into dbo.Factory
	(CompanyId, [name], [Description], FactoryKey, IsActive, 
		MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, 
		CreatedAt, UpdatedAt, DeletedAt, fp_core_id, Latitude, Longitude)

	select c1.Id,
			c1.[Name], 'default factory for Report', c1.FactoryKey, c1.IsActive, 
			c1.MinimumActivityFilter, c1.MinimumInactivityFilter, c1.MinimumActivityModifier, c1.MaximumActivityModifier,
			c1.CreatedAt, c1.UpdatedAt, c1.DeletedAt, c1.fp_core_id, '', ''
		from dbo.Company as c1
		where c1.fp_core_id in (1,9290,11091,11092,12386,42652,42860,47490,47993,55549,58072,58114,58320)

-- insert machanes using LegacyBox
INSERT INTO dbo.Machine 
	([Name], [Description], FactoryId, RemoteAddress, fp_core_Id, CreatedAt, UpdatedAt, DeletedAt)
	Select [name], [desc], 
		(select id from dbo.Factory where factoryKey = lb.factoryKey), lb.str_val, lb.Id,
		created_at, updated_at, deleted_at
		from dbo.fp_core_LegacyBox as lb



-- insert factories for companies which have factories and machines at the same time.
Insert Into dbo.Factory
	(CompanyId, [name], [Description], FactoryKey, IsActive, 
		MinimumActivityFilter, MinimumInactivityFilter, MinimumActivityModifier, MaximumActivityModifier, 
		CreatedAt, UpdatedAt, DeletedAt, fp_core_id, Latitude, Longitude)

	select c1.Id,
			c1.[Name], 'default factory', c1.FactoryKey, c1.IsActive, 
			c1.MinimumActivityFilter, c1.MinimumInactivityFilter, c1.MinimumActivityModifier, c1.MaximumActivityModifier,
			c1.CreatedAt, c1.UpdatedAt, c1.DeletedAt, c1.fp_core_id, '', ''
		from dbo.Company as c1
		inner join dbo.fp_core_Comtory	as com
		on com.id = c1.fp_core_Id
		where 
				com.id not  in (select fp_core_id from dbo.Factory)
			and com.id in (select fp_core_id from dbo.Company)
			and com.id in (
				select distinct(lb.parent_id) from dbo.Machine as m
					inner join dbo.fp_core_LegacyBox as lb
					on lb.id = m.fp_core_Id
					where m.FactoryId is null)

-- update missing factoryId 
update dbo.Machine 
	set dbo.Machine.factoryId =  f.id 
		from dbo.Factory as f
			inner join dbo.fp_core_LegacyBox as lb
			on f.fp_core_Id = lb.parent_id
			inner join dbo.Machine as m
			on m.fp_core_Id = lb.id	
		where factoryId is null 


-- insert collectors using FP_H/W
INSERT INTO dbo.Collector
	(FPHardwareId, [Name], [Description], MachineId, fp_data_source_Id, CreatedAt, UpdatedAt, DeletedAt)
	select 	
		hw.num_val, hw.[name], hw.[desc], 
		(select id from dbo.Machine where fp_core_Id = hw.parent_id),
		hw.id, hw.created_at, hw.updated_at, hw.deleted_at
		from dbo.fp_core_FPHardware as hw

-- insert live JobTemplate from fp_core_Jobs
INSERT INTO dbo.JobTemplate
	([Name], [Description], ClientKey, fp_core_id, CreatedAt, UpdatedAt, DeletedAt, FactoryId, 
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, 
    CustomerName, EstmatedStartDate, PlannedEndDate, Multiplier, IsOpen, RunRateScale, RuntimeScale)

    select j.[name], j.[desc], j.client_key, j.id, j.created_at, j.updated_at, j.deleted_at, f.id as factoryId,
        j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation,
        j.customer_name, j.est_start_date, j.planned_end_date, j.multiplier, j.is_open, 
        Case when j.runrate_scale_factor_id = 4 then 60 
                Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
            Case when j.runtime_scale_factor_id = 2  then 60 
                Else Case when j.runtime_scale_factor_id = 3 then 3600
                    Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end
        from dbo.fp_core_jobs as j
        inner join dbo.fp_core_Comtory as fpc
        on fpc.Id = j.data_source_id
        inner join dbo.Factory as f
        on f.FactoryKey = fpc.str_val
	    where j.is_template = 1 and j.parent_id is null and j.is_archived = 0
        --and j.target_count is null and j.target_runtime is null and j.target_runrate is null
        --and j.runtime_scale_factor_id is null
        --and j.runrate_scale_factor_id is null
        --and j.est_start_date is null    
        --and j.expected_cycle_time is null     
        --and j.expected_cycle_time_deviation is null
        --and (j.customer_name is null or j.customer_name = '')



-- find archived JobTemplate from fp_core_Jobs
 select j.[name], j.[desc], j.client_key, j.multiplier, j.id, j.is_open, j.is_archived, j.created_at, j.updated_at, j.deleted_at,
             (select FactoryId from dbo.JobTemplate where Id = j.parent_Id)   
        from dbo.fp_core_jobs as j
	    where j.is_template = 1 and j.is_archived = 1
        and j.parent_id in (select fp_core_id from dbo.JobTemplate)





-- insert live OperationTemplate form fp_core_jobs - first level
INSERT INTO dbo.OperationTemplate
	([Name], [Description], ClientKey, fp_core_id, CreatedAt, UpdatedAt, DeletedAt, JobTemplateId,
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, 
    EstmatedStartDate, PlannedEndDate, Multiplier, RunRateScale, RuntimeScale)

    select j.[name], j.[desc], j.client_key, j.id, j.created_at, j.updated_at, j.deleted_at, jt.Id,
         j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation,
            j.est_start_date, j.planned_end_date, j.multiplier, 
            Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end
        from dbo.fp_core_jobs as j
        inner join dbo.JobTemplate as jt
        on jt.fp_core_Id = j.parent_id
	    where j.is_template = 1 and j.is_archived = 0


-- insert live OperationTemplate form fp_core_jobs - second level
INSERT INTO dbo.OperationTemplate
	([Name], [Description], ClientKey, fp_core_id, CreatedAt, UpdatedAt, DeletedAt, JobTemplateId, [Group],
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, 
    EstmatedStartDate, PlannedEndDate, Multiplier, RunRateScale, RuntimeScale)

    select j.[name], j.[desc], j.client_key, j.id, j.created_at, j.updated_at, j.deleted_at, ot.JobTemplateId, ot.[Name],
         j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation,
            j.est_start_date, j.planned_end_date, j.multiplier, 
            Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end
        from  dbo.fp_core_jobs as j
		inner join dbo.OperationTemplate as ot
		on j.parent_id = ot.fp_core_Id
		where j.is_template = 1 and j.is_archived = 0
-- insert live OperationTemplate form fp_core_jobs - third or more level
INSERT INTO dbo.OperationTemplate
	([Name], [Description], ClientKey, fp_core_id, CreatedAt, UpdatedAt, DeletedAt, JobTemplateId, [Group],
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, 
    EstmatedStartDate, PlannedEndDate, Multiplier, RunRateScale, RuntimeScale)

    select j.[name], j.[desc], j.client_key, j.id, j.created_at, j.updated_at, j.deleted_at, ot.JobTemplateId, ot.[Name],
         j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation,
            j.est_start_date, j.planned_end_date, j.multiplier, 
            Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end
        from  dbo.fp_core_jobs as j
		inner join dbo.OperationTemplate as ot
		on j.parent_id = ot.fp_core_Id
		where j.is_template = 1 and j.is_archived = 0 
			and j.id not in (select fp_core_Id from dbo.OperationTemplate)


-- insert live Job
INSERT INTO dbo.Job
	([Name], [Description], ClientKey, CustomerName, Multiplier, fp_core_id, IsOpen, CreatedAt, UpdatedAt, DeletedAt, 
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, EstmatedStartDate, PlannedEndDate, RunRateScale, RuntimeScale,
    FactoryId)

    select j.[name], j.[desc], j.client_key, j.customer_name, j.multiplier, j.id, j.is_open, j.created_at, j.updated_at, j.deleted_at,
            j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation, j.est_start_date, j.planned_end_date,
           Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end,
           
            f.id as factoryId
        from dbo.fp_core_jobs as j
        inner join dbo.fp_core_Comtory as fpc
        on fpc.Id = j.data_source_id
        inner join dbo.Factory as f
        on f.FactoryKey = fpc.str_val
	    where j.is_template = 0 and j.is_archived = 0 
            and j.parent_id is null

-- insert live job created by job template
INSERT INTO dbo.Job
	([Name], [Description], ClientKey, CustomerName, Multiplier, fp_core_id, IsOpen, CreatedAt, UpdatedAt, DeletedAt, JobTemplateId,
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, EstmatedStartDate, PlannedEndDate, RunRateScale, RuntimeScale,
    FactoryId)

    select j.[name], j.[desc], j.client_key, j.customer_name, j.multiplier, j.id, j.is_open, j.created_at, j.updated_at, j.deleted_at, jt.id,
            j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation, j.est_start_date, j.planned_end_date,
           Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end,
           
            f.id as factoryId
        from dbo.fp_core_jobs as j
        inner join dbo.fp_core_Comtory as fpc
        on fpc.Id = j.data_source_id
        inner join dbo.Factory as f
        on f.FactoryKey = fpc.str_val
        inner join dbo.JobTemplate as jt
        on jt.fp_core_Id = j.parent_id
	    where j.is_template = 0 and j.is_archived = 0 

-- insert live Operation on first level
INSERT INTO dbo.Operation
	([Name], [Description], ClientKey, Multiplier, fp_core_id, IsOpen, CreatedAt, UpdatedAt, DeletedAt, 
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, EstmatedStartDate, PlannedEndDate, RunRateScale, RuntimeScale,
    JobId)

    select j.[name], j.[desc], j.client_key, j.multiplier, j.id, j.is_open, j.created_at, j.updated_at, j.deleted_at,
            j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation, j.est_start_date, j.planned_end_date,
           Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end,
           
           job.id as JobId
        from dbo.fp_core_jobs as j
        inner join dbo.Job as job
        on job.fp_core_Id = j.parent_id
	    where j.is_template = 0 and j.is_archived = 0

-- insert live Operation on 2nd or lower level
INSERT INTO dbo.Operation
	([Name], [Description], ClientKey, Multiplier, fp_core_id, IsOpen, CreatedAt, UpdatedAt, DeletedAt, 
    TargetCount, TargetRunrate, TargetRuntime, ExpectedCycleTime, ExpectedCycleTimeDeviation, EstmatedStartDate, PlannedEndDate, RunRateScale, RuntimeScale,
    JobId, [Group])

    select j.[name], j.[desc], j.client_key, j.multiplier, j.id, j.is_open, j.created_at, j.updated_at, j.deleted_at,
            j.target_count, j.target_runrate, j.target_runtime, j.expected_cycle_time, j.expected_cycle_time_deviation, j.est_start_date, j.planned_end_date,
           Case when j.runrate_scale_factor_id = 4 then 60 
                    Else Case when j.runrate_scale_factor_id = 5 then 3600 Else null end end,
                Case when j.runtime_scale_factor_id = 2  then 60 
                    Else Case when j.runtime_scale_factor_id = 3 then 3600
                        Else Case when j.runtime_scale_factor_id = 1 then 1 else null end end end,
           
           o.jobid as JobId, o.[name]
        from dbo.fp_core_jobs as j       
        inner join dbo.Operation as o
        on o.fp_core_Id = j.parent_id
	    where j.is_template = 0 and j.is_archived = 0 
            and j.id not in (select fp_core_Id from dbo.Operation)


-- insert notes 
INSERT INTO dbo.Note
	([Description], AttachedAt, CreatedAt, UpdatedAt, DeletedAt, MachineId)

    select fn.note, fn.attached_at, fn.created_at, fn.updated_at, fn.deleted_at, m.id 
		from dbo.fp_core_notes as fn
			inner join dbo.Machine as m
			on m.fp_core_Id = fn.data_source_id


-- insert OperationCategoy
INSERT INTO dbo.StatusCategory
	(FactoryId, [name], Color, CreatedAt, UpdatedAt, DeletedAt, fp_core_Id, [Status])

-- 1. children of id=1 : 3 rows
select 
	f.Id,
	foc.[name], foc.color, foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 1  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where  parent_id = 1 
-- 1.1 chilren of #1 : 0 row
select 
	f.Id,
	foc.[name], foc.color, foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 1  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 1) 

-- children of 1 but do not have any child
select 
	f.Id,
	foc.[name], foc.color, foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 1  
    from (select * from dbo.fp_core_operation_codes where id not in (select parent_id from dbo.fp_core_operation_codes where parent_id is not null))  as foc                        
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where  parent_id = 1 

-- 2. children of id=2 : 650 rows
select 
	f.Id,
	foc.[name], foc.color, foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where  parent_id = 2 

-- children of 2 but do not have any child
select 
	f.Id,
	foc.[name], foc.color, foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id not in (select parent_id from dbo.fp_core_operation_codes where parent_id is not null))  as foc                        
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where  parent_id = 2 

-- 2.01 chilren of #2 : 23 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) 
-- 2.02 chilren of #2.01 : 3 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) )
-- 2.03 chilren of #2.02 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) ))
-- 2.04 chilren of #2.03 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) )))
-- 2.05 chilren of #2.04 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) ))))
-- 2.06 chilren of #2.05 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) )))))
-- 2.07 chilren of #2.06 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) ))))))
-- 2.08 chilren of #2.07 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) )))))))
-- 2.09 chilren of #2.08 : 2 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) ))))))))
-- 2.10 chilren of #2.09 : 1 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) )))))))))
-- 2.11 chilren of #2.11 : 1 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) ))))))))))
-- 2.12 chilren of #2.11 : 1 rows
select 
	f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0  
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc            
        inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id in (select id from dbo.fp_core_operation_codes where parent_id = 2) )))))))))))

select 
    f.Id,
	foc.[name], foc.color, (select [name] from dbo.StatusCategory where fp_core_Id = foc.parent_id), foc.created_at, foc.updated_at,foc. deleted_at, foc.id, 0      
    from (select * from dbo.fp_core_operation_codes where id in (select parent_id from dbo.fp_core_operation_codes))  as foc
	inner join dbo.Factory as f
        on f.fp_core_Id = foc.data_source_id
    where foc.parent_id in (9217, 9218, 9219)



-- insert OperationCode
INSERT INTO dbo.StatusCode
	(CategoryId, [name], Color, CreatedAt, UpdatedAt, DeletedAt, fp_core_Id)

select 
	c.Id, 
	foc.[name], foc.color, foc.created_at, foc.updated_at,foc. deleted_at, foc.id  from dbo.fp_core_operation_codes as foc
	inner join dbo.StatusCategory as c
	on c.fp_core_Id = foc.parent_id


-- insert Code from Category
INSERT INTO dbo.StatusCode
	(CategoryId, [name], Color, CreatedAt, UpdatedAt, DeletedAt, fp_core_Id)

    select 
	    c.Id, 
	    c.[name], c.color, c.CreatedAt, c.UpdatedAt, c.DeletedAt, c.fp_core_Id 
        from dbo.StatusCategory as c


-- insert attachment for statusCode
INSERT dbo.Attachment
		(AttachmentType, AttachedAt, DetachedAt, CreatedAt, UpdatedAt, DeletedAt,
		MachineId, 
		CollectorId, CollecterName,
		AttachedOperationCodeId, fp_core_Id)

select 
	2, a.attached_at, a.detached_at, a.created_at, a.updated_at, a.deleted_at,
	c.MachineId, c.Id, c.[name],
	s.Id, a.id
	from dbo.fp_core_data_source_attachment as a
	inner join dbo.Collector as c
	on c.fp_data_source_Id = a.data_source_id
	inner join dbo.StatusCode as s
	on s.id = a.opcode_id

select 
	2, a.attached_at, a.detached_at, a.created_at, a.updated_at, a.deleted_at,
	m.Id, null, null,
	s.Id, a.id
	from dbo.fp_core_data_source_attachment as a
	inner join dbo.Machine as m
	on m.fp_core_Id = a.data_source_id
	inner join dbo.StatusCode as s
	on s.id = a.opcode_id

-- insert attachment for Job
INSERT dbo.Attachment
		(AttachmentType, AttachedAt, DetachedAt, CreatedAt, UpdatedAt, DeletedAt,
		MachineId, 
		CollectorId, CollecterName,
		AttachedJobId, fp_core_Id)

	select 		
		2, a.attached_at, a.detached_at, a.created_at, a.updated_at, a.deleted_at,
		c.Id, null, null,
		j.Id, a.Id
		from dbo.fp_core_data_source_attachment as a
		inner join dbo.Machine as c
		on c.fp_core_Id = a.data_source_id
		inner join dbo.Job as j
		on j.fp_core_Id = a.job_id
		where a.job_id is not null 

	select 		
		2, a.attached_at, a.detached_at, a.created_at, a.updated_at, a.deleted_at,
		c.MachineId, c.Id, c.[name],
		j.Id, a.Id
		from dbo.fp_core_data_source_attachment as a
		inner join dbo.Collector as c
		on c.fp_data_source_Id = a.data_source_id
		inner join dbo.Job as j
		on j.fp_core_Id = a.job_id
		where a.job_id is not null


-- related with Panel
INSERT dbo.FreePointProduct
	([Name], Alias, Code, [Description], Hide, fp_core_Id)

	select 		
		p.[name], p.alias, p.code, p.[description], p.hide, p.id
		from dbo.fp_core_Product  as p

INSERT dbo.PanelPreviewInfo
	(PanelTypeKey, PanelTier, PreviewImage, [Description], fp_core_Id)

	select 		
		p.panel_type_key, 
		case when p.tier_id is null then 0 else p.tier_id end, p.preview_image, p.preview_description, p.id
		from dbo.fp_core_panel_preview_info  as p

INSERT dbo.PanelType
	([Name], [Key], Category, Notes, [Description], MetaData, VersionMajor, VersionMinor, GlobalAccess, 
	CreatedAt, UpdatedAt, DeletedAt, fp_core_Id)

	select 		
		p.[name], p.[key], p.category_id, p.notes, p.[description], p.metadata, p.version_major, p.version_minor, p.global_access, 
		p.created_at, p.updated_at, p.deleted_at, p.id
		from dbo.fp_core_panel_types  as p


INSERT dbo.Layout
	([Name], [value], IsReporting, UserName,
	CompanyId,
	FreePointProductId,
	CreatedAt, UpdatedAt,  fp_core_Id)

	select 		
		l.[name], '', l.is_reporting, '',
		(select id from dbo.Company where l.company_id = fp_core_id),
		(select id from dbo.FreePointProduct where l.product_id = fp_core_id),
		l.created_at, l.updated_at, l.id
		from dbo.fp_core_layouts  as l


INSERT INTO dbo.Panel
	( [name], LayoutId, PanelTypeId, Placement, [Config], CreatedAt, UpdatedAt,  fp_core_Id)

    select 
	    c.[name], 
		(select l.id from dbo.Layout as l where l.fp_core_id = c.layout_id) as layoutId,
		(select pt.id from dbo.PanelType as pt where pt.fp_core_id = c.[type_id]),
		c.placement, c.[config], 
		c.Created_At, c.Updated_At, c.id 
        from dbo.fp_core_panels as c
		where c.layout_id in (select fp_core_id from dbo.layout)

-- insert ReportSubType
Insert Into dbo.ReportSubType
	([Key], DisplayName, DisplayOrder, CreatedAt, UpdatedAt, fp_core_id)
	select 
		[key], display_name, display_order, created_at, updated_at, id
		from dbo.fp_core_report_sub_types

-- insert ReportDefinition
Insert Into dbo.ReportDefinition
	([name], Suffix, Color, StaticResult, Divisor, TickRate, ScrapAdjust, ShiftBased, ActiveShiftBased, StartTime, EndTime,
	TimeStepSeconds, Offset, WindowSizeSeconds, 
	CreatedBy, UpdatedBy,
	FactoryId,
	ReportSubTypeId,
	ReportType,
	ChartType,
	CalculationWindowTransitionType,
	TickRateType,
	MathType,
	ValueType,
	ReportRangeType,
	RollingCalculationWindow,
	SemiFixedCalculationWindow, SemiFixedCalculationWindowOffset,
	CreatedAt, UpdatedAt, DeletedAt,
	fp_core_id)

	select 
		[name], suffix, color, static_result, divisor, tick_rate, scrap_adjust, shift_based, active_shift_based, start_time, end_time,
		time_step_seconds, offset, window_size_seconds,
		created_by, updated_by,
		(select id from dbo.Factory as f where f.fp_core_Id = company_id),
		sub_type_id,
		[type_id],
		chart_type_id,
		transition_type_id,
		tick_rate,
		math_type_id,
		value_type_id,
		report_range_type_id,
		rolling_cw_id,
		(select transition_type_id from dbo.fp_core_semi_fixed_calculation_windows as sfc
			where sfc.id = semi_fixed_cw_id),
		(select offset from dbo.fp_core_semi_fixed_calculation_windows as sfc
			where sfc.id = semi_fixed_cw_id),
		created_at, updated_at, deleted_at,
		id
		from dbo.fp_core_report_definitions;


-- insert into ReportDefinitionMachine
insert dbo.ReportDefinitionMachine
	(ReportDefinitionId, MachineId)
	select 
		rd.Id, m.Id
		from dbo.fp_core_report_definition_data_sources as fp
			inner join dbo.ReportDefinition as rd
			on rd.fp_core_id = fp.report_id
			inner join dbo.Machine as m
			on m.fp_core_Id = fp.data_source_id

-- insert into ReportDefinitionCollector
insert dbo.ReportDefinitionCollector
	(ReportDefinitionId, CollectorId)
	select 
		rd.Id, m.Id
		from dbo.fp_core_report_definition_data_sources as fp
			inner join dbo.ReportDefinition as rd
			on rd.fp_core_id = fp.report_id
			inner join dbo.Collector as m
			on m.fp_data_source_Id = fp.data_source_id

-- insert into ReportDefinitionJob
insert dbo.ReportDefinitionJob
	(ReportDefinitionId, JobId)
	select 
		rd.Id, m.Id
		from dbo.fp_core_report_definition_jobs as fp
			inner join dbo.ReportDefinition as rd
			on rd.fp_core_id = fp.report_id
			inner join dbo.Job as m
			on m.fp_core_Id = fp.job_id

-- insert into ReportDefinitionOperation
insert dbo.ReportDefinitionOperation
	(ReportDefinitionId, OperationId)
	select 
		rd.Id, m.Id
		from dbo.fp_core_report_definition_jobs as fp
			inner join dbo.ReportDefinition as rd
			on rd.fp_core_id = fp.report_id
			inner join dbo.Operation as m
			on m.fp_core_Id = fp.job_id

-- insert into ReportDefinitionStatusCode
insert dbo.ReportDefinitionStatusCode
	(ReportDefinitionId, StatusCodeId)
	select 
		rd.Id, m.Id
		from dbo.fp_core_report_definition_jobs as fp
			inner join dbo.ReportDefinition as rd
			on rd.fp_core_id = fp.report_id
			inner join dbo.StatusCode as m
			on m.fp_core_Id = fp.job_id