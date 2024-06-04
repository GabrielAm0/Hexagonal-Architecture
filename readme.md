# Arquitetura Hexagonal
### [Readme in English](https://github.com/GabrielAm0/Hexagonal-Architecture/blob/main/readme-en.md)


![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)
![PostgreSQL](https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white)

Este projeto é uma API construída usando **C#, .NET CORE, Entity Framework e PostgreSQL.**

O microserviço foi desenvolvido para demonstrar como implementar o padrão de Arquitetura Hexagonal em uma aplicação .NET Core. O projeto é uma API simples que gerencia produtos em uma loja.

## Conteúdo

- [Arquitetura Hexagonal](#arquitetura-hexagonal)
- [Instalação](#instalação)
- [Uso](#uso)
- [Endpoints da API](#endpoints-da-api)
- [Contribua](#contribua)

## Arquitetura Hexagonal

A Arquitetura Hexagonal é um padrão de arquitetura de software que permite a criação de componentes de aplicação fracamente acoplados. Este padrão também é conhecido como Ports and Adapters, e baseia-se na ideia de dividir a aplicação em camadas, com cada camada tendo uma responsabilidade específica.

O padrão de Arquitetura Hexagonal consiste em três camadas principais:

1. **Camada de Aplicação**: Esta camada contém a lógica da aplicação e é responsável por coordenar a interação entre as outras camadas. Ela recebe entrada do mundo externo e delega o processamento para a camada de domínio.

2. **Camada de Domínio/Core**: Esta camada contém a lógica de negócios central da aplicação. Ela define as entidades, objetos de valor e regras de negócios que governam o comportamento da aplicação.

3. **Camada de Infraestrutura**: Esta camada contém os detalhes de implementação da aplicação, como acesso a banco de dados, serviços externos e outras dependências. Ela fornece a infraestrutura necessária para a aplicação funcionar.

O padrão de Arquitetura Hexagonal promove a separação de responsabilidades e torna a aplicação mais modular e testável. Também permite a fácil integração de novos componentes e mudanças em componentes existentes sem afetar o restante da aplicação.

## Instalação

1. Instale o SDK do .NET na sua máquina. Este projeto foi construído usando .NET 8:

   [Baixar .NET SDK 8.0](https://dotnet.microsoft.com/download)

2. Clone o repositório:

```bash
git clone https://github.com/GabrielAm0/Hexagonal-Architecture.git

```

3. Instale o PostgreSQL na sua máquina

   [Download PostgreSql](https://www.postgresql.org/download/)

## Uso

1. Abra o projeto no Rider ou Visual Studio.
2. Execute os seguintes comandos no CLI:

```bash
    dotnet ef migrations add ProductsMigration
```

```bash
    dotnet ef database update
```

3. Atualize  `appsettings.json` inserindo suas Connection Strings do PostgreSQL

```csharp
"ConnectionStrings": {
  "DefaultConnection":"User ID= ;Password= ;Host= ;Port= ;Database= ;Pooling=true;"
}
```

4. Inicie a aplicação com .NET.
5. A API estará acessível em https://localhost:7115/swagger/index.html

## Endpoints da API

A API fornece os seguintes endpoints:

1. **GET Produto por ID**

```http request
GET /api/Products/"{id}" - Obter um produto por ID
```

2. **GET Todos os produtos**

```http request
GET /api/Products - Obter todos os produtos
```

3. **POST Registra produto**

```http request
GET /api/Products - Adicionar um novo produto
```

**BODY**

```json
{
  "name": "test",
  "price": 10.0
}
```

4. **DELETE Deleta produto**

```http request
DELETE /api/Products/"{id}" - Deletar um produto por ID
```

5. **UPDATE Atualiza produto**

```http request
PUT /api/Products/"{id}" - Atualizar um produto por ID
```

**BODY**

```json
{
  "name": "test",
  "price": 10.0
}
```

## Contribua

Contribuições são bem-vindas! Se você encontrar algum problema ou tiver sugestões de melhorias, por favor, abra uma issue ou envie um pull request para o repositório.


Ao contribuir para este projeto, siga o estilo de código existente, [commit conventions](https://www.conventionalcommits.org/en/v1.0.0/), e envie suas alterações em uma branch separada.
