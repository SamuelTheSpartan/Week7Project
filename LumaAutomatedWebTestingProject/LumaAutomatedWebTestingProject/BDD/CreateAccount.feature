Feature: CreateAccount

In order to login to an account
As an unregistered user of the Luma website
I want to be able to create an new account

@CreateAccount
@Happy
Scenario: Create Account with valid First Name, Last Name, Email, Password and Confirmed Password
	Given I am on the create new customer account page
	And I have the following valid credentials 
	| firstname | lastname | password    |
	| Lucas     | Brennan  | Password123 |
	And I enter the credentials
	When I click the create an account button
	Then I should land on the account page

@CreateAccount
@Sad
Scenario: Create Account with invalid First Name, Last Name and valid Email, Password and Confirmed Password
	Given I am on the create new customer account page
	And I have entered a invalid First Name "exam%ple"
	#id:firstname
	And I have entered a invalid Last Name "exa$mple2"
	#id:lastname
	And I have entered a unregistered Email
	#id:email_address
	And I have entered a valid Password "Password123"
	#id:password
	And I have entered a valid Password Confirmation "Password123"
	#id:password-confirmation
	When I click the create an account button
	Then I should see an error message that contains "First Name is not valid! Last Name is not valid! Last Name is not valid!"

@CreateAccount
@Sad
Scenario: Create Account with valid First Name, Last Name and Email and Password and Confirmed Password with less than 8 characters
	Given I am on the create new customer account page
	And I have the credentials with an Invalid Password
	| firstname | lastname | password |
	| Lucas     | Brennan  | pass     |
	And I enter the credentials
	When I click the create an account button
	Then I should see an error message that contains "Minimum length of this field must be equal or greater than 8 symbols. Leading and trailing spaces will be ignored"
