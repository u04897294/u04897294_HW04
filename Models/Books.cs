using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HW04BookStore.Models
{
    public abstract class Books
    {
       

        public List<Business> Blist = new List<Business>();
        public List<Romance> Rlist = new List<Romance>();

        public int _Id;
        public string _Name;
        public string _Author;
        public string _Description;
        public string _Edition;
        public double _Price;
        public string _Image;
        public DateTime _ReleaseDate;
        public double baseVat = 0.15;
        public string _Genre; //This will be used in our view using lambda to determine what genre is a book 


        
        public Books()
        {

        }

        
        public Books(int ID, string Name, string Author, string Description, string Edition, double Price, string Image, DateTime RealeaseDate, string Genre)
        {
            _Id = ID;
            _Name = Name;
            _Author = Author;
            _Description = Description;
            _Edition = Edition;
            _Price = Price;
            _Image = Image;
            _ReleaseDate = RealeaseDate;
            _Genre = Genre;
        }


        

        public abstract string BookInfo();

        public abstract string BookReviews();

        public abstract double PriceIncVat();

        public abstract string BookQuote();

        public abstract string BookAuthor();

        public abstract string BookPages();

       

        public int ID { get { return _Id; } set { _Id = value; } }

        public string Name { get { return _Name; } set { _Name = value; } }
        public string Author { get { return _Author; } set { _Author = value; } }

        public string Description { get { return _Description; } set { _Description = value; } }

        public string Edition { get { return _Edition; } set { _Edition = value; } }

        public double Price { get { return _Price; } set { _Price = value; } }

        public string Image { get { return _Image; } set { _Image = value; } }

        public DateTime ReleaseDate { get { return _ReleaseDate; } set { _ReleaseDate = value; } }

    }
}
