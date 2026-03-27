# Sistema de Gestão Comunitária - Beira

Este é um sistema desenvolvido em **VB.NET** (Visual Studio 2022) para a gestão e registo de membros de uma comunidade. O sistema permite o cadastro de dados pessoais e a filtragem automática por faixas etárias (Crianças, Jovens, Adultos e Idosos).

## 🚀 Funcionalidades

- **Registo de Membros:** Nome, Idade, Residência e Género.
- **Filtros Dinâmicos:** Visualização rápida de grupos específicos baseada na idade.
- **Base de Dados:** Integração total com MySQL/MariaDB.
- **Interface Intuitiva:** Desenvolvido com Windows Forms.

## 🛠️ Pré-requisitos

Para rodar este projeto, precisará de:

1. **XAMPP** (ou qualquer servidor MySQL local).
2. **Visual Studio 2022** (com suporte para .NET desktop development).
3. **MySQL Connector/NET** instalado no projeto.

## 📦 Como Instalar e Rodar

### 1. Preparar a Base de Dados
1. Abra o **phpMyAdmin** (localhost/phpmyadmin).
2. Crie uma nova base de dados chamada `gestao_comunitaria`.
3. Clique na aba **Importar**.
4. Selecione o ficheiro `gestao_comunitaria.sql` que está na raiz deste projeto.
5. Clique em **Executar**.

### 2. Rodar o Projeto
1. Abra o ficheiro `gestao_comunitaria.sln` no Visual Studio.
2. Certifique-se de que a string de conexão no código (`strConn`) coincide com as suas credenciais do MySQL (o padrão é `user=root` e `password` vazia).
3. Pressione **F5** ou clique em **Iniciar**.

## 📝 Notas de Versão
- A funcionalidade de "Doença Especial" foi temporariamente desativada (comentada no código) para garantir a estabilidade do sistema e compatibilidade universal da base de dados.

## 👥 Autor
Desenvolvido como parte do curso de Engenharia Informática - Beira, Moçambique.
Por: Izaque Tomo Bonga Junior e Americo Facitela Penga