Feature: BBCSignIn_ClickableLink
	check that the link are working on the Sign In page
	Also redirect users to the correct page
	
Background: 
	Given As a user I am on "BBCURL"

@Browser_Chrome
Scenario: Clicking on Need Help Link
    Given I click on Need help Link
	Then I should be redirected to the help page verify by the page title

@Browser_Chrome
Scenario: Clicking on Register now Link
    Given I click on Register now Link
	Then I should be redirected to the Register with BBC page verify by "Register with BBC" being displayed

@Browser_Chrome
Scenario: Clicking on Find out more about BBC account Link
    Given I click on Find out more about BBC account  Link
	Then I should be redirected to  Creating and Using your BBC account page verify by "Creating and Using your BBC account" being displayed

@Browser_Chrome
Scenario: Clicking on Abbout the BBC Link
    Given I click on Abbout the BBC Link
	Then I should be redirected to About  the BBC page verify by the page title

@Browser_Chrome
Scenario: Clicking on Privacy Policy Link
    Given I click on Privacy Policy Link
	Then I should be redirected to Your Information and Privacy page verify by "Your Information and Privacy" being displayed

@Browser_Chrome
Scenario: Clicking on Cookies Link
    Given I click on cookies Link
	Then I should be redirected to the Cookies and Browser Settings page verify by "Cookies and Browser Settings" being displayed

@Browser_Chrome
Scenario: Clicking on Accessibility help Link
    Given I click on Accessibility help Link
	Then I should be redirected to My Web my way page verify by "My Web my way" being displayed

@Browser_Chrome
Scenario: Clicking on Parental Guidance Link
    Given I click on parental Guidance Link
	Then I should be redirected to the Parental Guidance page verify by the page title 

	
@Browser_Chrome
Scenario: Clicking on Contact the BBC Link
    Given I click on Contact the BBC Link
	Then I should be redirected to the Contact the BBC page verify by the page title

@Browser_Chrome
Scenario: Clicking on Get Personalised Newsletters Link
    Given I click on Get Personanlised Newsletters Link
	Then I should be redirected to Get Personalised Newsletters page verify by the page title


@Browser_Chrome
Scenario: Clicking on cross button
    Given I click on the cross button
	Then I should be redirected to welcome to BBC page verify by the page title

	



	

	

	
