Feature: CT05_RegraEsporte
	Simple calculator for adding two numbers

@CT05
Scenario: CT05RegraEsporte


	Given usuario acessa paginaprincipal
	And Preenche Nome do cadastro
	And preenche o sobrenome
	And Seleciona o Sexo Masculino
	And Seleciona Comida Favorita Carne
	And  Seleciona a opção Natação
	When Clicar no botao cadastrar
	Then Deve ser exibida a mensagem "Cadastrado!"