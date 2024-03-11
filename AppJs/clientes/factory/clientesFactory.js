Srfin.factory('clientesFactory', ['$http', '$rootScope', function ($http, $rootScope) {

    var rListaClientesWeb = {};
    var oResAddClt = {};


    return {
        getListaClientesWeb: function (oConDatoCliente) {
            //Lista las operaciones actuales
            return $http.post("AppJs/clientes/controller/getClientesList.ashx", JSON.stringify(oConDatoCliente)).then(function (dataListCltW) {
                rListaClientesWeb = dataListCltW.data;
                return rListaClientesWeb;


            })
        },

        crudClienteWeb: function (datoClienteAdd) {
            //L´pednuete
            return $http.post("AppJs/Clientes/controller/crudClientesWeb.ashx", JSON.stringify(datoClienteAdd)).then(function (resDataClAdd) {
                oResAddClt = resDataClAdd.data;
                return oResAddClt;

            })
        }



    };
} ]);
