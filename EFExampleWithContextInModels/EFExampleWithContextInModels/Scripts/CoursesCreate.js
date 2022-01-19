angular
    .module('inputIconDemo', ['ngMaterial', 'ngMessages'])
    .controller('DemoCtrl', function ($scope) {
        $scope.user = {
            name: 'John Doe',
            Teacher Id: '',
            Id: '',
            description: 'Mountain View, CA',
            
        };
    });