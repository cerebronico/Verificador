Imports System.Data.SqlClient

Public Class Ingreso
    Private Sub BtnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnIngreso.Click
        Dim xPlanta As New Planta

        Try
            xPlanta.ShowDialog()
        Catch ex As Exception : MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub BtnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSalir.Click
        Me.Close()
    End Sub

    Private Sub Ingreso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.ActiveControl = Me.Controls(2)
    End Sub
End Class
