using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
	public class Facility : BaseEntity
	{
		public string Name { get; set; }

		public string FacilityCode { get; set; }

		public virtual ICollection<RoomFacility> Rooms { get; set; }
	}
}