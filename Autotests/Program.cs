using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Autotests
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.demoqa.com";
            driver.Url = "https://www.google.com";
            driver.Url = "https://www.yandex.ru";
            driver.Quit();
        }
    }
}
