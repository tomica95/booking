using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
	public class Room : BaseEntity
	{
		public string Name { get; set; }
		public string Description { get; set; }
		public double Space { get; set; }

		// Room has one RoomType
		public int RoomTypeId { get; set; }

		public virtual RoomType RoomType { get; set; }

		public virtual ICollection<RoomFacility> Facilities { get; set; }
	}
}