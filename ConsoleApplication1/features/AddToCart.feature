Feature: AddToCart
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add to cart button navigate to cart page
	Given I go to main page
		And I search for 'book'
		And click buy now link
		And insure 'В виде галереи' view
		And And Select 'В виде галереи'
		And select 1 item in search result
	When I click add to cart button
	Then verify I am on cart page

@mytag
Scenario: Items Is added to the cart
	Given I go to main page
		And I search for 'book'
		And click buy now link
		And And Select 'В виде галереи'
		And select 1 item in search result
	When I click add to cart button
	Then verify number of items in cart is 1


	 
