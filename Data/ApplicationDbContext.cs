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

     

        // to use CreatedAt, UpdatedAt and DeletedAt for LifeCycleEntity
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

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

            // junction entities for ReportDefinition
            builder.Entity<ReportDefinitionCollector>().HasKey(e => new { e.ReportDefinitionId, e.CollectorId });
            builder.Entity<ReportDefinitionMachine>().HasKey(e => new { e.ReportDefinitionId, e.MachineId });
            builder.Entity<ReportDefinitionJob>().HasKey(e => new { e.ReportDefinitionId, e.JobId });
            builder.Entity<ReportDefinitionOperation>().HasKey(e => new { e.ReportDefinitionId, e.OperationId });
            builder.Entity<ReportDefinitionStatusCode>().HasKey(e => new { e.ReportDefinitionId, e.StatusCodeId });
        }
        //var companies = JsonConvert.DeserializeObject<List<Company>>(File.ReadAllText("wwwroot/jsondata/json.json"));
        //foreach (var comp in companies)
        //{
        //    comp.Id = 0;
        //    comp.Factories.ToList().ForEach(a => { a.Id = 0; a.Machines.ToList().ForEach(a => a.Id = 0); a.Layouts.ToList().ForEach(a => { a.FreePointProduct = new(); a.Id = 0; a.Panels.ToList().ForEach(p => { p.Id = 0; p.PanelType = context.PanelType.Where(a => a.Id == (int)p.PanelTypeId).First(); }); }); });
        //    var testt = context.Company.Add(comp);
        //}
        //var test3 = context.SaveChanges();
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