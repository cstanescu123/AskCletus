using System.ComponentModel.DataAnnotations;

namespace AskCletus_BackEnd.Services.DALModels
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
    }
}
