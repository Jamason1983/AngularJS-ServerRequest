var app = angular.module("app", ['smart-table']);
var domainSelectedValue = "";
var osSelectedValue = "";
app.controller('requestController', ['$scope', '$http', '$log', function ($scope, $http, $log) {
    //Initalize scope values.
    $scope.showDetails = false;
    $scope.serverForm = {}
    $scope.serverForm.serverRequestorVal = "jamason";
    $scope.serverForm.serverNameVal = '';
    $scope.serverForm.serverDomainVal = {};
    $scope.serverForm.serverOSVal = {};
    $scope.serverForm.serverDatacenterVal = {};
    $scope.serverForm.serverCoresVal = {};
    $scope.serverForm.serverRAMVal = {};
    $scope.itemCollection = [];
    $scope.serverDetailsObject = {}

    $scope.serverForm.serverDrives = [
        { Size: 60, DriveId: "C:", DisplayName: "OS" }
    ];

    $scope.addServerDrive = function (size, driveId, displayName) {
        var newvalue = { Size: size, DriveId: driveId, DisplayName: displayName }
        $scope.serverForm.serverDrives.push(newvalue);
        document.getElementById("serverDriveSizeInput").value = "";
        document.getElementById('serverDriveDriveIdInput').value = "";
        document.getElementById('serverDriveDisplayNameInput').value = "";
    };

    $scope.removeServerDrive = function (index) {
        if (index === 0) {

        }
        else {
            $scope.serverForm.serverDrives.splice(index, 1);
        }
    };

    $scope.clearDetails = function () {
        $scope.showDetails = false;
    };

    $scope.viewServerDetails = function (object) {
        $scope.showDetails = true;
        $scope.serverDetailsObject = object;
    };

    
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



    //Server Select|Option arrays

    $scope.serverSubmit = function () {
        var json = {
                "Id": 0,
                "ServerName": $scope.serverForm.serverNameVal,
                "Requestor": $scope.serverForm.serverRequestorVal,
                "Domain": $scope.serverForm.serverDomainVal.value,
                "Datacenter": $scope.serverForm.serverDatacenterVal.value,
                "OS": $scope.serverForm.serverOSVal.value,
                "Cores": $scope.serverForm.serverCoresVal.value,
                "RAM": $scope.serverForm.serverRAMVal.value,
                "Drives": $scope.serverForm.serverDrives
            };
            var dataval = angular.toJson(json);
            console.log(dataval);

        $http({
            url: 'api/request',
            data: dataval,
            method: 'POST',
            headers: { 'Accept': 'application/json' }
        }).then(function (responce) {
            console.log('Success');
            $scope.itemCollection = responce.data;
            $scope.displayedCollection = [].concat($scope.itemCollection);
        }, function errorCallback(response) {
            console.log('Failed :`(');
            alert(response)
        });

    };



    $scope.optionsObjectServerDomains = [{ name: "puget.com", value: "puget" }, { name: "PSETest", value: "psetest" }];
    $scope.optionsObjectServerOSs = [{ name: "Windows 2008 R2", value: "win2008r2" }, { name: "Windows 2012", value: "win2012" }, { name: "Windows 2012 R2", value: "win2012r2" }, { name: "Suse", value: "suse" }];
    $scope.optionsObjectServerDatacenters = [{ name: "Bothel", value: "bothel" }, { name: "Bellevue", value: "bellevue" }];
    $scope.optionsObjectServerCores = [{ name: "1", value: 1 }, { name: "2", value: 2 }, { name: "3", value: 3 }, { name: "4", value: 4 }, { name: "5", value: 5 }, { name: "6", value: 6 }, { name: "7", value: 7 }, { name: "8", value: 8 }, { name: "9", value: 9 }, { name: "10", value: 10 }, { name: "11", value: 11 }, { name: "12", value: 12 }, { name: "13", value: 13 }, { name: "14", value: 14 }, { name: "15", value: 15 }, { name: "16", value: 16 }];
    $scope.optionsObjectServerRAMs = [{ name: "2GB", value: 2 }, { name: "4GB", value: 4 }, { name: "6GB", value: 6 }, { name: "8GB", value: 8 }, { name: "10GB", value: 10 }, { name: "12GB", value: 12 }, { name: "14GB", value: 14 }, { name: "16GB", value: 16 }, { name: "18GB", value: 18 }, { name: "20GB", value: 20 }, { name: "24GB", value: 24 }, { name: "28GB", value: 28 }, { name: "32GB", value: 32 }, { name: "36GB", value: 36 }, { name: "40GB", value: 40 }, { name: "44GB", value: 44 }, { name: "48GB", value: 48 }];

}]);
