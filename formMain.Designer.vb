<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formMain
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
        Me.btnGenerate = New System.Windows.Forms.Button()
        Me.groupSettings = New System.Windows.Forms.GroupBox()
        Me.btnFont2 = New System.Windows.Forms.Button()
        Me.btnFont1 = New System.Windows.Forms.Button()
        Me.lblBackgroundColor = New System.Windows.Forms.Label()
        Me.checkTransparent = New System.Windows.Forms.CheckBox()
        Me.btnBackground = New System.Windows.Forms.Button()
        Me.btnLineColor = New System.Windows.Forms.Button()
        Me.btnDotColor = New System.Windows.Forms.Button()
        Me.numLines = New System.Windows.Forms.NumericUpDown()
        Me.numDots = New System.Windows.Forms.NumericUpDown()
        Me.lblLineColor = New System.Windows.Forms.Label()
        Me.lblLineCount = New System.Windows.Forms.Label()
        Me.lblDotColor = New System.Windows.Forms.Label()
        Me.lblDotCount = New System.Windows.Forms.Label()
        Me.btnTest = New System.Windows.Forms.Button()
        Me.txtCaptchaInput = New System.Windows.Forms.TextBox()
        Me.Captcha1 = New GDI_Captcha.Captcha()
        Me.checkCase = New System.Windows.Forms.CheckBox()
        Me.groupSettings.SuspendLayout()
        CType(Me.numLines, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numDots, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnGenerate
        '
        Me.btnGenerate.Location = New System.Drawing.Point(177, 147)
        Me.btnGenerate.Name = "btnGenerate"
        Me.btnGenerate.Size = New System.Drawing.Size(75, 23)
        Me.btnGenerate.TabIndex = 0
        Me.btnGenerate.Text = "Generate"
        Me.btnGenerate.UseVisualStyleBackColor = True
        '
        'groupSettings
        '
        Me.groupSettings.Controls.Add(Me.btnFont2)
        Me.groupSettings.Controls.Add(Me.btnFont1)
        Me.groupSettings.Controls.Add(Me.lblBackgroundColor)
        Me.groupSettings.Controls.Add(Me.checkTransparent)
        Me.groupSettings.Controls.Add(Me.btnBackground)
        Me.groupSettings.Controls.Add(Me.btnLineColor)
        Me.groupSettings.Controls.Add(Me.btnDotColor)
        Me.groupSettings.Controls.Add(Me.numLines)
        Me.groupSettings.Controls.Add(Me.numDots)
        Me.groupSettings.Controls.Add(Me.lblLineColor)
        Me.groupSettings.Controls.Add(Me.lblLineCount)
        Me.groupSettings.Controls.Add(Me.lblDotColor)
        Me.groupSettings.Controls.Add(Me.lblDotCount)
        Me.groupSettings.Location = New System.Drawing.Point(12, 12)
        Me.groupSettings.Name = "groupSettings"
        Me.groupSettings.Size = New System.Drawing.Size(240, 129)
        Me.groupSettings.TabIndex = 2
        Me.groupSettings.TabStop = False
        Me.groupSettings.Text = "Settings"
        '
        'btnFont2
        '
        Me.btnFont2.Location = New System.Drawing.Point(122, 96)
        Me.btnFont2.Name = "btnFont2"
        Me.btnFont2.Size = New System.Drawing.Size(75, 23)
        Me.btnFont2.TabIndex = 4
        Me.btnFont2.Text = "Font #2"
        Me.btnFont2.UseVisualStyleBackColor = True
        '
        'btnFont1
        '
        Me.btnFont1.Location = New System.Drawing.Point(41, 96)
        Me.btnFont1.Name = "btnFont1"
        Me.btnFont1.Size = New System.Drawing.Size(75, 23)
        Me.btnFont1.TabIndex = 3
        Me.btnFont1.Text = "Font #1"
        Me.btnFont1.UseVisualStyleBackColor = True
        '
        'lblBackgroundColor
        '
        Me.lblBackgroundColor.AutoSize = True
        Me.lblBackgroundColor.Location = New System.Drawing.Point(6, 72)
        Me.lblBackgroundColor.Name = "lblBackgroundColor"
        Me.lblBackgroundColor.Size = New System.Drawing.Size(61, 13)
        Me.lblBackgroundColor.TabIndex = 3
        Me.lblBackgroundColor.Text = "BG Color:"
        '
        'checkTransparent
        '
        Me.checkTransparent.AutoSize = True
        Me.checkTransparent.Location = New System.Drawing.Point(77, 72)
        Me.checkTransparent.Name = "checkTransparent"
        Me.checkTransparent.Size = New System.Drawing.Size(92, 17)
        Me.checkTransparent.TabIndex = 4
        Me.checkTransparent.Text = "Transparent"
        Me.checkTransparent.UseVisualStyleBackColor = True
        '
        'btnBackground
        '
        Me.btnBackground.BackColor = System.Drawing.Color.Black
        Me.btnBackground.Location = New System.Drawing.Point(177, 68)
        Me.btnBackground.Name = "btnBackground"
        Me.btnBackground.Size = New System.Drawing.Size(35, 21)
        Me.btnBackground.TabIndex = 8
        Me.btnBackground.Tag = ""
        Me.btnBackground.UseVisualStyleBackColor = False
        '
        'btnLineColor
        '
        Me.btnLineColor.BackColor = System.Drawing.Color.Green
        Me.btnLineColor.Location = New System.Drawing.Point(195, 43)
        Me.btnLineColor.Name = "btnLineColor"
        Me.btnLineColor.Size = New System.Drawing.Size(35, 21)
        Me.btnLineColor.TabIndex = 7
        Me.btnLineColor.Tag = ""
        Me.btnLineColor.UseVisualStyleBackColor = False
        '
        'btnDotColor
        '
        Me.btnDotColor.BackColor = System.Drawing.Color.Blue
        Me.btnDotColor.Location = New System.Drawing.Point(79, 43)
        Me.btnDotColor.Name = "btnDotColor"
        Me.btnDotColor.Size = New System.Drawing.Size(35, 21)
        Me.btnDotColor.TabIndex = 6
        Me.btnDotColor.Tag = ""
        Me.btnDotColor.UseVisualStyleBackColor = False
        '
        'numLines
        '
        Me.numLines.Location = New System.Drawing.Point(195, 18)
        Me.numLines.Name = "numLines"
        Me.numLines.Size = New System.Drawing.Size(36, 20)
        Me.numLines.TabIndex = 5
        Me.numLines.Value = New Decimal(New Integer() {5, 0, 0, 0})
        '
        'numDots
        '
        Me.numDots.Location = New System.Drawing.Point(79, 17)
        Me.numDots.Name = "numDots"
        Me.numDots.Size = New System.Drawing.Size(35, 20)
        Me.numDots.TabIndex = 4
        Me.numDots.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'lblLineColor
        '
        Me.lblLineColor.AutoSize = True
        Me.lblLineColor.Location = New System.Drawing.Point(120, 47)
        Me.lblLineColor.Name = "lblLineColor"
        Me.lblLineColor.Size = New System.Drawing.Size(73, 13)
        Me.lblLineColor.TabIndex = 3
        Me.lblLineColor.Text = "Line Color:"
        '
        'lblLineCount
        '
        Me.lblLineCount.AutoSize = True
        Me.lblLineCount.Location = New System.Drawing.Point(120, 20)
        Me.lblLineCount.Name = "lblLineCount"
        Me.lblLineCount.Size = New System.Drawing.Size(73, 13)
        Me.lblLineCount.TabIndex = 2
        Me.lblLineCount.Text = "Line Count:"
        '
        'lblDotColor
        '
        Me.lblDotColor.AutoSize = True
        Me.lblDotColor.Location = New System.Drawing.Point(6, 47)
        Me.lblDotColor.Name = "lblDotColor"
        Me.lblDotColor.Size = New System.Drawing.Size(67, 13)
        Me.lblDotColor.TabIndex = 1
        Me.lblDotColor.Text = "Dot Color:"
        '
        'lblDotCount
        '
        Me.lblDotCount.AutoSize = True
        Me.lblDotCount.Location = New System.Drawing.Point(6, 20)
        Me.lblDotCount.Name = "lblDotCount"
        Me.lblDotCount.Size = New System.Drawing.Size(67, 13)
        Me.lblDotCount.TabIndex = 0
        Me.lblDotCount.Text = "Dot Count:"
        '
        'btnTest
        '
        Me.btnTest.Location = New System.Drawing.Point(212, 273)
        Me.btnTest.Name = "btnTest"
        Me.btnTest.Size = New System.Drawing.Size(41, 23)
        Me.btnTest.TabIndex = 3
        Me.btnTest.Text = "Test"
        Me.btnTest.UseVisualStyleBackColor = True
        '
        'txtCaptchaInput
        '
        Me.txtCaptchaInput.Location = New System.Drawing.Point(12, 274)
        Me.txtCaptchaInput.Name = "txtCaptchaInput"
        Me.txtCaptchaInput.Size = New System.Drawing.Size(197, 20)
        Me.txtCaptchaInput.TabIndex = 4
        '
        'Captcha1
        '
        Me.Captcha1.Location = New System.Drawing.Point(12, 176)
        Me.Captcha1.Name = "Captcha1"
        Me.Captcha1.Size = New System.Drawing.Size(240, 90)
        Me.Captcha1.TabIndex = 1
        Me.Captcha1.Text = "Captcha1"
        '
        'checkCase
        '
        Me.checkCase.AutoSize = True
        Me.checkCase.Location = New System.Drawing.Point(61, 151)
        Me.checkCase.Name = "checkCase"
        Me.checkCase.Size = New System.Drawing.Size(110, 17)
        Me.checkCase.TabIndex = 5
        Me.checkCase.Text = "case sensitive"
        Me.checkCase.UseVisualStyleBackColor = True
        '
        'formMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(261, 304)
        Me.Controls.Add(Me.checkCase)
        Me.Controls.Add(Me.txtCaptchaInput)
        Me.Controls.Add(Me.btnTest)
        Me.Controls.Add(Me.groupSettings)
        Me.Controls.Add(Me.Captcha1)
        Me.Controls.Add(Me.btnGenerate)
        Me.Font = New System.Drawing.Font("Consolas", 8.0!)
        Me.Name = "formMain"
        Me.Text = "GDI Captcha"
        Me.groupSettings.ResumeLayout(False)
        Me.groupSettings.PerformLayout()
        CType(Me.numLines, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numDots, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGenerate As System.Windows.Forms.Button
    Friend WithEvents Captcha1 As GDI_Captcha.Captcha
    Friend WithEvents groupSettings As System.Windows.Forms.GroupBox
    Friend WithEvents lblBackgroundColor As System.Windows.Forms.Label
    Friend WithEvents checkTransparent As System.Windows.Forms.CheckBox
    Friend WithEvents btnBackground As System.Windows.Forms.Button
    Friend WithEvents btnLineColor As System.Windows.Forms.Button
    Friend WithEvents btnDotColor As System.Windows.Forms.Button
    Friend WithEvents numLines As System.Windows.Forms.NumericUpDown
    Friend WithEvents numDots As System.Windows.Forms.NumericUpDown
    Friend WithEvents lblLineColor As System.Windows.Forms.Label
    Friend WithEvents lblLineCount As System.Windows.Forms.Label
    Friend WithEvents lblDotColor As System.Windows.Forms.Label
    Friend WithEvents lblDotCount As System.Windows.Forms.Label
    Friend WithEvents btnFont1 As System.Windows.Forms.Button
    Friend WithEvents btnFont2 As System.Windows.Forms.Button
    Friend WithEvents btnTest As System.Windows.Forms.Button
    Friend WithEvents txtCaptchaInput As System.Windows.Forms.TextBox
    Friend WithEvents checkCase As System.Windows.Forms.CheckBox

End Class
