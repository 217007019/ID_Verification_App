using ID_Verification_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BackendlessAPI;
using BackendlessAPI.Async;
using BackendlessAPI.Exception;

namespace ID_Verification_App.Controllers


{
    public class AdminController : Controller
    {
      

        // GET: Admin
        //Admin Home
        //This goes hand in hand with RegisterUser model
        public ActionResult Index(RegisterUser ru)
        {
            return View();
           
        }

        public ActionResult Register()
        {
            return View();
        }

        //View for Registering a new user
        [HttpPost]
        public ActionResult Register(RegisterUser registerUser)
        {
            RegisterUser ru = new RegisterUser();

            ru.Position = registerUser.Position;
            ru.PersalNumber = registerUser.PersalNumber;
            ru.Title = registerUser.Title;
            ru.FirstName = registerUser.FirstName;
            ru.MiddleName = registerUser.MiddleName;
            ru.Surname = registerUser.Surname;
            ru.IDNumber = registerUser.IDNumber;
            ru.Gender = registerUser.Gender;
            ru.Rank = registerUser.Rank;
            ru.Province = registerUser.Province;
            ru.Station = registerUser.Station;
            ru.Email = registerUser.Email;
            ru.Password = registerUser.Password;
            ru.Confirm_Password = registerUser.Confirm_Password;
            ru.Picture = registerUser.Picture;

            RegisterUser savedUser = Backendless.Data.Of<RegisterUser>().Save(ru);

         

            return View();
        }

        //for showing all the officers

        public ActionResult List()
        {

            return View();
        }

        //for updating a officers info

        public ActionResult Update()
        {


            return View();
        }

        //for deleting a officer

        public ActionResult Delete()
        {

            return View();
        }
    }
}