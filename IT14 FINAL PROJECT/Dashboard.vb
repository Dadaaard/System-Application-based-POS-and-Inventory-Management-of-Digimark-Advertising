﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel

Public Class Dashboard
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Inventory.Show()
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Sales.Show()
        Me.Close()

    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        View_Dashboard()
        Load_MonthlySales()
        Load_WeeklySales()
        Load_AnnuallySales()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Login.Show()
        Me.Close()

    End Sub

    Private Sub btnAccounts_Click(sender As Object, e As EventArgs) Handles btnAccounts.Click
        AccountDetails.Show()
    End Sub
End Class