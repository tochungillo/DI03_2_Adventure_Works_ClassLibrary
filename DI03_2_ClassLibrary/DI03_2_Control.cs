using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DI03_2_ClassLibrary
{
    public partial class DI03_2_Control : UserControl
    {
        // almacena los productModelID
        public List<int> modelIDs = new List<int>();

        public event EventHandler<ChangeTextBoxTextArgs> changeTextBoxTextCustomEvent;

        public int posicion;
        public int min;
        public int max;

        Random random = new Random();
        DataAccess da = new DataAccess();

        public DI03_2_Control()
        {
            InitializeComponent();
            // tooltip shown on mantain mouse hover productImagePictureBox
            instructionsToolTip.SetToolTip(productImagePictureBox, "Click to display another product");

            ActualizarDatos();
        }

        // Cursor change to hand on enter productImagePictureBox
        private void productImagePictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        // Cursor change to default on leave productImagePictureBox
        private void productImagePictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        // Devuelve un valor aleatorio entre min y max
        public int Aleatorio()
        {
            return random.Next(min, max);
        }

        // Asegurar que se tienen productModels corectos
        public void ActualizarDatos()
        {
            modelIDs = da.GetProductModelIDs();
            min = 0;
            max = modelIDs.Count;
        }

        private void productImagePictureBox_Click(object sender, EventArgs e)
        {
            posicion = Aleatorio();
            // guardar producto
            List<ProductModel> pm = da.GetProductModelsById(modelIDs[posicion]);
            // guardar datos
            modelIdTextBox.Text = pm[0].ProductModelID.ToString();
            modelNameTextBox.Text = pm[0].ProductModelName;
            listPriceTextBox.Text = pm[0].ListPrice.ToString();
            // guardar imagen
            MemoryStream ms = new MemoryStream(pm[0].LargePhoto);
            productImagePictureBox.Image = Image.FromStream(ms);

            GenerarSizes();
        }

        public void GenerarSizes()
        {
            // Almacena los distintos sizes del productModel y el productID que le corresponde
            List<ProductAndSize> sizes = da.GetProductAndSizes(modelIDs[posicion]);

            sizesFlowLayoutPanel.Controls.Clear();

            // no es necesario, pero resulta mas ordenado
            try
            {
                // Si es un numero podra hacer la conversion
                int esnumero = int.Parse(sizes[0].Size);
                // Entonces ordena de mayor a menor (por ejemplo: 38, 42, 46 ...)
                sizes = (List<ProductAndSize>)sizes.OrderBy(x => x.Size).ToList();
            }
            catch (Exception ex)
            {
                // Si es una letra, el orden es inverso (debe ser: S, M, L, XL)
                sizes = (List<ProductAndSize>)sizes.OrderByDescending(x => x.Size).ToList();
            }
            // Evitar duplicados
            List<ProductAndSize> no2 = new List<ProductAndSize>();
            no2.Add(sizes[0]);
            bool esta = false;
            foreach (ProductAndSize pas in sizes)
            {
                esta = false;
                if (pas.Size == null)
                {
                    pas.Size = "NULL";
                }
                foreach (ProductAndSize ps in no2)
                {
                    if (pas.Size.Equals(ps.Size))
                    {
                        esta = true;
                    }
                }
                if (!esta)
                {
                    no2.Add(pas);
                }
            }

            sizes.Clear();
            sizes = no2;

            // Ha de crear botones por cada size
            foreach (ProductAndSize ps in sizes)
            {
                Button buttonSize = new Button();
                if (ps.Size == null)
                {
                    buttonSize.Text = "NULL";
                }
                else
                {
                    buttonSize.Text = ps.Size;
                }
                buttonSize.Name = ps.ProductID.ToString();
                buttonSize.Click += buttonSize_Click;

                // introduces esos botones al sizesFlowLayoutPanel
                sizesFlowLayoutPanel.Controls.Add(buttonSize);
            }
        }
        // Evento de los botones size en el control
        public void buttonSize_Click(object sender, EventArgs e)
        {
            if (changeTextBoxTextCustomEvent != null)
            {
                changeTextBoxTextCustomEvent(sender, new ChangeTextBoxTextArgs( ((Button) sender).Name ));
            }
        }
    }
}
