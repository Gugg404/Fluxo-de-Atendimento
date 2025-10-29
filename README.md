# FluxoDeAtendimento

Sistema de **Fluxo de Atendimento**, desenvolvido para auxiliar o suporte no acompanhamento e registro de atendimentos de clientes.  
Permite identificar contatos, guiar o atendente em cada etapa do processo e registrar conclusões de atendimento.

---

## Funcionalidades Principais

- **Identificação de Contato:** registra informações básicas do cliente como nome, usuário, administrador e situação.
- **Fluxo de Cadastros:** 
  - Cadastro de Produtos
  - Cadastro de Pessoas
- **Sugestões de Mensagem:** fornece mensagens prontas para o atendente enviar ao cliente.
- **Orientações:** exibe dicas e links da central de ajuda para apoiar o atendente.
- **Histórico de Etapas:** mantém registro de todas as etapas percorridas pelo contato.
- **Navegação Guiada:** permite retornar para etapas anteriores, finalizar atendimentos ou seguir para outros setores.

---

## Tecnologias Utilizadas

- **.NET 8**  
- **Blazor Server**  
- **C#**  
- **Razor Components** para o front-end  
- **HTML / CSS**  
- **Possibilidade de integração com MudBlazor** para componentes visuais avançados  

---

## Estrutura do Projeto

- **Fluxo/** → Contém todas as telas do sistema, como Identificação, Cadastros, Setor Financeiro e Suporte.  
- **Shared/** → Componentes reutilizáveis, como `NavMenu` e layouts.  
- **wwwroot/** → Arquivos estáticos: CSS, JS, imagens.  
- **Program.cs** → Configuração e inicialização do aplicativo.  
- **Repositories/** → Camada responsável pelo gerenciamento de dados do contato e histórico de etapas.

---

## Como Rodar o Projeto

1. Clone o repositório:
   ```bash
   git clone https://github.com/Gugg404/Fluxo-de-Atendimento.git
