using System.Diagnostics.Eventing.Reader;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        conexion1 objconexion = new conexion1();
        public Form1()

        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
        private void estadoControles(Boolean estado)
        {
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "Nuevo")
            {
                button5.Text = "Guardar";
                button6.Text = "Cancel";
                estadoControles(true);
            }
            else
            { //Guardar 

                button5.Text = "Nuevo";
                button6.Text = "Cancelar";
                estadoControles(false);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "modificar")
            {
                button6.Text = "modificar";
                button6.Text = "Cancel";
                estadoControles(true);
            }
            else
            { //Cancelar 

                button5.Text = "Nuevo";
                button6.Text = "modificar";
                estadoControles(false);
            }
            }

    }
}
