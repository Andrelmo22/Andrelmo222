using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace BLL
{
    public class ClienteBLL
    {
        public void Atualizar(string pcpf,
                              DateTime? pDataNascimento,
                              string pNumeroCelular)
        {
            if (string.IsNullOrEmpty(pcpf))
                throw new Exception("CPF deve ser informado");

            if (string.IsNullOrEmpty(pNumeroCelular))
                throw new Exception("Numero do celular deve ser informado");

            if (!pDataNascimento.HasValue)
                throw new Exception("Data de Nascimento deve ser informada");

            var _contexto = new DAL.BancoDadosDataContext();
            var _cliente = new DAL.tbCliente()
            {
                cpf = pcpf,
                datanascimento = pDataNascimento,
                numerocelular = pNumeroCelular
            };

            var _item = _contexto.tbClientes.Where(c => c.cpf == pcpf);

            if (_item.Count<DAL.tbCliente>() > 0)
            {
                var _cli = _item.Single<DAL.tbCliente>();

                _cli.datanascimento = pDataNascimento;
                _cli.numerocelular = pNumeroCelular;

                _contexto.SubmitChanges();
            }
        }

        public DAL.tbCliente Pesquisar(string cpf)
        {
            var _contexto = new DAL.BancoDadosDataContext();
            var _item = _contexto.tbClientes.Where(c => c.cpf == cpf);

            if (_item.Count<DAL.tbCliente>() > 0)
            {
                return (_item.Single<DAL.tbCliente>());
            }
            else
            {
                return (null);
            }
        }
    }
}
