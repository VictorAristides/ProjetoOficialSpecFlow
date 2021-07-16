Feature: CT01_CadastroSemNome
	Quando um usuário tenta realizar cadastro de funcionario sem nome.

@CT01
Scenario: CT01CadastroSemNome
	Given usuario acessa paginaprincipal
	When Clicar no botao cadastrar
	Then Erro Solicitando Nome Obrigatorio