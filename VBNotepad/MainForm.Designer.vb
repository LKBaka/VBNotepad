<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class VBNotepad
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As ComponentModel.ComponentResourceManager = New ComponentModel.ComponentResourceManager(GetType(VBNotepad))
        MovePanel = New Panel()
        CloseBtn = New Label()
        MinWindow = New Label()
        TC = New TabControl()
        主页 = New TabPage()
        NewPage = New Label()
        FileOption = New Label()
        FileMenu = New Panel()
        SaveAsBtn = New Label()
        SaveBtn = New Label()
        OpenBtn = New Label()
        OpenFileDialog1 = New OpenFileDialog()
        SaveFileDialog1 = New SaveFileDialog()
        Edit = New Label()
        EditMenu = New Panel()
        replaceString = New Label()
        EditFont = New Label()
        FindText = New Label()
        FontDialog1 = New FontDialog()
        Look = New Label()
        LookMenu = New Panel()
        Label1 = New Label()
        Label2 = New Label()
        WordWrap = New Label()
        MaxWindow = New Label()
        MovePanel.SuspendLayout()
        TC.SuspendLayout()
        FileMenu.SuspendLayout()
        EditMenu.SuspendLayout()
        LookMenu.SuspendLayout()
        SuspendLayout()
        ' 
        ' MovePanel
        ' 
        MovePanel.BackColor = Color.DimGray
        MovePanel.Controls.Add(MaxWindow)
        MovePanel.Controls.Add(CloseBtn)
        MovePanel.Controls.Add(MinWindow)
        MovePanel.Location = New Point(0, 1)
        MovePanel.Name = "MovePanel"
        MovePanel.Size = New Size(743, 40)
        MovePanel.TabIndex = 0
        ' 
        ' CloseBtn
        ' 
        CloseBtn.AutoSize = True
        CloseBtn.Font = New Font("黑体", 15F, FontStyle.Regular, GraphicsUnit.Point)
        CloseBtn.ForeColor = SystemColors.ControlText
        CloseBtn.Location = New Point(701, 8)
        CloseBtn.Name = "CloseBtn"
        CloseBtn.Size = New Size(38, 25)
        CloseBtn.TabIndex = 2
        CloseBtn.Text = "×"
        ' 
        ' MinWindow
        ' 
        MinWindow.AutoSize = True
        MinWindow.Font = New Font("黑体", 15F, FontStyle.Regular, GraphicsUnit.Point)
        MinWindow.ForeColor = SystemColors.ControlText
        MinWindow.Location = New Point(639, 8)
        MinWindow.Name = "MinWindow"
        MinWindow.Size = New Size(25, 25)
        MinWindow.TabIndex = 1
        MinWindow.Text = "-"
        ' 
        ' TC
        ' 
        TC.Controls.Add(主页)
        TC.Location = New Point(0, 70)
        TC.Name = "TC"
        TC.SelectedIndex = 0
        TC.Size = New Size(743, 656)
        TC.TabIndex = 1
        ' 
        ' 主页
        ' 
        主页.BackColor = Color.Silver
        主页.Location = New Point(4, 29)
        主页.Name = "主页"
        主页.Size = New Size(735, 623)
        主页.TabIndex = 0
        主页.Text = ":)"
        ' 
        ' NewPage
        ' 
        NewPage.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        NewPage.ForeColor = SystemColors.ControlText
        NewPage.Location = New Point(678, 44)
        NewPage.Name = "NewPage"
        NewPage.Size = New Size(58, 23)
        NewPage.TabIndex = 3
        NewPage.Text = "+"
        NewPage.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' FileOption
        ' 
        FileOption.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        FileOption.ForeColor = SystemColors.ControlText
        FileOption.ImageAlign = ContentAlignment.BottomLeft
        FileOption.Location = New Point(7, 44)
        FileOption.Name = "FileOption"
        FileOption.Size = New Size(66, 28)
        FileOption.TabIndex = 4
        FileOption.Text = "文件"
        ' 
        ' FileMenu
        ' 
        FileMenu.BackColor = Color.LightGray
        FileMenu.Controls.Add(SaveAsBtn)
        FileMenu.Controls.Add(SaveBtn)
        FileMenu.Controls.Add(OpenBtn)
        FileMenu.Location = New Point(7, 70)
        FileMenu.Name = "FileMenu"
        FileMenu.Size = New Size(132, 139)
        FileMenu.TabIndex = 5
        ' 
        ' SaveAsBtn
        ' 
        SaveAsBtn.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        SaveAsBtn.ForeColor = SystemColors.ControlText
        SaveAsBtn.ImageAlign = ContentAlignment.BottomLeft
        SaveAsBtn.Location = New Point(9, 96)
        SaveAsBtn.Name = "SaveAsBtn"
        SaveAsBtn.Size = New Size(123, 24)
        SaveAsBtn.TabIndex = 8
        SaveAsBtn.Text = "另存为"
        ' 
        ' SaveBtn
        ' 
        SaveBtn.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        SaveBtn.ForeColor = SystemColors.ControlText
        SaveBtn.ImageAlign = ContentAlignment.BottomLeft
        SaveBtn.Location = New Point(9, 56)
        SaveBtn.Name = "SaveBtn"
        SaveBtn.Size = New Size(120, 24)
        SaveBtn.TabIndex = 7
        SaveBtn.Text = "保存"
        ' 
        ' OpenBtn
        ' 
        OpenBtn.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        OpenBtn.ForeColor = SystemColors.ControlText
        OpenBtn.ImageAlign = ContentAlignment.BottomLeft
        OpenBtn.Location = New Point(9, 18)
        OpenBtn.Name = "OpenBtn"
        OpenBtn.Size = New Size(126, 24)
        OpenBtn.TabIndex = 6
        OpenBtn.Text = "打开"
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' Edit
        ' 
        Edit.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Edit.ForeColor = SystemColors.ControlText
        Edit.ImageAlign = ContentAlignment.BottomLeft
        Edit.Location = New Point(79, 44)
        Edit.Name = "Edit"
        Edit.Size = New Size(66, 28)
        Edit.TabIndex = 6
        Edit.Text = "编辑"
        ' 
        ' EditMenu
        ' 
        EditMenu.BackColor = Color.LightGray
        EditMenu.Controls.Add(replaceString)
        EditMenu.Controls.Add(EditFont)
        EditMenu.Controls.Add(FindText)
        EditMenu.Location = New Point(79, 70)
        EditMenu.Name = "EditMenu"
        EditMenu.Size = New Size(132, 139)
        EditMenu.TabIndex = 9
        ' 
        ' replaceString
        ' 
        replaceString.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        replaceString.ForeColor = SystemColors.ControlText
        replaceString.ImageAlign = ContentAlignment.BottomLeft
        replaceString.Location = New Point(9, 96)
        replaceString.Name = "replaceString"
        replaceString.Size = New Size(123, 24)
        replaceString.TabIndex = 8
        replaceString.Text = "替换"
        ' 
        ' EditFont
        ' 
        EditFont.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        EditFont.ForeColor = SystemColors.ControlText
        EditFont.ImageAlign = ContentAlignment.BottomLeft
        EditFont.Location = New Point(9, 56)
        EditFont.Name = "EditFont"
        EditFont.Size = New Size(120, 24)
        EditFont.TabIndex = 7
        EditFont.Text = "字体"
        ' 
        ' FindText
        ' 
        FindText.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        FindText.ForeColor = SystemColors.ControlText
        FindText.ImageAlign = ContentAlignment.BottomLeft
        FindText.Location = New Point(9, 18)
        FindText.Name = "FindText"
        FindText.Size = New Size(126, 24)
        FindText.TabIndex = 6
        FindText.Text = "查找"
        ' 
        ' Look
        ' 
        Look.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Look.ForeColor = SystemColors.ControlText
        Look.ImageAlign = ContentAlignment.BottomLeft
        Look.Location = New Point(151, 44)
        Look.Name = "Look"
        Look.Size = New Size(69, 28)
        Look.TabIndex = 10
        Look.Text = "查看"
        ' 
        ' LookMenu
        ' 
        LookMenu.BackColor = Color.LightGray
        LookMenu.Controls.Add(Label1)
        LookMenu.Controls.Add(Label2)
        LookMenu.Controls.Add(WordWrap)
        LookMenu.Location = New Point(151, 70)
        LookMenu.Name = "LookMenu"
        LookMenu.Size = New Size(168, 139)
        LookMenu.TabIndex = 10
        ' 
        ' Label1
        ' 
        Label1.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label1.ForeColor = SystemColors.ControlText
        Label1.ImageAlign = ContentAlignment.BottomLeft
        Label1.Location = New Point(9, 96)
        Label1.Name = "Label1"
        Label1.Size = New Size(123, 24)
        Label1.TabIndex = 8
        ' 
        ' Label2
        ' 
        Label2.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        Label2.ForeColor = SystemColors.ControlText
        Label2.ImageAlign = ContentAlignment.BottomLeft
        Label2.Location = New Point(9, 56)
        Label2.Name = "Label2"
        Label2.Size = New Size(120, 24)
        Label2.TabIndex = 7
        ' 
        ' WordWrap
        ' 
        WordWrap.Font = New Font("黑体", 13.8F, FontStyle.Regular, GraphicsUnit.Point)
        WordWrap.ForeColor = SystemColors.ControlText
        WordWrap.ImageAlign = ContentAlignment.BottomLeft
        WordWrap.Location = New Point(9, 18)
        WordWrap.Name = "WordWrap"
        WordWrap.Size = New Size(222, 24)
        WordWrap.TabIndex = 6
        WordWrap.Text = "√自动换行"
        ' 
        ' MaxWindow
        ' 
        MaxWindow.AutoSize = True
        MaxWindow.Font = New Font("黑体", 12.5F, FontStyle.Regular, GraphicsUnit.Point)
        MaxWindow.ForeColor = SystemColors.ControlText
        MaxWindow.Location = New Point(670, 8)
        MaxWindow.Name = "MaxWindow"
        MaxWindow.Size = New Size(32, 21)
        MaxWindow.TabIndex = 3
        MaxWindow.Text = "口"
        ' 
        ' VBNotepad
        ' 
        AutoScaleDimensions = New SizeF(9F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(745, 722)
        Controls.Add(LookMenu)
        Controls.Add(Look)
        Controls.Add(EditMenu)
        Controls.Add(Edit)
        Controls.Add(FileMenu)
        Controls.Add(FileOption)
        Controls.Add(NewPage)
        Controls.Add(TC)
        Controls.Add(MovePanel)
        FormBorderStyle = FormBorderStyle.None
        Icon = CType(resources.GetObject("$this.Icon"), Icon)
        Name = "VBNotepad"
        Text = "VBNotepad"
        MovePanel.ResumeLayout(False)
        MovePanel.PerformLayout()
        TC.ResumeLayout(False)
        FileMenu.ResumeLayout(False)
        EditMenu.ResumeLayout(False)
        LookMenu.ResumeLayout(False)
        ResumeLayout(False)
    End Sub

    Friend WithEvents MovePanel As Panel
    Friend WithEvents TC As TabControl
    Friend WithEvents 主页 As TabPage
    Friend WithEvents MinWindow As Label
    Friend WithEvents CloseBtn As Label
    Friend WithEvents NewPage As Label
    Friend WithEvents FileOption As Label
    Friend WithEvents FileMenu As Panel
    Friend WithEvents OpenBtn As Label
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents SaveFileDialog1 As SaveFileDialog
    Friend WithEvents SaveBtn As Label
    Friend WithEvents SaveAsBtn As Label
    Friend WithEvents Edit As Label
    Friend WithEvents EditMenu As Panel
    Friend WithEvents replaceString As Label
    Friend WithEvents EditFont As Label
    Friend WithEvents FindText As Label
    Friend WithEvents FontDialog1 As FontDialog
    Friend WithEvents Look As Label
    Friend WithEvents LookMenu As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents WordWrap As Label
    Friend WithEvents MaxWindow As Label
End Class
