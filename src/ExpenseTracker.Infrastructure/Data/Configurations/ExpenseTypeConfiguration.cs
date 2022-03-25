using ExpenseTracker.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ExpenseTracker.Infrastructure.Data.Configurations
{
    public class ExpenseTypeConfiguration : IEntityTypeConfiguration<ExpenseType>
    {
        public void Configure(EntityTypeBuilder<ExpenseType> builder)
        {
            builder.HasKey(et => et.Id);

            builder.Property(et => et.Name)
                .HasMaxLength(30)
                .IsRequired();

            builder.HasMany(et => et.Expenses)
                .WithOne(e => e.ExpsenseType);

            builder.HasIndex(et => et.Name)
                .IsUnique();
        }
    }
}
