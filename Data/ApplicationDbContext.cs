using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Hosting;
using ShiftWorx.Models;


namespace ShiftWorx.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        // children of LifeCycleEntity (needed to add the condition to work with the query filter
        public DbSet<Company> Company { get; set; }
        public DbSet<Factory> Factory { get; set; }
        public DbSet<Machine> Machine { get; set; }
        public DbSet<Collector> Collector { get; set; }
        public DbSet<CollectorData> CollectorData { get; set; }
        public DbSet<JobTemplate> JobTemplate { get; set; }
        public DbSet<OperationTemplate> OperationTemplate { get; set; }
        public DbSet<Job> Job { get; set; }
        public DbSet<Operation> Operation { get; set; }
        public DbSet<StatusCategory> StatusCategory { get; set; }
        public DbSet<StatusCode> StatusCode { get; set; }
        public DbSet<Attachment> Attachment { get; set; }
        public DbSet<FreePointProduct> FreePointProduct { get; set; }
        public DbSet<Layout> Layout { get; set; }  
        public DbSet<Panel> Panel { get; set; }
        public DbSet<PanelType> PanelType { get; set; }
        public DbSet<PanelPreviewInfo> PanelPreviewInfo { get; set; }
        public DbSet<Note> Note { get; set; }
        public DbSet<ReportDefinition> ReportDefinition { get; set; }
        public DbSet<ReportSubType> ReportSubType { get; set; }

        //checklist
        public DbSet<Checklist> Checklist { get; set; }
        public DbSet<ChecklistItem> ChecklistItem { get; set; }
        public DbSet<ChecklistItemSelector> ChecklistItemSelector { get; set; }
        public DbSet<ChecklistItemSelectorOption> ChecklistItemSelectorOption { get; set; }
        public DbSet<ChecklistItemRule> ChecklistItemRule { get; set; }
        public DbSet<ChecklistSection> ChecklistSection { get; set; }
        public DbSet<ChecklistTemplate> ChecklistTemplate { get; set; }
        public DbSet<ChecklistTemplateItem> ChecklistTemplateItem { get; set; }
        public DbSet<ChecklistTemplateItemSelector> ChecklistTemplateItemSelector { get; set; }
        public DbSet<ChecklistTemplateItemSelectorOption> ChecklistTemplateItemSelectorOption { get; set; }
        public DbSet<ChecklistTemplateItemRule> ChecklistTemplateItemRule { get; set; }
        public DbSet<ChecklistTemplateSection> ChecklistTemplateSection { get; set; }
        public DbSet<Tag> Tag { get; set; }
        public DbSet<FpCoreUser> FpCoreUser { get; set; }
        public DbSet<FpCoreRole> FpCoreRole { get; set; }

        // junction entities
        public DbSet<ReportDefinitionCollector> ReportDefinitionCollector { get; set; }
        public DbSet<ReportDefinitionMachine> ReportDefinitionMachine { get; set; }
        public DbSet<ReportDefinitionJob> ReportDefinitionJob { get; set; }
        public DbSet<ReportDefinitionOperation> ReportDefinitionOperation { get; set; }
        public DbSet<ReportDefinitionStatusCode> ReportDefinitionStatusCode { get; set; }
        public DbSet<ChecklistTemplateFpCoreUser> ChecklistTemplateFpCoreUser { get; set; }
        public DbSet<ChecklistTemplateFpCoreRole> ChecklistTemplateFpCoreRole { get; set; }
        public DbSet<ChecklistTemplateJob> ChecklistTemplateJob { get; set; }
        public DbSet<ChecklistTemplateOperation> ChecklistTemplateOperation { get; set; }
        public DbSet<ChecklistTemplateMachine> ChecklistTemplateMachine { get; set; }
        public DbSet<ChecklistTemplateTag> ChecklistTemplateTag { get; set; }



        // to use CreatedAt, UpdatedAt and DeletedAt for LifeCycleEntity
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // junction entities for ReportDefinition
            builder.Entity<ReportDefinitionCollector>().HasKey(e => new { e.ReportDefinitionId, e.CollectorId });
            builder.Entity<ReportDefinitionMachine>().HasKey(e => new { e.ReportDefinitionId, e.MachineId });
            builder.Entity<ReportDefinitionJob>().HasKey(e => new { e.ReportDefinitionId, e.JobId });
            builder.Entity<ReportDefinitionOperation>().HasKey(e => new { e.ReportDefinitionId, e.OperationId });
            builder.Entity<ReportDefinitionStatusCode>().HasKey(e => new { e.ReportDefinitionId, e.StatusCodeId });

            // junction entities for checklistTemplate
            builder.Entity<ChecklistTemplateFpCoreUser>().HasKey(e => new { e.ChecklistTemplateId, e.FpCoreUserId });
            builder.Entity<ChecklistTemplateFpCoreRole>().HasKey(e => new { e.ChecklistTemplateId, e.FpCoreRoleId });
            builder.Entity<ChecklistTemplateJob>().HasKey(e => new { e.ChecklistTemplateId, e.JobId });
            builder.Entity<ChecklistTemplateOperation>().HasKey(e => new { e.ChecklistTemplateId, e.OperationId });
            builder.Entity<ChecklistTemplateMachine>().HasKey(e => new { e.ChecklistTemplateId, e.MachineId });
            builder.Entity<ChecklistTemplateTag>().HasKey(e => new { e.ChecklistTemplateId, e.TagId });

            builder.Entity<Company>().Property<DateTime?>("DeletedAt");
            builder.Entity<Company>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Factory>().Property<DateTime?>("DeletedAt");
            builder.Entity<Factory>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Machine>().Property<DateTime?>("DeletedAt");
            builder.Entity<Machine>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Collector>().Property<DateTime?>("DeletedAt");
            builder.Entity<Collector>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<JobTemplate>().Property<DateTime?>("DeletedAt");
            builder.Entity<JobTemplate>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<OperationTemplate>().Property<DateTime?>("DeletedAt");
            builder.Entity<OperationTemplate>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Job>().Property<DateTime?>("DeletedAt");
            builder.Entity<Job>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Operation>().Property<DateTime?>("DeletedAt");
            builder.Entity<Operation>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<StatusCategory>().Property<DateTime?>("DeletedAt");
            builder.Entity<StatusCategory>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<StatusCode>().Property<DateTime?>("DeletedAt");
            builder.Entity<StatusCode>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Note>().Property<DateTime?>("DeletedAt");
            builder.Entity<Note>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Attachment>().Property<DateTime?>("DeletedAt");
            builder.Entity<Attachment>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Layout>().Property<DateTime?>("DeletedAt");
            builder.Entity<Layout>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<Panel>().Property<DateTime?>("DeletedAt");
            builder.Entity<Panel>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<PanelType>().Property<DateTime?>("DeletedAt");
            builder.Entity<PanelType>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ReportDefinition>().Property<DateTime?>("DeletedAt");
            builder.Entity<ReportDefinition>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ReportSubType>().Property<DateTime?>("DeletedAt");
            builder.Entity<ReportSubType>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);

            // checklist
            builder.Entity<Checklist>().Property<DateTime?>("DeletedAt");
            builder.Entity<Checklist>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistItem>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistItem>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistItemSelector>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistItemSelector>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistItemSelectorOption>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistItemSelectorOption>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistItemRule>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistItemRule>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistSection>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistSection>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistTemplate>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistTemplate>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistTemplateItem>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistTemplateItem>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistTemplateItemSelector>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistTemplateItemSelector>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistTemplateItemSelectorOption>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistTemplateItemSelectorOption>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistTemplateItemRule>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistTemplateItemRule>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<ChecklistTemplateSection>().Property<DateTime?>("DeletedAt");
            builder.Entity<ChecklistTemplateSection>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);

            builder.Entity<Tag>().Property<DateTime?>("DeletedAt");
            builder.Entity<Tag>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<FpCoreUser>().Property<DateTime?>("DeletedAt");
            builder.Entity<FpCoreUser>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<FpCoreRole>().Property<DateTime?>("DeletedAt");
            builder.Entity<FpCoreRole>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
            builder.Entity<FileAttachment>().Property<DateTime?>("DeletedAt");
            builder.Entity<FileAttachment>().HasQueryFilter(m => EF.Property<DateTime?>(m, "DeletedAt") == null);
        }

        public override int SaveChanges()
        {
            OnBeforeSaving();          
            return base.SaveChanges();
        }
        public async Task<int> SaveChangesAsync()
        {
            OnBeforeSaving();
            return await base.SaveChangesAsync();
        }
        private void OnBeforeSaving()
        {
            foreach (var entry in ChangeTracker.Entries<LifeCycleEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        entry.CurrentValues["CreatedAt"] = DateTime.UtcNow;
                        entry.CurrentValues["UpdatedAt"] = DateTime.UtcNow;
                        break;
                    case EntityState.Modified:
                        entry.CurrentValues["UpdatedAt"] = DateTime.UtcNow;
                        break;
                    case EntityState.Deleted:
                        entry.State = EntityState.Modified;
                        entry.CurrentValues["DeletedAt"] = DateTime.UtcNow;
                        break;
                }
            }
        }
       
    }
}