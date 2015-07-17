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

    ' The OpenDocument procedure opens a file and loads it
    ' into the TextBox for editing.

    Sub OpenDocument()
        Dim inputFile As StreamReader   ' Object variable

        If ofdOpenFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            ' Retieve the elected filename.
            strFilename = ofdOpenFile.FileName

            Try
                ' Open the file.
                inputFile = File.OpenText(strFilename)

                ' Read thr file's contents into the TextBox.
                txtDocument.Text = inputFile.ReadToEnd

                ' Close the file.
                inputFile.Close()

                ' Update the isChanged variable.
                blnIsChanged = False
            Catch
                ' Error message for file open error.
                MessageBox.Show("Error opening the file.")
            End Try
        End If
    End Sub

    ' The SaveDocumnet procedure saves the current document.

    Sub SaveDocument()
        Dim outputFile As StreamWriter  ' Object variable

        Try

        Catch ex As Exception

        End Try
    End Sub
End Class
