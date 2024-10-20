

using ECommerce.Application.Enums;

namespace ECommerce.Application.Messages
{
    public static class JwtTokenMessage
    {
        public static object ConfirmEmail => new { Status = StatusCodeEnum.OK, Message = "Please!! Conifrm Your Email" };


        //Error Message
        public static string TokenNotExpire => "Cannot Generate Jwt Token because it is not Expire.Pleaase try later";
        public static string InvalidToken => "Invalid Token";
      

    }
}
