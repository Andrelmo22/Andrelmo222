using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SrvIntegracao
{
    [ServiceContract]
    public interface IServicoIntegracao
    {
        [OperationContract]
        DAL.tbCliente Pesquisar(string cpf);

        [OperationContract]
        void Atualizar(DAL.tbCliente cliente);
    }
}