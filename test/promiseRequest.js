const request = require('request');

function promiseRequest(id) {
    const url = `https://google.com`

    return new Promise((resolve, reject) => {
        request.get(url, (err, req, res) => {
            if (err) return reject(err);
            resolve(JSON.parse(res));
        });
    })
}

module.exports = promiseRequest