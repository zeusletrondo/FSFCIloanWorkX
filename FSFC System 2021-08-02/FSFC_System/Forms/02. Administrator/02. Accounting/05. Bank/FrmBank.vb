﻿
Public Class FrmBank

    Dim ID As Integer = 0
    Public vSave As Boolean
    Public vUpdate As Boolean
    Public vDelete As Boolean
    Public vPrint As Boolean
    Public vCheck As Boolean
    Public vApprove As Boolean

    Private Sub FrmBank_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetGridAppearance({GridView1})
        FixUI(AllowStandardUI)
        Icon = My.Resources.iLoanWorkX_ico
        FixPictureEdit(PictureEdit1, 263, 64, 9, 1, True)
        SuperTabControl1.SelectedTab = tabList
        With cbxType
            .DisplayMember = "type"
            .DataSource = BankType.Copy
            .SelectedIndex = -1
        End With
        LoadList()
    End Sub

    Private Sub BtnLogs_Click(sender As Object, e As EventArgs) Handles btnLogs.Click
        LblTitle_Click(sender, e)
    End Sub

    Private Sub FixUI(ApplyUI As Boolean)
        Try
            If ApplyUI = False Then
                Exit Sub
            End If
            GetLabelHeaderFontSettings({lblTitle})

            GetLabelFontSettings({LabelX155, LabelX1, LabelX2})

            GetTextBoxFontSettings({txtBank, txtAbbreviation})

            GetComboBoxFontSettings({cbxType})

            GetButtonFontSettings({btnAdd, btnSave, btnRefresh, btnCancel, btnModify, btnDelete, btnPrint})

            GetTabControlFontSettings({SuperTabControl1})
        Catch ex As Exception
            TriggerBugReport("Bank - FixUI", ex.Message.ToString)
        End Try
    End Sub

    Private Sub LblTitle_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        lblTitle.ForeColor = OfficialColor1
    End Sub

    Private Sub LblTitle_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        lblTitle.ForeColor = Color.Black
    End Sub

    Private Sub LblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        OpenFormHistory("Bank", lblTitle.Text)
    End Sub

    Private Sub LoadList()
        Cursor = Cursors.WaitCursor
        Dim SQL As String = "SELECT"
        SQL &= "    ID,"
        SQL &= "    BANK,"
        SQL &= "    short_name AS 'ABBREVIATION',"
        SQL &= "    `TYPE`"
        SQL &= " FROM bank_setup"
        SQL &= " WHERE `status` = 'ACTIVE';"
        GridControl1.DataSource = DataSource(SQL)
        GridView1.Columns("BANK").SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        GridView1.Columns("BANK").SummaryItem.DisplayFormat = "Total of {0} record(s) fetched"
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        If SuperTabControl1.SelectedTabIndex = 0 Then
            If MsgBoxYes(mRefresh) = MsgBoxResult.Yes Then
                Clear(False)
            End If
        ElseIf SuperTabControl1.SelectedTabIndex = 1 Then
            LoadList()
        End If
    End Sub

    Private Sub Clear(TriggerLoadData As Boolean)
        PanelEx10.Enabled = True
        txtBank.Text = ""
        txtAbbreviation.Text = ""
        cbxType.SelectedIndex = -1
        btnSave.Text = "&Save"
        btnSave.Enabled = True
        btnModify.Enabled = False
        btnDelete.Enabled = False

        If TriggerLoadData Then
            LoadList()
        End If
    End Sub

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
            SuperTabControl1.SelectedTab = tabBank
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

#Region "Keydown"
    Private Sub TxtBank_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBank.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtAbbreviation.Focus()
        End If
    End Sub

    Private Sub TxtAbbreviation_KeyDown(sender As Object, e As KeyEventArgs) Handles txtAbbreviation.KeyDown
        If e.KeyCode = Keys.Enter Then
            cbxType.Focus()
        End If
    End Sub

    Private Sub CbxType_KeyDown(sender As Object, e As KeyEventArgs) Handles cbxType.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnSave.Focus()
        End If
    End Sub
#End Region

#Region "Leave"

    Private Sub TxtBank_Leave(sender As Object, e As EventArgs) Handles txtBank.Leave
        txtBank.Text = ReplaceText(txtBank.Text)
    End Sub

    Private Sub TxtAbbreviation_Leave(sender As Object, e As EventArgs) Handles txtAbbreviation.Leave
        txtAbbreviation.Text = ReplaceText(txtAbbreviation.Text)
    End Sub

    Private Sub CbxType_Leave(sender As Object, e As EventArgs) Handles cbxType.Leave
        cbxType.Text = ReplaceText(cbxType.Text)
    End Sub
