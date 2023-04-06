Feature: InventoryPage

 As a registered user 
 I want to be able to add items to the cart and checkout my items 
 so that I can buy items

@InventoryPage
@Happy
Scenario: 4.1 When I select my size, colour and quantity the item(s) should be added to the cart
	Given I am on an item's page
	And I pick a <colour> 
	And I pick a <size>
	And I pick a quantity
	When I click the Add to Cart Button
	Then the item(s) should be added to the cart
	Examples:
	| colour                        | size                           |
	| option-label-color-93-item-49 | option-label-size-143-item-166 |
	| option-label-color-93-item-50 | option-label-size-143-item-167 |
	| option-label-color-93-item-56 | option-label-size-143-item-168 |
	| option-label-color-93-item-56 | option-label-size-143-item-169 |
	| option-label-color-93-item-56 | option-label-size-143-item-170 |


#ID: Black Blue Orange
# Add to cart button id="product-addtocart-button"
#ID: XS S M L XL 


# As a registered user I want to be able to add a large number of items to my basket so that I can itms in bulk
@BasketOverflow
@Happy
Scenario:4.2 Does the basket item limit work
    Given I have less than or equal to 10000 items in the basket
    When I add 1 or more items to basket
    Then I should see an error message that contains "The requested qty is not available"


# As a registered user I 

@InventoryPage
@Happy
Scenario: 4.3 The Cart Icon should bring up a menu with my Cart items
	Given I am on the inventory page
	When I click the Cart Icon
	Then a menu should show up with a proceed to checkout button 
	And it should include the items in the cart

# Names for the one above are a bit weird


@InventoryPage
@Happy
Scenario: 4.4 The Proceed to checkout button should work
Given The basket is not empty
And I am on the Cart List
When I click the Proceed to Checkout button
Then I should be taken to the Checkout Shipping Address Page

# Closed Cart List class="minicart-wrapper"> when closed
# Open Cart class="minicart-wrapper active"> when open
# Proceed to Chckout Button <button id="top-cart-btn-checkout"
# Cecjout shipping Page Url  https://magento.softwaretestingboard.com/checkout/#shipping

@InventoryPage
@Happy
Scenario: 4.5 The View and Edit Cart button should work
Given The basket is not empty
And I am on the Cart List
When I click the View and Edit Cart button
Then I should be taken to the SHopping Cart Page

# View and Edit Cart button
# Shopping Cart Page https://magento.softwaretestingboard.com/checkout/cart/
