﻿fccApp.service('storeHttpService', function () {
     

    //add or Edit user
    this.setServiceState = function ($http, $scope, url, usSpinnerService,serviceState) {


        usSpinnerService.spin("spinner-1");
        var methodType = "POST";
        
        $http({
            url: url,
            method: methodType,
            contentType: "application/json",
            data: JSON.stringify(serviceState)
        })
            .then(function (response) {
                usSpinnerService.stop('spinner-1');
                $scope.loadData = false;
               switch (serviceState.ServiceId) {
                case 2:
                    $scope.userData.ServiceData.BatchFileConversionService = !$scope.userData.ServiceData.BatchFileConversionService;
                    break;

                case 4:
                    $scope.userData.ServiceData.EmailAttachmentFileConversionService = !$scope.userData.ServiceData.EmailAttachmentFileConversionService;
                    break;

                case 3:
                    $scope.userData.ServiceData.FTPFileConversionService = !$scope.userData.ServiceData.FTPFileConversionService;
                    break;

            }
                 usSpinnerService.stop('spinner-1');
                showNotify("Success", "Service State Updating Successfull", "success");
            },
            function (response) { // optional
                // failed
                usSpinnerService.stop('spinner-1');
                showNotify("Error", "Service State Updating Error ", "danger");
               
            });
    }
});