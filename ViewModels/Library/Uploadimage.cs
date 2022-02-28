using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewModels.Library
{
    public class Uploadimage
    {
        private OpenFileDialog fd = new OpenFileDialog();

        //Metodo para cargar las imagenes
        public void CargarImagen(PictureBox pictureBox)
        {
            //Establecer la propiedad de WaitOnLoad a true significa que la imagen
            //se carga de forma sincronica
            pictureBox.WaitOnLoad = true;

            fd.Filter = "Todos(*.*)|*.*|Imagenes|*.jpg;*.gif;*.png;*.bmp";
            fd.ShowDialog();

            if(fd.FileName!= String.Empty)
            {
                pictureBox.ImageLocation = fd.FileName;
            }

        }
    }
}
