namespace PRYAguirreSantiagoPresentacionIG
{
    partial class frmCaso1
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
            Nombre = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtNombre = new TextBox();
            txtEdad = new TextBox();
            txtApellido = new TextBox();
            txtCarrera = new TextBox();
            button1 = new Button();
            lblMensaje = new Label();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(105, 79);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 109);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Apellido";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(111, 139);
            label2.Name = "label2";
            label2.Size = new Size(33, 15);
            label2.TabIndex = 2;
            label2.Text = "Edad";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(111, 168);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 3;
            label3.Text = "Carrera";
            label3.Click += label3_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(183, 71);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(81, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtEdad
            // 
            txtEdad.Location = new Point(183, 136);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(81, 23);
            txtEdad.TabIndex = 5;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(183, 106);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(81, 23);
            txtApellido.TabIndex = 6;
            // 
            // txtCarrera
            // 
            txtCarrera.Location = new Point(183, 165);
            txtCarrera.Name = "txtCarrera";
            txtCarrera.Size = new Size(81, 23);
            txtCarrera.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(94, 207);
            button1.Name = "button1";
            button1.Size = new Size(207, 25);
            button1.TabIndex = 8;
            button1.Text = "Presentacion";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // lblMensaje
            // 
            lblMensaje.AutoSize = true;
            lblMensaje.Location = new Point(100, 247);
            lblMensaje.Name = "lblMensaje";
            lblMensaje.Size = new Size(0, 15);
            lblMensaje.TabIndex = 9;
            lblMensaje.Click += label4_Click;
            // 
            // frmCaso1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(424, 321);
            Controls.Add(lblMensaje);
            Controls.Add(button1);
            Controls.Add(txtCarrera);
            Controls.Add(txtApellido);
            Controls.Add(txtEdad);
            Controls.Add(txtNombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Nombre);
            Name = "frmCaso1";
            Text = " Mi Presentacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtNombre;
        private TextBox txtEdad;
        private TextBox txtApellido;
        private TextBox txtCarrera;
        private Button button1;
        private Label lblMensaje;
    }
}