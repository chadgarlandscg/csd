module.exports = class RPN {
    constructor(str) {
        this.str = str;
    }

    calculate() {
        const chars = this.str.split(' ');
        switch (chars[2]) {
            case '+':
                return +chars[0] + +chars[1]
            case '-':
                return +chars[0] - +chars[1]
            case '*':
                return +chars[0] * +chars[1]
            case '/':
                return +chars[0] / +chars[1]
            default:
                break;
        }
    }
}