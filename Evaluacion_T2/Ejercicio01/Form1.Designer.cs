namespace Ejercicio01
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
            this.txtNombreBKP = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaUltimoBKP = new System.Windows.Forms.Label();
            this.lblUltimoBKP = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnUtilizar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtLIstaBackups = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombreBKP
            // 
            this.txtNombreBKP.Location = new System.Drawing.Point(65, 69);
            this.txtNombreBKP.Name = "txtNombreBKP";
            this.txtNombreBKP.Size = new System.Drawing.Size(190, 20);
            this.txtNombreBKP.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaUltimoBKP);
            this.groupBox1.Controls.Add(this.lblUltimoBKP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(261, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 89);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ùltimo Backup";
            // 
            // lblFechaUltimoBKP
            // 
            this.lblFechaUltimoBKP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechaUltimoBKP.Location = new System.Drawing.Point(97, 53);
            this.lblFechaUltimoBKP.Name = "lblFechaUltimoBKP";
            this.lblFechaUltimoBKP.Size = new System.Drawing.Size(250, 15);
            this.lblFechaUltimoBKP.TabIndex = 3;
            // 
            // lblUltimoBKP
            // 
            this.lblUltimoBKP.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUltimoBKP.Location = new System.Drawing.Point(97, 24);
            this.lblUltimoBKP.Name = "lblUltimoBKP";
            this.lblUltimoBKP.Size = new System.Drawing.Size(250, 15);
            this.lblUltimoBKP.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Listado de Backups";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(18, 101);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnUtilizar
            // 
            this.btnUtilizar.Location = new System.Drawing.Point(99, 101);
            this.btnUtilizar.Name = "btnUtilizar";
            this.btnUtilizar.Size = new System.Drawing.Size(75, 23);
            this.btnUtilizar.TabIndex = 9;
            this.btnUtilizar.Text = "Utilizar";
            this.btnUtilizar.UseVisualStyleBackColor = true;
            this.btnUtilizar.Click += new System.EventHandler(this.btnUtilizar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(180, 101);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 10;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtLIstaBackups
            // 
            this.txtLIstaBackups.Location = new System.Drawing.Point(18, 146);
            this.txtLIstaBackups.Multiline = true;
            this.txtLIstaBackups.Name = "txtLIstaBackups";
            this.txtLIstaBackups.Size = new System.Drawing.Size(237, 163);
            this.txtLIstaBackups.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 330);
            this.Controls.Add(this.txtLIstaBackups);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnUtilizar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombreBKP);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Administraciòn de Backups";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombreBKP;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaUltimoBKP;
        private System.Windows.Forms.Label lblUltimoBKP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnUtilizar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtLIstaBackups;
    }
}

