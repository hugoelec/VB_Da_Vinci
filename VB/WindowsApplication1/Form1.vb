Imports System
Imports System.IO
Imports System.Text

Public Class Form1

    Dim fileFilePath_1 As String = ""
    Dim fileFilePath_2 As String = ""
    Dim fileFilePath_3 As String = ""

    Dim savePath_1 As String = ""
    Dim savePath_2 As String = ""
    Dim savePath_3 As String = ""

    Dim check As String = "; filename = composition.3w" & vbCrLf & "; machine = daVinciF10" & vbCrLf & "; material = abs" & vbCrLf & "; layer_height = 0.3" & vbCrLf & "; total_layers = 333" & vbCrLf & "; total_filament = 0.00" & vbCrLf & "; extruder = 1" & vbCrLf & "G21 ; set units to millimeters"


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = Application.StartupPath ' My.Computer.FileSystem.SpecialDirectories.MyDocuments

        OpenFileDialog.Filter = "Gcode (*.gcode;*.gco)|*.gcode;*.gco"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            fileFilePath_1 = OpenFileDialog.FileName
            Label1.Text = Path.GetFileName(OpenFileDialog.FileName) '檔名
            savePath_1 = OpenFileDialog.FileName.Replace(Path.GetFileName(OpenFileDialog.FileName), "") '路徑

        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        If Label1.Text.Length = 0 Or Trim(Label1.Text) = "" Then
            'MsgBox("請選擇檔案")
        Else
            Try
                For Each filetmp As String In My.Computer.FileSystem.GetFiles(savePath_1, FileIO.SearchOption.SearchTopLevelOnly, "*.*") ' &amp; TextBox2.Text)

                    Dim _temp As String = filetmp.Replace(savePath_1, "")

                    If _temp.IndexOf("1_") <> -1 Then

                        My.Computer.FileSystem.DeleteFile(filetmp)

                    End If
                    '       MsgBox(filetmp)

                Next

                Dim nowStr As String = "SAMPLE01.gcode"    'Now.Year.ToString & Now.Month.ToString & Now.Day.ToString & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString & Now.Millisecond.ToString & ".txt"
                Dim _nowStr As String = "1_" & Label1.Text
                '  Dim sb As New StringBuilder()

                'Application.StartupPath '執行檔路徑
                Using outfile As New StreamWriter(savePath_1 & "/" & nowStr)

                    Using _outfile As New StreamWriter(savePath_1 & "/" & _nowStr)

                        Dim sr As StreamReader = File.OpenText(fileFilePath_1)
                        Dim getData As String = sr.ReadToEnd
                        'If getData.IndexOf(check) <> -1 Then
                        '    '    MsgBox("有找到")
                        '    outfile.Write(getData)
                        '    _outfile.Write(getData)
                        '    '  sb.Append(getData)
                        'Else
                        '    '    MsgBox("沒有找到唷")
                        '    outfile.WriteLine(check)
                        '    outfile.Write(getData)
                        '    _outfile.WriteLine(check)
                        '    _outfile.Write(getData)
                        '    '  sb.AppendLine(check)
                        '    '  sb.Append(getData)
                        'End If
                        '  outfile.WriteLine(check)
                        outfile.Write(getData)
                        '  _outfile.WriteLine(check)
                        _outfile.Write(getData)

                    End Using

                End Using

                '  MsgBox("完成!檔案在:" & savePath_1 & "/" & nowStr)
            Catch

            End Try

        End If

        '/*********************************************************/


        If Label2.Text.Length = 0 Or Trim(Label2.Text) = "" Then
            'MsgBox("請選擇檔案")
        Else
            Try
                For Each filetmp As String In My.Computer.FileSystem.GetFiles(savePath_2, FileIO.SearchOption.SearchTopLevelOnly, "*.*") ' &amp; TextBox2.Text)

                    Dim _temp As String = filetmp.Replace(savePath_2, "")

                    If _temp.IndexOf("2_") <> -1 Then

                        My.Computer.FileSystem.DeleteFile(filetmp)

                    End If
                    '       MsgBox(filetmp)

                Next

                Dim nowStr As String = "SAMPLE02.gcode"    'Now.Year.ToString & Now.Month.ToString & Now.Day.ToString & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString & Now.Millisecond.ToString & ".txt"
                Dim _nowStr As String = "2_" & Label2.Text
                '  Dim sb As New StringBuilder()

                'Application.StartupPath '執行檔路徑
                Using outfile As New StreamWriter(savePath_2 & "/" & nowStr)

                    Using _outfile As New StreamWriter(savePath_2 & "/" & _nowStr)

                        Dim sr As StreamReader = File.OpenText(fileFilePath_2)
                        Dim getData As String = sr.ReadToEnd
                        'If getData.IndexOf(check) <> -1 Then
                        '    '   MsgBox("有找到")
                        '    outfile.Write(getData)
                        '    _outfile.Write(getData)
                        '    '  sb.Append(getData)
                        'Else
                        '    '     MsgBox("沒有找到唷")
                        '    outfile.WriteLine(check)
                        '    outfile.Write(getData)
                        '    _outfile.WriteLine(check)
                        '    _outfile.Write(getData)
                        '    '  sb.AppendLine(check)
                        '    '  sb.Append(getData)
                        'End If
                        '   outfile.WriteLine(check)
                        outfile.Write(getData)
                        '   _outfile.WriteLine(check)
                        _outfile.Write(getData)

                    End Using

                End Using

                '  MsgBox("完成!檔案在:" & savePath_1 & "/" & nowStr)
            Catch

            End Try

        End If

        '/*********************************************************/


        If Label3.Text.Length = 0 Or Trim(Label3.Text) = "" Then
            'MsgBox("請選擇檔案")
        Else
            Try
                For Each filetmp As String In My.Computer.FileSystem.GetFiles(savePath_3, FileIO.SearchOption.SearchTopLevelOnly, "*.*") ' &amp; TextBox2.Text)

                    Dim _temp As String = filetmp.Replace(savePath_3, "")

                    If _temp.IndexOf("3_") <> -1 Then

                        My.Computer.FileSystem.DeleteFile(filetmp)

                    End If
                    '       MsgBox(filetmp)

                Next

                Dim nowStr As String = "SAMPLE03.gcode"    'Now.Year.ToString & Now.Month.ToString & Now.Day.ToString & Now.Hour.ToString & Now.Minute.ToString & Now.Second.ToString & Now.Millisecond.ToString & ".txt"
                Dim _nowStr As String = "3_" & Label3.Text
                '  Dim sb As New StringBuilder()

                'Application.StartupPath '執行檔路徑
                Using outfile As New StreamWriter(savePath_3 & "/" & nowStr)

                    Using _outfile As New StreamWriter(savePath_3 & "/" & _nowStr)

                        Dim sr As StreamReader = File.OpenText(fileFilePath_3)
                        Dim getData As String = sr.ReadToEnd
                        'If getData.IndexOf(check) <> -1 Then
                        '    '     MsgBox("有找到")
                        '    outfile.Write(getData)
                        '    _outfile.Write(getData)
                        '    '  sb.Append(getData)
                        'Else
                        '    '   MsgBox("沒有找到唷")
                        '    outfile.WriteLine(check)
                        '    outfile.Write(getData)
                        '    _outfile.WriteLine(check)
                        '    _outfile.Write(getData)
                        '    '  sb.AppendLine(check)
                        '    '  sb.Append(getData)
                        'End If
                        '  outfile.WriteLine(check)
                        outfile.Write(getData)
                        '  _outfile.WriteLine(check)
                        _outfile.Write(getData)

                    End Using

                End Using

                '  MsgBox("完成!檔案在:" & savePath_1 & "/" & nowStr)
            Catch

            End Try

        End If

        '/*********************************************************/

        MsgBox("轉換完成!")



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = Application.StartupPath ' My.Computer.FileSystem.SpecialDirectories.MyDocuments

        OpenFileDialog.Filter = "Gcode (*.gcode;*.gco)|*.gcode;*.gco"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            fileFilePath_2 = OpenFileDialog.FileName
            Label2.Text = Path.GetFileName(OpenFileDialog.FileName) '檔名
            savePath_2 = OpenFileDialog.FileName.Replace(Path.GetFileName(OpenFileDialog.FileName), "") '路徑

        End If

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Dim OpenFileDialog As New OpenFileDialog

        OpenFileDialog.InitialDirectory = Application.StartupPath ' My.Computer.FileSystem.SpecialDirectories.MyDocuments

        OpenFileDialog.Filter = "Gcode (*.gcode;*.gco)|*.gcode;*.gco"

        If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            fileFilePath_3 = OpenFileDialog.FileName
            Label3.Text = Path.GetFileName(OpenFileDialog.FileName) '檔名
            savePath_3 = OpenFileDialog.FileName.Replace(Path.GetFileName(OpenFileDialog.FileName), "") '路徑

        End If

    End Sub
End Class
