<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        PanelFondo = New Panel()
        PanelC = New Panel()
        btnLogin = New Button()
        Label4 = New Label()
        txtPassword = New TextBox()
        txtUser = New TextBox()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        PanelTitle = New Panel()
        PanelFondo.SuspendLayout()
        PanelC.SuspendLayout()
        SuspendLayout()
        ' 
        ' PanelFondo
        ' 
        PanelFondo.Controls.Add(PanelC)
        PanelFondo.Controls.Add(PanelTitle)
        PanelFondo.Dock = DockStyle.Fill
        PanelFondo.Location = New Point(0, 0)
        PanelFondo.Name = "PanelFondo"
        PanelFondo.Size = New Size(481, 671)
        PanelFondo.TabIndex = 0
        ' 
        ' PanelC
        ' 
        PanelC.BackColor = Color.Cornsilk
        PanelC.Controls.Add(btnLogin)
        PanelC.Controls.Add(Label4)
        PanelC.Controls.Add(txtPassword)
        PanelC.Controls.Add(txtUser)
        PanelC.Controls.Add(Label3)
        PanelC.Controls.Add(Label2)
        PanelC.Controls.Add(Label1)
        PanelC.Dock = DockStyle.Fill
        PanelC.ForeColor = SystemColors.ControlLightLight
        PanelC.Location = New Point(0, 72)
        PanelC.Name = "PanelC"
        PanelC.Size = New Size(481, 599)
        PanelC.TabIndex = 1
        ' 
        ' btnLogin
        ' 
        btnLogin.FlatAppearance.BorderSize = 0
        btnLogin.FlatStyle = FlatStyle.Flat
        btnLogin.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnLogin.ForeColor = SystemColors.ActiveCaptionText
        btnLogin.Location = New Point(0, 419)
        btnLogin.Name = "btnLogin"
        btnLogin.Size = New Size(481, 58)
        btnLogin.TabIndex = 6
        btnLogin.Text = "Ingresar"
        btnLogin.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial Narrow", 12F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ActiveCaptionText
        Label4.Location = New Point(177, 509)
        Label4.Name = "Label4"
        Label4.Size = New Size(128, 24)
        Label4.TabIndex = 5
        Label4.Text = "Agregar Usuario"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPassword.Location = New Point(43, 331)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(394, 34)
        txtPassword.TabIndex = 4
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Arial", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUser.Location = New Point(43, 201)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(394, 34)
        txtUser.TabIndex = 3
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(43, 278)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 27)
        Label3.TabIndex = 2
        Label3.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 13.8F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(43, 151)
        Label2.Name = "Label2"
        Label2.Size = New Size(100, 27)
        Label2.TabIndex = 1
        Label2.Text = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(153, 52)
        Label1.Name = "Label1"
        Label1.Size = New Size(175, 34)
        Label1.TabIndex = 0
        Label1.Text = "Bienvenido"
        ' 
        ' PanelTitle
        ' 
        PanelTitle.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PanelTitle.Dock = DockStyle.Top
        PanelTitle.Location = New Point(0, 0)
        PanelTitle.Name = "PanelTitle"
        PanelTitle.Size = New Size(481, 72)
        PanelTitle.TabIndex = 0
        ' 
        ' Login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(481, 671)
        Controls.Add(PanelFondo)
        FormBorderStyle = FormBorderStyle.None
        Name = "Login"
        Text = "Login"
        PanelFondo.ResumeLayout(False)
        PanelC.ResumeLayout(False)
        PanelC.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents PanelC As Panel
    Friend WithEvents txtUser As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
End Class