#End Region

    Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        If vSave Then
        Else
            MsgBox(mBox_Save, MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        If txtBank.Text.Trim = "" Then
            MsgBox("Please fill Bank field.", MsgBoxStyle.Information, "Info")
            txtBank.Focus()
            Exit Sub
        End If
        If txtAbbreviation.Text.Trim = "" Then
            MsgBox("Please fill bank abbreviation field.", MsgBoxStyle.Information, "Info")
            txtAbbreviation.Focus()
            Exit Sub
        End If
        If cbxType.Text.Trim = "" Or cbxType.SelectedIndex = -1 Then
            MsgBox("Please select bank type.", MsgBoxStyle.Information, "Info")
            cbxType.DroppedDown = True
            Exit Sub
        End If

        If btnSave.Text = "&Save" Then
            If MsgBoxYes(mSave) = MsgBoxResult.Yes Then
                Dim Exist As Integer = DataObject(String.Format("SELECT ID FROM bank_setup WHERE bank = '{0}' AND `status` = 'ACTIVE'", txtBank.Text))
                If Exist > 0 Then
                    MsgBox(String.Format("Bank {0} already exist, Please check your data.", txtBank.Text), MsgBoxStyle.Information, "Info")
                    Exit Sub
                End If

                Cursor = Cursors.WaitCursor
                Dim SQL As String = "INSERT INTO bank_setup SET"
                SQL &= String.Format(" bank = '{0}', ", txtBank.Text.Trim)
                SQL &= String.Format(" short_name = '{0}', ", txtAbbreviation.Text.Trim)
                SQL &= String.Format(" `type` = '{0}' ", cbxType.Text)
                DataObject(SQL)
                Cursor = Cursors.Default

                Logs("Bank", "Save", String.Format("Add new bank {0}", txtBank.Text), "", "", "", "")
                Clear(True)
                MsgBox("Successfully Saved!", MsgBoxStyle.Information, "Info")
            End If
        Else
            If MsgBoxYes(mUpdate) = MsgBoxResult.Yes Then
                Dim Exist As Integer = DataObject(String.Format("SELECT ID FROM bank_setup WHERE bank = '{0}' AND `status` = 'ACTIVE' AND ID != '{1}'", txtBank.Text, ID))
                If Exist > 0 Then
                    MsgBox(String.Format("Bank {0} already exist, Please check your data.", txtBank.Text), MsgBoxStyle.Information, "Info")
                    Exit Sub
                End If

                Dim Reason As String 'Reason for change
                If FrmReason.ShowDialog = DialogResult.OK Then
                    Reason = FrmReason.txtReason.Text
                Else
                    Exit Sub
                End If

                Cursor = Cursors.WaitCursor
                Dim SQL As String = "UPDATE bank_setup SET"
                SQL &= String.Format(" bank = '{0}', ", txtBank.Text.Trim)
                SQL &= String.Format(" short_name = '{0}', ", txtAbbreviation.Text.Trim)
                SQL &= String.Format(" `type` = '{0}' ", cbxType.Text)
                SQL &= String.Format(" WHERE ID = '{0}'", ID)
                DataObject(SQL)
                Cursor = Cursors.Default

                Logs("Bank", "Update", Reason, Changes(), "", "", "")
                Clear(True)
                MsgBox("Successfully Updated!", MsgBoxStyle.Information, "Info")
            End If
        End If
    End Sub

    Private Function Changes()
        Dim Change As String = ""
        Try
            If txtBank.Text = txtBank.Tag Then
            Else
                Change &= String.Format("Change Bank Name from {0} to {1}. ", txtBank.Tag, txtBank.Text)
            End If
            If txtAbbreviation.Text = txtAbbreviation.Tag Then
            Else
                Change &= String.Format("Change Bank Abbreviation from {0} to {1}. ", txtAbbreviation.Tag, txtAbbreviation.Text)
            End If
            If cbxType.Text = cbxType.Tag Then
            Else
                Change &= String.Format("Change Bank Type from {0} to {1}. ", cbxType.Tag, cbxType.Text)
            End If
        Catch ex As Exception
            TriggerBugReport("Bank - Changes", ex.Message.ToString)
        End Try

        Return Change
    End Function

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        If vPrint Then
        Else
            MsgBox(mBox_Print, MsgBoxStyle.Information, "Info")
            Exit Sub
        End If

        Cursor = Cursors.WaitCursor
        GridView1.OptionsPrint.UsePrintStyles = False
        StandardPrinting("BANK LIST", GridControl1)
        Logs("Bank List", "Print", "Print Bank List", "", "", "", "")
        Cursor = Cursors.Default
    End Sub

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
            DataObject(String.Format("UPDATE bank_setup SET `status` = 'DELETED' WHERE ID = '{0}'", ID))
            Logs("Bank", "Cancel", Reason, String.Format(String.Format("Cancel bank {0}", txtBank.Text)), "", "", "")
            Clear(True)
            Cursor = Cursors.Default
            MsgBox("Successfully Cancelled", MsgBoxStyle.Information, "Info")
        End If
    End Sub

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
            txtBank.Text = .GetFocusedRowCellValue("BANK")
            txtBank.Tag = .GetFocusedRowCellValue("BANK")
            txtAbbreviation.Text = .GetFocusedRowCellValue("ABBREVIATION")
            txtAbbreviation.Tag = .GetFocusedRowCellValue("ABBREVIATION")
            cbxType.Text = .GetFocusedRowCellValue("TYPE")
            cbxType.Tag = .GetFocusedRowCellValue("TYPE")
        End With
        btnSave.Text = "Update"
        SuperTabControl1.SelectedTab = tabBank
        btnModify.Enabled = True
        btnSave.Enabled = False
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        Clear(False)
        SuperTabControl1.SelectedTab = tabBank
    End Sub
End Class