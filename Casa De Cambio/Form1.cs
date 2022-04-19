using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Integrantes: jose julian berrio uribe, juan manuel torres, stiven molina 
///
/// </summary>

namespace Casa_De_Cambio
{ 
    public partial class frmCasadeCambio : Form
    {
        public frmCasadeCambio()
        {
            InitializeComponent();
            
            cmbCiudad.Items.Add("New York");
            cmbCiudad.Items.Add("Medellin");
            cmbCiudad.Items.Add("Los Angeles");
            cmbCiudad.Items.Add("Monterrey");
            cmbCiudad.Items.Add("Bogota");
            cmbCiudad.Items.Add("Barranquilla");
            cmbCiudad.Items.Add("Madrid");
            cmbCiudad.Items.Add("Barcelona");
            cmbCiudad.Items.Add("Acapulco");
            cmbCiudad.Items.Add("Cali");

            cmbMonedaDestino.Items.Add("Euro");
            cmbMonedaDestino.Items.Add("Peso chileno");
            cmbMonedaDestino.Items.Add("Peso Colombiano");
            cmbMonedaDestino.Items.Add("Dolar");


            cmbMonedaOrigen.Items.Add("Euro");
            cmbMonedaOrigen.Items.Add("Peso chileno");
            cmbMonedaOrigen.Items.Add("Peso Colombiano");
            cmbMonedaOrigen.Items.Add("Dolar");



        }

       

        private void frmCasadeCambio_FormClosed(object sender, FormClosedEventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Realmente deseas salir?", "Confirmacion",
          MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            double cantidadCambio;
            string Cantidadcambio = txtCantidadCambiar.Text;
            cantidadCambio = Convert.ToDouble(Cantidadcambio);
            String monedaOrigen = cmbMonedaOrigen.Text;
            string monedaDestino = cmbMonedaDestino.Text;


            if (monedaOrigen == "Dolar" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double dolar = 3732;

                resultado = dinero * dolar;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Dolar" & monedaDestino == "Peso chileno")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double dolar = 816.59;

                resultado = dinero * dolar;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Dolar" & monedaDestino == "Euro")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double dolar = 0.93;

                resultado = dinero * dolar;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Dolar")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double dolar = 3732;

                resultado = dinero / dolar;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }
            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Euro")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double euro = 4022;

                resultado = dinero / euro;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Peso chileno")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double pesochileno = 816.59;

                resultado = dinero / pesochileno;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Euro" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double euro = 3732;

                resultado = dinero * euro;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }
            if (monedaOrigen == "Euro" & monedaDestino == "Dolar")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double euro = 0.93;

                resultado = dinero / euro;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Euro" & monedaDestino == "Peso chileno")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double euro = 21.36;

                resultado = dinero * euro;
               txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Peso chileno" & monedaDestino == "Euro")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double euro = 879.69;

                resultado = dinero / euro;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }
            if (monedaOrigen == "Peso chileno" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double pesochileno = 216.69;

                resultado = dinero * pesochileno;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }


            if (monedaOrigen == "Peso chileno" & monedaDestino == "Dolar")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado;
                double dolar = 816.59;

                resultado = dinero / dolar;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }


            if (monedaOrigen == "Dolar" & monedaDestino == "Dolar")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado = dinero;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Euro" & monedaDestino == "Euro")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado = dinero;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Peso Colombiano" & monedaDestino == "Peso Colombiano")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado = dinero;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }

            if (monedaOrigen == "Peso chileno" & monedaDestino == "Peso chileno")
            {

                string vr = txtCantidadCambiar.Text;
                double dinero = Convert.ToDouble(vr);
                double resultado = dinero;
                txtValordelCanje.Text = Convert.ToString(resultado);

            }



        }

       





        

        

        private void btnSalir_Click_1(object sender, EventArgs e)
        {
            DialogResult Resultado = MessageBox.Show("¿Quieres salir?", "Confirmacion",
       MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            this.Close();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            rbdBTC.Checked = false;
            rbdCheque.Checked = false;
            rbdEfectivo.Checked = false;
            rbdTransferencia.Checked = false;

            txtCantidadCambiar.Text = "";
            txtValordelCanje.Text = "";
            txtDirección.Text = "";
            txtNombre.Text = "";
            txtTelefono.Text = "";
            txtApellido.Text = "";


            cmbCiudad.Text = "";
            cmbMonedaDestino.Text = "";
            cmbMonedaOrigen.Text = "";


        }
       
           

        private void btnRECIBO_Click(object sender, EventArgs e)
        {
                string nombre = txtNombre.Text;
                string apellido = txtApellido.Text;
                string ciudad = cmbCiudad.Text;
                string telefono = txtTelefono.Text;
                string direccion = txtDirección.Text;
                string Monedaorigen = cmbMonedaOrigen.Text;
                string Monedadestino = cmbMonedaDestino.Text;
                string dinero= txtCantidadCambiar.Text;
                string resultado = txtValordelCanje.Text;
                string radiob;

                if (rbdBTC.Checked == true)
                {
                   radiob = "BTC";

                    MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {Monedaorigen} \r Moneda Destino: {Monedadestino} \r Medio de Pago: {radiob} \r Valor a Cambiar: {dinero} \r Valor del Canje: {resultado} \r\r\r Gracias por utilizar nuestro servicio. ");
                }

                if (rbdCheque.Checked == true)
                {
                   radiob = "Cheque";

                    MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {Monedaorigen} \r Moneda Destino: {Monedadestino} \r Medio de Pago: {radiob} \r Valor a Cambiar: {dinero} \r Valor del Canje: {resultado} \r\r\r Gracias por utilizar nuestro servicio. ");
                }

                if (rbdEfectivo.Checked == true)
                {
                   radiob = "Efectivo";

                    MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {Monedaorigen} \r Moneda Destino: {Monedadestino} \r Medio de Pago: {radiob} \r Valor a Cambiar: {dinero} \r Valor del Canje: {resultado} \r\r\r Gracias por utilizar nuestro servicio. ");
                }
                if (rbdTransferencia.Checked == true)
                {
                   radiob = "Transferencia";

                    MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                   $"\r\r Datos Transacción \r\r Moneda de Origen: {Monedaorigen} \r Moneda Destino: {Monedadestino} \r Medio de Pago: {radiob} \r Valor a Cambiar: {dinero} \r Valor del Canje: {resultado} \r\r\r Gracias por utilizar nuestro servicio. ");
                }
                else
                {
                    MessageBox.Show($"Recibo de Transaccion \r\r\r Datos Personales \r\r Nombre: {nombre} \r Apellido: {apellido} \r Ciudad: {ciudad} \r Direccion: {direccion} \r" +
                    $"\r\r Datos Transacción \r\r Moneda de Origen: {Monedaorigen} \r Moneda Destino: {Monedadestino} \r Medio de Pago: No definido \r Valor a Cambiar: {dinero} \r Valor del Canje: {resultado} \r\r\r Gracias por utilizar nuestro servicio. ");
                }



            
        }
    }
}