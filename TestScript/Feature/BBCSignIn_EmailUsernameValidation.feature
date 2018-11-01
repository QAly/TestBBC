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
     | kelebalydie@gmailcom       |
     | keleba@com                 |
     | lydie@                     |
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
     | KELEBALYDIE@GMAIL.COM   |
     | senylydie@hotmail.co.uk |


@Browser_Chrome                                                   
Scenario Outline: Sigining In with Invalid Username including Acceptable characters 
	Given I input <Username> in the username box 
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section for acceptable characters
	##Warning message:Sorry, we can’t find an account with that username. If you're over 13, try your email address instead or get help here
Examples:                          
     | Username            |
     | lydie233            |
     | lydie233%           |
     | lydie233$           |
     | lydie233?           |
     | lydie233#           |
     | lydie~              |
     | lydie123^           |
     | lydie123=           |
     | lydie123_           |
     | lydie123+           |
     | lydie123}           |
     | lydie123{           |
     | lydie123\           |
     | lydie123/           |
     | lydie123'           |
     | lydie123-           |
     | kelebalydiegmailcom |

@Browser_Chrome  
Scenario Outline: Sigining In with Invalid Username Including Characters Not Accepted
	Given I enter invalid <Username> including unacceptable charaters
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section for Unacceptable characters
	#Warning message:Usernames can only include... Letters, numbers and these characters: ?/|}{+=_-^~`%$#
Examples:                            
      | Username |
      | lydie.   |
      | lydie*   |
      | lydie!   |
      | lydie,   |
      | lydie:   |
      | lydie!   |
      | lydie&   |
      | lydie>   |
      | lydie<   |

@Browser_Chrome  
Scenario Outline: Sigining In with Invalid Username warning message to still show
	Given I enter invalid <Username> characters
	When I click on Sigin in button
	Then I should be able to see a warning message displayed  for Unacceptable characters
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then warning message should still show 
	
	#Warning message:warning message is display in the password section, but it should still display in the email area
Examples:                            
      | Username |
      | lydie>   |
      | lydie<   |
	  
@Browser_Chrome
Scenario Outline: Sigining In with Username in UpperCase
	Given I enter a valid <Username> in UpperCase
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be able to see a warning message displayed in the email section for case sensitive not accepted 
	#Warning message:Uh oh, that password doesn’t match that account. Please try again.// this could be  bug , instead of displaying an error message under the email section it is displaying under password which is valid
Examples:                            
      | Username |
      | LYDIE    |
      | Lydie    |
      | lYdie    |
      | LydiE    |
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
	
Examples: 
     | Username                                                     |
     | lydielydielydielydielydielydielydielydielydielydielydielydie |



