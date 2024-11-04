var myApp = angular.module("myModule",[]);
myApp.controller("myController",function($scope)
{
    var technology =[
        {name:"C",likes:0,dislikes:0},
        {name:"C++",likes:0,dislikes:0},
        {name:"C#",likes:0,dislikes:0},
        {name:".NET",likes:0,dislikes:0}
    ];
    $scope.technology = technology;
    $scope.IncreementLikes = function(technology){technology.likes++;};
    $scope.IncreementDislikes = function(technology){technology.dislikes++;};
});