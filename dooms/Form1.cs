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
            float topPlate = float.Parse(txtTopPlateY.Text);
            float bottomPlate = float.Parse(txtBottomPlateY.Text);

            float topPlateX, bottomPlateX;
            if (cbxWLength.Checked)
            {
                topPlateX = cdt.currentXPos;
                bottomPlateX = cdt.currentXPos;
            }
            else
            {
                topPlateX = float.Parse(txtTopPlateX.Text);
                bottomPlateX = float.Parse(txtBottomPlateX.Text);

            }




            float wallThickness = float.Parse(txtZ.Text);
            Output =  txtHeader.Text + "\n";

            Output = Output + string.Format("ELM:{0}:{1}:{2}:{3}:{4}:{5}:{6};\n", topPlateX, wallHeight, wallThickness, 1, "wall1", "wall1", "wall1");
            //Top plate
            Output = Output + string.Format("TS:{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9};\n", topPlateX, txtTopPlateY.Text, txtTopPLateZ.Text, 0, wallHeight-topPlate, 0, "TP", "TPLenth", "TPDim", "TopPlate");
            //Bottom Plate
            Output = Output + string.Format("BS:{0}:{1}:{2}:{3}:{4}:{5}:{6}:{7}:{8}:{9};\n", bottomPlateX, txtBottomPlateY.Text, txtBottomPlateZ.Text, 0, 0, 0, "BP", "BPLenth", "BPDim", "BottomPlate");


            foreach (var item in lstItems.Items)
            {
                Output = Output + item.ToString() + "\n";
            }

            foreach (var el in cdt.ElementList)
            {

                for (int i = 1; i <= fst.Value; i++)
                {
                    float fstX = el.posX + (el.x / 2);
                    float fstZ = ((el.z / (int)fst.Value) * i)- (int)offset.Value;
                    if (fstZ < 15)
                    {
                        fstZ = 15;
                    }

                    //Fastener in topplate
                    Output = Output + string.Format("FST:{0}:{1}:{2}:{3}:{4}:{5}:{6}:;\n", fstX, wallHeight, fstZ, fstX, wallHeight - 89, fstZ, 11);
                    // fastener in bottomplate
                    Output = Output + string.Format("FST:{0}:{1}:{2}:{3}:{4}:{5}:{6}:;\n", fstX, 0, fstZ, fstX, 89, fstZ, 11);

                }
            }

            Output = Output + "EOF;\n";

            txtOutput.Text = Output;

        }

        private void btnAddStud_Click(object sender, EventArgs e)
        {
            float space;
            float xpos;

            if (cdt.ElementList.Count == 0)
            {
                space = 0;
            }
            else
            {
                space = float.Parse(txtSpace.Text);
            }


            if  (lstItems.SelectedIndices.Count > 0)
            {

                xpos = cdt.ElementList[lstItems.SelectedIndex].posX + cdt.ElementList[lstItems.SelectedIndex].x + space;
            }
            else
            {

                xpos = cdt.currentXPos + space;
            }



            float ypos = float.Parse(txtBottomPlateY.Text);
            float zpos = 0; //float.Parse(txtZ.Text);
            float Xspace = space + float.Parse(txtX.Text);
            

            Element st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);


            if (lstItems.SelectedIndices.Count > 0)
            {

                cdt.ElementList.Insert(lstItems.SelectedIndex, st);

            }
            else
            {

                cdt.ElementList.Add(st);
                cdt.currentXPos += Xspace;
            }







            lstItems.Items.Clear();

            cdt.updateList(lstItems);

            lblSpace.Text = string.Format("Nuvarande X pos = {0}", cdt.currentXPos);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cdt = new Cdt();

            cdt.ElementList = new List<Element>();

            txtF2.Text = txtY.Text;

            txtF3.Text = string.Format("{0}x{1}", txtX.Text, txtZ.Text);
            UpdateHeight();
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

            int SplicesDone = 0;


            for (int i = 0; i < (noOfStuds + noOfSplices*2); i++)
            {
                float Xspace;

                float xpos = cdt.currentXPos;
                float ypos = float.Parse(txtBottomPlateY.Text);
                float zpos = 0; //float.Parse(txtZ.Text);

                if (i == (noOfStuds-1) + noOfSplices * 2 || xpos >= Length - float.Parse(txtX.Text))
                {
                    Xspace = 0;
                    xpos = Length - float.Parse(txtX.Text);
                }
                else
                {
                    Xspace = spacing;
                }


                

                Element st;

                if (!(xpos < ( (float.Parse(txtJoint.Text) * (SplicesDone+1)) + float.Parse(txtX.Text)) && 
                    xpos > ((float.Parse(txtJoint.Text) * (SplicesDone+1)) - (float.Parse(txtX.Text)*2))))
                {
                    st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);

                    cdt.ElementList.Add(st);
                }

                if (xpos >= (Length - float.Parse(txtX.Text)))
                {
                    break;
                }

                cdt.currentXPos += Xspace;

                if (cbxSplice.Checked)
                {
                    if ( spacing >= splice  )
                    {
                        splice = int.Parse(txtJoint.Text);

           
                       
                      

                        xpos = splice - float.Parse(txtX.Text) + (int.Parse(txtJoint.Text) * SplicesDone);
                        Xspace = 0;

                        st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);

                        cdt.ElementList.Add(st);
                        cdt.currentXPos += Xspace;

                        xpos = int.Parse(txtJoint.Text) + (int.Parse(txtJoint.Text) * SplicesDone);
                        Xspace = 0;
                        st = new Element("ST", float.Parse(txtX.Text), float.Parse(txtY.Text), float.Parse(txtZ.Text), xpos, ypos, zpos, Xspace, txtF1.Text, txtF2.Text, txtF3.Text, txtF4.Text);
                        cdt.ElementList.Add(st);
                        cdt.currentXPos += Xspace;

                        SplicesDone += 1;
                        
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

        public  void UpdateHeight()
        {


            float plates = float.Parse(txtTopPlateY.Text);
            float stud = float.Parse(txtY.Text) ;
            float wallHeight = stud + (plates *2);

            lblHeight.Text = string.Format("Vägghöjd: {0}", wallHeight);

        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Name";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;


        }

        private void btnNewHeight_Click(object sender, EventArgs e)
        {
            string wh = "0";
            ShowInputDialog(ref wh);
            float wallHeight = float.Parse(wh);
            float plates = float.Parse(txtTopPlateY.Text);
            float stud = wallHeight - (plates * 2);

            txtY.Text = stud.ToString();

            foreach (var el in cdt.ElementList)
            {
                el.y = stud;
                el.field2 = txtF2.Text;
            }
            
            cdt.updateList(lstItems);
            UpdateHeight();

        }

        private void txtY_TextChanged(object sender, EventArgs e)
        {
            txtF2.Text = ((TextBox)sender).Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = txtOutput.Text;
            text = text.Replace(",", ".");
            System.IO.File.WriteAllText(txtPath.Text, text);
        }

        private void label12_Click_1(object sender, EventArgs e)
        {

        }

        private void txtX_TextChanged(object sender, EventArgs e)
        {
            txtF3.Text = string.Format("{0}x{1}", txtX.Text, txtZ.Text);
        }

        private void txtZ_TextChanged(object sender, EventArgs e)
        {
            txtF3.Text = string.Format("{0}x{1}", txtX.Text, txtZ.Text);
        }

        private void btnSetStud_Click(object sender, EventArgs e)
        {
            string wh = "0";
            ShowInputDialog(ref wh);
            float wallHeight = float.Parse(wh);
            float stud = wallHeight ;

            txtY.Text = stud.ToString();

            foreach (var el in cdt.ElementList)
            {
                el.y = stud;
                el.field2 = txtF2.Text;
            }

            cdt.updateList(lstItems);
            UpdateHeight();
        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            cdt.ElementList.Clear();
            cdt.currentXPos = 0;
            lstItems.Items.Clear();
        }

        private void btnOpenFIle_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@txtPath.Text);
        }

        private void lblSpace_Click(object sender, EventArgs e)
        {

        }

        private void btnNoIndex_Click(object sender, EventArgs e)
        {
            lstItems.ClearSelected();
        }

        private void txtAutoStuds_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
