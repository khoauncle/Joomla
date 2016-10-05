Feature: TC_JOOMLA_ARTICLE_001
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

Background: 
	Given Open Firefox Browser
	Given Navigate to the URL: "http://localhost/Joomla/administrator/index.php"

@mytag
# TC_JOOMLA_ARTICLE_001: Create new article with valid information
Scenario: Create new article with valid information
	Given Enter username "admin" and password "admin"
	Given Click on Create Article link
	Given Enter "Shen Title" "Uncategory" "Shen Content" on Title, Category, Content field
	When Click on "Save & Close" icon of the top right toolbar
	Then Verify the article is saved successfull with text: 'Article successfully saved.'