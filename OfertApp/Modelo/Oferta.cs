using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfertApp.Modelo
{
    internal class Oferta
    {
        private int idOferta;
        private Usuario usuario;
        private double precio;
        private string descripcion;
        private DateTime vigenciaDesde;
        private DateTime vigenciaHasta;

        public Oferta() { }

        public Oferta(int idOferta,Usuario usuario,double precio,string descripcion,DateTime vigenteDesde,DateTime vigenteHasta)
        {
            this.idOferta = idOferta;
            this.usuario = usuario;
            this.precio = precio;
            this.descripcion= descripcion;
            this.vigenciaDesde = vigenciaDesde;
            this.vigenciaHasta = vigenciaHasta;
        }

        public int IdOferta
        {
            get { return idOferta; }
            set { idOferta = value; }
        }

        public Usuario Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public double Precio 
        { 
            get { return precio; } 
            set { precio = value; } 
        }

        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public DateTime VigenciaDesde
        {
            get { return vigenciaDesde; }
            set { vigenciaDesde = value; }
        }
        public DateTime VigenciaHasta
        {
            get { return vigenciaHasta; }
            set { vigenciaHasta = value; }
        }




    }
}
