using System;
using System.Collections.Generic;
using System.Text;
using Application.CommandHendler;
using Application.DTO;
using Application.DTO.Pagination;
using Application.DTO.Search;

namespace Application.Queries.Facility
{
	public interface IGetAllFacilities : IQuery<SearchFacilityDTO, PagedResponse<FacilityDTO>>
	{
	}
}