

using ECommerce.Domain.Entity.File;
using ECommerce.Domain.Entity.Web;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace ECommerce.Domain.Entity.Identity
{
    public class AppUser:IdentityUser<string>
    {
        public string FullName { get; set; } = null!;
        public string Gender { get; set; } = null!;
        public bool Status { get; set; } = true;
        public string Address { get; set; } = null!;

        public string Profession
        {
            get => Enum.GetName(typeof(Profession), ProfessionEnum);
            set => ProfessionEnum = Enum.TryParse<Profession>(value, true, out var profession) ? profession : default;
        }
        public string Country
        {
            get => Enum.GetName(typeof(Country), CountryEnum);
            set => CountryEnum = Enum.TryParse<Country>(value, true, out var country) ? country : default;
        }
        public string City
        {
            get => Enum.GetName(typeof(City), CityEnum);
            set => CityEnum = Enum.TryParse<City>(value, true, out var city) ? city : default;
        }


        public  ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
        public ICollection<UserImage> UserImages { get; set; } = null!;
        public ICollection<AppUserRole> UserRoles { get; set; } = null!;




        // Enum property for internal usage
        [NotMapped]
        public Profession ProfessionEnum { get; set; }
        [NotMapped]
        public Country CountryEnum { get; set; }
        [NotMapped]
        public City CityEnum { get; set; }


    }


    public enum Profession
    {
        DotNet,
        Devops,
        GraphicDesigner,
        UI_UX
    }
    public enum Country
    {
        USA,
        Canada,
        India,
        Australia,
        Germany,
        UnitedKingdom,
    }

    public enum City
    {
        NewYork,
        LosAngeles,
        Toronto,
        Vancouver,
    }
}
