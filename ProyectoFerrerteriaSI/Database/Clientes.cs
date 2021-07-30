﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFerrerteriaSI.Database
{
    public class Clientes: Conexion
    {
        public string CodCliente { get; set; }
        public string NomCliente { get; set; }
        public string ApeCliente { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }

        public bool Insertar()
        {
            var db = GetConexion();//database
            db.Open();
            SqlCommand command = new SqlCommand("sp_insertCliente" ,db );
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddWithValue("@CodCliente",CodCliente);
            command.Parameters.AddWithValue("@NomCliente",NomCliente);
            command.Parameters.AddWithValue("@ApeCliente",ApeCliente);
            command.Parameters.AddWithValue("@Direccion",Direccion);
            command.Parameters.AddWithValue("@Telefono",Telefono);
           

            var row=command.ExecuteNonQuery();
            db.Close();
            return row > 0;



        }


    }
}
