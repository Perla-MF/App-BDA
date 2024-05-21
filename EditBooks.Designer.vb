<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditBooks
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EditBooks))
        Label1 = New Label()
        PBMinimizar = New PictureBox()
        PBClose = New PictureBox()
        PBMax = New PictureBox()
        PanelTitleB = New Panel()
        PBMin = New PictureBox()
        Label2 = New Label()
        PictureBox2 = New PictureBox()
        PictureBox3 = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox5 = New PictureBox()
        PicBR = New PictureBox()
        picBMinimize = New PictureBox()
        PicBClose = New PictureBox()
        PicBMaximize = New PictureBox()
        Panelfondo = New Panel()
        Label23 = New Label()
        CBoxAutor = New ComboBox()
        PictureBox7 = New PictureBox()
        PictureBox1 = New PictureBox()
        DataGVBooks = New DataGridView()
        Label13 = New Label()
        PanelMenu = New Panel()
        picBDelete = New PictureBox()
        Clean = New PictureBox()
        txtID = New TextBox()
        Label22 = New Label()
        Save = New PictureBox()
        txtBoxRT = New TextBox()
        Label14 = New Label()
        Label15 = New Label()
        txtBoxR5 = New TextBox()
        txtBoxRating = New TextBox()
        txtBoxR4 = New TextBox()
        txtBoxIdioma = New TextBox()
        Label16 = New Label()
        txtBoxR3 = New TextBox()
        txtBoxISBN = New TextBox()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label12 = New Label()
        txtBoxR2 = New TextBox()
        Label21 = New Label()
        txtBoxEditorial = New TextBox()
        txtBoxR1 = New TextBox()
        txtBoxAño = New TextBox()
        txtBoxDia = New TextBox()
        txtBoxMes = New TextBox()
        txtBoxPaginas = New TextBox()
        txtBoxAutor = New TextBox()
        txtBoxTitulo = New TextBox()
        Label11 = New Label()
        txtBoxReseñas = New TextBox()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label10 = New Label()
        DateAdd = New DateTimePicker()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBMax, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleB.SuspendLayout()
        CType(PBMin, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBR, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).BeginInit()
        Panelfondo.SuspendLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGVBooks, ComponentModel.ISupportInitialize).BeginInit()
        PanelMenu.SuspendLayout()
        CType(picBDelete, ComponentModel.ISupportInitialize).BeginInit()
        CType(Clean, ComponentModel.ISupportInitialize).BeginInit()
        CType(Save, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(96, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 34)
        Label1.TabIndex = 14
        Label1.Text = "Agregar Libro"
        ' 
        ' PBMinimizar
        ' 
        PBMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMinimizar.Image = CType(resources.GetObject("PBMinimizar.Image"), Image)
        PBMinimizar.Location = New Point(1055, 6)
        PBMinimizar.Name = "PBMinimizar"
        PBMinimizar.Size = New Size(27, 27)
        PBMinimizar.SizeMode = PictureBoxSizeMode.StretchImage
        PBMinimizar.TabIndex = 12
        PBMinimizar.TabStop = False
        ' 
        ' PBClose
        ' 
        PBClose.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBClose.Image = CType(resources.GetObject("PBClose.Image"), Image)
        PBClose.Location = New Point(1143, 6)
        PBClose.Name = "PBClose"
        PBClose.Size = New Size(27, 27)
        PBClose.SizeMode = PictureBoxSizeMode.StretchImage
        PBClose.TabIndex = 11
        PBClose.TabStop = False
        ' 
        ' PBMax
        ' 
        PBMax.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMax.Image = CType(resources.GetObject("PBMax.Image"), Image)
        PBMax.Location = New Point(1099, 6)
        PBMax.Name = "PBMax"
        PBMax.Size = New Size(27, 27)
        PBMax.SizeMode = PictureBoxSizeMode.StretchImage
        PBMax.TabIndex = 10
        PBMax.TabStop = False
        ' 
        ' PanelTitleB
        ' 
        PanelTitleB.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PanelTitleB.Controls.Add(PBMin)
        PanelTitleB.Controls.Add(Label2)
        PanelTitleB.Controls.Add(PictureBox2)
        PanelTitleB.Controls.Add(PBMinimizar)
        PanelTitleB.Controls.Add(PBClose)
        PanelTitleB.Controls.Add(PictureBox3)
        PanelTitleB.Controls.Add(PBMax)
        PanelTitleB.Controls.Add(PictureBox4)
        PanelTitleB.Controls.Add(PictureBox5)
        PanelTitleB.Controls.Add(PicBR)
        PanelTitleB.Controls.Add(picBMinimize)
        PanelTitleB.Controls.Add(PicBClose)
        PanelTitleB.Controls.Add(PicBMaximize)
        PanelTitleB.Dock = DockStyle.Top
        PanelTitleB.Location = New Point(0, 0)
        PanelTitleB.Name = "PanelTitleB"
        PanelTitleB.Size = New Size(1193, 40)
        PanelTitleB.TabIndex = 15
        ' 
        ' PBMin
        ' 
        PBMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMin.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PBMin.Image = CType(resources.GetObject("PBMin.Image"), Image)
        PBMin.Location = New Point(1099, 7)
        PBMin.Name = "PBMin"
        PBMin.Size = New Size(27, 27)
        PBMin.SizeMode = PictureBoxSizeMode.StretchImage
        PBMin.TabIndex = 16
        PBMin.TabStop = False
        PBMin.Visible = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ControlLightLight
        Label2.Location = New Point(95, 3)
        Label2.Name = "Label2"
        Label2.Size = New Size(182, 34)
        Label2.TabIndex = 9
        Label2.Text = "Editar Libro"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(26, 3)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(35, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 8
        PictureBox2.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1999, 5)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(27, 27)
        PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox3.TabIndex = 7
        PictureBox3.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(2087, 5)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(27, 27)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 6
        PictureBox4.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(2043, 5)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(27, 27)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 5
        PictureBox5.TabStop = False
        ' 
        ' PicBR
        ' 
        PicBR.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBR.Image = CType(resources.GetObject("PicBR.Image"), Image)
        PicBR.Location = New Point(2857, 7)
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
        picBMinimize.Location = New Point(2812, 7)
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
        PicBClose.Location = New Point(2902, 7)
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
        PicBMaximize.Location = New Point(2857, 7)
        PicBMaximize.Name = "PicBMaximize"
        PicBMaximize.Size = New Size(27, 27)
        PicBMaximize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBMaximize.TabIndex = 1
        PicBMaximize.TabStop = False
        ' 
        ' Panelfondo
        ' 
        Panelfondo.BackColor = Color.Cornsilk
        Panelfondo.Controls.Add(Label23)
        Panelfondo.Controls.Add(CBoxAutor)
        Panelfondo.Controls.Add(PictureBox7)
        Panelfondo.Controls.Add(PictureBox1)
        Panelfondo.Controls.Add(DataGVBooks)
        Panelfondo.Controls.Add(Label13)
        Panelfondo.Controls.Add(PanelMenu)
        Panelfondo.Dock = DockStyle.Fill
        Panelfondo.Location = New Point(0, 40)
        Panelfondo.Name = "Panelfondo"
        Panelfondo.Size = New Size(1193, 752)
        Panelfondo.TabIndex = 16
        ' 
        ' Label23
        ' 
        Label23.AutoSize = True
        Label23.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label23.Location = New Point(425, 44)
        Label23.Name = "Label23"
        Label23.Size = New Size(62, 24)
        Label23.TabIndex = 62
        Label23.Text = "Autor"
        ' 
        ' CBoxAutor
        ' 
        CBoxAutor.FormattingEnabled = True
        CBoxAutor.Location = New Point(502, 42)
        CBoxAutor.Name = "CBoxAutor"
        CBoxAutor.Size = New Size(242, 28)
        CBoxAutor.TabIndex = 61
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(1099, 27)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(53, 56)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 60
        PictureBox7.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(750, 27)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 53)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 58
        PictureBox1.TabStop = False
        ' 
        ' DataGVBooks
        ' 
        DataGVBooks.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGVBooks.BackgroundColor = Color.Cornsilk
        DataGVBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGVBooks.Location = New Point(422, 109)
        DataGVBooks.Name = "DataGVBooks"
        DataGVBooks.RowHeadersWidth = 51
        DataGVBooks.Size = New Size(748, 613)
        DataGVBooks.TabIndex = 57
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(484, 495)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 24)
        Label13.TabIndex = 56
        ' 
        ' PanelMenu
        ' 
        PanelMenu.BackColor = Color.Tan
        PanelMenu.Controls.Add(DateAdd)
        PanelMenu.Controls.Add(picBDelete)
        PanelMenu.Controls.Add(Clean)
        PanelMenu.Controls.Add(txtID)
        PanelMenu.Controls.Add(Label22)
        PanelMenu.Controls.Add(Save)
        PanelMenu.Controls.Add(txtBoxRT)
        PanelMenu.Controls.Add(Label14)
        PanelMenu.Controls.Add(Label15)
        PanelMenu.Controls.Add(txtBoxR5)
        PanelMenu.Controls.Add(txtBoxRating)
        PanelMenu.Controls.Add(txtBoxR4)
        PanelMenu.Controls.Add(txtBoxIdioma)
        PanelMenu.Controls.Add(Label16)
        PanelMenu.Controls.Add(txtBoxR3)
        PanelMenu.Controls.Add(txtBoxISBN)
        PanelMenu.Controls.Add(Label17)
        PanelMenu.Controls.Add(Label18)
        PanelMenu.Controls.Add(Label19)
        PanelMenu.Controls.Add(Label20)
        PanelMenu.Controls.Add(Label12)
        PanelMenu.Controls.Add(txtBoxR2)
        PanelMenu.Controls.Add(Label21)
        PanelMenu.Controls.Add(txtBoxEditorial)
        PanelMenu.Controls.Add(txtBoxR1)
        PanelMenu.Controls.Add(txtBoxAño)
        PanelMenu.Controls.Add(txtBoxDia)
        PanelMenu.Controls.Add(txtBoxMes)
        PanelMenu.Controls.Add(txtBoxPaginas)
        PanelMenu.Controls.Add(txtBoxAutor)
        PanelMenu.Controls.Add(txtBoxTitulo)
        PanelMenu.Controls.Add(Label11)
        PanelMenu.Controls.Add(txtBoxReseñas)
        PanelMenu.Controls.Add(Label6)
        PanelMenu.Controls.Add(Label7)
        PanelMenu.Controls.Add(Label8)
        PanelMenu.Controls.Add(Label9)
        PanelMenu.Controls.Add(Label4)
        PanelMenu.Controls.Add(Label5)
        PanelMenu.Controls.Add(Label3)
        PanelMenu.Controls.Add(Label10)
        PanelMenu.Dock = DockStyle.Left
        PanelMenu.Location = New Point(0, 0)
        PanelMenu.Name = "PanelMenu"
        PanelMenu.Size = New Size(398, 752)
        PanelMenu.TabIndex = 32
        ' 
        ' picBDelete
        ' 
        picBDelete.Image = CType(resources.GetObject("picBDelete.Image"), Image)
        picBDelete.Location = New Point(318, 677)
        picBDelete.Name = "picBDelete"
        picBDelete.Size = New Size(61, 65)
        picBDelete.SizeMode = PictureBoxSizeMode.StretchImage
        picBDelete.TabIndex = 69
        picBDelete.TabStop = False
        ' 
        ' Clean
        ' 
        Clean.Image = CType(resources.GetObject("Clean.Image"), Image)
        Clean.Location = New Point(180, 684)
        Clean.Name = "Clean"
        Clean.Size = New Size(53, 56)
        Clean.SizeMode = PictureBoxSizeMode.StretchImage
        Clean.TabIndex = 68
        Clean.TabStop = False
        ' 
        ' txtID
        ' 
        txtID.Enabled = False
        txtID.Location = New Point(224, 24)
        txtID.Name = "txtID"
        txtID.ReadOnly = True
        txtID.Size = New Size(170, 27)
        txtID.TabIndex = 67
        ' 
        ' Label22
        ' 
        Label22.AutoSize = True
        Label22.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label22.Location = New Point(11, 27)
        Label22.Name = "Label22"
        Label22.Size = New Size(29, 24)
        Label22.TabIndex = 66
        Label22.Tag = ""
        Label22.Text = "ID"
        ' 
        ' Save
        ' 
        Save.Image = CType(resources.GetObject("Save.Image"), Image)
        Save.Location = New Point(20, 684)
        Save.Name = "Save"
        Save.Size = New Size(53, 56)
        Save.SizeMode = PictureBoxSizeMode.StretchImage
        Save.TabIndex = 59
        Save.TabStop = False
        ' 
        ' txtBoxRT
        ' 
        txtBoxRT.Location = New Point(225, 640)
        txtBoxRT.Name = "txtBoxRT"
        txtBoxRT.Size = New Size(170, 27)
        txtBoxRT.TabIndex = 64
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(12, 643)
        Label14.Name = "Label14"
        Label14.Size = New Size(150, 24)
        Label14.TabIndex = 55
        Label14.Text = "Rating D. Total"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(11, 610)
        Label15.Name = "Label15"
        Label15.Size = New Size(88, 24)
        Label15.TabIndex = 54
        Label15.Text = "Rating 5"
        ' 
        ' txtBoxR5
        ' 
        txtBoxR5.Location = New Point(225, 607)
        txtBoxR5.Name = "txtBoxR5"
        txtBoxR5.Size = New Size(170, 27)
        txtBoxR5.TabIndex = 63
        ' 
        ' txtBoxRating
        ' 
        txtBoxRating.Location = New Point(225, 343)
        txtBoxRating.Name = "txtBoxRating"
        txtBoxRating.Size = New Size(170, 27)
        txtBoxRating.TabIndex = 46
        ' 
        ' txtBoxR4
        ' 
        txtBoxR4.Location = New Point(225, 574)
        txtBoxR4.Name = "txtBoxR4"
        txtBoxR4.Size = New Size(170, 27)
        txtBoxR4.TabIndex = 62
        ' 
        ' txtBoxIdioma
        ' 
        txtBoxIdioma.Location = New Point(225, 310)
        txtBoxIdioma.Name = "txtBoxIdioma"
        txtBoxIdioma.Size = New Size(170, 27)
        txtBoxIdioma.TabIndex = 45
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(12, 577)
        Label16.Name = "Label16"
        Label16.Size = New Size(88, 24)
        Label16.TabIndex = 53
        Label16.Text = "Rating 4"
        ' 
        ' txtBoxR3
        ' 
        txtBoxR3.Location = New Point(225, 541)
        txtBoxR3.Name = "txtBoxR3"
        txtBoxR3.Size = New Size(170, 27)
        txtBoxR3.TabIndex = 61
        ' 
        ' txtBoxISBN
        ' 
        txtBoxISBN.Location = New Point(225, 277)
        txtBoxISBN.Name = "txtBoxISBN"
        txtBoxISBN.Size = New Size(170, 27)
        txtBoxISBN.TabIndex = 44
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(11, 544)
        Label17.Name = "Label17"
        Label17.Size = New Size(88, 24)
        Label17.TabIndex = 52
        Label17.Text = "Rating 3"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(11, 511)
        Label18.Name = "Label18"
        Label18.Size = New Size(88, 24)
        Label18.TabIndex = 51
        Label18.Text = "Rating 2"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(11, 478)
        Label19.Name = "Label19"
        Label19.Size = New Size(88, 24)
        Label19.TabIndex = 50
        Label19.Text = "Rating 1"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(11, 445)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 24)
        Label20.TabIndex = 49
        Label20.Text = "Fecha"
        ' 
        ' Label12
        ' 
        Label12.AutoSize = True
        Label12.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label12.Location = New Point(12, 379)
        Label12.Name = "Label12"
        Label12.Size = New Size(205, 24)
        Label12.TabIndex = 47
        Label12.Text = "No. Total de reseñas"
        ' 
        ' txtBoxR2
        ' 
        txtBoxR2.Location = New Point(225, 508)
        txtBoxR2.Name = "txtBoxR2"
        txtBoxR2.Size = New Size(170, 27)
        txtBoxR2.TabIndex = 60
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(12, 412)
        Label21.Name = "Label21"
        Label21.Size = New Size(62, 24)
        Label21.TabIndex = 48
        Label21.Text = "Autor"
        ' 
        ' txtBoxEditorial
        ' 
        txtBoxEditorial.Location = New Point(225, 244)
        txtBoxEditorial.Name = "txtBoxEditorial"
        txtBoxEditorial.Size = New Size(170, 27)
        txtBoxEditorial.TabIndex = 43
        ' 
        ' txtBoxR1
        ' 
        txtBoxR1.Location = New Point(225, 475)
        txtBoxR1.Name = "txtBoxR1"
        txtBoxR1.Size = New Size(170, 27)
        txtBoxR1.TabIndex = 59
        ' 
        ' txtBoxAño
        ' 
        txtBoxAño.Location = New Point(225, 211)
        txtBoxAño.Name = "txtBoxAño"
        txtBoxAño.Size = New Size(170, 27)
        txtBoxAño.TabIndex = 42
        ' 
        ' txtBoxDia
        ' 
        txtBoxDia.Location = New Point(225, 178)
        txtBoxDia.Name = "txtBoxDia"
        txtBoxDia.Size = New Size(170, 27)
        txtBoxDia.TabIndex = 41
        ' 
        ' txtBoxMes
        ' 
        txtBoxMes.Location = New Point(225, 143)
        txtBoxMes.Name = "txtBoxMes"
        txtBoxMes.Size = New Size(170, 27)
        txtBoxMes.TabIndex = 40
        ' 
        ' txtBoxPaginas
        ' 
        txtBoxPaginas.Location = New Point(225, 109)
        txtBoxPaginas.Name = "txtBoxPaginas"
        txtBoxPaginas.Size = New Size(170, 27)
        txtBoxPaginas.TabIndex = 39
        ' 
        ' txtBoxAutor
        ' 
        txtBoxAutor.Location = New Point(225, 409)
        txtBoxAutor.Name = "txtBoxAutor"
        txtBoxAutor.Size = New Size(170, 27)
        txtBoxAutor.TabIndex = 58
        ' 
        ' txtBoxTitulo
        ' 
        txtBoxTitulo.Location = New Point(225, 76)
        txtBoxTitulo.Name = "txtBoxTitulo"
        txtBoxTitulo.Size = New Size(170, 27)
        txtBoxTitulo.TabIndex = 38
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(11, 346)
        Label11.Name = "Label11"
        Label11.Size = New Size(71, 24)
        Label11.TabIndex = 37
        Label11.Text = "Rating"
        ' 
        ' txtBoxReseñas
        ' 
        txtBoxReseñas.Location = New Point(225, 376)
        txtBoxReseñas.Name = "txtBoxReseñas"
        txtBoxReseñas.Size = New Size(170, 27)
        txtBoxReseñas.TabIndex = 57
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(11, 313)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 24)
        Label6.TabIndex = 36
        Label6.Text = "Idioma"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(12, 280)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 24)
        Label7.TabIndex = 35
        Label7.Text = "ISBN"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(12, 247)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 24)
        Label8.TabIndex = 34
        Label8.Text = "Editorial"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(12, 214)
        Label9.Name = "Label9"
        Label9.Size = New Size(190, 24)
        Label9.TabIndex = 33
        Label9.Text = "Año de publicación"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(11, 181)
        Label4.Name = "Label4"
        Label4.Size = New Size(184, 24)
        Label4.TabIndex = 32
        Label4.Text = "Día de publicación"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(11, 146)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 24)
        Label5.TabIndex = 31
        Label5.Text = "Mes de publicación"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(12, 112)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 24)
        Label3.TabIndex = 30
        Label3.Text = "No. Páginas"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(12, 79)
        Label10.Name = "Label10"
        Label10.Size = New Size(65, 24)
        Label10.TabIndex = 29
        Label10.Text = "Título"
        ' 
        ' DateAdd
        ' 
        DateAdd.Location = New Point(224, 443)
        DateAdd.Name = "DateAdd"
        DateAdd.Size = New Size(171, 27)
        DateAdd.TabIndex = 70
        ' 
        ' EditBooks
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1193, 792)
        Controls.Add(Panelfondo)
        Controls.Add(PanelTitleB)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "EditBooks"
        Text = "EditBooks"
        CType(PBMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PBMax, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleB.ResumeLayout(False)
        PanelTitleB.PerformLayout()
        CType(PBMin, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBR, ComponentModel.ISupportInitialize).EndInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).EndInit()
        Panelfondo.ResumeLayout(False)
        Panelfondo.PerformLayout()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGVBooks, ComponentModel.ISupportInitialize).EndInit()
        PanelMenu.ResumeLayout(False)
        PanelMenu.PerformLayout()
        CType(picBDelete, ComponentModel.ISupportInitialize).EndInit()
        CType(Clean, ComponentModel.ISupportInitialize).EndInit()
        CType(Save, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PBMinimizar As PictureBox
    Friend WithEvents PBClose As PictureBox
    Friend WithEvents PBMax As PictureBox
    Friend WithEvents PanelTitleB As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PicBR As PictureBox
    Friend WithEvents picBMinimize As PictureBox
    Friend WithEvents PicBClose As PictureBox
    Friend WithEvents PicBMaximize As PictureBox
    Friend WithEvents PBMin As PictureBox
    Friend WithEvents Panelfondo As Panel
    Friend WithEvents PanelMenu As Panel
    Friend WithEvents txtBoxRating As TextBox
    Friend WithEvents txtBoxIdioma As TextBox
    Friend WithEvents txtBoxISBN As TextBox
    Friend WithEvents txtBoxEditorial As TextBox
    Friend WithEvents txtBoxAño As TextBox
    Friend WithEvents txtBoxDia As TextBox
    Friend WithEvents txtBoxMes As TextBox
    Friend WithEvents txtBoxPaginas As TextBox
    Friend WithEvents txtBoxTitulo As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtBoxRT As TextBox
    Friend WithEvents txtBoxR5 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtBoxR4 As TextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtBoxR3 As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents txtBoxR2 As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents txtBoxR1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents txtBoxAutor As TextBox
    Friend WithEvents Label17 As Label
    Friend WithEvents txtBoxReseñas As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents DataGVBooks As DataGridView
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Save As PictureBox
    Friend WithEvents txtID As TextBox
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents CBoxAutor As ComboBox
    Friend WithEvents Clean As PictureBox
    Friend WithEvents picBDelete As PictureBox
    Friend WithEvents DateAdd As DateTimePicker
End Class
