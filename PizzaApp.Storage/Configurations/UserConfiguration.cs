using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaApp.Storage.Models;

namespace PizzaApp.Storage.Configurations;

public sealed class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("Users");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Id)
            .ValueGeneratedOnAdd();

        builder.Property(x => x.Email)
            .IsRequired()
            .HasMaxLength(256);

        builder.HasIndex(x => x.Email)
            .IsUnique();

        builder.Property(x => x.Telephone)
            .IsRequired()
            .HasMaxLength(32);
    }
}