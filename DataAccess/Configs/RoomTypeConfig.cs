using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Configs
{
	public class RoomTypeConfig : IEntityTypeConfiguration<RoomType>
	{
		public void Configure(EntityTypeBuilder<RoomType> builder)
		{
			builder.HasIndex(b => b.Name)
				.IsUnique();

			builder.Property(b => b.Name)
				.IsRequired()
				.HasMaxLength(50);

		}
	}
}
