# 11 - SaqueConta

Neste exercício foi montada uma classe account e o programa principal atribui os dados e o saldo do objeto.
Após atribuir o saldo, pede um valor para saque.

Dentro da pasta Entities, foi criado a pasta Exceptios para organizar a classe de excessão (e outras excessões se nessessário).

Dentro da função withDraw(), foi programado para caso o saque fosse maior que o saldo exibir uma mensagem de erro com o auxilio de "throw new DomainException('Mensagem do erro')".

No programa principal, a parte do código referente a esta função foi colocada dentro do bloco try{} com o bloco catch(DomainException){} logo abaixo para mostrar a mensagem do erro.