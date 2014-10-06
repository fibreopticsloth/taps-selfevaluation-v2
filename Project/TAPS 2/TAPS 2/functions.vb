Imports MySql.Data.MySqlClient

Module functions
    Public conn As MySqlConnection
    Public aplha As Integer = 1
    Public beta As Integer = 0
    Public connectStatus As Integer = 0

    Public Function GetConnect()
        Try
            conn = New MySqlConnection
            conn.ConnectionString = "DATABASE=computing_project;SERVER=127.0.0.1;user id=root;Convert Zero Datetime=True;Allow Zero Datetime=True"
        Catch ex As Exception
            LogError(101, ErrorToString)
        End Try
        Return conn
    End Function

    Public Function getMD5Hash(ByVal strToHash As String) As String
        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)

        Dim strResult As String = ""
        Dim b As Byte

        For Each b In bytesToHash
            strResult += b.ToString("x2")
        Next

        Return strResult
    End Function

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer
        Dim Generator As System.Random = New System.Random()
        Return Generator.Next(Min, Max)
    End Function

    Public Function ShowError(ByVal ErrorId As Integer)
        Select Case ErrorId
            Case 101 ' Error 101
                ShowMessageBox("Error: 101", "There was an error while submitting your details to our database. Please try again later.", 1)
            Case 102 ' Error 102
                ShowMessageBox("Error: 102", "The passwords you have entered do not match.", 1)
            Case 103 ' Error 103
                ShowMessageBox("Error: 103", "You have not submitted the required information to continue.", 1)
            Case 104 ' Error 104
                ShowMessageBox("Error: 104", "The school you have entered already exists.", 1)
            Case 105 ' Error 105
                ShowMessageBox("Error: 105", "You are not authorised to access this area", 1)
            Case 106 ' Error 106
                ShowMessageBox("Error: 106", "The details you have provided are incorrect. Please try again.", 1)
            Case 107 ' Error 107
                ShowMessageBox("Error: 107", "The computer name you have specified is already taken.", 1)
            Case 108 ' Error 108
                ShowMessageBox("Error: 108", "There was an error connecting to our database. Please try again later.", 1)
            Case 109 ' Error 109
                ShowMessageBox("Error: 109", "The name you have supplied does not exist.", 1)
            Case 110 ' Error 110
                ShowMessageBox("Error: 110", "No information was submitted. Please try again later.", 1)
            Case 111 ' Error 111
                ShowMessageBox("Error: 111", "The area you are trying to access is not available at this time. Please try again later.", 1)
        End Select
        Return 1
    End Function

    Public Function ShowMessageBox(ByVal Title As String, ByVal Message As String, ByVal Type As Integer)
        If Type = 1 Then
            frmError.errorStatus = 1
        ElseIf Type = 2 Then
            frmError.errorStatus = 2
        ElseIf Type = 3 Then
            frmError.errorStatus = 3
        End If
        frmError.lblErrorTitle.Text = Title
        frmError.lblErrorMessage.Text = Message
        frmError.Show()
        Return 1
    End Function

    Public Function AdminCheck()
        conn = GetConnect()
        Try
            conn.Open()
            Using sqlCommand As New MySqlCommand("SELECT * FROM users WHERE username = @username AND school = @school AND admin = @admin")
                sqlCommand.Connection = conn

                sqlCommand.Parameters.AddWithValue("@username", My.Settings.userName)
                'sqlCommand.Parameters.AddWithValue("@password", My.Settings.userPassword)
                sqlCommand.Parameters.AddWithValue("@school", My.Settings.schoolName)
                sqlCommand.Parameters.AddWithValue("@admin", 1)
                LogError("SQL QUERY", "SELECT * FROM users WHERE username = " & My.Settings.userName & " AND school = " & My.Settings.schoolName & " AND admin = 1")
                Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
                While sqlReader.Read()
                    Return 1
                End While
            End Using
            conn.Close()
        Catch ex As Exception
            ShowError(101)
            LogError(101, ErrorToString)
            Return 0
        End Try
    End Function

    Public Function LogErrorCode(ByVal errorID As Integer)
        Select Case errorID
            Case 101 ' Error 101
                LogError(101, "There was an error while submitting your details to our database. Please try again later.")
            Case 102 ' Error 102
                LogError(102, "The passwords you have entered do not match.")
            Case 103 ' Error 103
                LogError(103, "You have not submitted the required information to continue.")
            Case 104 ' Error 104
                LogError(104, "The school you have entered already exists.")
            Case 105 ' Error 105
                LogError(105, "You are not authorised to access this area")
            Case 106 ' Error 106
                LogError(106, "The details you have provided are incorrect. Please try again.")
            Case 107 ' Error 107
                LogError(107, "The computer name you have specified is already taken.")
            Case 108 ' Error 108
                LogError(108, "There was an error connecting to our database. Please try again later.")
            Case 109 ' Error 109
                LogError(109, "The name you have supplied does not exist.")
            Case 110 ' Error 110
                LogError(110, "No information was submitted. Please try again later.")
            Case 111 ' Error 111
                LogError(111, "The area you are trying to access is not available at this time. Please try again later.")
        End Select
        Return 0
    End Function

    Public Function LogError(ByVal errorID As String, ByVal errorInfo As String)
        conn = GetConnect()
        Try
            conn.Open()
            Using sqlCommand As New MySqlCommand("INSERT INTO errorlog(`errorid`, `school`, `username`, `errorinfo`) VALUES (@errorid, @school, @username, @errorinfo)")
                sqlCommand.Connection = conn
                sqlCommand.Parameters.AddWithValue("@errorid", errorID)
                If My.Settings.schoolName = "" Then
                    sqlCommand.Parameters.AddWithValue("@school", " ")
                Else
                    sqlCommand.Parameters.AddWithValue("@school", My.Settings.schoolName)
                End If
                If My.Settings.userName = "" Then
                    sqlCommand.Parameters.AddWithValue("@username", System.Environment.UserName)
                Else
                    sqlCommand.Parameters.AddWithValue("@username", My.Settings.userName)
                End If
                sqlCommand.Parameters.AddWithValue("@errorinfo", errorInfo)
                sqlCommand.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            MsgBox(ErrorToString)
        End Try
        Dim path As String = System.Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
        Dim FILE_NAME As String = path & "\SET\errorlog.txt"
        If System.IO.File.Exists(FILE_NAME) = True Then
            Dim objWriter As New System.IO.StreamWriter(FILE_NAME, IO.FileMode.Append)
            objWriter.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " | " & errorID & " | " & My.Settings.schoolName & " | " & System.Environment.UserName & " | " & errorInfo)
            objWriter.Close()
        Else
            My.Computer.FileSystem.CreateDirectory(path & "\SET")
            Dim objWriter As IO.StreamWriter
            objWriter = IO.File.CreateText(FILE_NAME)
            objWriter.WriteLine(DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") & " | " & errorID & " | " & My.Settings.schoolName & " | " & System.Environment.UserName & " | " & errorInfo)
            objWriter.Close()
        End If
        Return 0
    End Function

    Function ConnectionAttempt()
        conn = GetConnect()
        Try
            conn.Open()
            conn.Close()
            connectStatus = 1
        Catch ex As Exception
            connectStatus = 2
        End Try
        Return 1
    End Function

    Function LogInfo(ByVal action As String, ByVal info As String)
        conn = GetConnect()
        Try
            conn.Open()
            Using sqlCommand As New MySqlCommand("INSERT INTO log(`school`, `name`, `action`, `info`) VALUES (@school, @name, @action, @info)")
                sqlCommand.Connection = conn
                sqlCommand.Parameters.AddWithValue("@school", My.Settings.schoolName)
                sqlCommand.Parameters.AddWithValue("@name", System.Environment.UserName)
                sqlCommand.Parameters.AddWithValue("@action", action)
                sqlCommand.Parameters.AddWithValue("@info", info)
                sqlCommand.ExecuteNonQuery()
                LogError("SQL QUERY", "INSERT INTO log(`school`, `name`, `action`, `info`) VALUES (" & My.Settings.schoolName & ", " & System.Environment.UserName & ", " & action & ", " & info & ")")
            End Using
            conn.Close()
        Catch ex As Exception
            LogError(101, ErrorToString)
        End Try
        Return 0
    End Function

    Function PopulateEditReports()
        conn = GetConnect()
        Try
            conn.Open()
            Using sqlCommand As New MySqlCommand("SELECT * FROM reports WHERE school = @school AND finished = 0")
                sqlCommand.Connection = conn

                sqlCommand.Parameters.AddWithValue("@school", My.Settings.schoolName)
                LogError("SQL QUERY", "SELECT * FROM reports WHERE school = " & My.Settings.schoolName & " AND finished = 0")
                Dim sqlReader As MySqlDataReader = sqlCommand.ExecuteReader()
                While sqlReader.Read()
                    frmMain.editReportsGridView.Rows.Add(New String() {sqlReader("id"), sqlReader("dateStart").ToString, sqlReader("startUser"), sqlReader("dateEdit").ToString, sqlReader("lastUser"), sqlReader("percentComplete")})
                End While
            End Using
            conn.Close()
        Catch ex As Exception
            ShowError(101)
            LogError(101, ErrorToString)
        End Try
        Return 1
    End Function
End Module
