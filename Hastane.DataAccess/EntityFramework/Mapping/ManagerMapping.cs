﻿using Hastane.Entities.Concrete;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Hastane.DataAccess.EntityFramework.Mapping
{
    public class ManagerMapping : BaseEntityTypeConfig<Manager>
    {
        public override void Configure(EntityTypeBuilder<Manager> builder)
        {

            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired(true);

            builder.HasMany(x => x.Personnels)
                .WithOne(x => x.Manager)
                .HasForeignKey(x => x.ManagerID)
                .OnDelete(DeleteBehavior.Restrict);

            base.Configure(builder);
        }
    }
}
