using System;
using System.Collections.Generic;
using System.Text;
using Application.Commands.Facility;
using Application.DTO;
using AutoMapper;
using DataAccess;
using Domain.Entities;

namespace Implementation.Commands.FacilityCommands
{
	public class EfCreateFacility : BaseCommand, ICreateFacility
	{
		public EfCreateFacility(Context context, IMapper mapper) : base(context, mapper)
		{
		}

		public void Execute(FacilityDTO request)
		{
			var facility = Mapper.Map<Facility>(request);

			facility.Rooms = null;

			Context.Facility.Add(facility);

			Context.SaveChanges();
		}
	}
}