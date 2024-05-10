using OpenQA.Selenium.Chrome;

class Program
{
    static void Main(string[] args)
    {
        // Set the path to the Chrome Driver executable
        var chromeDriverPath = @"D:\selenium\chromedriver_win32\chromedriver.exe";
        ChromeDriverService chromeDriverService = ChromeDriverService.CreateDefaultService(chromeDriverPath);

        // Optional: Set any additional options for ChromeDriver if needed
        ChromeOptions chromeOptions = new ChromeOptions();
        chromeOptions.AddArgument("--start-maximized"); // Example: Start Chrome maximized

        // Create a new instance of ChromeDriver
        ChromeDriver driver = new ChromeDriver(chromeDriverService, chromeOptions);

        // Now you can use "driver" to interact with Chrome
        // For example:
        driver.Navigate().GoToUrl("https://www.getcalley.com/page-sitemap.xml");

        // Don't forget to close the driver when done
        driver.Quit();
    }
}




