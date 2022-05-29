Feature: Login
	As an user of Mars portal  
	I want to be able to log in
	So that I can see my profile page

@automate
Scenario: Signing in
	Given I login to Mars Portal using valid credentials
	Then I should be able to be logged into the portal successfull

	
