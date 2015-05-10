var customerModule = angular.module('customerModule');
customerModule.controller('customerController', ['$scope', 'bootstrappedData', function ($scope, bootstrappedData) {
    $scope.customerData = bootstrappedData.customers;
    var data = new kendo.data.DataSource({
        data: $scope.customerData
    });
    $scope.gridOptions = {
        dataSource: data,
        columns: [{ field: "number", title: "Number", width: "20px" }, { field: "name", title: "Name", width: "20px" }, { field: "city", title: "City", width: "20px" }]
    };
}]);