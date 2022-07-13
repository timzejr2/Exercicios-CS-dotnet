# 8 - PedidosItens

Criado a pasta entities para organizar as classes Client, Order, OrderItem e Product, também foi criada a pasta Enum dentro da pasta Entities para organizar o Enum OrderStatus.

O programa principal cadastru um objeto Client, um Enum OrderStatus e um objeto Order com a data atual, o OrderStatus e o Cliente cadastrados.

Em seguida solicita a quantidade de itens a serem cadastrados.

O programa socicita o cadastro dos itens no objeto orderItem que são adicionados a lista da classe Order pelo metodo addItem() do classe Order.

A classe Order também possui um método override toString() com o texto padrão para apresentar o resultado, mas para utilizar os resultados dos métos toString das outras classas junto ao mesmo texto, foi usado o método StringBuilder e AppendLine. Mostrando assim a data, o status, os dados do cliente, a lista dos itens e o preço total.