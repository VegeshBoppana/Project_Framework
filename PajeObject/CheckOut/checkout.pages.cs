using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObject.CheckOut
{
    public partial class checkout
    {

        protected By ContinueShopping => By.XPath("//a[@class = 'btn_secondary']");
        protected By Checkout => By.XPath("//a[@class = 'btn_action checkout_button']");
        protected By Productpageindicator => By.XPath("//div[text()='Products']");

        protected By CheckOutStep1Heading => By.XPath("//div[@class = 'subheader']");



        //step one
        protected By FirstName => By.XPath("//input[@id = 'first-name']");
        protected By LastName => By.XPath("//input[@id = 'last-name']");
        protected By Postalcode => By.XPath("//input[@id = 'postal-code']");

        protected By S1Continuee => By.XPath("//input[@class = 'btn_primary cart_button']");

        protected By PageName => By.XPath("//div[@class = 'subheader']");
        protected By Vertify => By.XPath("//div[@class = 'subheader']");
        protected By S1Cancell => By.XPath("//a[@class = 'cart_cancel_link btn_secondary']");



        // step two

        protected By S2Finish => By.XPath("//a[@class = 'btn_action cart_button']");
        protected By S2Cancel => By.XPath("//a[@class = 'cart_cancel_link btn_secondary']");

        //LAST STEP
        protected By confirmation => By.XPath("//h2[@class = 'complete-header']");

    }
}
