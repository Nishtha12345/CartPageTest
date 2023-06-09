using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace CodilityTest.Steps
{
    [Binding]
    public class Feature1StepDefinitions
    {

        [Given(@"I add four random items to my cart")]
        public void GivenIAddFourRandomItemsToMyCart()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Url = "https://cms.demo.katalon.com/";
            int count = 1;
            IList<IWebElement> el = driver.FindElements(By.XPath("//a[text()='Add to cart']"));
            for (int i = 0; i < el.Count; i++)
            // foreach (IWebElement ele in el)               
            {
                el[i].Click();
                count++;
            }

            // clicking teh crt 
            driver.FindElement(By.XPath("//a[text()='Cart']")).Click();

            // list of items 
            IList<IWebElement> listOfItems = driver.
                FindElements(By.XPath("//table[contains(@class,'woocommerce-cart')]//tbody//tr"));
            var size = listOfItems.Count;
            // Assert.Equals(size, 4);

            foreach (IWebElement ele in listOfItems)
            {

                IList<IWebElement> rowTds = ele.FindElements(By.TagName("td")); // all td 
                foreach (var td in rowTds)
                {
                    IWebElement el1 = td.FindElement(By.ClassName("product-price"));


                }

            }


        }





    

        [When(@"I view my cart")]
        public void WhenIViewMyCart()
        {
          //  throw new PendingStepException();
        }

        [Then(@"I find total four items listed in my cart")]
        public void ThenIFindTotalFourItemsListedInMyCart()
        {
            //throw new PendingStepException();
        }

        [When(@"I search for lowest price item")]
        public void WhenISearchForLowestPriceItem()
        {
           // throw new PendingStepException();
        }

        [When(@"I am able to remove the lowest price item from my cart")]
        public void WhenIAmAbleToRemoveTheLowestPriceItemFromMyCart()
        {
            //throw new PendingStepException();
        }

        [Then(@"I am able to verify three items in my cart")]
        public void ThenIAmAbleToVerifyThreeItemsInMyCart()
        {
          //  throw new PendingStepException();
        }
    }
}
