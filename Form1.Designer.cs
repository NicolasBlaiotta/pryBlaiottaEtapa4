namespace pryBlaiottaEtapa4
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
            lstVehiculo = new ListBox();
            btnCrearVehiculo = new Button();
            btnListar = new Button();
            pctVehiculo = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            lblNombreVehiculo = new Label();
            lblTipoVehiculo = new Label();
            ((System.ComponentModel.ISupportInitialize)pctVehiculo).BeginInit();
            SuspendLayout();
            // 
            // lstVehiculo
            // 
            lstVehiculo.FormattingEnabled = true;
            lstVehiculo.ItemHeight = 15;
            lstVehiculo.Location = new Point(332, 38);
            lstVehiculo.Name = "lstVehiculo";
            lstVehiculo.Size = new Size(190, 184);
            lstVehiculo.TabIndex = 0;
            // 
            // btnCrearVehiculo
            // 
            btnCrearVehiculo.Location = new Point(31, 363);
            btnCrearVehiculo.Name = "btnCrearVehiculo";
            btnCrearVehiculo.Size = new Size(105, 23);
            btnCrearVehiculo.TabIndex = 1;
            btnCrearVehiculo.Text = "Crear Vehiculo";
            btnCrearVehiculo.UseVisualStyleBackColor = true;
            btnCrearVehiculo.Click += btnCrearVehiculo_Click;
            // 
            // btnListar
            // 
            btnListar.Location = new Point(332, 250);
            btnListar.Name = "btnListar";
            btnListar.Size = new Size(75, 23);
            btnListar.TabIndex = 2;
            btnListar.Text = "Listar";
            btnListar.UseVisualStyleBackColor = true;
            btnListar.Click += btnListar_Click;
            // 
            // pctVehiculo
            // 
            pctVehiculo.Location = new Point(31, 35);
            pctVehiculo.Name = "pctVehiculo";
            pctVehiculo.Size = new Size(275, 193);
            pctVehiculo.TabIndex = 3;
            pctVehiculo.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 271);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 4;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 317);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 5;
            label2.Text = "Tipo";
            // 
            // lblNombreVehiculo
            // 
            lblNombreVehiculo.BorderStyle = BorderStyle.Fixed3D;
            lblNombreVehiculo.Location = new Point(146, 271);
            lblNombreVehiculo.Name = "lblNombreVehiculo";
            lblNombreVehiculo.Size = new Size(118, 25);
            lblNombreVehiculo.TabIndex = 6;
            // 
            // lblTipoVehiculo
            // 
            lblTipoVehiculo.BorderStyle = BorderStyle.Fixed3D;
            lblTipoVehiculo.Location = new Point(146, 317);
            lblTipoVehiculo.Name = "lblTipoVehiculo";
            lblTipoVehiculo.Size = new Size(118, 25);
            lblTipoVehiculo.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(549, 401);
            Controls.Add(lblTipoVehiculo);
            Controls.Add(lblNombreVehiculo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pctVehiculo);
            Controls.Add(btnListar);
            Controls.Add(btnCrearVehiculo);
            Controls.Add(lstVehiculo);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pctVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lstVehiculo;
        private Button btnCrearVehiculo;
        private Button btnListar;
        private PictureBox pctVehiculo;
        private Label label1;
        private Label label2;
        private Label lblNombreVehiculo;
        private Label lblTipoVehiculo;
    }
}