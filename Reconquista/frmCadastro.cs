﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        List<Contato> contatos = new List<Contato>();
        Contato contato = new Contato();

        public frmCadastro()
        {
            InitializeComponent();
        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
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
            mtbBem.Text = mtbCodBem.Text = mtbCodCli.Text = mtbContato.Text = mtbCPFCNPJ.Text = mtbEmail.Text = mtbNomeCli.Text = mtbPlaca.Text
                = mtbRGIE.Text = mtbTelefone.Text = rtbObsBem.Text = rtbObsCli.Text = "";
            btnCancelar.Enabled = false;
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

                bem.ID_bem = 0;
                bem.Nome_bem = mtbBem.Text.Trim();
                bem.Placa_bem = mtbPlaca.Text.Trim();
                bem.Obs_bem = rtbObsBem.Text;

                clienteBem.Dta_vigencia = DateTime.Parse(dtpVigencia.Text);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

            using (ReconquistaEntities db = new ReconquistaEntities())
            {
                db.Cliente.Add(cliente);
                db.Bem.Add(bem);
                db.Cliente_Bem.Add(clienteBem);
                db.Telefone.Add(telefone);
                db.SaveChanges(); 
            }
            limpaTela();
            // populaGridContato();
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

        private void mtbCPFCNPJ_Leave(object sender, EventArgs e)
        {
            cliente.CPF_CNPJ_cli = mtbCPFCNPJ.Text.Trim();

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

        }

        private void mtbTelefone_Leave(object sender, EventArgs e)
        {
            telefone.Telefone1 = mtbTelefone.Text.Trim();
            telefone.Contato_tel = mtbContato.Text.Trim();
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
            contato.contato = mtbContato.Text;
            contato.telefone = mtbTelefone.Text;

            contatos.Add(contato);
            mgContato.Rows.Add(contato.contato, contato.telefone);

        }

        private void btnRemoveContato_Click(object sender, EventArgs e)
        {
            contatos.Remove(contato);
            mgContato.Rows.Remove(mgContato.CurrentRow);
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


        //Continuar a validação do gridContatoSAmirr
    }
}
