using System;
using RandomClass;
using PooclsCarro;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form //Pertenece a form1 
    {
        string[] doc, path;
        string[] canciones;
        int NumAleatorio = 0;
        RandomClass1 rdn = new RandomClass1();
        int i;
        string ruta = "";
        Nodo nuevo;
        //AxWMPLib.AxWindowsMediaPlayer Player = new AxWMPLib.AxWindowsMediaPlayer();
        clsListaDoble addlist = new clsListaDoble();
        OpenFileDialog addpath = new OpenFileDialog();

        ListaCircular repeat = new ListaCircular();
        //Form1 ventanita = new Form1();


        public Form1()
        {
            
            InitializeComponent();
        }
        //shuffle btn
        private void button1_Click(object sender, EventArgs e)
        {
            

            ListBox.ObjectCollection list = listBox1.Items;
            Random random = new Random();
            int w = list.Count;
            listBox1.BeginUpdate();
            while (w > 1)
            {
                w--;
                int u = random.Next(w + 1);
                object value = list[u];
                list[u] = list[w];
                list[w] = value;
                Player.URL = path[u];
            }
            listBox1.EndUpdate();
            listBox1.Invalidate();
        }

        
        public void recorrer()
        {
            //Nodos_C p;
            if (nuevo != null)
            {
                nuevo = repeat.repeat.enlace; // siguiente nodo al de acceso

                while (nuevo == repeat.repeat.enlace)
                {
                    if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
                    {

                        listBox1.SelectedIndex += 1;

                        nuevo = nuevo.enlace;
                    }
                    else
                    {

                        Player.URL = addpath.FileNames[0];
                        listBox1.SelectedIndex = 0;
                        nuevo = nuevo.enlace;
                    }

                    nuevo = nuevo.enlace;
                }
            }
            else
            {
                MessageBox.Show("\t LISTA CIRCULAR VACIA");
            }
        }

        private void Player_Enter(object sender, EventArgs e)
        {
                 
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        //Cerrar Pestana
        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        //Maximizar
        private void pictureBox4_Click(object sender, EventArgs e)
        {
        if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
        else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
        //Minimizar
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }


        //Open Specific Files
        private void button2_Click(object sender, EventArgs e)
        {


            try
            {

                addpath.Multiselect = true;
                addpath.Filter = "Archivos audios (*.mp3),(*.mp4),(*.wav),(*.png)|";

                if (addpath.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    doc = addpath.SafeFileNames;
                    path = addpath.FileNames;
                    for ( i = 0; i < addpath.SafeFileNames.Length; i++)
                    {
                        addlist.insertarCabezaLista(addpath.FileNames[i]);
                        listBox1.Items.Add(addpath.SafeFileNames[i]);

                        repeat.insertar(addpath.FileNames[i]);
                        
                    }
                    Player.URL = addpath.FileNames[0];
                    listBox1.SelectedIndex = 0;


                    
                }


            }
            catch (Exception en)
            {
                MessageBox.Show(en.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        //Reproducir instanteneamente aleatorio usando clase random
        private void button3_Click(object sender, EventArgs e)
        {
            canciones = Directory.GetFiles("c:\\musica\\", "*.mp3");
            Player.URL = canciones[rdn.GeneraNum()];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           // ventanita.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        //Nos sirve para seleccionar un archivo de la lista y reproducirlo
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            try
            {
               Player.URL = path[listBox1.SelectedIndex];
            }
            catch (IndexOutOfRangeException)
            {

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Playbtn_Click(object sender, EventArgs e)
        {
            Player.Ctlcontrols.play();
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            string indice = listBox1.SelectedIndex.ToString();

            addlist.eliminar(indice);
            listBox1.Items.RemoveAt( Int32.Parse( indice));
            Player.Ctlcontrols.stop();
        }

        private void Next_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex < listBox1.Items.Count - 1)
            {
                listBox1.SelectedIndex += 1;
            }
        }

        private void Previous_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > 0)
            {
                listBox1.SelectedIndex -= 1;
            }
        }

        private void Repeatbtn_Click(object sender, EventArgs e)
        {
           // repeat.lc = false;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            //ventanita.Text= "Hola Mundo";
        }
    }
}
//rayalar@miumg.com.gt