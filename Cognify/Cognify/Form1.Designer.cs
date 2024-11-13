
namespace Cognify
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApplyRehabilitation = new System.Windows.Forms.Button();
            this.btnShowImpact = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblCrimeType = new System.Windows.Forms.Label();
            this.cbCrimeType = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblInmateName = new System.Windows.Forms.Label();
            this.lblExample1 = new System.Windows.Forms.Label();
            this.txtImateName = new System.Windows.Forms.TextBox();
            this.lblresult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnApplyRehabilitation
            // 
            this.btnApplyRehabilitation.Location = new System.Drawing.Point(15, 325);
            this.btnApplyRehabilitation.Name = "btnApplyRehabilitation";
            this.btnApplyRehabilitation.Size = new System.Drawing.Size(126, 23);
            this.btnApplyRehabilitation.TabIndex = 0;
            this.btnApplyRehabilitation.Text = "Aplicar Rehabilitacion";
            this.btnApplyRehabilitation.UseVisualStyleBackColor = true;
            this.btnApplyRehabilitation.Click += new System.EventHandler(this.btnApplyRehabilitation_Click);
            // 
            // btnShowImpact
            // 
            this.btnShowImpact.Location = new System.Drawing.Point(15, 370);
            this.btnShowImpact.Name = "btnShowImpact";
            this.btnShowImpact.Size = new System.Drawing.Size(95, 23);
            this.btnShowImpact.TabIndex = 1;
            this.btnShowImpact.Text = "Mostrar Impacto";
            this.btnShowImpact.UseVisualStyleBackColor = true;
            this.btnShowImpact.Click += new System.EventHandler(this.btnShowImpact_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(194, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(167, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Sistema de Rehabilitación Cognify";
            // 
            // lblCrimeType
            // 
            this.lblCrimeType.AutoSize = true;
            this.lblCrimeType.Location = new System.Drawing.Point(12, 250);
            this.lblCrimeType.Name = "lblCrimeType";
            this.lblCrimeType.Size = new System.Drawing.Size(81, 13);
            this.lblCrimeType.TabIndex = 3;
            this.lblCrimeType.Text = "Tipo de Crimen:";
            // 
            // cbCrimeType
            // 
            this.cbCrimeType.FormattingEnabled = true;
            this.cbCrimeType.Items.AddRange(new object[] {
            "Violento",
            "Financiero",
            "De Odio"});
            this.cbCrimeType.Location = new System.Drawing.Point(15, 276);
            this.cbCrimeType.Name = "cbCrimeType";
            this.cbCrimeType.Size = new System.Drawing.Size(91, 21);
            this.cbCrimeType.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ImageLocation = "https://img.freepik.com/vector-premium/prisionero-barra_29190-3939.jpg";
            this.pictureBox1.Location = new System.Drawing.Point(15, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(173, 164);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // lblInmateName
            // 
            this.lblInmateName.AutoSize = true;
            this.lblInmateName.Location = new System.Drawing.Point(12, 198);
            this.lblInmateName.Name = "lblInmateName";
            this.lblInmateName.Size = new System.Drawing.Size(111, 13);
            this.lblInmateName.TabIndex = 6;
            this.lblInmateName.Text = "Nombre de Prisionero:";
            // 
            // lblExample1
            // 
            this.lblExample1.AutoSize = true;
            this.lblExample1.Location = new System.Drawing.Point(194, 60);
            this.lblExample1.Name = "lblExample1";
            this.lblExample1.Size = new System.Drawing.Size(99, 13);
            this.lblExample1.TabIndex = 7;
            this.lblExample1.Text = "<-- Ejemplo de perfil";
            // 
            // txtImateName
            // 
            this.txtImateName.Location = new System.Drawing.Point(15, 214);
            this.txtImateName.Name = "txtImateName";
            this.txtImateName.Size = new System.Drawing.Size(100, 20);
            this.txtImateName.TabIndex = 8;
            // 
            // lblresult
            // 
            this.lblresult.AutoSize = true;
            this.lblresult.Location = new System.Drawing.Point(12, 409);
            this.lblresult.Name = "lblresult";
            this.lblresult.Size = new System.Drawing.Size(0, 13);
            this.lblresult.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 466);
            this.Controls.Add(this.lblresult);
            this.Controls.Add(this.txtImateName);
            this.Controls.Add(this.lblExample1);
            this.Controls.Add(this.lblInmateName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.cbCrimeType);
            this.Controls.Add(this.lblCrimeType);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShowImpact);
            this.Controls.Add(this.btnApplyRehabilitation);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApplyRehabilitation;
        private System.Windows.Forms.Button btnShowImpact;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblCrimeType;
        private System.Windows.Forms.ComboBox cbCrimeType;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblInmateName;
        private System.Windows.Forms.Label lblExample1;
        private System.Windows.Forms.TextBox txtImateName;
        private System.Windows.Forms.Label lblresult;
    }
}

