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

namespace DI03_2_Adventure_Works_ClassLibrary
{
    public partial class DI03_2_Control : UserControl
    {
        // almacena los productModelID
        public List<int> modelIDs = new List<int>();

        public int posicion;
        public int productID;
        public int min;
        public int max;

        Random random = new Random();
        DataAccess da = new DataAccess();

        public DI03_2_Control()
        {
            InitializeComponent();
            // tooltip shown on mantain mouse hover productImagePictureBox
            instructionsToolTip.SetToolTip(productImagePictureBox, "Click to display another product");
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

        private void productImagePictureBox_Click(object sender, EventArgs e)
        {
            posicion = Aleatorio();

            // Borra si hay otros botones creados
            sizesFlowLayoutPanel.Controls.Clear();

            // Obtiene los productos
            List<ProductModel> products = da.GetProductModels(modelIDs[posicion]);

            // pides que esten ordenados de mayor a menor por size
            try
            {
                // Si es un numero podra hacer la conversion
                int esnumero = int.Parse(products[0].Size);
                // Entonces ordena de mayor a menor (por ejemplo: 38, 42, 46 ...)
                products = (List<ProductModel>) products.OrderBy(x => x.Size).ToList();
            }
            catch (Exception ex)
            {
                // Si es una letra, el orden es inverso (debe ser: S, M, L, XL)
                products = (List<ProductModel>) products.OrderByDescending(x => x.Size).ToList();
            }

            // Convierte los datos a una imagen y la asigna a productImagePictureBox
            MemoryStream ms = new MemoryStream(products[0].LargePhoto);
            Image foto = Image.FromStream(ms);
            productImagePictureBox.Image = foto;

            // Muestra la informacion del product model en productModelDataTextBox
            productModelDataTextBox.Text = products[0].ToString();

            // Creara botones y los introducira en sizesFlowLayoutPanel
            GenerarSizes();
        }

        public void GenerarSizes()
        {
            // Almacena los distintos sizes del productModel y el productID que le corresponde
            List<ProductAndSize> sizes = da.GetProductAndSizes(modelIDs[posicion]);

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
                // introduces esos botones al sizesFlowLayoutPanel
                sizesFlowLayoutPanel.Controls.Add(buttonSize);
            }
        }
    }
}
