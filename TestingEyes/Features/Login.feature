Feature: Login
	Check if login functionality works

Scenario: Login user as Administrator
	Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	Then I should see user logged in to the application


Scenario: Logout from the application
	Given I navigate to application
	And I enter username and password
		| UserName | Password |
		| admin    | admin    |
	And I click login
	When I click Log out button
	Then navigate to login page


Scenario: Sign up to TestingEyes
	Given I navigate to application
	When I click on Sign up button
	    | Name  | UserName    | Email                    |   Password  |
        | Test  | TestExample | test.example@example.com |   Welcome1! |
	And clicks on Submit button
	Then navigate to login page   

  