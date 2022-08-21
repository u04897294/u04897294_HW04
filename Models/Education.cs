using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04BookStore.Models
{
    public class Education : Books
    {
       
        public string _Publisher; 
        public string _BookFormat; 


        //Default Constructors 

        public Education() : base()
        {

        }

        public Education(int ID, string Name, string Author, string Description, string Edition, double Price, string Image, DateTime RealeaseDate, string Genre, string Publisher, string BookFormat) : base(ID, Name, Author, Description, Edition, Price, Image, RealeaseDate, Genre)
        {
            _Publisher = Publisher;
            _BookFormat = BookFormat;
        }


        

        public override string BookInfo()
        {
            return "The Following bwas published by " + this.Publisher + ". \n " +
                   "The book comes in a " + this._BookFormat + " format.";
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
       

        public string Publisher { get { return _Publisher; } set { _Publisher = value; } }

        public string BookFormat { get { return _BookFormat; } set { _BookFormat = value; } }

    }
}
