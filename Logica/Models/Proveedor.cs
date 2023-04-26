﻿using Logica.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Models
{
    public class Proveedor
    {
        public int ProveedorID { get; set; }
        public string ProveedorNombre { get; set; }
        public string ProveedorCedula { get; set; }
        public string ProveedorEmail { get; set; }
        public string ProveedorDireccion { get; set; }
        public string ProveedorNotas { get; set; }
        public bool Activo { get; set; }

        public bool Agregar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Editar()
        {
            throw new System.Exception("Not implemented");
        }
        public bool Eliminar()
        {
            throw new System.Exception("Not implemented");
        }
        public Proveedor ConsultarPorCedula(ref string cedula)
        {
            throw new System.Exception("Not implemented");
        }
        public Proveedor ConsultarPorEmail(ref string email)
        {
            throw new System.Exception("Not implemented");
        }
        public Proveedor ConsultarPorID(ref int id)
        {
            throw new System.Exception("Not implemented");
        }

        public DataTable Listar(bool verActivos = true, string FiltroBusqueda = "")
        {
            DataTable R = new DataTable();

            Conexion MiCnn = new Conexion();

            MiCnn.ListaDeParametros.Add(new SqlParameter("@VerActivos", verActivos));
            MiCnn.ListaDeParametros.Add(new SqlParameter("@FiltroBusqueda", FiltroBusqueda));

            R = MiCnn.EjecutarSELECT("SPProveedorListar");

            return R;
        }

        public TipoProveedor MiTipoProveedor;

        public Proveedor()
        {
            MiTipoProveedor = new TipoProveedor();
        }

    }
}