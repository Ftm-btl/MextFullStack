using MextFullStackSaaS.Domain.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MextFullStackSaaS.Infrastructure.Persistence.Configurations
{
    public class UserBalanceHistoryConfiguration : IEntityTypeConfiguration<UserBalanceHistory>
    {
        public void Configure(EntityTypeBuilder<UserBalanceHistory> builder)
        {
            //ID
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            //Credits
            builder.Property(x => x.CurrentCredits)
                .IsRequired();

            //PreviousCredits
            builder.Property(x => x.PreviousCredits)
                .IsRequired();

            //Amoud
            builder.Property(x => x.Amount)
               .IsRequired();

            //Type
            builder.Property(x => x.Type)
              .HasConversion<int>()
              .IsRequired();

            //Common Properties

            // CreatedDate
            builder.Property(x => x.CreatedOn).IsRequired();

            // CreatedByUserId
            builder.Property(user => user.CreatedByUserId)
                .HasMaxLength(200)
                .IsRequired();

            // ModifiedDate
            builder.Property(user => user.ModifiedOn)
                .IsRequired(false);

            // ModifiedByUserId
            builder.Property(user => user.ModifiedByUserId)
                .HasMaxLength(100)
                .IsRequired(false);


            //Relationships
            //builder.HasOne<User>(x => x.User)
            //    .WithMany(u => u.Orders)
            //    .HasForeignKey(x => x.UserId);

            //builder.HasMany<UserBalanceHistory>(x => x.)
            //    .WithOne(h => h.UserBalance)
            //    .HasForeignKey(h => h.UserBalanceId);

            builder.ToTable("UserBalanceHistories");
        }
    }
}
