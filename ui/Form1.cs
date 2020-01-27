using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ui.Model;

namespace ui
{
    public partial class Form1 : Form

    {

        ArrayList list = new ArrayList();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        Guardar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
        Eliminar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
        System.Diagnostics.Process.Start("..\\..\\Data\\data.txt");
        }

    public void Guardar()
    {
        Visitor visitor = new Visitor(nameTextBox.Text, idTextBox.Text, patientTextBox.Text, textBox1.Text);


        list.Add(visitor);

        StreamWriter sw = new StreamWriter("..\\..\\Data\\data.txt");
        for (int i = 0; i < list.Count; i++)
        {
            sw.WriteLine(list[i].ToString());
        }
        sw.Close();

    }

    public void Eliminar()
    {
        Visitor visitor = new Visitor(nameTextBox.Text, idTextBox.Text, patientTextBox.Text, textBox1.Text);


        list.Remove(visitor);


    }
}
}
