(function () {
    angular.module('BugTracker')
    .service('bugService', function ($resource) {
        var self = this;

        var Bug = $resource('api/bug/:id');

        self.list = function () {
            return Bug.query();
        }

        self.add = function (bug, callback) {
            var newBug = new Bug({
                title: bug.title,
                description: bug.description,
                priority: bug.priority,
                assignedUser: bug.assignedUser,
                status: bug.status
            });
            newBug.$save(callback);

        };
        self.update = function (bug) {
            bug.$save();
        };
    });
})();