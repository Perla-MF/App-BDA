<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Books
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Books))
        PanelP = New Panel()
        PanelI = New Panel()
        PBLimpiar = New PictureBox()
        PBAgregar = New PictureBox()
        txtBoxRT = New TextBox()
        txtBoxR5 = New TextBox()
        txtBoxR4 = New TextBox()
        txtBoxR3 = New TextBox()
        txtBoxR2 = New TextBox()
        txtBoxR1 = New TextBox()
        txtBoxAutor = New TextBox()
        txtBoxReseñas = New TextBox()
        txtBoxRating = New TextBox()
        txtBoxIdioma = New TextBox()
        txtBoxISBN = New TextBox()
        txtBoxEditorial = New TextBox()
        txtBoxAño = New TextBox()
        txtBoxDia = New TextBox()
        txtBoxMes = New TextBox()
        txtBoxPaginas = New TextBox()
        txtBoxTitulo = New TextBox()
        Label13 = New Label()
        Label14 = New Label()
        Label15 = New Label()
        Label16 = New Label()
        Label17 = New Label()
        Label18 = New Label()
        Label19 = New Label()
        Label20 = New Label()
        Label21 = New Label()
        Label10 = New Label()
        Label11 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label3 = New Label()
        Label2 = New Label()
        PBMin = New PictureBox()
        PanelTitleB = New Panel()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        PBMinimizar = New PictureBox()
        PBClose = New PictureBox()
        PBMax = New PictureBox()
        PicBR = New PictureBox()
        picBMinimize = New PictureBox()
        PicBClose = New PictureBox()
        PicBMaximize = New PictureBox()
        DateAdd = New DateTimePicker()
        PanelP.SuspendLayout()
        PanelI.SuspendLayout()
        CType(PBLimpiar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBAgregar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBMin, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitleB.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PBMax, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBR, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelP
        ' 
        PanelP.Controls.Add(PanelI)
        PanelP.Controls.Add(PBMin)
        PanelP.Controls.Add(PanelTitleB)
        PanelP.Dock = DockStyle.Fill
        PanelP.Location = New Point(0, 0)
        PanelP.Name = "PanelP"
        PanelP.Size = New Size(1133, 687)
        PanelP.TabIndex = 0
        ' 
        ' PanelI
        ' 
        PanelI.BackColor = Color.Cornsilk
        PanelI.Controls.Add(DateAdd)
        PanelI.Controls.Add(PBLimpiar)
        PanelI.Controls.Add(PBAgregar)
        PanelI.Controls.Add(txtBoxRT)
        PanelI.Controls.Add(txtBoxR5)
        PanelI.Controls.Add(txtBoxR4)
        PanelI.Controls.Add(txtBoxR3)
        PanelI.Controls.Add(txtBoxR2)
        PanelI.Controls.Add(txtBoxR1)
        PanelI.Controls.Add(txtBoxAutor)
        PanelI.Controls.Add(txtBoxReseñas)
        PanelI.Controls.Add(txtBoxRating)
        PanelI.Controls.Add(txtBoxIdioma)
        PanelI.Controls.Add(txtBoxISBN)
        PanelI.Controls.Add(txtBoxEditorial)
        PanelI.Controls.Add(txtBoxAño)
        PanelI.Controls.Add(txtBoxDia)
        PanelI.Controls.Add(txtBoxMes)
        PanelI.Controls.Add(txtBoxPaginas)
        PanelI.Controls.Add(txtBoxTitulo)
        PanelI.Controls.Add(Label13)
        PanelI.Controls.Add(Label14)
        PanelI.Controls.Add(Label15)
        PanelI.Controls.Add(Label16)
        PanelI.Controls.Add(Label17)
        PanelI.Controls.Add(Label18)
        PanelI.Controls.Add(Label19)
        PanelI.Controls.Add(Label20)
        PanelI.Controls.Add(Label21)
        PanelI.Controls.Add(Label10)
        PanelI.Controls.Add(Label11)
        PanelI.Controls.Add(Label6)
        PanelI.Controls.Add(Label7)
        PanelI.Controls.Add(Label8)
        PanelI.Controls.Add(Label9)
        PanelI.Controls.Add(Label4)
        PanelI.Controls.Add(Label5)
        PanelI.Controls.Add(Label3)
        PanelI.Controls.Add(Label2)
        PanelI.Dock = DockStyle.Fill
        PanelI.Location = New Point(0, 40)
        PanelI.Name = "PanelI"
        PanelI.Size = New Size(1133, 647)
        PanelI.TabIndex = 9
        ' 
        ' PBLimpiar
        ' 
        PBLimpiar.BackColor = Color.Cornsilk
        PBLimpiar.Image = CType(resources.GetObject("PBLimpiar.Image"), Image)
        PBLimpiar.Location = New Point(630, 541)
        PBLimpiar.Name = "PBLimpiar"
        PBLimpiar.Size = New Size(59, 69)
        PBLimpiar.SizeMode = PictureBoxSizeMode.StretchImage
        PBLimpiar.TabIndex = 40
        PBLimpiar.TabStop = False
        ' 
        ' PBAgregar
        ' 
        PBAgregar.BackColor = Color.Cornsilk
        PBAgregar.Image = CType(resources.GetObject("PBAgregar.Image"), Image)
        PBAgregar.Location = New Point(373, 541)
        PBAgregar.Name = "PBAgregar"
        PBAgregar.Size = New Size(64, 69)
        PBAgregar.SizeMode = PictureBoxSizeMode.StretchImage
        PBAgregar.TabIndex = 39
        PBAgregar.TabStop = False
        ' 
        ' txtBoxRT
        ' 
        txtBoxRT.Location = New Point(841, 471)
        txtBoxRT.Name = "txtBoxRT"
        txtBoxRT.Size = New Size(237, 27)
        txtBoxRT.TabIndex = 37
        ' 
        ' txtBoxR5
        ' 
        txtBoxR5.Location = New Point(841, 420)
        txtBoxR5.Name = "txtBoxR5"
        txtBoxR5.Size = New Size(237, 27)
        txtBoxR5.TabIndex = 36
        ' 
        ' txtBoxR4
        ' 
        txtBoxR4.Location = New Point(841, 365)
        txtBoxR4.Name = "txtBoxR4"
        txtBoxR4.Size = New Size(237, 27)
        txtBoxR4.TabIndex = 35
        ' 
        ' txtBoxR3
        ' 
        txtBoxR3.Location = New Point(841, 309)
        txtBoxR3.Name = "txtBoxR3"
        txtBoxR3.Size = New Size(237, 27)
        txtBoxR3.TabIndex = 34
        ' 
        ' txtBoxR2
        ' 
        txtBoxR2.Location = New Point(841, 252)
        txtBoxR2.Name = "txtBoxR2"
        txtBoxR2.Size = New Size(237, 27)
        txtBoxR2.TabIndex = 33
        ' 
        ' txtBoxR1
        ' 
        txtBoxR1.Location = New Point(841, 204)
        txtBoxR1.Name = "txtBoxR1"
        txtBoxR1.Size = New Size(237, 27)
        txtBoxR1.TabIndex = 32
        ' 
        ' txtBoxAutor
        ' 
        txtBoxAutor.Location = New Point(841, 96)
        txtBoxAutor.Name = "txtBoxAutor"
        txtBoxAutor.Size = New Size(237, 27)
        txtBoxAutor.TabIndex = 30
        ' 
        ' txtBoxReseñas
        ' 
        txtBoxReseñas.Location = New Point(841, 36)
        txtBoxReseñas.Name = "txtBoxReseñas"
        txtBoxReseñas.Size = New Size(237, 27)
        txtBoxReseñas.TabIndex = 29
        ' 
        ' txtBoxRating
        ' 
        txtBoxRating.Location = New Point(293, 471)
        txtBoxRating.Name = "txtBoxRating"
        txtBoxRating.Size = New Size(237, 27)
        txtBoxRating.TabIndex = 28
        ' 
        ' txtBoxIdioma
        ' 
        txtBoxIdioma.Location = New Point(293, 420)
        txtBoxIdioma.Name = "txtBoxIdioma"
        txtBoxIdioma.Size = New Size(237, 27)
        txtBoxIdioma.TabIndex = 27
        ' 
        ' txtBoxISBN
        ' 
        txtBoxISBN.Location = New Point(293, 365)
        txtBoxISBN.Name = "txtBoxISBN"
        txtBoxISBN.Size = New Size(237, 27)
        txtBoxISBN.TabIndex = 26
        ' 
        ' txtBoxEditorial
        ' 
        txtBoxEditorial.Location = New Point(293, 309)
        txtBoxEditorial.Name = "txtBoxEditorial"
        txtBoxEditorial.Size = New Size(237, 27)
        txtBoxEditorial.TabIndex = 25
        ' 
        ' txtBoxAño
        ' 
        txtBoxAño.Location = New Point(293, 252)
        txtBoxAño.Name = "txtBoxAño"
        txtBoxAño.Size = New Size(237, 27)
        txtBoxAño.TabIndex = 24
        ' 
        ' txtBoxDia
        ' 
        txtBoxDia.Location = New Point(293, 204)
        txtBoxDia.Name = "txtBoxDia"
        txtBoxDia.Size = New Size(237, 27)
        txtBoxDia.TabIndex = 23
        ' 
        ' txtBoxMes
        ' 
        txtBoxMes.Location = New Point(293, 149)
        txtBoxMes.Name = "txtBoxMes"
        txtBoxMes.Size = New Size(237, 27)
        txtBoxMes.TabIndex = 22
        ' 
        ' txtBoxPaginas
        ' 
        txtBoxPaginas.Location = New Point(293, 96)
        txtBoxPaginas.Name = "txtBoxPaginas"
        txtBoxPaginas.Size = New Size(237, 27)
        txtBoxPaginas.TabIndex = 21
        ' 
        ' txtBoxTitulo
        ' 
        txtBoxTitulo.Location = New Point(293, 36)
        txtBoxTitulo.Name = "txtBoxTitulo"
        txtBoxTitulo.Size = New Size(237, 27)
        txtBoxTitulo.TabIndex = 20
        ' 
        ' Label13
        ' 
        Label13.AutoSize = True
        Label13.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label13.Location = New Point(587, 468)
        Label13.Name = "Label13"
        Label13.Size = New Size(0, 24)
        Label13.TabIndex = 18
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label14.Location = New Point(587, 468)
        Label14.Name = "Label14"
        Label14.Size = New Size(150, 24)
        Label14.TabIndex = 17
        Label14.Text = "Rating D. Total"
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label15.Location = New Point(587, 420)
        Label15.Name = "Label15"
        Label15.Size = New Size(88, 24)
        Label15.TabIndex = 16
        Label15.Text = "Rating 5"
        ' 
        ' Label16
        ' 
        Label16.AutoSize = True
        Label16.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label16.Location = New Point(587, 363)
        Label16.Name = "Label16"
        Label16.Size = New Size(88, 24)
        Label16.TabIndex = 15
        Label16.Text = "Rating 4"
        ' 
        ' Label17
        ' 
        Label17.AutoSize = True
        Label17.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label17.Location = New Point(587, 309)
        Label17.Name = "Label17"
        Label17.Size = New Size(88, 24)
        Label17.TabIndex = 14
        Label17.Text = "Rating 3"
        ' 
        ' Label18
        ' 
        Label18.AutoSize = True
        Label18.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label18.Location = New Point(587, 252)
        Label18.Name = "Label18"
        Label18.Size = New Size(88, 24)
        Label18.TabIndex = 13
        Label18.Text = "Rating 2"
        ' 
        ' Label19
        ' 
        Label19.AutoSize = True
        Label19.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label19.Location = New Point(587, 204)
        Label19.Name = "Label19"
        Label19.Size = New Size(88, 24)
        Label19.TabIndex = 12
        Label19.Text = "Rating 1"
        ' 
        ' Label20
        ' 
        Label20.AutoSize = True
        Label20.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label20.Location = New Point(587, 147)
        Label20.Name = "Label20"
        Label20.Size = New Size(67, 24)
        Label20.TabIndex = 11
        Label20.Text = "Fecha"
        ' 
        ' Label21
        ' 
        Label21.AutoSize = True
        Label21.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label21.Location = New Point(587, 93)
        Label21.Name = "Label21"
        Label21.Size = New Size(62, 24)
        Label21.TabIndex = 10
        Label21.Text = "Autor"
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(587, 36)
        Label10.Name = "Label10"
        Label10.Size = New Size(205, 24)
        Label10.TabIndex = 9
        Label10.Text = "No. Total de reseñas"
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(50, 468)
        Label11.Name = "Label11"
        Label11.Size = New Size(71, 24)
        Label11.TabIndex = 8
        Label11.Text = "Rating"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(50, 420)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 24)
        Label6.TabIndex = 7
        Label6.Text = "Idioma"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(50, 363)
        Label7.Name = "Label7"
        Label7.Size = New Size(56, 24)
        Label7.TabIndex = 6
        Label7.Text = "ISBN"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(50, 309)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 24)
        Label8.TabIndex = 5
        Label8.Text = "Editorial"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(50, 252)
        Label9.Name = "Label9"
        Label9.Size = New Size(190, 24)
        Label9.TabIndex = 4
        Label9.Text = "Año de publicación"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(50, 204)
        Label4.Name = "Label4"
        Label4.Size = New Size(184, 24)
        Label4.TabIndex = 3
        Label4.Text = "Día de publicación"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(50, 147)
        Label5.Name = "Label5"
        Label5.Size = New Size(192, 24)
        Label5.TabIndex = 2
        Label5.Text = "Mes de publicación"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(50, 93)
        Label3.Name = "Label3"
        Label3.Size = New Size(123, 24)
        Label3.TabIndex = 1
        Label3.Text = "No. Páginas"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(50, 36)
        Label2.Name = "Label2"
        Label2.Size = New Size(65, 24)
        Label2.TabIndex = 0
        Label2.Text = "Título"
        ' 
        ' PBMin
        ' 
        PBMin.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMin.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PBMin.Image = CType(resources.GetObject("PBMin.Image"), Image)
        PBMin.Location = New Point(1050, 5)
        PBMin.Name = "PBMin"
        PBMin.Size = New Size(27, 27)
        PBMin.SizeMode = PictureBoxSizeMode.StretchImage
        PBMin.TabIndex = 8
        PBMin.TabStop = False
        PBMin.Visible = False
        ' 
        ' PanelTitleB
        ' 
        PanelTitleB.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PanelTitleB.Controls.Add(Label1)
        PanelTitleB.Controls.Add(PictureBox1)
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
        PanelTitleB.Size = New Size(1133, 40)
        PanelTitleB.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 18F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ControlLightLight
        Label1.Location = New Point(95, 3)
        Label1.Name = "Label1"
        Label1.Size = New Size(213, 34)
        Label1.TabIndex = 9
        Label1.Text = "Agregar Libro"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(26, 3)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(35, 37)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 8
        PictureBox1.TabStop = False
        ' 
        ' PBMinimizar
        ' 
        PBMinimizar.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PBMinimizar.Image = CType(resources.GetObject("PBMinimizar.Image"), Image)
        PBMinimizar.Location = New Point(1006, 5)
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
        PBClose.Location = New Point(1094, 5)
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
        PBMax.Location = New Point(1050, 5)
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
        PicBR.Location = New Point(1864, 7)
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
        picBMinimize.Location = New Point(1819, 7)
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
        PicBClose.Location = New Point(1909, 7)
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
        PicBMaximize.Location = New Point(1864, 7)
        PicBMaximize.Name = "PicBMaximize"
        PicBMaximize.Size = New Size(27, 27)
        PicBMaximize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBMaximize.TabIndex = 1
        PicBMaximize.TabStop = False
        ' 
        ' DateAdd
        ' 
        DateAdd.Location = New Point(841, 149)
        DateAdd.Name = "DateAdd"
        DateAdd.Size = New Size(237, 27)
        DateAdd.TabIndex = 41
        ' 
        ' Books
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1133, 687)
        Controls.Add(PanelP)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(680, 500)
        Name = "Books"
        Text = "Books"
        PanelP.ResumeLayout(False)
        PanelI.ResumeLayout(False)
        PanelI.PerformLayout()
        CType(PBLimpiar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBAgregar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBMin, ComponentModel.ISupportInitialize).EndInit()
        PanelTitleB.ResumeLayout(False)
        PanelTitleB.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PBMinimizar, ComponentModel.ISupportInitialize).EndInit()
        CType(PBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PBMax, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBR, ComponentModel.ISupportInitialize).EndInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelP As Panel
    Friend WithEvents PanelTitleB As Panel
    Friend WithEvents PicBR As PictureBox
    Friend WithEvents picBMinimize As PictureBox
    Friend WithEvents PicBClose As PictureBox
    Friend WithEvents PicBMaximize As PictureBox
    Friend WithEvents PBMin As PictureBox
    Friend WithEvents PBMinimizar As PictureBox
    Friend WithEvents PBClose As PictureBox
    Friend WithEvents PBMax As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PanelI As Panel
    Friend WithEvents txtBoxRating As TextBox
    Friend WithEvents txtBoxIdioma As TextBox
    Friend WithEvents txtBoxISBN As TextBox
    Friend WithEvents txtBoxEditorial As TextBox
    Friend WithEvents txtBoxAño As TextBox
    Friend WithEvents txtBoxDia As TextBox
    Friend WithEvents txtBoxMes As TextBox
    Friend WithEvents txtBoxPaginas As TextBox
    Friend WithEvents txtBoxTitulo As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtBoxRT As TextBox
    Friend WithEvents txtBoxR5 As TextBox
    Friend WithEvents txtBoxR4 As TextBox
    Friend WithEvents txtBoxR3 As TextBox
    Friend WithEvents txtBoxR2 As TextBox
    Friend WithEvents txtBoxR1 As TextBox
    Friend WithEvents txtBoxAutor As TextBox
    Friend WithEvents txtBoxReseñas As TextBox
    Friend WithEvents PBAgregar As PictureBox
    Friend WithEvents PBLimpiar As PictureBox
    Friend WithEvents DateAdd As DateTimePicker
End Class
