using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace postgres
{
    public partial class trabajadoresForm : Form
    {
        public trabajadoresForm()
        {
            InitializeComponent();
        }

        private void trabajadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.trabajadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.postgresDataSet);

        }

        private void trabajadoresForm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'postgresDataSet.trabajadores' Puede moverla o quitarla según sea necesario.
            this.trabajadoresTableAdapter.Fill(this.postgresDataSet.trabajadores);

        }
    }
}
