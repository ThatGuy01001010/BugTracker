(function () {
    angular.module('BugTracker')
    .controller('registerController', function (registerService, $location) {
        var vm = this;

        vm.register = function () {
            registerService.register(vm.newUser, function (result) {               
                
                $location.path('/');
            });
        };
    });
})();