using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectFonal
{
    public partial class ctrUsEmpleado : UserControl
    {
        //Llamamos la clase conexion
        clsConexion cn = new clsConexion();

        public ctrUsEmpleado()
        {
            InitializeComponent();
            //Inicializamos el boton
            btnBuscarEmpleado.Enabled = false;

            //Metodos para tener los datos actualizados
            refrescarcombobox();
            //Metodo para tener los datos actualizados
            refrescardatagrid();

        }

        #region BLOQUE BUSCAR EMPLEADO

        private void btnBuscarEmpleado_Click(object sender, EventArgs e)
        {
            string Abuscar = cboBuscarEmpleado.Text;

            try
            {
                //Seleccionamos un empleado en especifico  guardado en la BD para mostrarlos en un datagridview
                string TraerTodo = "SELECT * FROM tblEmpleado WHERE strNombre = '" + Abuscar + "'";
                //Mostramos en el datagrid
                dtgvProveedor.DataSource = cn.mostrarTabla(TraerTodo);
                
                //Metodos para tener los datos actualizados
                refrescarcombobox();
                //Método para limpiar
                limpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se encontro tal empleado " + ex);
            }
        }

        #endregion


        #region BLOQUE REGISTRAR EMPLEADO

        private void txtIdentificacionEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtDireccionEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCargoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void txtNombreUsuarioEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se carácteres
            if (!char.IsLetter(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtContraEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // El caracter de la contraseña
            txtContraEmpleado.PasswordChar = '*';

            // Tamaño de la contraseña.
            txtContraEmpleado.MaxLength = 8;
        }


        private void btnGuardarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpleado.Text != "" && txtApellidoEmpleado.Text != "" && txtTelefonoEmpleado.Text != "" & txtIdentificacionEmpleado.Text != "" & txtDireccionEmpleado.Text !="" & txtCargoEmpleado.Text != "" & txtNombreUsuarioEmpleado.Text != "" & txtContraEmpleado.Text != "")
            {

                try
                {
                    string GuardarEmpleado = "INSERT INTO tblEmpleado([idCedula],[strNombre],[strApellido],[intTelefono],[strDireccion],[strCargo],[strUsuario],[strContra])" + 
                        "values('" + txtIdentificacionEmpleado.Text + "','" + txtNombreEmpleado.Text + "','" + txtApellidoEmpleado.Text + "','" + txtTelefonoEmpleado.Text + "','"+txtDireccionEmpleado.Text+ "','"+ txtCargoEmpleado.Text+"','"+txtNombreUsuarioEmpleado.Text+"','"+txtContraEmpleado.Text+"')";
                    cn.conectarComando(GuardarEmpleado);

                    //Metodos para tener los datos actualizados
                    refrescarcombobox();
                    //Metodo para tener los datos actualizados
                    refrescardatagrid();

                    //Método para limpiar
                    limpiarCampos();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se guardo la informacion " + ex.Message);

                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
        }
        #endregion

        #region BLOQUE MODIFICAR

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //Mostramos y ocultar panel necesarios          
            if (pnlModificarEmpleado.Visible == false)
            {
                pnlModificarEmpleado.Visible = true;
            }
            else
            {
                pnlModificarEmpleado.Visible = false;
            }
            pnlEliminarEmpleado.Visible = false;
        }

        private void txtModificarIdentificacionEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarNombreEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtModificarApellidoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtModificarDireccionEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {


        }

        private void txtModificarTelefonoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen letras
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtModificarCargoEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se ingresen números
            if (!char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }

        }

        private void txtModificarNombreUsuarioEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Para evitar que se carácteres
            if (!char.IsLetterOrDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;

            }
        }

        private void txtModificarContraEmpleado_KeyPress(object sender, KeyPressEventArgs e)
        {
            // El caracter de la contraseña
            txtModificarContraEmpleado.PasswordChar = '*';

            // Tamaño de la contraseña.
            txtModificarContraEmpleado.MaxLength = 8;
        }
        private void btnModificarEmpleado_Click(object sender, EventArgs e)
        {
            if (txtModificarNombreEmpleado.Text != "" & txtModificarApellidoEmpleado.Text != "" & txtModificarIdentificacionEmpleado.Text != "" & txtModificarDireccionEmpleado.Text != "" & txtModificarTelefonoEmpleado.Text != "" & txtModificarCargoEmpleado.Text !="" & txtModificarNombreUsuarioEmpleado.Text !="" & txtModificarContraEmpleado.Text != "")
            {

                try
                {
                    //Para mosdificar el proveedor
                    string Modificar = cboModificarEmpleado.Text;
                    string ModificarEmpleado = "UPDATE tblEmpleado set idCedula ='" + txtModificarIdentificacionEmpleado.Text + "' ,strNombre = '" + txtModificarNombreEmpleado.Text + "',strApellido = '" + txtModificarApellidoEmpleado.Text + "',intTelefono = '" + txtModificarTelefonoEmpleado.Text + "', " +
                        "strDireccion = '" + txtModificarDireccionEmpleado.Text + "', strCargo = '"+txtModificarCargoEmpleado.Text +"',strUsuario = '"+txtModificarNombreUsuarioEmpleado.Text+ "',strContra = '" + txtModificarContraEmpleado.Text + "' WHERE strNombre = '" + Modificar + "'" ;
                    cn.conectarComando(ModificarEmpleado);

                    //Metodos para tener los datos actualizados
                    refrescarcombobox();
                    //Metodo para tener los datos actualizados
                    refrescardatagrid();
                    //Limpiamos los textbox
                    limpiarCampos();

                    //Cerramos el panel
                    pnlModificarEmpleado.Visible = false;
                }
                catch (Exception ex)
                {

                    MessageBox.Show("No se pudo modificar los datos" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
        }

        private void btnCancelarModificarEmpleado_Click(object sender, EventArgs e)
        {
            //Cerramos el panel
            pnlModificarEmpleado.Visible = false;
        }
        #endregion


        #region BLOQUE ELIMINAR
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //Mostramos y ocultar panel necesarios
            if (pnlEliminarEmpleado.Visible == false)
            {
                pnlEliminarEmpleado.Visible = true;
            }
            else
            {
                pnlEliminarEmpleado.Visible = false;
            }
            pnlModificarEmpleado.Visible = false;
        }

        private void btnEliminarEmpleado_Click(object sender, EventArgs e)
        {
            try
            {
                //Para borrar el proveedor
                string Abuscar = cboEliminarEmpleado.Text;
                string BorrarEmpleado = "DELETE FROM tblEmpleado Where strNombre='" + Abuscar + "'";
                cn.conectarComando(BorrarEmpleado);

                //Metodos para tener los datos actualizados
                refrescarcombobox();
                //Metodos para tener los datos actualizados
                refrescardatagrid();

                //Cerramos el panel
                pnlEliminarEmpleado.Visible = false;

            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo eliminar el proveedor" + ex.Message);

            }
        }

        private void btnCancelarEliminarEmpleado_Click(object sender, EventArgs e)
        {
            //Cerramos el panel
            pnlEliminarEmpleado.Visible = false;
        }
        #endregion

        //Para limpiar los campos
        public void limpiarCampos()
        {

            //Registro
            txtIdentificacionEmpleado.Clear();
            txtNombreEmpleado.Clear();
            txtApellidoEmpleado.Clear();
            txtDireccionEmpleado.Clear();
            txtTelefonoEmpleado.Clear();
            txtCargoEmpleado.Clear();
            txtNombreUsuarioEmpleado.Clear();
            txtContraEmpleado.Clear();
            //Modificar
            txtModificarIdentificacionEmpleado.Clear();
            txtModificarNombreEmpleado.Clear();
            txtModificarApellidoEmpleado.Clear();
            txtModificarDireccionEmpleado.Clear();
            txtModificarTelefonoEmpleado.Clear();
            txtModificarCargoEmpleado.Clear();
            txtModificarNombreUsuarioEmpleado.Clear();
            txtModificarContraEmpleado.Clear();
        }

    

        private void refrescarcombobox()
        {
            //Llenamos los comboboxes
            try
            {
                string BuscarProveedor = "SELECT idCedula,strNombre FROM tblEmpleado ";
                cboBuscarEmpleado.DataSource = cn.mostrarTabla(BuscarProveedor);
                //Para mostrar en el Combo los nombres
                cboBuscarEmpleado.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboBuscarEmpleado.ValueMember = "idCedula";

                string EliminarProveedor = "SELECT idCedula,strNombre FROM tblEmpleado ";
                cboEliminarEmpleado.DataSource = cn.mostrarTabla(EliminarProveedor);
                //Para mostrar en el Combo los nombres
                cboEliminarEmpleado.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboEliminarEmpleado.ValueMember = "idCedula";

                string ModificarProveedor = "SELECT idCedula,strNombre FROM tblEmpleado ";
                cboModificarEmpleado.DataSource = cn.mostrarTabla(ModificarProveedor);
                //Para mostrar en el Combo los nombres
                cboModificarEmpleado.DisplayMember = "strNombre";
                //Para utilizar el nit al momento de hacer la consulta
                cboModificarEmpleado.ValueMember = "idCedula";

            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo elimar al proveedor" + ex.Message);

            }
        }

        private void refrescardatagrid()
        {

            //Mantenemos el datagrid refrescado
            try
            {
                //Mantenemos la tabla refrescada               
                string mostrarTabla = "SELECT idCedula,strNombre,strApellido,intTelefono,strDireccion,strCargo,strUsuario,strContra from tblEmpleado";
                //Llenamos el datagrid con la información
                dtgvProveedor.DataSource = cn.mostrarTabla(mostrarTabla);
            }
            catch (Exception ex)
            {

                MessageBox.Show("No se pudo mostrar la información en el " + dtgvProveedor + "" + ex.Message);
            }

        }

        private void cboBuscarEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Habilitamos el btnBuscarProveedor cuando escojan alguna opcion
            if (true)
            {
                btnBuscarEmpleado.Enabled = true;
            }
            else
            {
                //btnBuscarProveedor.Enabled = false;
            }
        }

        private void pnlModificarEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }


       
    }
}
