namespace hortalizas
{
    partial class inicio
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
            menu = new MenuStrip();
            menuusuario = new FontAwesome.Sharp.IconMenuItem();
            menumantenedor = new FontAwesome.Sharp.IconMenuItem();
            menuventas = new FontAwesome.Sharp.IconMenuItem();
            menucompras = new FontAwesome.Sharp.IconMenuItem();
            menureportes = new FontAwesome.Sharp.IconMenuItem();
            menuprovedores = new FontAwesome.Sharp.IconMenuItem();
            menuacercade = new FontAwesome.Sharp.IconMenuItem();
            menuclientes = new FontAwesome.Sharp.IconMenuItem();
            panel1 = new Panel();
            menu.SuspendLayout();
            SuspendLayout();
            // 
            // menu
            // 
            menu.AutoSize = false;
            menu.BackColor = Color.Green;
            menu.ImageScalingSize = new Size(20, 20);
            menu.Items.AddRange(new ToolStripItem[] { menuusuario, menumantenedor, menuventas, menucompras, menureportes, menuprovedores, menuclientes, menuacercade });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.RightToLeft = RightToLeft.No;
            menu.Size = new Size(1230, 86);
            menu.TabIndex = 0;
            menu.Text = "menuStrip1";
            // 
            // menuusuario
            // 
            menuusuario.AutoSize = false;
            menuusuario.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            menuusuario.IconColor = Color.Black;
            menuusuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuusuario.IconSize = 50;
            menuusuario.ImageScaling = ToolStripItemImageScaling.None;
            menuusuario.Name = "menuusuario";
            menuusuario.Size = new Size(152, 82);
            menuusuario.Text = "USUARIO";
            menuusuario.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menumantenedor
            // 
            menumantenedor.AutoSize = false;
            menumantenedor.IconChar = FontAwesome.Sharp.IconChar.Tools;
            menumantenedor.IconColor = Color.Black;
            menumantenedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menumantenedor.IconSize = 50;
            menumantenedor.ImageScaling = ToolStripItemImageScaling.None;
            menumantenedor.Name = "menumantenedor";
            menumantenedor.Size = new Size(152, 82);
            menumantenedor.Text = "MANTENEDOR";
            menumantenedor.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuventas
            // 
            menuventas.AutoSize = false;
            menuventas.IconChar = FontAwesome.Sharp.IconChar.Tags;
            menuventas.IconColor = Color.Black;
            menuventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuventas.IconSize = 50;
            menuventas.ImageScaling = ToolStripItemImageScaling.None;
            menuventas.Name = "menuventas";
            menuventas.Size = new Size(152, 82);
            menuventas.Text = "VENTAS";
            menuventas.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menucompras
            // 
            menucompras.AutoSize = false;
            menucompras.IconChar = FontAwesome.Sharp.IconChar.CartFlatbed;
            menucompras.IconColor = Color.Black;
            menucompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menucompras.IconSize = 50;
            menucompras.ImageScaling = ToolStripItemImageScaling.None;
            menucompras.Name = "menucompras";
            menucompras.Size = new Size(152, 82);
            menucompras.Text = "COMPRAS";
            menucompras.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menureportes
            // 
            menureportes.AutoSize = false;
            menureportes.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            menureportes.IconColor = Color.Black;
            menureportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menureportes.IconSize = 50;
            menureportes.ImageScaling = ToolStripItemImageScaling.None;
            menureportes.Name = "menureportes";
            menureportes.Size = new Size(152, 82);
            menureportes.Text = "REPORTES";
            menureportes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuprovedores
            // 
            menuprovedores.AutoSize = false;
            menuprovedores.IconChar = FontAwesome.Sharp.IconChar.Vcard;
            menuprovedores.IconColor = Color.Black;
            menuprovedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuprovedores.IconSize = 50;
            menuprovedores.ImageScaling = ToolStripItemImageScaling.None;
            menuprovedores.Name = "menuprovedores";
            menuprovedores.Size = new Size(152, 82);
            menuprovedores.Text = "PROVEDORES";
            menuprovedores.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuacercade
            // 
            menuacercade.AutoSize = false;
            menuacercade.IconChar = FontAwesome.Sharp.IconChar.CircleInfo;
            menuacercade.IconColor = Color.Black;
            menuacercade.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuacercade.IconSize = 50;
            menuacercade.ImageScaling = ToolStripItemImageScaling.None;
            menuacercade.Name = "menuacercade";
            menuacercade.Size = new Size(152, 82);
            menuacercade.Text = "ACERCA DE";
            menuacercade.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // menuclientes
            // 
            menuclientes.AutoSize = false;
            menuclientes.IconChar = FontAwesome.Sharp.IconChar.UserFriends;
            menuclientes.IconColor = Color.Black;
            menuclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            menuclientes.IconSize = 50;
            menuclientes.ImageScaling = ToolStripItemImageScaling.None;
            menuclientes.Name = "menuclientes";
            menuclientes.Size = new Size(152, 82);
            menuclientes.Text = "CLIENTES";
            menuclientes.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 86);
            panel1.Name = "panel1";
            panel1.Size = new Size(1230, 537);
            panel1.TabIndex = 1;
            // 
            // inicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1230, 623);
            Controls.Add(panel1);
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "inicio";
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            menu.ResumeLayout(false);
            menu.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menu;
        private FontAwesome.Sharp.IconMenuItem menuusuario;
        private FontAwesome.Sharp.IconMenuItem menumantenedor;
        private FontAwesome.Sharp.IconMenuItem menuventas;
        private FontAwesome.Sharp.IconMenuItem menucompras;
        private FontAwesome.Sharp.IconMenuItem menuprovedores;
        private FontAwesome.Sharp.IconMenuItem menuclientes;
        private FontAwesome.Sharp.IconMenuItem menureportes;
        private FontAwesome.Sharp.IconMenuItem menuacercade;
        private Panel panel1;
    }
}
