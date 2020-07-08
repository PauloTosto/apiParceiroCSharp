using System;
using System.Data;
using System.Windows.Forms;
using PrjApiParceiro_C.AcessosServidor;
using System.Collections.Generic;
using PrjApiParceiro_C.Services;
using PrjApiParceiro_C.Comum;
using PrjApiParceiro_C.Config_Componentes;

namespace PrjApiParceiro_C.Fiscais
{
    public partial class FrmFiscal_Novo : Form
    {
        //private MonteGrid oMestreColheita;
        //private MonteGrid oServicoColheita;
        private BindingSource mestreBSource = new BindingSource();
        private BindingSource itensFiscalBSource = new BindingSource();

        // private BindingSource servicoColheitaBSource = new BindingSource();
        DataSet odataset;
        MonteGrid oMestre;
        MonteGrid oItensFis;
        public FrmFiscal_Novo()
        {
            InitializeComponent();
            MonteGrids();
        }

        private async void toolStripConsulta_Click(object sender, EventArgs e)
        {

            DateTime data1, data2;
            data1 = new DateTime(2020, 01, 01);
            data2 = new DateTime(2020, 07, 01);
            Boolean ok = await ClassEventosNF.CargaNFeXML(data1, data2);
            if (ok == false) { MessageBox.Show("Problema na Carga Fiscal "); return; }
            odataset = ClassEventosNF.odataset;
            mestreBSource.DataSource = odataset.Tables["Mestre"];
            itensFiscalBSource.DataSource = odataset.Tables["ItensFis"];
            
            oMestre.ConfigureDBGridView();
            oMestre.FuncaoSoma();
            oMestre.ColocaTotais();

            oItensFis.ConfigureDBGridView();

            if (mestreBSource.DataSource != null)
            {
                DataView otable = (mestreBSource.DataSource as DataTable).AsDataView();
                if (otable.Count > 0)
                {   DataRowView registro = otable[0];
                    if (registro != null)
                    {   int nfiscal = Convert.ToInt32(registro["NFISCAL"]);
                        itensFiscalBSource.DataSource = odataset.Tables["ItensFis"].AsEnumerable().Where(row => row.Field<int>("ID_NF") == nfiscal).CopyToDataTable();
                    }
                }
            }

            mestreBSource.CurrentItemChanged += Mestre_PositionChanged;


            // MessageBox.Show("sucessos " + odataset.Tables.Count.ToString());

        }


        void Mestre_PositionChanged(object sender, EventArgs e)
        {

            DataRowView registro = ((sender as BindingSource).Current as DataRowView);
           
            if (registro != null)
            {
                int nfiscal = Convert.ToInt32(registro["NFISCAL"]);
                itensFiscalBSource.DataSource = odataset.Tables["ItensFis"].AsEnumerable().Where(row => row.Field<int>("ID_NF") == nfiscal).CopyToDataTable();
            }
            else
            { itensFiscalBSource.DataSource = null; }

        }

        private void MonteGrids()
        {
            oMestre = new MonteGrid();
            oMestre.LinhasMinimas = 4; // default é 3
            dgvMestre.DataSource = mestreBSource;
            oMestre.oDataGridView = dgvMestre;
            oMestre.sbTotal = statusMestre;
            oMestre.Clear();

            oMestre.AddValores("DTAEMI", "Emissão", 8, "dd/MM/yyyy", false, 0, "");
            oMestre.AddValores("EVENTO", "Canc", 5, "", false, 0, "");
            oMestre.AddValores("TPNF", "E/S", 3, "", false, 0, "");
            oMestre.AddValores("CFOP", "cfpo", 5, "", false, 0, "");
            oMestre.AddValores("NATOP", "NatOp", 15, "", false, 0, "");
            oMestre.AddValores("CRITICA", "Critica", 12, "", false, 0, "");
            oMestre.AddValores("NFISCAL", "NFiscal", 8, "", false, 0, "");
            oMestre.AddValores("DEST_NOME", "Destinatario", 30, "", false, 0, "");
            oMestre.AddValores("FIRMA", "Contabil", 10, "", false, 0, "");
            oMestre.AddValores("QUANT_NF", "Quant.Fiscal", 0, "##,##0.00", true, 0, "");
            oMestre.AddValores("VLRNF", "Vlr Fiscal", 0, "###,##0.00", true, 0, "");
            oMestre.AddValores("CODFAZ", "Faz.", 5, "", false, 0, "");
            oMestre.AddValores("DEST_CNPJ", "CNPJ/CPF", 14, "", false, 0, "");
            oMestre.AddValores("XLGR", "Nome Fazenda", 12, "", false, 0, "");
            oMestre.AddValores("FINNF", "Finalidade", 12, "", false, 0, "");
            oMestre.AddValores("IDDEST", "Destino Operação", 12, "", false, 0, "");

            dgvMestre.AllowUserToAddRows = false;
            dgvMestre.AllowUserToDeleteRows = false;
            dgvMestre.AllowUserToOrderColumns = true;
            dgvMestre.ReadOnly = true;


            dgvMestre.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;
            

            oItensFis = new MonteGrid();
            oItensFis.LinhasMinimas = 4; // default é 3
            dgvItens.DataSource = itensFiscalBSource;
            oItensFis.oDataGridView = dgvItens;
           // oItensFis.sbTotal = statusMestre;
            oItensFis.Clear();


            oItensFis.AddValores("CFOP", "CFOP", 5, "", false, 0, "");
            oItensFis.AddValores("cProd", "cProd", 4, "", false, 0, "");
            oItensFis.AddValores("xProd", "Descricao Produto", 15, "", false, 0, "");
            oItensFis.AddValores("cUnid", "Unid Com", 4, "", false, 0, "");
            oItensFis.AddValores("cQuant", "Quant.Com", 0, "###,##0.00", true, 0, "");
            oItensFis.AddValores("cPUnit", "Preço Unit", 0, "###,##0.00", true, 0, "");
            oItensFis.AddValores("cVlr", "Valor", 0, "###,##0.00", true, 0, "");
            oItensFis.AddValores("InfAdProd", "Informe Adcionais", 100, "", false, 0, "");

            dgvItens.AllowUserToAddRows = false;
            dgvItens.AllowUserToDeleteRows = false;
            dgvItens.AllowUserToOrderColumns = true;
            dgvItens.ReadOnly = true;


            dgvItens.ClipboardCopyMode = DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText;




        }



