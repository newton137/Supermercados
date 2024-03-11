using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Clientes
/// </summary>
namespace proyecto1.Model
{
    public class Clientes
    {
        private String _opcion;

        public String opcion
        {
            get { return _opcion; }
            set { _opcion = value; }
        }
        private int _idCliente;

        public int idCliente
        {
            get { return _idCliente; }
            set { _idCliente = value; }
        }
        private String _nombre;

        public String nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        private String _apellido;

        public String apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }


        private String _correo;

        public String correo
        {
            get { return _correo; }
            set { _correo = value; }
        }

        private String _telefono;

        public String telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public Clientes(String pOpcion, int pIdCliente, String pNombre, String pApellido, String pCorreo, String pTelefono)
            {
                this.opcion = pOpcion;
                this.idCliente = pIdCliente;
                this.nombre = pNombre;
                this.apellido = pApellido;
                this.correo = pCorreo;
                this.telefono = pTelefono;


            }

        public Clientes()
        {
            //
            // TODO: Agregar aquí la lógica del constructor
            //
        }
    }
}