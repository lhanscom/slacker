    angular
        .module('slacker')
        .controller('songListController', songListController);

    songListController.$inject = [
        '$scope', '$http', '$q', 'dataContext'];

    function songListController($scope, $http, $q, dataContext) {
        $scope.title = 'songListController';
        var vm = this;
        vm.orderField = 'Name';
        vm.reverse = true;
        vm.sortList = sortList;

        vm.setOrderField = setOrderField;
        vm.songs = [];

        activate();

        function activate() {
            getSongs();
        }


        function getSongs() {
            return dataContext.getSongs()
            .then(success);

            function success(songs) {
                vm.songs = songs;
                return vm.songs;
            }

        }

        function setOrderField(fieldName) {
            vm.orderField = fieldName;
        }

        function sortList(field) {
            vm.reverse = (vm.orderField === field) ? !vm.reverse : false;
            vm.orderField = field;
        }

    }

