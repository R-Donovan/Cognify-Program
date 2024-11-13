namespace Cognify
{
    partial class FormInicio
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
            this.btnRehabilitation = new System.Windows.Forms.Button();
            this.btnSetenciaFisica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnRehabilitation
            // 
            this.btnRehabilitation.Location = new System.Drawing.Point(313, 93);
            this.btnRehabilitation.Name = "btnRehabilitation";
            this.btnRehabilitation.Size = new System.Drawing.Size(95, 23);
            this.btnRehabilitation.TabIndex = 3;
            this.btnRehabilitation.Text = "Rehabilitacion Cognify";
            this.btnRehabilitation.UseVisualStyleBackColor = true;
            this.btnRehabilitation.Click += new System.EventHandler(this.btnRehabilitation_Click);
            // 
            // btnSetenciaFisica
            // 
            this.btnSetenciaFisica.Location = new System.Drawing.Point(70, 93);
            this.btnSetenciaFisica.Name = "btnSetenciaFisica";
            this.btnSetenciaFisica.Size = new System.Drawing.Size(126, 23);
            this.btnSetenciaFisica.TabIndex = 2;
            this.btnSetenciaFisica.Text = "Sentencia Fisica";
            this.btnSetenciaFisica.UseVisualStyleBackColor = true;
            this.btnSetenciaFisica.Click += new System.EventHandler(this.btnSetenciaFisica_Click);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 238);
            this.Controls.Add(this.btnRehabilitation);
            this.Controls.Add(this.btnSetenciaFisica);
            this.Name = "FormInicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRehabilitation;
        private System.Windows.Forms.Button btnSetenciaFisica;
    }
}