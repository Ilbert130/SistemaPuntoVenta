using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class ValidacionEntrada
    {
        public void TextKeyPress(KeyPressEventArgs e)
        {
            //Si la propiedad Handled es True no podras ingresar valor, si es false si

            //Condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsLetter(e.KeyChar)) { e.Handled = false; }
            //Condicion que permite no dar salto de linea cuando se oprime Enter.
            else if(e.KeyChar == Convert.ToChar(Keys.Enter)){ e.Handled = true; }
            //Condicion que nos permite utilizar la tecla backspace (Caracteres especiales)
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condicion que nos permite utilizar la tecla de espacion
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false;}
            else { e.Handled=true; }
        }

        public void NumberKeyPress(KeyPressEventArgs e)
        {
            //Condicion que solo nos permite ingresar datos de tipo texto
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            //Condicion que permite no dar salto de linea cuando se oprime Enter.
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            //Condicion que no permite ingresar dato tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            //Condicion que nos permite utilizar la tecla backspace (Caracteres especiales)
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            //Condicion que nos permite utilizar la tecla de espacion
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
    }
}
