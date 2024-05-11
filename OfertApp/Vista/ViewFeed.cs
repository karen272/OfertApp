using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OfertApp.Vista
{
    public partial class ViewFeed : Form
    {
        public ViewFeed()
        {
            InitializeComponent();
        }

        private void btnSubirOfeta_Click(object sender, EventArgs e)
        {
            ViewOferta oferta = new ViewOferta();
            oferta.ShowDialog();
        }
    }
}
