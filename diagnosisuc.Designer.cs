﻿namespace medico
{
    partial class diagnosisuc
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nametb = new System.Windows.Forms.TextBox();
            this.pssntb = new System.Windows.Forms.TextBox();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.search = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.addbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.searchbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nametb
            // 
            this.nametb.BackColor = System.Drawing.SystemColors.Control;
            this.nametb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nametb.Location = new System.Drawing.Point(103, 190);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(104, 13);
            this.nametb.TabIndex = 41;
            // 
            // pssntb
            // 
            this.pssntb.BackColor = System.Drawing.SystemColors.Control;
            this.pssntb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.pssntb.Location = new System.Drawing.Point(103, 125);
            this.pssntb.Name = "pssntb";
            this.pssntb.Size = new System.Drawing.Size(104, 13);
            this.pssntb.TabIndex = 40;
            // 
            // searchtb
            // 
            this.searchtb.BackColor = System.Drawing.SystemColors.Control;
            this.searchtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.searchtb.ForeColor = System.Drawing.Color.Black;
            this.searchtb.Location = new System.Drawing.Point(233, 348);
            this.searchtb.Multiline = true;
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(147, 22);
            this.searchtb.TabIndex = 46;
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(177, 357);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(50, 13);
            this.search.TabIndex = 37;
            this.search.Text = "DIAG_ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "CATEGORY";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "DIAG_ID";
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(180, 426);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(275, 150);
            this.dataGridView2.TabIndex = 27;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // addbutton
            // 
            this.addbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addbutton.Location = new System.Drawing.Point(335, 161);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(100, 30);
            this.addbutton.TabIndex = 31;
            this.addbutton.Text = "ADD NEW";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.addbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updatebutton.Location = new System.Drawing.Point(97, 266);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(100, 30);
            this.updatebutton.TabIndex = 30;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearbutton.Location = new System.Drawing.Point(391, 266);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(100, 30);
            this.clearbutton.TabIndex = 29;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletebutton.Location = new System.Drawing.Point(245, 266);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(100, 30);
            this.deletebutton.TabIndex = 28;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Transparent;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.ForeColor = System.Drawing.Color.Black;
            this.searchbutton.Location = new System.Drawing.Point(391, 348);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(100, 22);
            this.searchbutton.TabIndex = 26;
            this.searchbutton.Text = "SEARCH";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.searchtb);
            this.panel1.Controls.Add(this.searchbutton);
            this.panel1.Controls.Add(this.nametb);
            this.panel1.Controls.Add(this.search);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pssntb);
            this.panel1.Controls.Add(this.updatebutton);
            this.panel1.Controls.Add(this.addbutton);
            this.panel1.Controls.Add(this.deletebutton);
            this.panel1.Controls.Add(this.clearbutton);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(168, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(642, 687);
            this.panel1.TabIndex = 47;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Location = new System.Drawing.Point(39, 65);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(520, 2);
            this.panel9.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 23);
            this.label2.TabIndex = 14;
            this.label2.Text = "DIAGNOSIS INFO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(103, 143);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(104, 2);
            this.panel2.TabIndex = 14;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(103, 208);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(104, 2);
            this.panel3.TabIndex = 15;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Location = new System.Drawing.Point(233, 368);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(147, 2);
            this.panel4.TabIndex = 16;
            // 
            // diagnosisuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medico.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.panel1);
            this.Name = "diagnosisuc";
            this.Size = new System.Drawing.Size(1024, 687);
            this.Load += new System.EventHandler(this.diagnosisuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox pssntb;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Label label2;
    }
}
