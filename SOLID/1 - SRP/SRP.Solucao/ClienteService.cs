using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID._1___SRP.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionaCliente(Cliente cliente)
        {
            if (!cliente.IsValid())
                return "Dados Inválidos";

            EmailServices.Enviar("email_emitente_empresa@gmail.com", cliente.Email, "Assunto do E-mail", "Mensagem do corpo do e-mail!");

            return "Cliente cadastrado com sucesso!";
        }
    }
}
