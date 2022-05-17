using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AskCletus_BackEnd.Services.DALModels
{
    public class UserBar
    {
        [Key]
        public int BarId { get; set; }
        public string strIngredient1 { get; set; }
        public string strIngredient2 { get; set; }
        public string strIngredient3 { get; set; }
        public string strIngredient4 { get; set; }
        public string strIngredient5 { get; set; }
        public string strIngredient6 { get; set; }
        public string strIngredient7 { get; set; }
        public string strIngredient8 { get; set; }
        public string strIngredient9 { get; set; }
        public string strIngredient10 { get; set; }
        public string strIngredient11 { get; set; }
        public string strIngredient12 { get; set; }
        public string strIngredient13 { get; set; }
        public string strIngredient14 { get; set; }
        public string strIngredient15 { get; set; }
        public string strIngredient16 { get; set; }
        public string strIngredient17 { get; set; }
        public string strIngredient18 { get; set; }
        public string strIngredient19 { get; set; }
        public string strIngredient20 { get; set; }
        public string strIngredient21 { get; set; }
        public string strIngredient22 { get; set; }
        public string strIngredient23 { get; set; }
        public string strIngredient24 { get; set; }
        public string strIngredient25 { get; set; }

        [ForeignKey("User")]
        public int UserId { get; set; }
    }
}
