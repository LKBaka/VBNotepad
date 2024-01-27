Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Imports System
Imports System.Drawing
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class VBNotepad

    Declare Auto Function ReleaseCapture Lib "user32.dll" Alias "ReleaseCapture" () As Boolean
    'API ReleaseCapture函数是用来释放鼠标捕获的
    Declare Auto Function SendMessage Lib "user32.dll" Alias "SendMessage" (ByVal hWnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As IntPtr
    '向windows发送消息
    Public Const WM_SYSCOMMAND As Integer = &H112&
    Public Const SC_MOVE As Integer = &HF010&
    Public Const HTCAPTION As Integer = &H2&

    Public FileNameLabel = New Label
    Public Page = New TabPage
    WithEvents RichEdit As New RichTextBox
    Dim isMouseDown As Boolean = False
    Dim direction As MouseDirection = MouseDirection.None
    Dim mouseOff As Point
    ' Public config_file As New StreamReader(Application.StartupPath & "\config.ini", Encoding.UTF8)
    'Public config() As String = {}
    Public Enum MouseDirection
        Herizontal
        Vertical
        Declining
        None
    End Enum
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        mouseOff = New Point(-e.X, -e.Y)
        If e.Location.X >= Me.Width - 5 AndAlso e.Location.Y > Me.Height - 5 Then
            isMouseDown = True
        ElseIf e.Location.X >= Me.Width - 5 Then
            isMouseDown = True
        ElseIf e.Location.Y >= Me.Height - 5 Then
            isMouseDown = True
        Else
            Me.Cursor = Cursors.Arrow
            '改变鼠标样式为原样
            isMouseDown = False
            '鼠标移动事件
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'ReleaseCapture()
        'SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        '鼠标移动到边缘，改变鼠标的图标
        If e.Location.X >= Me.Width - 5 AndAlso e.Location.Y > Me.Height - 5 Then
            Me.Cursor = Cursors.SizeNWSE
            direction = MouseDirection.Declining
        ElseIf e.Location.X >= Me.Width - 5 Then
            Me.Cursor = Cursors.SizeWE
            direction = MouseDirection.Herizontal
        ElseIf e.Location.Y >= Me.Height - 5 Then
            Me.Cursor = Cursors.SizeNS
            direction = MouseDirection.Vertical
        Else
            '否则，以外的窗体区域，鼠标星座均为单向箭头（默认）             
            Me.Cursor = Cursors.Arrow
        End If
        If e.Location.X >= (Me.Width + Me.Left + 10) OrElse (e.Location.Y > Me.Height + Me.Top + 10) Then
            isMouseDown = False
        End If

        '设定好方向后，调用下面方法，改变窗体大小  
        ResizeWindow()

    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp
        '  Console.WriteLine("松开鼠标")
        isMouseDown = False
        direction = MouseDirection.None
        If isMouseDown Then
            isMouseDown = False
        End If
    End Sub
    Private Sub MinWindow_Click(sender As Object, e As EventArgs) Handles MinWindow.Click
        WindowState = FormWindowState.Minimized
    End Sub

    Private Sub rm1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MovePanel.MouseMove
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_SYSCOMMAND, SC_MOVE + HTCAPTION, 0)
        End If


    End Sub

    Private Sub NewPage_Click(sender As Object, e As EventArgs) Handles NewPage.Click
        NewTabPage(1)
    End Sub

    Public Sub NewTabPage(index As Integer)
        Dim rnd As New Random
        Page = New TabPage
        RichEdit = New RichTextBox
        FileNameLabel = New Label

        With Page
            .BackColor = Color.Silver
            .Name = "NewPage" & rnd.Next()
            .text = "未命名"
        End With
        With RichEdit
            .BackColor = Color.Silver
            .Name = "NewRichEdit" & rnd.Next()
            .Size = Size
            .AllowDrop = True
        End With

        If index = 2 Then
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                Dim filename = OpenFileDialog1.FileName
                Dim FileOpen As New StreamReader(filename)
                RichEdit.Text = FileOpen.ReadToEnd()
                FileOpen.Close()
                Page.text = filename.Substring(filename.LastIndexOf("\") + 1)
                With FileNameLabel
                    .text = OpenFileDialog1.FileName
                    .visible = False
                End With
            End If
        ElseIf index = 1 Then
            Try
                Dim filename = Command()
                Dim FileOpen As New StreamReader(filename)
                RichEdit.Text = FileOpen.ReadToEnd()
                FileOpen.Close()
                Page.text = filename.Substring(filename.LastIndexOf("\") + 1)
                With FileNameLabel
                    .text = Command()
                    .visible = False
                End With
            Catch ex As Exception

            End Try
        End If




        TC.Controls.Add(Page)
        Page.Controls.Add(RichEdit)
        Page.Controls.Add(FileNameLabel)
        TC.SelectedTab = Page
    End Sub
    Public Sub Save(index As Integer)
        If index = 1 Then
            If TC.SelectedTab.Text = "未命名" Then
                If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                    Dim SaveAsFileName = SaveFileDialog1.FileName
                    Dim FileWrite As New StreamWriter(SaveAsFileName)
                    FileWrite.Write(TC.SelectedTab.Controls.Item(0).Text)
                    FileWrite.Close()
                End If
            Else
                If TC.SelectedIndex <> 0 Then
                    Dim SaveFileName = TC.SelectedTab.Controls.Item(1).Text
                    Dim FileWrite2 As New StreamWriter(SaveFileName)
                    FileWrite2.Write(TC.SelectedTab.Controls.Item(0).Text)
                    FileWrite2.Close()
                End If
            End If
        ElseIf index = 2 Then
            If SaveFileDialog1.ShowDialog = DialogResult.OK Then
                Dim SaveAsFileName = SaveFileDialog1.FileName
                Dim FileWrite As New StreamWriter(SaveAsFileName)
                FileWrite.Write(TC.SelectedTab.Controls.Item(0).Text)
                FileWrite.Close()
            End If
        End If
    End Sub
    Private Sub TC_DoubleClick(sender As Object, e As EventArgs) Handles TC.DoubleClick
        Dim Temp_SelTab = TC.SelectedTab
        Dim Temp_SelIndex = TC.SelectedIndex
        TC.TabPages.Remove(Temp_SelTab)
        If TC.SelectedIndex <> 0 Then
            TC.SelectedIndex = Temp_SelIndex - 1
        Else
            TC.SelectedIndex = Temp_SelIndex
        End If
    End Sub

    Private Sub CloseBtn_Click(sender As Object, e As EventArgs) Handles CloseBtn.Click
        For i = 0 To 10
            Width -= 20
            Height -= 20
            Left += 10
            Top += 10
            Opacity -= 0.22
        Next
        End
    End Sub

    Private Sub VBNotepad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        FileMenu.Hide()
        EditMenu.Hide()
        LookMenu.Hide()
        If Command() <> "" Then
            NewTabPage(1)
        End If

    End Sub

    Private Sub FileOption_Click(sender As Object, e As EventArgs) Handles FileOption.Click
        If FileMenu.Visible Then
            FileMenu.Hide()
            FileOption.BackColor = Color.DarkGray
        Else
            FileMenu.Show()
            FileOption.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub OpenBtn_Click(sender As Object, e As EventArgs) Handles OpenBtn.Click
        NewTabPage(2)
    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        Save(1)
    End Sub

    Private Sub SaveAsBtn_Click(sender As Object, e As EventArgs) Handles SaveAsBtn.Click
        Save(2)
    End Sub

    Private Sub VBNotepad_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        NewPage.Location = New Point(Width - 67, NewPage.Location.Y)
        CloseBtn.Location = New Point(Width - 44, CloseBtn.Location.Y)
        MaxWindow.Location = New Point(Width - 75, MinWindow.Location.Y)
        MinWindow.Location = New Point(Width - 106, MinWindow.Location.Y)
        MovePanel.Width = Width
        TC.Size = New Size(Size.Width, Size.Height)
        RichEdit.Size = New Size(Size.Width, Size.Height)
    End Sub

    Private Sub Edit_Click(sender As Object, e As EventArgs) Handles Edit.Click
        If EditMenu.Visible Then
            EditMenu.Hide()
            Edit.BackColor = Color.DarkGray
        Else
            EditMenu.Show()
            Edit.BackColor = Color.LightGray
        End If
    End Sub

    Private Sub FindText_Click(sender As Object, e As EventArgs) Handles FindText.Click
        Dim find = InputBox("输入需要寻找的文本", "寻找文本")
        If find <> "" Then
            RichEdit.Find(find)
        End If
    End Sub

    Private Sub EditFont_Click(sender As Object, e As EventArgs) Handles EditFont.Click
        If FontDialog1.ShowDialog = DialogResult.OK Then
            Try
                TC.SelectedTab.Controls.Item(0).Font = FontDialog1.Font
            Catch
            End Try
        End If
    End Sub

    Private Sub ReplaceString_Click(sender As Object, e As EventArgs) Handles replaceString.Click
        Dim old = InputBox("输入被替换的文本", "替换文本")
        Dim replace = InputBox("输入替换的文本", "替换文本")
        If replace <> "" Then
            Try
                RichEdit.Text = RichEdit.Text.Replace(old, replace)
            Catch
            End Try
        End If

    End Sub

    Private Sub ResizeWindow()

        If Not isMouseDown Then
            Return
        End If
        If direction = MouseDirection.Declining Then
            'Me.Cursor = Cursors.SizeNWSE
            '改变宽度
            Me.Width = MousePosition.X - Me.Left + 5
            Me.Height = MousePosition.Y - Me.Top + 5

        ElseIf direction = MouseDirection.Herizontal Then
            'Me.Cursor = Cursors.SizeWE
            '改变宽度
            Me.Width = MousePosition.X - Me.Left + 5

        ElseIf direction = MouseDirection.Vertical Then
            'Me.Cursor = Cursors.SizeNS
            '改变高度
            Me.Height = MousePosition.Y - Me.Top + 5

        Else
            '鼠标不在窗口右和下边缘，把鼠标打回原型
            Me.Cursor = Cursors.Arrow
            isMouseDown = False
        End If
        Refresh()
    End Sub

    Private Sub Look_Click(sender As Object, e As EventArgs) Handles Look.Click
        If LookMenu.Visible Then
            LookMenu.Hide()
            Look.BackColor = Color.DarkGray
        Else
            LookMenu.Show()
            Look.BackColor = Color.LightGray
        End If

    End Sub

    Private Sub WordWrap_Click(sender As Object, e As EventArgs) Handles WordWrap.Click
        Dim TempFont = RichEdit.Font
        If RichEdit.WordWrap Then
            RichEdit.WordWrap = False
            WordWrap.Text = "自动换行"
            RichEdit.Font = TempFont

        Else
            RichEdit.WordWrap = True
            WordWrap.Text = "√自动换行"
            RichEdit.Font = TempFont
        End If
    End Sub

    Private Sub 主页_Click(sender As Object, e As EventArgs) Handles 主页.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles MaxWindow.Click
        WindowState = FormWindowState.Maximized
    End Sub
End Class