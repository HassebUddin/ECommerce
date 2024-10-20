

using ECommerce.Application.Enums;

namespace ECommerce.Application.Messages
{
    public static class AccountMessage
    {
        //email message
        public static object ConfirmEmail => new {Status=StatusCodeEnum.OK,Message= "Please!! Conifrm Your Email" };

    

        //Error message
        public static string TryAntotherPassword => "Password is not exist";
        public static string TryAntotherEmail => "Email is not exist ";



        //OTP Message
        public static object SendOTP => new { Status = StatusCodeEnum.OK, Message = "OTP is send your email" };
        public static string InvlaidOTP => "Invalid OTP";


        //Succcessed Message
        public static string LoginSuccessed => "Login Successed";
        public static string OTPVerfiySuccessed => "OTP Verify Successed";
        public static object ResetPasswordSuccessed => new {Status=StatusCodeEnum.OK,Message= "Password  Reset Successed" };
        public static object EmailConfirmSuccessed => new { Status =StatusCodeEnum.OK, Message = "Email  Confirm Successed" };




    }
}
