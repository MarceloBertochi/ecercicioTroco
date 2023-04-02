decimal valorDaCompra, valorPago, valorDoTroco; //criado 3 variáveis com tipo decimal

Console.WriteLine("--- Troco ---\n"); // criamos um títiulo - \n para pular linha

Console.Write("Valor da compra (R$)...: "); // avisa o valor da compra que será digitado
valorDaCompra = Convert.ToDecimal(Console.ReadLine()); // vaviavel valorDaCompra convertido para decimal, aguardando o entrada do valor com ReadLine

Console.Write("Valor pago (R$)........: "); // avisa o valor pago que será digitado
valorPago = Convert.ToDecimal(Console.ReadLine()); // vaviavel valorPago convertido para decimal, aguardando o entrada do valor com ReadLine

valorDoTroco = valorPago - valorDaCompra; // Variável valorDoTroco atribuido a uma subtração do ValorPago - ValorDaCompra

Console.WriteLine($"\nTroco: {valorDoTroco:C}"); // saída do valor do troco - :C coloca R$ 
