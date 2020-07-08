namespace PrjApiParceiro_C.Fiscais
{
    partial class FrmFiscal_Novo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFiscal_Novo));
            this.pnCabecalho = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txFazenda = new System.Windows.Forms.TextBox();
            this.txCFOP = new System.Windows.Forms.TextBox();
            this.gbCritica = new System.Windows.Forms.GroupBox();
            this.rbNenhuma = new System.Windows.Forms.RadioButton();
            this.rbIncompleto = new System.Windows.Forms.RadioButton();
            this.rbCompleto = new System.Windows.Forms.RadioButton();
            this.rbTodas = new System.Windows.Forms.RadioButton();
            this.gbFiscais = new System.Windows.Forms.GroupBox();
            this.rbVendas = new System.Windows.Forms.RadioButton();
            this.rbEntradas = new System.Windows.Forms.RadioButton();
            this.rbGeral = new System.Windows.Forms.RadioButton();
            this.tcLink = new System.Windows.Forms.TabControl();
            this.tpDisponivel = new System.Windows.Forms.TabPage();
            this.dgvDisponivel = new System.Windows.Forms.DataGridView();
            this.tsLigados = new System.Windows.Forms.TabPage();
            this.dgvLink = new System.Windows.Forms.DataGridView();
            this.tcVenda = new System.Windows.Forms.TabControl();
            this.tsDisponivelVenda = new System.Windows.Forms.TabPage();
            this.dgvDispVenda = new System.Windows.Forms.DataGridView();
            this.tsLigadosVenda = new System.Windows.Forms.TabPage();
            this.dgvLinkVenda = new System.Windows.Forms.DataGridView();
            this.pnToolStrip = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripNovo = new System.Windows.Forms.ToolStripButton();
            this.toolStripEdicao = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripConfirme = new System.Windows.Forms.ToolStripButton();
            this.toolStripCancele = new System.Windows.Forms.ToolStripButton();
            this.toolStripConsulta = new System.Windows.Forms.ToolStripButton();
            this.pnMestre = new System.Windows.Forms.Panel();
            this.pnMestreSub = new System.Windows.Forms.Panel();
            this.statusMestre = new System.Windows.Forms.StatusStrip();
            this.tcMestre = new System.Windows.Forms.TabControl();
            this.tsMestre = new System.Windows.Forms.TabPage();
            this.dgvMestre = new System.Windows.Forms.DataGridView();
            this.pnNFs = new System.Windows.Forms.Panel();
            this.tcItens = new System.Windows.Forms.TabControl();
            this.tsItens = new System.Windows.Forms.TabPage();
            this.dgvItens = new System.Windows.Forms.DataGridView();
            this.pnCabecalho.SuspendLayout();
            this.gbCritica.SuspendLayout();
            this.gbFiscais.SuspendLayout();
            this.tcLink.SuspendLayout();
            this.tpDisponivel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponivel)).BeginInit();
            this.tsLigados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).BeginInit();
            this.tcVenda.SuspendLayout();
            this.tsDisponivelVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispVenda)).BeginInit();
            this.tsLigadosVenda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkVenda)).BeginInit();
            this.pnToolStrip.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.pnMestre.SuspendLayout();
            this.pnMestreSub.SuspendLayout();
            this.tcMestre.SuspendLayout();
            this.tsMestre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMestre)).BeginInit();
            this.pnNFs.SuspendLayout();
            this.tcItens.SuspendLayout();
            this.tsItens.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).BeginInit();
            this.SuspendLayout();
            // 
            // pnCabecalho
            // 
            this.pnCabecalho.Controls.Add(this.label2);
            this.pnCabecalho.Controls.Add(this.label1);
            this.pnCabecalho.Controls.Add(this.txFazenda);
            this.pnCabecalho.Controls.Add(this.txCFOP);
            this.pnCabecalho.Controls.Add(this.gbCritica);
            this.pnCabecalho.Controls.Add(this.gbFiscais);
            this.pnCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnCabecalho.Location = new System.Drawing.Point(0, 0);
            this.pnCabecalho.Name = "pnCabecalho";
            this.pnCabecalho.Size = new System.Drawing.Size(1453, 70);
            this.pnCabecalho.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "FAZENDA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "CFOP:";
            // 
            // txFazenda
            // 
            this.txFazenda.Location = new System.Drawing.Point(262, 26);
            this.txFazenda.Name = "txFazenda";
            this.txFazenda.Size = new System.Drawing.Size(112, 22);
            this.txFazenda.TabIndex = 4;
            // 
            // txCFOP
            // 
            this.txCFOP.Location = new System.Drawing.Point(78, 23);
            this.txCFOP.Name = "txCFOP";
            this.txCFOP.Size = new System.Drawing.Size(75, 22);
            this.txCFOP.TabIndex = 2;
            // 
            // gbCritica
            // 
            this.gbCritica.Controls.Add(this.rbNenhuma);
            this.gbCritica.Controls.Add(this.rbIncompleto);
            this.gbCritica.Controls.Add(this.rbCompleto);
            this.gbCritica.Controls.Add(this.rbTodas);
            this.gbCritica.Location = new System.Drawing.Point(857, 8);
            this.gbCritica.Name = "gbCritica";
            this.gbCritica.Size = new System.Drawing.Size(518, 46);
            this.gbCritica.TabIndex = 1;
            this.gbCritica.TabStop = false;
            this.gbCritica.Text = "Crítica";
            // 
            // rbNenhuma
            // 
            this.rbNenhuma.AutoSize = true;
            this.rbNenhuma.Location = new System.Drawing.Point(388, 16);
            this.rbNenhuma.Name = "rbNenhuma";
            this.rbNenhuma.Size = new System.Drawing.Size(90, 21);
            this.rbNenhuma.TabIndex = 3;
            this.rbNenhuma.Text = "Nenhuma";
            this.rbNenhuma.UseVisualStyleBackColor = true;
            // 
            // rbIncompleto
            // 
            this.rbIncompleto.AutoSize = true;
            this.rbIncompleto.Location = new System.Drawing.Point(272, 16);
            this.rbIncompleto.Name = "rbIncompleto";
            this.rbIncompleto.Size = new System.Drawing.Size(97, 21);
            this.rbIncompleto.TabIndex = 2;
            this.rbIncompleto.Text = "Incompleto";
            this.rbIncompleto.UseVisualStyleBackColor = true;
            // 
            // rbCompleto
            // 
            this.rbCompleto.AutoSize = true;
            this.rbCompleto.Location = new System.Drawing.Point(148, 17);
            this.rbCompleto.Name = "rbCompleto";
            this.rbCompleto.Size = new System.Drawing.Size(88, 21);
            this.rbCompleto.TabIndex = 1;
            this.rbCompleto.Text = "Completo";
            this.rbCompleto.UseVisualStyleBackColor = true;
            // 
            // rbTodas
            // 
            this.rbTodas.AutoSize = true;
            this.rbTodas.Checked = true;
            this.rbTodas.Location = new System.Drawing.Point(35, 18);
            this.rbTodas.Name = "rbTodas";
            this.rbTodas.Size = new System.Drawing.Size(69, 21);
            this.rbTodas.TabIndex = 0;
            this.rbTodas.TabStop = true;
            this.rbTodas.Text = "Todas";
            this.rbTodas.UseVisualStyleBackColor = true;
            // 
            // gbFiscais
            // 
            this.gbFiscais.Controls.Add(this.rbVendas);
            this.gbFiscais.Controls.Add(this.rbEntradas);
            this.gbFiscais.Controls.Add(this.rbGeral);
            this.gbFiscais.Location = new System.Drawing.Point(433, 9);
            this.gbFiscais.Name = "gbFiscais";
            this.gbFiscais.Size = new System.Drawing.Size(368, 49);
            this.gbFiscais.TabIndex = 0;
            this.gbFiscais.TabStop = false;
            this.gbFiscais.Text = "Notas Fiscais";
            // 
            // rbVendas
            // 
            this.rbVendas.AutoSize = true;
            this.rbVendas.Location = new System.Drawing.Point(257, 18);
            this.rbVendas.Name = "rbVendas";
            this.rbVendas.Size = new System.Drawing.Size(77, 21);
            this.rbVendas.TabIndex = 2;
            this.rbVendas.Text = "Vendas";
            this.rbVendas.UseVisualStyleBackColor = true;
            // 
            // rbEntradas
            // 
            this.rbEntradas.AutoSize = true;
            this.rbEntradas.Location = new System.Drawing.Point(141, 20);
            this.rbEntradas.Name = "rbEntradas";
            this.rbEntradas.Size = new System.Drawing.Size(86, 21);
            this.rbEntradas.TabIndex = 1;
            this.rbEntradas.Text = "Entradas";
            this.rbEntradas.UseVisualStyleBackColor = true;
            // 
            // rbGeral
            // 
            this.rbGeral.AutoSize = true;
            this.rbGeral.Checked = true;
            this.rbGeral.Location = new System.Drawing.Point(31, 19);
            this.rbGeral.Name = "rbGeral";
            this.rbGeral.Size = new System.Drawing.Size(64, 21);
            this.rbGeral.TabIndex = 0;
            this.rbGeral.TabStop = true;
            this.rbGeral.Text = "Geral";
            this.rbGeral.UseVisualStyleBackColor = true;
            // 
            // tcLink
            // 
            this.tcLink.Controls.Add(this.tpDisponivel);
            this.tcLink.Controls.Add(this.tsLigados);
            this.tcLink.Location = new System.Drawing.Point(40, 480);
            this.tcLink.Name = "tcLink";
            this.tcLink.SelectedIndex = 0;
            this.tcLink.Size = new System.Drawing.Size(313, 222);
            this.tcLink.TabIndex = 3;
            // 
            // tpDisponivel
            // 
            this.tpDisponivel.Controls.Add(this.dgvDisponivel);
            this.tpDisponivel.Location = new System.Drawing.Point(4, 25);
            this.tpDisponivel.Name = "tpDisponivel";
            this.tpDisponivel.Padding = new System.Windows.Forms.Padding(3);
            this.tpDisponivel.Size = new System.Drawing.Size(305, 193);
            this.tpDisponivel.TabIndex = 0;
            this.tpDisponivel.Text = "Disponíveis";
            this.tpDisponivel.UseVisualStyleBackColor = true;
            // 
            // dgvDisponivel
            // 
            this.dgvDisponivel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDisponivel.Location = new System.Drawing.Point(14, 10);
            this.dgvDisponivel.Name = "dgvDisponivel";
            this.dgvDisponivel.RowHeadersWidth = 51;
            this.dgvDisponivel.Size = new System.Drawing.Size(251, 80);
            this.dgvDisponivel.TabIndex = 1;
            // 
            // tsLigados
            // 
            this.tsLigados.Controls.Add(this.dgvLink);
            this.tsLigados.Location = new System.Drawing.Point(4, 25);
            this.tsLigados.Name = "tsLigados";
            this.tsLigados.Padding = new System.Windows.Forms.Padding(3);
            this.tsLigados.Size = new System.Drawing.Size(306, 100);
            this.tsLigados.TabIndex = 1;
            this.tsLigados.Text = "Ligados";
            this.tsLigados.UseVisualStyleBackColor = true;
            // 
            // dgvLink
            // 
            this.dgvLink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLink.Location = new System.Drawing.Point(6, 6);
            this.dgvLink.Name = "dgvLink";
            this.dgvLink.RowHeadersWidth = 51;
            this.dgvLink.RowTemplate.Height = 24;
            this.dgvLink.Size = new System.Drawing.Size(251, 80);
            this.dgvLink.TabIndex = 0;
            // 
            // tcVenda
            // 
            this.tcVenda.Controls.Add(this.tsDisponivelVenda);
            this.tcVenda.Controls.Add(this.tsLigadosVenda);
            this.tcVenda.Location = new System.Drawing.Point(204, 480);
            this.tcVenda.Name = "tcVenda";
            this.tcVenda.SelectedIndex = 0;
            this.tcVenda.Size = new System.Drawing.Size(650, 222);
            this.tcVenda.TabIndex = 4;
            // 
            // tsDisponivelVenda
            // 
            this.tsDisponivelVenda.Controls.Add(this.dgvDispVenda);
            this.tsDisponivelVenda.Location = new System.Drawing.Point(4, 25);
            this.tsDisponivelVenda.Name = "tsDisponivelVenda";
            this.tsDisponivelVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tsDisponivelVenda.Size = new System.Drawing.Size(642, 193);
            this.tsDisponivelVenda.TabIndex = 0;
            this.tsDisponivelVenda.Text = "Disponiveis Venda";
            this.tsDisponivelVenda.UseVisualStyleBackColor = true;
            // 
            // dgvDispVenda
            // 
            this.dgvDispVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDispVenda.Location = new System.Drawing.Point(6, 9);
            this.dgvDispVenda.Name = "dgvDispVenda";
            this.dgvDispVenda.RowHeadersWidth = 51;
            this.dgvDispVenda.RowTemplate.Height = 24;
            this.dgvDispVenda.Size = new System.Drawing.Size(725, 81);
            this.dgvDispVenda.TabIndex = 0;
            // 
            // tsLigadosVenda
            // 
            this.tsLigadosVenda.Controls.Add(this.dgvLinkVenda);
            this.tsLigadosVenda.Location = new System.Drawing.Point(4, 25);
            this.tsLigadosVenda.Name = "tsLigadosVenda";
            this.tsLigadosVenda.Padding = new System.Windows.Forms.Padding(3);
            this.tsLigadosVenda.Size = new System.Drawing.Size(772, 98);
            this.tsLigadosVenda.TabIndex = 1;
            this.tsLigadosVenda.Text = "Ligados Venda";
            this.tsLigadosVenda.UseVisualStyleBackColor = true;
            // 
            // dgvLinkVenda
            // 
            this.dgvLinkVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLinkVenda.Location = new System.Drawing.Point(6, 13);
            this.dgvLinkVenda.Name = "dgvLinkVenda";
            this.dgvLinkVenda.RowHeadersWidth = 51;
            this.dgvLinkVenda.RowTemplate.Height = 24;
            this.dgvLinkVenda.Size = new System.Drawing.Size(679, 71);
            this.dgvLinkVenda.TabIndex = 0;
            // 
            // pnToolStrip
            // 
            this.pnToolStrip.Controls.Add(this.toolStrip1);
            this.pnToolStrip.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnToolStrip.Location = new System.Drawing.Point(1353, 70);
            this.pnToolStrip.Name = "pnToolStrip";
            this.pnToolStrip.Size = new System.Drawing.Size(100, 655);
            this.pnToolStrip.TabIndex = 10;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripNovo,
            this.toolStripEdicao,
            this.toolStripDelete,
            this.toolStripConfirme,
            this.toolStripCancele,
            this.toolStripConsulta});
            this.toolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(100, 655);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripNovo
            // 
            this.toolStripNovo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripNovo.Image")));
            this.toolStripNovo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNovo.Name = "toolStripNovo";
            this.toolStripNovo.Size = new System.Drawing.Size(66, 24);
            this.toolStripNovo.Text = "&Novo";
            this.toolStripNovo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripEdicao
            // 
            this.toolStripEdicao.Image = ((System.Drawing.Image)(resources.GetObject("toolStripEdicao.Image")));
            this.toolStripEdicao.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripEdicao.Name = "toolStripEdicao";
            this.toolStripEdicao.Size = new System.Drawing.Size(72, 24);
            this.toolStripEdicao.Text = "&Edição";
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(72, 24);
            this.toolStripDelete.Text = "Delete";
            // 
            // toolStripConfirme
            // 
            this.toolStripConfirme.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConfirme.Image")));
            this.toolStripConfirme.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConfirme.Name = "toolStripConfirme";
            this.toolStripConfirme.Size = new System.Drawing.Size(89, 24);
            this.toolStripConfirme.Text = "&Confirme";
            // 
            // toolStripCancele
            // 
            this.toolStripCancele.Image = ((System.Drawing.Image)(resources.GetObject("toolStripCancele.Image")));
            this.toolStripCancele.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCancele.Name = "toolStripCancele";
            this.toolStripCancele.Size = new System.Drawing.Size(80, 24);
            this.toolStripCancele.Text = "Cancele";
            // 
            // toolStripConsulta
            // 
            this.toolStripConsulta.Image = ((System.Drawing.Image)(resources.GetObject("toolStripConsulta.Image")));
            this.toolStripConsulta.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripConsulta.Name = "toolStripConsulta";
            this.toolStripConsulta.Size = new System.Drawing.Size(87, 24);
            this.toolStripConsulta.Text = "C&onsulta";
            this.toolStripConsulta.Click += new System.EventHandler(this.toolStripConsulta_Click);
            // 
            // pnMestre
            // 
            this.pnMestre.AutoScroll = true;
            this.pnMestre.Controls.Add(this.pnMestreSub);
            this.pnMestre.Controls.Add(this.tcMestre);
            this.pnMestre.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMestre.Location = new System.Drawing.Point(0, 70);
            this.pnMestre.Name = "pnMestre";
            this.pnMestre.Size = new System.Drawing.Size(1353, 230);
            this.pnMestre.TabIndex = 11;
            // 
            // pnMestreSub
            // 
            this.pnMestreSub.Controls.Add(this.statusMestre);
            this.pnMestreSub.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnMestreSub.Location = new System.Drawing.Point(0, 200);
            this.pnMestreSub.Name = "pnMestreSub";
            this.pnMestreSub.Size = new System.Drawing.Size(1332, 46);
            this.pnMestreSub.TabIndex = 3;
            // 
            // statusMestre
            // 
            this.statusMestre.Dock = System.Windows.Forms.DockStyle.None;
            this.statusMestre.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusMestre.Location = new System.Drawing.Point(424, 9);
            this.statusMestre.Name = "statusMestre";
            this.statusMestre.Size = new System.Drawing.Size(202, 22);
            this.statusMestre.TabIndex = 0;
            this.statusMestre.Text = "statusStrip1";
            // 
            // tcMestre
            // 
            this.tcMestre.Controls.Add(this.tsMestre);
            this.tcMestre.Dock = System.Windows.Forms.DockStyle.Top;
            this.tcMestre.Location = new System.Drawing.Point(0, 0);
            this.tcMestre.Name = "tcMestre";
            this.tcMestre.SelectedIndex = 0;
            this.tcMestre.Size = new System.Drawing.Size(1332, 200);
            this.tcMestre.TabIndex = 2;
            // 
            // tsMestre
            // 
            this.tsMestre.AutoScroll = true;
            this.tsMestre.Controls.Add(this.dgvMestre);
            this.tsMestre.Location = new System.Drawing.Point(4, 25);
            this.tsMestre.Name = "tsMestre";
            this.tsMestre.Padding = new System.Windows.Forms.Padding(3);
            this.tsMestre.Size = new System.Drawing.Size(1324, 171);
            this.tsMestre.TabIndex = 0;
            this.tsMestre.Text = "Notas Fiscais";
            this.tsMestre.UseVisualStyleBackColor = true;
            // 
            // dgvMestre
            // 
            this.dgvMestre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMestre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMestre.Location = new System.Drawing.Point(3, 3);
            this.dgvMestre.Name = "dgvMestre";
            this.dgvMestre.RowHeadersWidth = 18;
            this.dgvMestre.RowTemplate.Height = 18;
            this.dgvMestre.Size = new System.Drawing.Size(1318, 165);
            this.dgvMestre.TabIndex = 0;
            // 
            // pnNFs
            // 
            this.pnNFs.Controls.Add(this.tcItens);
            this.pnNFs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnNFs.Location = new System.Drawing.Point(0, 300);
            this.pnNFs.Name = "pnNFs";
            this.pnNFs.Size = new System.Drawing.Size(1353, 160);
            this.pnNFs.TabIndex = 12;
            // 
            // tcItens
            // 
            this.tcItens.Controls.Add(this.tsItens);
            this.tcItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcItens.Location = new System.Drawing.Point(0, 0);
            this.tcItens.Name = "tcItens";
            this.tcItens.SelectedIndex = 0;
            this.tcItens.Size = new System.Drawing.Size(1353, 160);
            this.tcItens.TabIndex = 3;
            // 
            // tsItens
            // 
            this.tsItens.Controls.Add(this.dgvItens);
            this.tsItens.Location = new System.Drawing.Point(4, 25);
            this.tsItens.Name = "tsItens";
            this.tsItens.Padding = new System.Windows.Forms.Padding(3);
            this.tsItens.Size = new System.Drawing.Size(1345, 131);
            this.tsItens.TabIndex = 0;
            this.tsItens.Text = "Itens da NF";
            this.tsItens.UseVisualStyleBackColor = true;
            // 
            // dgvItens
            // 
            this.dgvItens.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItens.Location = new System.Drawing.Point(3, 3);
            this.dgvItens.Name = "dgvItens";
            this.dgvItens.RowHeadersWidth = 51;
            this.dgvItens.RowTemplate.Height = 24;
            this.dgvItens.Size = new System.Drawing.Size(1339, 125);
            this.dgvItens.TabIndex = 0;
            // 
            // FrmFiscal_Novo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1453, 725);
            this.Controls.Add(this.pnNFs);
            this.Controls.Add(this.pnMestre);
            this.Controls.Add(this.pnToolStrip);
            this.Controls.Add(this.tcVenda);
            this.Controls.Add(this.tcLink);
            this.Controls.Add(this.pnCabecalho);
            this.Name = "FrmFiscal_Novo";
            this.Text = "FrmFiscal_Novo";
            this.pnCabecalho.ResumeLayout(false);
            this.pnCabecalho.PerformLayout();
            this.gbCritica.ResumeLayout(false);
            this.gbCritica.PerformLayout();
            this.gbFiscais.ResumeLayout(false);
            this.gbFiscais.PerformLayout();
            this.tcLink.ResumeLayout(false);
            this.tpDisponivel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDisponivel)).EndInit();
            this.tsLigados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLink)).EndInit();
            this.tcVenda.ResumeLayout(false);
            this.tsDisponivelVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDispVenda)).EndInit();
            this.tsLigadosVenda.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLinkVenda)).EndInit();
            this.pnToolStrip.ResumeLayout(false);
            this.pnToolStrip.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.pnMestre.ResumeLayout(false);
            this.pnMestreSub.ResumeLayout(false);
            this.pnMestreSub.PerformLayout();
            this.tcMestre.ResumeLayout(false);
            this.tsMestre.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMestre)).EndInit();
            this.pnNFs.ResumeLayout(false);
            this.tcItens.ResumeLayout(false);
            this.tsItens.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItens)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnCabecalho;
        private System.Windows.Forms.TabControl tcLink;
        private System.Windows.Forms.TabPage tpDisponivel;
        private System.Windows.Forms.DataGridView dgvDisponivel;
        private System.Windows.Forms.TabPage tsLigados;
        private System.Windows.Forms.DataGridView dgvLink;
        private System.Windows.Forms.TabControl tcVenda;
        private System.Windows.Forms.TabPage tsDisponivelVenda;
        private System.Windows.Forms.DataGridView dgvDispVenda;
        private System.Windows.Forms.TabPage tsLigadosVenda;
        private System.Windows.Forms.DataGridView dgvLinkVenda;
        private System.Windows.Forms.GroupBox gbFiscais;
        private System.Windows.Forms.TextBox txFazenda;
        private System.Windows.Forms.TextBox txCFOP;
        private System.Windows.Forms.GroupBox gbCritica;
        private System.Windows.Forms.RadioButton rbNenhuma;
        private System.Windows.Forms.RadioButton rbIncompleto;
        private System.Windows.Forms.RadioButton rbCompleto;
        private System.Windows.Forms.RadioButton rbTodas;
        private System.Windows.Forms.RadioButton rbVendas;
        private System.Windows.Forms.RadioButton rbEntradas;
        private System.Windows.Forms.RadioButton rbGeral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnToolStrip;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripNovo;
        private System.Windows.Forms.ToolStripButton toolStripEdicao;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.ToolStripButton toolStripConfirme;
        private System.Windows.Forms.ToolStripButton toolStripCancele;
        private System.Windows.Forms.ToolStripButton toolStripConsulta;
        private System.Windows.Forms.Panel pnMestre;
        private System.Windows.Forms.TabControl tcMestre;
        private System.Windows.Forms.TabPage tsMestre;
        private System.Windows.Forms.Panel pnNFs;
        private System.Windows.Forms.TabControl tcItens;
        private System.Windows.Forms.TabPage tsItens;
        private System.Windows.Forms.DataGridView dgvItens;
        private System.Windows.Forms.DataGridView dgvMestre;
        private System.Windows.Forms.Panel pnMestreSub;
        private System.Windows.Forms.StatusStrip statusMestre;
    }
}