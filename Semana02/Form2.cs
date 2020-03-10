using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;

namespace Semana02
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Anthony"].ConnectionString);

        private void Form2_Load(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("List_Orders", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        dgPedidos.DataSource = df.Tables["Pedidos"];
                    }
                }
            }
        }

        private void dgPedidos_DoubleClick(object sender, EventArgs e)
        {
            int codigo;
            codigo = Convert.ToInt32(dgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("List_Products_From_Order", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idOrder", codigo);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Detalles");
                        dgDetalle.DataSource = df.Tables["Detalles"];
                    }
                }
            }
        }
    }
}
