using salaoBeleza.Desktop.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace salaoBeleza.Desktop;

public partial class FormDashboard : Form
{
    private Usuario _usuario;
    public FormDashboard(Usuario usuario)
    {
       this._usuario = usuario;
        InitializeComponent();
    }

    private void pnlAgendar_Paint(object sender, PaintEventArgs e)
    {

    }

    private void lblSub_Click(object sender, EventArgs e)
    {

    }
}
