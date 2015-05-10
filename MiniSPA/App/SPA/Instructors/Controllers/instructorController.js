var customerModule = angular.module('customerModule');
customerModule.controller('instructorController', ['$scope', 'bootstrappedData', function ($scope, bootstrappedData) {
    $scope.instructors = bootstrappedData.instructors;
}]);