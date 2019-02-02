namespace Reconquista
{
    partial class frmCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastro));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabCliente = new MetroFramework.Controls.MetroTabPage();
            this.mtbCPFCNPJ = new MetroFramework.Controls.MetroTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rtbObsCli = new System.Windows.Forms.RichTextBox();
            this.mtbEmail = new MetroFramework.Controls.MetroTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnRemoveContato = new System.Windows.Forms.Button();
            this.btnAddContato = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.mtbTelefone = new MetroFramework.Controls.MetroTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.mtbContato = new MetroFramework.Controls.MetroTextBox();
            this.mgContato = new MetroFramework.Controls.MetroGrid();
            this.Contato_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCPFCPNJ = new System.Windows.Forms.Label();
            this.lblRGIE = new System.Windows.Forms.Label();
            this.mtbRGIE = new MetroFramework.Controls.MetroTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mtbNomeCli = new MetroFramework.Controls.MetroTextBox();
            this.mtbCodCli = new MetroFramework.Controls.MetroTextBox();
            this.mcbTipoCli = new MetroFramework.Controls.MetroComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabBem = new MetroFramework.Controls.MetroTabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.rtbObsBem = new System.Windows.Forms.RichTextBox();
            this.mgBem = new MetroFramework.Controls.MetroGrid();
            this.dtpVigencia = new System.Windows.Forms.DateTimePicker();
            this.mtbPlaca = new MetroFramework.Controls.MetroTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mtbBem = new MetroFramework.Controls.MetroTextBox();
            this.mtbCodBem = new MetroFramework.Controls.MetroTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabAnexo = new MetroFramework.Controls.MetroTabPage();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.metroGrid3 = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.PreencheCampo = new MetroFramework.Controls.MetroButton();
            this.metroTabControl1.SuspendLayout();
            this.tabCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgContato)).BeginInit();
            this.tabBem.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgBem)).BeginInit();
            this.tabAnexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabCliente);
            this.metroTabControl1.Controls.Add(this.tabBem);
            this.metroTabControl1.Controls.Add(this.tabAnexo);
            this.metroTabControl1.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.metroTabControl1.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 0;
            this.metroTabControl1.Size = new System.Drawing.Size(970, 476);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabCliente
            // 
            this.tabCliente.Controls.Add(this.mtbCPFCNPJ);
            this.tabCliente.Controls.Add(this.label9);
            this.tabCliente.Controls.Add(this.rtbObsCli);
            this.tabCliente.Controls.Add(this.mtbEmail);
            this.tabCliente.Controls.Add(this.label8);
            this.tabCliente.Controls.Add(this.btnRemoveContato);
            this.tabCliente.Controls.Add(this.btnAddContato);
            this.tabCliente.Controls.Add(this.label7);
            this.tabCliente.Controls.Add(this.mtbTelefone);
            this.tabCliente.Controls.Add(this.label6);
            this.tabCliente.Controls.Add(this.mtbContato);
            this.tabCliente.Controls.Add(this.mgContato);
            this.tabCliente.Controls.Add(this.lblCPFCPNJ);
            this.tabCliente.Controls.Add(this.lblRGIE);
            this.tabCliente.Controls.Add(this.mtbRGIE);
            this.tabCliente.Controls.Add(this.label3);
            this.tabCliente.Controls.Add(this.mtbNomeCli);
            this.tabCliente.Controls.Add(this.mtbCodCli);
            this.tabCliente.Controls.Add(this.mcbTipoCli);
            this.tabCliente.Controls.Add(this.label2);
            this.tabCliente.Controls.Add(this.label1);
            this.tabCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabCliente.HorizontalScrollbarBarColor = true;
            this.tabCliente.HorizontalScrollbarHighlightOnWheel = false;
            this.tabCliente.HorizontalScrollbarSize = 10;
            this.tabCliente.Location = new System.Drawing.Point(4, 44);
            this.tabCliente.Name = "tabCliente";
            this.tabCliente.Size = new System.Drawing.Size(962, 428);
            this.tabCliente.TabIndex = 0;
            this.tabCliente.Text = "Cliente";
            this.tabCliente.VerticalScrollbarBarColor = true;
            this.tabCliente.VerticalScrollbarHighlightOnWheel = false;
            this.tabCliente.VerticalScrollbarSize = 10;
            // 
            // mtbCPFCNPJ
            // 
            // 
            // 
            // 
            this.mtbCPFCNPJ.CustomButton.Image = null;
            this.mtbCPFCNPJ.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.mtbCPFCNPJ.CustomButton.Name = "";
            this.mtbCPFCNPJ.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCPFCNPJ.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCPFCNPJ.CustomButton.TabIndex = 1;
            this.mtbCPFCNPJ.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCPFCNPJ.CustomButton.UseSelectable = true;
            this.mtbCPFCNPJ.CustomButton.Visible = false;
            this.mtbCPFCNPJ.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbCPFCNPJ.Lines = new string[0];
            this.mtbCPFCNPJ.Location = new System.Drawing.Point(149, 79);
            this.mtbCPFCNPJ.MaxLength = 32767;
            this.mtbCPFCNPJ.Name = "mtbCPFCNPJ";
            this.mtbCPFCNPJ.PasswordChar = '\0';
            this.mtbCPFCNPJ.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCPFCNPJ.SelectedText = "";
            this.mtbCPFCNPJ.SelectionLength = 0;
            this.mtbCPFCNPJ.SelectionStart = 0;
            this.mtbCPFCNPJ.ShortcutsEnabled = true;
            this.mtbCPFCNPJ.Size = new System.Drawing.Size(137, 23);
            this.mtbCPFCNPJ.TabIndex = 4;
            this.mtbCPFCNPJ.UseSelectable = true;
            this.mtbCPFCNPJ.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCPFCNPJ.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbCPFCNPJ.Enter += new System.EventHandler(this.mtbCPFCNPJ_Enter);
            this.mtbCPFCNPJ.Leave += new System.EventHandler(this.mtbCPFCNPJ_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 16);
            this.label9.TabIndex = 24;
            this.label9.Text = "Observação";
            // 
            // rtbObsCli
            // 
            this.rtbObsCli.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbObsCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbObsCli.Location = new System.Drawing.Point(6, 243);
            this.rtbObsCli.Name = "rtbObsCli";
            this.rtbObsCli.Size = new System.Drawing.Size(953, 182);
            this.rtbObsCli.TabIndex = 8;
            this.rtbObsCli.Text = "";
            // 
            // mtbEmail
            // 
            // 
            // 
            // 
            this.mtbEmail.CustomButton.Image = null;
            this.mtbEmail.CustomButton.Location = new System.Drawing.Point(234, 1);
            this.mtbEmail.CustomButton.Name = "";
            this.mtbEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbEmail.CustomButton.TabIndex = 1;
            this.mtbEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbEmail.CustomButton.UseSelectable = true;
            this.mtbEmail.CustomButton.Visible = false;
            this.mtbEmail.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbEmail.Lines = new string[0];
            this.mtbEmail.Location = new System.Drawing.Point(292, 79);
            this.mtbEmail.MaxLength = 32767;
            this.mtbEmail.Name = "mtbEmail";
            this.mtbEmail.PasswordChar = '\0';
            this.mtbEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbEmail.SelectedText = "";
            this.mtbEmail.SelectionLength = 0;
            this.mtbEmail.SelectionStart = 0;
            this.mtbEmail.ShortcutsEnabled = true;
            this.mtbEmail.Size = new System.Drawing.Size(256, 23);
            this.mtbEmail.TabIndex = 5;
            this.mtbEmail.UseSelectable = true;
            this.mtbEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(289, 59);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "E-mail";
            // 
            // btnRemoveContato
            // 
            this.btnRemoveContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveContato.FlatAppearance.BorderSize = 0;
            this.btnRemoveContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveContato.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveContato.Image")));
            this.btnRemoveContato.Location = new System.Drawing.Point(875, 167);
            this.btnRemoveContato.Name = "btnRemoveContato";
            this.btnRemoveContato.Size = new System.Drawing.Size(69, 53);
            this.btnRemoveContato.TabIndex = 20;
            this.btnRemoveContato.UseVisualStyleBackColor = false;
            this.btnRemoveContato.Click += new System.EventHandler(this.btnRemoveContato_Click);
            // 
            // btnAddContato
            // 
            this.btnAddContato.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddContato.FlatAppearance.BorderSize = 0;
            this.btnAddContato.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddContato.Image = ((System.Drawing.Image)(resources.GetObject("btnAddContato.Image")));
            this.btnAddContato.Location = new System.Drawing.Point(875, 108);
            this.btnAddContato.Name = "btnAddContato";
            this.btnAddContato.Size = new System.Drawing.Size(69, 53);
            this.btnAddContato.TabIndex = 9;
            this.btnAddContato.UseVisualStyleBackColor = false;
            this.btnAddContato.Click += new System.EventHandler(this.btnAddContato_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(762, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 16);
            this.label7.TabIndex = 18;
            this.label7.Text = "Telefone (DDD)";
            // 
            // mtbTelefone
            // 
            // 
            // 
            // 
            this.mtbTelefone.CustomButton.Image = null;
            this.mtbTelefone.CustomButton.Location = new System.Drawing.Point(172, 1);
            this.mtbTelefone.CustomButton.Name = "";
            this.mtbTelefone.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbTelefone.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbTelefone.CustomButton.TabIndex = 1;
            this.mtbTelefone.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbTelefone.CustomButton.UseSelectable = true;
            this.mtbTelefone.CustomButton.Visible = false;
            this.mtbTelefone.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbTelefone.Lines = new string[0];
            this.mtbTelefone.Location = new System.Drawing.Point(765, 79);
            this.mtbTelefone.MaxLength = 32767;
            this.mtbTelefone.Name = "mtbTelefone";
            this.mtbTelefone.PasswordChar = '\0';
            this.mtbTelefone.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbTelefone.SelectedText = "";
            this.mtbTelefone.SelectionLength = 0;
            this.mtbTelefone.SelectionStart = 0;
            this.mtbTelefone.ShortcutsEnabled = true;
            this.mtbTelefone.Size = new System.Drawing.Size(194, 23);
            this.mtbTelefone.TabIndex = 7;
            this.mtbTelefone.UseSelectable = true;
            this.mtbTelefone.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbTelefone.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.mtbTelefone.Leave += new System.EventHandler(this.mtbTelefone_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "Contato";
            // 
            // mtbContato
            // 
            // 
            // 
            // 
            this.mtbContato.CustomButton.Image = null;
            this.mtbContato.CustomButton.Location = new System.Drawing.Point(183, 1);
            this.mtbContato.CustomButton.Name = "";
            this.mtbContato.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbContato.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbContato.CustomButton.TabIndex = 1;
            this.mtbContato.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbContato.CustomButton.UseSelectable = true;
            this.mtbContato.CustomButton.Visible = false;
            this.mtbContato.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbContato.Lines = new string[0];
            this.mtbContato.Location = new System.Drawing.Point(554, 79);
            this.mtbContato.MaxLength = 32767;
            this.mtbContato.Name = "mtbContato";
            this.mtbContato.PasswordChar = '\0';
            this.mtbContato.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbContato.SelectedText = "";
            this.mtbContato.SelectionLength = 0;
            this.mtbContato.SelectionStart = 0;
            this.mtbContato.ShortcutsEnabled = true;
            this.mtbContato.Size = new System.Drawing.Size(205, 23);
            this.mtbContato.TabIndex = 6;
            this.mtbContato.UseSelectable = true;
            this.mtbContato.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbContato.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mgContato
            // 
            this.mgContato.AllowUserToAddRows = false;
            this.mgContato.AllowUserToDeleteRows = false;
            this.mgContato.AllowUserToResizeRows = false;
            this.mgContato.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgContato.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgContato.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgContato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgContato.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.mgContato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mgContato.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Contato_tel,
            this.Fone});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgContato.DefaultCellStyle = dataGridViewCellStyle2;
            this.mgContato.EnableHeadersVisualStyles = false;
            this.mgContato.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgContato.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgContato.Location = new System.Drawing.Point(6, 108);
            this.mgContato.Name = "mgContato";
            this.mgContato.ReadOnly = true;
            this.mgContato.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgContato.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.mgContato.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgContato.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgContato.Size = new System.Drawing.Size(863, 112);
            this.mgContato.TabIndex = 14;
            // 
            // Contato_tel
            // 
            this.Contato_tel.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contato_tel.DataPropertyName = "Contato_tel";
            this.Contato_tel.HeaderText = "Contato";
            this.Contato_tel.Name = "Contato_tel";
            this.Contato_tel.ReadOnly = true;
            // 
            // Fone
            // 
            this.Fone.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fone.DataPropertyName = "Telefone";
            this.Fone.HeaderText = "Telefone";
            this.Fone.Name = "Fone";
            this.Fone.ReadOnly = true;
            // 
            // lblCPFCPNJ
            // 
            this.lblCPFCPNJ.AutoSize = true;
            this.lblCPFCPNJ.BackColor = System.Drawing.Color.Transparent;
            this.lblCPFCPNJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCPFCPNJ.Location = new System.Drawing.Point(146, 59);
            this.lblCPFCPNJ.Name = "lblCPFCPNJ";
            this.lblCPFCPNJ.Size = new System.Drawing.Size(43, 16);
            this.lblCPFCPNJ.TabIndex = 13;
            this.lblCPFCPNJ.Text = "C.P.F.";
            // 
            // lblRGIE
            // 
            this.lblRGIE.AutoSize = true;
            this.lblRGIE.BackColor = System.Drawing.Color.Transparent;
            this.lblRGIE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRGIE.Location = new System.Drawing.Point(3, 59);
            this.lblRGIE.Name = "lblRGIE";
            this.lblRGIE.Size = new System.Drawing.Size(34, 16);
            this.lblRGIE.TabIndex = 11;
            this.lblRGIE.Text = "R.G.";
            // 
            // mtbRGIE
            // 
            // 
            // 
            // 
            this.mtbRGIE.CustomButton.Image = null;
            this.mtbRGIE.CustomButton.Location = new System.Drawing.Point(115, 1);
            this.mtbRGIE.CustomButton.Name = "";
            this.mtbRGIE.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbRGIE.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbRGIE.CustomButton.TabIndex = 1;
            this.mtbRGIE.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbRGIE.CustomButton.UseSelectable = true;
            this.mtbRGIE.CustomButton.Visible = false;
            this.mtbRGIE.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbRGIE.Lines = new string[0];
            this.mtbRGIE.Location = new System.Drawing.Point(6, 79);
            this.mtbRGIE.MaxLength = 32767;
            this.mtbRGIE.Name = "mtbRGIE";
            this.mtbRGIE.PasswordChar = '\0';
            this.mtbRGIE.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbRGIE.SelectedText = "";
            this.mtbRGIE.SelectionLength = 0;
            this.mtbRGIE.SelectionStart = 0;
            this.mtbRGIE.ShortcutsEnabled = true;
            this.mtbRGIE.Size = new System.Drawing.Size(137, 23);
            this.mtbRGIE.TabIndex = 3;
            this.mtbRGIE.UseSelectable = true;
            this.mtbRGIE.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbRGIE.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(835, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Tipo";
            // 
            // mtbNomeCli
            // 
            // 
            // 
            // 
            this.mtbNomeCli.CustomButton.Image = null;
            this.mtbNomeCli.CustomButton.Location = new System.Drawing.Point(740, 1);
            this.mtbNomeCli.CustomButton.Name = "";
            this.mtbNomeCli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbNomeCli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbNomeCli.CustomButton.TabIndex = 1;
            this.mtbNomeCli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbNomeCli.CustomButton.UseSelectable = true;
            this.mtbNomeCli.CustomButton.Visible = false;
            this.mtbNomeCli.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbNomeCli.Lines = new string[0];
            this.mtbNomeCli.Location = new System.Drawing.Point(70, 33);
            this.mtbNomeCli.MaxLength = 32767;
            this.mtbNomeCli.Name = "mtbNomeCli";
            this.mtbNomeCli.PasswordChar = '\0';
            this.mtbNomeCli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbNomeCli.SelectedText = "";
            this.mtbNomeCli.SelectionLength = 0;
            this.mtbNomeCli.SelectionStart = 0;
            this.mtbNomeCli.ShortcutsEnabled = true;
            this.mtbNomeCli.Size = new System.Drawing.Size(762, 23);
            this.mtbNomeCli.TabIndex = 1;
            this.mtbNomeCli.UseSelectable = true;
            this.mtbNomeCli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbNomeCli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCodCli
            // 
            // 
            // 
            // 
            this.mtbCodCli.CustomButton.Image = null;
            this.mtbCodCli.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.mtbCodCli.CustomButton.Name = "";
            this.mtbCodCli.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCodCli.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCodCli.CustomButton.TabIndex = 1;
            this.mtbCodCli.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCodCli.CustomButton.UseSelectable = true;
            this.mtbCodCli.CustomButton.Visible = false;
            this.mtbCodCli.Enabled = false;
            this.mtbCodCli.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbCodCli.Lines = new string[0];
            this.mtbCodCli.Location = new System.Drawing.Point(6, 33);
            this.mtbCodCli.MaxLength = 32767;
            this.mtbCodCli.Name = "mtbCodCli";
            this.mtbCodCli.PasswordChar = '\0';
            this.mtbCodCli.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCodCli.SelectedText = "";
            this.mtbCodCli.SelectionLength = 0;
            this.mtbCodCli.SelectionStart = 0;
            this.mtbCodCli.ShortcutsEnabled = true;
            this.mtbCodCli.Size = new System.Drawing.Size(58, 23);
            this.mtbCodCli.TabIndex = 7;
            this.mtbCodCli.UseSelectable = true;
            this.mtbCodCli.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCodCli.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mcbTipoCli
            // 
            this.mcbTipoCli.BackColor = System.Drawing.Color.White;
            this.mcbTipoCli.FontSize = MetroFramework.MetroComboBoxSize.Small;
            this.mcbTipoCli.FontWeight = MetroFramework.MetroComboBoxWeight.Light;
            this.mcbTipoCli.ItemHeight = 19;
            this.mcbTipoCli.Items.AddRange(new object[] {
            "Física",
            "Jurídica"});
            this.mcbTipoCli.Location = new System.Drawing.Point(838, 31);
            this.mcbTipoCli.MaxDropDownItems = 2;
            this.mcbTipoCli.Name = "mcbTipoCli";
            this.mcbTipoCli.Size = new System.Drawing.Size(121, 25);
            this.mcbTipoCli.TabIndex = 2;
            this.mcbTipoCli.UseSelectable = true;
            this.mcbTipoCli.SelectedIndexChanged += new System.EventHandler(this.mcbTipoPessoa);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // tabBem
            // 
            this.tabBem.Controls.Add(this.button4);
            this.tabBem.Controls.Add(this.button3);
            this.tabBem.Controls.Add(this.label12);
            this.tabBem.Controls.Add(this.label11);
            this.tabBem.Controls.Add(this.rtbObsBem);
            this.tabBem.Controls.Add(this.mgBem);
            this.tabBem.Controls.Add(this.dtpVigencia);
            this.tabBem.Controls.Add(this.mtbPlaca);
            this.tabBem.Controls.Add(this.label4);
            this.tabBem.Controls.Add(this.mtbBem);
            this.tabBem.Controls.Add(this.mtbCodBem);
            this.tabBem.Controls.Add(this.label5);
            this.tabBem.Controls.Add(this.label10);
            this.tabBem.HorizontalScrollbarBarColor = true;
            this.tabBem.HorizontalScrollbarHighlightOnWheel = false;
            this.tabBem.HorizontalScrollbarSize = 10;
            this.tabBem.Location = new System.Drawing.Point(4, 44);
            this.tabBem.Name = "tabBem";
            this.tabBem.Size = new System.Drawing.Size(962, 428);
            this.tabBem.TabIndex = 1;
            this.tabBem.Text = "  Bem";
            this.tabBem.VerticalScrollbarBarColor = true;
            this.tabBem.VerticalScrollbarHighlightOnWheel = false;
            this.tabBem.VerticalScrollbarSize = 10;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(875, 127);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(76, 59);
            this.button4.TabIndex = 30;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(875, 62);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(76, 59);
            this.button3.TabIndex = 16;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(846, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Vigência";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(3, 189);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 27;
            this.label11.Text = "Observação";
            // 
            // rtbObsBem
            // 
            this.rtbObsBem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rtbObsBem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbObsBem.Location = new System.Drawing.Point(6, 209);
            this.rtbObsBem.Name = "rtbObsBem";
            this.rtbObsBem.Size = new System.Drawing.Size(953, 214);
            this.rtbObsBem.TabIndex = 15;
            this.rtbObsBem.Text = "";
            // 
            // mgBem
            // 
            this.mgBem.AllowUserToAddRows = false;
            this.mgBem.AllowUserToDeleteRows = false;
            this.mgBem.AllowUserToResizeRows = false;
            this.mgBem.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgBem.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.mgBem.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.mgBem.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgBem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.mgBem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.mgBem.DefaultCellStyle = dataGridViewCellStyle5;
            this.mgBem.EnableHeadersVisualStyles = false;
            this.mgBem.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.mgBem.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.mgBem.Location = new System.Drawing.Point(6, 62);
            this.mgBem.Name = "mgBem";
            this.mgBem.ReadOnly = true;
            this.mgBem.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.mgBem.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.mgBem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.mgBem.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.mgBem.Size = new System.Drawing.Size(863, 124);
            this.mgBem.TabIndex = 25;
            // 
            // dtpVigencia
            // 
            this.dtpVigencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpVigencia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpVigencia.Location = new System.Drawing.Point(849, 33);
            this.dtpVigencia.Name = "dtpVigencia";
            this.dtpVigencia.Size = new System.Drawing.Size(107, 22);
            this.dtpVigencia.TabIndex = 14;
            // 
            // mtbPlaca
            // 
            // 
            // 
            // 
            this.mtbPlaca.CustomButton.Image = null;
            this.mtbPlaca.CustomButton.Location = new System.Drawing.Point(110, 1);
            this.mtbPlaca.CustomButton.Name = "";
            this.mtbPlaca.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbPlaca.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbPlaca.CustomButton.TabIndex = 1;
            this.mtbPlaca.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbPlaca.CustomButton.UseSelectable = true;
            this.mtbPlaca.CustomButton.Visible = false;
            this.mtbPlaca.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbPlaca.Lines = new string[0];
            this.mtbPlaca.Location = new System.Drawing.Point(711, 33);
            this.mtbPlaca.MaxLength = 32767;
            this.mtbPlaca.Name = "mtbPlaca";
            this.mtbPlaca.PasswordChar = '\0';
            this.mtbPlaca.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbPlaca.SelectedText = "";
            this.mtbPlaca.SelectionLength = 0;
            this.mtbPlaca.SelectionStart = 0;
            this.mtbPlaca.ShortcutsEnabled = true;
            this.mtbPlaca.Size = new System.Drawing.Size(132, 23);
            this.mtbPlaca.TabIndex = 13;
            this.mtbPlaca.UseSelectable = true;
            this.mtbPlaca.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbPlaca.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(708, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 17;
            this.label4.Text = "Placa";
            // 
            // mtbBem
            // 
            // 
            // 
            // 
            this.mtbBem.CustomButton.Image = null;
            this.mtbBem.CustomButton.Location = new System.Drawing.Point(613, 1);
            this.mtbBem.CustomButton.Name = "";
            this.mtbBem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbBem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbBem.CustomButton.TabIndex = 1;
            this.mtbBem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbBem.CustomButton.UseSelectable = true;
            this.mtbBem.CustomButton.Visible = false;
            this.mtbBem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbBem.Lines = new string[0];
            this.mtbBem.Location = new System.Drawing.Point(70, 33);
            this.mtbBem.MaxLength = 32767;
            this.mtbBem.Name = "mtbBem";
            this.mtbBem.PasswordChar = '\0';
            this.mtbBem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbBem.SelectedText = "";
            this.mtbBem.SelectionLength = 0;
            this.mtbBem.SelectionStart = 0;
            this.mtbBem.ShortcutsEnabled = true;
            this.mtbBem.Size = new System.Drawing.Size(635, 23);
            this.mtbBem.TabIndex = 12;
            this.mtbBem.UseSelectable = true;
            this.mtbBem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbBem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // mtbCodBem
            // 
            // 
            // 
            // 
            this.mtbCodBem.CustomButton.Image = null;
            this.mtbCodBem.CustomButton.Location = new System.Drawing.Point(36, 1);
            this.mtbCodBem.CustomButton.Name = "";
            this.mtbCodBem.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mtbCodBem.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mtbCodBem.CustomButton.TabIndex = 1;
            this.mtbCodBem.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mtbCodBem.CustomButton.UseSelectable = true;
            this.mtbCodBem.CustomButton.Visible = false;
            this.mtbCodBem.Enabled = false;
            this.mtbCodBem.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.mtbCodBem.Lines = new string[0];
            this.mtbCodBem.Location = new System.Drawing.Point(6, 33);
            this.mtbCodBem.MaxLength = 32767;
            this.mtbCodBem.Name = "mtbCodBem";
            this.mtbCodBem.PasswordChar = '\0';
            this.mtbCodBem.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mtbCodBem.SelectedText = "";
            this.mtbCodBem.SelectionLength = 0;
            this.mtbCodBem.SelectionStart = 0;
            this.mtbCodBem.ShortcutsEnabled = true;
            this.mtbCodBem.Size = new System.Drawing.Size(58, 23);
            this.mtbCodBem.TabIndex = 15;
            this.mtbCodBem.UseSelectable = true;
            this.mtbCodBem.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mtbCodBem.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(67, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Bem*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 16);
            this.label10.TabIndex = 13;
            this.label10.Text = "Código";
            // 
            // tabAnexo
            // 
            this.tabAnexo.Controls.Add(this.button8);
            this.tabAnexo.Controls.Add(this.button9);
            this.tabAnexo.Controls.Add(this.metroGrid3);
            this.tabAnexo.HorizontalScrollbarBarColor = true;
            this.tabAnexo.HorizontalScrollbarHighlightOnWheel = false;
            this.tabAnexo.HorizontalScrollbarSize = 10;
            this.tabAnexo.Location = new System.Drawing.Point(4, 44);
            this.tabAnexo.Name = "tabAnexo";
            this.tabAnexo.Size = new System.Drawing.Size(962, 428);
            this.tabAnexo.TabIndex = 2;
            this.tabAnexo.Text = "Anexo";
            this.tabAnexo.VerticalScrollbarBarColor = true;
            this.tabAnexo.VerticalScrollbarHighlightOnWheel = false;
            this.tabAnexo.VerticalScrollbarSize = 10;
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Image = ((System.Drawing.Image)(resources.GetObject("button8.Image")));
            this.button8.Location = new System.Drawing.Point(872, 86);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(76, 59);
            this.button8.TabIndex = 33;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Image = ((System.Drawing.Image)(resources.GetObject("button9.Image")));
            this.button9.Location = new System.Drawing.Point(872, 21);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(76, 59);
            this.button9.TabIndex = 32;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // metroGrid3
            // 
            this.metroGrid3.AllowUserToDeleteRows = false;
            this.metroGrid3.AllowUserToResizeRows = false;
            this.metroGrid3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.metroGrid3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.metroGrid3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.metroGrid3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.metroGrid3.DefaultCellStyle = dataGridViewCellStyle8;
            this.metroGrid3.EnableHeadersVisualStyles = false;
            this.metroGrid3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGrid3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGrid3.Location = new System.Drawing.Point(3, 21);
            this.metroGrid3.Name = "metroGrid3";
            this.metroGrid3.ReadOnly = true;
            this.metroGrid3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.metroGrid3.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.metroGrid3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.metroGrid3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.metroGrid3.Size = new System.Drawing.Size(863, 348);
            this.metroGrid3.TabIndex = 31;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.btnCancelar);
            this.metroPanel1.Controls.Add(this.btnSalvar);
            this.metroPanel1.Controls.Add(this.btnProximo);
            this.metroPanel1.Controls.Add(this.btnVoltar);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(30, 542);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(953, 57);
            this.metroPanel1.TabIndex = 36;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.White;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(794, 3);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(69, 53);
            this.btnCancelar.TabIndex = 39;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.Color.White;
            this.btnSalvar.FlatAppearance.BorderSize = 0;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Image = ((System.Drawing.Image)(resources.GetObject("btnSalvar.Image")));
            this.btnSalvar.Location = new System.Drawing.Point(869, 3);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(69, 53);
            this.btnSalvar.TabIndex = 38;
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.BackColor = System.Drawing.Color.White;
            this.btnProximo.FlatAppearance.BorderSize = 0;
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Image = ((System.Drawing.Image)(resources.GetObject("btnProximo.Image")));
            this.btnProximo.Location = new System.Drawing.Point(733, 3);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(69, 53);
            this.btnProximo.TabIndex = 37;
            this.btnProximo.UseVisualStyleBackColor = false;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackColor = System.Drawing.Color.White;
            this.btnVoltar.FlatAppearance.BorderSize = 0;
            this.btnVoltar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(658, 3);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(69, 53);
            this.btnVoltar.TabIndex = 36;
            this.btnVoltar.UseVisualStyleBackColor = false;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(0, 0);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 37;
            this.metroButton1.Text = "metroButton1";
            this.metroButton1.UseSelectable = true;
            // 
            // PreencheCampo
            // 
            this.PreencheCampo.Location = new System.Drawing.Point(349, 24);
            this.PreencheCampo.Name = "PreencheCampo";
            this.PreencheCampo.Size = new System.Drawing.Size(229, 36);
            this.PreencheCampo.TabIndex = 38;
            this.PreencheCampo.Text = "Preenche Campo";
            this.PreencheCampo.UseSelectable = true;
            this.PreencheCampo.Click += new System.EventHandler(this.mbtPreencher_Click);
            // 
            // frmCadastro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1010, 608);
            this.Controls.Add(this.PreencheCampo);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmCadastro";
            this.Text = "Cadastro";
            this.Load += new System.EventHandler(this.frmCadastro_Load);
            this.metroTabControl1.ResumeLayout(false);
            this.tabCliente.ResumeLayout(false);
            this.tabCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgContato)).EndInit();
            this.tabBem.ResumeLayout(false);
            this.tabBem.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mgBem)).EndInit();
            this.tabAnexo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.metroGrid3)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabCliente;
        private MetroFramework.Controls.MetroTabPage tabBem;
        private MetroFramework.Controls.MetroTabPage tabAnexo;
        private System.Windows.Forms.Label label1;
        private MetroFramework.Controls.MetroTextBox mtbNomeCli;
        private MetroFramework.Controls.MetroTextBox mtbCodCli;
        private MetroFramework.Controls.MetroComboBox mcbTipoCli;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddContato;
        private System.Windows.Forms.Label label7;
        private MetroFramework.Controls.MetroTextBox mtbTelefone;
        private System.Windows.Forms.Label label6;
        private MetroFramework.Controls.MetroTextBox mtbContato;
        private MetroFramework.Controls.MetroGrid mgContato;
        private System.Windows.Forms.Label lblCPFCPNJ;
        private System.Windows.Forms.Label lblRGIE;
        private MetroFramework.Controls.MetroTextBox mtbRGIE;
        private System.Windows.Forms.Button btnRemoveContato;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.RichTextBox rtbObsCli;
        private MetroFramework.Controls.MetroTextBox mtbEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dtpVigencia;
        private MetroFramework.Controls.MetroTextBox mtbPlaca;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox mtbBem;
        private MetroFramework.Controls.MetroTextBox mtbCodBem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox rtbObsBem;
        private MetroFramework.Controls.MetroGrid mgBem;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private MetroFramework.Controls.MetroGrid metroGrid3;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contato_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fone;
        private MetroFramework.Controls.MetroTextBox mtbCPFCNPJ;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton PreencheCampo;
    }
}