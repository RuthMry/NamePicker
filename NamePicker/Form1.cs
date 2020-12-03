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

        private void nameEntered_TextChanged(object sender, EventArgs e)
        {

        }

        private void addName_Click(object sender, EventArgs e)
        {

            String newName = "";
            newName = nameEntered.Text;

            namesEntered.Items.Add(newName);
            namesEnteredList.Add(newName);
            nameEntered.Text = "";

        }


        private void removeName_Click(object sender, EventArgs e)
        {

            int selectedIndex = namesEntered.SelectedIndex;
            namesEntered.Items.RemoveAt(selectedIndex);
            namesEnteredList.RemoveAt(selectedIndex);

        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

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
            open.Title = "Abrir lista";
            open.FileName = "sin titulo 1";
            var result = open.ShowDialog();

            if (result == DialogResult.OK)
            {
                StreamReader read = new StreamReader(open.FileName);
                namesEntered.Text = read.ReadToEnd();
                read.Close();
            }
        }

        private void export_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Documento de tento |*.txt";
            save.Title = "Guardar lista";
            save.FileName = "sin titulo 1";
            var result = save.ShowDialog();

            if(result==DialogResult.OK)
            {
                StreamWriter write = new StreamWriter(save.FileName);
                foreach (object line in nameEntered.Lines)
                {
                    write.WriteLine(line);
                }
                write.Close();
            }
        }
    }
}
