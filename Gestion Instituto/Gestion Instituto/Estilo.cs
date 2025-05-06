using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestion_Instituto
{
    internal static class Estilo
    {
        public static bool ModoOscuro = false;

        // Colores
        static Color COLOR_PRINCIPAL_CLARO = Color.FromArgb(33, 63, 96);
        static Color COLOR_PRINCIPAL_OSCURO = Color.FromArgb(46, 88, 134);
        static Color COLOR_FONDO_CLARO = Color.FromArgb(235, 235, 235);
        static Color COLOR_FONDO_OSCURO = Color.FromArgb(40, 40, 50);
        static Color COLOR_BARRA_CLARO = Color.FromArgb(96, 96, 96);
        static Color COLOR_BARRA_OSCURO = Color.FromArgb(30, 30, 30);
        static Color COLOR_TEXTO_CLARO = Color.White;
        static Color COLOR_TEXTO_OSCURO = Color.Black;

        // Preparar colores
        public static Color ColorPrincipal = ModoOscuro ? COLOR_PRINCIPAL_OSCURO : COLOR_PRINCIPAL_CLARO;
        public static Color ColorFondo = ModoOscuro ? COLOR_FONDO_OSCURO : COLOR_FONDO_CLARO;
        public static Color ColorBarra = ModoOscuro ? COLOR_BARRA_OSCURO : COLOR_BARRA_CLARO;
        public static Color ColorTextoClaro = ModoOscuro ? COLOR_TEXTO_OSCURO : COLOR_TEXTO_CLARO;
        public static Color ColorTextoOscuro = ModoOscuro ? COLOR_TEXTO_CLARO : COLOR_TEXTO_OSCURO;

        // Fuentes
        public static Font BotonFont = new Font("Arial", 12, FontStyle.Bold);
        public static Font LabelFont = new Font("Arial", 12);

        public static void AplicarTodo(Control control)
        {
            // Preparar colores al llamar la funcion
            ColorPrincipal = ModoOscuro ? COLOR_PRINCIPAL_OSCURO : COLOR_PRINCIPAL_CLARO;
            ColorFondo = ModoOscuro ? COLOR_FONDO_OSCURO : COLOR_FONDO_CLARO;
            ColorBarra = ModoOscuro ? COLOR_BARRA_OSCURO : COLOR_BARRA_CLARO;
            ColorTextoClaro = ModoOscuro ? COLOR_TEXTO_OSCURO : COLOR_TEXTO_CLARO;
            ColorTextoOscuro = ModoOscuro ? COLOR_TEXTO_CLARO : COLOR_TEXTO_OSCURO;

            // Default
            if (control.Tag == null || control.Tag.ToString() == "")
            {
                control.Font = LabelFont;
                control.ForeColor = ColorTextoOscuro;
            }

            // Aplicar estilos segun control
            switch (control)
            {
                case Form: EstiloVentana(control as Form); break;
                case Button: EstiloBoton(control as Button); break;
                case TextBox: EstiloTextbox(control as TextBox); break;
                case ComboBox: EstiloComboBox(control as ComboBox); break;
                case Label: EstiloLabel(control as Label); break;
                case MenuStrip: EstiloMenuStrip(control as MenuStrip); break;
                case StatusStrip: EstiloStatusStrip(control as StatusStrip); break;
                case DataGridView: EstiloGridView(control as DataGridView); break;
                case Panel: EstiloPlanel(control as Panel); break;

                // Agregar los controles que hagan falta
            }


            // Aplicar a controles recursivamente
            foreach (Control child in control.Controls)
            {
                AplicarTodo(child);
            }
        }

        private static void EstiloVentana(Form form)
        {
            form.BackColor = ColorFondo;
            form.MinimumSize = form.Size;
            form.StartPosition = FormStartPosition.CenterParent;

            if (form.Name != "FormDashboard" && form.Name != "FormLogin")
            {
                form.ControlBox = false;
                form.MaximizeBox = false;
                form.MinimizeBox = false;
                form.ShowInTaskbar = false;
                form.StartPosition = FormStartPosition.CenterParent;

                form.KeyPreview = true;
                form.KeyDown += Form_KeyDown;
            }
        }


        private static void Form_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                if (sender is Form form)
                {
                    form.Close();
                }
            }
        }

        private static void EstiloBoton(Button boton)
        {
            if (boton.Tag == null || boton.Tag.ToString() == "")
            {
                boton.BackColor = ColorPrincipal;
                boton.ForeColor = Color.White;
                boton.Width = 140;
                boton.Height = 60;
                boton.FlatStyle = FlatStyle.Flat;
                boton.FlatAppearance.BorderSize = 0;
                boton.Font = BotonFont;
            }
        }

        private static void EstiloTextbox(TextBox textBox)
        {
            if (textBox.Tag == null || textBox.Tag.ToString() == "")
            {
                textBox.BorderStyle = BorderStyle.FixedSingle;
                textBox.ForeColor = Color.Black;
            }
        }

        private static void EstiloComboBox(ComboBox comboBox)
        {
            if (comboBox.Tag == null || comboBox.Tag.ToString() == "")
            {
                comboBox.Font = LabelFont;
                comboBox.ForeColor = Color.Black;
            }
        }

        private static void EstiloLabel(Label label)
        {
            if (label.Tag == null || label.Tag.ToString() == "")
            {
                label.Font = LabelFont;
                label.ForeColor = ColorTextoOscuro;
            }
        }

        private static void EstiloMenuStrip(MenuStrip menu)
        {
            menu.BackColor = ColorBarra;
            menu.ForeColor = Color.White;
        }

        private static void EstiloStatusStrip(StatusStrip strip)
        {
            strip.BackColor = ColorBarra;
            strip.ForeColor = Color.White;
        }

        private static void EstiloGridView(DataGridView grid)
        {
            grid.Font = LabelFont;
            grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.AllowUserToAddRows = false;
            grid.AllowUserToDeleteRows = false;
            grid.AllowUserToOrderColumns = false;
            grid.MultiSelect = false;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.ShowEditingIcon = false;
            grid.ReadOnly = true;
        }

        private static void EstiloPlanel(Panel panel)
        {
            panel.BackColor = ColorFondo;
        }

    }
}
