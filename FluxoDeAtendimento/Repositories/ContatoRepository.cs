using FluxoDeAtendimento.Models;

namespace FluxoDeAtendimento.Repositories
{
    public class ContatoRepository
    {
        private Contato? _contatoAtual;
        private readonly List<string> _historicoEtapas = new();

        public Task SalvarAsync(Contato contato)
        {
            _contatoAtual = new Contato
            {
                Id = contato.Id,
                Nome = contato.Nome,
                Usuario = contato.Usuario,
                Administrador = contato.Administrador,
                Situacao = contato.Situacao,
            };
            return Task.CompletedTask;
        }

        public Contato? ObterContatoAtual()
        {
            return _contatoAtual;
        }

        public void RegistrarEtapa(string etapa)
        {
            _historicoEtapas.Add($"{DateTime.Now:HH:mm:ss} - {etapa}");
        }

        public IReadOnlyList<string> ObterHistorico()
        {
            return _historicoEtapas.AsReadOnly();
        }

        public void Limpar()
        {
            _contatoAtual = null;
            _historicoEtapas.Clear();
        }

        public void AtualizarContato(Contato contato)
        {
            if (_contatoAtual != null && _contatoAtual.Id == contato.Id)
            {
                _contatoAtual = contato;
                RegistrarEtapa("Contato atualizado");
            }
        }
    }
}