﻿using System.Windows.Forms;

namespace WindowsFormsAppPrincipal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click(object sender, System.EventArgs e)
        {
            using (FormBuscarUsuario frm = new FormBuscarUsuario())
            {
                frm.ShowDialog();
            }
        }

        private void FormPrincipal_Load(object sender, System.EventArgs e)
        {

        }

        private void cadastroToolStripMenuItem_Click(object sender, System.EventArgs e)
        {

        }
    }
}
