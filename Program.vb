Imports System


Module Module1

    Sub Main()
        Console.Write("Escriba el valor de la bobina: ")
        Dim bobina As String
        bobina = Console.ReadLine
        Console.Write("Escriba el valor de frecuencia: ")
        Dim frecuencia As String
        frecuencia = Console.ReadLine
        Console.Write("Escriba el valor del capacitor: ")
        Dim capacitor As String
        capacitor = Console.ReadLine
        Console.Write("Escriba el valor de la resistencia: ")
        Dim resistencia As String
        resistencia = Console.ReadLine
        Dim xl As String
        xl = 2 * 3.1415 * frecuencia * bobina
        Console.WriteLine("Xl: " & xl)
        Dim angxl As String
        angxl = Math.Atan(xl / resistencia)
        Console.WriteLine("Angulo de Xl: " & angxl)
        Dim xc As String
        xc = 1 / (2 * 3.1415 * frecuencia * capacitor)
        Console.WriteLine("Xc: " & xc)
        Dim Z As String
        Dim angxc As String
        angxc = Math.Atan(-xc / resistencia)
        Console.WriteLine("Angulo de Xc: " & angxc)
        Z = Math.Sqrt(resistencia ^ 2 + (xl - xc) ^ 2)
        Console.WriteLine("Z: " & Z)
        Dim angimp As String
        angimp = Math.Atan((xl - xc) / resistencia)
        Console.WriteLine("Angulo de Z es: " & angimp)
        If 0 < xl - xc Then Console.WriteLine("Su impedancia es puramente inductiva") Else Console.WriteLine("Su impedancia es puramente capacitiva")
        Dim x As String
        x = xl - xc
        Console.WriteLine("X: " & x)
        Dim fo As String
        fo = 1 / (2 * 3.1415 * Math.Sqrt(bobina * capacitor))
        Console.WriteLine("Fo: " & fo)
        Console.WriteLine("R: " & resistencia)
    End Sub

End Module

