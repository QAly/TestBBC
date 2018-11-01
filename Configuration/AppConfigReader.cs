using BDDProject.Interfaces;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDProject.Configuration
{
    // appConfigReader has to implement the method  in the IConfig Interface also get all of its value from AppSettings
    public class AppConfigReader : IConfig
    {
        public string GetBBCURL()
        {
            return ConfigurationManager.AppSettings.Get("BBCURL");
        }

        public BrowserType GetBrowser()
        {
            string browser = ConfigurationManager.AppSettings.Get("Browser");
           return (BrowserType) Enum.Parse(typeof(BrowserType), browser);
            
        }
        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get("Username");


        }
        public string GetEmail()
        {
            return ConfigurationManager.AppSettings.Get("Email");


        }
        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get("Password");


        }
    }
}
