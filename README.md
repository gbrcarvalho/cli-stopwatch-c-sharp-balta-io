# Cronômetro - Aplicação CLI

Aplicação CLI de cronômetro em C#, do curso Fundamentos do C# de André Baltieri

https://balta.io/cursos/fundamentos-csharp

Um cronômetro de console simples escrito em C# que permite o usuário contar em segundos ou minutos.

## Funcionalidades

- **Flexibilidade na Entrada**: Defina o tempo de contagem em segundos (s) ou minutos (m)
- **Operção contínua**: Retorna ao menu depois de completar a contagem.

## Requisitos

- Framework .NET ou .NET Core/5+
- Compilador C#

## Como executar

   ```
   PS unidade:\caminho\cli-stopwatch-c-sharp-balta-io> dotnet run
   ```

## Uso

1. **Defina o tempo de contagem**
   - Para segundos: Entre um número seguido de um 's' (ex.: `10s` para 10 segundos)
   - Para minutos: Entre um número seguido de um 'm' (ex.: `2m` para 2 minutos)
   - Para sair: Entre `0s` ou `0m`

2. **Contagem**
   - A aplicação irá mostrar "Ready... Set... Go..." antes de começar
   - A contagem do tempo será mostrada e atualizada a cada sagundo
   - Quando finalizado, é mostrada a mensagem "Stopwatch finalizado" no console e retorna ao menu automaticamente.

## Exemplos

```
Entrada: 30s    → Contagem de 30 segundos
Entrada: 2m     → Contagem de 120 segundos  
Entrada: 1m     → Contagem de 60 segundos
Entrada: 0s     → Sai da aplicação
```

## Licença

Este é um projeto educacional desenvolvido com o intuito de exercitar os Fundamentos do C# aprendidos no curso. Sinta-se livre para usar e modificar conforme necessário.