using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.Models
{
    public class PostHistoryRequest
    {

        public int DrinkId { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }

    }
}
