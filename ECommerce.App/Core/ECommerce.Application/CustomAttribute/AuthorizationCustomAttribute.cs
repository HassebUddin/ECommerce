

using ECommerce.Application.Enums;

namespace ECommerce.Application.CustomAttribute
{
    public class AuthorizationCustomAttribute:Attribute
    {
        public string Menu { get; set; } = null!;
        public string Definition { get; set; } = null!;
        public ActionTypeEnum ActionType { get; set; } 

    }
}
