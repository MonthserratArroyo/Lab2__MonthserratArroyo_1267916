using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2_MonthserratArroyo_1267916
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante("Montse", true);

            //Lista de enteros
            List<int> ListaDeEnteros = new List<int>();
            //Pila de enteros
            Stack<int> PilaDeEnteros = new Stack<int>();
            //Cola de enteros
            Queue<int> ColaDeEnteros = new Queue<int>();

            //AGREGAR ITEMS LISTA
            ListaDeEnteros.Add(150);
            ListaDeEnteros.Add(740);
            ListaDeEnteros.Add(660);
            ListaDeEnteros.Add(100);
            ListaDeEnteros.Add(75);
            //AGREGAR ITEMS PILA
            PilaDeEnteros.Push(255);
            //AGREGAR ITEMS COLA
            ColaDeEnteros.Enqueue(75);


            //REMOVER ITEMS DE LISTA
            ListaDeEnteros.RemoveAt(0);
            //REMOVER ITEMS DE PILA
            PilaDeEnteros.Pop();
            //REMOVER ITEMS DE COLA
            ColaDeEnteros.Dequeue();

            foreach (int entero in ListaDeEnteros)
            {
                //hacer algo
                MessageBox.Show(entero.ToString());
            }

        
        }
    }
}
