Funcionalidade: Formulario de Contato
	Eu como usuário, preciso contactar o prestador de serviço
	Para que seja necessário um possível retorno
	Preciso preencher as informações corretamente.

@after
@Browser:Chrome
Esquema do Cenario: Preenchimento do formulario corretamente
	Dado que eu esteja no site jobmidia
	Quando eu clicar no link contato
	E para entrar em contato e necessario informar todos os dados obrigatorios do formulario: <Nome>,<E-mail>,<Telefone>,<Mensagem>
	Quando  eu clicar em Enviar
	Entao o site ira informar a mensagem 'Sua mensagem foi enviada com sucesso.'

	Exemplos:
	 |Nome		|E-mail					|Telefone	  | Mensagem		  |
	 |Franklin	|franklinjob@hotmail.com|(21)991475281|	Teste de Mensagem |

@after
@Browser:Chrome
Esquema do Cenario: Preenchimento do formulario com email incorreto
	Dado que eu esteja no site jobmidia
	Quando eu clicar no link contato
	E para entrar em contato e necessario informar todos os dados obrigatorios corretamente exceto email: <Nome>,<E-mail>,<Telefone>,<Mensagem>
	Entao o formulario irá alertar o preenchimento incorreto do email 'Formato de e-mail inválido'

	Exemplos:
	 |Nome		|E-mail		|Telefone	  | Mensagem		  |
	 |Franklin	|franklinjob|(21)991475281|	Teste de Mensagem |

@after
@Browser:Chrome
Esquema do Cenario: Preenchimento do formulario com email incorreto e alerta incorreto
	Dado que eu esteja no site jobmidia
	Quando eu clicar no link contato
	E para entrar em contato e necessario informar todos os dados obrigatorios corretamente exceto email: <Nome>,<E-mail>,<Telefone>,<Mensagem>
	Entao o formulario irá alertar o preenchimento incorreto do email 'Formato de e-mail inválidos'

	Exemplos: 
	 |Nome		|E-mail		|Telefone	  | Mensagem		  |
	 |Franklin	|franklinjob|(21)991475281|	Teste de Mensagem |