        /*
         * procedure TNFiscais_Novo.MonteGrids;
var
  campo: TField;
begin
  with oMestre do
  begin
    Campos.clear;

    Campos.Add('DTAEMI');
    Campos.Cabecalho[Campos.Count - 1] := 'Emissão';

    Campos.Add('Evento');
    Campos.Cabecalho[Campos.Count - 1] := 'Canc';
    Campos.Tamanho[Campos.Count - 1] := 4;

    Campos.Add('TPNF');
    Campos.Cabecalho[Campos.Count - 1] := 'E/S';

    Campos.Add('CFOP');
    Campos.Cabecalho[Campos.Count - 1] := 'CFOP';
    Campos.Tamanho[Campos.Count - 1] := 5;

    Campos.Add('NatOp');
    Campos.Cabecalho[Campos.Count - 1] := 'NatOp';
    Campos.Tamanho[Campos.Count - 1] := 15;

    Campos.Add('CRITICA');
    Campos.Cabecalho[Campos.Count - 1] := 'Critica';
    Campos.Tamanho[Campos.Count - 1] := 15;

    Campos.Add('NFISCAL');
    Campos.Cabecalho[Campos.Count - 1] := 'NFiscal';
    Campos.Tamanho[Campos.Count - 1] := 8;

    Campos.Add('DEST_NOME');
    Campos.Cabecalho[Campos.Count - 1] := 'Destinatario';
    Campos.Tamanho[Campos.Count - 1] := 30;

    Campos.Add('FIRMA');
    Campos.Cabecalho[Campos.Count - 1] := 'Contabil';
    Campos.Tamanho[Campos.Count - 1] := 10;

    Campos.Add('Quant_NF');
    Campos.Cabecalho[Campos.Count - 1] := 'Quant. Fiscal';
    Campos.Soma[Campos.Count - 1] := true;

    Campos.Add('vlrNF');
    Campos.Cabecalho[Campos.Count - 1] := 'Vlr Fiscal';
    Campos.Soma[Campos.Count - 1] := true;

    Campos.Add('CODFAZ');
    Campos.Cabecalho[Campos.Count - 1] := 'Faz.';
    Campos.Tamanho[Campos.Count - 1] := 5;

    Campos.Add('DEST_CNPJ');
    Campos.Cabecalho[Campos.Count - 1] := 'CNPJ/CPF';

    Campos.Add('xlgr');
    Campos.Cabecalho[Campos.Count - 1] := 'Nome Fazenda';
    Campos.Tamanho[Campos.Count - 1] := 12;

    Campos.Add('FINNF');
    Campos.Cabecalho[Campos.Count - 1] := 'Finalidade';

    Campos.Add('IDDEST');
    Campos.Cabecalho[Campos.Count - 1] := 'Destino Operação';

    // faltou outras informações
  end;
  with oItens do
  begin
    Campos.clear;
    Campos.Add('CFOP');
    Campos.Cabecalho[Campos.Count - 1] := 'CFOP';
    Campos.Tamanho[Campos.Count - 1] := 5;
    Campos.Add('cProd');
    Campos.Cabecalho[Campos.Count - 1] := 'cProd';
    Campos.Tamanho[Campos.Count - 1] := 4;
    Campos.Add('xProd');
    Campos.Cabecalho[Campos.Count - 1] := 'Descricao Produto';
    Campos.Tamanho[Campos.Count - 1] := 15;
    Campos.Add('cUnid');
    Campos.Cabecalho[Campos.Count - 1] := 'Unid Com';
    Campos.Tamanho[Campos.Count - 1] := 4;
    Campos.Add('cQuant');
    Campos.Cabecalho[Campos.Count - 1] := 'Quant. Com';
    Campos.Add('cPUnit');
    Campos.Cabecalho[Campos.Count - 1] := 'Preço Unit';

    Campos.Add('cVlr');
    Campos.Cabecalho[Campos.Count - 1] := 'Valor';

    Campos.Add('InfAdProd');
    Campos.Cabecalho[Campos.Count - 1] := 'Informe Adcionais';

  end;

  with oLoteDisp do
  begin
    Campos.clear;
    Campos.Add('SETOR');
    Campos.Cabecalho[Campos.Count - 1] := 'SETOR';
    Campos.Tamanho[Campos.Count - 1] := 5;
    Campos.Add('LOTE');
    Campos.Cabecalho[Campos.Count - 1] := 'Lote';
    Campos.Tamanho[Campos.Count - 1] := 4;
    Campos.Add('DTA_ENT');
    Campos.Cabecalho[Campos.Count - 1] := 'Dta Depos';

    Campos.AddValores('SDOKG_ENT', 'Quant Disponivel', 0, true, 0);

  end;

  with oNfeLote do
  begin
    Campos.clear;
    Campos.Add('SETOR');
    Campos.Cabecalho[Campos.Count - 1] := 'Setor';
    Campos.Tamanho[Campos.Count - 1] := 5;
    Campos.Add('LOTE');
    Campos.Cabecalho[Campos.Count - 1] := 'Lote';
    Campos.Tamanho[Campos.Count - 1] := 4;
    Campos.Add('DTA_ENT');
    Campos.Cabecalho[Campos.Count - 1] := 'Dta Depos';
    Campos.Add('DTA_EMI');
    Campos.Cabecalho[Campos.Count - 1] := 'Emissão';
    Campos.AddValores('KG', 'Quant Link', 0, true, 0);
  end;

  with oVendaDisp do
  begin
    Campos.clear;
    Campos.Add('FIRMA');
    Campos.Cabecalho[Campos.Count - 1] := 'FIRMA';
    Campos.Tamanho[Campos.Count - 1] := 8;

    Campos.Add('DESCFIRMA');
    Campos.Cabecalho[Campos.Count - 1] := 'NOME';
    Campos.Tamanho[Campos.Count - 1] := 20;

    // oTable.FindField('TIPOPROD').onSetText := TGetSet.TpProdSetText;
    oTable.FindField('PROD_TP').onGetText := TGetSet.TpProdGetText;

    Campos.Add('PROD_TP');
    Campos.Cabecalho[Campos.Count - 1] := 'Tipo Prod';
    Campos.Tamanho[Campos.Count - 1] := 12;

    Campos.Add('CERTIF');
    Campos.Cabecalho[Campos.Count - 1] := 'Certif';
    Campos.Tamanho[Campos.Count - 1] := 6;

    Campos.Add('PROD');
    Campos.Cabecalho[Campos.Count - 1] := 'Prod';
    Campos.Tamanho[Campos.Count - 1] := 4;

    Campos.Add('SAFRA');
    Campos.Cabecalho[Campos.Count - 1] := 'Safra';
    Campos.Tamanho[Campos.Count - 1] := 4;

    Campos.Add('CONT');
    Campos.Cabecalho[Campos.Count - 1] := 'Contrato';
    Campos.Tamanho[Campos.Count - 1] := 4;

    Campos.Add('DATA');
    Campos.Cabecalho[Campos.Count - 1] := 'Dta';

    Campos.AddValores('SDOQUANT', 'Quant Disponivel', 0, true, 0);

  end;

  with oNfeVenda do
  begin
    Campos.clear;
    Campos.Add('FIRMA');
    Campos.Cabecalho[Campos.Count - 1] := 'FIRMA';
    Campos.Tamanho[Campos.Count - 1] := 8;
    Campos.Add('SAFRA');
    Campos.Cabecalho[Campos.Count - 1] := 'Safra';
    Campos.Tamanho[Campos.Count - 1] := 4;

    Campos.Add('CONT');
    Campos.Cabecalho[Campos.Count - 1] := 'Contrato';
    Campos.Tamanho[Campos.Count - 1] := 4;

    Campos.Add('DTA_VENDA');
    Campos.Cabecalho[Campos.Count - 1] := 'Dta Venda';

    Campos.Cabecalho[Campos.Count - 1] := 'Quant.';
    Campos.AddValores('QUANT_V', 'Quant Link', 0, true, 0);
  end;

         */

    }
}
