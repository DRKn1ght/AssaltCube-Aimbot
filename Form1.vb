Imports System.Math
Public Class Form1
    Dim PlayerBase = ReadInteger("ac_client", Address:=&H509B74)
    Dim EnemyP1 As Integer = 0
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim PNum = ReadInteger("ac_client", Address:=&H50F500)

        'Informações do jogador
        Dim PlayerX = ReadFloat("ac_client", Address:=PlayerBase + &H4)
        Dim PlayerY = ReadFloat("ac_client", Address:=PlayerBase + &H8)
        Dim PlayerZ = ReadFloat("ac_client", Address:=PlayerBase + &HC)
        Dim MouseX = ReadFloat("ac_client", Address:=PlayerBase + &H40)
        Dim MouseY = ReadFloat("ac_client", Address:=PlayerBase + &H44)
        Dim HP = ReadInteger("ac_client", Address:=PlayerBase + &HF8)

        'Informações do inimigo
        Dim EnemyBase = ReadDMAInteger("ac_client", Address:=&H510D90, Offsets:={EnemyP1}, Level:=1)
        Dim EnemyX = ReadFloat("ac_client", Address:=EnemyBase + &H4)
        Dim EnemyY = ReadFloat("ac_client", Address:=EnemyBase + &H8)
        Dim EnemyZ = ReadFloat("ac_client", Address:=EnemyBase + &HC)
        Dim EnemyHP = ReadInteger("ac_client", Address:=EnemyBase + &HF8)


        'Distancia entre Player e Inimigo
        Dim Distance = Sqrt((EnemyX - PlayerX) ^ 2 + (EnemyY - PlayerY) ^ 2 + (EnemyZ - PlayerZ) ^ 2)

        'Angulo entre Player e Inimigo
        Dim AxB = PlayerX * EnemyX + PlayerY * EnemyY + PlayerZ * EnemyZ
        Dim A1 = Sqrt(PlayerX * PlayerX + PlayerY * PlayerY + PlayerZ * PlayerZ)
        Dim B1 = Sqrt(EnemyX * EnemyX + EnemyY * EnemyY + EnemyZ * EnemyZ)
        Dim deltaX = EnemyX - PlayerX
        Dim deltaY = PlayerY - EnemyY
        Dim deltaZ = EnemyZ - PlayerZ
        Dim Angle
        Dim Angle2
        If EnemyX > PlayerX And EnemyY < PlayerY Then
            Angle = Atan(deltaX / deltaY) * 180 / PI
        ElseIf EnemyX > PlayerX And EnemyY > PlayerY
            Angle = Atan(deltaX / deltaY) * 180 / PI + 180
        ElseIf EnemyX < PlayerX And EnemyY > PlayerY
            Angle = Atan(deltaX / deltaY) * 180 / PI - 180
        Else
            Angle = Atan(deltaX / deltaY) * 180 / PI + 360
        End If
        Angle2 = Asin(deltaZ / Distance) * 180 / PI

        PX.Text = PlayerX
        PY.Text = PlayerY
        PZ.Text = PlayerZ
        MX.Text = MouseX
        MY.Text = MouseY
        LIFE.Text = HP
        EX.Text = EnemyX
        EY.Text = EnemyY
        EZ.Text = EnemyZ
        ELIFE.Text = EnemyHP
        DIST.Text = Distance
        ANG.Text = Angle
        AngY.Text = Angle2
        PlayersNum.Text = PNum * 4 - 8
    End Sub
    <System.Runtime.InteropServices.DllImport("user32.dll")>
    Private Shared Function GetAsyncKeyState(ByVal vkey As System.Windows.Forms.Keys) As Short

    End Function
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim hotkey As Boolean


        hotkey = GetAsyncKeyState(Keys.LControlKey)


        If hotkey = True Then
            WriteFloat("ac_client", Address:=PlayerBase + &H40, Value:=ANG.Text)
            WriteFloat("ac_client", Address:=PlayerBase + &H44, Value:=AngY.Text)
        End If

    End Sub
    Private Declare Function GetDC Lib "user32" (ByVal hwnd As Integer) As Integer
    Private Declare Function InvalidateRect Lib "user32" (ByVal hwnd As IntPtr, ByVal lpRect As IntPtr, ByVal bErase As Boolean) As Boolean
    Private WithEvents myTimer As New Timer With {.Interval = 50, .Enabled = True}
    Private Sub drawOnDesktop()



        Dim HDC As Integer = GetDC(0)
        Dim myGraphics As Graphics = Graphics.FromHdc(HDC)
        Dim myPen As New Pen(Color.Chartreuse, 1) '// set pen color and width.
        ' myGraphics.DrawLine(myPen, SX, SY, 255, 255) '// (preset pen, startLocation.X, startLocation.Y, endLocation.X, endLocation.Y)

        '   myGraphics.DrawLine(myPen, 150, 355, 650, 355) '// (preset pen, startLocation.X, startLocation.Y, endLocation.X, endLocation.Y)
        '   myGraphics.Dispose()

    End Sub
    Private Sub myTimer_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        Me.drawOnDesktop()
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        EnemyP.Text = EnemyP1
        Dim tabkey As Boolean
        tabkey = GetAsyncKeyState(Keys.Tab)
        If tabkey = True Then
            If Not PlayersNum.Text <= 4 Then
                '    EnemyP1 = 0
                If EnemyP1 >= PlayersNum.Text Then
                    EnemyP1 = 0
                Else
                    EnemyP1 += 4
                End If
            End If

        End If
    End Sub
End Class
