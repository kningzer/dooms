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
            string Output;
            float wallHeight = float.Parse(txtBottomPlateY.Text) + float.Parse(txtTopPlateY.Text) + float.Parse(txtY.Text);
            float wallThickness = float.Parse(txtZ.Text);
            Output =  txtHeader.Text + "\n";

            Output = Output + string.Format("ELM:{0}:{1}:{2}:{3}:\n;", txtBottomPlateX.Text, wallHeight, wallThickness, 1);

            foreach (var item in lstItems.Items)
            {
                Output = Output + item.ToString() + "\n";
            }

            foreach (var el in cdt.ElementList)
            {

                float fstX = el.posX + (el.x / 2);

                //Fastener in topplate
                Output = Output + string.Format("FST:{0}:{1}:{2}:{3}:{4}:{5}:{6};\n", fstX, wallHeight, 50, fstX, wallHeight - 89, 50, 11);
                // fastener in bottomplate
                Output = Output + string.Format("FST:{0}:{1}:{2}:{3}:{4}:{5}:{6};\n", fstX, 0, 50, fstX, 89, 50, 11);
            }

            Output = Output + "EOF;\n";

            txtOutput.Text = Output;

        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            float xpos = cdt.currentXPos;
            float ypos = float.Parse(txtBottomPlateY.Text);
            float zpos = float.Parse(txtZ.Text);
            float Xspace = float.Parse(txtSpace.Text);
            

            Element st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);

            cdt.ElementList.Add(st);
            cdt.currentXPos += Xspace;

            lstItems.Items.Clear();

            cdt.updateList(lstItems);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cdt = new Cdt();

            cdt.ElementList = new List<Element>();

        }

        private void btnAutoRegel_Click(object sender, EventArgs e)
        {
            int spacing;
            int noOfStuds = int.Parse(txtAutoStuds.Text);
            int Length = int.Parse(txtAutoLength.Text);
            int splice = int.Parse(txtJoint.Text);
            int noOfSplices = Length / splice;


            // Le reset
            cdt.currentXPos = 0;
            lstItems.Items.Clear();
            cdt.ElementList.Clear();

            //spacing
            spacing =  Length / (noOfStuds -1);

            if (cbxSplice.Checked)
            {
                noOfStuds -= noOfSplices;
            }

            txtBottomPlateX.Text = Length.ToString();
            txtTopPlateX.Text = Length.ToString();

            for (int i = 0; i < noOfStuds; i++)
            {
                float Xspace;

                float xpos = cdt.currentXPos;
                float ypos = float.Parse(txtBottomPlateY.Text);
                float zpos = float.Parse(txtZ.Text);

                if (i == noOfStuds-1)
                {
                    Xspace = 0;
                    xpos = Length - float.Parse(txtX.Text);
                }
                else
                {
                    Xspace = spacing;
                }



                Element st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);

                cdt.ElementList.Add(st);
                cdt.currentXPos += Xspace;

                if (cbxSplice.Checked)
                {
                    if ( spacing >= splice)
                    {
                        splice = int.Parse(txtJoint.Text);

                        xpos = splice - float.Parse(txtX.Text);
                        Xspace = 0;

                        st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);

                        cdt.ElementList.Add(st);
                        cdt.currentXPos += Xspace;

                        xpos = int.Parse(txtJoint.Text);
                        Xspace = 0;
                        st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);
                        cdt.ElementList.Add(st);
                        cdt.currentXPos += Xspace;
                        
                    }
                    else
                    {
                        splice -= spacing;
                    }
                }
            }


            lstItems.Items.Clear();

            cdt.updateList(lstItems);
        }
    }
}
