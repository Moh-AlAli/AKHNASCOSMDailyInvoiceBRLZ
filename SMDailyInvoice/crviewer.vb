Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports System.Security.Cryptography
Imports System.IO
Imports System.Text



Friend Class crviewer



    Private rdoc As New ReportDocument
    Private conrpt As New ConnectionInfo()
    Dim server As String = ""
    Dim uid As String = ""
    Dim pass As String = ""
    Dim fdate As String = ""
    Dim tdate As String = ""




    Friend Function createdes(ByVal key As String) As TripleDES
        Dim md5 As MD5 = New MD5CryptoServiceProvider()
        Dim des As TripleDES = New TripleDESCryptoServiceProvider()
        des.Key = md5.ComputeHash(Encoding.Unicode.GetBytes(key))
        des.IV = New Byte(des.BlockSize \ 8 - 1) {}
        Return des
    End Function

    Friend Function Decryption(ByVal cyphertext As String, ByVal key As String) As String
        Dim b As Byte() = Convert.FromBase64String(cyphertext)
        Dim des As TripleDES = createdes(key)
        Dim ct As ICryptoTransform = des.CreateDecryptor()
        Dim output As Byte() = ct.TransformFinalBlock(b, 0, b.Length)
        Return Encoding.Unicode.GetString(output)
    End Function
    Friend Function Readconnectionstring() As String

        Dim secretkey As String = "Fhghqwjehqwlegtoit123mnk12%&4#"
        Dim path As String = ("txtcon\akhcon.txt")
        Dim sr As New StreamReader(path)

        server = sr.ReadLine()
        Dim db As String = sr.ReadLine()
        uid = sr.ReadLine()
        pass = sr.ReadLine()


        server = Decryption(server, secretkey)
        uid = Decryption(uid, secretkey)
        pass = Decryption(pass, secretkey)

        Dim cons As String = "" '"Data Source =(Local); DataBase =" & custstatement.compid & "; User Id =" & uid & "; Password =" & pass & ";"

        Return cons
    End Function
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles cryviewer.Load

        Try

            Dim type As Integer

            If dailyinv.rbinv.Checked = True Then
                type = 0
                rdoc.Load("reports\ARDLYINVRPT.rpt")
            ElseIf dailyinv.rbcrdb.Checked = True Then
                type = 1
                rdoc.Load("reports\ARDLYCRDRRPT.rpt")
            End If


            Dim tabs As Tables = rdoc.Database.Tables

         
            Dim fmonthnew As String = 0

            If dailyinv.DateTimePicker1.Value.Month.ToString.Length < 2 Then
                fmonthnew = "0" & dailyinv.DateTimePicker1.Value.Month
            Else
                fmonthnew = dailyinv.DateTimePicker1.Value.Month
            End If


            Dim tmonthnew As String = 0
            If dailyinv.DateTimePicker2.Value.Month.ToString.Length < 2 Then
                tmonthnew = "0" & dailyinv.DateTimePicker2.Value.Month
            Else
                tmonthnew = dailyinv.DateTimePicker2.Value.Month
            End If


            Dim fdaynew As String = 0
            If dailyinv.DateTimePicker1.Value.Day.ToString.Length < 2 Then
                fdaynew = "0" & dailyinv.DateTimePicker1.Value.Day
            Else
                fdaynew = dailyinv.DateTimePicker1.Value.Day
            End If


            Dim tdaynew As String = 0
            If dailyinv.DateTimePicker2.Value.Day.ToString.Length < 2 Then
                tdaynew = "0" & dailyinv.DateTimePicker2.Value.Day
            Else
                tdaynew = dailyinv.DateTimePicker2.Value.Day
            End If


            fdate = dailyinv.DateTimePicker1.Value.Year & fmonthnew & fdaynew
            tdate = dailyinv.DateTimePicker2.Value.Year & tmonthnew & tdaynew


            Readconnectionstring()
            For Each TAB As CrystalDecisions.CrystalReports.Engine.Table In tabs

                Dim tablog As TableLogOnInfo = TAB.LogOnInfo
                conrpt.ServerName = server
                conrpt.DatabaseName = dailyinv.compid
                conrpt.UserID = uid
                conrpt.Password = pass
                tablog.ConnectionInfo = conrpt
                TAB.ApplyLogOnInfo(tablog)
            Next

            rdoc.SetParameterValue("FrmDate", fdate)
            rdoc.SetParameterValue("Todate", tdate)
            rdoc.SetParameterValue("FRMCUST", dailyinv.Txtfrmcus.Text)
            rdoc.SetParameterValue("TOCUST", dailyinv.Txttocus.Text)
            rdoc.SetParameterValue("CONAME", dailyinv.compname)
            rdoc.SetParameterValue("type", type)

            cryviewer.ReportSource = rdoc


        Catch ex As Exception
            MessageBox.Show(ex.Message)
            If rdoc Is Nothing Then
                rdoc.Close()
                rdoc.Dispose()
            End If
        End Try
    End Sub



End Class