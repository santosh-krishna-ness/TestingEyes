Feature:Car Tabs
This feature will help users to know about the Testing Eyes application.

Background: User logs into the application
   	Given I navigate to application
      And I enter username and password
		| UserName | Password |
		| admin    | admin    |
      And I click login

Scenario: Cars tab
When I click Cars tab
Then Display the Cars page with images   

Scenario: Swift Car
When I click Cars tab and Swift car 
Then Display the Swift cars with details  

Scenario: Tata Tiago page
When I click Cars tab and Tata Tiago image
Then Display the Tata Tiago cars with details

Scenario: Back button
When I click Cars tab and Tata Tiago image
And click on Back button
Then Display the Cars page with images