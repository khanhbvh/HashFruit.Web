app.service("HomeService", function ($http) {
    var root = 'http://jsonplaceholder.typicode.com';

    this.GetTest = function () {
        var request = $http({
            method: "GET",
            url: root + '/users',
            dataType: 'json',
            contentType: 'application/json; charset=utf-8'
        });
        return request;
    };
});

app.controller('HomeController', function ($scope, HomeService) {
    $scope.ShowHello = function () {
        Pace.restart();
        var result = HomeService.GetTest2();
        result.then(function (pl) {
            if (!pl.data.IsError) {

            }
            alert("hello angular");
        },
        result.catch(function (pl) {

        }),
        function (errorPl) {
        });
    };

    $scope.ShowMessage = function () {
        AlertMessage('fa fa-info', 'Test Title', 'Info message');
    };
});