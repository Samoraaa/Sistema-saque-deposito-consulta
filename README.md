# Sistema Bancário — Saque, Depósito e Consulta

> Sistema simples e funcional de gerenciamento de conta bancária via terminal (CLI) desenvolvido em **C#**, com suporte a consulta de saldo, depósitos e saques com validação de saldo insuficiente.

---

## Sumário

- [Sobre o Projeto](#sobre-o-projeto)
- [Funcionalidades](#funcionalidades)
- [Pré-requisitos](#pré-requisitos)
- [Como Executar](#como-executar)
- [Exemplo de Uso](#exemplo-de-uso)
- [Estrutura do Projeto](#estrutura-do-projeto)
- [Regras de Negócio](#regras-de-negócio)
- [Possíveis Melhorias](#possíveis-melhorias)

---

## Sobre o Projeto

Este projeto simula as operações básicas de uma conta bancária por meio de uma interface de linha de comando (CLI). Desenvolvido em **C#**, demonstra conceitos fundamentais da linguagem como estruturas de controle (`while`, `if/else if`), conversão de tipos (`Convert.ToInt32`, `Convert.ToSingle`) e interação com o usuário via `Console`.

Ideal para fins didáticos, exercícios de lógica de programação ou como ponto de partida para evoluir para um sistema bancário mais completo.

---

## Funcionalidades

| Opção | Operação      | Descrição                                                       |
|-------|---------------|-----------------------------------------------------------------|
| `1`   | Consulta   | Exibe o saldo atual da conta                                    |
| `2`   | Depósito   | Solicita um valor e adiciona ao saldo                           |
| `3`   | Saque      | Solicita um valor e retira do saldo, se houver saldo suficiente |
| `4`   | Encerrar   | Finaliza a sessão e encerra o programa                          |
| outro | Inválido   | Informa que a opção digitada não é válida                       |

---

## Pré-requisitos

- [**.NET SDK 6.0+**](https://dotnet.microsoft.com/download) instalado
- Terminal (CMD, PowerShell, ou Terminal integrado do Visual Studio / VS Code)

Para verificar se o .NET está instalado:

```bash
dotnet --version
```

---

## Como Executar

1. **Clone o repositório:**

```bash
git clone https://github.com/seu-usuario/sistema-bancario.git
cd sistema-bancario
```

2. **Execute o projeto:**

```bash
dotnet run
```

Ou, se preferir compilar antes:

```bash
dotnet build
dotnet run
```

> Também é possível abrir o arquivo `Program.cs` diretamente no **Visual Studio** e pressionar `F5` para executar.

---

## 🖥️ Exemplo de Uso

```
1 - deseja ver seu saldo?
2 - deseja depositar?
3 - deseja realizar saque?
4 - finalizar sessão?
> 2
quanto deseja depositar?
> 500
1 - deseja ver seu saldo?
2 - deseja depositar?
3 - deseja realizar saque?
4 - finalizar sessão?
> 1
Seu saldo é 1500
1 - deseja ver seu saldo?
2 - deseja depositar?
3 - deseja realizar saque?
4 - finalizar sessão?
> 3
quanto deseja sacar?
> 2000
Saldo insuficiente!
1 - deseja ver seu saldo?
2 - deseja depositar?
3 - deseja realizar saque?
4 - finalizar sessão?
> 4
```

---

## Regras de Negócio

1. **Saldo inicial:** A conta começa com `R$ 1.000,00` definido diretamente no código (`saldo = 1000`).
2. **Depósito:**
   - O sistema solicita o valor via `Console.ReadLine()` e converte com `Convert.ToSingle()`.
   - O valor informado é somado ao saldo sem validação de mínimo (veja melhorias abaixo).
3. **Saque:**
   - O sistema verifica se `saqueInformado > saldo`.
   - Se verdadeiro, exibe `"Saldo insuficiente!"` e cancela a operação.
   - Se falso, o valor é subtraído do saldo.
4. **Opção inválida:**
   - Qualquer entrada diferente de `1`, `2`, `3` ou `4` exibe `"Escolha um valor valido"`.
5. **Encerramento:**
   - A opção `4` executa `break`, saindo do loop `while(true)` e encerrando o programa.

---

<p align="center">
  Feito com ❤️ para fins educacionais — C# e .NET
</p>
