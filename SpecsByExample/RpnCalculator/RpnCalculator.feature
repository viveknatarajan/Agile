Feature: RpnCalculator

Scenario Outline: Acceptance Tests
Given user opens RpnCalculator
When user enters <expression>
Then user is displayed <result>

Examples: 
| expression          | result |
| "5 1 2 + 4 * + 3 -" | 14     |
| "2 3 11 + 5 - *"    | 18     |