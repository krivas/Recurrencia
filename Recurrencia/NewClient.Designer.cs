namespace Recurrencia
{
    partial class NewClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nombreTxt = new System.Windows.Forms.TextBox();
            this.apellidoTxt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.numeroSocioTxt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tipoClienteCmb = new System.Windows.Forms.ComboBox();
            this.EmpresaTxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.telefonoHogarTxt = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.DireccionTxt = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.direccionAlternaTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CelularTxt = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.trabajoTxt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.extensionTxt = new System.Windows.Forms.TextBox();
            this.correoTxt = new System.Windows.Forms.TextBox();
            this.correoAlternoTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(246, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 2;
            // 
            // nombreTxt
            // 
            this.nombreTxt.Location = new System.Drawing.Point(18, 49);
            this.nombreTxt.Name = "nombreTxt";
            this.nombreTxt.Size = new System.Drawing.Size(216, 20);
            this.nombreTxt.TabIndex = 3;
            // 
            // apellidoTxt
            // 
            this.apellidoTxt.Location = new System.Drawing.Point(18, 97);
            this.apellidoTxt.Name = "apellidoTxt";
            this.apellidoTxt.Size = new System.Drawing.Size(216, 20);
            this.apellidoTxt.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 490);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Crear Cliente";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numeroSocioTxt
            // 
            this.numeroSocioTxt.Location = new System.Drawing.Point(240, 97);
            this.numeroSocioTxt.Mask = "00-0000";
            this.numeroSocioTxt.Name = "numeroSocioTxt";
            this.numeroSocioTxt.Size = new System.Drawing.Size(213, 20);
            this.numeroSocioTxt.TabIndex = 6;
            this.numeroSocioTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(287, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Numero de Socio :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(15, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Empresa :";
            // 
            // tipoClienteCmb
            // 
            this.tipoClienteCmb.FormattingEnabled = true;
            this.tipoClienteCmb.Items.AddRange(new object[] {
            "Cooperativa",
            "Contado"});
            this.tipoClienteCmb.Location = new System.Drawing.Point(240, 48);
            this.tipoClienteCmb.MaxDropDownItems = 2;
            this.tipoClienteCmb.Name = "tipoClienteCmb";
            this.tipoClienteCmb.Size = new System.Drawing.Size(213, 21);
            this.tipoClienteCmb.TabIndex = 15;
            this.tipoClienteCmb.Text = "Tipo de Cliente";
            // 
            // EmpresaTxt
            // 
            this.EmpresaTxt.Location = new System.Drawing.Point(18, 148);
            this.EmpresaTxt.Name = "EmpresaTxt";
            this.EmpresaTxt.Size = new System.Drawing.Size(435, 20);
            this.EmpresaTxt.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.correoAlternoTxt);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.correoTxt);
            this.groupBox1.Controls.Add(this.extensionTxt);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.trabajoTxt);
            this.groupBox1.Controls.Add(this.CelularTxt);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.direccionAlternaTxt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.telefonoHogarTxt);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.DireccionTxt);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.apellidoTxt);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.EmpresaTxt);
            this.groupBox1.Controls.Add(this.nombreTxt);
            this.groupBox1.Controls.Add(this.numeroSocioTxt);
            this.groupBox1.Controls.Add(this.tipoClienteCmb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(471, 519);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nuevo Cliente";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 394);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "Correo Electronico:";
            // 
            // telefonoHogarTxt
            // 
            this.telefonoHogarTxt.Location = new System.Drawing.Point(18, 311);
            this.telefonoHogarTxt.Mask = "(000)-000-0000";
            this.telefonoHogarTxt.Name = "telefonoHogarTxt";
            this.telefonoHogarTxt.Size = new System.Drawing.Size(213, 20);
            this.telefonoHogarTxt.TabIndex = 28;
            this.telefonoHogarTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 295);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(84, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "Telefono Hogar:";
            // 
            // DireccionTxt
            // 
            this.DireccionTxt.Location = new System.Drawing.Point(18, 207);
            this.DireccionTxt.Name = "DireccionTxt";
            this.DireccionTxt.Size = new System.Drawing.Size(435, 20);
            this.DireccionTxt.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Direccion:";
            // 
            // direccionAlternaTxt
            // 
            this.direccionAlternaTxt.Location = new System.Drawing.Point(18, 252);
            this.direccionAlternaTxt.Name = "direccionAlternaTxt";
            this.direccionAlternaTxt.Size = new System.Drawing.Size(435, 20);
            this.direccionAlternaTxt.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Direccion-alterna:";
            // 
            // CelularTxt
            // 
            this.CelularTxt.Location = new System.Drawing.Point(240, 311);
            this.CelularTxt.Mask = "(000)-000-0000";
            this.CelularTxt.Name = "CelularTxt";
            this.CelularTxt.Size = new System.Drawing.Size(213, 20);
            this.CelularTxt.TabIndex = 33;
            this.CelularTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 295);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 32;
            this.label6.Text = "Celular:";
            // 
            // trabajoTxt
            // 
            this.trabajoTxt.Location = new System.Drawing.Point(18, 359);
            this.trabajoTxt.Mask = "(000)-000-0000";
            this.trabajoTxt.Name = "trabajoTxt";
            this.trabajoTxt.Size = new System.Drawing.Size(213, 20);
            this.trabajoTxt.TabIndex = 34;
            this.trabajoTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 35;
            this.label7.Text = "Trabajo:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(247, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 36;
            this.label12.Text = "Extension:";
            // 
            // extensionTxt
            // 
            this.extensionTxt.Location = new System.Drawing.Point(241, 359);
            this.extensionTxt.Name = "extensionTxt";
            this.extensionTxt.Size = new System.Drawing.Size(213, 20);
            this.extensionTxt.TabIndex = 37;
            // 
            // correoTxt
            // 
            this.correoTxt.Location = new System.Drawing.Point(18, 410);
            this.correoTxt.Name = "correoTxt";
            this.correoTxt.Size = new System.Drawing.Size(435, 20);
            this.correoTxt.TabIndex = 38;
            // 
            // correoAlternoTxt
            // 
            this.correoAlternoTxt.Location = new System.Drawing.Point(18, 464);
            this.correoAlternoTxt.Name = "correoAlternoTxt";
            this.correoAlternoTxt.Size = new System.Drawing.Size(435, 20);
            this.correoAlternoTxt.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(19, 448);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(77, 13);
            this.label13.TabIndex = 39;
            this.label13.Text = "Correo Alterno:";
            // 
            // NewClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 543);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Name = "NewClient";
            this.Text = "Recurrencia";
            this.Load += new System.EventHandler(this.NewClient_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nombreTxt;
        private System.Windows.Forms.TextBox apellidoTxt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox numeroSocioTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox tipoClienteCmb;
        private System.Windows.Forms.TextBox EmpresaTxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox DireccionTxt;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox telefonoHogarTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox correoAlternoTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox correoTxt;
        private System.Windows.Forms.TextBox extensionTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox trabajoTxt;
        private System.Windows.Forms.MaskedTextBox CelularTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox direccionAlternaTxt;
        private System.Windows.Forms.Label label5;
    }
}

