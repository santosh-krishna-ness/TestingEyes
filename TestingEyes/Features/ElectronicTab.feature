Feature: ElectronicTab
    This feature will help users to know about the Testing Eyes application.


Background: User logs into the application
   	Given I navigate to application
      And I enter username and password
		| UserName | Password |
		| admin    | admin    |
      And I click login

Scenario: Electronic tab
When I Click Electronic tab
Then Display Electronic page with images   


Scenario: Nokia page
When I Click Electronic tab and Nokia image
Then display the Nokia mobile with details

Scenario: Back button
When I Click Electronic tab and Nokia image
And click on back button on Nokia page
Then Display Electronic page with images
