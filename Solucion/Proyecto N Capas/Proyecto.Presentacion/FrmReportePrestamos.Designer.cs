
namespace Proyecto.Presentacion
{
    partial class FrmReportePrestamos
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
            this.DgvPrestamos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvPrestamos
            // 
            this.DgvPrestamos.AllowUserToAddRows = false;
            this.DgvPrestamos.AllowUserToDeleteRows = false;
            this.DgvPrestamos.AllowUserToOrderColumns = true;
            this.DgvPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvPrestamos.Location = new System.Drawing.Point(12, 82);
            this.DgvPrestamos.Name = "DgvPrestamos";
            this.DgvPrestamos.ReadOnly = true;
            this.DgvPrestamos.RowHeadersWidth = 51;
            this.DgvPrestamos.RowTemplate.Height = 24;
            this.DgvPrestamos.Size = new System.Drawing.Size(776, 310);
            this.DgvPrestamos.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Reporte de prestamos";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Location = new System.Drawing.Point(465, 411);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(44, 17);
            this.LblTotal.TabIndex = 2;
            this.LblTotal.Text = "Total:";
            // 
            // FrmReportePrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DgvPrestamos);
            this.Name = "FrmReportePrestamos";
            this.Text = "FrmReportePrestamos";
            this.Load += new System.EventHandler(this.FrmReportePrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvPrestamos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblTotal;
    }
}