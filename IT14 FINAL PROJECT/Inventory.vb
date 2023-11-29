﻿Public Class Inventory

    Public indexCount As Integer

    Public idOrders As Integer
    Public idStocks As Integer
    Private Sub btnAddOrder_Click(sender As Object, e As EventArgs) Handles btnAddOrder.Click
        AddOrder.Show()


    End Sub

    Public Sub Inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadOrders()
        loadStocks()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        UpdateOrder.Show()

    End Sub
    Private Sub dgOrderList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgOrderList.CellContentClick
        indexCount = dgOrderList.CurrentRow.Index
        idOrders = dgOrderList.CurrentRow.Cells(0).Value
    End Sub


    Private Sub dgvStocks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvStocks.CellContentClick
        indexCount = dgvStocks.CurrentCell.RowIndex
        idStocks = dgvStocks.CurrentRow.Cells(0).Value

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 1 Then
            UpdateStocks.Show()
            UpdateStocks.lblID.Text = idStocks
        Else
            UpdateStocks.Close()
        End If

        If e.RowIndex >= 0 AndAlso e.ColumnIndex = 2 Then
            numeric1.Visible = True
            btnUpdateQuantity.Visible = True
            numeric1.Value = dgvStocks.CurrentRow.Cells(2).Value
        Else
            numeric1.Visible = False
            btnUpdateQuantity.Visible = False
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        ViewOrders.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Pricing.Show()

    End Sub

    Private Sub btnAddStocks_Click(sender As Object, e As EventArgs) Handles btnAddStocks.Click
        AddStocks.Show()

    End Sub


    Private Sub btnDeleteStocks_Click(sender As Object, e As EventArgs) Handles btnDeleteStocks.Click
        Delete_Stocks(idStocks)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dashboard.Show()
        Me.Close()

    End Sub

    Private Sub btnViewStocks_Click(sender As Object, e As EventArgs) Handles btnViewStocks.Click
        ViewStocks.Show()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Sales.Show()
        Me.Close()

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Login.Show()
        Me.Close()

    End Sub

    Public Sub btnUpdateQuantity_Click(sender As Object, e As EventArgs) Handles btnUpdateQuantity.Click
        Dim quantityval As Integer
        quantityval = numeric1.Value
        Update_QuantityStocks(quantityval, idStocks)
    End Sub

    Private Sub btnDeleteOrders_Click(sender As Object, e As EventArgs) Handles btnDeleteOrders.Click

        Dim result As DialogResult = MessageBox.Show("Are you sure you want to delete this order?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Delete_Orders(idOrders)
            MessageBox.Show("Order deleted successfully.")
        Else

        End If
    End Sub
End Class