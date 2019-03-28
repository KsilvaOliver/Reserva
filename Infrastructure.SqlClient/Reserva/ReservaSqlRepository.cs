using Reserva.Model;
using Reserva.Repositories;
using Microsoft.Practices.EnterpriseLibrary.Data;
using System;
using System.Data.Common;
using System.Data;
using Reserva.Comum;
using System.Configuration;

namespace Infrastructure.SqlClient.Reserva
{
    public class ReservaSqlRepository: IReservaRepository
    {
        public ReservaModel Consultar(string Token, string Cpf, string Matricula, string senha)
        {
            ReservaModel reservaModel = new ReservaModel();

            Database db = DataHelper.CreateDatabase();
            using (DbCommand dbCommand = db.GetStoredProcCommand("P_LISTA_SERVIDORES_WEB_SERVICE"))
            {
                db.AddInParameter(dbCommand, "@TOKEN", DbType.String, Token);
                db.AddInParameter(dbCommand, "@CPF", DbType.String, Cpf);
                db.AddInParameter(dbCommand, "@MATRICULA", DbType.String, Matricula);
                db.AddInParameter(dbCommand, "@SENHA", DbType.String, senha);

                using (IDataReader reader = db.ExecuteReader(dbCommand))
                {
                    if (reader.Read())
                    {
                        string retorno = DataHelper.ToGenericValue<string>(reader, "Retorno");
                        if (retorno == ConfigurationManager.AppSettings["ServidorLocalizado"])
                            reservaModel = Mapping(reader);

                        reservaModel.Retorno = retorno;
                    }
                       
                }
            }
            return reservaModel;
        }


        public Int32 Incluir(ReservaModel Reserva)
        {
            int retorno = 0;

            Database db = DataHelper.CreateDatabase();
            using (DbCommand dbCommand = db.GetStoredProcCommand("P_INCLUIR_PRE_RESERVA_MARGEM_WEB_SERVICE"))
            {
                db.AddInParameter(dbCommand, "@TOKEN", DbType.String, Reserva.Token);
                db.AddInParameter(dbCommand, "@CPF", DbType.String, Reserva.Cpf);
                db.AddInParameter(dbCommand, "@MATRICULA", DbType.String, Reserva.Matricula);
                db.AddInParameter(dbCommand, "@SENHA", DbType.String, Reserva.Senha);
                db.AddInParameter(dbCommand, "@BANCO", DbType.String, Reserva.Banco);
                db.AddInParameter(dbCommand, "@AGENCIA", DbType.String, Reserva.Agencia);
                db.AddInParameter(dbCommand, "@CONTA", DbType.String, Reserva.Conta);
                db.AddInParameter(dbCommand, "@VL_PRESTACAO", DbType.Decimal, Reserva.ValorPrestacao);
                db.AddInParameter(dbCommand, "@VL_LIBERADO", DbType.Decimal, Reserva.ValorLiberado);
                db.AddInParameter(dbCommand, "@QT_PRESTACAO", DbType.Int16, Reserva.QuantidadePrestacoes);
                db.AddInParameter(dbCommand, "@VL_OPERACAO", DbType.Decimal, Reserva.ValorTotalOperacao);

                using (IDataReader reader = db.ExecuteReader(dbCommand))
                {
                    if (reader.Read())
                        retorno = DataHelper.ToGenericValue<int>(reader, "RETORNO");
                }
            }
            return retorno;
        }

        private ReservaModel Mapping( IDataReader reader )
        {
            return new ReservaModel()
            {
                Cpf = DataHelper.ToGenericValue<string>(reader, "CPF"),
                Matricula = DataHelper.ToGenericValue<string>(reader, "MATRICULA"),
                Nome = DataHelper.ToGenericValue<string>(reader, "NOME"),
                DataNascimento = DataHelper.ToGenericValue<DateTime>(reader, "DATA DE NASCIMENTO"),
                NomeCategoria = DataHelper.ToGenericValue<string>(reader, "NOME DACATEGORIA"),
                SituacaoServidor = DataHelper.ToGenericValue<string>(reader, "SITUACAO DO SERVIDOR"),
                Convenio = DataHelper.ToGenericValue<string>(reader, "CONVÊNIO"),
                Produto = DataHelper.ToGenericValue<string>(reader, "PRODUTO"),
                MargemDisponivel = DataHelper.ToGenericValue<decimal>(reader, "MARGEM DISPONÍVEL"),
                ListaParcelas = DataHelper.ToGenericValue<string>(reader, "LISTA DE PARCELAS")
            };
        }
    }
}
