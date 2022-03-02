Feature: CT06_CadastroCompleto
	Simple calculator for adding two numbers

@CT06
Scenario: CT06CadastroCompleto

	Given usuario acessa paginaprincipal
	And Preenche Nome do cadastro
	And preenche o sobrenome
	And Seleciona o Sexo Masculino
	And Seleciona Comida Favorita Carne
	And  Seleciona a opção Natação
	And Seleciona Escolaridade Mestrado
	When Clicar no botao cadastrar
	Then Deve ser exibida a Mensagem "Cadastrado!" e Validar os demais campos