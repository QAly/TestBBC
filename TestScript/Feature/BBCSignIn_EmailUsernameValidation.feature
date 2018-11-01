Feature: BBCLogin_EmailUsernameValidation
	Open BBC Page
	check signing in using invalid Email or username credential
	Check the right information is displayed to help user to sign in correctly


Background: 
	Given As a user I am on "BBCURL"
	
@Browser_Chrome
Scenario Outline: Sigining In with Invalid Email
	Given As a user I enter invalid <Email> in the email section
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section 
	#Warning message: Sorry, that email doesn’t look right. Please check it's a proper email
Examples:             
     | Email                      |
     | keleba@com                 |
     | lydie10@                   |
     | lydiekelebalydie@gmail.com |
	 
@Browser_Chrome
Scenario Outline: Sigining In with a Valid Email not linked to a BBC Account 
	Given I input <Email> in the dedicated email section 
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section for valid Email Not Linked to a BBC account
	#Warning message:Sorry, we can’t find an account with that email.You can register for a new account or get help here
Examples:                        
     | Email                   |
     | kelebalydie@gmail.co.uk |
     | senylydie@hotmail.co.uk |


@Browser_Chrome                                                   
Scenario Outline: Sigining In with Invalid Username including Acceptable characters 
	Given I input <Username> in the username box 
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section for acceptable characters
	##Warning message:Sorry, we can’t find an account with that username. If you're over 13, try your email address instead or get help here
Examples:                          
     | Username              |
     | lydie10233%           |
     | lydie10233$           |
     | lydie10233?           |
     | lydie10233#           |
     | lydie10233~           |
     | lydie10123^           |
     | lydie10123=           |
     | lydie10123_           |
     | lydie10123+           |
     | lydie10123}           |
     | lydie10123{           |
     | lydie10123\           |
     | lydie10123/           |
     | lydie10123'           |
     | lydie10123-           |
     | kelebalydiegmailcom   |

@Browser_Chrome  
Scenario Outline: Sigining In with Invalid Username Including Characters Not Accepted
	Given I enter invalid <Username> including unacceptable charaters
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section to include characters
	#Warning message:Usernames can only include... Letters, numbers and these characters: ?/|}{+=_-^~`%$#
Examples:                            
      | Username   |
      | lydie10.   |
      | lydie10*   |
      | lydie10!   |
      | lydie10,   |
      | lydie10:   |
      | lydie10!   |
      | lydie10&   |
      | lydie10>   |
      | lydie10<   |
	  

@Browser_Chrome
Scenario: Sigining In with blank EmailUsername or Password
	Given I enter no Username in the username section
	And I enter no password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the username section as well as in password section
	#Warning message:Something's missing. Please check and try again

@Chrome_Browser
Scenario:  Sigining In with blank EmailUsername
    Given I enter no Username in the username section
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the username section as well as in password section
	#Warning message:Something's missing. Please check and try again

@Chrome_Browser
Scenario:  Sigining In with blank Password
    Given I enter valid Username in the email section
	And I enter no password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the username section as well as in password section
	#Warning message:Something's missing. Please check and try again
@Browser_Chrome
Scenario Outline: Sigining In with long username
	Given I enter long <Username> in the email 
	And I enter valid Password in the password section 
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section for long username
	#Sorry, that username's too long. It can't be more than 50 characters
Examples: 
     | Username                                                     |
     | lydielydielydielydielydielydielydielydielydielydielydielydie |



