using LinqToDB;
using Models.Conexion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels.Library;

namespace ViewModels
{
    public class ClientesVM:Conexion
    {
        private List<TextBox> textBoxCliente;
        private List<Label> labelCliente;
        private ValidacionEntrada evento;
        private string accion = "insert";
        private PictureBox imagePictureBox;
        private CheckBox checkBoxCredito;

        public ClientesVM(object[] objectos,List<TextBox> textBoxCliente, List<Label> labelCliente)
        {
            this.textBoxCliente = textBoxCliente;
            this.labelCliente = labelCliente;
            imagePictureBox = (PictureBox)objectos[0];
            checkBoxCredito = (CheckBox)objectos[1];
            evento = new ValidacionEntrada();
        }

        public void GuardarCliente()
        {
            if (textBoxCliente[0].Text.Equals(""))
            {
                labelCliente[0].Text = "Este campo es requerido";
                labelCliente[0].ForeColor = Color.Red;
                textBoxCliente[0].Focus();
            }
            else
            {
                if (textBoxCliente[1].Text.Equals(""))
                {
                    labelCliente[1].Text = "Este campo es requerido";
                    labelCliente[1].ForeColor = Color.Red;
                    textBoxCliente[1].Focus();
                }
                else
                {
                    if (textBoxCliente[2].Text.Equals(""))
                    {
                        labelCliente[2].Text = "Este campo es requerido";
                        labelCliente[2].ForeColor = Color.Red;
                        textBoxCliente[2].Focus();
                    }
                    else
                    {
                        if (textBoxCliente[3].Text.Equals(""))
                        {
                            labelCliente[3].Text = "Este campo es requerido";
                            labelCliente[3].ForeColor = Color.Red;
                            textBoxCliente[3].Focus();
                        }
                        else
                        {
                            if (evento.ComprobarFormatoEmail(textBoxCliente[5].Text))
                            {
                                if (textBoxCliente[4].Text.Equals(""))
                                {
                                    labelCliente[4].Text = "Este campo es requerido";
                                    labelCliente[4].ForeColor = Color.Red;
                                    textBoxCliente[4].Focus();
                                }
                                else
                                {

                                    if (textBoxCliente[5].Text.Equals(""))
                                    {
                                        labelCliente[5].Text = "Este campo es requerido";
                                        labelCliente[5].ForeColor = Color.Red;
                                        textBoxCliente[5].Focus();
                                    }
                                    else
                                    {
                                        var cliente1 = TClientes.Where(c => c.Nid.Equals(textBoxCliente[0].Text)).ToList();
                                        var cliente2 = TClientes.Where(c => c.Email.Equals(textBoxCliente[3].Text)).ToList();
                                        //Esta es la manera de unir dos lista del mismo tipo
                                        var list = cliente1.Union(cliente2).ToList();

                                        switch (accion)
                                        {
                                            case "insert":
                                                if (list.Count.Equals(0))
                                                {
                                                    SaveDato();
                                                }
                                                else
                                                {
                                                    if (0<cliente1.Count)
                                                    {
                                                        labelCliente[0].Text = "El nid ya esta registrado";
                                                        labelCliente[0].ForeColor = Color.Red;
                                                        textBoxCliente[0].Focus();
                                                    }

                                                    if (0<cliente2.Count)
                                                    {
                                                        labelCliente[3].Text = "El email ya esta registrado";
                                                        labelCliente[3].ForeColor = Color.Red;
                                                        textBoxCliente[3].Focus();
                                                    }
                                                }

                                                break;
                                        }
                                    }
                                }
                            }
                            else
                            {
                                labelCliente[3].Text = "Email invalido";
                                labelCliente[3].ForeColor = Color.Red;
                                textBoxCliente[3].Focus();
                            }
                        }
                    }
                }
            }
        }

        private void SaveDato()
        {
            BeginTransactionAsync();
            try
            {
                var srcImage = Objects.uploadimage.ResizeImage(imagePictureBox.Image, 165, 100);
                var image = Objects.uploadimage.ImageToByte(srcImage);

                switch (accion)
                {
                    case "insert":
                        TClientes.Value(c => c.Nid, textBoxCliente[0].Text)
                            .Value(c => c.Nombre, textBoxCliente[1].Text)
                            .Value(c => c.Apellido, textBoxCliente[2].Text)
                            .Value(c => c.Email, textBoxCliente[3].Text)
                            .Value(c => c.Telefono, textBoxCliente[4].Text)
                            .Value(c => c.Direccion, textBoxCliente[5].Text)
                            .Value(c => c.Credito, checkBoxCredito.Checked)
                            .Value(c => c.Fecha, DateTime.Now.ToString("dd/MMM/yyy"))
                            .Value(c => c.Imagen, image)
                            .Insert();

                        var cliente = TClientes.ToList().Last();

                        TReportes_clientes.Value(u => u.UltimoPago, 0)
                            .Value(u => u.FechaPago, "--/--/--")
                            .Value(u => u.DeudaActual, 0)
                            .Value(u => u.FechaDeuda, "--/--/--")
                            .Value(u => u.Ticket, "0000000000")
                            .Value(u => u.FechaLimite, "--/--/--")
                            .Value(u => u.IdCliente, cliente.IdCliente)
                            .Insert();

                        break;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }



    }
}
