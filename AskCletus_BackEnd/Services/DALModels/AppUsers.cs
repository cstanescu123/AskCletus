using Identity_Back_End.Models;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.DALModels
{
    public class AppUsers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
        public Authority Authority { get; set; }
        public IEnumerable<Ingredients> Ingredients { get; set; }
        public IEnumerable<Todo> Todos { get; set; }
    }

    public enum Authority
    {
        Github
    }
}



