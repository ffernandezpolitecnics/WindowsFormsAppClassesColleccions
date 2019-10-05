using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppClassesColleccions
{
    public partial class Form1 : Form
    {
        List<Pelicula> peliculas = new List<Pelicula>();

        public Form1()
        {
            InitializeComponent();
        }

        private bool errorDatos()
        {
            bool error = false;
            int anyoEstreno;

            if (textBoxTitulo.Text.Equals(""))
            {
                error = true;
                MessageBox.Show("El título no puede estar vacio", "Película", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxTitulo.Focus();
            }
            else if (textBoxDirector.Text.Equals(""))
            {
                error = true;
                MessageBox.Show("El director no puede estar vacio", "Película", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDirector.Focus();
            }
            else if (!int.TryParse(textBoxAnyoEstreno.Text, out anyoEstreno))
            {
                error = true;
                MessageBox.Show("El año de estreno no es un número", "Película", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxDirector.Focus();
            }

            return error;
        }

        private void buttonAnyadir_Click(object sender, EventArgs e)
        {
            if (!errorDatos())
            {
                //Crear película
                Pelicula peli = new Pelicula();
                peli.titulo = textBoxTitulo.Text;
                peli.director = textBoxDirector.Text;
                peli.anoEstreno = int.Parse(textBoxAnyoEstreno.Text);
                peli.temas = listBoxTemas.SelectedItems.Cast<String>().ToList();

                if (!peliculas.Contains(peli))
                {
                    peliculas.Add(peli);

                    //Refrescar datos de la listBox de películas

                    listBoxPeliculas.DataSource = null;
                    listBoxPeliculas.DisplayMember = "titulo";
                    listBoxPeliculas.ValueMember = "titulo";
                    listBoxPeliculas.DataSource = peliculas;
                }
                else
                {
                    MessageBox.Show("La película ya existe", "Película", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void listBoxPeliculas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxPeliculas.SelectedItem != null)
            {
                Pelicula peli = (Pelicula)listBoxPeliculas.SelectedItem;
                textBoxTitulo.Text = peli.titulo;
                textBoxDirector.Text = peli.director;
                textBoxAnyoEstreno.Text = peli.anoEstreno.ToString();

                listBoxTemas.SelectedItems.Clear();

                foreach (String tema in peli.temas)
                {
                    listBoxTemas.SelectedItems.Add(tema);
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
