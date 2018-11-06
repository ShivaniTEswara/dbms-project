namespace medico
{
    partial class PInfo
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
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.SlidingPanel = new System.Windows.Forms.Panel();
            this.PatientTabButton = new System.Windows.Forms.Button();
            this.HomeTabButton = new System.Windows.Forms.Button();
            this.DiagnosisTabButton = new System.Windows.Forms.Button();
            this.PrescriptionTabButton = new System.Windows.Forms.Button();
            this.SlidingPanel_ToggleButton = new System.Windows.Forms.Button();
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.SlidingPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Interval = 25;
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // SlidingPanel
            // 
            this.SlidingPanel.BackColor = System.Drawing.Color.LightSkyBlue;
            this.SlidingPanel.BackgroundImage = global::medico.Properties.Resources.grad_670x376;
            this.SlidingPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SlidingPanel.Controls.Add(this.PatientTabButton);
            this.SlidingPanel.Controls.Add(this.HomeTabButton);
            this.SlidingPanel.Controls.Add(this.DiagnosisTabButton);
            this.SlidingPanel.Controls.Add(this.PrescriptionTabButton);
            this.SlidingPanel.Controls.Add(this.SlidingPanel_ToggleButton);
            this.SlidingPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SlidingPanel.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel.Name = "SlidingPanel";
            this.SlidingPanel.Size = new System.Drawing.Size(300, 552);
            this.SlidingPanel.TabIndex = 0;
            // 
            // PatientTabButton
            // 
            this.PatientTabButton.BackColor = System.Drawing.Color.Transparent;
            this.PatientTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientTabButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PatientTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PatientTabButton.Image = global::medico.Properties.Resources.patient;
            this.PatientTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientTabButton.Location = new System.Drawing.Point(0, 157);
            this.PatientTabButton.Name = "PatientTabButton";
            this.PatientTabButton.Size = new System.Drawing.Size(300, 82);
            this.PatientTabButton.TabIndex = 7;
            this.PatientTabButton.Text = "PATIENT";
            this.PatientTabButton.UseVisualStyleBackColor = false;
            this.PatientTabButton.Click += new System.EventHandler(this.PatientTabButton_Click);
            // 
            // HomeTabButton
            // 
            this.HomeTabButton.BackColor = System.Drawing.Color.Transparent;
            this.HomeTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HomeTabButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HomeTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HomeTabButton.Image = global::medico.Properties.Resources.hbutton;
            this.HomeTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.HomeTabButton.Location = new System.Drawing.Point(0, 78);
            this.HomeTabButton.Name = "HomeTabButton";
            this.HomeTabButton.Size = new System.Drawing.Size(300, 82);
            this.HomeTabButton.TabIndex = 5;
            this.HomeTabButton.Text = "HOME";
            this.HomeTabButton.UseVisualStyleBackColor = false;
            this.HomeTabButton.Click += new System.EventHandler(this.HomeTabButton_Click);
            // 
            // DiagnosisTabButton
            // 
            this.DiagnosisTabButton.BackColor = System.Drawing.Color.Transparent;
            this.DiagnosisTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DiagnosisTabButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiagnosisTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.DiagnosisTabButton.Image = global::medico.Properties.Resources.dbutton;
            this.DiagnosisTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DiagnosisTabButton.Location = new System.Drawing.Point(0, 314);
            this.DiagnosisTabButton.Name = "DiagnosisTabButton";
            this.DiagnosisTabButton.Size = new System.Drawing.Size(300, 82);
            this.DiagnosisTabButton.TabIndex = 3;
            this.DiagnosisTabButton.Text = "DIAGNOSIS";
            this.DiagnosisTabButton.UseVisualStyleBackColor = false;
            this.DiagnosisTabButton.Click += new System.EventHandler(this.DiagnosisTabButton_Click);
            // 
            // PrescriptionTabButton
            // 
            this.PrescriptionTabButton.BackColor = System.Drawing.Color.Transparent;
            this.PrescriptionTabButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrescriptionTabButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrescriptionTabButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PrescriptionTabButton.Image = global::medico.Properties.Resources.prbutton;
            this.PrescriptionTabButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PrescriptionTabButton.Location = new System.Drawing.Point(0, 235);
            this.PrescriptionTabButton.Name = "PrescriptionTabButton";
            this.PrescriptionTabButton.Size = new System.Drawing.Size(300, 82);
            this.PrescriptionTabButton.TabIndex = 2;
            this.PrescriptionTabButton.Text = "PRESCRIPTION";
            this.PrescriptionTabButton.UseVisualStyleBackColor = false;
            this.PrescriptionTabButton.Click += new System.EventHandler(this.PrescriptionTabButton_Click);

            // SlidingPanel_ToggleButton
            // 
            this.SlidingPanel_ToggleButton.BackColor = System.Drawing.Color.Transparent;
            this.SlidingPanel_ToggleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingPanel_ToggleButton.Image = global::medico.Properties.Resources.left12;
            this.SlidingPanel_ToggleButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingPanel_ToggleButton.Location = new System.Drawing.Point(0, 0);
            this.SlidingPanel_ToggleButton.Name = "SlidingPanel_ToggleButton";
            this.SlidingPanel_ToggleButton.Size = new System.Drawing.Size(300, 82);
            this.SlidingPanel_ToggleButton.TabIndex = 1;
            this.SlidingPanel_ToggleButton.UseVisualStyleBackColor = false;
            this.SlidingPanel_ToggleButton.Click += new System.EventHandler(this.SlidingPanel_ToggleButton_Click);
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Location = new System.Drawing.Point(300, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(953, 552);
            this.ContentPanel.TabIndex = 1;
            // 
            // PInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1253, 552);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.SlidingPanel);
            this.Name = "PInfo";
            this.Text = "PInfo";
            this.SlidingPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SlidingPanel;
        private System.Windows.Forms.Button SlidingPanel_ToggleButton;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Button DiagnosisTabButton;
        private System.Windows.Forms.Button PrescriptionTabButton;
        private System.Windows.Forms.Button HomeTabButton;
        private System.Windows.Forms.Button PatientTabButton;
        private System.Windows.Forms.Panel ContentPanel;
    }
}