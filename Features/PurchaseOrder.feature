Feature: PurchaseOrder

Scenario Outline: purchase order
	Given User open Demoblaze website
	When User clicks Login
    And User enters the username "<Username>" and password "<Password>"
	And User clicks Proceed login for existing user
	Then User gets redirected to homepage
	And User navigate to Categories ->Phones
	And User click on Samsung galaxy s6
	And User click on Add to cart button
	Then User verify that product is added
	And User navigate to Cart
	And User click on Place order
	And User fill the form with fields '<Name>' '<Country>' '<City>' '<Credit card>' '<Month>' '<Year>' and submit
	Then User verify that order has placed
	

	Examples:
	| Username | Password | Name  | Country | City      | Credit card | Month | Year |
	| DhanaC   | 1234     | Dhana | UK      | Canbridge | 3456782978  | Feb   | 2024 |

Scenario Outline: Open product link in different window
	Given User open Demoblaze website
	When User clicks Login
    And User enters the username "<Username>" and password "<Password>"
	And User clicks Proceed login for existing user
	Then User gets redirected to homepage
	And User open product Nexus 6 in new window
	

	Examples:
	| Username | Password |
	| DhanaC   | 1234     |