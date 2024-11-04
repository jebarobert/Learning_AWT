var myApp = angular.module("myModule",[]);
myApp.controller("myController",function($scope)
{
    var employees =[
        {
            name:"Alpha", gender:"Male", city:"London",salary:50000
        },
        {
            name:"Beta", gender:"Female", city:"Paris",salary:68000
        },
        {
            name:"Gamma", gender:"Male", city:"New York",salary:57000
        },
        {
            name:"Delta", gender:"Male", city:"Netherland",salary:50000
        },
        {
            name:"Frox", gender:"Male", city:"Switzerland",salary:50000
        }
    ];
    $scope.employees = employees;
});