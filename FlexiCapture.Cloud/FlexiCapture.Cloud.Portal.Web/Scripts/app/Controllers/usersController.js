﻿function actionFormatterUser(value, row, index) {
    return [
        '<button class="btn btn-info orange-tooltip edit-user" href="javascript:void(0)" title="Edit" style=" text-align: center;" ',
        'data-toggle="tooltip" title="Edit User"  data-placement="bottom">',
        '<i class="glyphicon glyphicon-edit"></i>',
        '</button>'
    ].join('');
}

(function () {


    var usersController = function ($scope, $http, $location, $state, $uibModal, $log, $window, $filter, usSpinnerService, usersHttpService) {

        var url = $$ApiUrl + "/users";
        var data = [];
        
        
        $scope.loading = true;
        var getToUsersList = function () {
            usersHttpService.getToUsersList($http, $scope, $state, data, url, usSpinnerService)
        };
        getToUsersList();
        
        $window.actionEventsUser = {            
            'click .edit-user': function (e, value, row, index) {
                $scope.updateUser(row);
            }
        };
        $scope.updateUser = function (row) {
            // var singleUser = {};
            // var userId = row.userId;
            // for(i=0; i<$scope.users.length; i++){
            //     if($scope.users[i].UserData.Id == userId){
            //         singleUser = angular.copy($scope.users[i]);
            //     }
            // }
            // $scope.gotoAddNewUserView(singleUser);
        }

        //add new user btn event
        $scope.gotoAddNewUserView = function (user) {
            
            // if (user) {
            //     $scope.isEdit = true;
            // }
            // else {
            //     user = {};
            //     $scope.isEdit = false;
            // }
            
            // $scope.user = user;

            // var modalInstance = $uibModal.open({
            //     templateUrl: 'PartialViews/UserManagement.html',
            //     controller: manageUserController,
            //     controllerAs: 'vm',
            //     scope: $scope,
            //     resolve: {
            //         items: function () {
            //             return $scope.items;
            //         }
            //     }
            // });

            // modalInstance.result.then(function () {
            //     $log.info(JSON.stringify($scope.user));
            //     if ($scope.user.UserData.Id == undefined) $scope.isEdit = false;

            //     if (!$scope.isEdit) {
            //         $scope.user.UserData.Id = -1;
            //         $scope.user.LoginData.UserLoginStateId = 1;// состояние логина Активно
            //     }

            //     usersHttpService.manageUser($http, $scope, data, url, usSpinnerService, $scope.isEdit);
            // }, function () {
            //     $log.info('Modal dismissed at: ' + new Date());
            // });
        }
    };




    fccApp.controller("usersController", ["$scope", "$http", "$location", "$state", "$uibModal", "$log","$window", "$filter", "usSpinnerService", "usersHttpService", usersController]);
} ())