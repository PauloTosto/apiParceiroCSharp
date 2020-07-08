﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.IO;

using PrjApiParceiro_C.Core;

namespace PrjApiParceiro_C
{
    public partial class WinFrmConfigura : Form
    {
        public string servidor = "";
        public Dictionary<string, string> ListaCaminhos; 
        public WinFrmConfigura()
        {
            if (File.Exists(Environment.SpecialFolder.LocalApplicationData + "ConfigServidor.txt"))
            {
                ListaCaminhos = AcessosStream.LeiaLista(Environment.SpecialFolder.LocalApplicationData + "ConfigServidor.txt");
                servidor = ListaCaminhos["SERVIDOR_IP"];

            }


            
             
            InitializeComponent();
            textBoxServidor.Text = servidor; 


        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            
            ListaCaminhos["SERVIDOR_IP"] = servidor;
            
            AcessosStream.WriteLista(Environment.SpecialFolder.LocalApplicationData + "ConfigServidor.txt",ListaCaminhos);
                
        }




        
        private void TextBoxServidor_Validating(object sender, CancelEventArgs e)
        {
            servidor = (sender as TextBox).Text;
            if (servidor == "") { return; }
             bool Sucesso = TestaConexao.CheckForInternetConnection(servidor);
            if (!Sucesso)
            {
                servidor = "";
                e.Cancel = true;
                MessageBox.Show("Servidor Invalido");
            }
        }

        
        

        

    }


}
