using System;
using System.Collections.Generic;
using System.Text;
using Application.DTO;
using AutoMapper;
using Domain.Entities;

namespace Implementation.Profiles
{
	public class FacilityProfile : Profile
	{
		public FacilityProfile()
		{
			CreateMap<Facility, FacilityDTO>();
			CreateMap<FacilityDTO, Facility>();
		}
	}
}