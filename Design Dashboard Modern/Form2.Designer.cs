namespace Design_Dashboard_Modern
{
    partial class AddAdeudo
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
            this.panelTopAddA = new System.Windows.Forms.Panel();
            this.panelMainAddA = new System.Windows.Forms.Panel();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelPayment = new System.Windows.Forms.Label();
            this.labelTrat = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxPayment = new System.Windows.Forms.TextBox();
            this.textBoxTrat = new System.Windows.Forms.TextBox();
            this.radioButtonCash = new System.Windows.Forms.RadioButton();
            this.radioButtonTarget = new System.Windows.Forms.RadioButton();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelMainAddA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTopAddA
            // 
            this.panelTopAddA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(46)))));
            this.panelTopAddA.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAddA.Location = new System.Drawing.Point(0, 0);
            this.panelTopAddA.Name = "panelTopAddA";
            this.panelTopAddA.Size = new System.Drawing.Size(318, 54);
            this.panelTopAddA.TabIndex = 0;
            // 
            // panelMainAddA
            // 
            this.panelMainAddA.Controls.Add(this.buttonAdd);
            this.panelMainAddA.Controls.Add(this.radioButtonTarget);
            this.panelMainAddA.Controls.Add(this.radioButtonCash);
            this.panelMainAddA.Controls.Add(this.textBoxTrat);
            this.panelMainAddA.Controls.Add(this.textBoxPayment);
            this.panelMainAddA.Controls.Add(this.textBoxDate);
            this.panelMainAddA.Controls.Add(this.labelTrat);
            this.panelMainAddA.Controls.Add(this.labelPayment);
            this.panelMainAddA.Controls.Add(this.labelDate);
            this.panelMainAddA.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMainAddA.Location = new System.Drawing.Point(0, 54);
            this.panelMainAddA.Name = "panelMainAddA";
            this.panelMainAddA.Size = new System.Drawing.Size(318, 232);
            this.panelMainAddA.TabIndex = 1;
            this.panelMainAddA.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelMainAddA_Paint);
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(36, 15);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(37, 13);
            this.labelDate.TabIndex = 0;
            this.labelDate.Text = "Fecha";
            this.labelDate.Click += new System.EventHandler(this.LabelDate_Click);
            // 
            // labelPayment
            // 
            this.labelPayment.AutoSize = true;
            this.labelPayment.Location = new System.Drawing.Point(36, 73);
            this.labelPayment.Name = "labelPayment";
            this.labelPayment.Size = new System.Drawing.Size(32, 13);
            this.labelPayment.TabIndex = 1;
            this.labelPayment.Text = "Pago";
            // 
            // labelTrat
            // 
            this.labelTrat.AutoSize = true;
            this.labelTrat.Location = new System.Drawing.Point(36, 139);
            this.labelTrat.Name = "labelTrat";
            this.labelTrat.Size = new System.Drawing.Size(63, 13);
            this.labelTrat.TabIndex = 2;
            this.labelTrat.Text = "Tratamiento";
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(79, 12);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(183, 20);
            this.textBoxDate.TabIndex = 3;
            this.textBoxDate.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // textBoxPayment
            // 
            this.textBoxPayment.Location = new System.Drawing.Point(74, 70);
            this.textBoxPayment.Name = "textBoxPayment";
            this.textBoxPayment.Size = new System.Drawing.Size(100, 20);
            this.textBoxPayment.TabIndex = 4;
            // 
            // textBoxTrat
            // 
            this.textBoxTrat.Location = new System.Drawing.Point(123, 136);
            this.textBoxTrat.Name = "textBoxTrat";
            this.textBoxTrat.Size = new System.Drawing.Size(139, 20);
            this.textBoxTrat.TabIndex = 5;
            // 
            // radioButtonCash
            // 
            this.radioButtonCash.AutoSize = true;
            this.radioButtonCash.Location = new System.Drawing.Point(193, 55);
            this.radioButtonCash.Name = "radioButtonCash";
            this.radioButtonCash.Size = new System.Drawing.Size(64, 17);
            this.radioButtonCash.TabIndex = 6;
            this.radioButtonCash.TabStop = true;
            this.radioButtonCash.Text = "Efectivo";
            this.radioButtonCash.UseVisualStyleBackColor = true;
            // 
            // radioButtonTarget
            // 
            this.radioButtonTarget.AutoSize = true;
            this.radioButtonTarget.Location = new System.Drawing.Point(193, 89);
            this.radioButtonTarget.Name = "radioButtonTarget";
            this.radioButtonTarget.Size = new System.Drawing.Size(58, 17);
            this.radioButtonTarget.TabIndex = 7;
            this.radioButtonTarget.TabStop = true;
            this.radioButtonTarget.Text = "Tarjeta";
            this.radioButtonTarget.UseVisualStyleBackColor = true;
            this.radioButtonTarget.CheckedChanged += new System.EventHandler(this.RadioButton2_CheckedChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(231, 197);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Listo";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // AddAdeudo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 286);
            this.Controls.Add(this.panelMainAddA);
            this.Controls.Add(this.panelTopAddA);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddAdeudo";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panelMainAddA.ResumeLayout(false);
            this.panelMainAddA.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTopAddA;
        private System.Windows.Forms.Panel panelMainAddA;
        private System.Windows.Forms.Label labelTrat;
        private System.Windows.Forms.Label labelPayment;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.RadioButton radioButtonTarget;
        private System.Windows.Forms.RadioButton radioButtonCash;
        private System.Windows.Forms.TextBox textBoxTrat;
        private System.Windows.Forms.TextBox textBoxPayment;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.Button buttonAdd;
    }
}