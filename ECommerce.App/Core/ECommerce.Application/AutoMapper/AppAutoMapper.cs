

using AutoMapper;
using AutoMapper.Execution;
using ECommerce.Domain.Entity.Identity;
using ECommerce.Domain.Entity.Web;
using ECommerce.Domain.ViewModel.Request.Account;
using ECommerce.Domain.ViewModel.Request.Identity.Role;
using ECommerce.Domain.ViewModel.Request.Identity.User;
using ECommerce.Domain.ViewModel.Response.Identity.Role;
using ECommerce.Domain.ViewModel.Response.Identity.User;
using ECommerce.Domain.ViewModel.Response.Web;

namespace ECommerce.Application.AutoMapper
{
    public class AppAutoMapper:Profile
    {
        public AppAutoMapper()
        {
            //AppRole AutoMapper
            CreateMap<RoleCreateRequest, AppRole>().
                ForMember(des => des.Id, x => x.MapFrom(src => Guid.NewGuid().ToString()))
                .ReverseMap();

            CreateMap<RoleUpdateRequest, AppRole>().ReverseMap();
            CreateMap<RoleResponse, AppRole>().ReverseMap();

            //AppUser AutoMapper
            CreateMap<UserCreateRequest, AppUser>().
                ForMember(des => des.Id, x => x.MapFrom(src => Guid.NewGuid().ToString())).
                ForMember(src=>src.UserName,x=>x.MapFrom(des=>des.Email))
                .ReverseMap();

            CreateMap<UserUpdateRequest, AppUser>().ForMember(src => src.UserName, x => x.MapFrom(des => des.Email)).ReverseMap();
            CreateMap<UserResponse, AppUser>().ReverseMap();


            //Account AutoMapper
            CreateMap<RegisterRequest, AppUser>().ForMember(src => src.UserName, x => x.MapFrom(des => des.Email))
                .ForMember(des => des.Id, x => x.MapFrom(src=>Guid.NewGuid().ToString())).ReverseMap();
         
            CreateMap<LoginRequest, AppUser>().ForMember(src => src.UserName, x => x.MapFrom(des => des.Email)).ReverseMap();
            CreateMap<ForgetPasswordRequest, AppUser>().ForMember(src => src.UserName, x => x.MapFrom(des => des.Email)).ReverseMap();
            CreateMap<ResetPasswordRequest, AppUser>().ReverseMap();
            CreateMap<VerifyTwoFactorTokenRequest, AppUser>().ReverseMap();



            //WEB

            //Restautrant
            CreateMap<Resturant, RestaurantBranchResponse>().ReverseMap();

            //RestuaraantBranches
            CreateMap<RestaurantBranch, RestaurantBranchResponse>().ReverseMap();



            //DinnerTable
         


        }
    }
}
