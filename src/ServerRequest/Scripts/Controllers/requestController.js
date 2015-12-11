(function () {
    'use strict';

    angular
        .module('serverRequestApp')
        .controller('requestController', requestController);

    requestController.$inject = ['$scope', 'Requests'];

    function requestController($scope, Requests) {
        $scope.request = Requests.query();
    }
})();
