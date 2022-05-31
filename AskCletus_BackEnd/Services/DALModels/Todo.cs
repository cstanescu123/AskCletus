using AskCletus_BackEnd.Services.DALModels;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Identity_Back_End.Models
{
    public class Todo
    {
        [Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
        public AppUser User { get; set; }
    }
}
