# TextSortTest

## User Story
* As a statistician
* I want to analyse a paragraph of text
* So I can see all the words ordered alphabetically


## Acceptance Criteria
The result of the operation should adhere to the following:
| Acceptance Criteria | Input paragraph | Output |
|:------------------- | ---------------:| ------:|
|The words should be ordered alphabetically|`Zebra Apple`|`Apple Zebra`|
|Words should also be ordered from upper-case to lower-case|`Zebra aPple Apple`|`Apple aPple Zebra`|
|All `.,;'` characters should be removed|`Zebra, Apple`|`Apple Zebra`|
|Do not remove duplicate words|`Zebra Zebra`|`Zebra Zebra`|


## Hints and tips
* Please approach this as you would a pair-programming exercise. Talk about what you are doing and why. It's more important for us to understand your approach and thought process than your code.
* Using the internet is allowed and so is asking for help, but please don't use any AI.
* Everything in the solution can (and probably should) be changed.
* Demonstration of OOP and SOLID principles is important, even though it could be considered over-engineering for this simple task.
* Demonstration of solution architecture and project structure is also important.
* Ensure the code quality and style meets your own expectations (including tests).
