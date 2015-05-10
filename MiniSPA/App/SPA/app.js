var customerModule = angular.module('customerModule', ['kendo.directives', 'ngRoute']);
customerModule.config(function ($routeProvider, $locationProvider) {

    $routeProvider.when('/Main/Customers', {
        templateUrl: "/App/SPA/Customers/Partials/customers.html",
        controller: "customerController"
    });
    $routeProvider.when('/Main/Instructors', {
        templateUrl: "/App/SPA/Instructors/Partials/instructors.html",
        controller: "instructorController"
    });
    $locationProvider.html5Mode({ enabled: true, requireBase: false });
});

