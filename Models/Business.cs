using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04BookStore.Models
{
    public class Business : Books
    {

     
        public string _BusinessBookISBN; 
        public int _StarRating;


        
        public Business() : base()
        {

        }

        public Business(int ID, string Name, string Author, string Description, string Edition, double Price, string Image, DateTime RealeaseDate, string Genre, string BusinessBookISBN, int StarRating) : base(ID, Name, Author, Description, Edition, Price, Image, RealeaseDate, Genre)
        {
            _BusinessBookISBN = BusinessBookISBN;
            _StarRating = StarRating;
        }


        

        public override string BookInfo()
        {
            return "The Following book with " + this.Edition + " Edition/s" + ". \n " +
                   "The book has a rating of " + this._StarRating.ToString() + " stars.";
        }

        public override double PriceIncVat()
        {
            return this._Price + Math.Round(this._Price * baseVat, 2);

        }

        public override string BookReviews()
        {

            return "This book has " + Convert.ToString(CalculateReviews()) + " reviews.";
        }


        private int CalculateReviews()
        {
            Random reviews = new Random();
            reviews.Next(0, 10);
            return reviews.Next();
        }

        public override string BookQuote()
        {

            return this.Description;
        }

        public override string BookAuthor()
        {
            return this.Author;
        }

        public override string BookPages()
        {
            return "This book has " + Convert.ToString(CalculateBookPages()) + " pages.";

        }
        private int CalculateBookPages()
        {
            Random r = new Random();
            int rInt = r.Next(200, 500);
            return r.Next(200, 500);
        }


        public string BusinessBookISBN { get { return _BusinessBookISBN; } set { _BusinessBookISBN = value; } }

        public int StarRating { get { return _StarRating; } set { _StarRating = value; } }

    }
}
