using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dooms
{

    public partial class Form1 : Form
    {
        Cdt cdt;
        public Form1()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateFile_Click(object sender, EventArgs e)
        {




        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            float xpos, ypos, zpos;





            Element st = new Element("ST", float.Parse(txtX.Text), txtY, txtZ, xpos, ypos, zpos, );



        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cdt = new Cdt();

            cdt.ElementList = new List<Element>();

        }
    }
}
