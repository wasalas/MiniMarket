namespace CapaPresentacion
{
    partial class frmClientes_ed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClientes_ed));
            this.label1 = new System.Windows.Forms.Label();
            this.txt_codigo_cl = new System.Windows.Forms.TextBox();
            this.txt_num_doc_ide = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chk_estado = new System.Windows.Forms.CheckBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txt_observaciones = new System.Windows.Forms.TextBox();
            this.cbo_distritos = new System.Windows.Forms.ComboBox();
            this.cbo_provincias = new System.Windows.Forms.ComboBox();
            this.cbo_departamentos = new System.Windows.Forms.ComboBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_movil = new System.Windows.Forms.TextBox();
            this.txt_telefonos = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.cbo_sexo = new System.Windows.Forms.ComboBox();
            this.txt_nombres = new System.Windows.Forms.TextBox();
            this.txt_apellidos = new System.Windows.Forms.TextBox();
            this.txt_raz_soc = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.cbo_tip_doc_ide = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Codigo :";
            // 
            // txt_codigo_cl
            // 
            this.txt_codigo_cl.Enabled = false;
            this.txt_codigo_cl.Location = new System.Drawing.Point(122, 19);
            this.txt_codigo_cl.Name = "txt_codigo_cl";
            this.txt_codigo_cl.Size = new System.Drawing.Size(44, 20);
            this.txt_codigo_cl.TabIndex = 5;
            // 
            // txt_num_doc_ide
            // 
            this.txt_num_doc_ide.Location = new System.Drawing.Point(412, 48);
            this.txt_num_doc_ide.MaxLength = 30;
            this.txt_num_doc_ide.Name = "txt_num_doc_ide";
            this.txt_num_doc_ide.Size = new System.Drawing.Size(198, 20);
            this.txt_num_doc_ide.TabIndex = 25;
            this.txt_num_doc_ide.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tipo Documento :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 170;
            this.label3.Text = "Estado :";
            // 
            // chk_estado
            // 
            this.chk_estado.AutoSize = true;
            this.chk_estado.Location = new System.Drawing.Point(122, 407);
            this.chk_estado.Name = "chk_estado";
            this.chk_estado.Size = new System.Drawing.Size(56, 17);
            this.chk_estado.TabIndex = 175;
            this.chk_estado.Text = "Activo";
            this.chk_estado.UseVisualStyleBackColor = true;
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cancelar.Image")));
            this.btn_cancelar.Location = new System.Drawing.Point(325, 449);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(100, 52);
            this.btn_cancelar.TabIndex = 205;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.Location = new System.Drawing.Point(219, 449);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(100, 52);
            this.btn_guardar.TabIndex = 200;
            this.btn_guardar.Text = "&Guardar";
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txt_observaciones);
            this.groupBox1.Controls.Add(this.cbo_distritos);
            this.groupBox1.Controls.Add(this.cbo_provincias);
            this.groupBox1.Controls.Add(this.cbo_departamentos);
            this.groupBox1.Controls.Add(this.txt_direccion);
            this.groupBox1.Controls.Add(this.txt_movil);
            this.groupBox1.Controls.Add(this.txt_telefonos);
            this.groupBox1.Controls.Add(this.txt_email);
            this.groupBox1.Controls.Add(this.cbo_sexo);
            this.groupBox1.Controls.Add(this.txt_nombres);
            this.groupBox1.Controls.Add(this.txt_apellidos);
            this.groupBox1.Controls.Add(this.txt_raz_soc);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.cbo_tip_doc_ide);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_num_doc_ide);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txt_codigo_cl);
            this.groupBox1.Controls.Add(this.chk_estado);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(627, 431);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DATOS GENERALES";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(119, 110);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(66, 13);
            this.label18.TabIndex = 176;
            this.label18.Text = "Apellidos :";
            // 
            // txt_observaciones
            // 
            this.txt_observaciones.Location = new System.Drawing.Point(122, 345);
            this.txt_observaciones.MaxLength = 250;
            this.txt_observaciones.Multiline = true;
            this.txt_observaciones.Name = "txt_observaciones";
            this.txt_observaciones.Size = new System.Drawing.Size(488, 54);
            this.txt_observaciones.TabIndex = 165;
            this.txt_observaciones.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // cbo_distritos
            // 
            this.cbo_distritos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_distritos.FormattingEnabled = true;
            this.cbo_distritos.Location = new System.Drawing.Point(489, 315);
            this.cbo_distritos.Name = "cbo_distritos";
            this.cbo_distritos.Size = new System.Drawing.Size(121, 21);
            this.cbo_distritos.TabIndex = 155;
            // 
            // cbo_provincias
            // 
            this.cbo_provincias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_provincias.FormattingEnabled = true;
            this.cbo_provincias.Location = new System.Drawing.Point(317, 315);
            this.cbo_provincias.Name = "cbo_provincias";
            this.cbo_provincias.Size = new System.Drawing.Size(121, 21);
            this.cbo_provincias.TabIndex = 145;
            this.cbo_provincias.SelectionChangeCommitted += new System.EventHandler(this.cbo_provincias_SelectionChangeCommitted);
            // 
            // cbo_departamentos
            // 
            this.cbo_departamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_departamentos.FormattingEnabled = true;
            this.cbo_departamentos.Location = new System.Drawing.Point(122, 315);
            this.cbo_departamentos.Name = "cbo_departamentos";
            this.cbo_departamentos.Size = new System.Drawing.Size(121, 21);
            this.cbo_departamentos.TabIndex = 135;
            this.cbo_departamentos.SelectionChangeCommitted += new System.EventHandler(this.cbo_departamentos_SelectionChangeCommitted);
            // 
            // txt_direccion
            // 
            this.txt_direccion.Location = new System.Drawing.Point(122, 248);
            this.txt_direccion.MaxLength = 150;
            this.txt_direccion.Multiline = true;
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(488, 53);
            this.txt_direccion.TabIndex = 125;
            this.txt_direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // txt_movil
            // 
            this.txt_movil.Location = new System.Drawing.Point(122, 219);
            this.txt_movil.MaxLength = 50;
            this.txt_movil.Name = "txt_movil";
            this.txt_movil.Size = new System.Drawing.Size(488, 20);
            this.txt_movil.TabIndex = 115;
            this.txt_movil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // txt_telefonos
            // 
            this.txt_telefonos.Location = new System.Drawing.Point(122, 190);
            this.txt_telefonos.MaxLength = 50;
            this.txt_telefonos.Name = "txt_telefonos";
            this.txt_telefonos.Size = new System.Drawing.Size(488, 20);
            this.txt_telefonos.TabIndex = 100;
            this.txt_telefonos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(122, 161);
            this.txt_email.MaxLength = 150;
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(488, 20);
            this.txt_email.TabIndex = 85;
            this.txt_email.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // cbo_sexo
            // 
            this.cbo_sexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_sexo.FormattingEnabled = true;
            this.cbo_sexo.Location = new System.Drawing.Point(511, 129);
            this.cbo_sexo.Name = "cbo_sexo";
            this.cbo_sexo.Size = new System.Drawing.Size(99, 21);
            this.cbo_sexo.TabIndex = 65;
            // 
            // txt_nombres
            // 
            this.txt_nombres.Location = new System.Drawing.Point(317, 129);
            this.txt_nombres.MaxLength = 100;
            this.txt_nombres.Name = "txt_nombres";
            this.txt_nombres.Size = new System.Drawing.Size(190, 20);
            this.txt_nombres.TabIndex = 55;
            this.txt_nombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // txt_apellidos
            // 
            this.txt_apellidos.Location = new System.Drawing.Point(122, 129);
            this.txt_apellidos.MaxLength = 100;
            this.txt_apellidos.Name = "txt_apellidos";
            this.txt_apellidos.Size = new System.Drawing.Size(190, 20);
            this.txt_apellidos.TabIndex = 45;
            this.txt_apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // txt_raz_soc
            // 
            this.txt_raz_soc.Location = new System.Drawing.Point(122, 78);
            this.txt_raz_soc.MaxLength = 150;
            this.txt_raz_soc.Name = "txt_raz_soc";
            this.txt_raz_soc.Size = new System.Drawing.Size(488, 20);
            this.txt_raz_soc.TabIndex = 35;
            this.txt_raz_soc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Textos_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(17, 348);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(99, 13);
            this.label17.TabIndex = 160;
            this.label17.Text = "Observaciones :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(444, 319);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 13);
            this.label16.TabIndex = 150;
            this.label16.Text = "Distrito";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(254, 318);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(68, 13);
            this.label15.TabIndex = 140;
            this.label15.Text = "Provincia :";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 319);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(94, 13);
            this.label14.TabIndex = 130;
            this.label14.Text = "Departamento :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(17, 251);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(69, 13);
            this.label13.TabIndex = 120;
            this.label13.Text = "Direccion :";
            // 
            // cbo_tip_doc_ide
            // 
            this.cbo_tip_doc_ide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_tip_doc_ide.FormattingEnabled = true;
            this.cbo_tip_doc_ide.Location = new System.Drawing.Point(122, 48);
            this.cbo_tip_doc_ide.Name = "cbo_tip_doc_ide";
            this.cbo_tip_doc_ide.Size = new System.Drawing.Size(181, 21);
            this.cbo_tip_doc_ide.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 81);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(90, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "Razon Social :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 110);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 13);
            this.label11.TabIndex = 40;
            this.label11.Text = "Contacto :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(314, 110);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 50;
            this.label10.Text = "Nombres :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(508, 110);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 60;
            this.label9.Text = "Sexo :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 80;
            this.label7.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 90;
            this.label6.Text = "Telefonos :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 110;
            this.label5.Text = "Movil";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(309, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Nº Documento :";
            // 
            // frmClientes_ed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 504);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_guardar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClientes_ed";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Datos";
            this.Load += new System.EventHandler(this.frmClientes_ed_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_codigo_cl;
        private System.Windows.Forms.TextBox txt_num_doc_ide;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chk_estado;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_observaciones;
        private System.Windows.Forms.ComboBox cbo_distritos;
        private System.Windows.Forms.ComboBox cbo_provincias;
        private System.Windows.Forms.ComboBox cbo_departamentos;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_movil;
        private System.Windows.Forms.TextBox txt_telefonos;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.ComboBox cbo_sexo;
        private System.Windows.Forms.TextBox txt_nombres;
        private System.Windows.Forms.TextBox txt_apellidos;
        private System.Windows.Forms.TextBox txt_raz_soc;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbo_tip_doc_ide;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
    }
}