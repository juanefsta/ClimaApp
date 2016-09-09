var app = angular.module( 'myApp', [] );
app.controller( 'actividadController', function ( $scope, $http )
{
    $scope.cantidades = [1, 2, 3, 4, 5];
    $scope.prueba = [];
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
            actividad: $scope.actividadSeleccionada,
            cantidad: $scope.diaSeleccionado,
        };
        $http.post( '/api/dia', config )
           .success( function ( data, status, headers, config )
           {               
               $scope.prueba.push( data);
           } );
    };
} );
