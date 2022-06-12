Feature: BBCSignIn

A short summary of the feature: Sign in to BBC page and verify

@BBCSignIn
Scenario: Verrify Sign in Successfully
	Given I navigate to BBC Website
	 When I click on account link
	  And I enter my username and password
	  And I click on Sign in
	 Then I am able to sign in successfully
