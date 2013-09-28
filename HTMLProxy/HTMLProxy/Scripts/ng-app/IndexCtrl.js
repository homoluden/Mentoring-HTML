'use strict';

var IndexCtrl = function($scope, $http) {

}

var TabsCtrl = function ($scope) {
    $scope.tabs = [
    { title: "Приватность", content: "Содержимое вкладки Приватность" },
    { title: "Оповещения", content: "Содержимое вкладки Оповещения" },
    { title: "Чёрный список", content: "Содержимое вкладки Чёрный список" },
    { title: "Мобильные сервисы", content: "Содержимое вкладки Мобильные сервисы" },
    { title: "Баланс", content: "Содержимое вкладки Баланс" },
    ];

    //$scope.alertMe = function () {
    //    setTimeout(function () {
    //        alert("You've selected the alert tab!");
    //    });
    //};

    $scope.navType = 'pills';
}

angular.module('mentApp.controllers', [])
    .controller('IndexCtrl', ['$scope', '$http', IndexCtrl])
    .controller('TabsCtrl', ['$scope', TabsCtrl]);