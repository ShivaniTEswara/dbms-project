namespace medico

{
    partial class patientuc
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
            this.components = new System.ComponentModel.Container();
            this.searchbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.clearbutton = new System.Windows.Forms.Button();
            this.updatebutton = new System.Windows.Forms.Button();
            this.addbutton = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pssntb = new System.Windows.Forms.TextBox();
            this.nametb = new System.Windows.Forms.TextBox();
            this.agetb = new System.Windows.Forms.TextBox();
            this.gendertb = new System.Windows.Forms.TextBox();
            this.phnotb = new System.Windows.Forms.TextBox();
            this.addtb = new System.Windows.Forms.TextBox();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.dssncb = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // searchbutton
            // 
            this.searchbutton.BackColor = System.Drawing.Color.Transparent;
            this.searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.searchbutton.ForeColor = System.Drawing.Color.Yellow;
            this.searchbutton.Location = new System.Drawing.Point(700, 46);
            this.searchbutton.Name = "searchbutton";
            this.searchbutton.Size = new System.Drawing.Size(100, 30);
            this.searchbutton.TabIndex = 0;
            this.searchbutton.Text = "SEARCH";
            this.searchbutton.UseVisualStyleBackColor = false;
            this.searchbutton.Click += new System.EventHandler(this.searchbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(550, 368);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(100, 30);
            this.deletebutton.TabIndex = 1;
            this.deletebutton.Text = "DELETE";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // clearbutton
            // 
            this.clearbutton.Location = new System.Drawing.Point(768, 368);
            this.clearbutton.Name = "clearbutton";
            this.clearbutton.Size = new System.Drawing.Size(100, 30);
            this.clearbutton.TabIndex = 2;
            this.clearbutton.Text = "CLEAR";
            this.clearbutton.UseVisualStyleBackColor = true;
            this.clearbutton.Click += new System.EventHandler(this.clearbutton_Click);
            // 
            // updatebutton
            // 
            this.updatebutton.Location = new System.Drawing.Point(325, 368);
            this.updatebutton.Name = "updatebutton";
            this.updatebutton.Size = new System.Drawing.Size(100, 30);
            this.updatebutton.TabIndex = 3;
            this.updatebutton.Text = "UPDATE";
            this.updatebutton.UseVisualStyleBackColor = true;
            this.updatebutton.Click += new System.EventHandler(this.updatebutton_Click);
            // 
            // addbutton
            // 
            this.addbutton.Location = new System.Drawing.Point(107, 368);
            this.addbutton.Name = "addbutton";
            this.addbutton.Size = new System.Drawing.Size(100, 30);
            this.addbutton.TabIndex = 4;
            this.addbutton.Text = "ADD NEW";
            this.addbutton.UseVisualStyleBackColor = true;
            this.addbutton.Click += new System.EventHandler(this.button10_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView2.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView2.Location = new System.Drawing.Point(107, 142);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(761, 150);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 482);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "PSSN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 564);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "DSSN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(361, 444);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "NAME";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(361, 534);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "AGE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(361, 622);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "GENDER";
            // 
            // search
            // 
            this.search.AutoSize = true;
            this.search.Location = new System.Drawing.Point(212, 55);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(36, 13);
            this.search.TabIndex = 13;
            this.search.Text = "PSSN";
            this.search.Click += new System.EventHandler(this.label6_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(697, 550);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "ADDRESS";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(697, 482);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "PH NO";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pssntb
            // 
            this.pssntb.Location = new System.Drawing.Point(119, 479);
            this.pssntb.Name = "pssntb";
            this.pssntb.Size = new System.Drawing.Size(104, 20);
            this.pssntb.TabIndex = 16;
            // 
            // nametb
            // 
            this.nametb.Location = new System.Drawing.Point(460, 437);
            this.nametb.Name = "nametb";
            this.nametb.Size = new System.Drawing.Size(104, 20);
            this.nametb.TabIndex = 18;
            // 
            // agetb
            // 
            this.agetb.Location = new System.Drawing.Point(460, 527);
            this.agetb.Name = "agetb";
            this.agetb.Size = new System.Drawing.Size(104, 20);
            this.agetb.TabIndex = 19;
            // 
            // gendertb
            // 
            this.gendertb.Location = new System.Drawing.Point(460, 619);
            this.gendertb.Name = "gendertb";
            this.gendertb.Size = new System.Drawing.Size(104, 20);
            this.gendertb.TabIndex = 20;
            // 
            // phnotb
            // 
            this.phnotb.Location = new System.Drawing.Point(790, 475);
            this.phnotb.Name = "phnotb";
            this.phnotb.Size = new System.Drawing.Size(104, 20);
            this.phnotb.TabIndex = 21;
            // 
            // addtb
            // 
            this.addtb.Location = new System.Drawing.Point(790, 550);
            this.addtb.Name = "addtb";
            this.addtb.Size = new System.Drawing.Size(197, 20);
            this.addtb.TabIndex = 22;
            // 
            // searchtb
            // 
            this.searchtb.ForeColor = System.Drawing.Color.Black;
            this.searchtb.Location = new System.Drawing.Point(286, 52);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(372, 20);
            this.searchtb.TabIndex = 23;
            // 
            // dssncb
            // 
            this.dssncb.FormattingEnabled = true;
            this.dssncb.Items.AddRange(new object[] {
            "D101",
            "D102",
            "D103",
            "D104",
            "D105"});
            this.dssncb.Location = new System.Drawing.Point(107, 562);
            this.dssncb.Name = "dssncb";
            this.dssncb.Size = new System.Drawing.Size(130, 21);
            this.dssncb.TabIndex = 25;
            this.dssncb.SelectedIndexChanged += new System.EventHandler(this.dssncb_SelectedIndexChanged);
            // 
            // patientuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::medico.Properties.Resources.background_3;
            this.Controls.Add(this.dssncb);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.addtb);
            this.Controls.Add(this.phnotb);
            this.Controls.Add(this.gendertb);
            this.Controls.Add(this.agetb);
            this.Controls.Add(this.nametb);
            this.Controls.Add(this.pssntb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.addbutton);
            this.Controls.Add(this.updatebutton);
            this.Controls.Add(this.clearbutton);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.searchbutton);
            this.Name = "patientuc";
            this.Size = new System.Drawing.Size(1024, 687);
            this.Load += new System.EventHandler(this.patientuc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button searchbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Button clearbutton;
        private System.Windows.Forms.Button updatebutton;
        private System.Windows.Forms.Button addbutton;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox pssntb;
        private System.Windows.Forms.TextBox nametb;
        private System.Windows.Forms.TextBox agetb;
        private System.Windows.Forms.TextBox gendertb;
        private System.Windows.Forms.TextBox phnotb;
        private System.Windows.Forms.TextBox addtb;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.ComboBox dssncb;
    }
}
