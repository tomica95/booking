﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
	public class FacilityDTO
	{
		public int Id { get; set; }
		public string Name { get; set; }

		public string FacilityCode { get; set; }

		public virtual ICollection<RoomDTO> Rooms { get; set; } = new List<RoomDTO>();
	}
}