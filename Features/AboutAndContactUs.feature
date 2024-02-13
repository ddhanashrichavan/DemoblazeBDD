Feature: AboutAndContactUs

@AboutUs
Scenario: Playing the About us Video
    Given User open Demoblaze website
	When User clicks about us on navigation bar
	Then About us Popup appears
	When user clicks on play button
	Then the video starts playing
	And user clicks on close button


@ContactUs
Scenario: Sending Message using Contact tab
	Given User open Demoblaze website
	When User clicks contact on navigation bar
	Then contact Popup appears
	When user enters information '<contactEmail>' '<contactName>' '<Message>'
	And user clicks on Send Message
	Then Alert appears with text "Thanks for the message!!"

	Examples:
	| contactEmail         | contactName      | Message                 |
	| ddhanashri@gmail.com | Dhanashri Chavan | Testing contact Message |