var myApp = angular.module('myModule', []);
myApp.controller('myController', function ($scope) {
    var employee={
        Firstname: "Jeba",
        Lastname: "Robert",
        Gender: "Female",
        Photo: "Scripts/rose.jpg"
        };        
    $scope.employee = employee;

});