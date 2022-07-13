# 10 - Contribuintes

Um beneficio do polimorfismo junto a herança é o aproveitamento de código.
Neste exercício que propôs o calculo de imposto para empresas ou pessoas individuais, alguns atributos são comuns e eles estão na classe TaxPayer() quenão precisa calcular com o método Tax() diretamente e por isso ele é declarado com abstract, ja nas classes Company() e Individual() é feito a função Tax() com override para o calculo do imposto conforme a classificação extendendo a classe TaxPayer e usando : base para o contrutor aproveitar os atributos da classe herdada.