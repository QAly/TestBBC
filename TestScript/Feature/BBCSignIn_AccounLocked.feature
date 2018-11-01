Feature: BBCSignIn_AccounLocked
	Open BBC Page
	Check signing in using valid Email/Username credential
	Validate entering the wrong password too many times
    Also verify that user is redirecting to the account locked page
	Check the right information is displayed to help user to sign in
	
	

Background: 
	Given As a user I am on "BBCURL"
			
@Browser_Chrome
Scenario: Sigining In with Wrong Password Many Times
	Given I input valid username
	And wrong Password for the first time

	| Password     |
	| TestingBBC21 |
	And I click on "Sigin in" button
	And I enter invalid Password for the second time 

	| Password     |
	| TestingBBC21 |
	And I click on "Sigin in" button
	And I enter incorrect Password for the third time 

	| Password      |
	| Testing@BBC21 |
	And I click on "Sigin in" button
	And I enter incorrect password for the fourth time 

	| Password      |
	| Testing@BBC21 |
	And I click on "Sigin in" button

	And I enter incorrect password for the fifth time 

	| Password      |
	| Testing@BBC21 |
	And I click on "Sigin in" button
	And I enter incorrect password for the sixth time 

	| Password      |
	| Testing@BBC21 |
	And I click on "Sigin in" button
	
	Then user account should be locked verify by the account locked page being displayed
	#Sorry your account is locked, this happen when you enter the wrong password too many times

	
