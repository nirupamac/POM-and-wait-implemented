Feature: TMFeature

As a TurnUp Portal admin
I would like to create and edit Time and Material record
so that I can manage employees' Time and Material records successfully


Scenario: create Time and Material record with valid details
	Given I logged into Turn Up portal successfully
	When  I navigate to Time and Material page
	And   I create a new and material record
	Then  The record should be created successfully



