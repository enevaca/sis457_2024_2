namespace CpMinerva
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.c1Ribbon1 = new C1.Win.Ribbon.C1Ribbon();
            this.ribbonApplicationMenu1 = new C1.Win.Ribbon.RibbonApplicationMenu();
            this.ribbonBottomToolBar1 = new C1.Win.Ribbon.RibbonBottomToolBar();
            this.ribbonConfigToolBar1 = new C1.Win.Ribbon.RibbonConfigToolBar();
            this.ribbonQat1 = new C1.Win.Ribbon.RibbonQat();
            this.ribbonTab1 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup1 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCaProductos = new C1.Win.Ribbon.RibbonButton();
            this.btnCaProveedores = new C1.Win.Ribbon.RibbonButton();
            this.btnCaClientes = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab2 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup2 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCjCompras = new C1.Win.Ribbon.RibbonButton();
            this.btnCjVentas = new C1.Win.Ribbon.RibbonButton();
            this.ribbonGroup6 = new C1.Win.Ribbon.RibbonGroup();
            this.btnCjArqueoDiario = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab3 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup3 = new C1.Win.Ribbon.RibbonGroup();
            this.ribbonTab4 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup4 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAdEmpleados = new C1.Win.Ribbon.RibbonButton();
            this.btnAdRoles = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTab5 = new C1.Win.Ribbon.RibbonTab();
            this.ribbonGroup5 = new C1.Win.Ribbon.RibbonGroup();
            this.btnAyManualUsuario = new C1.Win.Ribbon.RibbonButton();
            this.btnAyAcercaDe = new C1.Win.Ribbon.RibbonButton();
            this.ribbonTopToolBar1 = new C1.Win.Ribbon.RibbonTopToolBar();
            this.pctPrincipal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // c1Ribbon1
            // 
            this.c1Ribbon1.ApplicationMenuHolder = this.ribbonApplicationMenu1;
            this.c1Ribbon1.BottomToolBarHolder = this.ribbonBottomToolBar1;
            this.c1Ribbon1.ConfigToolBarHolder = this.ribbonConfigToolBar1;
            this.c1Ribbon1.Location = new System.Drawing.Point(0, 0);
            this.c1Ribbon1.Name = "c1Ribbon1";
            this.c1Ribbon1.QatHolder = this.ribbonQat1;
            this.c1Ribbon1.Size = new System.Drawing.Size(673, 161);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab1);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab2);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab3);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab4);
            this.c1Ribbon1.Tabs.Add(this.ribbonTab5);
            this.c1Ribbon1.TopToolBarHolder = this.ribbonTopToolBar1;
            // 
            // ribbonApplicationMenu1
            // 
            this.ribbonApplicationMenu1.Name = "ribbonApplicationMenu1";
            // 
            // ribbonBottomToolBar1
            // 
            this.ribbonBottomToolBar1.Name = "ribbonBottomToolBar1";
            // 
            // ribbonConfigToolBar1
            // 
            this.ribbonConfigToolBar1.Name = "ribbonConfigToolBar1";
            // 
            // ribbonQat1
            // 
            this.ribbonQat1.Name = "ribbonQat1";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Groups.Add(this.ribbonGroup1);
            this.ribbonTab1.Name = "ribbonTab1";
            this.ribbonTab1.Text = "Catálogo";
            // 
            // ribbonGroup1
            // 
            this.ribbonGroup1.Items.Add(this.btnCaProductos);
            this.ribbonGroup1.Items.Add(this.btnCaProveedores);
            this.ribbonGroup1.Items.Add(this.btnCaClientes);
            this.ribbonGroup1.Name = "ribbonGroup1";
            this.ribbonGroup1.Text = "Administración de Catálogos";
            // 
            // btnCaProductos
            // 
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProductos.IconSet.Add(new C1.Framework.C1BitmapIcon("ReportDesign", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 236));
            this.btnCaProductos.Name = "btnCaProductos";
            this.btnCaProductos.Text = "Productos";
            this.btnCaProductos.Click += new System.EventHandler(this.btnCaProductos_Click);
            // 
            // btnCaProveedores
            // 
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaProveedores.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaProveedores.IconSet")))));
            this.btnCaProveedores.Name = "btnCaProveedores";
            this.btnCaProveedores.Text = "Proveedores";
            // 
            // btnCaClientes
            // 
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCaClientes.IconSet.Add(new C1.Framework.C1BitmapIcon(null, new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, ((System.Drawing.Image)(resources.GetObject("btnCaClientes.IconSet")))));
            this.btnCaClientes.Name = "btnCaClientes";
            this.btnCaClientes.Text = "Clientes";
            // 
            // ribbonTab2
            // 
            this.ribbonTab2.Groups.Add(this.ribbonGroup2);
            this.ribbonTab2.Groups.Add(this.ribbonGroup6);
            this.ribbonTab2.Name = "ribbonTab2";
            this.ribbonTab2.Text = "Caja";
            // 
            // ribbonGroup2
            // 
            this.ribbonGroup2.Items.Add(this.btnCjCompras);
            this.ribbonGroup2.Items.Add(this.btnCjVentas);
            this.ribbonGroup2.Name = "ribbonGroup2";
            this.ribbonGroup2.Text = "Gestión";
            // 
            // btnCjCompras
            // 
            this.btnCjCompras.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCjCompras.IconSet.Add(new C1.Framework.C1BitmapIcon("InsertCells", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 145));
            this.btnCjCompras.Name = "btnCjCompras";
            this.btnCjCompras.Text = "Compras";
            // 
            // btnCjVentas
            // 
            this.btnCjVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCjVentas.IconSet.Add(new C1.Framework.C1BitmapIcon("TrackChanges", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 323));
            this.btnCjVentas.Name = "btnCjVentas";
            this.btnCjVentas.Text = "Ventas";
            // 
            // ribbonGroup6
            // 
            this.ribbonGroup6.Items.Add(this.btnCjArqueoDiario);
            this.ribbonGroup6.Name = "ribbonGroup6";
            this.ribbonGroup6.Text = "Arqueo de Caja";
            // 
            // btnCjArqueoDiario
            // 
            this.btnCjArqueoDiario.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnCjArqueoDiario.IconSet.Add(new C1.Framework.C1BitmapIcon("TableProperties", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 312));
            this.btnCjArqueoDiario.Name = "btnCjArqueoDiario";
            this.btnCjArqueoDiario.Text = "Arqueo Diario";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Groups.Add(this.ribbonGroup3);
            this.ribbonTab3.Name = "ribbonTab3";
            this.ribbonTab3.Text = "Reportes";
            // 
            // ribbonGroup3
            // 
            this.ribbonGroup3.Name = "ribbonGroup3";
            this.ribbonGroup3.Text = "Group";
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Groups.Add(this.ribbonGroup4);
            this.ribbonTab4.Name = "ribbonTab4";
            this.ribbonTab4.Text = "Administración";
            // 
            // ribbonGroup4
            // 
            this.ribbonGroup4.Items.Add(this.btnAdEmpleados);
            this.ribbonGroup4.Items.Add(this.btnAdRoles);
            this.ribbonGroup4.Name = "ribbonGroup4";
            this.ribbonGroup4.Text = "Gestión de la Configuración";
            // 
            // btnAdEmpleados
            // 
            this.btnAdEmpleados.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdEmpleados.IconSet.Add(new C1.Framework.C1BitmapIcon("AddressBook", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 3));
            this.btnAdEmpleados.Name = "btnAdEmpleados";
            this.btnAdEmpleados.Text = "Empleados";
            this.btnAdEmpleados.Click += new System.EventHandler(this.btnAdEmpleados_Click);
            // 
            // btnAdRoles
            // 
            this.btnAdRoles.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAdRoles.IconSet.Add(new C1.Framework.C1BitmapIcon("Tools", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 321));
            this.btnAdRoles.Name = "btnAdRoles";
            this.btnAdRoles.Text = "Roles";
            // 
            // ribbonTab5
            // 
            this.ribbonTab5.Groups.Add(this.ribbonGroup5);
            this.ribbonTab5.Name = "ribbonTab5";
            this.ribbonTab5.Text = "Ayuda";
            // 
            // ribbonGroup5
            // 
            this.ribbonGroup5.Items.Add(this.btnAyManualUsuario);
            this.ribbonGroup5.Items.Add(this.btnAyAcercaDe);
            this.ribbonGroup5.Name = "ribbonGroup5";
            this.ribbonGroup5.Text = "Ayuda";
            // 
            // btnAyManualUsuario
            // 
            this.btnAyManualUsuario.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAyManualUsuario.IconSet.Add(new C1.Framework.C1BitmapIcon("Book", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 16));
            this.btnAyManualUsuario.Name = "btnAyManualUsuario";
            this.btnAyManualUsuario.Text = "Manual de Usuario";
            // 
            // btnAyAcercaDe
            // 
            this.btnAyAcercaDe.IconSet.Add(new C1.Framework.C1BitmapIcon("DefaultImage", new System.Drawing.Size(16, 16), System.Drawing.Color.Transparent, "DefaultImage", -1));
            this.btnAyAcercaDe.IconSet.Add(new C1.Framework.C1BitmapIcon("Info1", new System.Drawing.Size(32, 32), System.Drawing.Color.Transparent, "Preset_LargeImages", 140));
            this.btnAyAcercaDe.Name = "btnAyAcercaDe";
            this.btnAyAcercaDe.Text = "Acerca De...";
            // 
            // ribbonTopToolBar1
            // 
            this.ribbonTopToolBar1.Name = "ribbonTopToolBar1";
            // 
            // pctPrincipal
            // 
            this.pctPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pctPrincipal.Image = global::CpMinerva.Properties.Resources.principal;
            this.pctPrincipal.Location = new System.Drawing.Point(0, 161);
            this.pctPrincipal.Name = "pctPrincipal";
            this.pctPrincipal.Size = new System.Drawing.Size(673, 216);
            this.pctPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctPrincipal.TabIndex = 1;
            this.pctPrincipal.TabStop = false;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(673, 377);
            this.Controls.Add(this.pctPrincipal);
            this.Controls.Add(this.c1Ribbon1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "::: Minerva - Principal :::";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.c1Ribbon1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private C1.Win.Ribbon.C1Ribbon c1Ribbon1;
        private C1.Win.Ribbon.RibbonApplicationMenu ribbonApplicationMenu1;
        private C1.Win.Ribbon.RibbonBottomToolBar ribbonBottomToolBar1;
        private C1.Win.Ribbon.RibbonConfigToolBar ribbonConfigToolBar1;
        private C1.Win.Ribbon.RibbonQat ribbonQat1;
        private C1.Win.Ribbon.RibbonTab ribbonTab1;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup1;
        private C1.Win.Ribbon.RibbonTopToolBar ribbonTopToolBar1;
        private C1.Win.Ribbon.RibbonButton btnCaProductos;
        private C1.Win.Ribbon.RibbonButton btnCaProveedores;
        private C1.Win.Ribbon.RibbonButton btnCaClientes;
        private C1.Win.Ribbon.RibbonTab ribbonTab2;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup2;
        private C1.Win.Ribbon.RibbonTab ribbonTab3;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup3;
        private C1.Win.Ribbon.RibbonTab ribbonTab4;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup4;
        private C1.Win.Ribbon.RibbonTab ribbonTab5;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup5;
        private C1.Win.Ribbon.RibbonButton btnCjCompras;
        private C1.Win.Ribbon.RibbonButton btnCjVentas;
        private C1.Win.Ribbon.RibbonGroup ribbonGroup6;
        private C1.Win.Ribbon.RibbonButton btnCjArqueoDiario;
        private C1.Win.Ribbon.RibbonButton btnAdEmpleados;
        private C1.Win.Ribbon.RibbonButton btnAdRoles;
        private C1.Win.Ribbon.RibbonButton btnAyManualUsuario;
        private C1.Win.Ribbon.RibbonButton btnAyAcercaDe;
        private System.Windows.Forms.PictureBox pctPrincipal;
    }
}