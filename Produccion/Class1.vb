Public Class Class1

    Private WithEvents xTimer As New System.Windows.Forms.Timer

        Public Sub New(TickValue As Integer)
            xTimer = New System.Windows.Forms.Timer
            xTimer.Interval = TickValue
        End Sub

        Public Sub StartTimer()
            xTimer.Start()
        End Sub

        Public Sub StopTimer()
            xTimer.Stop()
        End Sub

        Private Sub Timer_Tick() Handles xTimer.Tick
            Console.WriteLine("ticked")

        End Sub


End Class
