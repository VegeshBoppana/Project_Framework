Feature: Interactions with Buttons on the DemoQA Website

  As a user on the DemoQA website
  I want to perform double-click and right-click interactions on buttons
  So that I can see confirmations of these interactions

  Background:
    Given the user has navigated to the DemoQA  Page

  Scenario: Successfully performing a Double Click on the "Double-Click-Me" Button
    Given  the user has navigated to the DemoQA Buttons Page
    When the user double-clicks on the Double-Click-Me button
    Then an output should display with the message "You have done a double click"

  Scenario: Successfully performing a Right Click on the "Right-Click-Me" Button
    Given the user has navigated to the DemoQA Buttons Page
    When the user right-clicks on the Right-Click-Mee button
    Then an output should display with the message "You have done a right click"

   Scenario: Checking the implementation of the check-box
   Given user is on the Checkbox page
   When user clicks on the Home square box 
   Then All the Checjbox should get selected

   Scenario: Checking the functionality of the Radio Button
   Given User is on the Radio Button Page
   When User Selects the enabled Radio Buttons
   Then User see the corresponding output


Scenario: Interacting with a dropdown menu and selecting options
    Given User is on the Select-Menu Page
    When User retrieves and prints all dropdown options
    Then User should see all the options listed

    When User selects the option at index
    Then User should see "Purple" as the selected value

    When User selects the option with text "Magenta"
    Then User should see "Magenta" as the selected value

    When User selects the option with value "6"
    Then User should see "6" as the selected value

Scenario: 



