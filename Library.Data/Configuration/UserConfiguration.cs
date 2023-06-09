﻿using Library.Model.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.Property(u => u.Email)
                .HasMaxLength(30)
                .IsUnicode(false);

            builder.Property(u => u.Password)
                .HasMaxLength(50)
                .IsUnicode(false);

            builder.Property(u => u.StaffReaderID)
                .HasColumnName("StaffReader_Id");


            // relations

            builder.HasOne(sr => sr.StaffReader)
                .WithMany(u => u.Users);

        }
    }
}
