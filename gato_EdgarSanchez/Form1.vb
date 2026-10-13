
Imports System.IO
Imports System.Numerics
Imports Windows.Win32.System
Imports System.Media
Imports System.Net

Public Class Form1
    Dim ga, j1, j2, v1, v2, v3, v4, v5, v6, v7, v8, v9 As String

    Dim turno As Integer
    Dim vsPC As Boolean = False

    Dim player As New SoundPlayer()

    Private Sub MusicaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MusicaToolStripMenuItem.Click
        If MusicaToolStripMenuItem.Checked = False Then
            MusicaToolStripMenuItem.Checked = True
            'My.Computer.Audio.Play(My.Resources.Resource1.musica, AudioPlayMode.BackgroundLoop)'
        Else
            MusicaToolStripMenuItem.Checked = False
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub SalirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SalirToolStripMenuItem.Click
        If MsgBox("Desea salir del programa", 36, "Exit...") = vbYes Then
            End
        End If
    End Sub

    Private Sub Version2JugadoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Version2JugadoresToolStripMenuItem.Click

        linea1.Visible = False
        linea2.Visible = False
        linea3.Visible = False
        linea4.Visible = False
        linea5.Visible = False
        linea6.Visible = False
        paneldiagonal1.Visible = False
        paneldiagonal2.Visible = False

        x1.Visible = False
        x2.Visible = False
        x3.Visible = False
        x4.Visible = False
        x5.Visible = False
        x6.Visible = False
        x7.Visible = False
        x8.Visible = False
        x9.Visible = False

        c1.Visible = False
        c2.Visible = False
        c3.Visible = False
        c4.Visible = False
        c5.Visible = False
        c6.Visible = False
        c7.Visible = False
        c8.Visible = False
        c9.Visible = False

        b1.Visible = True
        b2.Visible = True
        b3.Visible = True
        b4.Visible = True
        b4.Visible = True
        b5.Visible = True
        b6.Visible = True
        b7.Visible = True
        b8.Visible = True
        b9.Visible = True

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b9.Enabled = True

        v1 = ""
        v2 = ""
        v3 = ""
        v4 = ""
        v5 = ""
        v6 = ""
        v7 = ""
        v8 = ""
        v9 = ""

        j1 = ""
        j2 = ""
        ga = ""

        turno = 1

        Do
            j1 = InputBox("Ingrese nombre del primer jugador ", "j1")
            If Len(j1) >= 3 Then
            Else
                MsgBox("No acepta vacios y al menos debe ser de 3 letras", 16, "Error")
            End If
            Exit Do
        Loop While True

        Do
            j2 = InputBox("Ingrese nombre del segundo jugador ", "j2")
            If Len(j2) < 3 Then
                MsgBox("No acepta vacios y al menos debe ser de 3 letras", 16, "Error")
            End If
        Loop Until j2.Length >= 3

        Label2.Text = j1
    End Sub

    Private Sub B1_Click(sender As Object, e As EventArgs) Handles b1.Click
        b1.Visible = False
        If turno = 1 Then
            x1.Visible = True
            v1 = "X"
        Else
            c1.Visible = True
            v1 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()

        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Private Sub B2_Click(sender As Object, e As EventArgs) Handles b2.Click
        b2.Visible = False
        If turno = 1 Then
            x2.Visible = True
            v2 = "X"
        Else
            c2.Visible = True
            v2 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Sub Cambiar_turno()
        If ga = "" Then
            If turno = 1 Then
                turno = 2
                Label2.Text = j2
            Else
                turno = 1
                Label2.Text = j1
            End If
        End If
    End Sub

    Sub desabilitarbotones()
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False
        b9.Enabled = False

    End Sub
    Sub Checar_ganador()

        If v1 = "X" And v2 = "X" And v3 = "X" Then
            ga = j1
            linea1.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v4 = "X" And v5 = "X" And v6 = "X" Then
            ga = j1
            linea2.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v7 = "X" And v8 = "X" And v9 = "X" Then
            ga = j1
            linea3.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v1 = "X" And v4 = "X" And v7 = "X" Then
            ga = j1
            linea4.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v2 = "X" And v5 = "X" And v8 = "X" Then
            ga = j1
            linea5.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v3 = "X" And v6 = "X" And v9 = "X" Then
            ga = j1
            linea6.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v1 = "X" And v5 = "X" And v9 = "X" Then
            ga = j1
            paneldiagonal1.BringToFront()
            paneldiagonal1.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v3 = "X" And v5 = "X" And v7 = "X" Then
            ga = j1
            paneldiagonal2.BringToFront()
            paneldiagonal2.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        '=========================================================================='
        '================      validar los 0      ================================='

        If v1 = "0" And v2 = "0" And v3 = "0" Then
            ga = j2
            linea1.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v4 = "0" And v5 = "0" And v6 = "0" Then
            ga = j2
            linea2.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v7 = "0" And v8 = "0" And v9 = "0" Then
            ga = j2
            linea3.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v1 = "0" And v4 = "0" And v7 = "0" Then
            ga = j2
            linea4.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v2 = "0" And v5 = "0" And v8 = "0" Then
            ga = j2
            linea5.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v3 = "0" And v6 = "0" And v9 = "0" Then
            ga = j2
            linea6.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v1 = "0" And v5 = "0" And v9 = "0" Then
            ga = j2
            paneldiagonal1.BringToFront()
            paneldiagonal1.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        If v3 = "0" And v5 = "0" And v7 = "0" Then
            ga = j2
            paneldiagonal2.BringToFront()
            paneldiagonal2.Visible = True
            desabilitarbotones()
            MsgBox("Gano " & ga, 64, "You won...")
            Exit Sub
        End If

        '========================================================='
        '====================validacion de empate'

        If ga = "" And v1 <> "" And v2 <> "" And v3 <> "" And v4 <> "" And v5 <> "" And v6 <> "" And v7 <> "" And v8 <> "" And v9 <> "" Then

            ga = "Gato"
            MsgBox("Gano " & ga, 48, "Empate.....")

        End If


    End Sub

    Sub Desactivar_botones()
        b1.Enabled = False
        b2.Enabled = False
        b3.Enabled = False
        b4.Enabled = False
        b5.Enabled = False
        b6.Enabled = False
        b7.Enabled = False
        b8.Enabled = False
        b9.Enabled = False
    End Sub

    Private Sub B3_Click(sender As Object, e As EventArgs) Handles b3.Click
        b3.Visible = False
        If turno = 1 Then
            x3.Visible = True
            v3 = "X"
        Else
            c3.Visible = True
            v3 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Private Sub B4_Click(sender As Object, e As EventArgs) Handles b4.Click
        b4.Visible = False
        If turno = 1 Then
            x4.Visible = True
            v4 = "X"
        Else
            c4.Visible = True
            v4 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Private Sub B5_Click(sender As Object, e As EventArgs) Handles b5.Click
        b5.Visible = False
        If turno = 1 Then
            x5.Visible = True
            v5 = "X"
        Else
            c5.Visible = True
            v5 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()

        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Private Sub B6_Click(sender As Object, e As EventArgs) Handles b6.Click
        b6.Visible = False
        If turno = 1 Then
            x6.Visible = True
            v6 = "X"
        Else
            c6.Visible = True
            v6 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()

        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Private Sub B7_Click(sender As Object, e As EventArgs) Handles b7.Click
        b7.Visible = False
        If turno = 1 Then
            x7.Visible = True
            v7 = "X"
        Else
            c7.Visible = True
            v7 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If

    End Sub

    Private Sub B8_Click(sender As Object, e As EventArgs) Handles b8.Click
        b8.Visible = False
        If turno = 1 Then
            x8.Visible = True
            v8 = "X"
        Else
            c8.Visible = True
            v8 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()
        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If
    End Sub

    Private Sub B9_Click(sender As Object, e As EventArgs) Handles b9.Click
        b9.Visible = False
        If turno = 1 Then
            x9.Visible = True
            v9 = "X"
        Else
            c9.Visible = True
            v9 = "0"
        End If
        Checar_ganador()
        Cambiar_turno()

        If vsPC = True And turno = 2 And ga = "" Then
            jugadaPC()
        End If
    End Sub

    Private Sub AutorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AutorToolStripMenuItem.Click
        MsgBox("   Programa del juego del gato " & Chr(13) & Chr(13) &
               "Desarrollado en Visual Studio " & Chr(13) & Chr(13) &
               "     Lenguaje de visual Basic " & Chr(13) & Chr(13) &
               "   Elaborado por Edgar Sanchez " & Chr(13) & Chr(13) &
               "              8vo Semestre " & Chr(13) & Chr(13) &
               "Ing. Sistemas Computacionales " & Chr(13) & Chr(13), 64, "Creditos del Autor")

    End Sub

    Private Sub VersioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VersioToolStripMenuItem.Click

        vsPC = True

        linea1.Visible = False
        linea2.Visible = False
        linea3.Visible = False
        linea4.Visible = False
        linea5.Visible = False
        linea6.Visible = False
        paneldiagonal1.Visible = False
        paneldiagonal2.Visible = False

        x1.Visible = False
        x2.Visible = False
        x3.Visible = False
        x4.Visible = False
        x5.Visible = False
        x6.Visible = False
        x7.Visible = False
        x8.Visible = False
        x9.Visible = False

        c1.Visible = False
        c2.Visible = False
        c3.Visible = False
        c4.Visible = False
        c5.Visible = False
        c6.Visible = False
        c7.Visible = False
        c8.Visible = False
        c9.Visible = False

        b1.Visible = True
        b2.Visible = True
        b3.Visible = True
        b4.Visible = True
        b4.Visible = True
        b5.Visible = True
        b6.Visible = True
        b7.Visible = True
        b8.Visible = True
        b9.Visible = True

        b1.Enabled = True
        b2.Enabled = True
        b3.Enabled = True
        b4.Enabled = True
        b5.Enabled = True
        b6.Enabled = True
        b7.Enabled = True
        b8.Enabled = True
        b9.Enabled = True

        v1 = ""
        v2 = ""
        v3 = ""
        v4 = ""
        v5 = ""
        v6 = ""
        v7 = ""
        v8 = ""
        v9 = ""

        j1 = ""
        j2 = ""
        ga = ""

        turno = 1
        ga = ""


        Do
            j1 = InputBox("Ingrese nombre del primer jugador ", "j1")
            If Len(j1) >= 3 Then
            Else
                MsgBox("No acepta vacios y al menos debe ser de 3 letras", 16, "Error")
            End If
            Exit Do
        Loop While True

        j2 = "PC"


    End Sub

    Sub jugadaPC()

        If intentar("0") Then Exit Sub
        If intentar("X") Then Exit Sub

        If v5 = "" Then Marcar(5) : Exit Sub

        If v1 = "" Then Marcar(1) : Exit Sub
        If v3 = "" Then Marcar(3) : Exit Sub
        If v7 = "" Then Marcar(7) : Exit Sub
        If v9 = "" Then Marcar(9) : Exit Sub

        If v2 = "" Then Marcar(2) : Exit Sub
        If v4 = "" Then Marcar(4) : Exit Sub
        If v6 = "" Then Marcar(6) : Exit Sub
        If v8 = "" Then Marcar(8) : Exit Sub

    End Sub

    Function intentar(sim As String) As Boolean

        If v1 = sim And v2 = sim And v3 = "" Then Marcar(3) : Return True
        If v1 = sim And v3 = sim And v2 = "" Then Marcar(2) : Return True
        If v2 = sim And v3 = sim And v1 = "" Then Marcar(1) : Return True

        If v4 = sim And v5 = sim And v6 = "" Then Marcar(6) : Return True
        If v4 = sim And v6 = sim And v5 = "" Then Marcar(5) : Return True
        If v5 = sim And v6 = sim And v4 = "" Then Marcar(4) : Return True

        If v7 = sim And v8 = sim And v9 = "" Then Marcar(9) : Return True
        If v7 = sim And v9 = sim And v8 = "" Then Marcar(8) : Return True
        If v8 = sim And v9 = sim And v7 = "" Then Marcar(7) : Return True

        If v1 = sim And v4 = sim And v7 = "" Then Marcar(7) : Return True
        If v1 = sim And v7 = sim And v4 = "" Then Marcar(4) : Return True
        If v4 = sim And v7 = sim And v1 = "" Then Marcar(1) : Return True

        If v2 = sim And v5 = sim And v8 = "" Then Marcar(8) : Return True
        If v2 = sim And v8 = sim And v5 = "" Then Marcar(5) : Return True
        If v5 = sim And v8 = sim And v2 = "" Then Marcar(2) : Return True

        If v3 = sim And v6 = sim And v9 = "" Then Marcar(9) : Return True
        If v3 = sim And v9 = sim And v6 = "" Then Marcar(6) : Return True
        If v6 = sim And v9 = sim And v3 = "" Then Marcar(3) : Return True

        If v1 = sim And v5 = sim And v9 = "" Then Marcar(9) : Return True
        If v1 = sim And v9 = sim And v5 = "" Then Marcar(5) : Return True
        If v5 = sim And v9 = sim And v1 = "" Then Marcar(1) : Return True

        If v3 = sim And v5 = sim And v7 = "" Then Marcar(7) : Return True
        If v3 = sim And v7 = sim And v5 = "" Then Marcar(5) : Return True
        If v5 = sim And v7 = sim And v3 = "" Then Marcar(3) : Return True

        Return False

    End Function

    Sub Marcar(pos As Integer)

        Select Case pos
            Case 1 : b1.PerformClick()
            Case 2 : b2.PerformClick()
            Case 3 : b3.PerformClick()
            Case 4 : b4.PerformClick()
            Case 5 : b5.PerformClick()
            Case 6 : b6.PerformClick()
            Case 7 : b7.PerformClick()
            Case 8 : b8.PerformClick()
            Case 9 : b9.PerformClick()

        End Select

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        paneldiagonal1.BackColor = Color.Transparent
        paneldiagonal1.Parent = Panel1

        paneldiagonal2.BackColor = Color.Transparent
        paneldiagonal2.Parent = Panel1
    End Sub

    Private Sub paneldiagonal1_Paint(sender As Object, e As PaintEventArgs) Handles paneldiagonal1.Paint
        Dim pluma As New Pen(Color.Yellow, 8)
        e.Graphics.DrawLine(pluma, 0, 0, paneldiagonal1.Width, paneldiagonal1.Height)
        pluma.Dispose()
    End Sub

    Private Sub paneldiagonal2_Paint(sender As Object, e As PaintEventArgs) Handles paneldiagonal2.Paint
        Dim pluma As New Pen(Color.Yellow, 8)
        e.Graphics.DrawLine(pluma, 0, paneldiagonal2.Height, paneldiagonal2.Width, 0)
        pluma.Dispose()
    End Sub

End Class
