using System;
using System.Collections.Generic;
using System.Text;
using Application.CommandHendler;
using Application.DTO;

namespace Application.Commands.Facility
{
	public interface ICreateFacility : ICommand<FacilityDTO>
	{
	}
}