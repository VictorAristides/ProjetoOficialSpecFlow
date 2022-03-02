Feature: CT03RegraSexoVazio
	Simple calculator for adding two numbers

@CT03
Scenario: CT03RegraSexoVazio

	Given usuario acessa paginaprincipal
	And Preenche Nome do cadastro
	And preenche o sobrenome
	When Clicar no botao cadastrar
	Then Erro Solicitando Sexo obrigatorio