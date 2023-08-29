using HotelAPI.Domain.Interfaces;
using HotelAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelAPI.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : GenericController<Hotel>
    {
        public HotelsController(IGenericUnitOfWork<Hotel> unit) : base(unit)
        {
        }
    }
}
