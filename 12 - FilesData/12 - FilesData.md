# 12 - FilesData

Neste exercício para manipulação de arquivos e pastas, Foi usado a função da biblioteca System.IO "File.ReadAllLines" que permitiu atribuir o conteudo de cada linha de um arquivo .csv que possui algumas informações de alguns produtos separado por virgula.

A função Directory.CreateDirectory foi usada para criar uma nova pasta.

O bloco "using (StramReader sw = File.AppendText())" foi usado para conforme as regras dentro multiplicar a quantidade de cada item pelo seu valor e no resultado mostrar o preço total. Esta função está na classe Product.

Manipulando as informações de cada linha usando um forEach, e no fim usando a função WriteLine para escrever as novas informações no novo arquivo .csv dentro da nova pasta criada.