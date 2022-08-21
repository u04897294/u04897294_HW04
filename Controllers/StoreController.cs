using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HW04BookStore.Models;

namespace HW04BookStore.Controllers
{
    public class StoreController : Controller
    {
      
        public ActionResult Home()
        {
            return View();
        }
       
        private static string UserUsername = "PaulAde";

        private static string UserPassword = "abc123";


        public static List<Business> Blist = new List<Business>();

        
        public static List<Romance> Rlist = new List<Romance>();

        
        public static List<Education> Edulist = new List<Education>();

        private void InitialiseStore()
        {
            if (StoreDb.Count() == 0)
            {
               
                Blist.Add(new Business(1,
                                           "Rich dad poor dad",
                                           "Robert Kyoasaki",
                                           "Business book about being financially wise",
                                           "2nd",
                                           345.68,
                                           "~/Content/Images/Business/richdad.png",
                                           new DateTime(2010, 2, 10),
                                           "business",
                                           "BDS3161484100",
                                           5 ));
                Blist.Add(new Business(2,
                                           "Shoe dog",
                                           "Phil Knight",
                                           "Nike founder discovers his potential forbusiness through running shoes",
                                           "2nd",
                                           400.50,
                                           "~/Content/Images/Business/shoedog.png",
                                           new DateTime(2008, 3, 23),
                                           "business",
                                           "BDS3161484100",
                                           5));
                Blist.Add(new Business(3,
                                        "Outliers",
                                        "Malcom Gladwell",
                                        "The story of success from someone who was not afraid to be an outlier",
                                        "1st",
                                        645.68,
                                        "~/Content/Images/Business/outliers.png",
                                        new DateTime(2006, 3, 12),
                                        "business",
                                        "BGS3163484190",
                                        5));

                
                Rlist.Add(new Romance(4,
                                           "Pride and Prejudice",
                                           "Jane Austen",
                                           "It’s a tale as old as time: boy meets girl; boy and girl bicker and declare their contempt for one another",
                                           "2nd",
                                           360.30,
                                           "~/Content/Images/Romance/prideandp.png",
                                           new DateTime(2016, 12, 14),
                                           "romance",
                                           "BDS3161484100",
                                           "50 Shades of grey"));
                Rlist.Add(new Romance(5,
                                           "The hating game",
                                           "Sally Thorne",
                                           "If you've ever carried a torch for a colleague (the scandal!) this novel will feel familiar ",
                                           "1st",
                                           200.00,
                                           "~/Content/Images/Romance/hgame.png",
                                           new DateTime(2000, 4, 22),
                                           "romance",
                                           "BDS3161484100",
                                           "The queen and king"));
                Rlist.Add(new Romance(6,
                                        "The Kiss Quotient",
                                        "Helen Hoang",
                                        "In this novel from Helen Hoang, Stella Lane is the genius mathematician who puts herself in remedial romance",
                                        "1nd",
                                        460.32,
                                        "~/Content/Images/Romance/kissq.png",
                                        new DateTime(2019, 5, 13),
                                        "romance",
                                        "BDS3161484100",
                                        "Nerdy lovers"));


                
                Edulist.Add(new Education(7,
                                           "English handbook and study guide",
                                           "Mark Harris",
                                           "A comprehensive english reference book for young scholars",
                                           "3rd",
                                           345.68,
                                           "~/Content/Images/Education/englishhb.png",
                                           new DateTime(2013, 2, 13),
                                           "education",
                                           "Cengage learning",
                                           "Paperback"));
                Edulist.Add(new Education(8,
                                           "Improving your c# skills",
                                           "John Callaway",
                                           "Solving mordern challenges with functional programming and test-driven techniques of C#",
                                           "1st",
                                           400.00,
                                           "~/Content/Images/Education/improvingc.png",
                                           new DateTime(2015, 8, 18),
                                          "education",
                                           "Learning path",
                                           "Paperback"));
               
                Edulist.Add(new Education(9,
                                          "Introduction to Human Resource Management",
                                          "Mou Charles",
                                          "A handbook for people who want to get to know more about resource management",
                                          "1nd",
                                          345.68,
                                          "~/Content/Images/Education/hrbook.png",
                                          new DateTime(2019, 12, 20),
                                         "education",
                                          "Dept learning",
                                          "Hardback"));
                //Populate the Store list
                StoreDb.AddRange(Blist); 
                StoreDb.AddRange(Rlist); 
                StoreDb.AddRange(Edulist); 

            }
            else
            {
                StoreDb.Clear();
                StoreDb.AddRange(Blist);
                StoreDb.AddRange(Rlist);
                StoreDb.AddRange(Edulist);

                return;
            }
        }

        //Declare My Store list
        public static List<Books> StoreDb = new List<Books>();

      
       
        public ActionResult Store()
        {
            InitialiseStore();

            return View(StoreDb);
        }



        //Index table

        [HttpGet]
        public ActionResult BusIndex()
        {
            return View(Blist);
        }



        [HttpGet]
        public ActionResult AddBusToStore()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult AddBusToStore(Business addBus)
        {
            Blist.Add(addBus);
            return RedirectToAction("Store");
        }




 


        [HttpGet]
        public ActionResult RomIndex()
        {
            return View(Rlist);
        }



        [HttpGet]
        public ActionResult AddRomToStore()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddRomToStore(Romance addRom)
        {
            Rlist.Add(addRom);
            return RedirectToAction("Store");
        }



    
        [HttpGet]
        public ActionResult EduIndex()
        {
            return View(Edulist);
        }



        [HttpGet]
        public ActionResult AddEduToStore()
        {
            return View();
        }


        [HttpPost]
        public ActionResult AddEduToStore(Education addEdu)
        {
            Edulist.Add(addEdu);
            return RedirectToAction("Store");
        }

  

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string Username, string Password)
        {
            if (Password == UserPassword && Username == UserUsername)
            {
                return RedirectToAction("AdminPortal");
            }
            else
            {
                ViewBag.Message = "YOU NEED PERMISSION TO ACCESS THIS LINK";
                return View();
            }

        }

        [HttpGet]
        public ActionResult AdminPortal()
        {
            return View();
        }

    }
}