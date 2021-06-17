
namespace Proyecto.Presentacion
{
    partial class FrmMantenimientoLibros
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
            this.TabGeneral = new System.Windows.Forms.TabControl();
            this.tabPageListado = new System.Windows.Forms.TabPage();
            this.TxtBuscar = new System.Windows.Forms.TextBox();
            this.BtnBuscar = new System.Windows.Forms.Button();
            this.DgvLibros = new System.Windows.Forms.DataGridView();
            this.Seleccionar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabPageMantenimiento = new System.Windows.Forms.TabPage();
            this.TxtTitulo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNumEjemplares = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtIsbn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtAutor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEditorial = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtId = new System.Windows.Forms.TextBox();
            this.BtnInsertar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.TxtAnioEdicion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtUbicacion = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtNumPaginas = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtMateria = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtIdioma = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtPais = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtNumEdicion = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtDescripcion = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.TabGeneral.SuspendLayout();
            this.tabPageListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).BeginInit();
            this.tabPageMantenimiento.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabGeneral
            // 
            this.TabGeneral.Controls.Add(this.tabPageListado);
            this.TabGeneral.Controls.Add(this.tabPageMantenimiento);
            this.TabGeneral.Location = new System.Drawing.Point(12, 12);
            this.TabGeneral.Name = "TabGeneral";
            this.TabGeneral.SelectedIndex = 0;
            this.TabGeneral.Size = new System.Drawing.Size(825, 548);
            this.TabGeneral.TabIndex = 0;
            // 
            // tabPageListado
            // 
            this.tabPageListado.Controls.Add(this.TxtBuscar);
            this.tabPageListado.Controls.Add(this.BtnBuscar);
            this.tabPageListado.Controls.Add(this.DgvLibros);
            this.tabPageListado.Location = new System.Drawing.Point(4, 25);
            this.tabPageListado.Name = "tabPageListado";
            this.tabPageListado.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageListado.Size = new System.Drawing.Size(817, 519);
            this.tabPageListado.TabIndex = 0;
            this.tabPageListado.Text = "Listado";
            this.tabPageListado.UseVisualStyleBackColor = true;
            // 
            // TxtBuscar
            // 
            this.TxtBuscar.Location = new System.Drawing.Point(6, 31);
            this.TxtBuscar.Name = "TxtBuscar";
            this.TxtBuscar.Size = new System.Drawing.Size(429, 22);
            this.TxtBuscar.TabIndex = 2;
            // 
            // BtnBuscar
            // 
            this.BtnBuscar.Location = new System.Drawing.Point(507, 31);
            this.BtnBuscar.Name = "BtnBuscar";
            this.BtnBuscar.Size = new System.Drawing.Size(137, 23);
            this.BtnBuscar.TabIndex = 1;
            this.BtnBuscar.Text = "Buscar";
            this.BtnBuscar.UseVisualStyleBackColor = true;
            this.BtnBuscar.Click += new System.EventHandler(this.BtnBuscar_Click);
            // 
            // DgvLibros
            // 
            this.DgvLibros.AllowUserToAddRows = false;
            this.DgvLibros.AllowUserToDeleteRows = false;
            this.DgvLibros.AllowUserToOrderColumns = true;
            this.DgvLibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvLibros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Seleccionar});
            this.DgvLibros.Location = new System.Drawing.Point(6, 89);
            this.DgvLibros.Name = "DgvLibros";
            this.DgvLibros.ReadOnly = true;
            this.DgvLibros.RowHeadersWidth = 51;
            this.DgvLibros.RowTemplate.Height = 24;
            this.DgvLibros.Size = new System.Drawing.Size(805, 367);
            this.DgvLibros.TabIndex = 0;
            // 
            // Seleccionar
            // 
            this.Seleccionar.HeaderText = "Seleccionar";
            this.Seleccionar.MinimumWidth = 6;
            this.Seleccionar.Name = "Seleccionar";
            this.Seleccionar.ReadOnly = true;
            this.Seleccionar.Width = 125;
            // 
            // tabPageMantenimiento
            // 
            this.tabPageMantenimiento.Controls.Add(this.TxtDescripcion);
            this.tabPageMantenimiento.Controls.Add(this.label14);
            this.tabPageMantenimiento.Controls.Add(this.TxtUbicacion);
            this.tabPageMantenimiento.Controls.Add(this.label13);
            this.tabPageMantenimiento.Controls.Add(this.TxtNumPaginas);
            this.tabPageMantenimiento.Controls.Add(this.label12);
            this.tabPageMantenimiento.Controls.Add(this.TxtMateria);
            this.tabPageMantenimiento.Controls.Add(this.label11);
            this.tabPageMantenimiento.Controls.Add(this.TxtIdioma);
            this.tabPageMantenimiento.Controls.Add(this.label10);
            this.tabPageMantenimiento.Controls.Add(this.TxtPais);
            this.tabPageMantenimiento.Controls.Add(this.label9);
            this.tabPageMantenimiento.Controls.Add(this.TxtNumEdicion);
            this.tabPageMantenimiento.Controls.Add(this.label8);
            this.tabPageMantenimiento.Controls.Add(this.TxtAnioEdicion);
            this.tabPageMantenimiento.Controls.Add(this.label7);
            this.tabPageMantenimiento.Controls.Add(this.BtnActualizar);
            this.tabPageMantenimiento.Controls.Add(this.BtnCancelar);
            this.tabPageMantenimiento.Controls.Add(this.BtnInsertar);
            this.tabPageMantenimiento.Controls.Add(this.TxtId);
            this.tabPageMantenimiento.Controls.Add(this.TxtCodigo);
            this.tabPageMantenimiento.Controls.Add(this.label16);
            this.tabPageMantenimiento.Controls.Add(this.TxtEditorial);
            this.tabPageMantenimiento.Controls.Add(this.label6);
            this.tabPageMantenimiento.Controls.Add(this.TxtAutor);
            this.tabPageMantenimiento.Controls.Add(this.label5);
            this.tabPageMantenimiento.Controls.Add(this.TxtIsbn);
            this.tabPageMantenimiento.Controls.Add(this.label4);
            this.tabPageMantenimiento.Controls.Add(this.TxtNumEjemplares);
            this.tabPageMantenimiento.Controls.Add(this.label3);
            this.tabPageMantenimiento.Controls.Add(this.label1);
            this.tabPageMantenimiento.Controls.Add(this.TxtTitulo);
            this.tabPageMantenimiento.Location = new System.Drawing.Point(4, 25);
            this.tabPageMantenimiento.Name = "tabPageMantenimiento";
            this.tabPageMantenimiento.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageMantenimiento.Size = new System.Drawing.Size(817, 519);
            this.tabPageMantenimiento.TabIndex = 1;
            this.tabPageMantenimiento.Text = "Matenimiento";
            this.tabPageMantenimiento.UseVisualStyleBackColor = true;
            // 
            // TxtTitulo
            // 
            this.TxtTitulo.Location = new System.Drawing.Point(17, 129);
            this.TxtTitulo.Name = "TxtTitulo";
            this.TxtTitulo.Size = new System.Drawing.Size(162, 22);
            this.TxtTitulo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Titulo";
            // 
            // TxtNumEjemplares
            // 
            this.TxtNumEjemplares.Location = new System.Drawing.Point(17, 190);
            this.TxtNumEjemplares.Name = "TxtNumEjemplares";
            this.TxtNumEjemplares.Size = new System.Drawing.Size(162, 22);
            this.TxtNumEjemplares.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Numero Ejemplares";
            // 
            // TxtIsbn
            // 
            this.TxtIsbn.Location = new System.Drawing.Point(17, 257);
            this.TxtIsbn.Name = "TxtIsbn";
            this.TxtIsbn.Size = new System.Drawing.Size(162, 22);
            this.TxtIsbn.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "ISBN";
            // 
            // TxtAutor
            // 
            this.TxtAutor.Location = new System.Drawing.Point(17, 326);
            this.TxtAutor.Name = "TxtAutor";
            this.TxtAutor.Size = new System.Drawing.Size(162, 22);
            this.TxtAutor.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Autor";
            // 
            // TxtEditorial
            // 
            this.TxtEditorial.Location = new System.Drawing.Point(17, 398);
            this.TxtEditorial.Name = "TxtEditorial";
            this.TxtEditorial.Size = new System.Drawing.Size(162, 22);
            this.TxtEditorial.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Editorial";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(17, 69);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(162, 22);
            this.TxtCodigo.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(17, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(52, 17);
            this.label16.TabIndex = 30;
            this.label16.Text = "Codigo";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(17, 15);
            this.TxtId.Name = "TxtId";
            this.TxtId.Size = new System.Drawing.Size(162, 22);
            this.TxtId.TabIndex = 32;
            // 
            // BtnInsertar
            // 
            this.BtnInsertar.Location = new System.Drawing.Point(561, 68);
            this.BtnInsertar.Name = "BtnInsertar";
            this.BtnInsertar.Size = new System.Drawing.Size(162, 23);
            this.BtnInsertar.TabIndex = 33;
            this.BtnInsertar.Text = "Insertar";
            this.BtnInsertar.UseVisualStyleBackColor = true;
            this.BtnInsertar.Click += new System.EventHandler(this.BtnInsertar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(561, 128);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(162, 23);
            this.BtnCancelar.TabIndex = 34;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(561, 194);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(162, 23);
            this.BtnActualizar.TabIndex = 35;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            // 
            // TxtAnioEdicion
            // 
            this.TxtAnioEdicion.Location = new System.Drawing.Point(20, 463);
            this.TxtAnioEdicion.Name = "TxtAnioEdicion";
            this.TxtAnioEdicion.Size = new System.Drawing.Size(162, 22);
            this.TxtAnioEdicion.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 443);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Año de Edicion";
            // 
            // TxtUbicacion
            // 
            this.TxtUbicacion.Location = new System.Drawing.Point(288, 403);
            this.TxtUbicacion.Name = "TxtUbicacion";
            this.TxtUbicacion.Size = new System.Drawing.Size(162, 22);
            this.TxtUbicacion.TabIndex = 49;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(288, 383);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(70, 17);
            this.label13.TabIndex = 48;
            this.label13.Text = "Ubicacion";
            // 
            // TxtNumPaginas
            // 
            this.TxtNumPaginas.Location = new System.Drawing.Point(288, 331);
            this.TxtNumPaginas.Name = "TxtNumPaginas";
            this.TxtNumPaginas.Size = new System.Drawing.Size(162, 22);
            this.TxtNumPaginas.TabIndex = 47;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 311);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(133, 17);
            this.label12.TabIndex = 46;
            this.label12.Text = "Numero de Páginas";
            // 
            // TxtMateria
            // 
            this.TxtMateria.Location = new System.Drawing.Point(288, 262);
            this.TxtMateria.Name = "TxtMateria";
            this.TxtMateria.Size = new System.Drawing.Size(162, 22);
            this.TxtMateria.TabIndex = 45;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 17);
            this.label11.TabIndex = 44;
            this.label11.Text = "Materia";
            // 
            // TxtIdioma
            // 
            this.TxtIdioma.Location = new System.Drawing.Point(288, 195);
            this.TxtIdioma.Name = "TxtIdioma";
            this.TxtIdioma.Size = new System.Drawing.Size(162, 22);
            this.TxtIdioma.TabIndex = 43;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 17);
            this.label10.TabIndex = 42;
            this.label10.Text = "Idioma";
            // 
            // TxtPais
            // 
            this.TxtPais.Location = new System.Drawing.Point(288, 129);
            this.TxtPais.Name = "TxtPais";
            this.TxtPais.Size = new System.Drawing.Size(162, 22);
            this.TxtPais.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(288, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 17);
            this.label9.TabIndex = 40;
            this.label9.Text = "País";
            // 
            // TxtNumEdicion
            // 
            this.TxtNumEdicion.Location = new System.Drawing.Point(288, 69);
            this.TxtNumEdicion.Name = "TxtNumEdicion";
            this.TxtNumEdicion.Size = new System.Drawing.Size(162, 22);
            this.TxtNumEdicion.TabIndex = 39;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Numero de edicion";
            // 
            // TxtDescripcion
            // 
            this.TxtDescripcion.Location = new System.Drawing.Point(288, 463);
            this.TxtDescripcion.Name = "TxtDescripcion";
            this.TxtDescripcion.Size = new System.Drawing.Size(162, 22);
            this.TxtDescripcion.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(288, 443);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(82, 17);
            this.label14.TabIndex = 50;
            this.label14.Text = "Descripcion";
            // 
            // FrmMantenimientoLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 584);
            this.Controls.Add(this.TabGeneral);
            this.Name = "FrmMantenimientoLibros";
            this.Text = "Mantenimiento Libros";
            this.Load += new System.EventHandler(this.FrmMantenimientoLibros_Load);
            this.TabGeneral.ResumeLayout(false);
            this.tabPageListado.ResumeLayout(false);
            this.tabPageListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvLibros)).EndInit();
            this.tabPageMantenimiento.ResumeLayout(false);
            this.tabPageMantenimiento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabGeneral;
        private System.Windows.Forms.TabPage tabPageListado;
        private System.Windows.Forms.TabPage tabPageMantenimiento;
        private System.Windows.Forms.DataGridView DgvLibros;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Seleccionar;
        private System.Windows.Forms.Button BtnBuscar;
        private System.Windows.Forms.TextBox TxtBuscar;
        private System.Windows.Forms.TextBox TxtTitulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtNumEjemplares;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtIsbn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtAutor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEditorial;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtId;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnInsertar;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.TextBox TxtDescripcion;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox TxtUbicacion;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtNumPaginas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtMateria;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtIdioma;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtPais;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox TxtNumEdicion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtAnioEdicion;
        private System.Windows.Forms.Label label7;
    }
}