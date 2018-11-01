Feature: BBCSignIn_Successfully
	Open BBC Page
	Check signing in using valid credential
	Also verify that the registered username is displayed	

Background: 
	Given As a user I am on "BBCURL"
	
	

@Browser_Chrome
Scenario Outline: Sigining In Successfully with Email 
	Given I enter valid <Email> in the email section
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be redirected to BBC account page veryfy by account being displayed
Examples: 
   | Email                 |
   | KELEBALYDIE@GMAIL.COM |
   | kelebalydie@gmail.com |
@Browser_Chrome
Scenario Outline: Sigining In Successfully with Username
	Given I enter a valid <Username> in UpperCase
	And I enter valid Password in the password section
	When I click on Sigin in button
	Then I should be redirected to BBC account page veryfy by regitered username being displayed

Examples:                            
      | Username |
      | LYDIE10  |
      | Lydie10  |
      | LydiE 10 |

	



