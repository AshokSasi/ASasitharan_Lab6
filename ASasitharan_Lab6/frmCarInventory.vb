'Name: Ashok Sasitharan
'Student Id: 100745484
'Date: March 13 2020
'Description: This application will take in the details of a car such as the make,model,price,year,
'And whether the car Is New Or Not And will add the car to a list. The added car's information can also be edited.
Option Strict On
Public Class frmCarInventory
    'Global Variables
    Dim selectedCar As Car
    Dim isCarSelected As Boolean = False
    Dim carList As New List(Of Car)
    Dim isAddingToListView As Boolean = False

    ''' <summary>
    ''' When the form loads set the numeric up down's value to the max value
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'set the year to 2020 on load
        numericUpDownYear.Value = numericUpDownYear.Maximum
    End Sub
    ''' <summary>
    ''' This button closes the application when clicked
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    ''' <summary>
    ''' Checks if form inputs are valid and then adds them to the listview in a new car object or edits previous data entries when pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'calls IsValid and runs if user input is valid
        If IsValid() = True Then
            'run if a car is selected
            If Not isCarSelected Then
                'Create a new car object
                selectedCar = New Car(cbMake.Text, txtModel.Text, Convert.ToInt32(numericUpDownYear.Value), Convert.ToDecimal(txtPrice.Text), chkNew.Checked)
                'add the car to the car list
                carList.Add(selectedCar)
                'outputs message with car data
                lblOutput.Text = "It worked! " & vbCrLf & selectedCar.GetCarData
                'runs if a car exitst in the list
            ElseIf selectedCar.Id.Trim.Length > 0 Then
                'set old data with new inputs
                selectedCar.Make = cbMake.Text
                selectedCar.Model = txtModel.Text
                selectedCar.Price = Convert.ToDecimal(txtPrice.Text)
                selectedCar.Year = Convert.ToInt32(numericUpDownYear.Value)
                selectedCar.IsNew = chkNew.Checked
                'outputs message with car data
                lblOutput.Text = "It worked! " & vbCrLf & selectedCar.GetCarData
            End If
            'call set defaults
            SetDefaults()
        End If
    End Sub

    ''' <summary>
    ''' event handler that is used when a character in the list is selected
    ''' </summary>
    Private Sub lvwCars_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvwCars.SelectedIndexChanged
        Dim priceInput As Decimal = 0.0D

        'runs ifa list view item is selected
        If lvwCars.SelectedIndices.Count = 1 Then
            selectedCar = carList(lvwCars.SelectedIndices(0))
            'set isCarSelected to true
            isCarSelected = True
            'set form inputs to the selected cars inputs
            cbMake.Text = selectedCar.Make
            txtModel.Text = selectedCar.Model
            numericUpDownYear.Value = selectedCar.Year
            txtPrice.Text = selectedCar.Price.ToString
            chkNew.Checked = selectedCar.IsNew

        Else
            'set isCarSelected to false
            isCarSelected = False
        End If

    End Sub

    ''' <summary>
    ''' This procedure stops an entry's checkbox from being checked in the listview
    ''' </summary>
    Private Sub lvwCars_ItemCheck(sender As Object, e As ItemCheckEventArgs) Handles lvwCars.ItemCheck

        ' run if a car is not currently being added to the list
        If Not isAddingToListView Then

            ' keep the old checkbox value
            e.NewValue = e.CurrentValue
        End If
    End Sub

    ''' <summary>
    ''' This procedure sets the form controls to their defualt state and call the populate list procedure
    ''' </summary>
    Private Sub SetDefaults()
        'sets the make combo box to blank
        cbMake.SelectedIndex = -1
        'set model textbox to blank
        txtModel.Text = ""
        'set price textbox to blank
        txtPrice.Text = ""
        'set the is New checkbox to unchecked
        chkNew.Checked = False
        'set the numeric up downs year to 2020 which is the maximum
        numericUpDownYear.Value = numericUpDownYear.Maximum
        'set focus to make combo box
        Me.cbMake.Focus()
        'call populate list
        PopulateList()


    End Sub

    ''' <summary>
    ''' This function checks the inputs and displays error messages if input is invalid
    ''' </summary>
    ''' <returns></returns>
    Private Function IsValid() As Boolean
        'Variables
        Dim errorMessage As String = String.Empty
        Dim isValidInput As Boolean = True
        Dim priceInput As Decimal = 0.0D

        'run if make is not chosen
        If cbMake.Text = String.Empty Then
            'add error message
            errorMessage += "Please select a make for the car." & vbCrLf

            ' set isValidInput to false
            isValidInput = False
        End If

        'run if model input is blank
        If txtModel.Text = String.Empty Then

            ' add error message
            errorMessage += "Please enter the model of the car." & vbCrLf
            txtModel.Focus()
            ' set isValidInput to false
            isValidInput = False

        End If

        'run if the price is empty or not numeric
        If Not Decimal.TryParse(txtPrice.Text, priceInput) Then

            ' add error message
            errorMessage += "Price must be a number greater than 0." & vbCrLf
            txtPrice.Focus()
            txtPrice.SelectAll()

            ' set isValidInput to false
            isValidInput = False

            'run if the price was less than 0
        ElseIf Convert.ToDecimal(txtPrice.Text) < 0 Then
            ' add error message
            errorMessage += "Please enter a price greater than or equal to $0.00." & vbCrLf
            txtPrice.Focus()
            txtPrice.SelectAll()

            ' set isValidInput to false
            isValidInput = False
        End If

        If isValidInput = False Then
            ' display the error message in output textbox
            lblOutput.Text = errorMessage
        End If
        'return the boolean value of isValidInput
        Return isValidInput
    End Function

    ''' <summary>
    ''' This procedure populates the listview with the inputted car data
    ''' </summary>
    Sub PopulateList()

        ' Clear the items from the listview control
        lvwCars.Items.Clear()

        ' This For loop re-populates the list
        For index As Integer = 0 To carList.Count - 1
            'create a new listview item
            Dim carItem As New ListViewItem()
            'makes checkboxes appear on the listview
            lvwCars.CheckBoxes = True

            'assign the values to the listview item
            carItem.Checked = carList(index).IsNew
            carItem.SubItems.Add(carList(index).Id.ToString())
            carItem.SubItems.Add(carList(index).Make)
            carItem.SubItems.Add(carList(index).Model)
            carItem.SubItems.Add(carList(index).Year.ToString())
            carItem.SubItems.Add(carList(index).Price.ToString("c"))

            'set to true to show that a car is being inputted into the list
            isAddingToListView = True

            'add the car's details to the listview
            lvwCars.Items.Add(carItem)

            ' set isAddingToListView to false to show that a car is not being inputted to the list
            isAddingToListView = False
        Next
    End Sub

    ''' <summary>
    ''' This button sets the form to its default state when pressed
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ' call setDefaults procedure
        SetDefaults()
    End Sub
End Class
