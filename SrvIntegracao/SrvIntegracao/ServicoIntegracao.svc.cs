using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SrvIntegracao
{
    public class ServicoIntegracao : IServicoIntegracao
    {
        public DAL.tbCliente Pesquisar(string cpf)
        {
            BLL.ClienteBLL _bll = new BLL.ClienteBLL();

            return (_bll.Pesquisar(cpf));
        }

        public void Atualizar(DAL.tbCliente cliente)
        {
            BLL.ClienteBLL _bll = new BLL.ClienteBLL();

            _bll.Atualizar(cliente.cpf,
                           cliente.datanascimento,
                           cliente.numerocelular);
        }
    }
}