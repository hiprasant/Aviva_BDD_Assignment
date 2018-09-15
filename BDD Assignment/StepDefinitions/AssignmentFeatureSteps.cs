using BDD_Assignment.Framework;
using BDD_Assignment.PageObject;
using NUnit.Framework;
using System;
using System.Linq;
using TechTalk.SpecFlow;

namespace BDD_Assignment.StepDefinitions
{
    [Binding]
    public class AssignmentFeatureSteps
    {
        public GooglePage google = new GooglePage();

        [Given(@"User launch google\.com")]
        public void GivenUserLaunchGoogle_Com()
        {
            MyDriver.driver.Navigate().GoToUrl("https://www.google.com");
            Console.WriteLine("Google site Opened.");
        }

        [When(@"User search for (.*) in Google")]
        public void WhenUserSearchForAvivaInGoogle(string searchText)
        {
            this.google.Search(searchText);
            Console.WriteLine(string.Format("{0} written in Search box and submitted", searchText));
        }

        [Then(@"User should see (.*) links in the first search page")]
        public void ThenUserShouldSeeLinksOfAvivaInTheFirstSearchPage(int numberOfLinks)
        {
            int NumberOfLinks = google.LinksList.Count();
            Console.WriteLine("Total number of links are : " + numberOfLinks);
            Assert.IsTrue(numberOfLinks == NumberOfLinks);
        }

        [Then(@"User should see the fifth link text")]
        public void ThenUserShouldSeeTheFifthLinkText()
        {
            Console.WriteLine("The text of fifth link is : " + google.LinksList[4].Text);
        }
    }
}


