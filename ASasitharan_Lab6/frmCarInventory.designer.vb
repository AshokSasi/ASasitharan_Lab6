<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCarInventory
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblMake = New System.Windows.Forms.Label()
        Me.lblYear = New System.Windows.Forms.Label()
        Me.lblModel = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.cbMake = New System.Windows.Forms.ComboBox()
        Me.lvwCars = New System.Windows.Forms.ListView()
        Me.colNew = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colId = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colMake = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colModel = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colYears = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.colPrices = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.numericUpDownYear = New System.Windows.Forms.NumericUpDown()
        Me.txtModel = New System.Windows.Forms.TextBox()
        Me.txtPrice = New System.Windows.Forms.TextBox()
        Me.lblOutput = New System.Windows.Forms.Label()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.chkNew = New System.Windows.Forms.CheckBox()
        Me.toolTipCarInventory = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.numericUpDownYear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMake
        '
        Me.lblMake.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMake.Location = New System.Drawing.Point(37, 22)
        Me.lblMake.Name = "lblMake"
        Me.lblMake.Size = New System.Drawing.Size(41, 21)
        Me.lblMake.TabIndex = 0
        Me.lblMake.Text = "&Make:"
        Me.lblMake.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblYear
        '
        Me.lblYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblYear.Location = New System.Drawing.Point(37, 88)
        Me.lblYear.Name = "lblYear"
        Me.lblYear.Size = New System.Drawing.Size(35, 15)
        Me.lblYear.TabIndex = 4
        Me.lblYear.Text = "&Year:"
        Me.lblYear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblModel
        '
        Me.lblModel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblModel.Location = New System.Drawing.Point(37, 57)
        Me.lblModel.Name = "lblModel"
        Me.lblModel.Size = New System.Drawing.Size(45, 15)
        Me.lblModel.TabIndex = 2
        Me.lblModel.Text = "M&odel:"
        Me.lblModel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblPrice
        '
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(37, 115)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(38, 15)
        Me.lblPrice.TabIndex = 6
        Me.lblPrice.Text = "&Price:"
        Me.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'cbMake
        '
        Me.cbMake.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbMake.FormattingEnabled = True
        Me.cbMake.Items.AddRange(New Object() {"Acura", "Audi", "Bentley", "Buick", "Chevorlet", "Ford", "Honda", "Hyundai", "Jeep", "Toyota", "Volkswagen", "", "", "", ""})
        Me.cbMake.Location = New System.Drawing.Point(89, 21)
        Me.cbMake.Name = "cbMake"
        Me.cbMake.Size = New System.Drawing.Size(121, 21)
        Me.cbMake.TabIndex = 1
        Me.toolTipCarInventory.SetToolTip(Me.cbMake, "Choose the car make.")
        '
        'lvwCars
        '
        Me.lvwCars.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.colNew, Me.colId, Me.colMake, Me.colModel, Me.colYears, Me.colPrices})
        Me.lvwCars.FullRowSelect = True
        Me.lvwCars.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lvwCars.HideSelection = False
        Me.lvwCars.Location = New System.Drawing.Point(38, 204)
        Me.lvwCars.MultiSelect = False
        Me.lvwCars.Name = "lvwCars"
        Me.lvwCars.Size = New System.Drawing.Size(359, 186)
        Me.lvwCars.TabIndex = 9
        Me.toolTipCarInventory.SetToolTip(Me.lvwCars, "Select a car to edit.")
        Me.lvwCars.UseCompatibleStateImageBehavior = False
        Me.lvwCars.View = System.Windows.Forms.View.Details
        '
        'colNew
        '
        Me.colNew.Text = "New"
        Me.colNew.Width = 47
        '
        'colId
        '
        Me.colId.Text = "ID"
        Me.colId.Width = 46
        '
        'colMake
        '
        Me.colMake.Text = "Make"
        Me.colMake.Width = 64
        '
        'colModel
        '
        Me.colModel.Text = "Model"
        Me.colModel.Width = 65
        '
        'colYears
        '
        Me.colYears.Text = "Year"
        Me.colYears.Width = 52
        '
        'colPrices
        '
        Me.colPrices.Text = "Price"
        Me.colPrices.Width = 79
        '
        'numericUpDownYear
        '
        Me.numericUpDownYear.Location = New System.Drawing.Point(89, 88)
        Me.numericUpDownYear.Maximum = New Decimal(New Integer() {2020, 0, 0, 0})
        Me.numericUpDownYear.Minimum = New Decimal(New Integer() {1920, 0, 0, 0})
        Me.numericUpDownYear.Name = "numericUpDownYear"
        Me.numericUpDownYear.Size = New System.Drawing.Size(120, 20)
        Me.numericUpDownYear.TabIndex = 5
        Me.toolTipCarInventory.SetToolTip(Me.numericUpDownYear, "Choose the year the car was manufactured in.")
        Me.numericUpDownYear.Value = New Decimal(New Integer() {1920, 0, 0, 0})
        '
        'txtModel
        '
        Me.txtModel.Location = New System.Drawing.Point(89, 56)
        Me.txtModel.Multiline = True
        Me.txtModel.Name = "txtModel"
        Me.txtModel.Size = New System.Drawing.Size(120, 20)
        Me.txtModel.TabIndex = 3
        Me.toolTipCarInventory.SetToolTip(Me.txtModel, "Enter the car's model.")
        '
        'txtPrice
        '
        Me.txtPrice.Location = New System.Drawing.Point(89, 115)
        Me.txtPrice.Multiline = True
        Me.txtPrice.Name = "txtPrice"
        Me.txtPrice.Size = New System.Drawing.Size(120, 20)
        Me.txtPrice.TabIndex = 7
        Me.toolTipCarInventory.SetToolTip(Me.txtPrice, "Enter the price of the car.")
        '
        'lblOutput
        '
        Me.lblOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblOutput.Location = New System.Drawing.Point(38, 393)
        Me.lblOutput.Name = "lblOutput"
        Me.lblOutput.Size = New System.Drawing.Size(359, 103)
        Me.lblOutput.TabIndex = 10
        Me.toolTipCarInventory.SetToolTip(Me.lblOutput, "Displays output messages.")
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(38, 517)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(83, 32)
        Me.btnEnter.TabIndex = 11
        Me.btnEnter.Text = "&Enter"
        Me.toolTipCarInventory.SetToolTip(Me.btnEnter, "Press to enter a car's information.")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(174, 517)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(83, 32)
        Me.btnReset.TabIndex = 12
        Me.btnReset.Text = "&Reset"
        Me.toolTipCarInventory.SetToolTip(Me.btnReset, "Press to reset the form.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(314, 517)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(83, 32)
        Me.btnExit.TabIndex = 13
        Me.btnExit.Text = "E&xit"
        Me.toolTipCarInventory.SetToolTip(Me.btnExit, "Press to close the application.")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'chkNew
        '
        Me.chkNew.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkNew.Location = New System.Drawing.Point(0, 141)
        Me.chkNew.Name = "chkNew"
        Me.chkNew.Size = New System.Drawing.Size(92, 24)
        Me.chkNew.TabIndex = 8
        Me.chkNew.Text = "&New"
        Me.chkNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.toolTipCarInventory.SetToolTip(Me.chkNew, "Select if the car is new or not.")
        Me.chkNew.UseVisualStyleBackColor = True
        '
        'frmCarInventory
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(428, 561)
        Me.Controls.Add(Me.chkNew)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.lblOutput)
        Me.Controls.Add(Me.txtPrice)
        Me.Controls.Add(Me.txtModel)
        Me.Controls.Add(Me.numericUpDownYear)
        Me.Controls.Add(Me.lvwCars)
        Me.Controls.Add(Me.cbMake)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblModel)
        Me.Controls.Add(Me.lblYear)
        Me.Controls.Add(Me.lblMake)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCarInventory"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Car Inventory"
        CType(Me.numericUpDownYear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMake As Label
    Friend WithEvents lblYear As Label
    Friend WithEvents lblModel As Label
    Friend WithEvents lblPrice As Label
    Friend WithEvents cbMake As ComboBox
    Friend WithEvents lvwCars As ListView
    Friend WithEvents colNew As ColumnHeader
    Friend WithEvents colId As ColumnHeader
    Friend WithEvents colMake As ColumnHeader
    Friend WithEvents numericUpDownYear As NumericUpDown
    Friend WithEvents txtModel As TextBox
    Friend WithEvents txtPrice As TextBox
    Friend WithEvents lblOutput As Label
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents chkNew As CheckBox
    Friend WithEvents colModel As ColumnHeader
    Friend WithEvents colYears As ColumnHeader
    Friend WithEvents colPrices As ColumnHeader
    Friend WithEvents toolTipCarInventory As ToolTip
End Class
