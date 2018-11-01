using BDDProject.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDProject.Interfaces
{
    //method that appConfigReader will implement
    public interface IConfig
    {
      BrowserType GetBrowser();
          string GetBBCURL();
          string GetUsername();
          string GetEmail();
          string GetPassword();



    }
}
