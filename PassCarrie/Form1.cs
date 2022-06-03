using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using Classes;

// ===============================
// AUTHOR       : JEFFERSON BRANDÃO DA COSTA - ANALISTA/PROGRAMADOR
// CREATE DATE  : 14/07/2017  dd/mm/yyyy
// DESCRIPTION  : Ler serial de cada carrie, passado pelo processo e contabilizar o uso de cada
// SPECIAL NOTES: 
// ===============================
// Change History: version 1.0.0 
// Date: 
//==================================

namespace PassCarrie
{
    public partial class Carrie : Form
    {
        public Carrie()
        {
            InitializeComponent();
            //
            #region RODAPÉ

            int anoCriacao = 2017;
            int anoAtual = DateTime.Now.Year;
            string texto = anoCriacao == anoAtual ? " Foxconn CNSBG All Rights Reserved." : "-" + anoAtual + " Foxconn CNSBG All Rights Reserved.";
            //
            lbRodape.Text = "Copyright © " + anoCriacao + texto;

            #endregion
            //
            lbAviso.Visible = false;
        }
        //
        #region SOM AVISO

        private void SomErro()
        {
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory;
                SoundPlayer som = new SoundPlayer(caminho + "/sound/fail.wav");
                som.Play();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;

            }
        }
        //
        private void SomOk()
        {
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory;
                SoundPlayer som = new SoundPlayer(caminho + "/sound/pass.wav");
                som.Play();
            }
            catch (Exception ex)
            {
                string erro = ex.Message;
            }
        }

        #endregion      
        //
        private void txtSerial_KeyUp(object sender, KeyEventArgs e)
        { 
            if (e.KeyCode == Keys.Enter)
            {
                //Do something
                e.Handled = true;

                string serial = txtSerial.Text.Trim().ToUpper();
                //
                if (!string.IsNullOrEmpty(serial))
                {
                    RegistraCarrie(serial);
                }
                else
                {
                    lbAviso.Visible = true;
                    lbAviso.Text = "Erro:: Favor scanear número do serial";
                    //
                    SomErro();
                }
                //
                txtSerial.SelectAll();//deixa selecionado valor
            }
        }

        public string Usado(string serial)
        {
            #region PEGA O VALOR ATUAL DA QUANTIDADE USADA DO SERIAL

            string totalUsado = "0";
            //
            MySQLDbConnect Objconn = new MySQLDbConnect();
            //           
            Objconn.Conectar();
            Objconn.Parametros.Clear();
            //         
            string Sql = @"SELECT usado FROM carrie.carrie  WHERE serial  = '" + serial + "'";
            //                  
            Objconn.SetarSQL(Sql);
            Objconn.Executar();
            Objconn.Desconectar();
            //
            if (Objconn.Isvalid)
            {
                if (Objconn.Tabela.Rows.Count > 0)
                {
                    totalUsado = string.IsNullOrEmpty(Objconn.Tabela.Rows[0]["usado"].ToString()) ? "0" : Objconn.Tabela.Rows[0]["usado"].ToString();
                }
                else
                {
                    lbAviso.Visible = true;
                    lbAviso.Text = "Erro:: Serial não existe";
                    //
                    SomErro();
                    totalUsado = "Erro::";
                }
            }
            else
            {
                lbAviso.Visible = true;
                lbAviso.Text = "Erro::" + Objconn.Message;
                //
                SomErro();
                totalUsado = "Erro::";
            }

            return totalUsado;

            #endregion
        }

        public void RegistraCarrie(string serial)
        {
            #region UPDATE

            MySQLDbConnect Objconn = new MySQLDbConnect();
            //
            string dataAtual = DateTime.Now.Date.ToString("yyyy-MM-dd") + " " + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second;
            string qtdUsado = Usado(serial);
            //
            if (!qtdUsado.Contains("Erro::"))
            {                
                int usado = int.Parse(qtdUsado) + 1;//incrementa uso com '1'. Cada vez que serial for scaneado no processo
                //
                Objconn.Conectar();
                Objconn.Parametros.Clear();
                //         
                string Sql = @"UPDATE carrie.carrie  SET  data_inicio = '" + dataAtual + "', usado = '" + usado + @"'                                                              
                                  WHERE serial  = '" + serial + "'";
                Objconn.SetarSQL(Sql);
                Objconn.Executar();
                Objconn.Desconectar();
                //
                if (Objconn.Isvalid)
                {
                    lbAviso.Visible = false;
                    SomOk();
                }
                else
                {
                    lbAviso.Visible = true;
                    lbAviso.Text = "Erro::" + Objconn.Message;
                    //
                    SomErro();
                }
            }

            #endregion
        }

        //*deixa setado cursor no textbox*
        //private void txtSerial_Enter(object sender, EventArgs e)
        //{
        //    if (!String.IsNullOrEmpty(txtSerial.Text))
        //    {
        //        //txtSerial.SelectionStart = 0;
        //        //txtSerial.SelectionLength = txtSerial.Text.Length;

        //        txtSerial.SelectAll();
        //    }
        //}
        //
    }
}
