Feature: Hangman
	Para jugar el juego
	Como Jugador
	Quiero intentar una serie de palabras y saber si adiviné o no

@mytag
Scenario: Perder el juego
	Given La palabra del Wordle es 'perro'
	When Ingreso 5 veces la palabra 'carro'
	Then Debería perder la partida