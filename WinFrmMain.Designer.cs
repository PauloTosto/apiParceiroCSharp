namespace PrjApiParceiro_C
{
    partial class FrmPrincipal
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
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.arquivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controleNFiscaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nFiscaisProduçãoNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rodeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivosToolStripMenuItem,
            this.controleNFiscaisToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1358, 28);
            this.menuPrincipal.TabIndex = 0;
            this.menuPrincipal.Text = "menuStrip1";
            // 
            // arquivosToolStripMenuItem
            // 
            this.arquivosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.arquivosToolStripMenuItem.Name = "arquivosToolStripMenuItem";
            this.arquivosToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.arquivosToolStripMenuItem.Text = "Arquivos";
            this.arquivosToolStripMenuItem.Click += new System.EventHandler(this.arquivosToolStripMenuItem_Click);
            // 
            // configuraçãoToolStripMenuItem
            // 
            this.configuraçãoToolStripMenuItem.Name = "configuraçãoToolStripMenuItem";
            this.configuraçãoToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.configuraçãoToolStripMenuItem.Text = "Configuração";
            this.configuraçãoToolStripMenuItem.Click += new System.EventHandler(this.configuraçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // controleNFiscaisToolStripMenuItem
            // 
            this.controleNFiscaisToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraXMLToolStripMenuItem,
            this.nFiscaisProduçãoNewToolStripMenuItem,
            this.rodeXMLToolStripMenuItem});
            this.controleNFiscaisToolStripMenuItem.Name = "controleNFiscaisToolStripMenuItem";
            this.controleNFiscaisToolStripMenuItem.Size = new System.Drawing.Size(140, 24);
            this.controleNFiscaisToolStripMenuItem.Text = "Controle N.Fiscais";
            // 
            // configuraXMLToolStripMenuItem
            // 
            this.configuraXMLToolStripMenuItem.Name = "configuraXMLToolStripMenuItem";
            this.configuraXMLToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.configuraXMLToolStripMenuItem.Text = "Configura XML";
            this.configuraXMLToolStripMenuItem.Click += new System.EventHandler(this.configuraXMLToolStripMenuItem_Click);
            // 
            // nFiscaisProduçãoNewToolStripMenuItem
            // 
            this.nFiscaisProduçãoNewToolStripMenuItem.Name = "nFiscaisProduçãoNewToolStripMenuItem";
            this.nFiscaisProduçãoNewToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.nFiscaisProduçãoNewToolStripMenuItem.Text = "N.Fiscais Produção<New>";
            this.nFiscaisProduçãoNewToolStripMenuItem.Click += new System.EventHandler(this.nFiscaisProduçãoNewToolStripMenuItem_Click);
            // 
            // rodeXMLToolStripMenuItem
            // 
            this.rodeXMLToolStripMenuItem.Name = "rodeXMLToolStripMenuItem";
            this.rodeXMLToolStripMenuItem.Size = new System.Drawing.Size(265, 26);
            this.rodeXMLToolStripMenuItem.Text = "RodeXML";
            this.rodeXMLToolStripMenuItem.Click += new System.EventHandler(this.rodeXMLToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(136, 59);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1036, 357);
            this.dataGridView1.TabIndex = 1;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1358, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuPrincipal);
            this.Name = "FrmPrincipal";
            this.Text = "ApiParceiro (versão C#)";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem arquivosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem controleNFiscaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nFiscaisProduçãoNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rodeXMLToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

