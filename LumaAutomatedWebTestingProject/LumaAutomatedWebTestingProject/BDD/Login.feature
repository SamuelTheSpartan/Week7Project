Feature: SL_Signin

In order to be able to buy items
As a registered user of the Luma website 
I want to be able to sign in to my account

@Signin
@Happy

Scenario: Login with valid email and valid password
Given I am on the customer login page 
And I have entered a valid e-mail
#id.email
And I have entered a valid password
#id.pass
When I click the sign in button 
#id.send2
Then I should land on the account page


@Signin
@Sad

Scenario: Login with valid email and invalid password
Given I am on the customer login page 
And I have entered a valid e-mail
And I have entered a invalid password of "<passwords>"
When I click the sign in button 
Then I should see an error message that contains "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later"
#data-ui-id="message-error"
Examples: 
| passwords |
| wrong     |
| 12345     |



@Signin
@Sad
Scenario: Invalid email and password
Given I am on the customer login page
And I have the following credentials
| UserName        | Password |
| fakeusername    | password |
And I enter these credentials
When I click the sign in button 
Then I should see an error message that contains "The account sign-in was incorrect or your account is disabled temporarily. Please wait and try again later"

# Forgotten Password 


#Try Demo Customer Access

#Email:roni_cost@example.com

#Password:roni_cost3@example.com