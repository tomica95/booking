using System;
using System.Collections.Generic;
using System.Text;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.Configs
{
	public class FacilityConfig : IEntityTypeConfiguration<Facility>
	{
		public void Configure(EntityTypeBuilder<Facility> builder)
		{
			builder.HasIndex(r => r.Name)
				.IsUnique();

			builder.Property(r => r.Name)
				.IsRequired();

			builder.Property(r => r.FacilityCode)
				.IsRequired();

			builder.HasMany(rf => rf.Rooms)
				.WithOne(rf => rf.Facility)
				.HasForeignKey(rf => rf.FacilityId)
				.OnDelete(DeleteBehavior.Restrict);
		}
	}
}