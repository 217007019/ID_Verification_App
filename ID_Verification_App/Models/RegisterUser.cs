using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BackendlessAPI;
using BackendlessAPI.Async;
using BackendlessAPI.Exception;
using VisioForge.Shared.MediaFoundation.OPM;
using BackendlessAPI;
using BackendlessAPI.Async;
using BackendlessAPI.Exception;

namespace ID_Verification_App.Models
{
    public class RegisterUser
    {
        //class for registering new users

        public string objectId;

        public string Position { get; set; }

        public string PersalNumber { get; set; }

        public string Title { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string Surname { get; set; }

        public string IDNumber { get; set; }

        public string Gender { get; set; }

        public string Rank { get; set; }

        public string Province { get; set; }

        public string Location { get; set; }

        public string Station { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string Confirm_Password { get; set; }

        public string Picture { get; set; }


    }

    //Backendless.InitApp(0514E5DE - 8B8B - 7C5B - FF77 - 19AEC45EF900, 015E84B2 - 0E87 - 4282 - 855F - 58BCFC43AB5B);

    
    
    
}