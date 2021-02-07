
namespace DI03_2_Adventure_Works_ClassLibrary
{
    partial class DI03_2_Control
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
            this.components = new System.ComponentModel.Container();
            this.sizesFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.productModelDataTextBox = new System.Windows.Forms.TextBox();
            this.productImagePictureBox = new System.Windows.Forms.PictureBox();
            this.instructionsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sizesFlowLayoutPanel
            // 
            this.sizesFlowLayoutPanel.Location = new System.Drawing.Point(12, 303);
            this.sizesFlowLayoutPanel.Name = "sizesFlowLayoutPanel";
            this.sizesFlowLayoutPanel.Size = new System.Drawing.Size(669, 93);
            this.sizesFlowLayoutPanel.TabIndex = 14;
            // 
            // productModelDataTextBox
            // 
            this.productModelDataTextBox.Location = new System.Drawing.Point(14, 275);
            this.productModelDataTextBox.Name = "productModelDataTextBox";
            this.productModelDataTextBox.Size = new System.Drawing.Size(667, 22);
            this.productModelDataTextBox.TabIndex = 13;
            this.productModelDataTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // productImagePictureBox
            // 
            this.productImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productImagePictureBox.Location = new System.Drawing.Point(152, 0);
            this.productImagePictureBox.Name = "productImagePictureBox";
            this.productImagePictureBox.Size = new System.Drawing.Size(394, 269);
            this.productImagePictureBox.TabIndex = 12;
            this.productImagePictureBox.TabStop = false;
            this.productImagePictureBox.MouseEnter += new System.EventHandler(this.productImagePictureBox_MouseEnter);
            this.productImagePictureBox.MouseLeave += new System.EventHandler(this.productImagePictureBox_MouseLeave);
            // 
            // DI03_2_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.sizesFlowLayoutPanel);
            this.Controls.Add(this.productModelDataTextBox);
            this.Controls.Add(this.productImagePictureBox);
            this.Name = "DI03_2_Control";
            this.Size = new System.Drawing.Size(696, 403);
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sizesFlowLayoutPanel;
        private System.Windows.Forms.TextBox productModelDataTextBox;
        private System.Windows.Forms.PictureBox productImagePictureBox;
        private System.Windows.Forms.ToolTip instructionsToolTip;
    }
}
