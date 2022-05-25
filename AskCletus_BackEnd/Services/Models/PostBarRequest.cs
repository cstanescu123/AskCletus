using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.Models
{
    public class PostBarRequest
    {
        public string Ingredient { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
