using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace DotnetSelenium
{
    public static class SeleniumCustomMethod
    {
        // 1. Method should get the locator
        // 2. Start getting the type of identifier
        // 3. Perform operation on the locator
        public static void ClickElement(this IWebElement locator)
        {
            locator.Click();
        }

        public static void SubmitElement(this IWebElement locator)
        {
            locator.Submit();
        }

        public static void EnterText(this IWebElement locator, string text)
        {
            locator.Clear();
            locator.SendKeys(text);
        }

        public static void SelectDropDownByText(this IWebElement locator, string text)
        {
            var selectElement = new SelectElement(locator);
            selectElement.SelectByText(text);
        }

        public static void SelectDropDownByValue(this IWebElement locator, string value)
        {
            var selectElement = new SelectElement(locator);
            selectElement.SelectByValue(value);
        }

        public static void MultiSelectElements(this IWebElement locator, string[] values)
        {
            SelectElement multiSelect = new SelectElement(locator);
            foreach (string value in values)
            {
                multiSelect.SelectByText(value);
            }
        }

        public static List<string> GetAllSelectedLists(this IWebElement locator)
        {
            List<string> options = new List<string>();
            SelectElement multiSelect = new SelectElement(locator);
            IList<IWebElement> selectedOptions = new SelectElement(locator).AllSelectedOptions;
            foreach (IWebElement option in selectedOptions)
            {
                options.Add(option.Text);
            }

            return options;
        }
    }
}
