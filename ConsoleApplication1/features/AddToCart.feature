Feature: AddToCart
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given I go to main page
		And I search for 'book'
		And click buy now link
		And insure I am on 'В виде галереи' view
		And select 1 item in search result

@mytag
Scenario: Add to cart button navigate to cart page
	When I click add to cart button
	Then verify I am on cart page

@mytag
Scenario: Items Is added to the cart
	When I click add to cart button
	Then verify number of items in cart more then 1


	 
