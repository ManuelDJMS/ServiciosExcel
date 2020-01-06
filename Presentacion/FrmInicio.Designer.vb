<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmInicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmInicio))
        Me.GunaElipse1 = New Guna.UI.WinForms.GunaElipse(Me.components)
        Me.PanelContenedor = New System.Windows.Forms.Panel()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LbRuta = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtInforme = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.TxtMagnitud = New Guna.UI.WinForms.GunaTextBox()
        Me.LbModelo = New Guna.UI.WinForms.GunaLabel()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.PanelBarraTitulo = New Guna.UI.WinForms.GunaPanel()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.lbVersion = New Guna.UI.WinForms.GunaLabel()
        Me.GunaVSeparator1 = New Guna.UI.WinForms.GunaVSeparator()
        Me.GunaImageButton4 = New Guna.UI.WinForms.GunaImageButton()
        Me.BtnCargar = New Guna.UI.WinForms.GunaButton()
        Me.btnGuardar = New Guna.UI.WinForms.GunaButton()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GunaPictureBox2 = New Guna.UI.WinForms.GunaPictureBox()
        Me.BtnCerrar = New Guna.UI.WinForms.GunaImageButton()
        Me.BtnMinimizar = New Guna.UI.WinForms.GunaImageButton()
        Me.GunaImageButton1 = New Guna.UI.WinForms.GunaImageButton()
        Me.PanelContenedor.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelBarraTitulo.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaElipse1
        '
        Me.GunaElipse1.TargetControl = Me
        '
        'PanelContenedor
        '
        Me.PanelContenedor.Controls.Add(Me.GunaImageButton1)
        Me.PanelContenedor.Controls.Add(Me.lbVersion)
        Me.PanelContenedor.Controls.Add(Me.DataGridView2)
        Me.PanelContenedor.Controls.Add(Me.DataGridView1)
        Me.PanelContenedor.Controls.Add(Me.BtnCargar)
        Me.PanelContenedor.Controls.Add(Me.LbRuta)
        Me.PanelContenedor.Controls.Add(Me.GunaLabel4)
        Me.PanelContenedor.Controls.Add(Me.TxtInforme)
        Me.PanelContenedor.Controls.Add(Me.GunaLabel3)
        Me.PanelContenedor.Controls.Add(Me.TxtMagnitud)
        Me.PanelContenedor.Controls.Add(Me.LbModelo)
        Me.PanelContenedor.Controls.Add(Me.btnGuardar)
        Me.PanelContenedor.Controls.Add(Me.Label26)
        Me.PanelContenedor.Controls.Add(Me.PictureBox1)
        Me.PanelContenedor.Controls.Add(Me.GunaLabel2)
        Me.PanelContenedor.Controls.Add(Me.PanelBarraTitulo)
        Me.PanelContenedor.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelContenedor.Location = New System.Drawing.Point(0, 0)
        Me.PanelContenedor.Name = "PanelContenedor"
        Me.PanelContenedor.Size = New System.Drawing.Size(641, 183)
        Me.PanelContenedor.TabIndex = 0
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.DataGridView2.Location = New System.Drawing.Point(320, 217)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(237, 240)
        Me.DataGridView2.TabIndex = 231
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "Column1"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "Column2"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.DataGridView1.Location = New System.Drawing.Point(62, 217)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(193, 240)
        Me.DataGridView1.TabIndex = 232
        '
        'Column1
        '
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Column2"
        Me.Column2.Name = "Column2"
        '
        'LbRuta
        '
        Me.LbRuta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbRuta.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbRuta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.LbRuta.Location = New System.Drawing.Point(187, 157)
        Me.LbRuta.Name = "LbRuta"
        Me.LbRuta.Size = New System.Drawing.Size(442, 16)
        Me.LbRuta.TabIndex = 227
        Me.LbRuta.Text = "Ruta del archivo solicitado:"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.ForeColor = System.Drawing.Color.SteelBlue
        Me.GunaLabel4.Location = New System.Drawing.Point(15, 157)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(166, 16)
        Me.GunaLabel4.TabIndex = 226
        Me.GunaLabel4.Text = "Ruta del archivo solicitado:"
        '
        'TxtInforme
        '
        Me.TxtInforme.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtInforme.BaseColor = System.Drawing.Color.White
        Me.TxtInforme.BorderColor = System.Drawing.Color.Silver
        Me.TxtInforme.BorderSize = 1
        Me.TxtInforme.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtInforme.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtInforme.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TxtInforme.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtInforme.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtInforme.Location = New System.Drawing.Point(338, 117)
        Me.TxtInforme.Name = "TxtInforme"
        Me.TxtInforme.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtInforme.Size = New System.Drawing.Size(155, 26)
        Me.TxtInforme.TabIndex = 225
        '
        'GunaLabel3
        '
        Me.GunaLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(264, 120)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(68, 18)
        Me.GunaLabel3.TabIndex = 224
        Me.GunaLabel3.Text = "Informe:"
        '
        'TxtMagnitud
        '
        Me.TxtMagnitud.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TxtMagnitud.BaseColor = System.Drawing.Color.White
        Me.TxtMagnitud.BorderColor = System.Drawing.Color.Silver
        Me.TxtMagnitud.BorderSize = 1
        Me.TxtMagnitud.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TxtMagnitud.FocusedBaseColor = System.Drawing.Color.White
        Me.TxtMagnitud.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(31, Byte), Integer), CType(CType(212, Byte), Integer), CType(CType(175, Byte), Integer))
        Me.TxtMagnitud.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.TxtMagnitud.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TxtMagnitud.Location = New System.Drawing.Point(103, 117)
        Me.TxtMagnitud.Name = "TxtMagnitud"
        Me.TxtMagnitud.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.TxtMagnitud.Size = New System.Drawing.Size(155, 26)
        Me.TxtMagnitud.TabIndex = 223
        '
        'LbModelo
        '
        Me.LbModelo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LbModelo.AutoSize = True
        Me.LbModelo.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LbModelo.Location = New System.Drawing.Point(15, 120)
        Me.LbModelo.Name = "LbModelo"
        Me.LbModelo.Size = New System.Drawing.Size(82, 18)
        Me.LbModelo.TabIndex = 222
        Me.LbModelo.Text = "Magnitud:"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(87, 88)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(111, 18)
        Me.Label26.TabIndex = 169
        Me.Label26.Text = "Ingresa los datos"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.BackColor = System.Drawing.Color.Transparent
        Me.GunaLabel2.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.ForeColor = System.Drawing.Color.ForestGreen
        Me.GunaLabel2.Location = New System.Drawing.Point(84, 56)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(140, 30)
        Me.GunaLabel2.TabIndex = 167
        Me.GunaLabel2.Text = "ETL Servicios"
        '
        'PanelBarraTitulo
        '
        Me.PanelBarraTitulo.BackColor = System.Drawing.Color.White
        Me.PanelBarraTitulo.Controls.Add(Me.GunaLabel1)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaPictureBox2)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnCerrar)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaVSeparator1)
        Me.PanelBarraTitulo.Controls.Add(Me.BtnMinimizar)
        Me.PanelBarraTitulo.Controls.Add(Me.GunaImageButton4)
        Me.PanelBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelBarraTitulo.Location = New System.Drawing.Point(0, 0)
        Me.PanelBarraTitulo.Name = "PanelBarraTitulo"
        Me.PanelBarraTitulo.Size = New System.Drawing.Size(641, 50)
        Me.PanelBarraTitulo.TabIndex = 5
        '
        'GunaLabel1
        '
        Me.GunaLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.ForeColor = System.Drawing.Color.Gainsboro
        Me.GunaLabel1.Location = New System.Drawing.Point(53, 17)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(129, 20)
        Me.GunaLabel1.TabIndex = 11
        Me.GunaLabel1.Text = "Servicios a Excel"
        '
        'lbVersion
        '
        Me.lbVersion.AutoSize = True
        Me.lbVersion.Font = New System.Drawing.Font("Century Gothic", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbVersion.ForeColor = System.Drawing.Color.Black
        Me.lbVersion.Location = New System.Drawing.Point(-264, 89)
        Me.lbVersion.Name = "lbVersion"
        Me.lbVersion.Size = New System.Drawing.Size(53, 20)
        Me.lbVersion.TabIndex = 10
        Me.lbVersion.Text = "1.0.0.0"
        '
        'GunaVSeparator1
        '
        Me.GunaVSeparator1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaVSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.GunaVSeparator1.LineColor = System.Drawing.Color.WhiteSmoke
        Me.GunaVSeparator1.Location = New System.Drawing.Point(548, 12)
        Me.GunaVSeparator1.Name = "GunaVSeparator1"
        Me.GunaVSeparator1.Size = New System.Drawing.Size(10, 25)
        Me.GunaVSeparator1.TabIndex = 3
        '
        'GunaImageButton4
        '
        Me.GunaImageButton4.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton4.Image = Nothing
        Me.GunaImageButton4.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton4.Location = New System.Drawing.Point(8, 8)
        Me.GunaImageButton4.Name = "GunaImageButton4"
        Me.GunaImageButton4.OnHoverImage = Nothing
        Me.GunaImageButton4.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.GunaImageButton4.Size = New System.Drawing.Size(32, 32)
        Me.GunaImageButton4.TabIndex = 0
        '
        'BtnCargar
        '
        Me.BtnCargar.AnimationHoverSpeed = 0.07!
        Me.BtnCargar.AnimationSpeed = 0.03!
        Me.BtnCargar.BackColor = System.Drawing.Color.Transparent
        Me.BtnCargar.BaseColor = System.Drawing.Color.SteelBlue
        Me.BtnCargar.BorderColor = System.Drawing.Color.Black
        Me.BtnCargar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCargar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnCargar.FocusedColor = System.Drawing.Color.Empty
        Me.BtnCargar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.BtnCargar.ForeColor = System.Drawing.Color.White
        Me.BtnCargar.Image = Global.ServiciosExcel.My.Resources.Resources.icons8_submit_progress_28
        Me.BtnCargar.ImageSize = New System.Drawing.Size(20, 20)
        Me.BtnCargar.Location = New System.Drawing.Point(422, 58)
        Me.BtnCargar.Name = "BtnCargar"
        Me.BtnCargar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(70, Byte), Integer), CType(CType(115, Byte), Integer), CType(CType(170, Byte), Integer))
        Me.BtnCargar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.BtnCargar.OnHoverForeColor = System.Drawing.Color.White
        Me.BtnCargar.OnHoverImage = Nothing
        Me.BtnCargar.OnPressedColor = System.Drawing.Color.Black
        Me.BtnCargar.Radius = 3
        Me.BtnCargar.Size = New System.Drawing.Size(209, 28)
        Me.BtnCargar.TabIndex = 230
        Me.BtnCargar.Text = "Cargar lista por primera vez"
        '
        'btnGuardar
        '
        Me.btnGuardar.AnimationHoverSpeed = 0.07!
        Me.btnGuardar.AnimationSpeed = 0.03!
        Me.btnGuardar.BackColor = System.Drawing.Color.Transparent
        Me.btnGuardar.BaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(175, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnGuardar.BorderColor = System.Drawing.Color.Black
        Me.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnGuardar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnGuardar.FocusedColor = System.Drawing.Color.Empty
        Me.btnGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.btnGuardar.ForeColor = System.Drawing.Color.White
        Me.btnGuardar.Image = Global.ServiciosExcel.My.Resources.Resources.icons8_export_csv_28
        Me.btnGuardar.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnGuardar.Location = New System.Drawing.Point(277, 58)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.OnHoverBaseColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(160, Byte), Integer), CType(CType(130, Byte), Integer))
        Me.btnGuardar.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnGuardar.OnHoverForeColor = System.Drawing.Color.White
        Me.btnGuardar.OnHoverImage = Nothing
        Me.btnGuardar.OnPressedColor = System.Drawing.Color.Black
        Me.btnGuardar.Radius = 3
        Me.btnGuardar.Size = New System.Drawing.Size(139, 28)
        Me.btnGuardar.TabIndex = 221
        Me.btnGuardar.Text = "Exportar a Excel"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 56)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(66, 50)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 168
        Me.PictureBox1.TabStop = False
        '
        'GunaPictureBox2
        '
        Me.GunaPictureBox2.BaseColor = System.Drawing.Color.White
        Me.GunaPictureBox2.Image = Global.ServiciosExcel.My.Resources.Resources.icons8_microsoft_excel_48
        Me.GunaPictureBox2.Location = New System.Drawing.Point(12, 8)
        Me.GunaPictureBox2.Name = "GunaPictureBox2"
        Me.GunaPictureBox2.Size = New System.Drawing.Size(32, 32)
        Me.GunaPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GunaPictureBox2.TabIndex = 9
        Me.GunaPictureBox2.TabStop = False
        '
        'BtnCerrar
        '
        Me.BtnCerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnCerrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnCerrar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnCerrar.Image = Global.ServiciosExcel.My.Resources.Resources.icons8_multiply_48
        Me.BtnCerrar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnCerrar.Location = New System.Drawing.Point(602, 8)
        Me.BtnCerrar.Name = "BtnCerrar"
        Me.BtnCerrar.OnHoverImage = Nothing
        Me.BtnCerrar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.BtnCerrar.Size = New System.Drawing.Size(32, 32)
        Me.BtnCerrar.TabIndex = 7
        '
        'BtnMinimizar
        '
        Me.BtnMinimizar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnMinimizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnMinimizar.DialogResult = System.Windows.Forms.DialogResult.None
        Me.BtnMinimizar.Image = Global.ServiciosExcel.My.Resources.Resources.icons8_horizontal_line_48
        Me.BtnMinimizar.ImageSize = New System.Drawing.Size(16, 16)
        Me.BtnMinimizar.Location = New System.Drawing.Point(564, 8)
        Me.BtnMinimizar.Name = "BtnMinimizar"
        Me.BtnMinimizar.OnHoverImage = Nothing
        Me.BtnMinimizar.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.BtnMinimizar.Size = New System.Drawing.Size(32, 32)
        Me.BtnMinimizar.TabIndex = 1
        '
        'GunaImageButton1
        '
        Me.GunaImageButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GunaImageButton1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.GunaImageButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaImageButton1.Image = Global.ServiciosExcel.My.Resources.Resources.icons8_attach_28
        Me.GunaImageButton1.ImageSize = New System.Drawing.Size(16, 16)
        Me.GunaImageButton1.Location = New System.Drawing.Point(508, 111)
        Me.GunaImageButton1.Name = "GunaImageButton1"
        Me.GunaImageButton1.OnHoverImage = Nothing
        Me.GunaImageButton1.OnHoverImageOffset = New System.Drawing.Point(0, -1)
        Me.GunaImageButton1.Size = New System.Drawing.Size(32, 32)
        Me.GunaImageButton1.TabIndex = 233
        '
        'FrmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(641, 183)
        Me.Controls.Add(Me.PanelContenedor)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FrmInicio"
        Me.Text = "Inicio"
        Me.PanelContenedor.ResumeLayout(False)
        Me.PanelContenedor.PerformLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelBarraTitulo.ResumeLayout(False)
        Me.PanelBarraTitulo.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GunaPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GunaElipse1 As Guna.UI.WinForms.GunaElipse
    Friend WithEvents PanelContenedor As Panel
    Friend WithEvents PanelBarraTitulo As Guna.UI.WinForms.GunaPanel
    Friend WithEvents lbVersion As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaPictureBox2 As Guna.UI.WinForms.GunaPictureBox
    Friend WithEvents BtnCerrar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaVSeparator1 As Guna.UI.WinForms.GunaVSeparator
    Friend WithEvents BtnMinimizar As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaImageButton4 As Guna.UI.WinForms.GunaImageButton
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label26 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnGuardar As Guna.UI.WinForms.GunaButton
    Friend WithEvents LbRuta As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtInforme As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents TxtMagnitud As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents LbModelo As Guna.UI.WinForms.GunaLabel
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents BtnCargar As Guna.UI.WinForms.GunaButton
    Friend WithEvents GunaImageButton1 As Guna.UI.WinForms.GunaImageButton
End Class
