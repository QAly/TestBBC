Feature: BBCSigningIn_PasswordValidation
	Open BBC Page
	check signing in using invalid Email or username credential
	Check the right information is displayed to help user to sign in correctly
	
	
	

	
Background: 
	Given As a user I am on "BBCURL"

@Browser_Chrome
Scenario Outline: Sigining In with Short length Password 
	Given I input valid username
	And I enter a <Password> of less than eight characters
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the password section
	#Warning message: Sorry, that password is too short. It needs to be eight characters or more
	
Examples: 
     | Password |
     | Myth     | 

	
@Browser_Chrome
Scenario Outline: Sigining In with Password including Letters only
	Given I input valid username
	And I enter a <Password> that only contain letters
	When I click on Sigin in button
	Then I should be able to see a warning message to include characters
	#Warning message: Sorry, that password isn't valid. Please include something that isn't a letter
	 
Examples: 
     | Password |
     | Mythique | 

@Browser_Chrome
Scenario Outline: Sigining In with Invalid Password Including Characters Only
	Given I input valid username
	And I enter a <Password> that only contain characters and numbers
	When I click on Sigin in button
	Then I should be able to see a warning message displayed to include letter
	#Sorry, that password isn't valid. Please include a letter
	
Examples: 
     | Password |
     | 1234$!?? | 
	

