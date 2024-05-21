<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Author
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Author))
        PanelFondo = New Panel()
        Panel1 = New Panel()
        PictureBox5 = New PictureBox()
        btnBuscar = New PictureBox()
        Label2 = New Label()
        CBAuthor = New ComboBox()
        DataGVAuthor = New DataGridView()
        PanelM = New Panel()
        DateAdd = New DateTimePicker()
        PictureBox6 = New PictureBox()
        Label4 = New Label()
        txtID = New TextBox()
        Label3 = New Label()
        txtAID = New TextBox()
        PictureBox4 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox2 = New PictureBox()
        btnDelete = New Button()
        btnEdit = New Button()
        btnGuardar = New Button()
        labelName = New Label()
        LabelDate = New Label()
        txtName = New TextBox()
        PanelTitleB = New Panel()
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
        PanelFondo.SuspendLayout()
        Panel1.SuspendLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(btnBuscar, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGVAuthor, ComponentModel.ISupportInitialize).BeginInit()
        PanelM.SuspendLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleB.SuspendLayout()
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
        SuspendLayout()
        ' 
        ' PanelFondo
        ' 
        PanelFondo.Controls.Add(Panel1)
        PanelFondo.Controls.Add(PanelTitleB)
        PanelFondo.Dock = DockStyle.Fill
        PanelFondo.Location = New Point(0, 0)
        PanelFondo.Name = "PanelFondo"
        PanelFondo.Size = New Size(1119, 545)
        PanelFondo.TabIndex = 0
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = Color.Cornsilk
        Panel1.Controls.Add(PictureBox5)
        Panel1.Controls.Add(btnBuscar)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(CBAuthor)
        Panel1.Controls.Add(DataGVAuthor)
        Panel1.Controls.Add(PanelM)
        Panel1.Dock = DockStyle.Fill
        Panel1.Location = New Point(0, 40)
        Panel1.Margin = New Padding(3, 4, 3, 4)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(1119, 505)
        Panel1.TabIndex = 3
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(1033, 17)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(53, 56)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 60
        PictureBox5.TabStop = False
        ' 
        ' btnBuscar
        ' 
        btnBuscar.Image = CType(resources.GetObject("btnBuscar.Image"), Image)
        btnBuscar.Location = New Point(865, 20)
        btnBuscar.Name = "btnBuscar"
        btnBuscar.Size = New Size(53, 53)
        btnBuscar.SizeMode = PictureBoxSizeMode.StretchImage
        btnBuscar.TabIndex = 59
        btnBuscar.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(421, 34)
        Label2.Name = "Label2"
        Label2.Size = New Size(69, 24)
        Label2.TabIndex = 33
        Label2.Text = "Autor:"
        ' 
        ' CBAuthor
        ' 
        CBAuthor.Font = New Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        CBAuthor.FormattingEnabled = True
        CBAuthor.Location = New Point(496, 31)
        CBAuthor.Name = "CBAuthor"
        CBAuthor.Size = New Size(335, 31)
        CBAuthor.TabIndex = 32
        ' 
        ' DataGVAuthor
        ' 
        DataGVAuthor.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGVAuthor.BackgroundColor = Color.Cornsilk
        DataGVAuthor.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGVAuthor.Location = New Point(421, 95)
        DataGVAuthor.Name = "DataGVAuthor"
        DataGVAuthor.RowHeadersWidth = 51
        DataGVAuthor.Size = New Size(672, 377)
        DataGVAuthor.TabIndex = 31
        ' 
        ' PanelM
        ' 
        PanelM.BackColor = Color.Tan
        PanelM.Controls.Add(DateAdd)
        PanelM.Controls.Add(PictureBox6)
        PanelM.Controls.Add(Label4)
        PanelM.Controls.Add(txtID)
        PanelM.Controls.Add(Label3)
        PanelM.Controls.Add(txtAID)
        PanelM.Controls.Add(PictureBox4)
        PanelM.Controls.Add(PictureBox3)
        PanelM.Controls.Add(PictureBox2)
        PanelM.Controls.Add(btnDelete)
        PanelM.Controls.Add(btnEdit)
        PanelM.Controls.Add(btnGuardar)
        PanelM.Controls.Add(labelName)
        PanelM.Controls.Add(LabelDate)
        PanelM.Controls.Add(txtName)
        PanelM.Dock = DockStyle.Left
        PanelM.Location = New Point(0, 0)
        PanelM.Name = "PanelM"
        PanelM.Size = New Size(398, 505)
        PanelM.TabIndex = 30
        ' 
        ' DateAdd
        ' 
        DateAdd.Location = New Point(133, 172)
        DateAdd.Name = "DateAdd"
        DateAdd.Size = New Size(253, 27)
        DateAdd.TabIndex = 68
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(169, 431)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(53, 53)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 67
        PictureBox6.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(10, 78)
        Label4.Name = "Label4"
        Label4.Size = New Size(34, 24)
        Label4.TabIndex = 65
        Label4.Text = "Id:"
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Font = New Font("Arial", 12F)
        txtID.Location = New Point(133, 75)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(253, 30)
        txtID.TabIndex = 66
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(10, 33)
        Label3.Name = "Label3"
        Label3.Size = New Size(100, 24)
        Label3.TabIndex = 63
        Label3.Text = "AuthorID:"
        ' 
        ' txtAID
        ' 
        txtAID.Enabled = False
        txtAID.Font = New Font("Arial", 12F)
        txtAID.Location = New Point(133, 30)
        txtAID.Name = "txtAID"
        txtAID.ReadOnly = True
        txtAID.Size = New Size(253, 30)
        txtAID.TabIndex = 64
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(3, 376)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 53)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 62
        PictureBox4.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(3, 311)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(53, 53)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 61
        PictureBox3.TabStop = False
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(3, 246)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 53)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 60
        PictureBox2.TabStop = False
        ' 
        ' btnDelete
        ' 
        btnDelete.FlatAppearance.BorderSize = 0
        btnDelete.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        btnDelete.FlatStyle = FlatStyle.Flat
        btnDelete.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnDelete.ForeColor = SystemColors.ButtonHighlight
        btnDelete.Location = New Point(0, 376)
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
        btnEdit.Location = New Point(0, 311)
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
        btnGuardar.Location = New Point(0, 246)
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
        labelName.Location = New Point(10, 127)
        labelName.Name = "labelName"
        labelName.Size = New Size(91, 24)
        labelName.TabIndex = 23
        labelName.Text = "Nombre:"
        ' 
        ' LabelDate
        ' 
        LabelDate.AutoSize = True
        LabelDate.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        LabelDate.Location = New Point(10, 172)
        LabelDate.Name = "LabelDate"
        LabelDate.Size = New Size(74, 24)
        LabelDate.TabIndex = 25
        LabelDate.Text = "Fecha:"
        ' 
        ' txtName
        ' 
        txtName.Font = New Font("Arial", 12F)
        txtName.Location = New Point(133, 124)
        txtName.Name = "txtName"
        txtName.Size = New Size(253, 30)
        txtName.TabIndex = 26
        ' 
        ' PanelTitleB
        ' 
        PanelTitleB.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
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
        PanelTitleB.Size = New Size(1119, 40)
        PanelTitleB.TabIndex = 2
        ' 
        ' PicBoxMin
        ' 
        PicBoxMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBoxMin.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PicBoxMin.Image = CType(resources.GetObject("PicBoxMin.Image"), Image)
        PicBoxMin.Location = New Point(1033, 5)
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
        PicBoxMinimize.Location = New Point(989, 5)
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
        Label1.Size = New Size(218, 34)
        Label1.TabIndex = 9
        Label1.Text = "Agregar Autor"
        ' 
        ' picBoxClose
        ' 
        picBoxClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        picBoxClose.Image = CType(resources.GetObject("picBoxClose.Image"), Image)
        picBoxClose.Location = New Point(1077, 5)
        picBoxClose.Name = "picBoxClose"
        picBoxClose.Size = New Size(27, 27)
        picBoxClose.SizeMode = PictureBoxSizeMode.StretchImage
        picBoxClose.TabIndex = 9
        picBoxClose.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(30, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PicBoxMaximize
        ' 
        PicBoxMaximize.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBoxMaximize.Image = CType(resources.GetObject("PicBoxMaximize.Image"), Image)
        PicBoxMaximize.Location = New Point(1033, 5)
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
        PBMinimizar.Location = New Point(1925, 5)
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
        PBClose.Location = New Point(2013, 5)
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
        PBMax.Location = New Point(1969, 5)
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
        PicBR.Location = New Point(2783, 7)
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
        picBMinimize.Location = New Point(2739, 7)
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
        PicBClose.Location = New Point(2827, 7)
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
        PicBMaximize.Location = New Point(2783, 7)
        PicBMaximize.Name = "PicBMaximize"
        PicBMaximize.Size = New Size(27, 27)
        PicBMaximize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBMaximize.TabIndex = 1
        PicBMaximize.TabStop = False
        ' 
        ' Author
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1119, 545)
        Controls.Add(PanelFondo)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(680, 500)
        Name = "Author"
        Text = "Author"
        PanelFondo.ResumeLayout(False)
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(btnBuscar, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGVAuthor, ComponentModel.ISupportInitialize).EndInit()
        PanelM.ResumeLayout(False)
        PanelM.PerformLayout()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleB.ResumeLayout(False)
        PanelTitleB.PerformLayout()
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
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelFondo As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents labelName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents LabelDate As Label
    Friend WithEvents PanelM As Panel
    Friend WithEvents DataGVAuthor As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnEdit As Button
    Friend WithEvents btnGuardar As Button
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
    Friend WithEvents Label2 As Label
    Friend WithEvents CBAuthor As ComboBox
    Friend WithEvents btnBuscar As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtAID As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents DateAdd As DateTimePicker
End Class
