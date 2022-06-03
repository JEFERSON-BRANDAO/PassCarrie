using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Classes
{
    class StringConexao
    {
        public string Server()
        {
            #region ENDEREÇO SERVIDOR

            string IpServer = string.Empty;
            //
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\CONFIG\conexao.txt";
                string linha;
                int row = 0;
                //
                if (System.IO.File.Exists(caminho))
                {
                    System.IO.StreamReader arqTXT = new System.IO.StreamReader(caminho);
                    //
                    while ((linha = arqTXT.ReadLine()) != null)
                    {
                        if (row == 0)//primeira linha do .txt
                        {
                            for (int indice = 0; indice < linha.Length; indice++)
                            {
                                if (indice > 9)//IP_SERVER:xx.xx.xxx.xxx pega string a partir da décima posicao
                                {
                                    IpServer += linha[indice];
                                }
                            }
                        }
                        //
                        row++;
                    }
                    //
                    arqTXT.Close();
                }

            }
            catch
            {
                //
            }
            //
            return IpServer;

            #endregion
        }

        public string DataBase()
        {
            #region NOME DA BASE DE DADOS

            string dataBase = string.Empty;
            //
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\CONFIG\conexao.txt";
                string linha;
                int row = 0;
                //
                if (System.IO.File.Exists(caminho))
                {
                    System.IO.StreamReader arqTXT = new System.IO.StreamReader(caminho);
                    //
                    while ((linha = arqTXT.ReadLine()) != null)
                    {
                        if (row == 1)//segunda linha do .txt
                        {
                            for (int indice = 0; indice < linha.Length; indice++)
                            {
                                if (indice > 8)
                                {
                                    dataBase += linha[indice];
                                }
                            }
                        }
                        //
                        row++;
                    }
                    //
                    arqTXT.Close();
                }

            }
            catch
            {
                //
            }
            //
            return dataBase;

            #endregion
        }

        public string Senha()
        {
            #region SENHA BASE DE DADOS

            string senha = string.Empty;
            //
            try
            {
                string caminho = AppDomain.CurrentDomain.BaseDirectory + @"\CONFIG\conexao.txt";
                string linha;
                int row = 0;
                //
                if (System.IO.File.Exists(caminho))
                {
                    System.IO.StreamReader arqTXT = new System.IO.StreamReader(caminho);
                    //
                    while ((linha = arqTXT.ReadLine()) != null)
                    {
                        if (row == 2)//terceira linha do .txt
                        {
                            for (int indice = 0; indice < linha.Length; indice++)
                            {
                                if (indice > 3)
                                {
                                    senha += linha[indice];
                                }
                            }
                        }
                        //
                        row++;
                    }
                    //
                    arqTXT.Close();
                }

            }
            catch
            {
                //
            }
            //
            Criptografia s = new Criptografia();
            return s.Descriptografar(senha); 

            #endregion
        }
    }
}
