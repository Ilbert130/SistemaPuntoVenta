using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels
{
    public class ClientesVM
    {
        private List<TextBox> textBoxCliente;
        private List<Label> labelCliente;

        public ClientesVM(List<TextBox> textBoxCliente, List<Label> labelCliente)
        {
            this.textBoxCliente = textBoxCliente;
            this.labelCliente = labelCliente;
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

                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
