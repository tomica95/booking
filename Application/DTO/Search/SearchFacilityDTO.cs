using System;
using System.Collections.Generic;
using System.Text;
using Application.DTO.Pagination;

namespace Application.DTO.Search
{
	public class SearchFacilityDTO : PagedSearch
	{
		public string Name { get; set; }
	}
}