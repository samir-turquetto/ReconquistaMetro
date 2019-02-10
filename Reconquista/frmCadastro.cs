using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reconquista
{
    public partial class frmCadastro : MetroFramework.Forms.MetroForm
    {
        Cliente cliente = new Cliente();
        Cliente_Bem clienteBem = new Cliente_Bem();
        Bem bem = new Bem();
        Telefone telefone = new Telefone();
        Anexo anexo = new Anexo();
        List<Telefone> telefones = new List<Telefone>();
        List<Bem> bens = new List<Bem>();
        List<Anexo> anexos = new List<Anexo>();
        List<Cliente_Bem> cliente_Bens = new List<Cliente_Bem>();
        int numero;

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void mcbTipoPessoa(object sender, EventArgs e)
        {
            if (mcbTipoCli.SelectedIndex == 0)
            {
                lblRGIE.Text = "R.G.";
                lblCPFCPNJ.Text = "C.P.F.*";
                mtbRGIE.Text = "";
                mtbCPFCNPJ.Text = "";
            }
            if (mcbTipoCli.SelectedIndex == 1)
            {
                lblRGIE.Text = "Inscrição Estadual";
                lblCPFCPNJ.Text = "C.N.P.J*";
                mtbRGIE.Text = "";
                mtbCPFCNPJ.Text = "";
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            numero = 0;
            mcbTipoCli.SelectedIndex = 0;
            metroTabControl1.SelectedIndex = 0;
            limpaTela();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex > 0)
            {
                metroTabControl1.SelectedIndex = metroTabControl1.SelectedIndex - 1;
            }
        }

        private void btnProximo_Click(object sender, EventArgs e)
        {
            if (metroTabControl1.SelectedIndex < 2)
            {
                metroTabControl1.SelectedIndex = metroTabControl1.SelectedIndex + 1;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpaTela();

        }

        void limpaTela()
        {
            mtbBem.Text = mtbCodBem.Text = mtbCodCli.Text = mtbContato.Text = mtbCPFCNPJ.Text =
                mtbEmail.Text = mtbNomeCli.Text = mtbPlaca.Text =
                mtbRGIE.Text = mtbTelefone.Text = rtbObsBem.Text =
                rtbObsCli.Text = "";
            mgContato.Rows.Clear();
            mgAnexo.Rows.Clear();
            btnRemoveContato.Enabled = false;
            btnRemoveAnexo.Enabled = false;
            btnCancelar.Enabled = false;
            btnRemoveBem.Enabled = false;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                cliente.ID_cli = 0;
                cliente.Nome_cli = mtbNomeCli.Text.Trim();
                cliente.Tipo_cli = mcbTipoCli.SelectedIndex.ToString();
                cliente.RG_IE_cli = mtbRGIE.Text.Trim();
                cliente.Email_cli = mtbEmail.Text.Trim();
                cliente.Obs_cli = rtbObsCli.Text;                
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            using (ReconquistaEntities db = new ReconquistaEntities())
            {
                db.Cliente.Add(cliente);                
                
                foreach (Bem bem in bens)
                {
                    bem.ID_cli = cliente.ID_cli;
                    db.Bem.Add(bem);                    
                }
                foreach (Cliente_Bem cb in cliente_Bens)
                {
                    cb.ID_cli = cliente.ID_cli;
                    cb.ID_bem = bem.ID_bem;
                    db.Cliente_Bem.Add(cb);                
                }
                foreach (Anexo att in anexos)
                {
                    att.ID_bem = bem.ID_bem;
                    db.Anexo.Add(att);
                    db.SaveChanges();
                }
                foreach (Telefone telefone in telefones)
                {
                    telefone.ID_cli = cliente.ID_cli;                   
                    db.Telefone.Add(telefone);
                    db.SaveChanges();
                }


            }
            limpaTela();
            MessageBox.Show("Cadastro efetuado com sucesso!");
        }

        void populaGridContato()
        {
            mgContato.AutoGenerateColumns = false;
            using (ReconquistaEntities db = new ReconquistaEntities())
            {
                mgContato.DataSource = db.Telefone.ToList<Telefone>();
            }
        }

        void populaGridAnexo()
        {
            mgAnexo.AutoGenerateColumns = false;
            using (ReconquistaEntities db = new ReconquistaEntities())
            {
                mgAnexo.DataSource = db.Anexo.ToList<Anexo>();
            }
        }

        private void mtbCPFCNPJ_Leave(object sender, EventArgs e)
        {
            if (mtbCPFCNPJ.Text == "")
                return;

            if (mcbTipoCli.SelectedIndex == 0 && mtbCPFCNPJ.Text.Count() == 11)
            {
                try
                {

                    if (validaCpf(mtbCPFCNPJ.Text))
                    {
                        mtbCPFCNPJ.Text = Convert.ToUInt64(mtbCPFCNPJ.Text).ToString(@"000\.000\.000\-00");
                    }
                    else
                    {
                        MessageBox.Show("CPF invalido!");
                        mtbCPFCNPJ.Text = "";
                        mtbCPFCNPJ.Focus();
                        mtbCPFCNPJ.Select();
                    }
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    mtbCPFCNPJ.Text = "";
                    mtbCPFCNPJ.Focus();
                    mtbCPFCNPJ.Select();
                }

            }
            else if (mcbTipoCli.SelectedIndex == 1 && mtbCPFCNPJ.Text.Count() == 14)
            {
                try
                {
                    mtbCPFCNPJ.Text = Convert.ToUInt64(mtbCPFCNPJ.Text).ToString(@"00\.000\.000/0000\-00");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    mtbCPFCNPJ.Text = "";
                    mtbCPFCNPJ.Focus();
                    mtbCPFCNPJ.Select();
                }

            }
            else
            {
                MessageBox.Show("Formato inválido, por favor verifique.");
                mtbCPFCNPJ.Text = "";
                mtbCPFCNPJ.Focus();
                mtbCPFCNPJ.Select();
            }

            cliente.CPF_CNPJ_cli = mtbCPFCNPJ.Text.Trim();

        }

        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            if (mtbTelefone.Text.Count() == 11)
            {
                try
                {
                    mtbTelefone.Text = Convert.ToUInt64(mtbTelefone.Text).ToString(@"\(00\) 00000\-0000");
                }
                catch (Exception erro)
                {
                    MessageBox.Show(erro.Message);
                    mtbTelefone.Text = "";
                    mtbTelefone.Focus();
                    mtbTelefone.Select();
                }
            }
            else if (mtbTelefone.Text.Count() == 10)
            {
                try
                {
                    mtbTelefone.Text = Convert.ToUInt64(mtbTelefone.Text).ToString(@"\(00\) 0000\-0000");
                }
                catch (Exception erro)
                {
                    mtbTelefone.Text = "";
                    MessageBox.Show(erro.Message);
                    mtbTelefone.Text = "";
                    mtbTelefone.Focus();
                    mtbTelefone.Select();
                }
            }
            else
            {
                mtbTelefone.Text = "";
            }


        }

        private void mtbCPFCNPJ_Enter(object sender, EventArgs e)
        {
            if (mcbTipoCli.SelectedIndex == 0 && mtbCPFCNPJ.Text.Count() == 14)
            {
                mtbCPFCNPJ.Text = mtbCPFCNPJ.Text.Replace("-", "");
                mtbCPFCNPJ.Text = mtbCPFCNPJ.Text.Replace(".", "");
            }
            else if (mcbTipoCli.SelectedIndex == 1 && mtbCPFCNPJ.Text.Count() == 18)
            {
                mtbCPFCNPJ.Text = mtbCPFCNPJ.Text.Replace("-", "");
                mtbCPFCNPJ.Text = mtbCPFCNPJ.Text.Replace(".", "");
                mtbCPFCNPJ.Text = mtbCPFCNPJ.Text.Replace("/", "");

            }
        }

        private void btnAddContato_Click(object sender, EventArgs e)
        {
            if (mtbContato.Text != "" && mtbTelefone.Text != "")
            {
                var telefone = new Telefone();
                telefone.Contato_tel = mtbContato.Text;
                telefone.Telefone1 = mtbTelefone.Text;

                telefones.Add(telefone);
                mgContato.Rows.Add(telefone.Contato_tel, telefone.Telefone1);

                mtbContato.Text = mtbTelefone.Text = "";
                btnRemoveContato.Enabled = true;
            }

        }

        private void btnRemoveContato_Click(object sender, EventArgs e)
        {
            telefones.Remove(telefone);
            mgContato.Rows.Remove(mgContato.CurrentRow);
            if (mgContato.Rows.Count < 1)
            {
                btnRemoveContato.Enabled = false;
            }
        }

        public static bool validaCpf(string cpf)
        {
            int[] multiplicador1 = new int[9] { 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] multiplicador2 = new int[10] { 11, 10, 9, 8, 7, 6, 5, 4, 3, 2 };
            string tempCpf;
            string digito;
            int soma;
            int resto;
            cpf = cpf.Trim();
            cpf = cpf.Replace(".", "").Replace("-", "");
            if (cpf.Length != 11)
                return false;
            tempCpf = cpf.Substring(0, 9);
            soma = 0;

            for (int i = 0; i < 9; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador1[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = resto.ToString();
            tempCpf = tempCpf + digito;
            soma = 0;
            for (int i = 0; i < 10; i++)
                soma += int.Parse(tempCpf[i].ToString()) * multiplicador2[i];
            resto = soma % 11;
            if (resto < 2)
                resto = 0;
            else
                resto = 11 - resto;
            digito = digito + resto.ToString();
            return cpf.EndsWith(digito);
        }

        private void mbtPreencher_Click(object sender, EventArgs e)
        {    
            numero += 1;
            mtbBem.Text = $"bem teste {numero}";
            mtbCPFCNPJ.Text = "12345678909";
            mtbNomeCli.Text = $"Teste {numero}";
            mtbContato.Text = $"Teste {numero}";
            mtbTelefone.Text = "11123456789";
        }

        public static string RetiraMascara(string Codigo)
        {
            return Codigo.Replace(".", string.Empty).Replace("-", string.Empty).Replace("/", string.Empty);
        }

        private void btnAddBem_Click(object sender, EventArgs e)
        {
            if (mtbBem.Text != "")
            {
                var bem = new Bem();
                bem.Nome_bem = mtbBem.Text;
                bem.Placa_bem = mtbPlaca.Text;
                bem.Obs_bem = rtbObsBem.Text;
                 
                bens.Add(bem);

                var clienteBem = new Cliente_Bem();
                clienteBem.Dta_vigencia = DateTime.ParseExact(dtpVigencia.Text, "dd/MM/yyyy",System.Globalization.CultureInfo.InvariantCulture);

                cliente_Bens.Add(clienteBem);

                mgBem.Rows.Add(bem.Nome_bem, bem.Placa_bem, clienteBem.Dta_vigencia.ToString("dd/MM/yyyy"));                

                mtbBem.Text = mtbPlaca.Text = rtbObsBem.Text = "";

                btnRemoveBem.Enabled = true;
            }
        }

        private void btnAddAnexo_Click(object sender, EventArgs e)
        {
            OpenFileDialog arquivo = new OpenFileDialog();
            var anexo = new Anexo();

            if (arquivo.ShowDialog() == DialogResult.OK)
            {
                var sample = new FileInfo(arquivo.FileName);
                if (sample.Exists) {
                    anexo.Arquivo_anexo = new byte[sample.Length];
                    anexo.Nome_Arquivo = sample.Name;
                    anexo.Ext_Arquivo = sample.Extension;
                    anexos.Add(anexo);
                    mgAnexo.Rows.Add(anexo.Nome_Arquivo);
                    btnRemoveAnexo.Enabled = true;
                }
            }           
        }

        private void btnRemoveAnexo_Click(object sender, EventArgs e)
        {
            anexos.Remove(anexo);
            mgAnexo.Rows.Remove(mgAnexo.CurrentRow);
            if (mgAnexo.Rows.Count < 1)
            {
                btnRemoveAnexo.Enabled = false;
            }
        }

        private void btnRemoveBem_Click(object sender, EventArgs e)
        {
            bens.Remove(bem);
            cliente_Bens.Remove(clienteBem);
            mgBem.Rows.Remove(mgBem.CurrentRow);
            if (mgBem.Rows.Count < 1)
            {
                btnRemoveBem.Enabled = false;
            }
        }
    }
}

