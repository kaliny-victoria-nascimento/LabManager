# Lab Manager

Programa que organiza dados de laboratórios e computadores.

## Tecnologia utilizada
- dotnet core 6.0
- SQLite

## Funcionalidade
- Cadastramento de computadores e laboratórios;
- Atualização de computadores e laboratórios;
- Exibição de computadores e laboratórios;
- Deleção de computadores e laboratórios.

## Como usar
Para visualizar os dados de computadores inseridos
```
dotnet run -- Computer List
```
Para visualizar os dados de laboratórios inseridos
```
dotnet run -- Lab List
```


Para inserir um computador na tabela
```
dotnet run -- Computer New "id" "ram" "processador"
```
* Por exemplo: dotnet run -- Computer New 3 "16gb" "Intel"

Para inserir um laboratório na tabela
```
dotnet run -- Lab New "id" "number" "name" "block"
```
* Por exemplo: dotnet run -- Lab New 8 "7" "Kaliny Victória" "3"


Para deletar um computador pelo id
```
dotnet run -- Computer Delete "id"
```
* Por exemplo: dotnet run -- Computer Delete 2

Para deletar um laboratório pelo id
```
dotnet run -- Lab Delete "id"
```
* Por exemplo: dotnet run -- Lab Delete 1


Para atualizar a lista de computadores
```
dotnet run -- Computer Update "id" "ram" "processor"
```
* Por exemplo: dotnet run -- Computer Update 1 '8gb' 'Amd'

Para atualizar a lista de laboratórios
```
dotnet run -- Lab Update "id" "number" "name" "block"
```
* Por exemplo: dotnet run -- Lab Update 1 '2' 'Lívia' '2'


Para mostrar os dados do computador por id
```
dotnet run -- Computer Show "id"
```
* Por exemplo: dotnet run -- Computer Show 2


Para mostrar os dados do labaroratório por id
```
dotnet run -- Lab Show "id"
```
* Por exemplo: dotnet run -- Lab Show 3

