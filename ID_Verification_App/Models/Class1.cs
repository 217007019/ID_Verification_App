using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ID_Verification_App.Models
{
    public class BackendlessInit
    {
        private static readonly string APPLICATIONID = "0514E5DE-8B8B-7C5B-FF77-19AEC45EF900";
        private static readonly string APIKEY = "015E84B2-0E87-4282-855F-58BCFC43AB5B";

        public static void Init()
        {
            if (APPLICATIONID.Length == 0 || APIKEY.Length == 0)
                throw new Exception("Please make sure to enter you Application ID and API key in BackendlessInit.cs.");

            BackendlessAPI.Backendless.InitApp(APPLICATIONID, APIKEY);
        }
    }
}