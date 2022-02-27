Imports System.Text.RegularExpressions

Public Class ValidacionesAIRIS
    'Solo numeros
    Public Function allNumbers(cadena As String) As Boolean

        'Se utilizan expresiones regulares para indicar si es numero o no
        'Se aceptan "," y "." como separador entre enteros y decimales
        allNumbers = Regex.IsMatch(cadena, "^$|^\d*$")

        Return allNumbers

    End Function
    'Solo letras
    Public Function onlyLetter(cadena As String) As Boolean
        onlyLetter = Regex.IsMatch(cadena, "^[a-zA-ZñÑíÍóÓéÉáÁúÚüÜ]+([ -][a-zA-ZñÑíÍóÓéÉáÁúÚüÜ]+)*[ ]*$")
        Return onlyLetter
    End Function



    'Alfanumerico
    Public Function validarAlfanumerico(cadena As String) As Boolean

        validarAlfanumerico = (Regex.IsMatch(cadena, "^$|^[a-zA-Z0-9_ -]*$"))

        Return validarAlfanumerico

    End Function

    'Telefono

    Public Function validarNumeroTelefono(numero As String) As Boolean

        'El numero es valido si empieza por parentesis, "+" o numeros, si conteniene espacios en blanco
        ' entre los numeros y su numero de caracteres es mayor a 8
        validarNumeroTelefono = (Regex.IsMatch(numero, "^$|^(\(\+?(\d){1,3}\))?(\d){9,13}$"))

        Return validarNumeroTelefono

    End Function

    Public Function insertNumeroTelefono(numero As String) As Boolean

        'El numero es valido si empieza por parentesis, "+" o numeros, si conteniene espacios en blanco
        ' entre los numeros y su numero de caracteres es mayor a 8
        insertNumeroTelefono = (Regex.IsMatch(numero, "^$|^[0-9+()]*$"))

        Return insertNumeroTelefono

    End Function

    Public Function numeroPositivo(numeroCadena As String) As Boolean

        'Se guarda en la variable numero el valor de la cadena
        'Si se encuentra un caracter que no es digito
        'la funcion devuelve 0
        Dim numero As Double = Val(numeroCadena)

        'Si el numero es mayor a 0 la funcion 
        'devuelve true sino false
        If numero > 0 Then

            numeroPositivo = True

        Else

            numeroPositivo = False

        End If

        Return numeroPositivo

    End Function

    Public Function naturalDecimal(numero As String) As Boolean

        'Compureba que sea un natural entero o decimal
        naturalDecimal = (Regex.IsMatch(numero, "^$|^\d*\.?\d+$"))

        Return naturalDecimal

    End Function



End Class
