using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Pedidos
/// </summary>
namespace proyecto1.Model
{
    public class Pedidos
    {
        private String _opcion;

        public String opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }
        private int _idPedido;

        public int idPedido
        {
            get { return _idPedido; }
            set { _idPedido = value; }
        }
        private int _idSucursal;

        public int idSucursal
        {
            get { return _idSucursal; }
            set { _idSucursal = value; }
        }

        private int _idEmpleado;

        public int idEmpleado
        {
            get { return _idEmpleado; }
            set { _idEmpleado = value; }
        }

        private int _idCliente;

        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }

        private String _fecha;

        public String fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        private String _hora;

        public String hora
        {
            get { return _hora; }
            set { _hora = value; }
        }
        public Pedidos(String pOpcion, int pIdPedido, int pIdEmpleado, int pIdSucursal, int pIdCliente, String pFecha, String pHora)
        {
                this.opcion = pOpcion;
                this.idPedido = pIdPedido;
                this.idEmpleado = pIdEmpleado;
                this.idSucursal = pIdSucursal;
                this.idCliente = pIdCliente;
                this.fecha = pFecha;
                this.hora = pHora;
         }

        public Pedidos()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}