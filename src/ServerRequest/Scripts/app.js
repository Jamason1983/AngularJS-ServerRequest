var app = angular.module("app", ['smart-table']);
app.controller('requestController', ['$scope', '$http', '$log', function ($scope, $http, $log) {

    $scope.itemCollection = [];
    console.log(JSON.stringify('Start jsonp to /api/request'));
    $http({
        url: 'api/request',
        method: 'GET',
        headers: { 'Accept': 'application/json' }
    }).then(function (responce) {
        $scope.itemCollection = responce.data;
        $scope.displayedCollection = [].concat($scope.itemCollection);
    }).finally(function () {
        
    });
}]);