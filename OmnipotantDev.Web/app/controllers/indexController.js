'use strict';
app.controller('indexController', ['$scope', '$location', 'authService', function ($scope, $location, authService) {

    $scope.logOut = function() {
        authService.logOut();
        $location.path('/games');
    };

    $scope.authentication = authService.authentication;

}]);