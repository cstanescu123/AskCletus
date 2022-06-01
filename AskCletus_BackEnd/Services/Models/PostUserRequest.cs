using AskCletus_BackEnd.Services.DALModels;
using System.Collections.Generic;

namespace AskCletus_BackEnd.Services.Models
{
    public class PostUserRequest
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }


    }
}
