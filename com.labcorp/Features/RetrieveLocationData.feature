Feature: LabcorpLoginPage

 In order to oprn the browser as a QA tester 
 I want to ensure webpage is working end to end 

@tag1
Scenario: As a user I should open a bowser and navigate to careers link and search for active positin and validate 
		  Job title, Job Location, Job Id then click on applay button and validate Job title,Job Location and JobId on the 
		  proceeding page then click to return Job Search button.

	Given As a user I should naviagte to labcorp webpage
	And   As a user I should find and click careers link
	Then  As a user I should search for active position 
	And   Add assertions con confirm Job Title,Job Location, JobId
	And   And 3 other assertion of the choice
	And   Clcik Applay Now button and confirm Job Title,Job Location, JobId on the proceeding page
	Then  Click to Return to Job Search 
	 