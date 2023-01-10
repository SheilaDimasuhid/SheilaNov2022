Feature: TMFeature

As a TUrnUp portal user
I would like to create,edit and delete time and material records
So that I can manage employyee's time and materials successfully


Scenario: Create time and material record with valid details
	Given I logged into TurnUp portal successfully
	When I navigate to Time and Material page
	And I create a new Time and Material record
	Then The record should be created successfully
