
namespace DI03_2_Adventure_Works_ClassLibrary
{
    partial class DI03_2_MainForm
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
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.aleatorioButton = new System.Windows.Forms.Button();
            this.especificoComboBox = new System.Windows.Forms.ComboBox();
            this.especificoLabel = new System.Windows.Forms.Label();
            this.dI03_2_Control1 = new DI03_2_Adventure_Works_ClassLibrary.DI03_2_Control();
            this.SuspendLayout();
            // 
            // idTextBox
            // 
            this.idTextBox.Location = new System.Drawing.Point(58, 455);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(208, 22);
            this.idTextBox.TabIndex = 14;
            // 
            // aleatorioButton
            // 
            this.aleatorioButton.Location = new System.Drawing.Point(549, 455);
            this.aleatorioButton.Name = "aleatorioButton";
            this.aleatorioButton.Size = new System.Drawing.Size(84, 31);
            this.aleatorioButton.TabIndex = 13;
            this.aleatorioButton.Text = "aleatorio";
            this.aleatorioButton.UseVisualStyleBackColor = true;
            this.aleatorioButton.Click += new System.EventHandler(this.aleatorioButton_Click);
            // 
            // especificoComboBox
            // 
            this.especificoComboBox.FormattingEnabled = true;
            this.especificoComboBox.Location = new System.Drawing.Point(361, 462);
            this.especificoComboBox.Name = "especificoComboBox";
            this.especificoComboBox.Size = new System.Drawing.Size(121, 24);
            this.especificoComboBox.TabIndex = 12;
            this.especificoComboBox.SelectedIndexChanged += new System.EventHandler(this.especificoComboBox_SelectedIndexChanged);
            // 
            // especificoLabel
            // 
            this.especificoLabel.AutoSize = true;
            this.especificoLabel.Location = new System.Drawing.Point(276, 434);
            this.especificoLabel.Name = "especificoLabel";
            this.especificoLabel.Size = new System.Drawing.Size(436, 17);
            this.especificoLabel.TabIndex = 11;
            this.especificoLabel.Text = "(Funcionalidad extra) Busca un porducto especifico insertando su id";
            // 
            // dI03_2_Control1
            // 
            this.dI03_2_Control1.Location = new System.Drawing.Point(35, 12);
            this.dI03_2_Control1.Name = "dI03_2_Control1";
            this.dI03_2_Control1.Size = new System.Drawing.Size(696, 403);
            this.dI03_2_Control1.TabIndex = 15;
            // 
            // DI03_2_MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 532);
            this.Controls.Add(this.dI03_2_Control1);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(this.aleatorioButton);
            this.Controls.Add(this.especificoComboBox);
            this.Controls.Add(this.especificoLabel);
            this.Name = "DI03_2_MainForm";
            this.Text = "DI03_2_MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.Button aleatorioButton;
        private System.Windows.Forms.ComboBox especificoComboBox;
        private System.Windows.Forms.Label especificoLabel;
        private DI03_2_Control dI03_2_Control1;
    }
}