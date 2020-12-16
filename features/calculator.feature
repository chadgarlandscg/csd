# features/calculator.feature
Feature: Simple maths
  In order to do maths
  As a developer
  I want to increment variables

#   Scenario: easy maths
#     Given a variable set to 1
#     When I increment the variable by 1
#     Then the variable should contain 2

  Scenario Outline: checking a matrix
    Given input set to <input>
    Then the result should equal <result>

    Examples:
      | input   | result |
      | 100 5 + |    105 |
      | 100 5 - |    95 |
      | 100 5 * |    500 |
      | 100 5 / |    20 |