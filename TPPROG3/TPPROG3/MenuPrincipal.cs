﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPPROG3
{
 public partial class menu_principal : Form
 {
  public menu_principal()
  {
   InitializeComponent();
  }

  private void salirToolStripMenuItem_Click(object sender, EventArgs e)
  {
   Close();
  }

  private void menu_principal_Load(object sender, EventArgs e)
  {

  }

  private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
  {
   AcercaDe Acerca = new AcercaDe();
   Acerca.Show();
  }

  private void agregarEquipoToolStripMenuItem_Click(object sender, EventArgs e)
  {

  }

  private void modificarDatosToolStripMenuItem1_Click(object sender, EventArgs e)
  {

  }

  private void porIDToolStripMenuItem_Click(object sender, EventArgs e)
  {

  }

  private void porNDeSerieToolStripMenuItem_Click(object sender, EventArgs e)
  {

  }

  private void verListadoToolStripMenuItem1_Click(object sender, EventArgs e)
  {

  }

        private void agregarClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void modificarDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
