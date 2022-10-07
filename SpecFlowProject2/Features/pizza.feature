Feature: JoesPizza1

A short summary of the feature

@tag2
Scenario: Purcahsing two pizzas and deleting one and the confirming the order.
	Given I have opened the website 
	When I click on Checkout button
	Then It displays cart is empty message
	When I click on pizza list 
	Then I get redirected to pizza list
	When I click on Add To Cart button to add pizza
	Then I will be redirected to the cart
	When I click on add more pizza
	Then I will get redirected to pizza list
	When I  add another pizza
	Then I get redirected towards the cart 
	When I click on checkout
	Then Order confirmation page is opened