(function () {
    angular.module('BugTracker')
    .controller('loginController', function (loginService, $location) {
        var vm = this;

        vm.login = function () {
            loginService.login(vm.newUser, function () {
                $location.path('/');
            });
        };

    });
})();