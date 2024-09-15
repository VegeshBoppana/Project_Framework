using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

public static class SelectUtilities
{
    // Method to select an option by index
    public static void SelectByIndex(IWebElement dropdownElement, int index)
    {
        SelectElement select = new SelectElement(dropdownElement);
        select.SelectByIndex(index);
        Console.WriteLine("Selected value by index: " + select.SelectedOption.Text);
    }

    // Method to select an option by visible text
    public static void SelectByText(IWebElement dropdownElement, string text)
    {
        SelectElement select = new SelectElement(dropdownElement);
        select.SelectByText(text);
        Console.WriteLine("Selected value by text: " + select.SelectedOption.Text);
    }

    // Method to select an option by value
    public static void SelectByValue(IWebElement dropdownElement, string value)
    {
        SelectElement select = new SelectElement(dropdownElement);
        select.SelectByValue(value);
        Console.WriteLine("Selected value by value: " + select.SelectedOption.Text);
    }

    // Method to print all options in the dropdown
    public static void PrintOptions(IWebElement dropdownElement)
    {
        SelectElement select = new SelectElement(dropdownElement);
        IList<IWebElement> options = select.Options;
        Console.WriteLine("Dropdown options are:");
        foreach (IWebElement option in options)
        {
            Console.WriteLine(option.Text);
        }
    }
}
