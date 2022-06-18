namespace FirstApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lvLista = new System.Windows.Forms.ListView();
            this.Cedula = new System.Windows.Forms.ColumnHeader();
            this.Apellido = new System.Windows.Forms.ColumnHeader();
            this.Nombre = new System.Windows.Forms.ColumnHeader();
            this.Carrera = new System.Windows.Forms.ColumnHeader();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbCarrera = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(27, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(134, 170);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(172, 31);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // btnAgregar
            // 
            this.btnAgregar.AutoSize = true;
            this.btnAgregar.BackColor = System.Drawing.SystemColors.InfoText;
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgregar.Location = new System.Drawing.Point(36, 302);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(270, 49);
            this.btnAgregar.TabIndex = 6;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(134, 78);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(172, 31);
            this.txtCedula.TabIndex = 12;
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(39, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Cedula";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(134, 123);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(172, 31);
            this.txtApellido.TabIndex = 14;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(27, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "Apellido";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(37, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Carrera";
            // 
            // lvLista
            // 
            this.lvLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Cedula,
            this.Apellido,
            this.Nombre,
            this.Carrera});
            this.lvLista.Location = new System.Drawing.Point(366, 21);
            this.lvLista.Name = "lvLista";
            this.lvLista.Size = new System.Drawing.Size(605, 313);
            this.lvLista.TabIndex = 17;
            this.lvLista.UseCompatibleStateImageBehavior = false;
            this.lvLista.View = System.Windows.Forms.View.Details;
            this.lvLista.DoubleClick += new System.EventHandler(this.lvLista_DoubleClick);
            // 
            // Cedula
            // 
            this.Cedula.Text = "Cedula";
            this.Cedula.Width = 100;
            // 
            // Apellido
            // 
            this.Apellido.Text = "Apellido";
            this.Apellido.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.Text = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Carrera
            // 
            this.Carrera.Text = "Carrera";
            this.Carrera.Width = 100;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(362, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 18;
            this.button2.Text = "Eliminar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // button3
            // 
            this.button3.AutoSize = true;
            this.button3.Location = new System.Drawing.Point(498, 382);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(224, 35);
            this.button3.TabIndex = 19;
            this.button3.Text = "Ver elementos agregados";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.btnVerAgregados_Click);
            // 
            // button4
            // 
            this.button4.AutoSize = true;
            this.button4.Location = new System.Drawing.Point(742, 382);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(225, 35);
            this.button4.TabIndex = 20;
            this.button4.Text = "Ver elementos eliminados";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.btnVerEliminar_Click);
            // 
            // cmbCarrera
            // 
            this.cmbCarrera.FormattingEnabled = true;
            this.cmbCarrera.Items.AddRange(new object[] {
            "Software",
            "Sistemas",
            "Civil",
            "Veterinaria"});
            this.cmbCarrera.Location = new System.Drawing.Point(134, 220);
            this.cmbCarrera.Name = "cmbCarrera";
            this.cmbCarrera.Size = new System.Drawing.Size(172, 33);
            this.cmbCarrera.TabIndex = 21;
            this.cmbCarrera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbCarrera_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1000, 445);
            this.Controls.Add(this.cmbCarrera);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lvLista);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "José Sánchez List";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private Button btnAgregar;
        private TextBox txtCedula;
        private Label label4;
        private TextBox txtApellido;
        private Label label5;
        private Label label6;
        private ListView lvLista;
        private ColumnHeader Cedula;
        private ColumnHeader Apellido;
        private ColumnHeader Nombre;
        private ColumnHeader Carrera;
        private Button button2;
        private Button button3;
        private Button button4;
        private ComboBox cmbCarrera;
    }
}