
namespace Proyecto.Presentacion
{
    partial class Inicio
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MatenimientosMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.matenimientoLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.BtnBuscarLibro = new System.Windows.Forms.Button();
            this.TxtBuscarLibro = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DgvProfesores = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.TxtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnPrestamo = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MatenimientosMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1352, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // MatenimientosMenu
            // 
            this.MatenimientosMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator5,
            this.matenimientoLibrosToolStripMenuItem});
            this.MatenimientosMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.MatenimientosMenu.Name = "MatenimientosMenu";
            this.MatenimientosMenu.Size = new System.Drawing.Size(130, 24);
            this.MatenimientosMenu.Text = "&Mantenimientos";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(129, 6);
            // 
            // matenimientoLibrosToolStripMenuItem
            // 
            this.matenimientoLibrosToolStripMenuItem.Name = "matenimientoLibrosToolStripMenuItem";
            this.matenimientoLibrosToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.matenimientoLibrosToolStripMenuItem.Text = "&Libros";
            this.matenimientoLibrosToolStripMenuItem.Click += new System.EventHandler(this.matenimientoLibrosToolStripMenuItem_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 712);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1352, 26);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(54, 20);
            this.toolStripStatusLabel.Text = "Estado";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.DgvLibros);
            this.panel1.Controls.Add(this.BtnBuscarLibro);
            this.panel1.Controls.Add(this.TxtBuscarLibro);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(781, 362);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Busqueda de Libro";
            // 
            // DgvLibros
            // 
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Location = new System.Drawing.Point(12, 74);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.RowHeadersWidth = 51;
            this.DgvLibros.RowTemplate.Height = 24;
            this.DgvLibros.Size = new System.Drawing.Size(754, 248);
            this.DgvLibros.TabIndex = 2;
            // 
            // BtnBuscarLibro
            // 
            this.BtnBuscarLibro.Location = new System.Drawing.Point(670, 46);
            this.BtnBuscarLibro.Name = "BtnBuscarLibro";
            this.BtnBuscarLibro.Size = new System.Drawing.Size(96, 23);
            this.BtnBuscarLibro.TabIndex = 1;
            this.BtnBuscarLibro.Text = "Buscar";
            this.BtnBuscarLibro.UseVisualStyleBackColor = true;
            this.BtnBuscarLibro.Click += new System.EventHandler(this.BtnBuscarLibro_Click);
            // 
            // TxtBuscarLibro
            // 
            this.TxtBuscarLibro.Location = new System.Drawing.Point(12, 45);
            this.TxtBuscarLibro.Name = "TxtBuscarLibro";
            this.TxtBuscarLibro.Size = new System.Drawing.Size(405, 22);
            this.TxtBuscarLibro.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DgvProfesores);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.TxtBuscarProfesor);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(787, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(565, 362);
            this.panel2.TabIndex = 5;
            // 
            // DgvProfesores
            // 
            this.DgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesores.Location = new System.Drawing.Point(25, 75);
            this.DgvProfesores.Name = "DgvProfesores";
            this.DgvProfesores.RowHeadersWidth = 51;
            this.DgvProfesores.RowTemplate.Height = 24;
            this.DgvProfesores.Size = new System.Drawing.Size(528, 247);
            this.DgvProfesores.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(457, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TxtBuscarProfesor
            // 
            this.TxtBuscarProfesor.Location = new System.Drawing.Point(25, 46);
            this.TxtBuscarProfesor.Name = "TxtBuscarProfesor";
            this.TxtBuscarProfesor.Size = new System.Drawing.Size(251, 22);
            this.TxtBuscarProfesor.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Busqueda de Profesor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.dateTimePicker);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.BtnPrestamo);
            this.panel3.Controls.Add(this.dataGridView2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 399);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1352, 310);
            this.panel3.TabIndex = 6;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(983, 89);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(357, 22);
            this.dateTimePicker.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(980, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha limite devolucion";
            // 
            // BtnPrestamo
            // 
            this.BtnPrestamo.Location = new System.Drawing.Point(983, 244);
            this.BtnPrestamo.Name = "BtnPrestamo";
            this.BtnPrestamo.Size = new System.Drawing.Size(357, 63);
            this.BtnPrestamo.TabIndex = 4;
            this.BtnPrestamo.Text = "Agregar Prestamo";
            this.BtnPrestamo.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(15, 59);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(944, 248);
            this.dataGridView2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prestamos activos del profesor";
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1352, 738);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Inicio";
            this.Text = "Matenimiento Biblioteca";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolStripMenuItem MatenimientosMenu;
        private System.Windows.Forms.ToolStripMenuItem matenimientoLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox TxtBuscarLibro;
        private System.Windows.Forms.Button BtnBuscarLibro;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscarProfesor;
        private System.Windows.Forms.DataGridView DgvProfesores;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button BtnPrestamo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}



