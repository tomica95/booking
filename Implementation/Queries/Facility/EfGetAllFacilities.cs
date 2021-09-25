using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Application.DTO;
using Application.DTO.Pagination;
using Application.DTO.Search;
using Application.Queries.Facility;
using AutoMapper;
using DataAccess;
using Domain.Entities;
using Implementation.Commands;

namespace Implementation.Queries
{
	public class EfGetAllFacilities : BaseCommand, IGetAllFacilities
	{
		public EfGetAllFacilities(Context context, IMapper mapper) : base(context, mapper)
		{
		}

		public PagedResponse<FacilityDTO> Execute(SearchFacilityDTO dto)
		{
			var facilityQuery = this.Context.Facility.AsQueryable();

			if (!string.IsNullOrEmpty(dto.Name) || !string.IsNullOrWhiteSpace(dto.Name))
			{
				facilityQuery = Context.Facility.Where(f => f.Name.ToLower().Contains(dto.Name.ToLower()));
			}

			var skipCount = dto.PerPage * (dto.Page - 1);

			var facilities = Mapper.Map<List<FacilityDTO>>(facilityQuery.Skip(skipCount).Take(dto.PerPage).ToList());

			var reponse = new PagedResponse<FacilityDTO>
			{
				CurrentPage = dto.Page,
				ItemsPerPage = dto.PerPage,
				TotalCount = facilities.Count(),
				Items = facilities
			};

			return reponse;
		}
	}
}