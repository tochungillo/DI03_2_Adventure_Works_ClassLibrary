
namespace DI03_2_ClassLibrary
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
            this.modelIdTextBox = new System.Windows.Forms.TextBox();
            this.productImagePictureBox = new System.Windows.Forms.PictureBox();
            this.instructionsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.listPriceTextBox = new System.Windows.Forms.TextBox();
            this.modelIdLabel = new System.Windows.Forms.Label();
            this.modelNameLabel = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // sizesFlowLayoutPanel
            // 
            this.sizesFlowLayoutPanel.Location = new System.Drawing.Point(36, 306);
            this.sizesFlowLayoutPanel.Name = "sizesFlowLayoutPanel";
            this.sizesFlowLayoutPanel.Size = new System.Drawing.Size(669, 93);
            this.sizesFlowLayoutPanel.TabIndex = 17;
            // 
            // modelIdTextBox
            // 
            this.modelIdTextBox.Location = new System.Drawing.Point(454, 57);
            this.modelIdTextBox.Name = "modelIdTextBox";
            this.modelIdTextBox.Size = new System.Drawing.Size(251, 22);
            this.modelIdTextBox.TabIndex = 16;
            // 
            // productImagePictureBox
            // 
            this.productImagePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.productImagePictureBox.Location = new System.Drawing.Point(38, 0);
            this.productImagePictureBox.Name = "productImagePictureBox";
            this.productImagePictureBox.Size = new System.Drawing.Size(394, 269);
            this.productImagePictureBox.TabIndex = 15;
            this.productImagePictureBox.TabStop = false;
            this.productImagePictureBox.Click += new System.EventHandler(this.productImagePictureBox_Click);
            this.productImagePictureBox.MouseEnter += new System.EventHandler(this.productImagePictureBox_MouseEnter);
            this.productImagePictureBox.MouseLeave += new System.EventHandler(this.productImagePictureBox_MouseLeave);
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(454, 127);
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(251, 22);
            this.modelNameTextBox.TabIndex = 18;
            // 
            // listPriceTextBox
            // 
            this.listPriceTextBox.Location = new System.Drawing.Point(454, 191);
            this.listPriceTextBox.Name = "listPriceTextBox";
            this.listPriceTextBox.Size = new System.Drawing.Size(251, 22);
            this.listPriceTextBox.TabIndex = 20;
            // 
            // modelIdLabel
            // 
            this.modelIdLabel.AutoSize = true;
            this.modelIdLabel.Location = new System.Drawing.Point(451, 37);
            this.modelIdLabel.Name = "modelIdLabel";
            this.modelIdLabel.Size = new System.Drawing.Size(63, 17);
            this.modelIdLabel.TabIndex = 21;
            this.modelIdLabel.Text = "Model ID";
            // 
            // modelNameLabel
            // 
            this.modelNameLabel.AutoSize = true;
            this.modelNameLabel.Location = new System.Drawing.Point(451, 107);
            this.modelNameLabel.Name = "modelNameLabel";
            this.modelNameLabel.Size = new System.Drawing.Size(87, 17);
            this.modelNameLabel.TabIndex = 22;
            this.modelNameLabel.Text = "Model Name";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Location = new System.Drawing.Point(451, 171);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(66, 17);
            this.PriceLabel.TabIndex = 23;
            this.PriceLabel.Text = "List Price";
            // 
            // DI03_2_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.modelNameLabel);
            this.Controls.Add(this.modelIdLabel);
            this.Controls.Add(this.listPriceTextBox);
            this.Controls.Add(this.modelNameTextBox);
            this.Controls.Add(this.sizesFlowLayoutPanel);
            this.Controls.Add(this.modelIdTextBox);
            this.Controls.Add(this.productImagePictureBox);
            this.Name = "DI03_2_Control";
            this.Size = new System.Drawing.Size(747, 435);
            ((System.ComponentModel.ISupportInitialize)(this.productImagePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel sizesFlowLayoutPanel;
        private System.Windows.Forms.TextBox modelIdTextBox;
        private System.Windows.Forms.PictureBox productImagePictureBox;
        private System.Windows.Forms.ToolTip instructionsToolTip;
        private System.Windows.Forms.TextBox modelNameTextBox;
        private System.Windows.Forms.TextBox listPriceTextBox;
        private System.Windows.Forms.Label modelIdLabel;
        private System.Windows.Forms.Label modelNameLabel;
        private System.Windows.Forms.Label PriceLabel;
    }
}
