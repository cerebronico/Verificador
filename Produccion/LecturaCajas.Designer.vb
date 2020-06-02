<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Verificador
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Verificador))
        Me.BtnSalir = New System.Windows.Forms.Button()
        Me.TxtCodSKU = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtNoCajas = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtSerial = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnActualizar = New System.Windows.Forms.Button()
        Me.TextBoxINTERVAL = New System.Windows.Forms.TextBox()
        Me.TextTOut = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextTOff = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.textTOn = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblcInvalidas = New System.Windows.Forms.Label()
        Me.lblcValidas = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label_I1 = New System.Windows.Forms.Label()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Label_I3 = New System.Windows.Forms.Label()
        Me.Label_I4 = New System.Windows.Forms.Label()
        Me.Label_I2 = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TimerTagValidator = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tsElapsedTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.SerialPortModuloIO = New System.IO.Ports.SerialPort(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnSalir
        '
        Me.BtnSalir.BackColor = System.Drawing.Color.Red
        Me.BtnSalir.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSalir.ForeColor = System.Drawing.Color.White
        Me.BtnSalir.Location = New System.Drawing.Point(278, 262)
        Me.BtnSalir.Name = "BtnSalir"
        Me.BtnSalir.Size = New System.Drawing.Size(95, 38)
        Me.BtnSalir.TabIndex = 0
        Me.BtnSalir.Text = "Salir"
        Me.BtnSalir.UseVisualStyleBackColor = False
        '
        'TxtCodSKU
        '
        Me.TxtCodSKU.Enabled = False
        Me.TxtCodSKU.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtCodSKU.Location = New System.Drawing.Point(105, 14)
        Me.TxtCodSKU.Name = "TxtCodSKU"
        Me.TxtCodSKU.Size = New System.Drawing.Size(266, 38)
        Me.TxtCodSKU.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(32, 23)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 25)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "SKU:"
        '
        'TxtNoCajas
        '
        Me.TxtNoCajas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TxtNoCajas.Enabled = False
        Me.TxtNoCajas.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNoCajas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.TxtNoCajas.Location = New System.Drawing.Point(100, 67)
        Me.TxtNoCajas.Name = "TxtNoCajas"
        Me.TxtNoCajas.Size = New System.Drawing.Size(73, 23)
        Me.TxtNoCajas.TabIndex = 10
        Me.TxtNoCajas.Text = "0"
        Me.TxtNoCajas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(52, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(44, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Validas:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 67)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 25)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Lector:"
        '
        'TxtSerial
        '
        Me.TxtSerial.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtSerial.Location = New System.Drawing.Point(105, 58)
        Me.TxtSerial.Name = "TxtSerial"
        Me.TxtSerial.Size = New System.Drawing.Size(266, 38)
        Me.TxtSerial.TabIndex = 7
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btnActualizar)
        Me.GroupBox1.Controls.Add(Me.TextBoxINTERVAL)
        Me.GroupBox1.Controls.Add(Me.TextTOut)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextTOff)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.textTOn)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(21, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(233, 105)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Parámetros"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 79)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 13)
        Me.Label7.TabIndex = 5
        Me.Label7.Text = "Tiempo en 1/10 segundos"
        '
        'btnActualizar
        '
        Me.btnActualizar.Location = New System.Drawing.Point(148, 71)
        Me.btnActualizar.Name = "btnActualizar"
        Me.btnActualizar.Size = New System.Drawing.Size(75, 26)
        Me.btnActualizar.TabIndex = 4
        Me.btnActualizar.Text = "Actualizar"
        Me.btnActualizar.UseVisualStyleBackColor = True
        '
        'TextBoxINTERVAL
        '
        Me.TextBoxINTERVAL.Location = New System.Drawing.Point(174, 45)
        Me.TextBoxINTERVAL.Name = "TextBoxINTERVAL"
        Me.TextBoxINTERVAL.Size = New System.Drawing.Size(49, 20)
        Me.TextBoxINTERVAL.TabIndex = 2
        Me.TextBoxINTERVAL.Text = "50"
        Me.TextBoxINTERVAL.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextBoxINTERVAL, "Resolución del Temporizador")
        '
        'TextTOut
        '
        Me.TextTOut.Location = New System.Drawing.Point(50, 45)
        Me.TextTOut.Name = "TextTOut"
        Me.TextTOut.Size = New System.Drawing.Size(49, 20)
        Me.TextTOut.TabIndex = 2
        Me.TextTOut.Text = "0"
        Me.TextTOut.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextTOut, "Tiempo máximo de detección de código")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(113, 48)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "INTERVAL"
        '
        'TextTOff
        '
        Me.TextTOff.Location = New System.Drawing.Point(174, 19)
        Me.TextTOff.Name = "TextTOff"
        Me.TextTOff.Size = New System.Drawing.Size(49, 20)
        Me.TextTOff.TabIndex = 2
        Me.TextTOff.Text = "0"
        Me.TextTOff.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.TextTOff, "Tiempo de permanencia activa del empujador")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 48)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(40, 13)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "T OUT"
        '
        'textTOn
        '
        Me.textTOn.Location = New System.Drawing.Point(50, 19)
        Me.textTOn.Name = "textTOn"
        Me.textTOn.Size = New System.Drawing.Size(49, 20)
        Me.textTOn.TabIndex = 2
        Me.textTOn.Text = "0"
        Me.textTOn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.ToolTip1.SetToolTip(Me.textTOn, "Tiempo de espera para expulsar la caja")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(136, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "T OFF"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "T ON"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblcInvalidas)
        Me.GroupBox2.Controls.Add(Me.lblcValidas)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.TxtNoCajas)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(21, 102)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 100)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Cajas"
        '
        'lblcInvalidas
        '
        Me.lblcInvalidas.AutoSize = True
        Me.lblcInvalidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcInvalidas.Location = New System.Drawing.Point(160, 47)
        Me.lblcInvalidas.Name = "lblcInvalidas"
        Me.lblcInvalidas.Size = New System.Drawing.Size(16, 16)
        Me.lblcInvalidas.TabIndex = 14
        Me.lblcInvalidas.Text = "0"
        '
        'lblcValidas
        '
        Me.lblcValidas.AutoSize = True
        Me.lblcValidas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcValidas.Location = New System.Drawing.Point(160, 21)
        Me.lblcValidas.Name = "lblcValidas"
        Me.lblcValidas.Size = New System.Drawing.Size(16, 16)
        Me.lblcValidas.TabIndex = 13
        Me.lblcValidas.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(52, 77)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "TOTAL"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(52, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Invalidas:"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox3.Controls.Add(Me.Label_I1)
        Me.GroupBox3.Controls.Add(Me.Label_I3)
        Me.GroupBox3.Controls.Add(Me.Label_I4)
        Me.GroupBox3.Controls.Add(Me.Label_I2)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.ForeColor = System.Drawing.Color.White
        Me.GroupBox3.Location = New System.Drawing.Point(278, 103)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 145)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Módulo E/S"
        '
        'Label_I1
        '
        Me.Label_I1.AutoSize = True
        Me.Label_I1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_I1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label_I1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_I1.ForeColor = System.Drawing.Color.White
        Me.Label_I1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_I1.ImageIndex = 0
        Me.Label_I1.ImageList = Me.ImageList1
        Me.Label_I1.Location = New System.Drawing.Point(22, 25)
        Me.Label_I1.Name = "Label_I1"
        Me.Label_I1.Size = New System.Drawing.Size(52, 26)
        Me.Label_I1.TabIndex = 23
        Me.Label_I1.Text = "    I1"
        Me.Label_I1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Verde_f01.gif")
        Me.ImageList1.Images.SetKeyName(1, "Verde_f02.gif")
        Me.ImageList1.Images.SetKeyName(2, "Rojo_f01.gif")
        Me.ImageList1.Images.SetKeyName(3, "Rojo_f02.gif")
        '
        'Label_I3
        '
        Me.Label_I3.AutoSize = True
        Me.Label_I3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_I3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_I3.ForeColor = System.Drawing.Color.White
        Me.Label_I3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_I3.ImageIndex = 0
        Me.Label_I3.ImageList = Me.ImageList1
        Me.Label_I3.Location = New System.Drawing.Point(22, 81)
        Me.Label_I3.Name = "Label_I3"
        Me.Label_I3.Size = New System.Drawing.Size(50, 24)
        Me.Label_I3.TabIndex = 21
        Me.Label_I3.Text = "    I3"
        Me.Label_I3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_I4
        '
        Me.Label_I4.AutoSize = True
        Me.Label_I4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_I4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_I4.ForeColor = System.Drawing.Color.White
        Me.Label_I4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_I4.ImageIndex = 0
        Me.Label_I4.ImageList = Me.ImageList1
        Me.Label_I4.Location = New System.Drawing.Point(22, 109)
        Me.Label_I4.Name = "Label_I4"
        Me.Label_I4.Size = New System.Drawing.Size(50, 24)
        Me.Label_I4.TabIndex = 20
        Me.Label_I4.Text = "    I4"
        Me.Label_I4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label_I2
        '
        Me.Label_I2.AutoSize = True
        Me.Label_I2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label_I2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_I2.ForeColor = System.Drawing.Color.White
        Me.Label_I2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label_I2.ImageIndex = 0
        Me.Label_I2.ImageList = Me.ImageList1
        Me.Label_I2.Location = New System.Drawing.Point(22, 53)
        Me.Label_I2.Name = "Label_I2"
        Me.Label_I2.Size = New System.Drawing.Size(50, 24)
        Me.Label_I2.TabIndex = 22
        Me.Label_I2.Text = "    I2"
        Me.Label_I2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'TimerTagValidator
        '
        Me.TimerTagValidator.Interval = 50
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.tsElapsedTime})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 316)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(391, 22)
        Me.StatusStrip1.TabIndex = 19
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.Red
        Me.ToolStripStatusLabel1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripStatusLabel1.ForeColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(85, 17)
        Me.ToolStripStatusLabel1.Text = "No Conectado"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.AutoSize = False
        Me.ToolStripStatusLabel2.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(50, 17)
        Me.ToolStripStatusLabel2.Text = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tsElapsedTime
        '
        Me.tsElapsedTime.AutoSize = False
        Me.tsElapsedTime.Margin = New System.Windows.Forms.Padding(5, 3, 0, 2)
        Me.tsElapsedTime.Name = "tsElapsedTime"
        Me.tsElapsedTime.Size = New System.Drawing.Size(50, 17)
        Me.tsElapsedTime.Text = "0"
        Me.tsElapsedTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'SerialPortModuloIO
        '
        Me.SerialPortModuloIO.BaudRate = 115200
        Me.SerialPortModuloIO.PortName = "COM5"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutomaticDelay = 200
        '
        'Verificador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(391, 338)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSerial)
        Me.Controls.Add(Me.TxtCodSKU)
        Me.Controls.Add(Me.BtnSalir)
        Me.Controls.Add(Me.GroupBox3)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Verificador"
        Me.Text = "Verificador de Códigos"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnSalir As System.Windows.Forms.Button
    Friend WithEvents TxtCodSKU As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TxtNoCajas As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TxtSerial As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnActualizar As Button
    Friend WithEvents textTOn As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents lblcInvalidas As Label
    Friend WithEvents lblcValidas As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents TimerTagValidator As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents SerialPortModuloIO As IO.Ports.SerialPort
    Friend WithEvents Label_I1 As Label
    Friend WithEvents Label_I3 As Label
    Friend WithEvents Label_I4 As Label
    Friend WithEvents Label_I2 As Label
    Friend WithEvents TextTOff As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents TextTOut As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxINTERVAL As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents tsElapsedTime As ToolStripStatusLabel
End Class
