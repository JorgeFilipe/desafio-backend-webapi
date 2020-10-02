# <b>Desafio Inforce: webapi backend</b>
<br/>



# Inicializando o Projeto Webapi</b>

### Requerimentos para o projeto:
  - IDE utilizada `Visual Studio Code`.
  - Servidor `MySQL` Banco de Dados (Configurar a String de Conexão no arquivo `appsettings.json`).

  - Remova a pasta `Migrations` com todos seus dados.

  - Gere uma nova Migration:  
    - execute: `dotnet ef migrations add "NomeDaTabela"`
    
  - Atualize executando:
    - `dotnet ef database update`
    
    - Caso queira ver o processo de execução, basta rodar com o -v no final do comando.


<br/>

## Execução

No diretório do projeto, você pode executar no terminal:
## `dotnet run`
o projeto será executado e estará de pé em:
[http://localhost:5001](http://localhost:5001) ou [http://localhost:5000](http://localhost:5000)

<br/>

## Desafios Enfrentados:
Durante o decorrer do projeto o principal desafio foi, conciliar entre aprender mais sobre as tecnologias utilizadas, e requeridas no desafio, tais como o Framework Entity, para as persistências dos dados, o próprio dotnet Core, e ao mesmo tempo abstrair tudo e codar o desafio da webapi.

## Soluções Encontradas:
Durante os momentos de dúvidas, problemas e warnings "insolucionáveis" `(rsrs...)`, busquei auxílio nas documentações do Microsoft docs, e também em alguns tópicos no Stack Overflow e iMasters.

## O que foi extraído do desafio:
Mesmo não tendo muita afinidade com C#, os conhecimentos adquiridos de outras linguagem proporcionou uma abstração mais rápida da sintaxe do C#. E também uma visão mais sólida do que é uma API, e de tudo que fica "por baixo do capô".

