Imports System.IO

Public Class Form1
    ' Class-level variables
    Private strFilename As String = String.Empty    ' Document filename
    Dim blnIsChanged As Boolean = False             ' File change flag

    Sub ClearDocumnet()
        ' Clear the contents of the text box.
        txtDocument.Clear()

        ' Clear the documnet name.
        strFilename = String.Empty

        ' Set is Changed to False.
        blnIsChanged = False
    End Sub
End Class
