Feature: SwagLabs Testing



#implement the background
#implement the AND

@mytag1
Scenario: Check login functionality
Given User is in the login Page
When User enter a valid username and password from 'data.csv' file
Then User should go to the Product Page




@mytag2
Scenario Outline: Add to cart functionality
Given User is in the Product Page
When User adds the following products:
    | Sauce Labs Backpac | Bike Light | T-Shirt | FleeceJacket | Onesie | RedShirt |
    | <Sauce Labs Backpac> | <Bike Light> | <T-Shirt> | <FleeceJacket> | <Onesie> | <RedShirt> |
Then Count on the cart should display <ExpectedCount>

Examples: 
| Sauce Labs Backpac | Bike Light | T-Shirt | FleeceJacket | Onesie | RedShirt | ExpectedCount |
| 1                  | 0         | 1       | 0            | 1      | 1        | 4              |
| 1                  | 1         | 1       | 0            | 1      | 1        | 5              |
| 1                  | 1         | 1       | 1            | 1      | 1        | 6              |
| 1                  | 1         | 0       | 0            | 0      | 0        | 2              |





@mytag3
Scenario: Check the Your Cart Functionality
Given User Clicks on the Cart Symbol after adding few items
When User Clicks on Continue Shopping
Then User Should go to Products Page


@mytag4
Scenario: Checking the Checkout step1 functionality
Given User is in the cart page
When user Clicks on the Checkout
Then user should got to the stepOne functionality page



@mytag5
Scenario Outline: Checking the information page
    Given user is on the Your Information Page
    When user enters the following details and clicks on continue "<First Name>"  "<Second Name>" "<Zip/Postal Code>"
    Then User should see <ExpectedResult>

Examples:
| First Name | Second Name | Zip/Postal Code | ExpectedResult          |
|            |             |                 |Checkout: Your Information|
| Vegesh     | Sai         | 500000          |Checkout: Overview|
| @Vegesh    | Sai         | 532r2           |Checkout: Your Information|
| Vegesh     | @Sai        | 34543           |Checkout: Your Information|
| Vegesh     | Sai         | 500@00          |Checkout: Your Information|
| @Vegesh    | @Sai        | dee@123@        |Checkout: Your Information|











