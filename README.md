# API de Autenticação de Usuários

## Visão Geral

Esta é uma API de Autenticação de Usuários construída com .NET Core que permite o registro e a autenticação de usuários de forma segura utilizando JWT (JSON Web Tokens). A API utiliza o Identity para gerenciamento de usuários e inclui recursos como geração de tokens, registro de usuários e proteção de dados. A segurança dos tokens é garantida através do uso de `SymmetricSecurityKey`.

### Demonstração
![Assista ao Gif de demonstração](https://github.com/Jonas-Emir/autenticacao-de-usuario_API/blob/feature/ImplementacaoControleUsuario/gif_autenticacaoAPI.gif)

## Recursos

- **Registro de Usuário**: Criação de um novo usuário com geração de Token.
- **Autenticação JWT**: Geração e validação de tokens JWT para sessões de usuário.
- **Gerenciamento de Acesso**: Atribuição de regras de autorização aos usuários para maior segurança e controle de acesso.
- **Proteção de Dados**: Garantia de que dados sensíveis sejam criptografados e seguros.
