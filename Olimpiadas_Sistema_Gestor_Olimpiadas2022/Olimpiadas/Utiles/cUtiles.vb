Public Class cUtiles
    
End Class

Public Class Combo_ItemData
    Private vId As String
    Private vNombre As String

    Public Sub New()
        vNombre = ""
        vId = 0
    End Sub

    Public Sub New(ByVal pNombre As String, ByVal pId As String)
        vNombre = pNombre
        vId = pId
    End Sub

    Public Property Nombre() As String
        Get
            Return vNombre
        End Get
        Set(ByVal sValue As String)
            vNombre = sValue
        End Set
    End Property

    Public Property ItemData() As String
        Get
            Return vId
        End Get
        Set(ByVal iValue As String)
            vId = iValue
        End Set
    End Property

    Public Overrides Function ToString() As String
        Return vNombre
    End Function
    
End Class

Public Class COrdenarListview
    Implements IComparer

    Private vIndiceColumna As Integer
    Private vTipoOrden As SortOrder

    Public Sub New(ByVal pIndiceColumna As Integer, ByVal pTipoOrden As SortOrder)
        vIndiceColumna = pIndiceColumna
        vTipoOrden = pTipoOrden
    End Sub

    Public Function Ordenar(ByVal x As Object, ByVal y As Object) As Integer Implements System.Collections.IComparer.Compare
        Dim item_x As ListViewItem = DirectCast(x, ListViewItem)
        Dim item_y As ListViewItem = DirectCast(y, ListViewItem)

        Dim string_x As String

        If item_x.SubItems.Count <= vIndiceColumna Then
            string_x = ""
        Else
            string_x = item_x.SubItems(vIndiceColumna).Text
        End If

        Dim string_y As String
        If item_y.SubItems.Count <= vIndiceColumna Then
            string_y = ""
        Else
            string_y = item_y.SubItems(vIndiceColumna).Text
        End If

        If vTipoOrden = SortOrder.Ascending Then
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_x).CompareTo(Val(string_y))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_x).CompareTo(DateTime.Parse(string_y))
            Else
                Return String.Compare(string_x, string_y)
            End If
        Else
            If IsNumeric(string_x) And IsNumeric(string_y) Then
                Return Val(string_y).CompareTo(Val(string_x))
            ElseIf IsDate(string_x) And IsDate(string_y) Then
                Return DateTime.Parse(string_y).CompareTo(DateTime.Parse(string_x))
            Else
                Return String.Compare(string_y, string_x)
            End If
        End If
    End Function
End Class
