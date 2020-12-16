const { Given, When, Then } = require("cucumber");
const assert = require("assert").strict
const Calculator = require('../../calculator');

Given('input set to {}', function (str) {
    // Given('input set to {int} {float} +', function (int, float) {
    // Given('input set to {float} {int} +', function (float, int) {
    // Given('input set to {float} {float} +', function (float, float2) {
    // Write code here that turns the phrase above into concrete actions
    this.calculator = new Calculator(str);
});

Then('the result should equal {}', function (val) {
    // Then('the result should equal {float}', function (float) {
    // Write code here that turns the phrase above into concrete actions
    assert.equal(this.calculator.calculate(), +val);
});