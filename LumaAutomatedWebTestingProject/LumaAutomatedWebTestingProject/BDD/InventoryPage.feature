Feature: InventoryPage

 As a registered user I want to be able to add items to the cart and checkout my items so that I can buy items

@InventoryPage
@Happy
Scenario: When I select my size, colour and quantity the item(s) should be added to the cart
	Given I am on an item's page
	When I pick a colour 
	And I pick a size
	And I pick a quantity
	And I click the Add to Cart Button
	Then the item(s) should be added to the cart

# Mabye a list for size and colour


@BasketOverflow
@Happy
Scenario: Does the basket item limit work
    Given I have less than or equal to 10000 items in the basket
    When I add 1 or more items to basket
    Then I should see an error message that contains "The requested qty is not available"


@InventoryPage
@Happy
Scenario: The Add Icon should bring up a menu with my Cart items
	Given I am on the inventory page
	When I click the Cart Icon
	Then a menu should show up with a proceed to checkout button 
	And it should include the items in the cart

# Names for the one above are a bit weird



Scenario: The Proceed to checkout button should work
Given 
