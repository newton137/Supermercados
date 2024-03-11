var Srfin = angular.module('Srfin', []);
Srfin.controller('miControlador', function($scope){
    $scope.clientes = [
    {id:'1',nombre:'Lalo',apellido:'Lopez',telefono:'951 234 5678', correo:'correo@gmail.com'},
    {id:'2', nombre: 'Catalina', apellido: 'García', telefono:'55 123 456 78', correo: 'correo2@hotmail.com'}];
    }
    );