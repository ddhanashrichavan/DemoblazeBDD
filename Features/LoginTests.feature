Feature: Release_to_Water
	


Scenario Outline: Release to Water Scenario
	Given I am on the Assure login page 
	And I entered the '<Username>' and '<Password>'
	When I click login button
	Then I am able to login
	And I navigate to module ->Environment ->Release To Water
	And I added first new record
	 * I click New Record Button
	 * I fill in the '<SampleDate_one>' and '<Description_one>' field
	 * I click Save and Close Button
	And I added second new record 
	 * I click New Record Button
	 * I fill in the '<SampleDate_two>' and '<Description_two>' field
	 * I click Save and Close Button
	And I delete the first record
	And I verify that First record has been deleted
	And I verify that the second record is still available
	And I Click logout Button

	Examples:
	| Username | Password | SampleDate_one | Description_one | SampleDate_two | Description_two      |
	| PramilaK | Evo@99   | 02/05/2022     | its a test      |  06/08/2022    |  results are true    |
	
