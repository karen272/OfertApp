﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertApp.Modelo
{
    internal class Usuario
    {
        private int id;
        private string nombre;
        
        public Usuario() { }

        public Usuario (int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Nombre
        {
            get { return nombre;}
            set { nombre = value; }
        }
    }
}
