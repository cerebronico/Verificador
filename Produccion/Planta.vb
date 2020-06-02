Imports System.Data.SqlClient

Public Class Planta

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub BtnAceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAceptar.Click

        Dim LecturaCajas As New Verificador
        VGSCodSKU = TxtCodSku.Text
        LecturaCajas.ShowDialog()

    End Sub

    Private Sub Planta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.Controls(4)
    End Sub
End Class