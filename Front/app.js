var accountApp = angular.module('accountApp', []);

accountApp.controller('mainController', function($scope, $http){
    $scope.bank = {id:0, name:""};
    $scope.clientName = '';
    $scope.accountNumber = '';
    $scope.accountType = 0;
    $scope.openingBalance = '';
    $scope.currency = 0;
    $scope.currencyList = ['EGP', 'Euro', 'Dollar'];
    $scope.accountTypeList = ['Current', 'Saving', 'Deposit'];

    $http
    ({
        method: 'GET',
        url: 'http://localhost:5077/Bank'
    }).then(function success(result){
           
            $scope.bankList = result.data; 
            console.log($scope.bankList);
        },function error(result) {

            console.log(result);

        });
    $scope.submit= function(bank, clientName, accountNumber, accountType, openingBalance, currency){
        var clientData = {
            accountNumber: accountNumber,
            name: clientName,
            openingBalance: openingBalance,
            currency: currency,
            accountType: accountType,
            bankId: bank.id
        }
        $http
        ({
            method: 'POST',
            url: 'http://localhost:5077/Client',
            data: clientData
        }).then(function success(response){
            if(response.data)
            $scope.msg="Data Submitted Successfully!!";
        }, function error(result) {
            $scope.msg = "Service Didn't Work!!";
            console.log(result);

        });
    $scope.bank = {id:'', name:""};
    $scope.clientName = '';
    $scope.accountNumber = '';
    $scope.accountType = '';
    $scope.openingBalance = '';
    $scope.currency = '';
    
        var popup = document.getElementById("submitModal");
        popup.modal("show");


    }
    

    
    });

    
