var app = angular.module("app", []);
app.controller('requestController', ['$scope', '$http', '$log', function ($scope, $http, $log) {

    $scope.itemCollection = [];
    console.log(JSON.stringify('Start jsonp to /api/request'));
    $http({
        url: 'api/request',
        method: 'GET',
        headers: { 'Accept': 'application/json' }
    }).then(function (responce) {
        $scope.itemCollection = responce.data;
        console.log("Values inside of $http scope: " + $scope.itemCollection.length);
    }).finally(function () {
        console.log("Values outside of $http scope: " + $scope.itemCollection.length);
    });

}]);