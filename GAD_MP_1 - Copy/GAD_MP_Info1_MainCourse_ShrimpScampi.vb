﻿Imports System.Data.OleDb

Public Class GAD_MP_Info1_MainCourse_ShrimpScampi

    Dim GAD_MP_Testing_Connection_str As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=FoodHub_DB.mdb;"
    Dim connection As New OleDbConnection(GAD_MP_Testing_Connection_str)
    Private images As New List(Of Image)
    Private currentImageIndex As Integer = 0

    Private Sub GAD_MP_MainCourse_ShrimpScampi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        images.Add(My.Resources.sushi)
        images.Add(My.Resources.spaghetti_200px)
        images.Add(My.Resources.poultry_leg_200px)
        images.Add(My.Resources.kawaii_steak_200px)
        images.Add(My.Resources.beef_200px)
        images.Add(My.Resources.prawn_200px)
        images.Add(My.Resources.Fish_Fillet_200px)
        Me.Text = "Food Hub | Main Course | Shrimp Scampi"
        Timer1.Enabled = True
        Label1.Text = "Shrimp Scampi"
        Label1.Font = New Font("Microsoft JhengHei", 14.0)
        Timer1.Interval = 500
        Label3.Text = "Italian-American dish " & vbCrLf & " of shrimp cooked in" & vbCrLf & " a garlic-butter sauce with" & vbCrLf & " white wine, lemon juice," & vbCrLf & " and parsley, typically" & vbCrLf & " served over pasta or rice."
        Label3.Font = New Font("Microsoft JhengHei", 9.0)

    End Sub

    Private Sub Button2_MouseEnter(sender As Object, e As EventArgs) Handles Button2.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub
    Private Sub Button1_MouseEnter(sender As Object, e As EventArgs) Handles Button1.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub Button1_MouseLeave(sender As Object, e As EventArgs) Handles Button1.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub
    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If NumericUpDown1.Value = 0 Then

            GAD_MP_Info5_Cart_QuantityError.Show()

        Else

            CheckBox1.Checked = True

            GAD_MP_Info5_Confirmation.Show()

            'GAD_MP_Form7_Cart.Panel2.Visible = False

            Me.Hide()

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        currentImageIndex += 1
        If currentImageIndex >= images.Count Then
            currentImageIndex = 0
        End If

        PictureBox2.Image = images(currentImageIndex)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class