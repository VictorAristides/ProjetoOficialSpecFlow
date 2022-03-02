Feature: CT02_RegraSobreNomeVazio
	Quando um usuário tenta realizar cadastro de funcionario sem sobrenome.


@CT02
Scenario: CT02RegraSobreNomeVazio
	Given usuario acessa paginaprincipal
	And Preenche Nome do cadastro
	When Clicar no botao cadastrar
	Then Erro Solicitando SobreNome Obrigatorio