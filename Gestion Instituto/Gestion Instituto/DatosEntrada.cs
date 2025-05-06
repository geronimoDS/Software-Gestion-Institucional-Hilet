using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Instituto
{
    internal class DatosEntrada
    {
        public static bool ValidarTexto(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return false;
            else
                return true;
        }

        public static bool ValidarTexto(TextBox txt, ErrorProvider errorProvider, string mensaje)
        {
            if (String.IsNullOrEmpty(txt.Text))
            {
                errorProvider.SetError(txt, mensaje);
                txt.Focus();
                return false;
            }
            else
            {
                errorProvider.SetError(txt, "");
                return true;
            }
        }

        public static bool ValidarNumero(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return false;
            else if (!int.TryParse(txt.Text, out int n))
                return false;
            else
                return true;
        }

        public static bool ValidarNumero(TextBox txt, ErrorProvider errorProvider, string mensaje)
        {
            if (String.IsNullOrEmpty(txt.Text) || !int.TryParse(txt.Text, out int n))
            {
                errorProvider.SetError(txt, mensaje);
                txt.Focus();
                return false;
            }
            else
            {
                errorProvider.SetError(txt, "");
                return true;
            }
        }

        public static bool ValidarDecimal(TextBox txt)
        {
            if (String.IsNullOrEmpty(txt.Text))
                return false;
            else if (!decimal.TryParse(txt.Text, out decimal n))
                return false;
            else
                return true;
        }
        
        public static bool ValidarDecimal(TextBox txt, ErrorProvider errorProvider, string mensaje)
        {
            if (String.IsNullOrEmpty(txt.Text) || !decimal.TryParse(txt.Text, out decimal n))
            {
                errorProvider.SetError(txt, mensaje);
                txt.Focus();
                return false;
            }
            else
            {
                errorProvider.SetError(txt, "");
                return true;
            }
        }


    }
}
