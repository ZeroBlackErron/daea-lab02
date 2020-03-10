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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["Anthony"].ConnectionString);

        public void ListaAnios()
        {
            using (SqlCommand cmd = new SqlCommand("Usp_ListaAnios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "ListaAnios");
                        cboAnios.DataSource = df.Tables["ListaAnios"];
                        cboAnios.DisplayMember = "Anios";
                        cboAnios.ValueMember = "Anios";
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ListaAnios();
        }

        private void cboAnios_SelectionChangeCommitted(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("Usp_Lista_Pedidos_Anios", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@anio", cboAnios.SelectedValue);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Pedidos");
                        dgPedidos.DataSource = df.Tables["Pedidos"];
                        txtNumPedidos.Text = df.Tables["Pedidos"].Rows.Count.ToString();
                    }
                }
            }
        }

        private void dgPedidos_DoubleClick(object sender, EventArgs e)
        {
            int codigo;
            codigo = Convert.ToInt32(dgPedidos.CurrentRow.Cells[0].Value);
            using (SqlCommand cmd = new SqlCommand("Usp_Detalle_Pedido", cn))
            {
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = cmd;
                    da.SelectCommand.CommandType = CommandType.StoredProcedure;
                    da.SelectCommand.Parameters.AddWithValue("@idpedido", codigo);
                    using (DataSet df = new DataSet())
                    {
                        da.Fill(df, "Detalles");
                        dgDetalle.DataSource = df.Tables["Detalles"];
                        txtMonDetalle.Text = df.Tables["Detalles"].Compute("Sum(Monto)", "").ToString();
                    }
                }
            }
        }
    }
}
