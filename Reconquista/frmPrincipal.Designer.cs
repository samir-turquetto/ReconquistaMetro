namespace Reconquista
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.mtCadastro = new MetroFramework.Controls.MetroTile();
            this.mtPesquisa = new MetroFramework.Controls.MetroTile();
            this.mtRelatorio = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // mtCadastro
            // 
            this.mtCadastro.ActiveControl = null;
            this.mtCadastro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtCadastro.Cursor = System.Windows.Forms.Cursors.Default;
            this.mtCadastro.Location = new System.Drawing.Point(118, 110);
            this.mtCadastro.Name = "mtCadastro";
            this.mtCadastro.Size = new System.Drawing.Size(254, 470);
            this.mtCadastro.TabIndex = 0;
            this.mtCadastro.Text = "Cadastro";
            this.mtCadastro.TileImage = ((System.Drawing.Image)(resources.GetObject("mtCadastro.TileImage")));
            this.mtCadastro.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCadastro.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtCadastro.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtCadastro.UseSelectable = true;
            this.mtCadastro.UseTileImage = true;
            this.mtCadastro.Click += new System.EventHandler(this.mtCadastro_Click);
            // 
            // mtPesquisa
            // 
            this.mtPesquisa.ActiveControl = null;
            this.mtPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtPesquisa.Location = new System.Drawing.Point(403, 110);
            this.mtPesquisa.Name = "mtPesquisa";
            this.mtPesquisa.Size = new System.Drawing.Size(254, 470);
            this.mtPesquisa.TabIndex = 1;
            this.mtPesquisa.Text = "Pesquisar";
            this.mtPesquisa.TileImage = ((System.Drawing.Image)(resources.GetObject("mtPesquisa.TileImage")));
            this.mtPesquisa.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPesquisa.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtPesquisa.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtPesquisa.UseSelectable = true;
            this.mtPesquisa.UseTileImage = true;
            // 
            // mtRelatorio
            // 
            this.mtRelatorio.ActiveControl = null;
            this.mtRelatorio.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mtRelatorio.Location = new System.Drawing.Point(688, 110);
            this.mtRelatorio.Name = "mtRelatorio";
            this.mtRelatorio.Size = new System.Drawing.Size(254, 470);
            this.mtRelatorio.TabIndex = 2;
            this.mtRelatorio.Text = "Relatório";
            this.mtRelatorio.TileImage = ((System.Drawing.Image)(resources.GetObject("mtRelatorio.TileImage")));
            this.mtRelatorio.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtRelatorio.TileTextFontSize = MetroFramework.MetroTileTextSize.Tall;
            this.mtRelatorio.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Bold;
            this.mtRelatorio.UseSelectable = true;
            this.mtRelatorio.UseTileImage = true;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 641);
            this.Controls.Add(this.mtRelatorio);
            this.Controls.Add(this.mtPesquisa);
            this.Controls.Add(this.mtCadastro);
            this.Name = "frmPrincipal";
            this.Text = "Reconquista";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtCadastro;
        private MetroFramework.Controls.MetroTile mtPesquisa;
        private MetroFramework.Controls.MetroTile mtRelatorio;
    }
}

