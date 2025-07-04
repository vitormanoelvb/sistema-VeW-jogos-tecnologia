VeW\_Games\_Tecnologia

Sistema Windows Forms em C# integrado a MySQL (Workbench) para gerenciar uma loja de jogos.
Inclui cadastro, pesquisa, edição, exclusão “soft” (marcação inativa), restauração e reorganização de IDs.

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

🔑  Credenciais MySQL

Host: localhost
Porta: 3306
Banco de Dados: vew\_jogos\_tech

Usuário   | Senha             | Permissões
waudias   | SenhaForte123!    | SELECT, INSERT, UPDATE, DELETE
vitor     | SenhaForte123!    | SELECT, INSERT, UPDATE, DELETE

O código de conexão (Conexao.ObterConexao()) tenta primeiro o usuário waudias; se falhar, tenta vitor.

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

Estrutura do Projeto

VeW\_Games\_Tecnologia/
├─ Conexao.cs         – classe estática para obter MySqlConnection
├─ Form1.cs           – lógica de eventos, CRUD e filtros
├─ Form1.Designer.cs  – definição e posicionamento dos controles no formulário
├─ Program.cs         – ponto de entrada
└─ README.txt         – este arquivo

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

Fluxo de Uso

1. Inicialização

   * Ao abrir o form, CarregarProdutos() busca todos os produtos ativo = TRUE e popula o DataGridView.
   * ComboBoxes (Plataforma, Gênero, Categoria) são preenchidos com as opções.

2. Cadastro (Salvar)

   * Validações: todos os campos obrigatórios devem ser preenchidos; preço e estoque precisam ser valores numéricos válidos.
   * Insere no MySQL e então:
     a) ReorganizarIDs() – renumera todos os IDs e reseta o AUTO\_INCREMENT.
     b) CarregarProdutos() – atualiza a grade.

3. Pesquisa por Nome

   * btnPesquisar filtra nome LIKE '%texto%' e ativo = TRUE.
   * Se não encontrar, exibe “Produto não encontrado!” e não limpa o grid.

4. Edição

   * Selecionar uma linha do grid, clicar em Editar.
   * Se nada estiver selecionado, pede “Selecione um produto…”.
   * Valida preço e estoque antes de atualizar.

5. Exclusão “Soft”

   * Dupla confirmação (Aviso + Pergunta).
   * Atualiza ativo = FALSE, reorganiza IDs e recarrega.

6. Mostrar Apagados

   * btnMostrarApagados busca apenas ativo = FALSE.

7. Restaurar Selecionados

   * Seleciona linhas apagadas e restaura com ativo = TRUE.

8. Consulta Rápida

   * Combina filtros de Plataforma, Gênero e Categoria dinamicamente.
   * Preenche o grid com todos os resultados e carrega o primeiro registro nos campos.

9. Limpar Consulta

   * Limpa todos os TextBox e ComboBox e recarrega somente os ativos.

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

Configuração

1. Banco de Dados

   * Importe o script de criação da tabela produtos (com constraints).
   * Crie os usuários e aplique GRANT conforme credenciais acima.

2. Visual Studio

   * Abra a solução; instale o pacote MySql.Data (v9.3.0).
   * Ajuste Conexao.cs se necessário (host/porta/banco/usuário/senha).

3. Execução

   * Compile e execute; toda a interface funciona via botões no Form1.

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

Observações

* Soft delete: nada é removido fisicamente, apenas marcado inativo.
* Reorganização de IDs: mantém os IDs sem “buracos” após exclusões.
* Tratamento de erros com mensagens claras ao usuário.
* Handlers de eventos auxiliares (labels, TextBox) mantidos conforme Designer.

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

UNIVERSIDE VALE DO RIO DOCE (UNIVALE)

–––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––––

ADIMINISTRAÇÃO DE SEGURANÇA DE BANCO DE DADOS 
PROF: HENRIQUE BIANOR FREITAS SILVA
ALUNOS: VITOR MANOEL VIDAL BRAZ e WAUCLIDSON ALVES DIAS
