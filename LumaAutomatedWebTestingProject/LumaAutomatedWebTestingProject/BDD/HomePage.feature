Feature: HomePage

As a registered user I want to be able to 
navigate across the homepage so that i can see items

@HomePage
@Happy
Scenario: Homepage buttons take us to the correct page
	Given I am on the home page
	When I click on <Menu Button>
	Then it takes me to the <correct page url>
Examples: 
| Menu Button | correct page url|
| What's New  | What's New Page |
| Women       | Women's Page    |
| Men         | Men's Page      |
| Gear        | Gear Page       |
| Training    | Training Page   |
| Sale        | Sale Page       |

# What's New id="ui-id-3"
# Women id="ui-id-4"
# Men id="ui-id-5"
# Gear id="ui-id-6"
# Training id="ui-id-7"
# Sale id="ui-id-8"

@HomePage
@Happy
Scenario: When you hover over the menu buttons they bring drop down menus
	Given I am on the home page
	When I hover over <Menu Button>
	Then it brings up a <drop down menu>
Examples: 
| Menu Button | drop down menu  |
| Women       | Women's Page    |
| Men         | Men's Page      |
| Gear        | Gear Page       |
| Training    | Training Page   |

# Drop Down Menu
# 

