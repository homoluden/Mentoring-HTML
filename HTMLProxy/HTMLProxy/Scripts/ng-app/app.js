'use strict';

angular.module('mentApp', ['mentApp.controllers']).
  config(['$routeProvider', function ($routeProvider) {
      $routeProvider.when('/', { templateUrl: '/Content/partials/index.html', controller: 'IndexCtrl' });
      $routeProvider.when('/proxy', { templateUrl: '/Content/partials/proxy.html', controller: 'ProxyCtrl' });
      $routeProvider.when('/404', { templateUrl: '/Content/partials/404.html', controller: '404Ctrl' });
      $routeProvider.otherwise({ redirectTo: '/404' });
  }]);