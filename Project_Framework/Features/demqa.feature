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
    Given User is on the Select_Menu Page
    When User retrieves and prints all dropdown options
    Then User should seee all the options listed

    When User selects the option with the value 4
    Then User should seee "purple" as the selected value

    When User selects the option with valuee "6"
    Then User should seee "6" as the selected value

    When User selects the option with the valuee "Green"
    Then User should seeee "Green" as the Selected value


@windowhandles
Scenario: Interacting with the Browser Windows
       Given User is on the WindowHandles Page
	   When User clicks on the NewTab
       Then User should print the content in the new tab

        When the user clicks on the NewWindow
       Then User should print the content in the new Window

       When the user clicks on the New Window Message
       Then User should print the content in the new Window message

@alerts
Scenario: Interacting with a simple alert
  Given the user is on the Alerts Page
  When the user clicks on the first Click Me button
  Then an alert should be displayed
  And the user clicks OK on the alert
#
Scenario: Interacting with a delayed alert
  Given the user is on the Alerts Page
  When the user clicks on the second Click Me
  Then the user should see an alert after 5 seconds
  And the user clicks OK on the alert
#
Scenario: Interacting with a confirmation alert (OK Selection)
  Given the user is on the Alerts Page
  When the user clicks on the confirm box
  Then an alert with OK and Cancel options should be displayed
  When the user clicks on OK
  Then the output "You selected Ok" should be displayed
#
Scenario: Interacting with a confirmation alert (Cancel Selection)
  Given the user is on the Alerts Page
  When the user clicks on the confirm box
  Then an alert with OK and Cancel options should be displayed
  When the user clicks on Cancel
  Then the output "You selected Cancel" should be displayed
#
Scenario: Interacting with a prompt to enter a name and accept it
  Given the user is on the Alerts Page
  When the user clicks on the prompt button
  Then an alert with a field to enter the name should be displayed
  When the user enters the name "Vegesh"
  And the user clicks OK



Scenario: Implementing the Fluentwaits in the Progress Bar page
Given the user is in the Progress Bar
When the user clicks on the srtat the progress bar starts moving
Then the user should see reset after sometime and clicks on it








 



