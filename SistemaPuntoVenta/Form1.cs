using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using ViewModels.Library;

namespace SistemaPuntoVenta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //CODIGO DEL CLIENTE
        #region
        private ClientesVM clientes;
        private void btn_clientes_Click(object sender, EventArgs e)
        {
            var textBoxCliente = new List<TextBox>();
            textBoxCliente.Add(txt_idCliente);
            textBoxCliente.Add(txt_nombreCliente);
            textBoxCliente.Add(txt_apellidoCliente);
            textBoxCliente.Add(txt_emailCliente);
            textBoxCliente.Add(txt_direccionCliente);
            textBoxCliente.Add(txt_telefonoCliente);

            var labelCliente = new List<Label>();
            labelCliente.Add(label_idCliente);
            labelCliente.Add(label_clienteNombre);
            labelCliente.Add(label_apellidoCliente);
            labelCliente.Add(label_emailCliente);
            labelCliente.Add(label_direccionCliente);
            labelCliente.Add(label_telefonoCliente);

            object[] objectos = {
                pb_clietne,
                checkBox_ClienteCredito

            
            };

            clientes = new ClientesVM(objectos,textBoxCliente, labelCliente);
            tpc_Principal.SelectedIndex = 1;
        }

        //Este metodo invoca a la clase para colocar una imagen
        private void pb_clietne_Click(object sender, EventArgs e)
        {
            Objects.uploadimage.CargarImagen(pb_clietne); 
        }

        //Este evento es para que cuando escribas en el textbox cambie de color
        //el label y vuelva a su color inicial cuando se borre todo
        private void txt_idCliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_idCliente.Text.Equals(""))
            {
                label_idCliente.ForeColor = Color.Black;
            }
            else
            {
                label_idCliente.ForeColor = Color.Green;
            }
        }

        private void txt_idCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.ValidacionEntrada.NumberKeyPress(e);
        }

        private void txt_nombreCliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_nombreCliente.Text.Equals(""))
            {
                label_clienteNombre.ForeColor = Color.Black;
            }
            else
            {
                label_clienteNombre.ForeColor = Color.Green;
            }
        }

        private void txt_nombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.ValidacionEntrada.TextKeyPress(e);
        }

        private void txt_apellidoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_apellidoCliente.Text.Equals(""))
            {
                label_apellidoCliente.ForeColor = Color.Black;
            }
            else
            {
                label_apellidoCliente.ForeColor = Color.Green;
            }
        }

        private void txt_apellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.ValidacionEntrada.TextKeyPress(e);
        }

        private void txt_emailCliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_emailCliente.Text.Equals(""))
            {
                label_emailCliente.ForeColor = Color.Black;
            }
            else
            {
                label_emailCliente.ForeColor = Color.Green;
            }
        }

        private void txt_telefonoCliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_telefonoCliente.Text.Equals(""))
            {
                label_telefonoCliente.ForeColor = Color.Black;
            }
            else
            {
                label_telefonoCliente.ForeColor = Color.Green;
            }
        }

        private void txt_telefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.ValidacionEntrada.NumberKeyPress(e);
        }

        private void txt_direccionCliente_TextChanged(object sender, EventArgs e)
        {
            if (txt_direccionCliente.Text.Equals(""))
            {
                label_direccionCliente.ForeColor = Color.Black;
            }
            else
            {
                label_direccionCliente.ForeColor = Color.Green;
            }
        }

        private void btn_agregarCliente_Click(object sender, EventArgs e)
        {
            clientes.GuardarCliente();
        }

        private void btn_eliminarCliente_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}
