using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.DALModels
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
<<<<<<< HEAD

     //   [ForeignKey("UserBar")]
=======
>>>>>>> 33f287fc13673d857c59251e7aea65247930076e
        public IEnumerable<UserBar> Ingredients{ get; set; }
    }
}
