'use strict';

var IndexCtrl = function($scope, $http) {
    $scope.topLinks = [
        { title: "люди", href: "/#", showIcon: false, showText: true },
        { title: "сообщества", href: "/#", showIcon: false, showText: true },
        { title: "игры", href: "/#", showIcon: false, showText: true },
        { title: "музыка", href: "/#", showIcon: false, showText: true },
        { iconClass: "glyphicon glyphicon-play", href: "/#", showIcon: true, showText: false },
        { title: "помощь", href: "/#", showIcon: false, showText: true },
        { title: "выйти", href: "/#", showIcon: false, showText: true }
    ];

    $scope.sideLinks = [
        { title: "Моя Страница", href: "/#", showIcon: false, showText: true },
        { title: "Мои Друзья", href: "/#", showIcon: false, showText: true },
        { title: "Мои Фотографии", href: "/#", showIcon: false, showText: true },
        { title: "Мои Видеозаписи", href: "/#", showIcon: false, showText: true },
        { title: "Мои Аудиозаписи", href: "/#", showIcon: false, showText: true },
        { title: "Мои Сообщения", href: "/#", showIcon: false, showText: true },
        { title: "Мои Заметки", href: "/#", showIcon: false, showText: true },
        { title: "Мои Группы", href: "/#", showIcon: false, showText: true },
        { title: "Мои Новости", href: "/#", showIcon: false, showText: true },
        { title: "Мои Закладки", href: "/#", showIcon: false, showText: true },
        { title: "Мои Настройки", href: "/#", showIcon: false, showText: true }
    ];

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