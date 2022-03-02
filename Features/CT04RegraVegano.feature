Feature: CT04RegraVegano
	Simple calculator for adding two numbers

@CT04
Scenario: CT04RegraVegano

	Given usuario acessa paginaprincipal
	And Preenche Nome do cadastro
	And preenche o sobrenome
	And Seleciona o Sexo Masculino
	And Seleciona Carne e Vegetariano
	When Clicar no botao cadastrar
	Then Deve exibir a mensagem "Tem certeza que voce eh vegetariano?"