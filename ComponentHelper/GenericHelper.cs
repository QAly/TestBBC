using BDDProject.Settings;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDDProject.ComponentHelper
{
    //Contain the common method which is used by other script
    public class GenericHelper
    { 
        //unique element
        public static bool isElementPresent(By Locator)
        {
            try
            {
                return ObjectRepository.driver.FindElements(Locator).Count == 1;
            }
            catch (Exception e)
            {
                Console.WriteLine("The error is  " +e);
                return false;
               

            }



        }
         

        public static IWebElement GetElement(By Locator)
        {

            if (isElementPresent(Locator)) {

                return ObjectRepository.driver.FindElement(Locator);
            }
            else
            {

                throw new NoSuchElementException("Element Not Found : " + Locator.ToString());
            }

        }
    }
}
