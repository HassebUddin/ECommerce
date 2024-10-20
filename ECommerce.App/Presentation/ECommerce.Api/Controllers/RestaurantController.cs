
using AutoMapper;
using ECommerce.Application.IRepositories.Web.DinnerTables;
using ECommerce.Application.IRepositories.Web.RestaurantBranchs;
using ECommerce.Application.IRepositories.Web.Restautrants;
using ECommerce.Domain.Entity.Web;
using ECommerce.Domain.ViewModel.Response.Web;
using ECommerce.Persistence.Context;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace ECommerce.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class RestaurantController : ControllerBase
    {

        private readonly AppDbContext _dbContext;


        private readonly IRestaurantWriteRepository _restaurantWriteRepository;  
        private readonly IRestaurantReadRepository _restaurantReadRepository;

        private readonly IRestaurantBranchWriteRepository _restaurantBranchWriteRepository;
        private readonly IRestaurantBranchReadRepository  _restaurantBranchReadRepository;


        private readonly IDinnerTableWriteRepository _dinnerTableWriteRepository;
        private readonly IDinnerTableReadRepository _dinnerTablReadRepository;


        private readonly IMapper _mapper;

        public RestaurantController(IRestaurantWriteRepository restaurantWriteRepository, IRestaurantReadRepository restaurantReadRepository,
            IMapper mapper, IRestaurantBranchWriteRepository restaurantBranchWriteRepository,
            IRestaurantBranchReadRepository restaurantBranchReadRepository, IDinnerTableReadRepository dinnerTablReadRepository, IDinnerTableWriteRepository dinnerTableWriteRepository, AppDbContext dbContext)
        {
            _restaurantWriteRepository = restaurantWriteRepository;
            _restaurantReadRepository = restaurantReadRepository;
            _mapper = mapper;
            _restaurantBranchWriteRepository = restaurantBranchWriteRepository;
            _restaurantBranchReadRepository = restaurantBranchReadRepository;
            _dinnerTablReadRepository = dinnerTablReadRepository;
            _dinnerTableWriteRepository = dinnerTableWriteRepository;
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> Restaurants()
        {
            return Ok((await _restaurantReadRepository.GetAll().ToListAsync()));
        }


        [HttpGet("{restaurantId}")]
        public async Task<IActionResult> Branches(string restaurantId)
        {
            var restautrantWithBracnches = await _restaurantReadRepository.Table.Include(x => x.RestaurantBranches)
                            .FirstOrDefaultAsync(x => x.Id == restaurantId);
            
            return Ok(_mapper.Map<List<RestaurantBranchResponse>>(restautrantWithBracnches?.RestaurantBranches));
        }

  
        [HttpGet("{branchId}")]
        public async Task<IActionResult> DinnerTables(string branchId)
        {
          


            var data = await (
              from rb in _dbContext.restaurantBranches
              join dt in _dbContext.dinnerTables on rb.Id equals dt.RestaurantBranchId
              join ts in _dbContext.timeSlots on dt.Id equals ts.DinnerTableId
              where dt.RestaurantBranchId == branchId && ts.ReservationDay >= DateTime.Now.Date
              orderby ts.Id, ts.MealType
              select new DinnerTableResponse()
              {
                  BranchId = rb.Id,
                  Capacity = dt.Capacity,
                  TableName = dt.TableName,
                  MealType = ts.MealType,
                  ReservationDay = ts.ReservationDay,
                  TableStatus = ts.TableStatus,
                  TimeSlotId = ts.Id,
                  UserEmailId = (from r in _dbContext.reservations
                                 join u in _dbContext.Users on r.UserId equals u.Id
                                 where r.TimeSlotId == ts.Id
                                 select u.Email.ToLower()).FirstOrDefault()
              }).ToListAsync();


            return Ok(data);


          

        }
  

        [HttpGet("{branchId}/{date}")]
        public async Task<IActionResult> DinnerTables(string branchId,DateTime date)
        {
            return Ok((await _restaurantBranchReadRepository.Table.Include(x => x.DinnerTables).ThenInclude(t=>t.TimeSlots)
                .FirstOrDefaultAsync(x => x.Id == branchId && x.DinnerTables.Any(x=>x.TimeSlots.Any(x=>x.ReservationDay==date)))));
        }
    }
}
