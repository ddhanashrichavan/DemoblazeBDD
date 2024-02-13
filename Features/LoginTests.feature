Feature: Login scenario

@Login @Positive
Scenario Outline:  Login to the website
	Given User open Demoblaze website
	When User clicks Login
    And User enters the username "<Username>" and password "<Password>"
	And User clicks Proceed login for existing user
	Then User gets redirected to homepage

	Examples: 
	| Username  | Password |
	| DhanaC | 1234     |

	@Login @Negative
	Scenario Outline: Login to the website with invalid/non existing user
	Given User open Demoblaze website
	When User clicks Login
	And User enters the username "<Username>" and password "<Password>"
	And User clicks Proceed login
	Then User sees the failed login popup message

	Examples: 
	| Username | Password |
	| DhanaTest | 1234     |
	| xcas     | 1234     |
	| test     |          |
	
	
