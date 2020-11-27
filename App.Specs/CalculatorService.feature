Feature: CalculatorService
	In order to avoid silly mistakes
	As a math novice
	I want to be told the sum of two numbers

@noactions
Scenario: No additions or subtractions
	When the numbers are calculated
	Then the result should be 0

@addnumbers
Scenario: Add two numbers
	Given the first number of 50.2 is added
	And the second number of 70.8 is added
	When the numbers are calculated
	Then the result should be 121

@addandsubtractnumbers
Scenario: Add two numbers and subtract one
	Given the first number of 50 is added
	And the second number of 70 is added
	And the third number of 10 is subtracted
	When the numbers are calculated
	Then the result should be 110