﻿Feature: RegistrationTests

@Positive @Registration
Scenario: User will register into the website with a new username
	Given User open Demoblaze website
	When User clicks Sign Up
	And User enters the signup username "<Username1>" and password "<Password1>"
	And User click on Sign up to proceed
	Then User sees the success popup message

	Examples: 
	| Username1 | Password1|
	| Testcvb     | test  |

@Negative @Registration
Scenario: Sign up to the website 
	Given User open Demoblaze website
	When User clicks Sign Up
	And User enters the signup username "<Username>" and password "<Password>"
	And User click on Sign up to proceed
	Then User sees the failed popup message

	Examples: 
	| Username | Password |
	| test     | test     |
	| xyz      |          |
	|		   |  asdasd  |
