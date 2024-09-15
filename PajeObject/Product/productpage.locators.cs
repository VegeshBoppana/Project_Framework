using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PajeObject.Product
{
    public partial class productpage
    {
        protected By BackPackItem => By.XPath("//div[@class='inventory_item']//div[@class='inventory_item_name' and text()='Sauce Labs Backpack']/ancestor::div[@class='inventory_item']//button[contains(@class, 'btn_primary')]");

        protected By BikeLightItem => By.XPath("//div[@class='inventory_list']//div[.//div[text()='Sauce Labs Bike Light']]//button[text()='ADD TO CART']");

        protected By BoltShirtItem => By.XPath("//div[@class='inventory_list']//div[.//div[text()='Sauce Labs Bolt T-Shirt']]//button[text()='ADD TO CART']");
        protected By FleeceJacket => By.XPath("//div[@class='inventory_list']//div[.//div[text()='Sauce Labs Fleece Jacket']]//button[text()='ADD TO CART']");
        protected By LabsOnesie => By.XPath("//div[@class='inventory_list']//div[.//div[text()='Sauce Labs Onesie']]//button[text()='ADD TO CART']");
        protected By TShirtRed => By.XPath("//div[@class='inventory_list']//div[.//div[text()='Test.allTheThings() T-Shirt (Red)']]//button[text()='ADD TO CART']");

        protected By CartCount = By.XPath("//span[@class='fa-layers-counter shopping_cart_badge']");
        protected By CartSymbol = By.XPath("//div[@id = 'shopping_cart_container']"); // check it is working or not
        protected By Productpageindicator => By.XPath("//div[text()='Products']");
    }
}
