Feature: CalculatorService
	In order to avoid silly mistakes
	As a math novice
	I want to be told the sum of two numbers

@noactions
Scenario: No additions or subtractions
	When the numbers are calculated
	Then the result should be 0

@addactions
Scenario: An add operation is sent
	Given the operation is sent:
	| Operation | Value |
	| Add | 10.5 |
	When the numbers are calculated
	Then the result should be 10.5

@subtractactions
Scenario: An subtract operation is sent
	Given the operation is sent:
	| Operation | Value |
	| Subtract | 10.5 |
	When the numbers are calculated
	Then the result should be -10.5

@subtractnumbers
Scenario: Subtract two numbers, add none
	When the number of 10 is subtracted
	And the number of 10 is subtracted
	When the numbers are calculated
	Then the result should be -20

@addnumbers
Scenario: Add two numbers
	Given the number of 50.2 is added
	And the number of 70.8 is added
	When the numbers are calculated
	Then the result should be 121

@addandsubtractnumbers
Scenario: Add numbers and subtract one
	Given the number of 50 is added
	And the number of 70 is added
	And the number of 10 is subtracted
	When the numbers are calculated
	Then the result should be 110