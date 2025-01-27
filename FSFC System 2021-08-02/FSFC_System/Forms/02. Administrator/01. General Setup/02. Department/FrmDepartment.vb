﻿Public Class FrmDepartment

    Dim ID As Integer
    Public vSave As Boolean
    Public vUpdate As Boolean
    Public vDelete As Boolean
    Public vPrint As Boolean
    Public vCheck As Boolean
    Public vApprove As Boolean
    Private Sub FrmDepartment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Icon = My.Resources.iLoanWorkX_ico
        FixUI(AllowStandardUI)
        FixPictureEdit(PictureEdit1, 263, 64, 9, 1, True)
        SuperTabControl1.SelectedTab = tabList

        LoadData()
    End Sub

    Private Sub FixUI(ApplyUI As Boolean)
        Try
            If ApplyUI = False Then
                Exit Sub
            End If
            GetLabelHeaderFontSettings({lblTitle})

            GetLabelFontSettings({LabelX155, LabelX1})

            GetTextBoxFontSettings({txtDepartment, txtDepartmentCode})

            GetButtonFontSettings({btnAdd, btnSave, btnRefresh, btnCancel, btnModify, btnDelete, btnPrint})

            GetTabControlFontSettings({SuperTabControl1})
        Catch ex As Exception
            TriggerBugReport("Department - FixUI", ex.Message.ToString)
        End Try
    End Sub

    Private Sub BtnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        LblTitle_Click(sender, e)
    End Sub

    Private Sub LblTitle_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        lblTitle.ForeColor = OfficialColor1
    End Sub

    Private Sub LblTitle_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        lblTitle.ForeColor = Color.Black
    End Sub

    Private Sub LblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        OpenFormHistory("Department", lblTitle.Text)
    End Sub

    Private Sub LoadData()
        Cursor = Cursors.WaitCursor
        GridControl1.DataSource = DataSource("SELECT ID, department_code AS 'Department Code', Department, (SELECT FORMAT(IFNULL(COUNT(ID),0),0) FROM employee_setup WHERE department_id = department_setup.ID AND `status` = 'ACTIVE') AS 'No. of Employee(s)' FROM department_setup WHERE `status` = 'ACTIVE' ORDER BY `Department Code`;")
        GridView1.Columns("Department").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        GridView1.Columns("Department").SummaryItem.DisplayFormat = "Total of {0} record(s) fetched"
        Cursor = Cursors.Default
    End Sub

    '***KEYDOWN
    Private Sub TxtDepartment_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepartment.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        End If
    End Sub

    Private Sub TxtDepartmentCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtDepartmentCode.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub
    '***KEYDOWN

    '***LEAVE
    Private Sub TxtDepartment_Leave(sender As Object, e As EventArgs) Handles txtDepartment.Leave
        txtDepartment.Text = ReplaceText(txtDepartment.Text.Trim)
    End Sub

    Private Sub TxtDepartmentCode_Leave(sender As Object, e As EventArgs) Handles txtDepartmentCode.Leave
        txtDepartmentCode.Text = ReplaceText(txtDepartmentCode.Text.Trim)
    End Sub
    '***LEAVE

    '***BUTTON CLICK
    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBoxYes(mClose) = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub BtnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If SuperTabControl1.SelectedTabIndex = 0 Then
            SuperTabControl1.SelectedTab = tabList
        End If
    End Sub

    Private Sub BtnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        If SuperTabControl1.SelectedTabIndex = 1 Then
            SuperTabControl1.SelectedTab = tabSetup
        End If
    End Sub

    Private Sub SuperTabControl1_SelectedTabChanged(sender As Object, e As DevComponents.DotNetBar.SuperTabStripSelectedTabChangedEventArgs) Handles SuperTabControl1.SelectedTabChanged
        If SuperTabControl1.SelectedTabIndex = 0 Then
            btnBack.Enabled = False
            btnAdd.Enabled = False
            btnSave.Enabled = True
            btnModify.Enabled = False
            btnPrint.Enabled = False
            btnDelete.Enabled = False
            btnNext.Enabled = True
        ElseIf SuperTabControl1.SelectedTabIndex = 1 Then
            Clear(False)
            btnBack.Enabled = True
            btnAdd.Enabled = True
            btnSave.Enabled = False
            btnModify.Enabled = False
            btnPrint.Enabled = True
            btnDelete.Enabled = False
            btnNext.Enabled = False
        End If
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If SuperTabControl1.SelectedTabIndex = 0 Then
            If MsgBoxYes(mRefresh) = MsgBoxResult.Yes Then
                Clear(False)
            End If
        ElseIf SuperTabControl1.SelectedTabIndex = 1 Then
            LoadData()
        End If
    End Sub

    Private Sub Clear(TriggerLoadData As Boolean)
        PanelEx10.Enabled = True
        txtDepartment.Text = ""
        txtDepartmentCode.Text = ""
        btnSave.Text = "&Save"
        btnSave.Enabled = True
        btnModify.Enabled = False
        btnDelete.Enabled = False

        If TriggerLoadData Then
            LoadData()
        End If
    End Sub

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If vSave Then
        Else
            MsgBox(mBox_Save, MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If txtDepartment.Text.Trim = "" Then
            MsgBox("Please fill department field.", MsgBoxStyle.Information, "Info")
            txtDepartment.Focus()
            Exit Sub
        End If
        If txtDepartmentCode.Text.Trim = "" Then
            MsgBox("Please fill department code field.", MsgBoxStyle.Information, "Info")
            txtDepartmentCode.Focus()
            Exit Sub
        End If

        If btnSave.Text = "&Save" Then
            If MsgBoxYes(mSave) = MsgBoxResult.Yes Then
                Dim Exist As Integer = DataObject(String.Format("SELECT ID FROM department_setup WHERE (department = '{0}' OR department_code = '{1}') AND `status` = 'ACTIVE'", txtDepartment.Text, txtDepartmentCode.Text))
                If Exist > 0 Then
                    MsgBox(String.Format("Either department name ({0}) or department code ({1}) already exist, Please check your data.", txtDepartment.Text, txtDepartmentCode.Text), MsgBoxStyle.Information, "Info")
                    Exit Sub
                End If

                Cursor = Cursors.WaitCursor
                Dim SQL As String = "INSERT INTO department_setup SET"
                SQL &= String.Format(" department = '{0}', ", txtDepartment.Text.Trim)
                SQL &= String.Format(" department_code = '{0}'", txtDepartmentCode.Text.Trim)
                DataObject(SQL)
                Cursor = Cursors.Default

                Logs("Department", "Save", String.Format("Add new department {0}", txtDepartment.Text), "", "", "", "")
                Clear(True)
                txtDepartment.Focus()
                MsgBox("Successfully Saved!", MsgBoxStyle.Information, "Info")
            End If
        Else
            If MsgBoxYes(mUpdate) = MsgBoxResult.Yes Then
                Dim Exist As Integer = DataObject(String.Format("SELECT ID FROM department_setup WHERE (department = '{0}' OR department_code = '{1}') AND `status` = 'ACTIVE' AND ID != '{2}'", txtDepartment.Text, txtDepartmentCode.Text, ID))
                If Exist > 0 Then
                    MsgBox(String.Format("Either department name ({0}) or department code ({1}) already exist, Please check your data.", txtDepartment.Text, txtDepartmentCode.Text), MsgBoxStyle.Information, "Info")
                    Exit Sub
                End If

                Dim Reason As String 'Reason for change
                If FrmReason.ShowDialog = DialogResult.OK Then
                    Reason = FrmReason.txtReason.Text
                Else
                    Exit Sub
                End If

                Cursor = Cursors.WaitCursor
                Dim SQL As String = "UPDATE department_setup SET"
                SQL &= String.Format(" department = '{0}', ", txtDepartment.Text.Trim)
                SQL &= String.Format(" department_code = '{0}'", txtDepartmentCode.Text.Trim)
                SQL &= String.Format(" WHERE ID = '{0}'", ID)
                DataObject(SQL)
                Cursor = Cursors.Default

                Logs("Department", "Update", Reason, Changes(), "", "", "")
                Clear(True)
                txtDepartment.Focus()
                MsgBox("Successfully Updated!", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub

    Private Function Changes()
        Dim Change As String = ""
        Try
            If txtDepartment.Text = txtDepartment.Tag Then
            Else
                Change &= String.Format("Change Department from {0} to {1}. ", txtDepartment.Tag, txtDepartment.Text)
            End If
            If txtDepartmentCode.Text = txtDepartmentCode.Tag Then
            Else
                Change &= String.Format("Change Department Code from {0} to {1}. ", txtDepartmentCode.Tag, txtDepartmentCode.Text)
            End If
        Catch ex As Exception
            TriggerBugReport("Department - Changes", ex.Message.ToString)
        End Try
        Return Change
    End Function

    Private Sub BtnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If vUpdate Then
        Else
            MsgBox(mBox_Update, MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If MsgBoxYes(mModify) = MsgBoxResult.Yes Then
            btnSave.Text = "Update"
            btnSave.Enabled = True
            btnModify.Enabled = False
            btnDelete.Enabled = True
            PanelEx10.Enabled = True
        End If
    End Sub

    Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If vDelete Then
        Else
            MsgBox(mBox_Delete, MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If MsgBoxYes(mDelete) = MsgBoxResult.Yes Then
            Dim Reason As String 'Reason for change
            If FrmReason.ShowDialog = DialogResult.OK Then
                Reason = FrmReason.txtReason.Text
            Else
                Exit Sub
            End If

            Cursor = Cursors.WaitCursor
            DataObject(String.Format("UPDATE department_setup SET `status` = 'DELETED' WHERE ID = '{0}'", ID))
            Logs("Department", "Cancel", Reason, String.Format("Cancel department {0}", txtDepartment.Text), "", "", "")
            Clear(True)
            Cursor = Cursors.Default
            MsgBox("Successfully Cancelled", MsgBoxStyle.Information, "Info")
        End If
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If vPrint Then
        Else
            MsgBox(mBox_Print, MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        GridView1.OptionsPrint.UsePrintStyles = False
        StandardPrinting("DEPARTMENT LIST", GridControl1)
        Logs("Department", "Print", "Print Department List", "", "", "", "")
        Cursor = Cursors.Default
    End Sub
    '***BUTTON CLICK

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        With FrmMain
            .Keyboard_Press = True
            .Keyboard_Session = .Timer_Session.Interval
        End With
        If e.Control And e.KeyCode = Keys.S Then
            btnSave.Focus()
            btnSave.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.B Then
            btnBack.Focus()
            btnBack.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.N Then
            btnNext.Focus()
            btnNext.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.F Then
            btnRefresh.Focus()
            btnRefresh.PerformClick()
        ElseIf (e.Control And e.KeyCode = Keys.X) Or e.KeyCode = Keys.Escape Then
            btnCancel.Focus()
            btnCancel.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.P Then
            btnPrint.Focus()
            btnPrint.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.D Then
            btnDelete.Focus()
            btnDelete.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.M Then
            btnModify.Focus()
            btnModify.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.A Then
            btnAdd.Focus()
            btnAdd.PerformClick()
        ElseIf (e.Control And e.KeyCode = Keys.Left) Or (e.Control And e.KeyCode = Keys.Down) Then
            btnBack.Focus()
            btnBack.PerformClick()
        ElseIf (e.Control And e.KeyCode = Keys.Right) Or (e.Control And e.KeyCode = Keys.Up) Then
            btnNext.Focus()
            btnNext.PerformClick()
        ElseIf e.KeyCode = Keys.F12 Then
            FrmMain.BtnReport_Click(sender, e)
        End If
    End Sub

    Private Sub GridView1_KeyDown(sender As Object, e As KeyEventArgs) Handles GridView1.KeyDown
        If e.KeyCode = Keys.Enter Then
            GridView1_DoubleClick(sender, e)
        End If
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Clear(False)
        SuperTabControl1.SelectedTab = tabSetup
    End Sub

    Private Sub GridView1_DoubleClick(sender As Object, e As EventArgs) Handles GridView1.DoubleClick
        Try
            If GridView1.GetFocusedRowCellValue("ID").ToString = "" Then
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try
        Cursor = Cursors.WaitCursor
        PanelEx10.Enabled = False
        With GridView1
            ID = .GetFocusedRowCellValue("ID")
            txtDepartmentCode.Text = .GetFocusedRowCellValue("Department Code")
            txtDepartmentCode.Tag = .GetFocusedRowCellValue("Department Code")
            txtDepartment.Text = .GetFocusedRowCellValue("Department")
            txtDepartment.Tag = .GetFocusedRowCellValue("Department")
        End With

        SuperTabControl1.SelectedTab = tabSetup
        btnModify.Enabled = True
        btnSave.Enabled = False
        Cursor = Cursors.Default
    End Sub

    Private Sub IViewEmployees_Click(sender As Object, e As EventArgs) Handles iViewEmployees.Click
        Try
            If GridView1.GetFocusedRowCellValue("ID").ToString = "" Then
                Exit Sub
            ElseIf GridView1.GetFocusedRowCellValue("No. of Employee(s)") = 0 Then
                MsgBox(String.Format("No employee assigned for {0}", GridView1.GetFocusedRowCellValue("Department")), MsgBoxStyle.Information, "Info")
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        Dim Empl As New FrmEmployee
        With Empl
            .From_Department = True
            .DeptID_PosID = GridView1.GetFocusedRowCellValue("ID")
            .ShowDialog()
            .Dispose()
        End With
    End Sub
End Class