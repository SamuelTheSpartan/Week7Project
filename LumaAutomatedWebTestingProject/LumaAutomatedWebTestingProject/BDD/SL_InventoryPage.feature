Feature: InventoryPage

 As a registered user 
 I want to be able to add items to the cart and checkout my items 
 so that I can buy items

#@InventoryPage
#@Happy
#	| option-label-color-93-item-49 | option-label-size-143-item-166 |


@InventoryPage
@Happy
Scenario: The item should be added to the cart after I selected my colour and size
	Given I am on the item's page
	And I pick black as my colour
	And I pick XS as my size
	When I click the Add to Cart Button
	Then I should be able to add an item to my shopping cart


#ID: Black Blue Orange
# Add to cart button id="product-addtocart-button"
#ID: XS S M L XL 


# As a registered user I want to be able to add a large number of items to my basket so that I can itms in bulk
@InventoryPage
@Happy
Scenario: Testing the item limit on the basket
    Given I am on the basket page
    When I change the quantity to 9858
	And I click update the shopping cart button
    Then I should see an error message
#"The requested qty is not available"
# max number is 9857 in the cart for this test

# As a registered user I 

@InventoryPage
@Happy
Scenario: The Cart Icon should bring up a menu with my Cart items
	Given I am on the inventory page
	When I click the Cart Icon
	Then a menu should show up with a proceed to checkout button 

@InventoryPage
@Happy
Scenario: The Proceed to checkout button should bring me to the checkout shipping address page
Given I have added an item to the basket
And I am on the Cart List
When I click the Proceed to Checkout button
Then I should be taken to the Checkout Shipping Address Page

# Closed Cart List class="minicart-wrapper"> when closed
# Open Cart class="minicart-wrapper active"> when open
# Proceed to Chckout Button <button id="top-cart-btn-checkout"
# Cecjout shipping Page Url  https://magento.softwaretestingboard.com/checkout/#shipping

@InventoryPage
@Happy
Scenario: The View and Edit Cart button bring me to the shopping cart page
Given I have added an item to the basket
And I am on the Cart List
When I click the View and Edit Cart button
Then I should be taken to the Shopping Cart Page

# View and Edit Cart button
# Shopping Cart Page https://magento.softwaretestingboard.com/checkout/cart/
