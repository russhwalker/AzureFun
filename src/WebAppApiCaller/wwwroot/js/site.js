// Write your JavaScript code.

var myHeaders = new Headers();

var init = {
    method: 'GET',
    headers: myHeaders,
    mode: 'cors',
    cache: 'default'
};

fetch('', init)
    .then(function (response) {
        if (response.ok) {
            return response.json();
        }
        throw new Error('Network response was not ok.');
    }).then(function (json) {
        alert(JSON.stringify(json));
    }).catch(function (error) {
        console.log('There has been a problem with your fetch operation: ', error.message);
    });