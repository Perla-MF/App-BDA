<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrincipal))
        PanelC = New Panel()
        PanelF = New Panel()
        Reload = New PictureBox()
        PictureBox4 = New PictureBox()
        PictureBox1 = New PictureBox()
        CBoxAutor = New ComboBox()
        Label2 = New Label()
        DataGVFichaB = New DataGridView()
        Label1 = New Label()
        PictureBox2 = New PictureBox()
        PanelM = New Panel()
        PictureBox8 = New PictureBox()
        PictureBox7 = New PictureBox()
        PictureBox6 = New PictureBox()
        PictureBox5 = New PictureBox()
        Button4 = New Button()
        Button3 = New Button()
        BtnAddA = New Button()
        btnAddB = New Button()
        PanelTitle = New Panel()
        PicBR = New PictureBox()
        picBMinimize = New PictureBox()
        PicBClose = New PictureBox()
        PicBMaximize = New PictureBox()
        PanelC.SuspendLayout()
        PanelF.SuspendLayout()
        CType(Reload, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(DataGVFichaB, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        PanelM.SuspendLayout()
        CType(PictureBox8, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).BeginInit()
        PanelTitle.SuspendLayout()
        CType(PicBR, ComponentModel.ISupportInitialize).BeginInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).BeginInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' PanelC
        ' 
        PanelC.BackColor = Color.NavajoWhite
        PanelC.Controls.Add(PanelF)
        PanelC.Controls.Add(PanelM)
        PanelC.Controls.Add(PanelTitle)
        PanelC.Dock = DockStyle.Fill
        PanelC.Location = New Point(0, 0)
        PanelC.Name = "PanelC"
        PanelC.Size = New Size(1015, 593)
        PanelC.TabIndex = 0
        ' 
        ' PanelF
        ' 
        PanelF.BackColor = Color.Cornsilk
        PanelF.Controls.Add(Reload)
        PanelF.Controls.Add(PictureBox4)
        PanelF.Controls.Add(PictureBox1)
        PanelF.Controls.Add(CBoxAutor)
        PanelF.Controls.Add(Label2)
        PanelF.Controls.Add(DataGVFichaB)
        PanelF.Controls.Add(Label1)
        PanelF.Controls.Add(PictureBox2)
        PanelF.Dock = DockStyle.Fill
        PanelF.Location = New Point(250, 40)
        PanelF.Name = "PanelF"
        PanelF.Size = New Size(765, 553)
        PanelF.TabIndex = 2
        ' 
        ' Reload
        ' 
        Reload.Image = CType(resources.GetObject("Reload.Image"), Image)
        Reload.Location = New Point(371, 96)
        Reload.Name = "Reload"
        Reload.Size = New Size(36, 37)
        Reload.SizeMode = PictureBoxSizeMode.StretchImage
        Reload.TabIndex = 13
        Reload.TabStop = False
        ' 
        ' PictureBox4
        ' 
        PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), Image)
        PictureBox4.Location = New Point(422, 85)
        PictureBox4.Name = "PictureBox4"
        PictureBox4.Size = New Size(53, 56)
        PictureBox4.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox4.TabIndex = 12
        PictureBox4.TabStop = False
        ' 
        ' PictureBox1
        ' 
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(696, 85)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(53, 56)
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox1.TabIndex = 10
        PictureBox1.TabStop = False
        ' 
        ' CBoxAutor
        ' 
        CBoxAutor.FormattingEnabled = True
        CBoxAutor.Location = New Point(97, 100)
        CBoxAutor.Name = "CBoxAutor"
        CBoxAutor.Size = New Size(268, 28)
        CBoxAutor.TabIndex = 5
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Arial", 12F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(21, 104)
        Label2.Name = "Label2"
        Label2.Size = New Size(71, 24)
        Label2.TabIndex = 4
        Label2.Text = "Autor:"
        ' 
        ' DataGVFichaB
        ' 
        DataGVFichaB.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGVFichaB.BackgroundColor = Color.Cornsilk
        DataGVFichaB.ColumnHeadersHeight = 40
        DataGVFichaB.GridColor = SystemColors.Info
        DataGVFichaB.Location = New Point(16, 163)
        DataGVFichaB.Name = "DataGVFichaB"
        DataGVFichaB.RowHeadersWidth = 51
        DataGVFichaB.Size = New Size(733, 371)
        DataGVFichaB.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Arial", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(258, 32)
        Label1.Name = "Label1"
        Label1.Size = New Size(249, 27)
        Label1.TabIndex = 2
        Label1.Text = "Fichas Bibliográficas"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(21, 19)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(53, 56)
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' PanelM
        ' 
        PanelM.BackColor = Color.Tan
        PanelM.Controls.Add(PictureBox8)
        PanelM.Controls.Add(PictureBox7)
        PanelM.Controls.Add(PictureBox6)
        PanelM.Controls.Add(PictureBox5)
        PanelM.Controls.Add(Button4)
        PanelM.Controls.Add(Button3)
        PanelM.Controls.Add(BtnAddA)
        PanelM.Controls.Add(btnAddB)
        PanelM.Dock = DockStyle.Left
        PanelM.Location = New Point(0, 40)
        PanelM.Name = "PanelM"
        PanelM.Size = New Size(250, 553)
        PanelM.TabIndex = 1
        ' 
        ' PictureBox8
        ' 
        PictureBox8.Image = CType(resources.GetObject("PictureBox8.Image"), Image)
        PictureBox8.Location = New Point(3, 341)
        PictureBox8.Name = "PictureBox8"
        PictureBox8.Size = New Size(50, 49)
        PictureBox8.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox8.TabIndex = 16
        PictureBox8.TabStop = False
        ' 
        ' PictureBox7
        ' 
        PictureBox7.Image = CType(resources.GetObject("PictureBox7.Image"), Image)
        PictureBox7.Location = New Point(6, 283)
        PictureBox7.Name = "PictureBox7"
        PictureBox7.Size = New Size(48, 49)
        PictureBox7.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox7.TabIndex = 15
        PictureBox7.TabStop = False
        ' 
        ' PictureBox6
        ' 
        PictureBox6.Image = CType(resources.GetObject("PictureBox6.Image"), Image)
        PictureBox6.Location = New Point(7, 223)
        PictureBox6.Name = "PictureBox6"
        PictureBox6.Size = New Size(43, 49)
        PictureBox6.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox6.TabIndex = 14
        PictureBox6.TabStop = False
        ' 
        ' PictureBox5
        ' 
        PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), Image)
        PictureBox5.Location = New Point(3, 168)
        PictureBox5.Name = "PictureBox5"
        PictureBox5.Size = New Size(50, 49)
        PictureBox5.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox5.TabIndex = 13
        PictureBox5.TabStop = False
        ' 
        ' Button4
        ' 
        Button4.FlatAppearance.BorderSize = 0
        Button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        Button4.FlatStyle = FlatStyle.Flat
        Button4.Font = New Font("Arial", 12F, FontStyle.Bold)
        Button4.ForeColor = SystemColors.ButtonHighlight
        Button4.ImageAlign = ContentAlignment.MiddleRight
        Button4.Location = New Point(0, 341)
        Button4.Name = "Button4"
        Button4.Size = New Size(250, 49)
        Button4.TabIndex = 4
        Button4.Text = "Agregar Usuario"
        Button4.TextAlign = ContentAlignment.MiddleRight
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.FlatAppearance.BorderSize = 0
        Button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        Button3.FlatStyle = FlatStyle.Flat
        Button3.Font = New Font("Arial", 12F, FontStyle.Bold)
        Button3.ForeColor = SystemColors.ButtonHighlight
        Button3.ImageAlign = ContentAlignment.MiddleRight
        Button3.Location = New Point(0, 283)
        Button3.Name = "Button3"
        Button3.Size = New Size(250, 49)
        Button3.TabIndex = 3
        Button3.Text = "Editar Libro"
        Button3.TextAlign = ContentAlignment.MiddleRight
        Button3.UseVisualStyleBackColor = True
        ' 
        ' BtnAddA
        ' 
        BtnAddA.FlatAppearance.BorderSize = 0
        BtnAddA.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        BtnAddA.FlatStyle = FlatStyle.Flat
        BtnAddA.Font = New Font("Arial", 12F, FontStyle.Bold)
        BtnAddA.ForeColor = SystemColors.ButtonHighlight
        BtnAddA.ImageAlign = ContentAlignment.MiddleRight
        BtnAddA.Location = New Point(0, 223)
        BtnAddA.Name = "BtnAddA"
        BtnAddA.Size = New Size(250, 49)
        BtnAddA.TabIndex = 2
        BtnAddA.Text = "Agregar Autor"
        BtnAddA.TextAlign = ContentAlignment.MiddleRight
        BtnAddA.UseVisualStyleBackColor = True
        ' 
        ' btnAddB
        ' 
        btnAddB.FlatAppearance.BorderSize = 0
        btnAddB.FlatAppearance.MouseDownBackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        btnAddB.FlatStyle = FlatStyle.Flat
        btnAddB.Font = New Font("Arial", 12F, FontStyle.Bold)
        btnAddB.ForeColor = SystemColors.ButtonHighlight
        btnAddB.ImageAlign = ContentAlignment.MiddleRight
        btnAddB.Location = New Point(0, 163)
        btnAddB.Name = "btnAddB"
        btnAddB.Size = New Size(250, 49)
        btnAddB.TabIndex = 1
        btnAddB.Text = "Agregar Libro"
        btnAddB.TextAlign = ContentAlignment.MiddleRight
        btnAddB.UseVisualStyleBackColor = True
        ' 
        ' PanelTitle
        ' 
        PanelTitle.BackColor = Color.FromArgb(CByte(108), CByte(59), CByte(42))
        PanelTitle.Controls.Add(PicBR)
        PanelTitle.Controls.Add(picBMinimize)
        PanelTitle.Controls.Add(PicBClose)
        PanelTitle.Controls.Add(PicBMaximize)
        PanelTitle.Dock = DockStyle.Top
        PanelTitle.Location = New Point(0, 0)
        PanelTitle.Name = "PanelTitle"
        PanelTitle.Size = New Size(1015, 40)
        PanelTitle.TabIndex = 0
        ' 
        ' PicBR
        ' 
        PicBR.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        PicBR.Image = CType(resources.GetObject("PicBR.Image"), Image)
        PicBR.Location = New Point(931, 7)
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
        picBMinimize.Location = New Point(887, 7)
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
        PicBClose.Location = New Point(975, 7)
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
        PicBMaximize.Location = New Point(931, 7)
        PicBMaximize.Name = "PicBMaximize"
        PicBMaximize.Size = New Size(27, 27)
        PicBMaximize.SizeMode = PictureBoxSizeMode.StretchImage
        PicBMaximize.TabIndex = 1
        PicBMaximize.TabStop = False
        ' 
        ' FormPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(1015, 593)
        Controls.Add(PanelC)
        FormBorderStyle = FormBorderStyle.None
        MinimumSize = New Size(680, 500)
        Name = "FormPrincipal"
        Text = "Form1"
        PanelC.ResumeLayout(False)
        PanelF.ResumeLayout(False)
        PanelF.PerformLayout()
        CType(Reload, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox4, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(DataGVFichaB, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        PanelM.ResumeLayout(False)
        CType(PictureBox8, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox7, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox6, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox5, ComponentModel.ISupportInitialize).EndInit()
        PanelTitle.ResumeLayout(False)
        CType(PicBR, ComponentModel.ISupportInitialize).EndInit()
        CType(picBMinimize, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBClose, ComponentModel.ISupportInitialize).EndInit()
        CType(PicBMaximize, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PanelC As Panel
    Friend WithEvents PanelTitle As Panel
    Friend WithEvents PanelM As Panel
    Friend WithEvents picBMinimize As PictureBox
    Friend WithEvents PicBClose As PictureBox
    Friend WithEvents PicBMaximize As PictureBox
    Friend WithEvents PicBR As PictureBox
    Friend WithEvents BtnAddA As Button
    Friend WithEvents btnAddB As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PanelF As Panel
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents CBoxAutor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DataGVFichaB As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Reload As PictureBox

End Class
