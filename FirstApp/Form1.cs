using BibliotecaPOE;

namespace FirstApp
{
    public partial class Form1 : Form
    {
        List<Estudiante> ListaEstudiante = new List<Estudiante>(); // Create a new list of ListaEstudiante
        List<Estudiante> ListaBorrados = new List<Estudiante>(); // Create a new list of ListaBorrados

        public Form1()
        {
            InitializeComponent();
        }

        public void AgregarDatos()
        {
            Estudiante objEstudiante = new Estudiante(); // create new object estudiante
            objEstudiante.Cedula = txtCedula.Text.Trim();
            objEstudiante.Apellido = txtApellido.Text.Trim();
            objEstudiante.Nombre = txtNombre.Text.Trim();
            objEstudiante.Carrera = cmbCarrera.Text.Trim();

            ListaEstudiante.Add(objEstudiante);

            ListViewItem itemAlumno = new ListViewItem();
            itemAlumno = lvLista.Items.Add(objEstudiante.Cedula);
            itemAlumno.SubItems.Add(objEstudiante.Apellido);
            itemAlumno.SubItems.Add(objEstudiante.Nombre);
            itemAlumno.SubItems.Add(objEstudiante.Carrera);

            txtCedula.Text = String.Empty;
            txtApellido.Text = String.Empty;
            txtNombre.Text = String.Empty;
            cmbCarrera.Text = String.Empty;
        }

        private void lvLista_DoubleClick(object sender, EventArgs e)
        {
            if (lvLista.SelectedItems.Count > 0)
            {
                ListViewItem itemSel = lvLista.SelectedItems[0];
                MessageBox.Show(
                    this,
                    itemSel.Text
                        + " "
                        + itemSel.SubItems[1].Text
                        + " "
                        + itemSel.SubItems[2].Text
                        + " "
                        + itemSel.SubItems[3].Text,
                    "Sistema POE",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                this,
                "Esta seguro de agregar estos datos?",
                "Agregar Datos",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );
            if (dr == DialogResult.Yes)
            {
                AgregarDatos();
            }
        }

        public void ActualizarDatos()
        {
            ListaEstudiante.Clear(); // Clear list ListaEstudiante
            foreach (ListViewItem itemAlumno in lvLista.Items) // foreach of items from list
            {
                Estudiante objEstudiante = new Estudiante();
                objEstudiante.Cedula = itemAlumno.Text;
                objEstudiante.Apellido = itemAlumno.SubItems[1].Text;
                objEstudiante.Nombre = itemAlumno.SubItems[2].Text;
                objEstudiante.Carrera = itemAlumno.SubItems[3].Text;
                ListaEstudiante.Add(objEstudiante); // add the new item to the list
            }
        }

        public void EliminarDatos()
        {
            ListViewItem itemSel = lvLista.SelectedItems[0]; // get the selected item

            Estudiante objEstudiante = new Estudiante();
            objEstudiante.Cedula = itemSel.Text;
            objEstudiante.Apellido = itemSel.SubItems[1].Text;
            objEstudiante.Nombre = itemSel.SubItems[2].Text;
            objEstudiante.Carrera = itemSel.SubItems[3].Text;

            ListaBorrados.Add(objEstudiante); // save that item in list ListaBorrados
            lvLista.Items.Remove(itemSel); // delete selected item from listview
            ActualizarDatos(); // update the list
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            EliminarDatos(); // delete selected item from listview
        }

        private void btnVerEliminar_Click(object sender, EventArgs e)
        {
            lvLista.Items.Clear(); // clear listview
            ListViewItem itemAlumno = new ListViewItem();
            foreach (Estudiante item in ListaBorrados) // add items from ListaBorrados to listview
            {
                itemAlumno = lvLista.Items.Add(item.Cedula);
                itemAlumno.SubItems.Add(item.Apellido);
                itemAlumno.SubItems.Add(item.Nombre);
                itemAlumno.SubItems.Add(item.Carrera);
            }
        }

        private void btnVerAgregados_Click(object sender, EventArgs e)
        {
            lvLista.Items.Clear(); // clear listview
            ListViewItem itemAlumno = new ListViewItem();
            foreach (Estudiante item in ListaEstudiante) // add items from ListaEstudiante to listview
            {
                itemAlumno = lvLista.Items.Add(item.Cedula);
                itemAlumno.SubItems.Add(item.Apellido);
                itemAlumno.SubItems.Add(item.Nombre);
                itemAlumno.SubItems.Add(item.Carrera);
            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsDigit(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Space
            );
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsLetter(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Space
            );
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsLetter(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Space
            );
        }

        private void cmbCarrera_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(
                char.IsLetter(e.KeyChar)
                || e.KeyChar == (char)Keys.Back
                || e.KeyChar == (char)Keys.Space
            );
        }
    }
}
