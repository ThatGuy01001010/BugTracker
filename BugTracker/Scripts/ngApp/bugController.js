(function() {
    angular.module('BugTracker')
    .controller('bugController', function (bugService, $location) {
        var vm = this;

        vm.bugs = bugService.list();

        vm.add = function () {
            bugService.add(vm.newBug, function (result) {
                vm.bugs.push(result);
                $('#addForm')[0].reset();
            });
        };
        vm.update = function (bug) {
            bugService.update(bug);
        };
    });
})();