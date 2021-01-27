namespace dooms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstItems = new System.Windows.Forms.ListBox();
            this.btnAddStud = new System.Windows.Forms.Button();
            this.btnAddSUB = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.txtSpace = new System.Windows.Forms.TextBox();
            this.lbl = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBottomPlateX = new System.Windows.Forms.TextBox();
            this.txtBottomPlateY = new System.Windows.Forms.TextBox();
            this.txtBottomPlateZ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTopPLateZ = new System.Windows.Forms.TextBox();
            this.txtTopPlateY = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTopPlateX = new System.Windows.Forms.TextBox();
            this.txtAutoStuds = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAutoLength = new System.Windows.Forms.TextBox();
            this.btnAutoRegel = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.RichTextBox();
            this.txtHeader = new System.Windows.Forms.RichTextBox();
            this.btnCreateFile = new System.Windows.Forms.Button();
            this.txtF1 = new System.Windows.Forms.TextBox();
            this.txtF2 = new System.Windows.Forms.TextBox();
            this.txtF3 = new System.Windows.Forms.TextBox();
            this.txtF4 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.cbxSplice = new System.Windows.Forms.CheckBox();
            this.txtJoint = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstItems
            // 
            this.lstItems.FormattingEnabled = true;
            this.lstItems.Location = new System.Drawing.Point(12, 12);
            this.lstItems.Name = "lstItems";
            this.lstItems.Size = new System.Drawing.Size(209, 277);
            this.lstItems.TabIndex = 0;
            // 
            // btnAddStud
            // 
            this.btnAddStud.Location = new System.Drawing.Point(227, 237);
            this.btnAddStud.Name = "btnAddStud";
            this.btnAddStud.Size = new System.Drawing.Size(121, 23);
            this.btnAddStud.TabIndex = 1;
            this.btnAddStud.Text = "Lägg till regel";
            this.btnAddStud.UseVisualStyleBackColor = true;
            this.btnAddStud.Click += new System.EventHandler(this.btnAddStud_Click);
            // 
            // btnAddSUB
            // 
            this.btnAddSUB.Location = new System.Drawing.Point(227, 266);
            this.btnAddSUB.Name = "btnAddSUB";
            this.btnAddSUB.Size = new System.Drawing.Size(121, 23);
            this.btnAddSUB.TabIndex = 2;
            this.btnAddSUB.Text = "Lägg till SUB element";
            this.btnAddSUB.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(227, 28);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(28, 20);
            this.txtX.TabIndex = 4;
            this.txtX.Text = "45";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(233, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(447, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Fördela ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(268, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Y";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(303, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Z";
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(261, 28);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(28, 20);
            this.txtY.TabIndex = 9;
            this.txtY.Text = "2000";
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(295, 28);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(28, 20);
            this.txtZ.TabIndex = 10;
            this.txtZ.Text = "95";
            // 
            // txtSpace
            // 
            this.txtSpace.Location = new System.Drawing.Point(354, 28);
            this.txtSpace.Name = "txtSpace";
            this.txtSpace.Size = new System.Drawing.Size(28, 20);
            this.txtSpace.TabIndex = 11;
            this.txtSpace.Text = "600";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(342, 12);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(55, 13);
            this.lbl.TabIndex = 12;
            this.lbl.Text = "Mellanrum";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(469, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Syll";
            // 
            // txtBottomPlateX
            // 
            this.txtBottomPlateX.Location = new System.Drawing.Point(430, 28);
            this.txtBottomPlateX.Name = "txtBottomPlateX";
            this.txtBottomPlateX.Size = new System.Drawing.Size(36, 20);
            this.txtBottomPlateX.TabIndex = 13;
            this.txtBottomPlateX.Text = "4000";
            // 
            // txtBottomPlateY
            // 
            this.txtBottomPlateY.Location = new System.Drawing.Point(472, 28);
            this.txtBottomPlateY.Name = "txtBottomPlateY";
            this.txtBottomPlateY.Size = new System.Drawing.Size(28, 20);
            this.txtBottomPlateY.TabIndex = 15;
            this.txtBottomPlateY.Text = "45";
            // 
            // txtBottomPlateZ
            // 
            this.txtBottomPlateZ.Location = new System.Drawing.Point(506, 28);
            this.txtBottomPlateZ.Name = "txtBottomPlateZ";
            this.txtBottomPlateZ.Size = new System.Drawing.Size(28, 20);
            this.txtBottomPlateZ.TabIndex = 16;
            this.txtBottomPlateZ.Text = "95";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(513, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Z";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(478, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Y";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(443, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "X";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(662, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 26;
            this.label9.Text = "Z";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(627, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(592, 12);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "X";
            // 
            // txtTopPLateZ
            // 
            this.txtTopPLateZ.Location = new System.Drawing.Point(655, 28);
            this.txtTopPLateZ.Name = "txtTopPLateZ";
            this.txtTopPLateZ.Size = new System.Drawing.Size(28, 20);
            this.txtTopPLateZ.TabIndex = 23;
            this.txtTopPLateZ.Text = "95";
            // 
            // txtTopPlateY
            // 
            this.txtTopPlateY.Location = new System.Drawing.Point(621, 28);
            this.txtTopPlateY.Name = "txtTopPlateY";
            this.txtTopPlateY.Size = new System.Drawing.Size(28, 20);
            this.txtTopPlateY.TabIndex = 22;
            this.txtTopPlateY.Text = "45";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(600, 51);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Hammarband";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txtTopPlateX
            // 
            this.txtTopPlateX.Location = new System.Drawing.Point(575, 28);
            this.txtTopPlateX.Name = "txtTopPlateX";
            this.txtTopPlateX.Size = new System.Drawing.Size(40, 20);
            this.txtTopPlateX.TabIndex = 20;
            this.txtTopPlateX.Text = "4000";
            // 
            // txtAutoStuds
            // 
            this.txtAutoStuds.Location = new System.Drawing.Point(498, 82);
            this.txtAutoStuds.Name = "txtAutoStuds";
            this.txtAutoStuds.Size = new System.Drawing.Size(28, 20);
            this.txtAutoStuds.TabIndex = 27;
            this.txtAutoStuds.Text = "10";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(532, 85);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(97, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "st reglar över längd";
            // 
            // txtAutoLength
            // 
            this.txtAutoLength.Location = new System.Drawing.Point(635, 82);
            this.txtAutoLength.Name = "txtAutoLength";
            this.txtAutoLength.Size = new System.Drawing.Size(66, 20);
            this.txtAutoLength.TabIndex = 29;
            this.txtAutoLength.Text = "5000";
            // 
            // btnAutoRegel
            // 
            this.btnAutoRegel.Location = new System.Drawing.Point(504, 108);
            this.btnAutoRegel.Name = "btnAutoRegel";
            this.btnAutoRegel.Size = new System.Drawing.Size(91, 23);
            this.btnAutoRegel.TabIndex = 30;
            this.btnAutoRegel.Text = "Do it!";
            this.btnAutoRegel.UseVisualStyleBackColor = true;
            this.btnAutoRegel.Click += new System.EventHandler(this.btnAutoRegel_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(707, 28);
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(370, 410);
            this.txtOutput.TabIndex = 31;
            this.txtOutput.Text = "";
            // 
            // txtHeader
            // 
            this.txtHeader.Location = new System.Drawing.Point(354, 266);
            this.txtHeader.Name = "txtHeader";
            this.txtHeader.Size = new System.Drawing.Size(347, 172);
            this.txtHeader.TabIndex = 32;
            this.txtHeader.Text = "VERSION:5.0; \nTXT:(c) Randek BauTech AB 2020-01-01. \nTXT:This is a header; \nPNO:s" +
    "tk; \nFL:1; \nPL:false; \nEL:false; \nHV:false; \nWIN:false; \nELD:EXTERIOR; \nDNO:TEST" +
    "PANEL1; \nELF:OUTSIDE; ";
            // 
            // btnCreateFile
            // 
            this.btnCreateFile.Location = new System.Drawing.Point(484, 214);
            this.btnCreateFile.Name = "btnCreateFile";
            this.btnCreateFile.Size = new System.Drawing.Size(121, 23);
            this.btnCreateFile.TabIndex = 33;
            this.btnCreateFile.Text = "Skapa fil";
            this.btnCreateFile.UseVisualStyleBackColor = true;
            this.btnCreateFile.Click += new System.EventHandler(this.btnCreateFile_Click);
            // 
            // txtF1
            // 
            this.txtF1.Location = new System.Drawing.Point(248, 78);
            this.txtF1.Name = "txtF1";
            this.txtF1.Size = new System.Drawing.Size(63, 20);
            this.txtF1.TabIndex = 34;
            // 
            // txtF2
            // 
            this.txtF2.Location = new System.Drawing.Point(248, 104);
            this.txtF2.Name = "txtF2";
            this.txtF2.Size = new System.Drawing.Size(63, 20);
            this.txtF2.TabIndex = 35;
            // 
            // txtF3
            // 
            this.txtF3.Location = new System.Drawing.Point(248, 130);
            this.txtF3.Name = "txtF3";
            this.txtF3.Size = new System.Drawing.Size(63, 20);
            this.txtF3.TabIndex = 36;
            // 
            // txtF4
            // 
            this.txtF4.Location = new System.Drawing.Point(248, 156);
            this.txtF4.Name = "txtF4";
            this.txtF4.Size = new System.Drawing.Size(63, 20);
            this.txtF4.TabIndex = 37;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(317, 81);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(38, 13);
            this.label14.TabIndex = 38;
            this.label14.Text = "Field 1";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(317, 107);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "Field 2";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(317, 133);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 40;
            this.label16.Text = "Field 3";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(317, 159);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(38, 13);
            this.label17.TabIndex = 41;
            this.label17.Text = "Field 4";
            // 
            // cbxSplice
            // 
            this.cbxSplice.AutoSize = true;
            this.cbxSplice.Location = new System.Drawing.Point(450, 137);
            this.cbxSplice.Name = "cbxSplice";
            this.cbxSplice.Size = new System.Drawing.Size(95, 17);
            this.cbxSplice.TabIndex = 42;
            this.cbxSplice.Text = "Skapa skarvar";
            this.cbxSplice.UseVisualStyleBackColor = true;
            // 
            // txtJoint
            // 
            this.txtJoint.Location = new System.Drawing.Point(450, 160);
            this.txtJoint.Name = "txtJoint";
            this.txtJoint.Size = new System.Drawing.Size(66, 20);
            this.txtJoint.TabIndex = 43;
            this.txtJoint.Text = "4000";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 450);
            this.Controls.Add(this.txtJoint);
            this.Controls.Add(this.cbxSplice);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtF4);
            this.Controls.Add(this.txtF3);
            this.Controls.Add(this.txtF2);
            this.Controls.Add(this.txtF1);
            this.Controls.Add(this.btnCreateFile);
            this.Controls.Add(this.txtHeader);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btnAutoRegel);
            this.Controls.Add(this.txtAutoLength);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAutoStuds);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtTopPLateZ);
            this.Controls.Add(this.txtTopPlateY);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTopPlateX);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtBottomPlateZ);
            this.Controls.Add(this.txtBottomPlateY);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBottomPlateX);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.txtSpace);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.btnAddSUB);
            this.Controls.Add(this.btnAddStud);
            this.Controls.Add(this.lstItems);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstItems;
        private System.Windows.Forms.Button btnAddStud;
        private System.Windows.Forms.Button btnAddSUB;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.TextBox txtSpace;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBottomPlateX;
        private System.Windows.Forms.TextBox txtBottomPlateY;
        private System.Windows.Forms.TextBox txtBottomPlateZ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTopPLateZ;
        private System.Windows.Forms.TextBox txtTopPlateY;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTopPlateX;
        private System.Windows.Forms.TextBox txtAutoStuds;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAutoLength;
        private System.Windows.Forms.Button btnAutoRegel;
        private System.Windows.Forms.RichTextBox txtOutput;
        private System.Windows.Forms.RichTextBox txtHeader;
        private System.Windows.Forms.Button btnCreateFile;
        private System.Windows.Forms.TextBox txtF1;
        private System.Windows.Forms.TextBox txtF2;
        private System.Windows.Forms.TextBox txtF3;
        private System.Windows.Forms.TextBox txtF4;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.CheckBox cbxSplice;
        private System.Windows.Forms.TextBox txtJoint;
    }
}

