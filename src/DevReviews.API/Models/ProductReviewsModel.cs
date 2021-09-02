using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevReviews.API.Models
{
    public class ProductReviewsModel
    {
        public ProductReviewsModel(int id, string author, int raiting, string comments, DateTime registereAt)
        {
            Id = id;
            Author = author;
            Raiting = raiting;
            Comments = comments;
            RegistereAt = registereAt;
        }

        public int Id { get; set; }
        public string Author { get; set; }
        public int Raiting { get; set; }
        public string Comments { get; set; }
        public DateTime RegistereAt { get; set; }
    }
}
