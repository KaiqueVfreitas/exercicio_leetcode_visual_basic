Module Module1

    Sub Main()
        Dim decNum1 As Decimal
        Dim decNum2 As Decimal
        Dim decResult As Decimal

        Console.WriteLine("SOMA DOIS NÚMEROS")
        Console.Write("Digite o numero 1:")
        decNum1 = Console.ReadLine()
        Console.Write("Digite o numero 2:")
        decNum2 = Console.ReadLine()

        decResult = Soma.CalcularSoma(decNum1, decNum2)


        Console.Write($"O seu resultado foi {decResult}")

    End Sub

End Module
