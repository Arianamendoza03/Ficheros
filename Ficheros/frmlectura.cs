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
    public partial class frmlectura : Form
    {
        public frmlectura()
        {
            InitializeComponent();
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            //apertura del archivo
           try
            { 
             
                string file = this.txtArchivo.Text;
            
            FileStream archivo = new FileStream(file,FileMode.Open);
            StreamReader sr = new StreamReader(archivo);


            //lectura de la primera linea del archivo
            string cad, aux = "";
            cad = sr.ReadLine();
            while(cad != null)
            {
                aux += cad + Environment.NewLine;
                cad = sr.ReadLine();
            }
            this.txtResultado.Text = aux;
            //cerrar le flujo
            sr.Close();

        }catch(IOException el)
            {
                MessageBox.Show(el.Message.ToString());
            }
         }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            openFileDialog1.Title = "Lectura de archivos de textos";
            openFileDialog1.InitialDirectory = @"c:\tmp";
            openFileDialog1.Filter = "txt filas(*.txt)|*.txt";
           
            
            if (openFileDialog1.ShowDialog()== DialogResult.OK)
            {
                this.txtArchivo.Text = openFileDialog1.FileName;
            }
            else
            {
                this.txtArchivo.Text = " ";
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
    }


}
