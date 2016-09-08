var app = angular.module( 'myApp', [] );
app.controller( 'actividadController', function ( $scope, $http )
{
    $scope.cantidades = [1, 2, 3, 4, 5];
    $scope.prueba = [2];
    $http.get( "/api/actividad" ).then( function ( response )
    {
        $scope.actividades = response.data;
    } );

    $http.get( "/api/base" ).then( function ( response )
    {
        $scope.dias = response.data;
        $scope.totalDias = []
        /*angular.foreach( dia in dias )
        {
            totalDias.push(
                {
                    fecha: dia.Date,
                    tempMin: dia.Temperature.Minimum.Value,
                    tempMax: dia.Temperature.Maximum.Value,
                    fraseDia: dia.Day.IconPhrase,
                    fraseNoche: dia.Night.IconPhrase,
                }
            );
        };*/
    } );

    $scope.mostrar = function ()
    {
        var config = {
            days: $scope.totalDias,
            actividad: $scope.actividadSeleccionada,
            cantidad: $scope.diaSeleccionado,
        };
        $http.get( '/api/dia', config )
           .success( function ( data, status, headers, config )
           {
               $scope.prueba.push( config.days );
           } );
    };
} );
