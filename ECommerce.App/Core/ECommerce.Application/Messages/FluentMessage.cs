
using ECommerce.Application.Enums;

namespace ECommerce.Application.Messages
{
    public static class FluentMessage
    {

        public static string Required(string propertyname)
            => $"{propertyname} is required";
       
      

        public static string EmailAddress()
            => "Email is not correct format";

    }
}
