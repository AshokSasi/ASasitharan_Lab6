'Name: Ashok Sasitharan
'Student Id: 100745484
'Date: April 16  2020
'Description: This application is an MDI form that can open the text editor, car list, and average units shipped applications
Option Strict On
Imports System.IO
Public Class frmMain

    ''' <summary>
    '''  Puts the selected text into the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCopy_Click(sender As Object, e As EventArgs) Handles mnuEditCopy.Click
        'run if the active mdi child is the text editor
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            'call the copu function from frmTextEditor
            CType(ActiveMdiChild, frmTextEditor).EditCopy()

            'run if the selected mdi child is not frmTextEditor
        Else
            'display an error message
            MessageBox.Show("Cannot copy from the current selected window")
        End If
    End Sub
    ''' <summary>
    ''' Creates a new instance of frmTextEditor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ShowNewTextEditor(sender As Object, e As EventArgs) Handles mnuFileNew.Click, tsNewTextEditor.Click
        'Creates a new instance of frmTextEditor
        Dim myTextEditor As New frmTextEditor
        'sets the Mdi parent 
        myTextEditor.MdiParent = Me
        'shows the form
        myTextEditor.Show()
    End Sub

    ''' <summary>
    ''' Puts the selected text into the clipboard and removes the selected text from the text editor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditCut_Click(sender As Object, e As EventArgs) Handles mnuEditCut.Click
        'run if the active mdi child is the text editor
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            'call the friend cut function from frmTextEditor
            CType(ActiveMdiChild, frmTextEditor).EditCut()

            'run if the selected mdi child is not frmTextEditor
        Else
            'display error message
            MessageBox.Show("Cannot cut from the current selected window")
        End If
    End Sub

    ''' <summary>
    ''' Prints out the text stored in the clipboard
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuEditPaste_Click(sender As Object, e As EventArgs) Handles mnuEditPaste.Click
        'run if the active mdi child is the text editor
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            'call the friend paste function from frmTextEditor
            CType(ActiveMdiChild, frmTextEditor).EditPaste()

            'run if the selected mdi child is not frmTextEditor
        Else
            'display error message
            MessageBox.Show("Cannot paste from the current selected window")
        End If
    End Sub
    ''' <summary>
    '''  Saves the users file and opens the saveFileDialog if the file does not exist
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSave_Click(sender As Object, e As EventArgs) Handles mnuFileSave.Click, tsSave.Click
        'run if the active mdi child is the text editor
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            'call the friend save function from frmTextEditor
            CType(ActiveMdiChild, frmTextEditor).FileSave()

            'run if the selected mdi child is not frmTextEditor
        Else
            'display error message
            MessageBox.Show("Cannot save the current selected window")
        End If

    End Sub
    ''' <summary>
    ''' Opens the user's file using the open file dialog
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileOpen_Click(sender As Object, e As EventArgs) Handles mnuFileOpen.Click, tsOpen.Click
        'Variables
        Dim openFileDialog As New OpenFileDialog
        Dim existingFileName As String
        'set the filter for the open file dialog to only show text files
        openFileDialog.Filter = "Text|*.txt|All|*.*"
        'show the OpenFileDialog
        openFileDialog.ShowDialog()
        'set the existing file name to the name of the file being opened
        existingFileName = openFileDialog.FileName


        'run if the existing file name is not empty
        If Not existingFileName = String.Empty Then
            'declare new streamReader
            Dim reader As New StreamReader(existingFileName)

            'create a new instance of frmTextEditor
            Dim myTextEditor As New frmTextEditor

            'read through the file
            myTextEditor.txtTextEditor.Text = reader.ReadToEnd

            'close the stream reader
            reader.Close()

            'set the mdi parent to the current form
            myTextEditor.MdiParent = Me

            'show the text editor
            myTextEditor.Show()
            'set the form name to have the file path
            myTextEditor.Text = "Text Editor " & existingFileName
        End If
    End Sub
    ''' <summary>
    '''  Code for save as button that opens the save file dialog to save and rename the text file
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileSaveAs_Click(sender As Object, e As EventArgs) Handles mnuFileSaveAs.Click
        'run if frmTextEditor is not the active child
        If TypeOf (ActiveMdiChild) Is frmTextEditor Then
            'call the FileSaveAs friend function from frmTextEditor
            CType(ActiveMdiChild, frmTextEditor).FileSaveAs()

            'run if the active child is not frmTextEditor
        Else
            'display an error message
            MessageBox.Show("Cannot save in the current selected window")
        End If
    End Sub
    ''' <summary>
    ''' Closes the active instance of frmTextEditor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuFileClose_Click(sender As Object, e As EventArgs) Handles mnuFileClose.Click

        'run if there are mdi children
        If MdiChildren.Count > 0 Then
            'show a message box asking if the user wants to exit the application.
            ' If the user selects yes then close the active mdi child
            If MessageBox.Show("Do you want to close the application?", "Exit", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then
                ActiveMdiChild.Close()
            End If

            'run if there are no mdi children open
        Else
            'show a message box asking the user if they want to exit the application 
            'If the user does want to the close if then close the whole form
            If MessageBox.Show("Do you want to exit the application?", "Exit", MessageBoxButtons.YesNo) =
                DialogResult.Yes Then
                Me.Close()
            End If
        End If

    End Sub

    ''' <summary>
    ''' Exits the application
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FileExit(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'closes the form
        Me.Close()
    End Sub


    ''' <summary>
    ''' Makes all mdi children windows cascade
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowCascade_Click(sender As Object, e As EventArgs) Handles mnuWindowCascade.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    ''' <summary>
    ''' Tiles the mdi child windows horizontally
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowTileHorizontal_Click(sender As Object, e As EventArgs) Handles mnuWindowTileHorizontal.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    ''' <summary>
    ''' Tiles the mdi child windows vertically
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowTileVertical_Click(sender As Object, e As EventArgs) Handles mnuWindowTileVertical.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    ''' <summary>
    ''' Opens frmCarInventory
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowOpenCarInventory_Click(sender As Object, e As EventArgs) Handles mnuWindowOpenCarList.Click, tsOpenCarList.Click
        'creates a new instance of frmCarInventory
        Dim myCarInventory As New frmCarInventory
        'set myCarInventory as the mdi parent
        myCarInventory.MdiParent = Me
        'Show myCarInventory
        myCarInventory.Show()
    End Sub

    ''' <summary>
    ''' Displays a message box with information about the lab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuAbout_Click(sender As Object, e As EventArgs) Handles mnuHelpAbout.Click
        'creates a message box
        MessageBox.Show("NETD 2202" & vbCrLf & vbCrLf & "Lab #6" & vbCrLf & vbCrLf & "A.Sasitharan", "About")
    End Sub

    ''' <summary>
    ''' Opens a new instance frmAverageUnits
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub mnuWindowOpenAverageUnits_Click(sender As Object, e As EventArgs) Handles mnuWindowOpenAverageUnits.Click, tsOpenAverageUnitsShipped.Click
        'create a new instance of frmAverageUnitsShipped
        Dim myAverageUnitsShipped As New frmAverageUnitsShipped
        'Set myaverageUnitsShipped as the mdi parent
        myAverageUnitsShipped.MdiParent = Me
        'Show myAverageUnitsShipped
        myAverageUnitsShipped.Show()
    End Sub

End Class
