using Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain.Data.EntityTypeConfigurations
{
    public class WorkerTypeEntityConfiguration : IEntityTypeConfiguration<Worker>
    {
        public void Configure(EntityTypeBuilder<Worker> builder)
        {
            builder.ToTable("Workers");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired();
            builder
            .HasOne(x => x.Shift).WithMany(x => x.Workers).HasForeignKey(x => x.ShiftId);
        }
    }
}