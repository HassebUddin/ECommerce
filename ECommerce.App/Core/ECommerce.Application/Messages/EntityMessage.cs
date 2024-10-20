

using ECommerce.Application.Enums;

namespace ECommerce.Application.Messages
{
    public static class EntityMessage
    {
   

        //Successed Messaeg
        public static object Inserted(string propertyname) => new { Status = StatusCodeEnum.OK, Message = $"{propertyname} Insert Successed" };
        public static object Updated(string propertyname) => new { Status = StatusCodeEnum.OK, Message = $"{propertyname} Update Successed" };
        public static object Deleted(string propertyname) => new { Status = StatusCodeEnum.OK, Message = $"{propertyname} Delete Successed" };


        //Error Message
        public static string AlreadyExist(string propertyname) => $"{propertyname} is already taken";
        public static string NotFound(string propertyname) => $"{propertyname} is not found";


    }
}
