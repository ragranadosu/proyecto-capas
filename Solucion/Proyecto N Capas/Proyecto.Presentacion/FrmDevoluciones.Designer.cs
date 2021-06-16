
namespace Proyecto.Presentacion
{
    partial class FrmDevoluciones
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
            this.BtnBuscarProfesor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.DgvProfesores = new System.Windows.Forms.DataGridView();
            this.BtnDevolver = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.DgvPrestamos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnBuscarProfesor
            // 
            this.BtnBuscarProfesor.Location = new System.Drawing.Point(651, 95);
            this.BtnBuscarProfesor.Name = "BtnBuscarProfesor";
            this.BtnBuscarProfesor.Size = new System.Drawing.Size(75, 23);
            this.BtnBuscarProfesor.TabIndex = 0;
            this.BtnBuscarProfesor.Text = "Buscar";
            this.BtnBuscarProfesor.UseVisualStyleBackColor = true;
            this.BtnBuscarProfesor.Click += new System.EventHandler(this.BtnBuscarProfesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Busqueda Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre o Apellido";
            // 
            // TxtBuscarProfesor
            // 
            this.TxtBuscarProfesor.Location = new System.Drawing.Point(65, 95);
            this.TxtBuscarProfesor.Name = "TxtBuscarProfesor";
            this.TxtBuscarProfesor.Size = new System.Drawing.Size(297, 22);
            this.TxtBuscarProfesor.TabIndex = 3;
            // 
            // DgvProfesores
            // 
            this.DgvProfesores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvProfesores.Location = new System.Drawing.Point(65, 140);
            this.DgvProfesores.Name = "DgvProfesores";
            this.DgvProfesores.ReadOnly = true;
            this.DgvProfesores.RowHeadersWidth = 51;
            this.DgvProfesores.RowTemplate.Height = 24;
            this.DgvProfesores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvProfesores.Size = new System.Drawing.Size(661, 153);
            this.DgvProfesores.TabIndex = 4;
            this.DgvProfesores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvProfesores_CellClick);
            // 
            // BtnDevolver
            // 
            this.BtnDevolver.Location = new System.Drawing.Point(810, 228);
            this.BtnDevolver.Name = "BtnDevolver";
            this.BtnDevolver.Size = new System.Drawing.Size(173, 65);
            this.BtnDevolver.TabIndex = 5;
            this.BtnDevolver.Text = "Devolver";
            this.BtnDevolver.UseVisualStyleBackColor = true;
            this.BtnDevolver.Click += new System.EventHandler(this.BtnDevolver_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(203, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Prestamos activos del profesor";
            // 
            // DgvPrestamos
            // 
            this.DgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrestamos.Location = new System.Drawing.Point(65, 373);
            this.DgvPrestamos.Name = "DgvPrestamos";
            this.DgvPrestamos.ReadOnly = true;
            this.DgvPrestamos.RowHeadersWidth = 51;
            this.DgvPrestamos.RowTemplate.Height = 24;
            this.DgvPrestamos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvPrestamos.Size = new System.Drawing.Size(981, 192);
            this.DgvPrestamos.TabIndex = 7;
            this.DgvPrestamos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvPrestamos_CellClick);
            // 
            // FrmDevoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1099, 636);
            this.Controls.Add(this.DgvPrestamos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnDevolver);
            this.Controls.Add(this.DgvProfesores);
            this.Controls.Add(this.TxtBuscarProfesor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnBuscarProfesor);
            this.Name = "FrmDevoluciones";
            this.Text = "FrmDevoluciones";
            this.Load += new System.EventHandler(this.FrmDevoluciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvProfesores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnBuscarProfesor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscarProfesor;
        private System.Windows.Forms.DataGridView DgvProfesores;
        private System.Windows.Forms.Button BtnDevolver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgvPrestamos;
    }
}