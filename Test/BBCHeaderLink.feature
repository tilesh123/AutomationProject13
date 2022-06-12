Feature: BBCHeaderLink

As a BBC User
I want to check all my header links 
so that my customers can see those page short summary of the feature

@BBCHeaderLink
Scenario Outline: Verify Header links are working
	Given I navigate to BBC website
	 When I click on <headerlink>
	 Then I can see <headerlink> page
	 Examples:
	 | headerlink |
	 | News       |
	 | Sport      |
	 | Reel       |
	 | Worklife   |
	 | Travel     |
	 | Future     |
	 | Culture    |
	 | TV         |
	 | Weather    |
	 | Sounds     |