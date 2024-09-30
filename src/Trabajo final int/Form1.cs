using Datos;
using Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_final_int
{
    
    
    public partial class Form1 : Form
    {
        public static List<ApiProducts> Products = new List<ApiProducts>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Products = ConectionApi.GetProducts("https://fakestoreapi.com");
            dataGridView1.DataSource = Products;
        }
    }
}
