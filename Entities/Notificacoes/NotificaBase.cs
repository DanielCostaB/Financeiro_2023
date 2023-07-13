namespace Entities.Notificacoes
{
    public class NotificaBase
    {

        public bool ValidarPropriedadeString(string valor, string nomePropriedade)
        {
            if (string.IsNullOrWhiteSpace(valor) || string.IsNullOrWhiteSpace(nomePropriedade))
            {
                notificacoes.Add(new Notifica
                {
                    mensagem = "Campo Obrigatório",
                    NomePropriedade = nomePropriedade,
                });
            }
        }
    }
}