using System;
using System.Windows.Forms;

namespace Cantina
{
    public partial class frmPesquisar : Form
    {
        public frmPesquisar()
        {
            InitializeComponent();
        }

        private void rdbCodigo_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();

        }

        private void rdbNome_CheckedChanged(object sender, EventArgs e)
        {
            txtDescricao.Enabled = true;
            txtDescricao.Focus();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (rdbCodigo.Checked)
            {
                if (!txtDescricao.Text.Equals(""))

                {
                    ltbPesquisar.Items.Clear();
                    ltbPesquisar.Items.Add(txtDescricao.Text);

                }

                else
                {
                    MessageBox.Show("digitae, burro :(");
                    txtDescricao.Focus();



                }

            }

            if (rdbNome.Checked)
            {
                if (!txtDescricao.Text.Equals(""))

                {
                    ltbPesquisar.Items.Clear();
                    ltbPesquisar.Items.Add(txtDescricao.Text);

                }

            }
        }

        public void limparCampos()
        {

            txtDescricao.Clear();
            rdbCodigo.Checked = false;
            rdbNome.Checked = false;
            ltbPesquisar.Items.Clear();
            txtDescricao.Enabled = true;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
