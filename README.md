# Editor de Texto com Dicionário de Palavras

Este projeto implementa um editor de texto em C# que possui um dicionário de palavras. O editor permite que os usuários carreguem ou criem novos arquivos de texto, validem as palavras contidas no texto e gerenciem um dicionário de palavras utilizando uma lista simplesmente encadeada.

## Funcionalidades

- **Carregar e Editar Arquivos**: O editor permite abrir arquivos de texto existentes ou criar novos.
- **Validação de Palavras**: O editor verifica se as palavras digitadas estão presentes no dicionário, sem diferenciar maiúsculas de minúsculas.
- **Marcação de Palavras**: Palavras que não estão no dicionário são marcadas, e o usuário pode optar por adicioná-las ao dicionário.
- **Dicionário com Lista Simplesmente Encadeada**: O dicionário é implementado utilizando uma lista simplesmente encadeada.
- **Persistência do Dicionário**: O dicionário é armazenado em um arquivo físico, permitindo que seja reutilizado em várias execuções do programa.

## Estrutura do Projeto

### Classes Principais

- **EditorTexto**
  - Responsável pela interface do editor e manipulação de arquivos de texto.
  - Métodos para abrir, salvar e editar arquivos.

- **Dicionario**
  - Implementa a lista simplesmente encadeada para armazenar as palavras.
  - Métodos para adicionar, remover e verificar palavras no dicionário.
  - Rotina para carregar e salvar o dicionário em um arquivo físico.

### Formato do Arquivo do Dicionário

O dicionário é armazenado em um arquivo de texto, onde cada linha contém uma palavra. O formato é simples, com uma palavra por linha.

### Prints

![image](https://github.com/user-attachments/assets/e384e6bc-9c8f-440a-bece-ed2c71092a9f)
