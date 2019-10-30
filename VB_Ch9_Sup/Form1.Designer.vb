<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VB_Ch9_Sup
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Load = New System.Windows.Forms.TabPage()
        Me.btnProcess = New System.Windows.Forms.Button()
        Me.txtFilePath = New System.Windows.Forms.TextBox()
        Me.btnSelectFile = New System.Windows.Forms.Button()
        Me.View = New System.Windows.Forms.TabPage()
        Me.btnMakeLower = New System.Windows.Forms.Button()
        Me.btnRemPunct = New System.Windows.Forms.Button()
        Me.txtDisplayText = New System.Windows.Forms.TextBox()
        Me.lblFileText = New System.Windows.Forms.Label()
        Me.btnCountToFile = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.TabControl1.SuspendLayout()
        Me.Load.SuspendLayout()
        Me.View.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Load)
        Me.TabControl1.Controls.Add(Me.View)
        Me.TabControl1.Location = New System.Drawing.Point(13, 13)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(983, 704)
        Me.TabControl1.TabIndex = 0
        '
        'Load
        '
        Me.Load.Controls.Add(Me.btnProcess)
        Me.Load.Controls.Add(Me.txtFilePath)
        Me.Load.Controls.Add(Me.btnSelectFile)
        Me.Load.Location = New System.Drawing.Point(4, 22)
        Me.Load.Name = "Load"
        Me.Load.Padding = New System.Windows.Forms.Padding(3)
        Me.Load.Size = New System.Drawing.Size(975, 678)
        Me.Load.TabIndex = 0
        Me.Load.Text = "Load"
        Me.Load.UseVisualStyleBackColor = True
        '
        'btnProcess
        '
        Me.btnProcess.BackColor = System.Drawing.Color.Lime
        Me.btnProcess.Font = New System.Drawing.Font("Wide Latin", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnProcess.Location = New System.Drawing.Point(339, 89)
        Me.btnProcess.Name = "btnProcess"
        Me.btnProcess.Size = New System.Drawing.Size(476, 144)
        Me.btnProcess.TabIndex = 2
        Me.btnProcess.Text = "PROCESS THE FILE"
        Me.btnProcess.UseVisualStyleBackColor = False
        '
        'txtFilePath
        '
        Me.txtFilePath.Location = New System.Drawing.Point(203, 32)
        Me.txtFilePath.Name = "txtFilePath"
        Me.txtFilePath.Size = New System.Drawing.Size(753, 20)
        Me.txtFilePath.TabIndex = 1
        Me.txtFilePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnSelectFile
        '
        Me.btnSelectFile.Location = New System.Drawing.Point(17, 21)
        Me.btnSelectFile.Name = "btnSelectFile"
        Me.btnSelectFile.Size = New System.Drawing.Size(180, 40)
        Me.btnSelectFile.TabIndex = 0
        Me.btnSelectFile.Text = "&Select File"
        Me.btnSelectFile.UseVisualStyleBackColor = True
        '
        'View
        '
        Me.View.Controls.Add(Me.btnExit)
        Me.View.Controls.Add(Me.btnCountToFile)
        Me.View.Controls.Add(Me.btnMakeLower)
        Me.View.Controls.Add(Me.btnRemPunct)
        Me.View.Controls.Add(Me.txtDisplayText)
        Me.View.Controls.Add(Me.lblFileText)
        Me.View.Location = New System.Drawing.Point(4, 22)
        Me.View.Name = "View"
        Me.View.Padding = New System.Windows.Forms.Padding(3)
        Me.View.Size = New System.Drawing.Size(975, 678)
        Me.View.TabIndex = 1
        Me.View.Text = "View"
        Me.View.UseVisualStyleBackColor = True
        '
        'btnMakeLower
        '
        Me.btnMakeLower.Location = New System.Drawing.Point(294, 415)
        Me.btnMakeLower.Name = "btnMakeLower"
        Me.btnMakeLower.Size = New System.Drawing.Size(180, 40)
        Me.btnMakeLower.TabIndex = 3
        Me.btnMakeLower.Text = "Convert to Lower"
        Me.btnMakeLower.UseVisualStyleBackColor = True
        '
        'btnRemPunct
        '
        Me.btnRemPunct.Location = New System.Drawing.Point(108, 416)
        Me.btnRemPunct.Name = "btnRemPunct"
        Me.btnRemPunct.Size = New System.Drawing.Size(180, 40)
        Me.btnRemPunct.TabIndex = 2
        Me.btnRemPunct.Text = "Remove Punctuation"
        Me.btnRemPunct.UseVisualStyleBackColor = True
        '
        'txtDisplayText
        '
        Me.txtDisplayText.Location = New System.Drawing.Point(3, 23)
        Me.txtDisplayText.Multiline = True
        Me.txtDisplayText.Name = "txtDisplayText"
        Me.txtDisplayText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDisplayText.Size = New System.Drawing.Size(963, 387)
        Me.txtDisplayText.TabIndex = 1
        '
        'lblFileText
        '
        Me.lblFileText.AutoSize = True
        Me.lblFileText.Location = New System.Drawing.Point(427, 7)
        Me.lblFileText.Name = "lblFileText"
        Me.lblFileText.Size = New System.Drawing.Size(47, 13)
        Me.lblFileText.TabIndex = 0
        Me.lblFileText.Text = "File Text"
        '
        'btnCountToFile
        '
        Me.btnCountToFile.Location = New System.Drawing.Point(480, 416)
        Me.btnCountToFile.Name = "btnCountToFile"
        Me.btnCountToFile.Size = New System.Drawing.Size(180, 40)
        Me.btnCountToFile.TabIndex = 4
        Me.btnCountToFile.Text = "Count To File"
        Me.btnCountToFile.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(666, 416)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(180, 40)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'VB_Ch9_Sup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1008, 729)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "VB_Ch9_Sup"
        Me.Text = "VB_Ch9_Sup"
        Me.TabControl1.ResumeLayout(False)
        Me.Load.ResumeLayout(False)
        Me.Load.PerformLayout()
        Me.View.ResumeLayout(False)
        Me.View.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents Load As TabPage
    Friend WithEvents btnProcess As Button
    Friend WithEvents txtFilePath As TextBox
    Friend WithEvents btnSelectFile As Button
    Friend WithEvents View As TabPage
    Friend WithEvents txtDisplayText As TextBox
    Friend WithEvents lblFileText As Label
    Friend WithEvents btnRemPunct As Button
    Friend WithEvents btnMakeLower As Button
    Friend WithEvents btnCountToFile As Button
    Friend WithEvents btnExit As Button
End Class
