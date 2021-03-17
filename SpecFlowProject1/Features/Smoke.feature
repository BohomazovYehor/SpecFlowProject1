Feature: Smoke
  As a user
  I want to test all main site functional
  So that I can be sure that site works correctly

  Scenario Outline: Check search field work correctly
    Given User opens '<homePage>' page
    And User checks search field visibility
    When User makes search by keyword '<keyword>'
    And User clicks search button
    Then User checks visibility of searching item

    Examples:
      |homePage                |keyword      |
      |  https://www.ebay.com/ | 124628199558|

  Scenario Outline: Check add product to cart
    Given User opens '<homePage>' page
    And User checks search field visibility
    When User makes search by keyword '<keyword>'
    And User clicks search button
    And User clicks searching item link
    And User clicks add to cart button
    Then User checks item visibility in cart

    Examples:
      |homePage                |keyword      |
      |  https://www.ebay.com/ | 124628199558|

  Scenario Outline: Check payment field visibility
    Given User opens '<homePage>' page
    And User checks search field visibility
    When User makes search by keyword '<keyword>'
    And User clicks search button
    And User clicks searching item link
    And User clicks add to cart button
    And User click go to checkout
    Then user checks visibility of payment fields

    Examples:
      |homePage                |keyword      |
      |  https://www.ebay.com/ | 124628199558|

  Scenario Outline: Check visibility of error massage when sign in with unregister email
    Given User opens '<homePage>' page
    And User click sign in button
    When User enter unregister email '<email>'
    And User click continue button
    Then User checks visibility of error massage

    Examples:
    |homePage                |email               |
    |  https://www.ebay.com/ |bagama321@gmail.com |

  Scenario Outline: Check visibility of category popup
    Given User opens '<homePage>' page
    When User click category button
    Then User check visibility of category popup

    Examples:
    | homePage              |
    | https://www.ebay.com/ |

  Scenario Outline: Check visibility of help page input field
   Given User opens '<homePage>' page
   When User click help button
   Then User checks visibility of input field
  
   Examples:
      | homePage              |
      | https://www.ebay.com/ |

  Scenario Outline: Check visibility of tennis page
    Given User opens '<homePage>' page
    When User click category button
    And User click sporting goods button
    And User click tennis goods button
    Then User check tennis page is displayed
  
    Examples:
      | homePage              |
      | https://www.ebay.com/ |

  Scenario Outline: Check visibility of sporting goods page
   Given User opens '<homePage>' page
   When User click category button
   And User click sporting goods button
   Then User checks sporting goods page is displayed

   Examples:
     | homePage              |
     | https://www.ebay.com/ |

  Scenario Outline: Check visibility of error massage when sign in with incorrect password
   Given User opens '<homePage>' page
   And User click sign in button
   When User enter register email '<email>'
   And User click continue button
   And User enter incorrect password '<password>'
   And User click sign in button on sign in page
   Then User checks visibility of error massage

   Examples:
   |homePage              |email                   |password   |
   |https://www.ebay.com/ |bohomazovehor@gmail.com |qwer859623 |

  Scenario Outline: Check daily deals page is load
    Given User opens '<homePage>' page
    When User click daily deals button
    Then User checks daily deals page is load

    Examples:
      | homePage              |
      | https://www.ebay.com/ |
