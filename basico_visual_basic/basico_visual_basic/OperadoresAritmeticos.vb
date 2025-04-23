Public Class OperadoresAritmeticos
    Public Shared Function ExpressaoPreDefinida() As Decimal
        Dim decExpressao As Decimal
        decExpressao = (3 * 3 * (3 + 5) / (1 + 2) ^ (5 - 3) Mod 2)

        Return decExpressao
    End Function
    Public Shared Function CalcularSoma(decNum1 As Decimal, decNum2 As Decimal) As Decimal
        Return decNum1 + decNum2
    End Function
    Public Shared Function FormulaBhaskara(decValorA As Decimal, decValorB As Decimal, decValorC As Decimal)
        Dim decValorDelta As Decimal
        Dim decResult1 As Decimal
        Dim decResult2 As Decimal

        If decValorA <> 0 Then
            decValorDelta = decValorB ^ 2 - 4 * decValorA * decValorC
            If decValorDelta = 0 Then
                Throw New ArgumentException("Delta menor que 0")
            End If

            decValorDelta = decValorDelta ^ 0.5
            decResult1 = (-decValorB + decValorDelta) / (2 * decValorA)
            decResult2 = (-decValorB - decValorDelta) / (2 * decValorA)

            Return (decResult1, decResult2)
        Else
            Return ("Valor de A não pode ser 0")
        End If

    End Function
End Class
