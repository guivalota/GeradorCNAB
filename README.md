# Sistema de Geração de Arquivos de Remessa CNAB240

Este projeto é um sistema para a geração de arquivos de remessa no formato CNAB240, utilizado para homologação em sistemas financeiros. O sistema atualmente gera arquivos com as seguintes estruturas:

- Header
- Lote
- Trailer

## Funcionalidades

- Geração de arquivos de remessa CNAB240.
- Suporte para os segmentos A e B.
- Inclusão de Header e Trailer nos arquivos gerados.

## Estrutura do Arquivo

O arquivo gerado pelo sistema segue a estrutura padrão do CNAB240:

1. **Header**: Contém informações gerais do arquivo.
2. **Segmento A**: Informações específicas de transações financeiras.
3. **Segmento B**: Informações adicionais complementares às transações.
4. **Trailer**: Contém informações de fechamento do arquivo.

## Como Usar

Para usar o sistema, siga os passos abaixo:

1. Clone o repositório para sua máquina local:

   ```bash
   git clone https://github.com/guivalota/GeradorCNAB.git
