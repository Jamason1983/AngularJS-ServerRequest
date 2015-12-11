(function () {
    'use strict';
    var requestService = angular.module('requestService', ['ngResource']);

    requestService.factory('Requests', ['$resource', function ($resource) {
        return $resource('/api/request/', {}, {
            query: { method: 'GET', params: {}, isArray: true }
        });
    }]);
});