app.service("ProductService", function ($http) {
    this.GetTest = function () {
        var request = $http({
            method: "GET",
            url: "/Home/GetTest",
            dataType: 'json',
            contentType: 'application/json; charset=utf-8'
        });
        return request;
    };
});

app.controller('ProductController', function ($scope, ProductService) {
    $scope.ShowHello = function () {
        alert("hello product");
    };
});