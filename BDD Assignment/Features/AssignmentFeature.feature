@All
Feature: AvivaLinks
	In order to find the links of Aviva
	As an user I search for Aviva in Google page
	So that I can see the Aviva websites links.


@Positive
 Scenario: Successful search of Aviva in the Google page
	Given User launch google.com
	When User search for Aviva in Google
	Then User should see 6 links in the first search page
	And User should see the fifth link text

	@Negative
 Scenario: Successful search of another text other than Aviva
	Given User launch google.com
	When User search for Yahoo in Google
	Then User should see 8 links in the first search page
	And User should see the fifth link text


