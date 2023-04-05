Feature: CreateAccount

In order to login to an account
As an unregistered user of the Luma website
I want to be able to create an new account

@CreateAccount
@Happy
Scenario: Create Account with valid First Name, Last Name, Email, Password and Confirmed Password
	Given I am on the create new customer account page
	And I have entered a valid First Name
	And I have entered a valid Last Name 
	#Can we include First / Last Name as one
	And I have entered a unregistered Email
	And I have entered a valid Password
	And I have entered a valid Password Confirmation
	When I click the create an account button
	Then I should land on the account page

@CreateAccount
@Sad
Scenario: Create Account with invalid First Name, Last Name and valid Email, Password and Confirmed Password
	Given I am on the create new customer account page
	And I have entered a invalid First Name with a semi colon
	#id:firstname
	And I have entered a invalid Last Name with a semi colon
	#id:lastname
	And I have entered a unregistered Email
	#id:email_address
	And I have entered a valid Password
	#id:password
	And I have entered a valid Password Confirmation
	#id:password-confirmation
	When I click the create an account button
	Then I should see an error message that contains "First Name is not valid! Last Name is not valid! Last Name is not valid!"

@CreateAccount
@Sad
Scenario: Create Account with valid First Name, Last Name and Email and Password and Confirmed Password with less than 8 characters
	Given I am on the create new customer account page
	And I have entered a valid First Name
	And I have entered a valid Last Name
	And I have entered a unregistered Email
	And I have entered a Password with less than 8 characters 
	And I have entered a Password Confirmation less than 8 characters 
	When I click the create an account button
	Then I should see an error message that contains "Minimum length of this field must be equal or greater than 8 symbols. Leading and trailing spaces will be ignored"