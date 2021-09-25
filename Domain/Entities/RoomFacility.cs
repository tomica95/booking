using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
	public class RoomFacility
	{
		public int RoomId { get; set; }

		public int FacilityId { get; set; }

		public virtual Room Room { get; set; }

		public virtual Facility Facility { get; set; }
	}
}