namespace hortalizas
{
    partial class login
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
            txtdocumento = new TextBox();
            txtcontraseña = new TextBox();
            label3 = new Label();
            label4 = new Label();
            ingresar = new FontAwesome.Sharp.IconButton();
            iconButton2 = new FontAwesome.Sharp.IconButton();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // txtdocumento
            // 
            txtdocumento.Location = new Point(253, 62);
            txtdocumento.Name = "txtdocumento";
            txtdocumento.Size = new Size(214, 27);
            txtdocumento.TabIndex = 3;
            txtdocumento.TextChanged += txtdocumento_TextChanged;
            // 
            // txtcontraseña
            // 
            txtcontraseña.Location = new Point(251, 125);
            txtcontraseña.Name = "txtcontraseña";
            txtcontraseña.PasswordChar = '*';
            txtcontraseña.Size = new Size(214, 27);
            txtcontraseña.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(253, 26);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 5;
            label3.Text = "Nro Documento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(251, 92);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 6;
            label4.Text = "Contraseña";
            // 
            // ingresar
            // 
            ingresar.BackColor = Color.ForestGreen;
            ingresar.Cursor = Cursors.Hand;
            ingresar.FlatStyle = FlatStyle.Flat;
            ingresar.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            ingresar.IconColor = Color.Black;
            ingresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            ingresar.IconSize = 20;
            ingresar.Location = new Point(401, 185);
            ingresar.Name = "ingresar";
            ingresar.Size = new Size(94, 29);
            ingresar.TabIndex = 7;
            ingresar.Text = "ingresar";
            ingresar.TextAlign = ContentAlignment.BottomCenter;
            ingresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            ingresar.UseVisualStyleBackColor = false;
            ingresar.Click += iconButton1_Click;
            // 
            // iconButton2
            // 
            iconButton2.BackColor = Color.Red;
            iconButton2.FlatStyle = FlatStyle.Flat;
            iconButton2.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            iconButton2.IconColor = Color.Black;
            iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton2.IconSize = 20;
            iconButton2.Location = new Point(253, 185);
            iconButton2.Name = "iconButton2";
            iconButton2.Size = new Size(103, 29);
            iconButton2.TabIndex = 8;
            iconButton2.Text = "Cancelar";
            iconButton2.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton2.UseVisualStyleBackColor = false;
            iconButton2.Click += iconButton2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.fon;
            pictureBox1.Location = new Point(-9, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 241);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.SeaGreen;
            label1.Location = new Point(41, 194);
            label1.Name = "label1";
            label1.Size = new Size(148, 20);
            label1.TabIndex = 10;
            label1.Text = "SISTEMA DE VENTAS";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Green;
            pictureBox2.Image = Properties.Resources.Padlock_User_Control_23100;
            pictureBox2.Location = new Point(55, 37);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(125, 124);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(556, 239);
            Controls.Add(pictureBox2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Controls.Add(iconButton2);
            Controls.Add(ingresar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtcontraseña);
            Controls.Add(txtdocumento);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtdocumento;
        private TextBox txtcontraseña;
        private Label label3;
        private Label label4;
        private FontAwesome.Sharp.IconButton ingresar;
        private FontAwesome.Sharp.IconButton iconButton2;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
    }
}