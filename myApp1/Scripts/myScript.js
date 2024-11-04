var myApp = angular.module("myModule",[]);
myApp.controller("myController",function($scope)
{
    var Menu=[
        {
            type:"Starters",
            items:[
                {name:"Paneer Chilly"},
                {name:"Chicken Tikka"},
                {name:"hgng"}]
        },
        {
            type:"Main Course",
            items:[
                {name:"Briyani"},
                {name:"wad"},
                {name:"akuysdh"}]
        },
        {
            type:"Desserts",
            items:[
                {name:"kjusyDh"},
                {name:"uiskyd"},
                {name:"p;ois"}]
        }
    ];
    $scope.Menu = Menu;
});