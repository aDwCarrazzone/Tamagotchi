# Tamagotchi

# ATM2020
Repositório voltado ao desenvolvimento do jogo Tamagotchi para realizar a prática da ATM do primeiro semestre 2020.

## Sumário
<ul>
  <li><a href="https://github.com/aDwCarrazzone/ATM2020#resumo">Resumo</a></li>
  <li><a href="https://github.com/aDwCarrazzone/ATM2020#introdução">Introdução</a></li>
  <li><a href="https://github.com/aDwCarrazzone/ATM2020#desenvolvimento">Desenvolvimento</a></li>
  <li><a href="https://github.com/aDwCarrazzone/ATM2020#conclusão">Conclusão</a></li>
</ul>

## Resumo

  Esse projeto tem como objetivo o desenvolvimento de um jogo através da engine Unity fazendo o uso de um banco de dados mysql, linguagens php e C#. Para o desenvolvimento do projeto fora utilizado a documentação da ferramenta Unity e vídeos tutorials. O Servidor será totalmente em php, o jogo em C#, a ligação entre ambos feita pela engine Unity e seus módulos de comunicação via post/request. Espera-se ter como resultado um jogo multiplataforma com intuito de fazer uso de um servidor e fazer envios e requisições de dados para obter um jogo de bichinho virtual que você possa levar consigo para qualquer lugar, independente do dispositivo usado para jogar. É proposto o uso de banco de dados para solucionar um dos maiores defeitos do tamagotchi convencional, onde case a bateria acabasse ou tivesse falhas você perdia o seu bichinho pois o mesmo ficava armazenado na memória temporária do dispositivo. C# será utilizado pois é a linguagem de programação utilizada pela Unity, PHP será utilizado para que seja feito a transferência de dados locais para o banco de dados assim garantindo que os dados não sejam perdidos ao fim do uso da aplicação

  ***Apache:*** É o servidor web onde os dados serão interpretados e transferidos entre o jogo e o banco de dados;
  
[Apache](https://github.com/aDwCarrazzone/Tamagotchi/blob/master/assets/about/Apache/README.md)

  ***C#:*** É a linguagem de programação utilizada pela engine Unity e a linguagem em que o jogo será desenvolvido;
  
[C#](https://github.com/aDwCarrazzone/Tamagotchi/blob/master/assets/about/C#/README.md)

  ***MySQL:*** É o banco de dados, onde ficara armazenado todas as informações dos jogadores e de seus pets.
  
[MySQL](https://github.com/aDwCarrazzone/Tamagotchi/blob/master/assets/about/MySQL/README.md)

  ***PHP:***  Linguagem de back-end responsavel por interpretar os dados e transferi-los entre o jogo e o banco de dados.

[PHP](https://github.com/aDwCarrazzone/Tamagotchi/blob/master/assets/about/PHP/README.MD)

  ***Unity:*** É uma engine para jogos, ela não se limita a industria de jogos, já que varias empresas fora dessa industria a usa. É a engine escolhida pelas ferramentas já disponiveis e por ter a possibilidade de desenvolvimento de jogos multi-plataformas.
  
[Unity](https://github.com/aDwCarrazzone/Tamagotchi/blob/master/assets/about/Unity/README.md)

## Introdução

  O projeto tem como objetivo resolver o problema com o bichinho virtual tradicional de perda de dados apos uma queda ou descarga da bateria.
  
  ## Desenvolvimento

  O projeto começou pelo desenvolvimento do banco de dados MySQL utilizando a ferramenta Workbench utilizada nas aulas durante o semestre. A construção do banco foi realizada dividindo os bichinhos e os usuários em duas tabelas diferentes.
  A linguagem de programação utilisada foi a C# por a engine roda nessa linguagem.
  A linguagem de programação responsavel pela parte do servidor foi o php pois a Unity possui uma formas de comunicação com serviços web e por ter conhecimentos prévios com a linguagem php.
  A engine escolhida foi a Unity pois ela possui uma fácil conexão entre o php e o C# além de possuir uma vasta documentação e varios tutoriais online para facilitar o desenvolvimento do jogo. 
  Após a criação do banco, fora aplicado alguns dados para realizar testes de inseção, deleção e etc. Depois da criação e testes do banco foi realizado testes de comunicação através da Unity.
  Com a comunicação do banco funcionando com a engine selecionada foi iniciado o desenvolvimento do sistema de registro e de login do jogo, pois será necessário uma conta de jogo para que seja armazenado os dados dos bichinhos virtuais no banco.

# Conclusão
 
 O desenvolvimento de um jogo por completo acaba sendo demasiadamente complexo para a realização a curto prazo, porem é fácil ver o resultado do trabalho em tempo real conforme a realização das etapas envolvidas no desenvolvimento, desde o registro dos jogadores até a deleção do bichinho. Inicialmente a idéia do projeto éra um jogo para multi-plataformas, porem a dificuldade do desenvolvimento ocasionou o foco em somente uma plataforma temporariamente, onde somente após a realização completa do jogo para uma plataforma será iniciado o desenvolvimento para outras plataformas.
