Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Runtime.CompilerServices
Imports Microsoft.Win32
Imports Produccion.My

Public Class Verificador
    Delegate Sub dlgTimerEnable(ByRef tmr As Timer, ByVal enable As Boolean) ', ByVal start As Boolean, ByVal [stop] As Boolean)
    Delegate Sub SetTextCallback(ByRef texto As ToolStripStatusLabel, ByVal [text] As String) 'Added to prevent threading errors during receiveing of data

    Private Sub TimerEnable(ByRef tmr As Timer, ByVal enable As Boolean) ', ByVal start As Boolean, ByVal [stop] As Boolean)
        tmr.Enabled = enable
        'If [stop] Then tmr.Stop()
        'If start Then tmr.Start()
    End Sub

    Private Sub SetTexto(ByRef tssl As ToolStripStatusLabel, ByVal [text] As String)
        tssl.Text = [text]
    End Sub

    Private Sub LecturaCajas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            TxtCodSKU.Text = VGSCodSKU

            textTOn.Text = CInt(My.MySettings.Default.var_INTERVALOTIEMPO)
            TextBoxINTERVAL.Text = CInt(My.MySettings.Default.var_INTERVAL)
            TextTOff.Text = CInt(My.MySettings.Default.var_TOFF)
            TextTOut.Text = CInt(My.MySettings.Default.var_TOUT)

            lblcInvalidas.Text = 0
            lblcValidas.Text = 0

            Me.ActiveControl = Me.Controls(4)

            TxtSerial.Select()

            'TimerTagValidator.Start()
            'AddHandler TimerTagValidator.Tick, AddressOf TimerTagValidator_Tick

            SerialPortModuloIO.Open()

        Catch ex As Exception : MsgBox(ex.Message)
            MessageBox.Show("Error al acceder al Puerto Serial: " & ex.Message)
        End Try

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        'SetBeep(False)
        Me.Close()
    End Sub

    Private Sub Set_Timer(Interval As Integer)
        For i = 1 To Interval
            Threading.Thread.Sleep(100)
            Application.DoEvents()
        Next
    End Sub

    Private Sub TxtSerial_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TxtSerial.TextChanged

        TimerTagValidator.Stop()

        Try
            Dim VLScodSku As String
            VLScodSku = TxtSerial.Text()

            If VLScodSku <> "" Then

                If Len(VLScodSku) = 13 Then
                    TxtSerial.Text = Mid(VLScodSku, 1, Len(VLScodSku))
                    If ValidaProducto() Then
                        lblcValidas.Text = CInt(lblcValidas.Text) + 1
                        SerialPortModuloIO.Write(15)

                    Else
                        Set_Timer(CInt(textTOn.Text))
                        SerialPortModuloIO.Write(7)
                        Set_Timer(CInt(TextTOff.Text))
                        SerialPortModuloIO.Write(15)
                        lblcInvalidas.Text = CInt(lblcInvalidas.Text) + 1

                    End If
                    TxtSerial.Text = ""
                    TxtSerial.Focus()
                End If
            End If
            TxtNoCajas.Text = (CInt(lblcInvalidas.Text) + CInt(lblcValidas.Text)).ToString()

        Catch ex As Exception
            MessageBox.Show("Error del Lector: " & ex.Message)
        End Try
    End Sub

    Function ValidaProducto() As Boolean
        ValidaProducto = True
        If Not (Trim(VGSCodSKU) = Trim(TxtSerial.Text)) Then ValidaProducto = False

    End Function


    Private Sub LecturaCajas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing

        TimerTagValidator.Stop()

    End Sub

    Private Sub btnActualizar_Click(sender As Object, e As EventArgs) Handles btnActualizar.Click
        Try
            My.MySettings.Default.var_INTERVALOTIEMPO = textTOn.Text
            My.MySettings.Default.var_TOFF = TextTOff.Text
            My.MySettings.Default.var_TOUT = TextTOut.Text
            My.MySettings.Default.var_INTERVAL = TextBoxINTERVAL.Text

            TimerTagValidator.Interval = TextBoxINTERVAL.Text


            My.Settings.Save()
            My.Settings.Reload()

        Catch ex As Exception
            MessageBox.Show("Error al actualizar" & ex.Message)
        End Try

    End Sub

    Private Sub TimerTagValidator_Tick(sender As Object, e As EventArgs) Handles TimerTagValidator.Tick
        'TextBoxTestigo.Text = TextBoxTestigo.Text + 1
        'tsElapsedTime.Text = TextBoxTestigo.Text
        tsElapsedTime.Text = CInt(tsElapsedTime.Text) + 1

        If (CInt(tsElapsedTime.Text) > CInt(TextTOut.Text)) Then
            TimerTagValidator.Stop()
            tsElapsedTime.Text = 0
            Eject()
        End If

    End Sub

    Private Sub Eject()
        Set_Timer(CInt(textTOn.Text))
        SerialPortModuloIO.Write(7)
        Set_Timer(CInt(TextTOff.Text))
        SerialPortModuloIO.Write(15)

        lblcInvalidas.Text = CInt(lblcInvalidas.Text) + 1

    End Sub

    Private Sub Verificador_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If SerialPortModuloIO.IsOpen Then
            SerialPortModuloIO.Close()
        End If
    End Sub

    Private Sub Verificador_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If SerialPortModuloIO.IsOpen Then
            ToolStripStatusLabel1.Text = "Conectado"
            ToolStripStatusLabel1.BackColor = Color.DarkGreen
        Else
            ToolStripStatusLabel1.Text = "No Conectado"
            ToolStripStatusLabel1.BackColor = Color.DarkRed
        End If
    End Sub


    Private Sub ReceivedText(ByVal [text] As String) 'input from ReadExisting

        Dim inputs As String, value As Byte


        inputs = [text].Substring(0, 1).Replace(ControlChars.Cr, "").Replace(ControlChars.Lf, "")

        If inputs.Length = 1 And Not String.IsNullOrEmpty(inputs) Then ' <> vbLf And inputs <> vbCr Then
            Try
                value = Convert.ToByte(inputs, 16)
                ToolStripStatusLabel2.Text = value '[text]

                If ((value And 8) = 8) Then
                    Label_I1.ImageIndex = 0
                    If TimerTagValidator.Enabled Then
                        Me.Invoke(New dlgTimerEnable(AddressOf TimerEnable), New Object() {TimerTagValidator, False})
                    End If
                Else
                    Label_I1.ImageIndex = 1
                    If Not TimerTagValidator.Enabled Then
                        Me.Invoke(New dlgTimerEnable(AddressOf TimerEnable), New Object() {TimerTagValidator, True})
                        Me.Invoke(New SetTextCallback(AddressOf SetTexto), New Object() {tsElapsedTime, "0"})
                    End If
                End If

                If ((value And 4) = 4) Then
                    Label_I2.ImageIndex = 0
                Else
                    Label_I2.ImageIndex = 1
                End If

                If ((value And 2) = 2) Then
                    Label_I3.ImageIndex = 0
                Else
                    Label_I3.ImageIndex = 1
                End If

                If ((value And 1) = 1) Then
                    Label_I4.ImageIndex = 0
                Else
                    Label_I4.ImageIndex = 1
                End If

            Catch ex As Exception
                Console.WriteLine("input: ", inputs)
                MessageBox.Show("Error I/O: " & ex.Message)
            End Try
        End If



    End Sub

    Private Sub SerialPortModuloIO_DataReceived(sender As Object, e As IO.Ports.SerialDataReceivedEventArgs) Handles SerialPortModuloIO.DataReceived
        ReceivedText(SerialPortModuloIO.ReadExisting())
    End Sub

End Class
