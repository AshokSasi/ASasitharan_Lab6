'Name: Ashok Sasitharan
'Student Id: 100745484
'Date: March 30 2020
'Description: This application is a simple text editor with functions such as new,open,close,save,save as ,cut,copy,and paste
Option Strict On
Imports System.IO

Public Class frmTextEditor
    'Global variables
    Dim existingFileName As String
    Dim textEdited As Boolean = False

    ''' <summary>
    ''' Sets the title of the form when the form loads
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets the title of the form when it loads
        Me.Text = "Text Editor Select a File to Open"
    End Sub

    ''' <summary>
    ''' Exits the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuExit_Click(sender As Object, e As EventArgs)
        ConfirmClose()
        If textEdited = False Then
            'closes the form
            Me.Close()
        End If
    End Sub

    ''' <summary>
    ''' calls the FileSave function to save a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSave_Click(sender As Object, e As EventArgs)
        FileSave()
    End Sub

    ''' <summary>
    ''' Saves the users file and opens the saveFileDialog if the file does not exist
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub FileSave()
        'variables
        Dim saveFileDialog As New SaveFileDialog
        saveFileDialog.Filter = "Text|*.txt|All|*.*"
        Dim filePath As String

        'run if the files name is not blank to save without opening the save file dialog
        If Not existingFileName = String.Empty Then
            'declare new streamReader
            Dim writer As New StreamWriter(existingFileName)
            'save the contents of the file
            writer.Write(txtTextEditor.Text)
            'close stream writer
            writer.Close()

            'run if the file name is empty
        Else
            'open the save file dialog
            saveFileDialog.ShowDialog()
            'set filePath to the entered file name
            filePath = saveFileDialog.FileName

            'run if filePath is not empty
            If Not filePath = String.Empty Then
                'declare new writer
                Dim writer As New StreamWriter(filePath)
                'save the contents of the file
                writer.Write(txtTextEditor.Text)
                'close stream writer
                writer.Close()
            End If
            'set the global file name to filePath
            existingFileName = filePath
            'set form title
            Me.Text = "Text Editor " & existingFileName
        End If
        'set text edited to false
        textEdited = False
    End Sub
    ''' <summary>
    ''' Calls the FileOpen function to open a file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuOpen_Click(sender As Object, e As EventArgs)
        FileOpen()
    End Sub

    ''' <summary>
    ''' Code for the open button that opens the file dialog to select and open the text file in the editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub FileOpen()
        'call confim close function
        ConfirmClose()

        'run if text edited is false
        If textEdited = False Then
            'variables
            Dim openFileDialog As New OpenFileDialog
            openFileDialog.Filter = "Text|*.txt|All|*.*"
            'enable the text eeditor
            txtTextEditor.Enabled = True

            'show the open fle dialog
            openFileDialog.ShowDialog()

            'set the global file name variable to the name of the file being opened
            existingFileName = openFileDialog.FileName

            'run if the global file name is not empty
            If Not existingFileName = String.Empty Then
                'declare new streamReader
                Dim reader As New StreamReader(existingFileName)
                'set the global file name variable to the name of the file being opened
                existingFileName = openFileDialog.FileName

                'output the files text into the textbox
                txtTextEditor.Text = reader.ReadToEnd()
                'close stream reader
                reader.Close()

                'set the form name
                Me.Text = "Text Editor " & existingFileName
            End If
            'set textEdited to false
            textEdited = False
        End If
    End Sub

    ''' <summary>
    ''' Calls the FileSaveAs function 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuSaveAs_Click(sender As Object, e As EventArgs)
        FileSaveAs()
    End Sub

    ''' <summary>
    ''' Code for save as button that opens the save file dialog to save and rename the text file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub FileSaveAs()
        'variables
        Dim saveFileDialog As New SaveFileDialog

        saveFileDialog.ShowDialog() 'open the save file dialog
        'set the file name variable as the name of the file being entered
        Dim filePath As String = saveFileDialog.FileName
        'run if the file name is not empty 
        If Not filePath = String.Empty Then
            'declare new stream writer
            Dim writer As New StreamWriter(filePath)
            'save the contents of the file
            writer.Write(txtTextEditor.Text)

            'close stream writer
            writer.Close()
        End If
        'set global file name to the file name
        existingFileName = filePath
        'set the form title 
        Me.Text = "Text Editor " & existingFileName
        textEdited = False
    End Sub
    ''' <summary>
    ''' calls the EditCopy function to copy text to the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs)
        EditCopy()
    End Sub

    ''' <summary>
    '''  Puts the selected text into the clipboard
    ''' </summary>
    Friend Sub EditCopy()
        Clipboard.Clear()
        'run if the selected text is not blank
        If Not txtTextEditor.SelectedText = String.Empty Then
            'puts the selected text into the clipboard
            My.Computer.Clipboard.SetText(txtTextEditor.SelectedText)
        End If
    End Sub

    ''' <summary>
    ''' calls the edit paste function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs)
        EditPaste()
    End Sub

    ''' <summary>
    ''' Gets the text in the clipboard and outputs it in the text editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub EditPaste()
        'prints out the text in the clip board into the text box
        txtTextEditor.SelectedText = My.Computer.Clipboard.GetText()
    End Sub

    ''' <summary>
    ''' calls the EditCut function
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs)
        EditCut()
    End Sub

    ''' <summary>
    ''' Puts the selected text into the clipboard and removes the selected text from the text editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Friend Sub EditCut()
        'run if the selected text is not blank
        If Not txtTextEditor.SelectedText = String.Empty Then
            'puts the selected text on the clip board
            My.Computer.Clipboard.SetText(txtTextEditor.SelectedText)
            'deletes the selected text
            txtTextEditor.SelectedText = String.Empty
        End If
    End Sub

    ''' <summary>
    ''' Creates a new text file by changing the file name to empty and clearing the text editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuNew_Click(sender As Object, e As EventArgs)
        'call confim close function
        ConfirmClose()
        If textEdited = False Then
            'enables the text box
            txtTextEditor.Enabled = True
            'sets the file name to empty
            existingFileName = String.Empty
            ' clears the textbox
            txtTextEditor.Text = ""
            'sets the title of the form
            Me.Text = "Text Editor "
            'set text edited to false
            textEdited = False
        End If
    End Sub

    ''' <summary>
    ''' closes a open text file and disables the text box
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuClose_Click(sender As Object, e As EventArgs)
        ConfirmClose() 'call confirm close function
        'run if the text has not been edited
        If textEdited = False Then
            ' sets the file name to empty
            existingFileName = String.Empty
            ' clears the text editor 
            txtTextEditor.Text = ""
            'disables the text editor
            txtTextEditor.Enabled = False
            'sets the title of the form
            Me.Text = "Text Editor "
            'set text edited to false
            textEdited = False
        End If
    End Sub

    ''' <summary>
    ''' Displays a message box that shows details about the lab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'creates a message box
        MessageBox.Show("NETD 2202" & vbCrLf & vbCrLf & "Lab #5" & vbCrLf & vbCrLf & "A.Sasitharan", "About")
    End Sub

    ''' <summary>
    ''' Sets a boolean to true if text has been edited in the file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub txtTextEditor_TextChanged(sender As Object, e As EventArgs) Handles txtTextEditor.TextChanged
        'sets textEdited to true
        textEdited = True
    End Sub

    ''' <summary>
    ''' function that displays a message box if text in the file has been edited asking the user if they want to close the file without saving
    ''' </summary>
    Sub ConfirmClose()
        'run if textEdited equals true
        If textEdited = True Then
            'run if the user presses yes on the yes no message box
            If MsgBox("You have unsaved changes. Are you sure you want to close the file?.", MsgBoxStyle.YesNo, "Text Editor") = MsgBoxResult.Yes Then
                textEdited = False 'sets textEdited to false

                ' run if the user presses no on the yes no message box
            Else
                'sets textEdited to true
                textEdited = True
            End If
        End If
    End Sub
End Class
