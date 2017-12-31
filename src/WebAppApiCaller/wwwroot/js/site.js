
var myHeaders = new Headers();
var init = {
    method: 'GET',
    headers: myHeaders,
    mode: 'cors',
    cache: 'default'
};

var div = document.getElementById("result");
fetch('https://azurefunctionappfun.azurewebsites.net/api/PersonFunction?code===&personId=7', init)
    .then(function (response) {
        if (response.ok) {
            return response.json();
        }
        throw new Error('Network response was not ok.');
    }).then(function (json) {
        div.textContent = JSON.stringify(json);
    }).catch(function (error) {
        div.textContent = 'There has been a problem with your fetch operation: ' + error.message;
    });