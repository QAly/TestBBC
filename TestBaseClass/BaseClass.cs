using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using BDDProject.Configuration;
using BDDProject.CustomException;
using BDDProject.Settings;
using NUnit.Framework;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace BDDProject.TestBaseClass
{
    public  class BaseClass

    {
        private static ExtentTest featureName;
        private static ExtentTest scenario;
        private static ExtentReports extent;
       



        //create the instance of firefofx driver and launch firefox browser
        private static IWebDriver GetFirefoxDriver()
        {
            IWebDriver driver = new FirefoxDriver();
           
            driver.Manage().Window.Maximize();
            
            return driver;

        }
        //create the instance of chrome and launch chrome browser
        private static IWebDriver GetChromeDriver()
        {
            IWebDriver driver = new ChromeDriver();
            
            driver.Manage().Window.Maximize();
           
            return driver;


        }
        //create the instance of IE and launch Iternet Explorer browser
        private static IWebDriver GetIEDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
          
            driver.Manage().Window.Maximize();
           
            return driver;


        }//Iterate and call the method above based on the browsertype
        [SetUp]
        public static void InitWebDriver()
        {
            ObjectRepository.config = new AppConfigReader();

            switch (ObjectRepository.config.GetBrowser())
            {
                case BrowserType.Firefox:
                    ObjectRepository.driver = GetFirefoxDriver();
                    break;

                case BrowserType.Chrome:
                    ObjectRepository.driver = GetChromeDriver();

                    break;

                case BrowserType.IE:
                    ObjectRepository.driver = GetIEDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver Not Found: " + ObjectRepository.config.GetBrowser().ToString());




            }

        }//Initialise the extent report within the project path so the report will be visible where the project is located
        [BeforeTestRun]
        public static void InitialiseReport()
        {
            string pth = System.Reflection.Assembly.GetCallingAssembly().CodeBase;
            string actualPath = pth.Substring(0, pth.LastIndexOf("bin"));
            string projectPath = new Uri(actualPath).LocalPath;
            string reportPath = projectPath + "ExtentReport.html ";
          
            var htmlReporter = new ExtentHtmlReporter(reportPath);
            htmlReporter.Configuration().Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent = new ExtentReports();
            extent.AttachReporter(htmlReporter);

           
        }
        //generate report
        [AfterTestRun]
        public static void TearDownReport()
        {
            extent.Flush();
            ObjectRepository.driver.Quit();
            
        }
        //this will display the name of the Feature that is being executed in the report
        [BeforeFeature]
        public static void BeforeFeature()
        {

            featureName = extent.CreateTest<Feature>(FeatureContext.Current.FeatureInfo.Title);


        }
        // This give the name of the scenario that is being executed in the report 
       [BeforeScenario]
        public static void BeforeScenario()
        {
             scenario = featureName.CreateNode<Scenario>(ScenarioContext.Current.ScenarioInfo.Title);



        }
        // this  will the method (Given, When, And,Then) of the step and the name of that step in the report
        [AfterStep]
        public static void InSertReportingSteps()
        {
            var stepType = ScenarioStepContext.Current.StepInfo.StepDefinitionType.ToString();

           //PropertyInfo pInfo = typeof(ScenarioContext).GetProperty("TestStatus", BindingFlags.Instance | BindingFlags.NonPublic);
          // MethodInfo getter = pInfo.GetGetMethod(nonPublic: true);
           // object TestResult =  getter.Invoke(ScenarioContext.Current, null);


            //This will run when the test step excetued pass
            if (ScenarioContext.Current.TestError == null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text);
                }
                if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text);
                }
                if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text);
                }

                if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text);
                }



            }
            //this will run if the test step executed fail
            else if (ScenarioContext.Current.TestError != null)
            {
                if (stepType == "Given")
                {
                    scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                }
                if (stepType == "And")
                {
                    scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                }
                if (stepType == "When")
                {
                    scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.InnerException);
                }

                if (stepType == "Then")
                {
                    scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Fail(ScenarioContext.Current.TestError.Message); ;
                }

            }
            }
            
            //else if (TestResult.ToString() == "StepDefinitionPending")
           // {
            //    if (stepType == "Given")
            //    {
              //      scenario.CreateNode<Given>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
             //   }
                //else if (stepType == "And")
                //{
               //     scenario.CreateNode<And>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
               // }
               // else if (stepType == "When")
               // {
               //     scenario.CreateNode<When>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
               // }
               // else if (stepType == "Then")
               // {
               //     scenario.CreateNode<Then>(ScenarioStepContext.Current.StepInfo.Text).Skip("Step Definition Pending");
               // }

           // }



        }
        
      





    }
    
    

