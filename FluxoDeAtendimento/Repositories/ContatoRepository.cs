using FluxoDeAtendimento.Models;

namespace FluxoDeAtendimento.Repositories
{
    public class ContatoRepository
    {
        private Contato? _contatoAtual;
        private readonly List<string> _historicoEtapas = new();

        // Salva o contato atual
        public Task SalvarAsync(Contato contato)
        {
            _contatoAtual = new Contato
            {
                Id = contato.Id,
                Nome = contato.Nome,
                Usuario = contato.Usuario,
                Administrador = contato.Administrador,
                Situacao = contato.Situacao,
                Modulo = contato.Modulo,
                Conclusao = contato.Conclusao,
                SubEtapa = contato.SubEtapa,
            };
            return Task.CompletedTask;
        }

        public Contato? ObterContatoAtual() => _contatoAtual;


        // ===
        // : Define o módulo atual ===
        public void DefinirModulo(string modulo)
        {
            if (_contatoAtual == null)
                _contatoAtual = new Contato();

            _contatoAtual.Modulo = modulo;
            RegistrarEtapa($"Entrou no módulo {modulo}");
        }

        public void DefinirSubEtapa(string subetapa)
        { 
            if (_contatoAtual == null)
                _contatoAtual = new Contato();

            _contatoAtual.SubEtapa = subetapa;
            RegistrarEtapa($"Entrou na etapa {subetapa}");
        }


        // === Conclusão agora salva no contato ===
        public void DefinirConclusao(string texto)
        {
            if (_contatoAtual == null)
                _contatoAtual = new Contato();

            _contatoAtual.Conclusao = texto;
            RegistrarEtapa("Conclusão definida");
        }

        public string ObterConclusao() => _contatoAtual?.Conclusao ?? string.Empty;

        // === Histórico de etapas ===
        public void RegistrarEtapa(string etapa)
        {
            if (!string.IsNullOrWhiteSpace(etapa))
                _historicoEtapas.Add($"{DateTime.Now:HH:mm:ss} - {etapa}");
        }

        public IReadOnlyList<string> ObterHistorico() => _historicoEtapas.AsReadOnly();

        public void AtualizarContato(Contato contato)
        {
            if (_contatoAtual != null && _contatoAtual.Id == contato.Id)
            {
                _contatoAtual = contato;
                RegistrarEtapa("Contato atualizado");
            }
        }

        public void Limpar()
        {
            _contatoAtual = null;
            _historicoEtapas.Clear();
        }

    }
}