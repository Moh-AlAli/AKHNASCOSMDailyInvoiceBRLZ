
Imports AccpacCOMAPI

Friend Class dailyinv

    Friend compid As String = ""
    Private acsignon As New AccpacSignonManager.AccpacSignonMgr
    Friend mSession As New AccpacCOMAPI.AccpacSession
    Friend frmcust As String
    Friend Tocust As String
    Friend fdate As String
    Friend tdate As String
    Friend compname As String

    Private Sub dailyinv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            mSession.Init("", "XX", "XX0001", "65A")
            acsignon.Signon(mSession)
            compid = mSession.CompanyID
            compname = mSession.CompanyName
            If compid = "" Then
                Close()
            End If
            Txttocus.Text = "zzzzzzzzzzzzzzzzzzzzzz"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim fmonthnew As String = 0
            If DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & DateTimePicker1.Value.Month
            Else
                fmonthnew = DateTimePicker1.Value.Month
            End If
            Dim tmonthnew As String = 0
            If DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & DateTimePicker2.Value.Month
            Else
                tmonthnew = DateTimePicker2.Value.Month
            End If

            Dim fdaynew As String = 0
            If DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & DateTimePicker1.Value.Day
            Else
                fdaynew = DateTimePicker1.Value.Day
            End If
            Dim tdaynew As String = 0
            If DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & DateTimePicker2.Value.Day
            Else
                tdaynew = DateTimePicker2.Value.Day
            End If

            fdate = DateTimePicker1.Value.Year & fmonthnew & fdaynew

            tdate = DateTimePicker2.Value.Year & tmonthnew & tdaynew

            If Trim(Txtfrmcus.Text) <= Trim(Txttocus.Text) Then
                If fdate <= tdate Then

                    If rbinv.Checked = True Or rbcrdb.Checked = True Then
                        crviewer.Show()

                    Else
                        MessageBox.Show("Choose Report Type")
                    End If
                Else
                    MessageBox.Show("From Date  greater than To Date")
                End If
            Else
                MessageBox.Show("From Customer No greater than To Customer No")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Close()
    End Sub

 
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Picfromcust.Click
        Fromcustomer.Show()
        Picfromcust.Enabled = False

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles Pictocust.Click
        ToCustomer.Show()
        Pictocust.Enabled = False

    End Sub
End Class
