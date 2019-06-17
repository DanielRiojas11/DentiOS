namespace Design_Dashboard_Modern
{
    partial class AddConsult
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
            this.panelAddCTop = new System.Windows.Forms.Panel();
            this.panelMainAddC = new System.Windows.Forms.Panel();
            this.labelDateAddC = new System.Windows.Forms.Label();
            this.labelCauseAddC = new System.Windows.Forms.Label();
            this.labelObservationsAddC = new System.Windows.Forms.Label();
            this.textBoxCauseAddC = new System.Windows.Forms.TextBox();
            this.textBoxObservations = new System.Windows.Forms.TextBox();
            this.buttonAddC = new System.Windows.Forms.Button();
            this.FechaAddConsulta = new System.Windows.Forms.DateTimePicker();
            this.panelMainAddC.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddCTop
            // 
            this.panelAddCTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelAddCTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelAddCTop.Location = new System.Drawing.Point(0, 0);
            this.panelAddCTop.Name = "panelAddCTop";
            this.panelAddCTop.Size = new System.Drawing.Size(565, 57);
            this.panelAddCTop.TabIndex = 0;
            // 
            // panelMainAddC
            // 
            this.panelMainAddC.Controls.Add(this.FechaAddConsulta);
            this.panelMainAddC.Controls.Add(this.buttonAddC);
            this.panelMainAddC.Controls.Add(this.textBoxObservations);
            this.panelMainAddC.Controls.Add(this.textBoxCauseAddC);
            this.panelMainAddC.Controls.Add(this.labelObservationsAddC);
            this.panelMainAddC.Controls.Add(this.labelCauseAddC);
            this.panelMainAddC.Controls.Add(this.labelDateAddC);
            this.panelMainAddC.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainAddC.Location = new System.Drawing.Point(0, 57);
            this.panelMainAddC.Name = "panelMainAddC";
            this.panelMainAddC.Size = new System.Drawing.Size(565, 309);
            this.panelMainAddC.TabIndex = 1;
            // 
            // labelDateAddC
            // 
            this.labelDateAddC.AutoSize = true;
            this.labelDateAddC.Location = new System.Drawing.Point(50, 38);
            this.labelDateAddC.Name = "labelDateAddC";
            this.labelDateAddC.Size = new System.Drawing.Size(40, 13);
            this.labelDateAddC.TabIndex = 0;
            this.labelDateAddC.Text = "Fecha:";
            // 
            // labelCauseAddC
            // 
            this.labelCauseAddC.AutoSize = true;
            this.labelCauseAddC.Location = new System.Drawing.Point(50, 74);
            this.labelCauseAddC.Name = "labelCauseAddC";
            this.labelCauseAddC.Size = new System.Drawing.Size(101, 13);
            this.labelCauseAddC.TabIndex = 1;
            this.labelCauseAddC.Text = "Motivo de Consulta:";
            // 
            // labelObservationsAddC
            // 
            this.labelObservationsAddC.AutoSize = true;
            this.labelObservationsAddC.Location = new System.Drawing.Point(50, 181);
            this.labelObservationsAddC.Name = "labelObservationsAddC";
            this.labelObservationsAddC.Size = new System.Drawing.Size(81, 13);
            this.labelObservationsAddC.TabIndex = 2;
            this.labelObservationsAddC.Text = "Observaciones:";
            this.labelObservationsAddC.Click += new System.EventHandler(this.LabelObservationsAddC_Click);
            // 
            // textBoxCauseAddC
            // 
            this.textBoxCauseAddC.Location = new System.Drawing.Point(53, 90);
            this.textBoxCauseAddC.Multiline = true;
            this.textBoxCauseAddC.Name = "textBoxCauseAddC";
            this.textBoxCauseAddC.Size = new System.Drawing.Size(422, 67);
            this.textBoxCauseAddC.TabIndex = 3;
            // 
            // textBoxObservations
            // 
            this.textBoxObservations.Location = new System.Drawing.Point(53, 197);
            this.textBoxObservations.Multiline = true;
            this.textBoxObservations.Name = "textBoxObservations";
            this.textBoxObservations.Size = new System.Drawing.Size(422, 62);
            this.textBoxObservations.TabIndex = 4;
            // 
            // buttonAddC
            // 
            this.buttonAddC.Location = new System.Drawing.Point(458, 265);
            this.buttonAddC.Name = "buttonAddC";
            this.buttonAddC.Size = new System.Drawing.Size(75, 23);
            this.buttonAddC.TabIndex = 5;
            this.buttonAddC.Text = "Agregar";
            this.buttonAddC.UseVisualStyleBackColor = true;
            this.buttonAddC.Click += new System.EventHandler(this.ButtonAddC_Click);
            // 
            // FechaAddConsulta
            // 
            this.FechaAddConsulta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FechaAddConsulta.Location = new System.Drawing.Point(110, 31);
            this.FechaAddConsulta.Name = "FechaAddConsulta";
            this.FechaAddConsulta.Size = new System.Drawing.Size(240, 20);
            this.FechaAddConsulta.TabIndex = 9;
            // 
            // AddConsult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 366);
            this.Controls.Add(this.panelMainAddC);
            this.Controls.Add(this.panelAddCTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddConsult";
            this.Text = "Form3";
            this.panelMainAddC.ResumeLayout(false);
            this.panelMainAddC.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelAddCTop;
        private System.Windows.Forms.Panel panelMainAddC;
        private System.Windows.Forms.Label labelDateAddC;
        private System.Windows.Forms.TextBox textBoxObservations;
        private System.Windows.Forms.TextBox textBoxCauseAddC;
        private System.Windows.Forms.Label labelObservationsAddC;
        private System.Windows.Forms.Label labelCauseAddC;
        private System.Windows.Forms.Button buttonAddC;
        private System.Windows.Forms.DateTimePicker FechaAddConsulta;
    }
}