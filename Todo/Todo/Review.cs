using System;
using System.Collections.Generic;
namespace Todo
{

    public class Review : TodoSet
    {
        public List<Review> Reviews;
        private string review;

        public Review(string Review)
        {
            Reviews = new List<Review>();
            review = Review;
        }
        public void PrintReview()
        {
            Console.WriteLine(review);
        }
    }
}
