namespace Design_Dashboard_Modern
{
    partial class AddPatient
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
            this.panelTopAddPat = new System.Windows.Forms.Panel();
            this.panelMainAddPatient = new System.Windows.Forms.Panel();
            this.labelNameAddP = new System.Windows.Forms.Label();
            this.labelBirthDayAddP = new System.Windows.Forms.Label();
            this.labelRFCAddP = new System.Windows.Forms.Label();
            this.labelEMailAddP = new System.Windows.Forms.Label();
            this.labelAddPPhone = new System.Windows.Forms.Label();
            this.labelAddPRecomenderBy = new System.Windows.Forms.Label();
            this.labelAddPEtiology = new System.Windows.Forms.Label();
            this.labelAddPMedicAlerts = new System.Windows.Forms.Label();
            this.textBoxNameAddP = new System.Windows.Forms.TextBox();
            this.textBoxRFCAddP = new System.Windows.Forms.TextBox();
            this.textBoxEmailAddP = new System.Windows.Forms.TextBox();
            this.textBoxPhoneAddP = new System.Windows.Forms.TextBox();
            this.textBoxRecomendedbyAddP = new System.Windows.Forms.TextBox();
            this.textBoxEtiolofyAddP = new System.Windows.Forms.TextBox();
            this.textBoxMedicAlertsAddP = new System.Windows.Forms.TextBox();
            this.dateTimePickerAddP = new System.Windows.Forms.DateTimePicker();
            this.buttonAddP = new System.Windows.Forms.Button();
            this.panelMainAddPatient.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopAddPat
            // 
            this.panelTopAddPat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTopAddPat.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAddPat.Location = new System.Drawing.Point(0, 0);
            this.panelTopAddPat.Name = "panelTopAddPat";
            this.panelTopAddPat.Size = new System.Drawing.Size(800, 64);
            this.panelTopAddPat.TabIndex = 0;
            // 
            // panelMainAddPatient
            // 
            this.panelMainAddPatient.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panelMainAddPatient.Controls.Add(this.buttonAddP);
            this.panelMainAddPatient.Controls.Add(this.dateTimePickerAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxMedicAlertsAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxEtiolofyAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxRecomendedbyAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxPhoneAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxEmailAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxRFCAddP);
            this.panelMainAddPatient.Controls.Add(this.textBoxNameAddP);
            this.panelMainAddPatient.Controls.Add(this.labelAddPMedicAlerts);
            this.panelMainAddPatient.Controls.Add(this.labelAddPEtiology);
            this.panelMainAddPatient.Controls.Add(this.labelAddPRecomenderBy);
            this.panelMainAddPatient.Controls.Add(this.labelAddPPhone);
            this.panelMainAddPatient.Controls.Add(this.labelEMailAddP);
            this.panelMainAddPatient.Controls.Add(this.labelRFCAddP);
            this.panelMainAddPatient.Controls.Add(this.labelBirthDayAddP);
            this.panelMainAddPatient.Controls.Add(this.labelNameAddP);
            this.panelMainAddPatient.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainAddPatient.Location = new System.Drawing.Point(0, 64);
            this.panelMainAddPatient.Name = "panelMainAddPatient";
            this.panelMainAddPatient.Size = new System.Drawing.Size(800, 386);
            this.panelMainAddPatient.TabIndex = 1;
            // 
            // labelNameAddP
            // 
            this.labelNameAddP.AutoSize = true;
            this.labelNameAddP.Location = new System.Drawing.Point(94, 25);
            this.labelNameAddP.Name = "labelNameAddP";
            this.labelNameAddP.Size = new System.Drawing.Size(47, 13);
            this.labelNameAddP.TabIndex = 0;
            this.labelNameAddP.Text = "Nombre:";
            // 
            // labelBirthDayAddP
            // 
            this.labelBirthDayAddP.AutoSize = true;
            this.labelBirthDayAddP.Location = new System.Drawing.Point(94, 63);
            this.labelBirthDayAddP.Name = "labelBirthDayAddP";
            this.labelBirthDayAddP.Size = new System.Drawing.Size(111, 13);
            this.labelBirthDayAddP.TabIndex = 1;
            this.labelBirthDayAddP.Text = "Fecha de Nacimiento:";
            // 
            // labelRFCAddP
            // 
            this.labelRFCAddP.AutoSize = true;
            this.labelRFCAddP.Location = new System.Drawing.Point(94, 92);
            this.labelRFCAddP.Name = "labelRFCAddP";
            this.labelRFCAddP.Size = new System.Drawing.Size(31, 13);
            this.labelRFCAddP.TabIndex = 2;
            this.labelRFCAddP.Text = "RFC:";
            // 
            // labelEMailAddP
            // 
            this.labelEMailAddP.AutoSize = true;
            this.labelEMailAddP.Location = new System.Drawing.Point(94, 124);
            this.labelEMailAddP.Name = "labelEMailAddP";
            this.labelEMailAddP.Size = new System.Drawing.Size(35, 13);
            this.labelEMailAddP.TabIndex = 3;
            this.labelEMailAddP.Text = "Email:";
            // 
            // labelAddPPhone
            // 
            this.labelAddPPhone.AutoSize = true;
            this.labelAddPPhone.Location = new System.Drawing.Point(94, 155);
            this.labelAddPPhone.Name = "labelAddPPhone";
            this.labelAddPPhone.Size = new System.Drawing.Size(52, 13);
            this.labelAddPPhone.TabIndex = 4;
            this.labelAddPPhone.Text = "Telefono:";
            // 
            // labelAddPRecomenderBy
            // 
            this.labelAddPRecomenderBy.AutoSize = true;
            this.labelAddPRecomenderBy.Location = new System.Drawing.Point(94, 191);
            this.labelAddPRecomenderBy.Name = "labelAddPRecomenderBy";
            this.labelAddPRecomenderBy.Size = new System.Drawing.Size(98, 13);
            this.labelAddPRecomenderBy.TabIndex = 5;
            this.labelAddPRecomenderBy.Text = "Recomendado por:";
            // 
            // labelAddPEtiology
            // 
            this.labelAddPEtiology.AutoSize = true;
            this.labelAddPEtiology.Location = new System.Drawing.Point(94, 232);
            this.labelAddPEtiology.Name = "labelAddPEtiology";
            this.labelAddPEtiology.Size = new System.Drawing.Size(50, 13);
            this.labelAddPEtiology.TabIndex = 6;
            this.labelAddPEtiology.Text = "Etiologia:";
            // 
            // labelAddPMedicAlerts
            // 
            this.labelAddPMedicAlerts.AutoSize = true;
            this.labelAddPMedicAlerts.Location = new System.Drawing.Point(94, 291);
            this.labelAddPMedicAlerts.Name = "labelAddPMedicAlerts";
            this.labelAddPMedicAlerts.Size = new System.Drawing.Size(84, 13);
            this.labelAddPMedicAlerts.TabIndex = 7;
            this.labelAddPMedicAlerts.Text = "Alertas medicas:";
            // 
            // textBoxNameAddP
            // 
            this.textBoxNameAddP.Location = new System.Drawing.Point(147, 18);
            this.textBoxNameAddP.Name = "textBoxNameAddP";
            this.textBoxNameAddP.Size = new System.Drawing.Size(507, 20);
            this.textBoxNameAddP.TabIndex = 8;
            // 
            // textBoxRFCAddP
            // 
            this.textBoxRFCAddP.Location = new System.Drawing.Point(154, 89);
            this.textBoxRFCAddP.Name = "textBoxRFCAddP";
            this.textBoxRFCAddP.Size = new System.Drawing.Size(165, 20);
            this.textBoxRFCAddP.TabIndex = 9;
            // 
            // textBoxEmailAddP
            // 
            this.textBoxEmailAddP.Location = new System.Drawing.Point(154, 121);
            this.textBoxEmailAddP.Name = "textBoxEmailAddP";
            this.textBoxEmailAddP.Size = new System.Drawing.Size(298, 20);
            this.textBoxEmailAddP.TabIndex = 11;
            // 
            // textBoxPhoneAddP
            // 
            this.textBoxPhoneAddP.Location = new System.Drawing.Point(154, 152);
            this.textBoxPhoneAddP.Name = "textBoxPhoneAddP";
            this.textBoxPhoneAddP.Size = new System.Drawing.Size(135, 20);
            this.textBoxPhoneAddP.TabIndex = 12;
            // 
            // textBoxRecomendedbyAddP
            // 
            this.textBoxRecomendedbyAddP.Location = new System.Drawing.Point(198, 191);
            this.textBoxRecomendedbyAddP.Name = "textBoxRecomendedbyAddP";
            this.textBoxRecomendedbyAddP.Size = new System.Drawing.Size(371, 20);
            this.textBoxRecomendedbyAddP.TabIndex = 13;
            this.textBoxRecomendedbyAddP.TextChanged += new System.EventHandler(this.TextBoxRecomendedbyAddP_TextChanged);
            // 
            // textBoxEtiolofyAddP
            // 
            this.textBoxEtiolofyAddP.Location = new System.Drawing.Point(154, 225);
            this.textBoxEtiolofyAddP.Multiline = true;
            this.textBoxEtiolofyAddP.Name = "textBoxEtiolofyAddP";
            this.textBoxEtiolofyAddP.Size = new System.Drawing.Size(415, 46);
            this.textBoxEtiolofyAddP.TabIndex = 14;
            // 
            // textBoxMedicAlertsAddP
            // 
            this.textBoxMedicAlertsAddP.Location = new System.Drawing.Point(184, 288);
            this.textBoxMedicAlertsAddP.Multiline = true;
            this.textBoxMedicAlertsAddP.Name = "textBoxMedicAlertsAddP";
            this.textBoxMedicAlertsAddP.Size = new System.Drawing.Size(470, 66);
            this.textBoxMedicAlertsAddP.TabIndex = 15;
            // 
            // dateTimePickerAddP
            // 
            this.dateTimePickerAddP.Location = new System.Drawing.Point(211, 57);
            this.dateTimePickerAddP.Name = "dateTimePickerAddP";
            this.dateTimePickerAddP.Size = new System.Drawing.Size(200, 20);
            this.dateTimePickerAddP.TabIndex = 16;
            // 
            // buttonAddP
            // 
            this.buttonAddP.Location = new System.Drawing.Point(713, 351);
            this.buttonAddP.Name = "buttonAddP";
            this.buttonAddP.Size = new System.Drawing.Size(75, 23);
            this.buttonAddP.TabIndex = 17;
            this.buttonAddP.Text = "Agregar";
            this.buttonAddP.UseVisualStyleBackColor = true;
            this.buttonAddP.Click += new System.EventHandler(this.ButtonAddP_Click);
            // 
            // AddPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMainAddPatient);
            this.Controls.Add(this.panelTopAddPat);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.panelMainAddPatient.ResumeLayout(false);
            this.panelMainAddPatient.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopAddPat;
        private System.Windows.Forms.Panel panelMainAddPatient;
        private System.Windows.Forms.TextBox textBoxMedicAlertsAddP;
        private System.Windows.Forms.TextBox textBoxEtiolofyAddP;
        private System.Windows.Forms.TextBox textBoxRecomendedbyAddP;
        private System.Windows.Forms.TextBox textBoxPhoneAddP;
        private System.Windows.Forms.TextBox textBoxEmailAddP;
        private System.Windows.Forms.TextBox textBoxRFCAddP;
        private System.Windows.Forms.TextBox textBoxNameAddP;
        private System.Windows.Forms.Label labelAddPMedicAlerts;
        private System.Windows.Forms.Label labelAddPEtiology;
        private System.Windows.Forms.Label labelAddPRecomenderBy;
        private System.Windows.Forms.Label labelAddPPhone;
        private System.Windows.Forms.Label labelEMailAddP;
        private System.Windows.Forms.Label labelRFCAddP;
        private System.Windows.Forms.Label labelBirthDayAddP;
        private System.Windows.Forms.Label labelNameAddP;
        private System.Windows.Forms.Button buttonAddP;
        private System.Windows.Forms.DateTimePicker dateTimePickerAddP;
    }
}