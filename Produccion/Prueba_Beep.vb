Imports System
Imports System.Windows.Forms
Imports IAHAL
Imports System.Collections

' Digital input and output example
' --------------------------------
' 
' This example shows how simple it is to get the state of a device digital input, 
' and how simple it is to set the state of digital output/relays state
' 
' In this example we first attempt to detect connected devices and then populate a 
' combobox list with name of those available.
' After selecting a device we pass a BitArray object to the ReadDI and WriteDO methods of an IADevice object * 

Public Class Prueba_Beep
    Dim iadevs As IADevices = New IADevices()
    Dim iaSelectedDevice As IADevice
    Dim chkBoxes(15) As CheckBox
    Dim chkBoxesOut(15) As CheckBox

    Private Sub initCheckBoxes()

        '1st byte
        chkBoxes(0) = chk1
        chkBoxes(1) = chk2
        chkBoxes(2) = chk3
        chkBoxes(3) = chk4
        chkBoxes(4) = chk5
        chkBoxes(5) = chk6
        chkBoxes(6) = chk7
        chkBoxes(7) = chk8
        '2nd byte
        chkBoxes(8) = chk9
        chkBoxes(9) = chk10
        chkBoxes(10) = chk11
        chkBoxes(11) = chk12
        chkBoxes(12) = chk13
        chkBoxes(13) = chk14
        chkBoxes(14) = chk15
        chkBoxes(15) = chk16

        'out
        '1st byte
        chkBoxesOut(0) = chkO1
        chkBoxesOut(1) = chkO2
        chkBoxesOut(2) = chkO3
        chkBoxesOut(3) = chkO4
        chkBoxesOut(4) = chkO5
        chkBoxesOut(5) = chkO6
        chkBoxesOut(6) = chkO7
        chkBoxesOut(7) = chkO8
        '2nd byte
        chkBoxesOut(8) = chkO9
        chkBoxesOut(9) = chkO10
        chkBoxesOut(10) = chkO11
        chkBoxesOut(11) = chkO12
        chkBoxesOut(12) = chkO13
        chkBoxesOut(13) = chkO14
        chkBoxesOut(14) = chkO15
        chkBoxesOut(15) = chkO16
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim ec As IAError = IAError.IA_OK
        initCheckBoxes()

        ec = iadevs.DetectAllDevices()
        If ec <> IAError.IA_OK Then
            MessageBox.Show(iadevs.GetErrorMessage(ec))
        End If
        cmbDevices.DisplayMember = "Name"
        cmbDevices.ValueMember = "UniqueID"

        Dim dev As IADevice
        For Each dev In iadevs

            'get the first device with DI functions
            If dev.HasDigitalInput Or dev.HasDigitalOutput Then
                ' populate device combobox 
                cmbDevices.Items.Add(dev)
            End If
        Next
    End Sub

    Private Sub cmbDevices_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDevices.SelectedIndexChanged
        iaSelectedDevice = cmbDevices.SelectedItem
        setDisplay()
    End Sub

    Private Sub btnRead_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRead.Click
        Dim ba As BitArray = New BitArray(15)
        Dim iaErr As IAError
        Dim chCount As Integer
        Dim i As Integer
        If (iaSelectedDevice Is Nothing) Then

            MessageBox.Show("No valid device selected")
            Exit Sub
        End If

        chCount = iaSelectedDevice.getDIChannelCount()

        'limit to available checkboxes
        If (chCount > 16) Then chCount = 16

        'read value from hardware
        iaErr = iaSelectedDevice.ReadDI(ba)
        If (iaErr = IAError.IA_OK) Then
            For i = 0 To chCount - 1
                chkBoxes(i).Checked = ba(i)
            Next
        End If
    End Sub

    Private Sub btnWrite_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnWrite.Click
        Dim ba As BitArray = New BitArray(16)
        Dim iaErr As IAError
        Dim chCount As Integer
        Dim i As Integer
        If (iaSelectedDevice Is Nothing) Then

            MessageBox.Show("No valid device selected")
            Exit Sub
        End If



        chCount = iaSelectedDevice.getDOChannelCount

        'limit to available checkboxes
        If (chCount > 16) Then chCount = 16

        'read value from hardware

        For i = 0 To chCount - 1

            ba(i) = chkBoxesOut(i).Checked
        Next

        iaErr = iaSelectedDevice.WriteDO(ba)
        If (iaErr <> IAError.IA_OK) Then
            MessageBox.Show(iaErr.ToString())
        End If
    End Sub

    Private Sub setDisplay()
        If (iaSelectedDevice Is Nothing) = False Then

            grpDigitalInput.Visible = iaSelectedDevice.HasDigitalInput

            grpDigitalOutput.Visible = iaSelectedDevice.HasDigitalOutput
        End If
    End Sub

End Class
