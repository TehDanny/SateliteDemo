Feature: Satelite
	In order to analyse weather on earth
	As a meteorologist
	I want to receive the most recent data from the satellite

Scenario: Get data from last 24 hours
	Given I have entered 24
	When I press Get Data
	Then the result should be a 100 lines of data on the screen
