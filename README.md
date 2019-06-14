NAV API
----

API de um projeto desenvolvido durante o 5º termo do bacharelado de Sistemas de Informação, como domínio sendo um sistema idealizado e estruturado em outra disciplina da graduação.

O Front-end que consumirá esta API terá seu link disponibilizado aqui em breve.

A API está disponível online nesta url: [NAV - API][3]. A sua página inicial possui mais detalhes da estrutura do projeto e seu código. 

----

O arquivo [NAV.postman_collection.json][4] é uma coleção do Postman com os métodos básicos para interagir com a API: criação de condutor, funcionário e um item de caixa (entrada/saída de dinheiro).

_Alterando os verbos destes métodos é possível executar outras operações com estas 3 entidades. Os verbos atualmente suportados são: GET, GET (passando um ID no final da URL. Ex: /api/condutor/3), POST, PUT e DELETE_

----

### Tecnologias utilizadas:
* [ASP.NET Core 2.2][1]
* [Entity Framework 6.2.0][2]

[1]: https://dotnet.microsoft.com/apps/aspnet 	                                            "ASP.NET Core 2.2"
[2]: https://docs.microsoft.com/pt-br/ef/		                                                "Entity Framework 6"
[3]: http://ec2-18-231-174-195.sa-east-1.compute.amazonaws.com:8080                         "NAV - API"
[4]: https://github.com/henrikato/NavApiNetCore/blob/master/NAV.postman_collection.json     "Coleção Postman da API do NAV"
