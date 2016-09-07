var app = angular.module('myApp', []);
app.controller( 'actividadController', function ( $scope, $http )
{
    $scope.cantidades = [1, 2, 3, 4, 5];
    $http.get( "/api/actividad" ).then( function ( response )
    {
        $scope.actividades = response.data;
    } );

    $http.get( "/api/base" ).then( function ( response )
    {
        $scope.dias = response.data;
    } );
    
    $scope.mostrar = function ()
    {
        var config = {
            days: $scope.dias,
            actividad: $scope.actividades,
            cantidad: $scope.cantidades,
        };
        $http.get( '/api/base', config )
           .success( function ( data, status, headers, config )
           {
               $scope.Details = data;
           });
    };     
});
