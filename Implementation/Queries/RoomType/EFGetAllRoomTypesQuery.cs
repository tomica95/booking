using Application.DTO;
using Application.DTO.Search;
using Application.Queries.RoomType;
using AutoMapper;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Implementation.Queries.RoomType
{
	public class EFGetAllRoomTypesQuery : IGetAllRoomTypes
	{
		private readonly Context _context;
		private readonly IMapper _mapper;

		public EFGetAllRoomTypesQuery(Context context, IMapper mapper)
		{
			_context = context;
			_mapper = mapper;
		}

		public int Id => 2;

		public string Name => "Get Room Types";

		public RoomTypeDTO Execute(SearchRoomTypeDTO search)
		{
			var rolesQuery = _context.RoomTypes.AsQueryable();

			if (!string.IsNullOrEmpty(search.Name) || !string.IsNullOrWhiteSpace(search.Name))
			{
				rolesQuery = rolesQuery.Where(r => r.Name.ToLower().Contains(search.Name.ToLower()));
			}

			return _mapper.Map<RoomTypeDTO>(rolesQuery);

		}
	}
}
