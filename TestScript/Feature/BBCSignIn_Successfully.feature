Feature: BBCSignIn_Successfully
	Open BBC Page
	Check signing in using valid credential
	Also verify that the registered username is displayed	

Background: 
	Given As a user I am on "BBCURL"
	
	

@Browser_Chrome
Scenario: Sigining In Successfully with Email 
	Given I enter valid Email in the email section
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be redirected to BBC account page veryfy by registred username diplayed

@Browser_Chrome
Scenario: Sigining In Successfully with Username
	Given I enter valid Username in the email section
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be redirected to BBC account page veryfy by registred username diplayed

	



