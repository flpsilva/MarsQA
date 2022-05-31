Feature: SellerAdd Profile Details

As a Seller
I want the feature to add, edit and delete my Profile Details
So that
The people seeking for some skills can look into my details.


Scenario: 1Add skill in profile detail
	Given I logged into the Mars profile detail page
	When I add a new skill to the profile details
	Then the new skill must be visible in my profile details


Scenario: 2Edit a skill
	Given I update Skill on an existing skill record 
	Then the record should have the updated skill


Scenario: 3Delete kill
	 Given I delete the skill record
	 Then I am able to validate that the registered skill was successfully deleted