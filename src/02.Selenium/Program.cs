using OpenQA.Selenium;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Exercise.Selenium;

public class Program
{
	public static void Main()
    {
		int[] accurateDatabaseIds = new int[] { 253477, 263529 };
        string startDate = "01/10/2022";
		string endDate = "15/10/2022";

        var edgeDriver = new EdgeDriver();

		try
		{
			edgeDriver.Manage().Window.Maximize();

			edgeDriver.Url = "https://account.accurate.id/";

			#region Login to Accurate
			var element_j_username = edgeDriver.FindElement(By.Name("j_username"));
			element_j_username.SendKeys("indonesia.dmssupport@upfield.com");

			var element_j_password = edgeDriver.FindElement(By.Name("j_password"));
			element_j_password.SendKeys("Blueband@12345");

			element_j_password.Submit();
			#endregion

			#region Choose and Go to Accurate Databse/Distributor Home Page
			foreach (var accurateDatabaseId in accurateDatabaseIds)
			{
				var distributor_URL = $"https://public.accurate.id/accurate/open.do?id={accurateDatabaseId}"; // example: https://public.accurate.id/accurate/open.do?id=253477

                edgeDriver.Url = distributor_URL;

				SpinWait.SpinUntil(() => edgeDriver.Url != distributor_URL);

				var elementTabBerita = new WebDriverWait(edgeDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[@href='#' and @title='Tutup']")));

				if (elementTabBerita is not null)
				{
					// Close Tab 'Berita'
					elementTabBerita.Click();

					// Open Tab 'Report'
                    edgeDriver.Url = $"{edgeDriver.Url}#accurate__report__report";
                }

				var elementReportPenjualan = new WebDriverWait(edgeDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath("//a[contains(text(), 'Rincian Penjualan per Barang Outlet Distrik Salesman')]")));

				if (elementReportPenjualan is not null)
				{
                    // Open 'Dialog' Report
                    elementReportPenjualan.Click();

					// Set Start and End Date
					var xpathStartDate = "//input[@name='startDate']";
					var xpathEndDate = "//input[@name='endDate']";

					var elementStartDate = new WebDriverWait(edgeDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(xpathStartDate)));
					var elementEndDate = new WebDriverWait(edgeDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(xpathEndDate)));

					if (elementStartDate is not null && elementEndDate is not null)
					{
						elementStartDate.SendKeys(startDate);

						elementEndDate.Click();
                        elementEndDate.SendKeys(endDate);
					}

					edgeDriver.FindElement(By.XPath("//button[@name='btnShowReport']")).Click();
				}

				var xpathDropDownExport = "//ul[@class='dropdown-menu text-left']";
                var elementDropDownExport = edgeDriver.FindElement(By.XPath(xpathDropDownExport));

				if (elementDropDownExport is not null)
				{
					edgeDriver.ExecuteScript("arguments[0].style.display = 'block';", elementDropDownExport);

                    var xpathButtonReportExcel = "//a[contains(text(), 'Excel')]";
                    var elementButtonReportExcel = new WebDriverWait(edgeDriver, TimeSpan.FromSeconds(20)).Until(ExpectedConditions.ElementIsVisible(By.XPath(xpathButtonReportExcel)));

                    if (elementButtonReportExcel is not null)
                    {
                        elementButtonReportExcel.Click();
                    }
                }
            }
            #endregion

            Thread.Sleep(10_000);
		}
		catch (Exception)
		{
			throw;
		}
		finally
		{
			edgeDriver.Quit();
		}
    }
}
