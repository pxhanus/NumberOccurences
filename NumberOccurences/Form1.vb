'Patricia Hanus
'151202
'Number Occurences
'_____________________________________________________________________________
Public Class Form1

    Private Sub btnCountNumerals_Click(sender As Object, e As EventArgs) Handles btnCountNumerals.Click
        Dim numStr As String = Me.txtNum.Text
        Dim occurences(9) As Integer

        Call NumOccur(numStr, occurences)
        Call DisplayOccur(Me.lstNumOccurences, occurences)
    End Sub
    '********************************************************************************************
    'NumOccur
    'Counts the occurences of numbers in a string
    'pre:  An appropriately sized array - size 10	
    'post: returns a filled array 
    '********************************************************************************************
    Sub NumOccur(ByVal numStr As String, ByRef array() As Integer)
        Dim numIndex As String
        Dim num As Char
        For index As Integer = 0 To numStr.Length - 1
            num = numStr.Chars(index)
            If num >= ChrW(48) _
                And num <= ChrW(57) Then
                numIndex = (AscW(num) - 48)
                array(numIndex) += 1
            End If
        Next
    End Sub
    '********************************************************************************************
    'DisplayOccur
    'Displays the contents of the passed array in the passed list box values index
    '
    'post:  Array results displayed in list box 
    '********************************************************************************************
    Sub DisplayOccur(ByRef lstbox As ListBox, ByRef array() As Integer)
        For index As Integer = 0 To array.Length - 1
            lstbox.Items.Add(index & vbTab & array(index))
        Next
    End Sub

    Private Sub txtNum_TextChanged(sender As Object, e As EventArgs) Handles txtNum.TextChanged
        Me.lstNumOccurences.Items.Clear()
    End Sub
End Class
