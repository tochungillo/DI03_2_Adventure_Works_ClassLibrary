using DI03_2_ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI03_2_WindowsForms
{
    public partial class MainForm : Form
    {
        public static int productId
        {
            get { return productId; }
            set
            {
                productId = value;
                //productIdTextBox.Text = $"El id del producto es: {value}";
            }
        }
        public MainForm()
        {
            InitializeComponent();

            dI03_2_Control1.changeTextBoxTextCustomEvent += new EventHandler<ChangeTextBoxTextArgs>(control_changeTextBoxTextCustomEvent);

            ActualizarEspecifico();
        }

        private void aleatorioButton_Click(object sender, EventArgs e)
        {
            dI03_2_Control1.ActualizarDatos();

            ActualizarEspecifico();
        }

        private void especificoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (especificoComboBox.SelectedIndex != -1)
            {
                dI03_2_Control1.min = especificoComboBox.SelectedIndex;
                dI03_2_Control1.max = especificoComboBox.SelectedIndex + 1;
            }
        }
        public void ActualizarEspecifico()
        {
            foreach (int i in dI03_2_Control1.modelIDs)
            {
                especificoComboBox.Items.Add(i.ToString());
            }
        }

        // Evento de los botones size en el control
        private void control_changeTextBoxTextCustomEvent(object sender, ChangeTextBoxTextArgs e)
        {
            productIdTextBox.Text = e.Text;
        }
    }
}
