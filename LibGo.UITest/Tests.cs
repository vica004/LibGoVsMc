using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace LibGo.UITest
{
    [TestFixture(Platform.Android)]
    [TestFixture(Platform.iOS)]
    public class Tests
    {
        IApp app;
        Platform platform;

        public Tests(Platform platform)
        {
            this.platform = platform;
        }

        [SetUp]
        public void BeforeEachTest()
        {
            app = AppInitializer.StartApp(platform);
        }

        [Test]
        public void AppLaunches()
        {
            app.Screenshot("First screen.");
        }

        [Test]
        public void LibGoTest()
        {
            app.WaitForElement(x => x.Class("WebView").Css("SPAN.FontWhiteOpenHours"));
            app.Tap(x => x.Class("WebView").Css("SPAN.FontWhiteOpenHours"));
            app.Tap(x => x.Class("WebView").Css("SPAN.FontWhiteOpenHours"));
            app.WaitForElement(x => x.Class("WebView").XPath("//A[@id=\"wt54_wtFooter_wt103_wt2\"]/IMG"));
            app.Tap(x => x.Class("WebView").XPath("//A[@id=\"wt54_wtFooter_wt103_wt2\"]/IMG"));
            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"New database: ProQuest Global Newsstream\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"New database: ProQuest Global Newsstream\"]"));
            app.ScrollDown();
            app.ScrollUp();
            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"Main\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"Main\"]"));
            app.WaitForElement(x => x.Class("WebView").XPath("//A[@id=\"wt54_wtFooter_wt103_wt4\"]/IMG"));
            app.Tap(x => x.Class("WebView").XPath("//A[@id=\"wt54_wtFooter_wt103_wt4\"]/IMG"));
            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"Services\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"Services\"]"));
            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"Book Displays In The Library\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"Book Displays In The Library\"]"));
            app.ScrollDown();
            app.WaitForElement(x => x.Class("WebView").Css("SPAN.CustomizeFooterForSimpleLibGo_FontColorForLastContainer"));
            app.Tap(x => x.Class("WebView").Css("SPAN.CustomizeFooterForSimpleLibGo_FontColorForLastContainer"));
            app.WaitForElement(x => x.Class("WebView").XPath("//DIV[text()=\"Back\"]"));
            app.Tap(x => x.Class("WebView").XPath("//DIV[text()=\"Back\"]"));

            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"Main\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"Main\"]"));
            app.WaitForElement(x => x.Class("WebView").Css("INPUT#wt54_wtMainContent_wt48_wt1"));
            app.Tap(x => x.Class("WebView").Css("INPUT#wt54_wtMainContent_wt48_wt1"));
            app.EnterText(x => x.Class("WebView").Css("INPUT#wt54_wtMainContent_wt48_wt1"), "English");
            app.Tap(x => x.Class("WebView").Css("INPUT#wt54_wtMainContent_wt48_wt4"));
            
            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"Back\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"Back\"]"));
            app.WaitForElement(x => x.Class("WebView").XPath("//SPAN[text()=\"My Account\"]"));
            app.Tap(x => x.Class("WebView").XPath("//SPAN[text()=\"My Account\"]"));
            app.WaitForElement(x => x.Class("WebView").Css("INPUT#wt30_wtMainContent_wt21_SilkUIFramework_wtModalScreen_block_wtMessage_wt33_wt6"));
            app.Tap(x => x.Class("WebView").Css("INPUT#wt30_wtMainContent_wt21_SilkUIFramework_wtModalScreen_block_wtMessage_wt33_wt6"));
            app.EnterText(x => x.Class("WebView").Css("INPUT#wt30_wtMainContent_wt21_SilkUIFramework_wtModalScreen_block_wtMessage_wt33_wt6"), "test1");
            app.Tap(x => x.Class("WebView").Css("INPUT#wt30_wtMainContent_wt21_SilkUIFramework_wtModalScreen_block_wtMessage_wt33_wt7"));
            app.EnterText(x => x.Class("WebView").Css("INPUT#wt30_wtMainContent_wt21_SilkUIFramework_wtModalScreen_block_wtMessage_wt33_wt7"), "13049");
            app.Tap(x => x.Class("WebView").Css("INPUT#wt30_wtMainContent_wt21_SilkUIFramework_wtModalScreen_block_wtMessage_wt33_wt9"));
            app.WaitForElement(x => x.Class("WebView").Css("SPAN.FontGreyMarginLeft"));
            app.Tap(x => x.Class("WebView").Css("SPAN.FontGreyMarginLeft"));
        }
    }
}

