var app = angular.module('myApp', []);
app.controller( 'actividadController', function ( $scope, $http )
{
    $http.get( "/api/actividad" ).then( function ( response )
    {
        $scope.actividades = response.data;
    } );

    $http.get( "/api/base" ).then( function ( response )
    {
        $scope.dias = response.data;
    } );

} );
