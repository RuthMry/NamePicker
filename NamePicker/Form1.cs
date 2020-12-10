using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace NamePicker
{
    public partial class Form1 : Form
    {

        static List<string> namesEnteredList = new List<string>();
        static List<string> pickedNames = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {




        }







        private void enterName_TextChanged(object sender, EventArgs e)
        {

        }


        //Añadir nombres a campo de texto
        private void addName_Click(object sender, EventArgs e)
        {

            String newName = "";
            newName = enterName.Text;


            if (enterName.TextLength == 0 || enterName.Text.Trim() == "")
            {

                MessageBox.Show("Ingrese un nombre");
                enterName.Clear(); //eliminar los espacios en blanco ingresados
            }
            else
            {
                namesEntered.Items.Add(newName);
                namesEnteredList.Add(newName);
                enterName.Text = "";

            }
            enterName.Focus(); //ubicar el cursor en el ingreso de datos







        }

        //Eliminar nombres de lista
        private void removeName_Click(object sender, EventArgs e)
        {


            MessageBox.Show("¿Seguro que desea eliminar?");

            int selectedIndex = namesEntered.SelectedIndex;
            namesEntered.Items.RemoveAt(selectedIndex);
            namesEnteredList.RemoveAt(selectedIndex);

            enterName.Focus();


        }

        private void label2_Click(object sender, EventArgs e)
        {


        }


        //Elegir un nombre al azar
        private void selectName_Click(object sender, EventArgs e)
        {

            Random winner = new Random();
            int i = winner.Next(0, namesEnteredList.Count);

            selectedName.Items.Add(namesEnteredList.ElementAt(i));
            pickedNames.Add(namesEnteredList.ElementAt(i));

            namesEntered.Items.RemoveAt(i);
            namesEnteredList.RemoveAt(i);

        }

        private void namesEntered_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void selectedName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }







        
        private void import_Click(object sender, EventArgs e)
        {


                
                OpenFileDialog open = new OpenFileDialog();
                open.Filter = "Documento de tento |*.txt";

     
                var result = open.ShowDialog();

                if (result == DialogResult.OK)
                {

                    StreamReader read = new StreamReader(open.FileName);
                    namesEntered.Text = read.ReadToEnd();
                    
                    
                

                  read.Close();
                }
                open.Dispose();



            }


            ///

            

            //Exportar/guardar datos en archivo txt
            private void export_Click(object sender, EventArgs e)
            {

                SaveFileDialog exp = new SaveFileDialog();
                exp.Filter = "Documento de tento |*.txt";
                exp.FileName = "sin titulo 1";
                if (exp.ShowDialog() == DialogResult.OK)
                {

                    StreamWriter writer = new StreamWriter(exp.FileName);
                    for (int i = 0; i < namesEntered.Items.Count; i++)
                    {
                        writer.WriteLine((string)namesEntered.Items[i]);

                    }
                    writer.Close();
                }
                exp.Dispose();









            }


            
            private void label3_Click(object sender, EventArgs e)
            {

            }





            /*
              private bool validateData()
               {
                   bool ok = true;

                   if (enterName.Text.Length==0 || enterName.Text.Trim()==" ") 
                   {
                       ok = false;
                       ErrorProvider.ReferenceEquals(enterName, "Ingresar Nombre");
                   }
                   return ok;

               }*/





            ///

            
            private void button1_Click_1(object sender, EventArgs e)
            {

                MessageBox.Show("¿Seguro que desea eliminar?");

                namesEntered.Items.Clear();
            }
        }
    }


