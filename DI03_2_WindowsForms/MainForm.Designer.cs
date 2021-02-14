
namespace DI03_2_WindowsForms
{
    partial class MainForm
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
            this.funcionalidadExtraLabel = new System.Windows.Forms.Label();
            this.productIdTextBox = new System.Windows.Forms.TextBox();
            this.especificoComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dI03_2_Control1 = new DI03_2_ClassLibrary.DI03_2_Control();
            this.SuspendLayout();
            // 
            // funcionalidadExtraLabel
            // 
            this.funcionalidadExtraLabel.AutoSize = true;
            this.funcionalidadExtraLabel.Location = new System.Drawing.Point(389, 487);
            this.funcionalidadExtraLabel.Name = "funcionalidadExtraLabel";
            this.funcionalidadExtraLabel.Size = new System.Drawing.Size(413, 51);
            this.funcionalidadExtraLabel.TabIndex = 0;
            this.funcionalidadExtraLabel.Text = "Funcionalidad Extra:\r\n(Al presionar la imagen,\r\nbuscara unicamente el productmode" +
    "l marcado por el combobox)";
            // 
            // productIdTextBox
            // 
            this.productIdTextBox.Location = new System.Drawing.Point(84, 519);
            this.productIdTextBox.Name = "productIdTextBox";
            this.productIdTextBox.Size = new System.Drawing.Size(210, 22);
            this.productIdTextBox.TabIndex = 1;
            // 
            // especificoComboBox
            // 
            this.especificoComboBox.FormattingEnabled = true;
            this.especificoComboBox.Location = new System.Drawing.Point(392, 540);
            this.especificoComboBox.Name = "especificoComboBox";
            this.especificoComboBox.Size = new System.Drawing.Size(151, 24);
            this.especificoComboBox.TabIndex = 2;
            this.especificoComboBox.SelectedIndexChanged += new System.EventHandler(this.especificoComboBox_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(704, 540);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 3;
            this.button1.Text = "aleatorioButton";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.aleatorioButton_Click);
            // 
            // dI03_2_Control1
            // 
            this.dI03_2_Control1.Location = new System.Drawing.Point(84, 12);
            this.dI03_2_Control1.Name = "dI03_2_Control1";
            this.dI03_2_Control1.Size = new System.Drawing.Size(747, 435);
            this.dI03_2_Control1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(904, 579);
            this.Controls.Add(this.dI03_2_Control1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.especificoComboBox);
            this.Controls.Add(this.productIdTextBox);
            this.Controls.Add(this.funcionalidadExtraLabel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label funcionalidadExtraLabel;
        private System.Windows.Forms.TextBox productIdTextBox;
        private System.Windows.Forms.ComboBox especificoComboBox;
        private System.Windows.Forms.Button button1;
        private DI03_2_ClassLibrary.DI03_2_Control dI03_2_Control1;
    }
}

