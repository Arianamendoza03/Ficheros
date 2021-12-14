using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ficheros
{
    public partial class frmExplorador : Form
    {
        public frmExplorador()
        {
            InitializeComponent();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            string carpeta = this.txtCarpeta.Text;
            DirectoryInfo di = new  DirectoryInfo(carpeta);

            //recorro la lista de archivos y lo almaceno en el listbox
            this.listaArchivos.Items.Clear();
            foreach (var archivo in di.GetFiles())
            {
                this.listaArchivos.Items.Add(archivo);

            }
        }
    }
}
