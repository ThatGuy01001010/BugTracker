(function () {
    angular.module('BugTracker')
    .service('registerService', function ($http) {
        var self = this;

        self.register = function (newUser, callback) {

            $http.post('api/Account/Register', newUser)
            .success(function (result) {
                callback();

            });
        };
    });
})();