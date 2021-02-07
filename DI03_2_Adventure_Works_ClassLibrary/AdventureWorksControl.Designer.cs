
namespace DI03_2_Adventure_Works_ClassLibrary
{
    partial class AdventureWorksControl
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.informacioTextBox = new System.Windows.Forms.TextBox();
            this.productPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // informacioTextBox
            // 
            this.informacioTextBox.Location = new System.Drawing.Point(173, 304);
            this.informacioTextBox.Name = "informacioTextBox";
            this.informacioTextBox.Size = new System.Drawing.Size(667, 22);
            this.informacioTextBox.TabIndex = 5;
            this.informacioTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productPictureBox
            // 
            this.productPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productPictureBox.Location = new System.Drawing.Point(297, 29);
            this.productPictureBox.Name = "productPictureBox";
            this.productPictureBox.Size = new System.Drawing.Size(394, 269);
            this.productPictureBox.TabIndex = 4;
            this.productPictureBox.TabStop = false;
            // 
            // AdventureWorksControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.informacioTextBox);
            this.Controls.Add(this.productPictureBox);
            this.Name = "AdventureWorksControl";
            this.Size = new System.Drawing.Size(1012, 354);
            ((System.ComponentModel.ISupportInitialize)(this.productPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox informacioTextBox;
        private System.Windows.Forms.PictureBox productPictureBox;
    }
}
