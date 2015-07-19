Imports System.IO

Public Class Form1
    ' Class-level variables
    Private strFilename As String = String.Empty    ' Document filename
    Dim blnIsChanged As Boolean = False             ' File change flag

    Sub ClearDocument()
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
            ' Retieve the selected filename.
            strFilename = ofdOpenFile.FileName

            Try
                ' Open the file.
                inputFile = File.OpenText(strFilename)

                ' Read the file's contents into the TextBox.
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
            ' Create the file.
            outputFile = File.CreateText(strFilename)

            ' Write the TextBox to the file.
            outputFile.Write(txtDocument.Text)

            ' Close the file.
            outputFile.Close()

            ' Update the isChanged variable.
            blnIsChanged = False
        Catch
            ' Error message for file creation error.
            MessageBox.Show("Error creating the file.")
        End Try
    End Sub


    Private Sub txtDocument_TextChanged(sender As Object, e As EventArgs) Handles txtDocument.TextChanged
        ' Indicate the text has changed.
        blnIsChanged = True
    End Sub


    Private Sub mnuFileNew_Click(sender As Object, e As EventArgs) Handles mnuFileNew.Click
        ' Has the current document changed?
        If blnIsChanged = True Then
            ' Confirm before clearing the document.
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                ClearDocument()
            End If
        Else
            ' Document has not changed, so clear it.
            ClearDocument()
        End If
    End Sub

    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click
        ' Has the current documnet changed?
        If blnIsChanged = True Then
            ' Confirm before clearing and replacing.
            If MessageBox.Show("The current document is not saved. " &
                               "Are you sure?", "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                ClearDocument()
                OpenDocument()
            Else
                ' Document has not changed, so replace it.
                ClearDocument()
                OpenDocument()
            End If
        End If
    End Sub

    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click
        ' Does the current document have a filename.
        If strFilename = String.Empty Then
            ' The document has not been saved, so
            ' use Save As dialog box.
            If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
                strFilename = sfdSaveFile.FileName
                SaveDocument()
            End If
        Else
            ' Save the document with the current filename.
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        ' Save the current document under a new filename.
        If sfdSaveFile.ShowDialog = Windows.Forms.DialogResult.OK Then
            strFilename = sfdSaveFile.FileName
            SaveDocument()
        End If
    End Sub

    Private Sub mnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        ' Close the form.
        Me.Close()
    End Sub

    Private Sub mnuHelpAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        ' Display an about box.
        MessageBox.Show("Simple Text Editor version 1.0")
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' If the document has benn modified, confirm
        ' before exiting.
        If blnIsChanged = True Then
            If MessageBox.Show("The current document is not saved. " &
                               "Do you wish to discard your charges?",
                               "Confirm",
                               MessageBoxButtons.YesNo) =
                           Windows.Forms.DialogResult.Yes Then
                e.Cancel = False
            Else
                e.Cancel = True
            End If
        End If
    End Sub
End Class