<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AddUser))
        PanelTitleB = New Panel()
        PictureBox2 = New PictureBox()
        PicBoxMin = New PictureBox()
        PicBoxMinimize = New PictureBox()
        Label1 = New Label()
        picBoxClose = New PictureBox()
        PictureBox1 = New PictureBox()
        PicBoxMaximize = New PictureBox()
        PBMinimizar = New PictureBox()
        PBClose = New PictureBox()
        PBMax = New PictureBox()
        PicBR = New PictureBox()
        picBMinimize = New PictureBox()
        PicBClose = New PictureBox()
        PicBMaximize = New PictureBox()
        PanelMenu = New Panel()
        Label3 = New Label()
        txtID = New TextBox()
        txtStatus = New TextBox()
        Label2 = New Label()
        txtPassword = New TextBox()
        btnDelete = New Button()
        btnEdit = New Button()
        btnGuardar = New Button()
        labelName = New Label()
        LabelPassword = New Label()
        txtName = New TextBox()
        txtUser = New TextBox()
        LabelUser = New Label()
        PanelFondo = New Panel()
        PictureBox3 = New PictureBox()
        DataGVUsers = New DataGridView()
        PictureBox4 = New PictureBox()
        PanelTitleB.SuspendLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBoxClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBoxMaximize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBMax, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBR, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        PanelFondo.SuspendLayout()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGVUsers, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelTitleB
        ' 
        PanelTitleB.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PanelTitleB.Controls.Add(PictureBox2)
        PanelTitleB.Controls.Add(PicBoxMin)
        PanelTitleB.Controls.Add(PicBoxMinimize)
        PanelTitleB.Controls.Add(Label1)
        PanelTitleB.Controls.Add(picBoxClose)
        PanelTitleB.Controls.Add(PictureBox1)
        PanelTitleB.Controls.Add(PicBoxMaximize)
        PanelTitleB.Controls.Add(PBMinimizar)
        PanelTitleB.Controls.Add(PBClose)
        PanelTitleB.Controls.Add(PBMax)
        PanelTitleB.Controls.Add(PicBR)
        PanelTitleB.Controls.Add(picBMinimize)
        PanelTitleB.Controls.Add(PicBClose)
        PanelTitleB.Controls.Add(PicBMaximize)
        PanelTitleB.Dock = DockStyle.Top
        PanelTitleB.Location = New Point(0, 0)
        PanelTitleB.Name = "PanelTitleB"
        PanelTitleB.Size = New Size(1083, 40)
        PanelTitleB.TabIndex = 3
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(1044, 6)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(27, 27)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 11
        PictureBox2.TabStop = False
        ' 
        ' PicBoxMin
        ' 
        PicBoxMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBoxMin.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PicBoxMin.Image = CType(resources.GetObject("PicBoxMin.Image"), Image)
        PicBoxMin.Location = New Point(1916, 5)
        PicBoxMin.Name = "PicBoxMin"
        PicBoxMin.Size = New Size(27, 27)
        PicBoxMin.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxMin.TabIndex = 9
        PicBoxMin.TabStop = False
        PicBoxMin.Visible = False
        ' 
        ' PicBoxMinimize
        ' 
        PicBoxMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBoxMinimize.Image = CType(resources.GetObject("PicBoxMinimize.Image"), Image)
        PicBoxMinimize.Location = New Point(1872, 5)
        PicBoxMinimize.Name = "PicBoxMinimize"
        PicBoxMinimize.Size = New Size(27, 27)
        PicBoxMinimize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxMinimize.TabIndex = 10
        PicBoxMinimize.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(95, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(251, 34)
        Label1.TabIndex = 9
        Label1.Text = "Agregar Usuario"
        ' 
        ' picBoxClose
        ' 
        picBoxClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picBoxClose.Image = CType(resources.GetObject("picBoxClose.Image"), Image)
        picBoxClose.Location = New Point(1960, 5)
        picBoxClose.Name = "picBoxClose"
        picBoxClose.Size = New Size(27, 27)
        picBoxClose.SizeMode = PictureBoxSizeMode.StretchImage
        picBoxClose.TabIndex = 9
        picBoxClose.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(24, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(38, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PicBoxMaximize
        ' 
        PicBoxMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBoxMaximize.Image = CType(resources.GetObject("PicBoxMaximize.Image"), Image)
        PicBoxMaximize.Location = New Point(1916, 5)
        PicBoxMaximize.Name = "PicBoxMaximize"
        PicBoxMaximize.Size = New Size(27, 27)
        PicBoxMaximize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBoxMaximize.TabIndex = 8
        PicBoxMaximize.TabStop = False
        ' 
        ' PBMinimizar
        ' 
        PBMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMinimizar.Image = CType(resources.GetObject("PBMinimizar.Image"), Image)
        PBMinimizar.Location = New Point(2808, 5)
        PBMinimizar.Name = "PBMinimizar"
        PBMinimizar.Size = New Size(27, 27)
        PBMinimizar.SizeMode = PictureBoxSizeMode.StretchImage
        PBMinimizar.TabIndex = 7
        PBMinimizar.TabStop = False
        ' 
        ' PBClose
        ' 
        PBClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBClose.Image = CType(resources.GetObject("PBClose.Image"), Image)
        PBClose.Location = New Point(2896, 5)
        PBClose.Name = "PBClose"
        PBClose.Size = New Size(27, 27)
        PBClose.SizeMode = PictureBoxSizeMode.StretchImage
        PBClose.TabIndex = 6
        PBClose.TabStop = False
        ' 
        ' PBMax
        ' 
        PBMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMax.Image = CType(resources.GetObject("PBMax.Image"), Image)
        PBMax.Location = New Point(2852, 5)
        PBMax.Name = "PBMax"
        PBMax.Size = New Size(27, 27)
        PBMax.SizeMode = PictureBoxSizeMode.StretchImage
        PBMax.TabIndex = 5
        PBMax.TabStop = False
        ' 
        ' PicBR
        ' 
        PicBR.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBR.Image = CType(resources.GetObject("PicBR.Image"), Image)
        PicBR.Location = New Point(3666, 7)
        PicBR.Name = "PicBR"
        PicBR.Size = New Size(27, 27)
        PicBR.SizeMode = PictureBoxSizeMode.StretchImage
        PicBR.TabIndex = 4
        PicBR.TabStop = False
        PicBR.Visible = False
        ' 
        ' picBMinimize
        ' 
        picBMinimize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picBMinimize.Image = CType(resources.GetObject("picBMinimize.Image"), Image)
        picBMinimize.Location = New Point(3622, 7)
        picBMinimize.Name = "picBMinimize"
        picBMinimize.Size = New Size(27, 27)
        picBMinimize.SizeMode = PictureBoxSizeMode.StretchImage
        picBMinimize.TabIndex = 3
        picBMinimize.TabStop = False
        ' 
        ' PicBClose
        ' 
        PicBClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBClose.Image = CType(resources.GetObject("PicBClose.Image"), Image)
        PicBClose.Location = New Point(3710, 7)
        PicBClose.Name = "PicBClose"
        PicBClose.Size = New Size(27, 27)
        PicBClose.SizeMode = PictureBoxSizeMode.StretchImage
        PicBClose.TabIndex = 2
        PicBClose.TabStop = False
        ' 
        ' PicBMaximize
        ' 
        PicBMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBMaximize.Image = CType(resources.GetObject("PicBMaximize.Image"), Image)
        PicBMaximize.Location = New Point(3666, 7)
        PicBMaximize.Name = "PicBMaximize"
        PicBMaximize.Size = New Size(27, 27)
        PicBMaximize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBMaximize.TabIndex = 1
        PicBMaximize.TabStop = False
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.Tan
        PanelMenu.Controls.Add(PictureBox4)
        PanelMenu.Controls.Add(Label3)
        PanelMenu.Controls.Add(txtID)
        PanelMenu.Controls.Add(txtStatus)
        PanelMenu.Controls.Add(Label2)
        PanelMenu.Controls.Add(txtPassword)
        PanelMenu.Controls.Add(btnDelete)
        PanelMenu.Controls.Add(btnEdit)
        PanelMenu.Controls.Add(btnGuardar)
        PanelMenu.Controls.Add(labelName)
        PanelMenu.Controls.Add(LabelPassword)
        PanelMenu.Controls.Add(txtName)
        PanelMenu.Controls.Add(txtUser)
        PanelMenu.Controls.Add(LabelUser)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 40)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(398, 503)
        PanelMenu.TabIndex = 31
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(16, 24)
        Label3.Name = "Label3"
        Label3.Size = New Size(36, 24)
        Label3.TabIndex = 36
        Label3.Text = "ID:"
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Font = New Font("Arial", 12F)
        txtID.Location = New Point(139, 21)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(253, 30)
        txtID.TabIndex = 37
        ' 
        ' txtStatus
        ' 
        txtStatus.Enabled = False
        txtStatus.Font = New Font("Arial", 12F)
        txtStatus.Location = New Point(139, 185)
        txtStatus.Name = "txtStatus"
        txtStatus.PasswordChar = "*"c
        txtStatus.ReadOnly = True
        txtStatus.Size = New Size(253, 30)
        txtStatus.TabIndex = 35
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(16, 185)
        Label2.Name = "Label2"
        Label2.Size = New Size(89, 24)
        Label2.TabIndex = 34
        Label2.Text = "Estatus:"
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Arial", 12F)
        txtPassword.Location = New Point(139, 149)
        txtPassword.Name = "txtPassword"
        txtPassword.PasswordChar = "*"c
        txtPassword.Size = New Size(253, 30)
        txtPassword.TabIndex = 33
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(0, 367)
        btnDelete.Name = "btnDelete"
        btnDelete.Size = New Size(398, 49)
        btnDelete.TabIndex = 32
        btnDelete.Text = "Eliminar"
        btnDelete.UseVisualStyleBackColor = True
        ' 
        ' btnEdit
        ' 
        btnEdit.FlatAppearance.BorderSize = 0
        btnEdit.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        btnEdit.FlatStyle = FlatStyle.Flat
        btnEdit.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnEdit.ForeColor = SystemColors.ButtonHighlight
        btnEdit.Location = New Point(0, 302)
        btnEdit.Name = "btnEdit"
        btnEdit.Size = New Size(398, 49)
        btnEdit.TabIndex = 31
        btnEdit.Text = "Editar"
        btnEdit.UseVisualStyleBackColor = True
        ' 
        ' btnGuardar
        ' 
        btnGuardar.FlatAppearance.BorderSize = 0
        btnGuardar.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        btnGuardar.FlatStyle = FlatStyle.Flat
        btnGuardar.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnGuardar.ForeColor = SystemColors.ButtonHighlight
        btnGuardar.Location = New Point(0, 238)
        btnGuardar.Name = "btnGuardar"
        btnGuardar.Size = New Size(398, 49)
        btnGuardar.TabIndex = 30
        btnGuardar.Text = "Guardar"
        btnGuardar.UseVisualStyleBackColor = True
        ' 
        ' labelName
        ' 
        labelName.AutoSize = True
        labelName.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        labelName.Location = New Point(16, 80)
        labelName.Name = "labelName"
        labelName.Size = New Size(91, 24)
        labelName.TabIndex = 23
        labelName.Text = "Nombre:"
        ' 
        ' LabelPassword
        ' 
        LabelPassword.AutoSize = True
        LabelPassword.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelPassword.Location = New Point(16, 149)
        LabelPassword.Name = "LabelPassword"
        LabelPassword.Size = New Size(110, 24)
        LabelPassword.TabIndex = 25
        LabelPassword.Text = "Password:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial", 12F)
        txtName.Location = New Point(139, 77)
        txtName.Name = "txtName"
        txtName.Size = New Size(253, 30)
        txtName.TabIndex = 26
        ' 
        ' txtUser
        ' 
        txtUser.Font = New Font("Arial", 12F)
        txtUser.Location = New Point(139, 113)
        txtUser.Name = "txtUser"
        txtUser.Size = New Size(253, 30)
        txtUser.TabIndex = 28
        ' 
        ' LabelUser
        ' 
        LabelUser.AutoSize = True
        LabelUser.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelUser.Location = New Point(16, 116)
        LabelUser.Name = "LabelUser"
        LabelUser.Size = New Size(112, 24)
        LabelUser.TabIndex = 24
        LabelUser.Text = "Username:"
        ' 
        ' PanelFondo
        ' 
        PanelFondo.BackColor = Color.Cornsilk
        PanelFondo.Controls.Add(PictureBox3)
        PanelFondo.Controls.Add(DataGVUsers)
        PanelFondo.Dock = DockStyle.Fill
        PanelFondo.Location = New Point(398, 40)
        PanelFondo.Margin = New Padding(3, 4, 3, 4)
        PanelFondo.Name = "PanelFondo"
        PanelFondo.Size = New Size(685, 503)
        PanelFondo.TabIndex = 32
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(609, 21)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(53, 56)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 11
        PictureBox3.TabStop = False
        ' 
        ' DataGVUsers
        ' 
        DataGVUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGVUsers.BackgroundColor = Color.Cornsilk
        DataGVUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGVUsers.Location = New Point(23, 85)
        DataGVUsers.Name = "DataGVUsers"
        DataGVUsers.RowHeadersWidth = 51
        DataGVUsers.Size = New Size(639, 394)
        DataGVUsers.TabIndex = 0
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(171, 423)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 56)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 38
        PictureBox4.TabStop = False
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1083, 543)
        Controls.Add(PanelFondo)
        Controls.Add(PanelMenu)
        Controls.Add(PanelTitleB)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(680, 500)
        Name = "AddUser"
        Text = "AddUser"
        PanelTitleB.ResumeLayout(False)
        PanelTitleB.PerformLayout()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxMin, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(picBoxClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBoxMaximize, ComponentModel.ISupportInitialize).EndInit()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PBMax, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBR, ComponentModel.ISupportInitialize).EndInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        PanelFondo.ResumeLayout(False)
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGVUsers, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelTitleB As Panel
    Friend WithEvents PicBoxMin As PictureBox
    Friend WithEvents PicBoxMinimize As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents picBoxClose As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PicBoxMaximize As PictureBox
    Friend WithEvents PBMinimizar As PictureBox
    Friend WithEvents PBClose As PictureBox
    Friend WithEvents PBMax As PictureBox
    Friend WithEvents PicBR As PictureBox
    Friend WithEvents picBMinimize As PictureBox
    Friend WithEvents PicBClose As PictureBox
    Friend WithEvents PicBMaximize As PictureBox
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnGuardar As Button
    Friend WithEvents labelName As Label
    Friend WithEvents LabelPassword As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtUser As TextBox
    Friend WithEvents LabelUser As Label
    Friend WithEvents PanelFondo As Panel
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents DataGVUsers As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtStatus As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
End Class
