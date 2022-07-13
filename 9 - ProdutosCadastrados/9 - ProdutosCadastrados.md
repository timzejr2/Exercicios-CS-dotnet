# 9 - ProdutosCadastrados

Neste exercícios existem 3 classes, a Product, a ImportedProduct e a UsedProduct.
O programa principal pede para cadastrar e classificar o item como objeto de uma das 3 classes acima.
As classes ImportedProduct e UsedProduct herdam os atributos da classe Product. Empregando assim os conceitos de Herança e Polimorfismo.

Para não precisar repetir os atributos ja informados na classe principal Product, utiliza ao lado do nome da classe a sintaxe ": classe herdada", e informam os atributos que apenas elas possuem e no método construtor utilizam ": base(atributos herdados)"

As classes ImportedProduct e UsedProduct possuem o método Override toString da função priceTag() com o texto definido para resposta, mas caso seja um produto comum da classe Product, foi usado o Virtual, desta forma conforme caracteristicas do objeto é escolhido a função priceTag da classe correspondente.