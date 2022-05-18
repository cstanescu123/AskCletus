using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.DALModels
{
    public class DrinkHistory
    {
        [Key]
        public int HistoryId { get; set; }
        public int DrinkId { get; set; }
        public DateTime Date { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
