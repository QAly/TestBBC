using BDDProject.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDProject.Settings
{
    public class ObjectRepository
    {
        public static IConfig config { get; set; }
        public static IWebDriver driver { get; set; }
    }
}
