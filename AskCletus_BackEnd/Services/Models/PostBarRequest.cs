using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.Models
{
    public class PostBarRequest
    {
        public string Ingredients { get; set; }
        public int UserId { get; set; }
    }
}
