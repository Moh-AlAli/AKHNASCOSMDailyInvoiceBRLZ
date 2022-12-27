Imports ACCPAC.Advantage
Friend Class Fromcustomer

    Private i As Integer
    Private j As Integer
    Private os As New Session
    Private dblink As DBLink
    Private compid As String = ""

    Private Sub Fromcust_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            os.Init("", "XX", "XX0001", "65A")
            os.OpenWin("", "", "", dailyinv.compid, System.DateTime.Now, 0)
            'os.Open("ADMIN", "ADMIN", dailyinv.compid, System.DateTime.Now, 0)
            dblink = os.OpenDBLink(DBLinkType.Company, DBLinkFlags.ReadOnly)




            Dim arv As View
            arv = dblink.OpenView("AR0024")

            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim name As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim id As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))

            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim icl As New DataGridViewTextBoxColumn
            icl.DataPropertyName = "IDCUST"
            icl.Name = "clidc"
            icl.HeaderText = "Customer Number"
            icl.Width = 150
            DGfcus.Columns.Add(icl)
            Dim ncl As New DataGridViewTextBoxColumn
            ncl.DataPropertyName = "NAMECUST"
            ncl.Name = "colnc"
            ncl.HeaderText = "Customer Name"
            ncl.Width = 190
            DGfcus.Columns.Add(ncl)

            DGfcus.DataSource = arcusds.Tables(0)


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ButSel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButSel.Click
        Try

            Dim arv As View
            arv = dblink.OpenView("AR0024")
            Dim searfil As String = ""

            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = "NAMECUST like ""%" + Txtname.Text + "%"" "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "IDCUST like ""%" + Txtcusno.Text + "%"" "
            Else
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            End If
            arv.Browse(searfil, True)
            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = arcusds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            dailyinv.txtfrmcus.Text = dt.Rows(i)(0)
            dailyinv.Picfromcust.enabled = True
            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Butcan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Butcan.Click
        dailyinv.Picfromcust.enabled = True
        Close()

    End Sub

    Private Sub Txtcusno_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcusno.MouseLeave

        If Txtcusno.Text <> Nothing Then

            Dim arv As View

            arv = dblink.OpenView("AR0024")
            Dim searfil As String = ""
            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = "NAMECUST like ""%" + Txtname.Text + "%"" "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "IDCUST like ""%" + Txtcusno.Text + "%"" "
            Else
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            End If

            arv.Browse(searfil, True)


            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()

            Do While arv.FilterFetch(False)

                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()

            Loop


            DGfcus.DataSource = arcusds.Tables(0)

        End If
    End Sub

    Private Sub Txtname_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtname.MouseLeave

        Try



            Dim arv As View
            arv = dblink.OpenView("AR0024")
            Dim searfil As String = ""

            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = "NAMECUST like ""%" + Txtname.Text + "%"" "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "IDCUST like ""%" + Txtcusno.Text + "%"" "
            Else
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = arcusds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub Txtcusno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtcusno.TextChanged
        Try


            Dim arv As View
            arv = dblink.OpenView("AR0024")
            Dim searfil As String = ""
            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = "NAMECUST like ""%" + Txtname.Text + "%"" "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "IDCUST like ""%" + Txtcusno.Text + "%"" "
            Else
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = arcusds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Txtname_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Txtname.TextChanged
        Try

            Dim arv As View
            arv = dblink.OpenView("AR0024")
            Dim searfil As String = ""

            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = "NAMECUST like ""%" + Txtname.Text + "%"" "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "IDCUST like ""%" + Txtcusno.Text + "%"" "
            Else
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            End If
            arv.Browse(searfil, True)
            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            DGfcus.DataSource = arcusds.Tables(0)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGfcus_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DGfcus.CellContentClick
        Try
            Dim arv As View
            arv = dblink.OpenView("AR0024")
            Dim searfil As String = ""

            If Txtcusno.Text <> Nothing And Txtname.Text <> Nothing Then
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            ElseIf Txtname.Text <> Nothing And Txtcusno.Text = Nothing Then
                searfil = "NAMECUST like ""%" + Txtname.Text + "%"" "
            ElseIf Txtcusno.Text <> Nothing And Txtname.Text = Nothing Then
                searfil = "IDCUST like ""%" + Txtcusno.Text + "%"" "
            Else
                searfil = "NAMECUST Like ""%" + Txtname.Text + "%"" and IDCUST like ""%" + Txtcusno.Text + "%"" "
            End If

            arv.Browse(searfil, True)
            Dim arcusds As DataSet = New DataSet("AR")

            Dim cust As DataTable = arcusds.Tables.Add("ARCUS")
            Dim id As DataColumn = cust.Columns.Add("IDCUST", Type.GetType("System.String"))
            Dim name As DataColumn = cust.Columns.Add("NAMECUST", Type.GetType("System.String"))
            cust.PrimaryKey = New DataColumn() {id}
            Dim row As DataRow
            row = cust.NewRow()
            Do While arv.FilterFetch(False)
                Dim cid As String = arv.Fields.FieldByName("IDCUST").Value.ToString()
                Dim cn As String = arv.Fields.FieldByName("NAMECUST").Value.ToString()
                row("IDCUST") = cid
                row("NAMECUST") = cn
                arcusds.Tables(0).Rows.Add(row)
                row = cust.NewRow()
            Loop
            Dim dt As DataTable = arcusds.Tables(0)

            i = DGfcus.CurrentCell.RowIndex
            j = DGfcus.CurrentCell.ColumnIndex
            dailyinv.txtfrmcus.Text = dt.Rows(i)(0)
            dailyinv.Picfromcust.enabled = True

            Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub



    Private Sub Fromcustomer_FormClosed(sender As Object, e As FormClosedEventArgs) Handles MyBase.FormClosed
        dailyinv.Picfromcust.Enabled = True
    End Sub
End Class