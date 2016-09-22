Feature: TC_JOOMLA_ARTICLE_001
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given Open Firefox Browser
@mytag
Scenario: Create new article with valid information
	Given Navigate to the URL: "http://192.168.189.119/abyssal/administrator/index.php"
	Given Enter username "long.ngoc.nguyen" and password "123456"
	Given Click on Create Article link
	Given Enter "Shen Title" "Uncategory" "Shen Content" on Title, Category, Content field
	When Click on "Save & Close" icon of the top right toolbar
	Then Verify the article is saved successfull