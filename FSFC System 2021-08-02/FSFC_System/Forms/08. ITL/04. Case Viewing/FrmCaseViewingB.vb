﻿Imports DevExpress.XtraCharts
Imports DevExpress.XtraReports.UI
Public Class FrmCaseViewingB

    Private Sub FrmCaseViewing_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GetBandedGridApperance({BandedGridView1})
        FixUI(AllowStandardUI)
        Icon = My.Resources.iLoanWorkX_ico
        FixPictureEdit(PictureEdit1, 263, 64, 9, 1, True)

        LoadData()
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

            GetButtonFontSettings({btnSearch, btnCancel, btnPrint, btnGraph})
        Catch ex As Exception
            TriggerBugReport("Case Viewing B - FixUI", ex.Message.ToString)
        End Try
    End Sub

    Private Sub LblTitle_MouseEnter(sender As Object, e As EventArgs) Handles lblTitle.MouseEnter
        lblTitle.ForeColor = OfficialColor1
    End Sub

    Private Sub LblTitle_MouseLeave(sender As Object, e As EventArgs) Handles lblTitle.MouseLeave
        lblTitle.ForeColor = Color.Black
    End Sub

    Private Sub LblTitle_Click(sender As Object, e As EventArgs) Handles lblTitle.Click
        OpenFormHistory("Case Mapping", lblTitle.Text)
    End Sub

    Private Sub LoadData()
        Cursor = Cursors.WaitCursor
        Dim SQL As String = "   SELECT B.ID,"
        SQL &= "   '' AS 'No',"
        SQL &= "   B.Branch, B.Branch_Code,"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'DECIDED AND FOR MONITORING' THEN Amount END),0) AS 'A_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'DECIDED AND FOR MONITORING' THEN Account END),0) AS 'A_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'FOR PREPARATION OF MFE' THEN Amount END),0) AS 'B_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'FOR PREPARATION OF MFE' THEN Account END),0) AS 'B_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'FOR DELIVERY OF MFE' THEN Amount END),0) AS 'C_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'FOR DELIVERY OF MFE' THEN Account END),0) AS 'C_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'MFE FOR MONITORING' THEN Amount END),0) AS 'D_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'MFE FOR MONITORING' THEN Account END),0) AS 'D_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'FILED IN COURT' THEN Amount END),0) AS 'E_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'FILED IN COURT' THEN Account END),0) AS 'E_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'MFE WAITING FOR DECISION' THEN Amount END),0) AS 'F_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'MFE WAITING FOR DECISION' THEN Account END),0) AS 'F_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'TO PAY WRIT FEE' THEN Amount END),0) AS 'G_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'TO PAY WRIT FEE' THEN Account END),0) AS 'G_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'TO PAY SHERIFF`S BILL' THEN Amount END),0) AS 'H_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'TO PAY SHERIFF`S BILL' THEN Account END),0) AS 'H_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'MFE FOR MONITORING' THEN Amount END),0) AS 'I_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory = 'MFE FOR MONITORING' THEN Account END),0) AS 'I_Account',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory IN ('DECIDED AND FOR MONITORING','FOR PREPARATION OF MFE','FOR DELIVERY OF MFE','MFE DELIVERED','FILED IN COURT','MFE WAITING FOR DECISION','TO PAY WRIT FEE','TO PAY SHERIFF`S BILL','MFE FOR MONITORING') THEN Amount END),0) AS 'T_Amount',"
        SQL &= "   IFNULL(SUM(CASE WHEN C.SubCategory IN ('DECIDED AND FOR MONITORING','FOR PREPARATION OF MFE','FOR DELIVERY OF MFE','MFE DELIVERED','FILED IN COURT','MFE WAITING FOR DECISION','TO PAY WRIT FEE','TO PAY SHERIFF`S BILL','MFE FOR MONITORING') THEN Account END),0) AS 'T_Account'"
        SQL &= " FROM branch B LEFT JOIN (SELECT COUNT(M.ID) AS 'Account', SUM(Ledger_Balance(M.AccountNumber,M.MortgageID)) AS 'Amount', M.BranchID, SubCategory(SubCategoryID) AS 'SubCategory', SubCategoryID, CategoryID FROM case_main M WHERE M.`status` = 'ACTIVE' AND CategoryID = 7 GROUP BY SubCategoryID, BranchID) C"
        SQL &= "   ON B.BranchID = C.BranchID"
        SQL &= "   WHERE B.`status` = 'ACTIVE' "
        SQL &= "   GROUP BY B.BranchID ORDER BY `ID`"

        Dim DT As DataTable = DataSource(SQL)
        Dim A_Amount As Double
        Dim A_Account As Double
        Dim B_Amount As Double
        Dim B_Account As Double
        Dim C_Amount As Double
        Dim C_Account As Double
        Dim D_Amount As Double
        Dim D_Account As Double
        Dim E_Amount As Double
        Dim E_Account As Double
        Dim F_Amount As Double
        Dim F_Account As Double
        Dim G_Amount As Double
        Dim G_Account As Double
        Dim H_Amount As Double
        Dim H_Account As Double
        Dim I_Amount As Double
        Dim I_Account As Double
        Dim T_Amount As Double
        Dim T_Account As Double
        For x As Integer = 0 To DT.Rows.Count - 1
            DT(x)("No") = x + 1
            A_Amount += DT(x)("A_Amount")
            A_Account += DT(x)("A_Account")
            B_Amount += DT(x)("B_Amount")
            B_Account += DT(x)("B_Account")
            C_Amount += DT(x)("C_Amount")
            C_Account += DT(x)("C_Account")
            D_Amount += DT(x)("D_Amount")
            D_Account += DT(x)("D_Account")
            E_Amount += DT(x)("E_Amount")
            E_Account += DT(x)("E_Account")
            F_Amount += DT(x)("F_Amount")
            F_Account += DT(x)("F_Account")
            G_Amount += DT(x)("G_Amount")
            G_Account += DT(x)("G_Account")
            H_Amount += DT(x)("H_Amount")
            H_Account += DT(x)("H_Account")
            I_Amount += DT(x)("I_Amount")
            I_Account += DT(x)("I_Account")
            T_Amount += DT(x)("T_Amount")
            T_Account += DT(x)("T_Account")
        Next
        DT.Rows.Add(1000, "", "               T O T A L", "", A_Amount, A_Account, B_Amount, B_Account, C_Amount, C_Account, D_Amount, D_Account, E_Amount, E_Account, F_Amount, F_Account, G_Amount, G_Account, H_Amount, H_Account, I_Amount, I_Account, T_Amount, T_Account)

        GridControl1.DataSource = DT
        Cursor = Cursors.Default
    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        If MsgBoxYes(mClose) = MsgBoxResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub BtnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        LoadData()
    End Sub

    Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Cursor = Cursors.WaitCursor
        Dim Report As New RptCaseMappingB
        With Report
            .lblTitle.Text = lblTitle.Text
            Dim DT As DataTable = GridControl1.DataSource
            Dim DT_Sample As DataTable = DT.Copy
            DT_Sample.Rows.RemoveAt(BandedGridView1.RowCount - 1)
            .DataSource = DT_Sample
            .lblNo.DataBindings.Add("Text", DT_Sample, "No")
            .lblBranch.DataBindings.Add("Text", DT_Sample, "Branch")
            .lblAmount_A.DataBindings.Add("Text", DT_Sample, "A_Amount")
            .lblAccount_A.DataBindings.Add("Text", DT_Sample, "A_Account")
            .lblAmount_B.DataBindings.Add("Text", DT_Sample, "B_Amount")
            .lblAccount_B.DataBindings.Add("Text", DT_Sample, "B_Account")
            .lblAmount_C.DataBindings.Add("Text", DT_Sample, "C_Amount")
            .lblAccount_C.DataBindings.Add("Text", DT_Sample, "C_Account")
            .lblAmount_D.DataBindings.Add("Text", DT_Sample, "D_Amount")
            .lblAccount_D.DataBindings.Add("Text", DT_Sample, "D_Account")
            .lblAmount_E.DataBindings.Add("Text", DT_Sample, "E_Amount")
            .lblAccount_E.DataBindings.Add("Text", DT_Sample, "E_Account")
            .lblAmount_F.DataBindings.Add("Text", DT_Sample, "F_Amount")
            .lblAccount_F.DataBindings.Add("Text", DT_Sample, "F_Account")
            .lblAmount_G.DataBindings.Add("Text", DT_Sample, "G_Amount")
            .lblAccount_G.DataBindings.Add("Text", DT_Sample, "G_Account")
            .lblAmount_H.DataBindings.Add("Text", DT_Sample, "H_Amount")
            .lblAccount_H.DataBindings.Add("Text", DT_Sample, "H_Account")
            .lblAmount_I.DataBindings.Add("Text", DT_Sample, "I_Amount")
            .lblAccount_I.DataBindings.Add("Text", DT_Sample, "I_Account")
            .lblAmount_T.DataBindings.Add("Text", DT_Sample, "T_Amount")
            .lblAccount_T.DataBindings.Add("Text", DT_Sample, "T_Account")

            .lblBranchT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "Branch")
            .lblAmount_AT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "A_Amount")
            .lblAccount_AT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "A_Account")
            .lblAmount_BT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "B_Amount")
            .lblAccount_BT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "B_Account")
            .lblAmount_CT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "C_Amount")
            .lblAccount_CT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "C_Account")
            .lblAmount_DT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "D_Amount")
            .lblAccount_DT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "D_Account")
            .lblAmount_ET.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "E_Amount")
            .lblAccount_ET.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "E_Account")
            .lblAmount_FT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "F_Amount")
            .lblAccount_FT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "F_Account")
            .lblAmount_GT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "G_Amount")
            .lblAccount_GT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "G_Account")
            .lblAmount_HT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "H_Amount")
            .lblAccount_HT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "H_Account")
            .lblAmount_IT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "I_Amount")
            .lblAccount_IT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "I_Account")
            .lblAmount_TT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "T_Amount")
            .lblAccount_TT.Text = BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "T_Account")
            Logs("Case Mapping", "Print", "[SENSITIVE] Print Case Mapping Decided", "", "", "", "")
            .ShowPreview()
        End With
        Cursor = Cursors.Default
    End Sub

    Private Sub Form_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        With FrmMain
            .Keyboard_Press = True
            .Keyboard_Session = .Timer_Session.Interval
        End With
        If (e.Control And e.KeyCode = Keys.X) Or e.KeyCode = Keys.Escape Then
            btnCancel.Focus()
            btnCancel.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.P Then
            btnPrint.Focus()
            btnPrint.PerformClick()
        ElseIf e.Control And e.KeyCode = Keys.S Then
            btnSearch.Focus()
            btnSearch.PerformClick()
        ElseIf e.KeyCode = Keys.F12 Then
            FrmMain.BtnReport_Click(sender, e)
        End If
    End Sub

    Private Sub BtnGraph_Click(sender As Object, e As EventArgs) Handles btnGraph.Click
        Dim Graph As New FrmCaseViewingGraph
        With Graph
            PieChart(.Chart1, "Amount")
            PieChart(.Chart2, "Account")
            LineChart(.Chart3)
            .ShowDialog()
            .Dispose()
        End With
    End Sub

    Private Sub PieChart(Chart As ChartControl, Type As String)
        Cursor = Cursors.WaitCursor
        Dim Product As New DataTable
        With Product
            .Columns.Add("Caption")
            .Columns.Add("Value")
            .Rows.Add("Decided for Monitoring", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "A_" & Type))
            .Rows.Add("For Preparation of MFE", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "B_" & Type))
            .Rows.Add("For Delivery of MFE", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "C_" & Type))
            .Rows.Add("MFE Delivered", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "D_" & Type))
            .Rows.Add("Filed in Court", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "E_" & Type))
            .Rows.Add("MFE Waiting for Decision", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "F_" & Type))
            .Rows.Add("To Pay Writ Fee", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "G_" & Type))
            .Rows.Add("To Pay Sheriff's Bill", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "H_" & Type))
            .Rows.Add("MFE for Monitoring", BandedGridView1.GetRowCellValue(BandedGridView1.RowCount - 1, "I_" & Type))
        End With
        ' Create a pie chart
        Chart.Series.Clear()
        Try
            Dim Series1 As New Series("Percentage of Amount", ViewType.Pie)

            For x As Integer = 0 To Product.Rows.Count - 1
                Series1.Points.Add(New SeriesPoint(Product(x)("Caption"), Product(x)("Value")))
            Next

            Chart.Series.Add(Series1)
            Series1.LegendTextPattern = "{A}: {V:n2}"

            CType(Series1.Label, PieSeriesLabel).ResolveOverlappingMode = ResolveOverlappingMode.Default

            Dim myView As PieSeriesView = CType(Series1.View, PieSeriesView)
            Chart.Titles(0).Text = Type & " Percentage [Decided]"
        Catch ex As Exception
            Cursor = Cursors.Default
        End Try
        Cursor = Cursors.Default
    End Sub

    Private Sub LineChart(Chart As ChartControl)
        Cursor = Cursors.WaitCursor
        Chart.Series.Clear()
        For x As Integer = 0 To BandedGridView1.RowCount - 2
            Dim Series1 As New Series(BandedGridView1.GetRowCellValue(x, "Branch_Code"), ViewType.Bar)
            Dim Series2 As New Series(BandedGridView1.GetRowCellValue(x, "Branch_Code"), ViewType.Bar)
            Series1.Points.Add(New SeriesPoint(BandedGridView1.GetRowCellValue(x, "Branch_Code"), CDbl(BandedGridView1.GetRowCellValue(x, "T_Amount"))))
            Series2.Points.Add(New SeriesPoint(BandedGridView1.GetRowCellValue(x, "Branch_Code"), CDbl(BandedGridView1.GetRowCellValue(x, "T_Account"))))
            With Chart
                .Series.Add(Series1)
                .Series.Add(Series2)
                .Titles(0).Text = "Decided Amount | Account"
            End With
        Next
        Cursor = Cursors.Default
    End Sub

    Private Sub BandedGridView1_DoubleClick(sender As Object, e As EventArgs) Handles BandedGridView1.DoubleClick
        Try
            If BandedGridView1.GetFocusedRowCellValue("ID").ToString = "" Then
                Exit Sub
            End If
        Catch ex As Exception
            Exit Sub
        End Try

        Dim View As New FrmCaseViewingList
        With View
            .lblTitle.Text = "CASE VIEWING DECIDED LIST"
            Dim DT As New DataTable
            With DT
                .Columns.Add("ID")
                .Columns.Add("Branch")
                .Columns.Add("Defendant")
                .Columns.Add("Case Number")
                .Columns.Add("Date Filed")
                .Columns.Add("Decision Value")
                .Columns.Add("Book Value")
                .Columns.Add("Balance")
                .Columns.Add("Counsel")
                .Columns.Add("Case_Status")
                .Columns.Add("LastModified")
                .Columns.Add("AccountNumber")
                .Columns.Add("Prepared By")
                .Columns.Add("Collateral")
                .Columns.Add("AccountN")
                .Columns.Add("DueRP")
                .Columns.Add("Mobile")
                .Columns.Add("CategoryID")
            End With
            Dim SQL As String
            Dim DT_Archived As DataTable = DataSource("SELECT ID, SubCategory FROM case_subcategory WHERE `status` = 'ACTIVE' AND CategoryID = 7 ORDER BY `Rank`;")
            For x As Integer = 0 To DT_Archived.Rows.Count - 1
                DT.Rows.Add(0, DT_Archived(x)("SubCategory"), "", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                SQL = "SELECT "
                SQL &= "  M.ID, CategoryID, SubCategoryID,"
                SQL &= "  Branch (BranchID) AS 'Branch',"
                SQL &= "  Borrower (BorrowerID) AS 'Defendant',"
                SQL &= "  CaseNumber AS 'Case Number',"
                SQL &= "  DATE_FORMAT(DateFilled, '%M %d, %Y') AS 'Date Filed',"
                SQL &= "  DecisionValue AS 'Decision Value',"
                SQL &= "  BookValue AS 'Book Value',"
                SQL &= "  Ledger_Balance(AccountNumber,M.MortgageID) AS 'Balance',"
                SQL &= "  IFNULL(Employee (CounselID),'') AS 'Counsel', Case_Status, LastModified, AccountNumber, Employee(M.PreparedID) AS 'Prepared By', Collateral, AccountN, DueRP, (SELECT Mobile_B FROM profile_borrower WHERE profile_borrower.BorrowerID = M.BorrowerID) AS 'Mobile'"
                SQL &= String.Format(" FROM case_main M WHERE `status` = 'ACTIVE' AND CategoryID = 7  AND SubCategoryID = {0} ORDER BY `Defendant`;", DT_Archived(x)("ID"))
                Dim DT_Result As DataTable = DataSource(SQL)
                If DT_Result.Rows.Count > 0 Then
                    For y As Integer = 0 To DT_Result.Rows.Count - 1
                        DT.Rows.Add(DT_Result(y)("ID"), DT_Result(y)("Branch"), y + 1 & ". " & DT_Result(y)("Defendant"), DT_Result(y)("Case Number"), DT_Result(y)("Date Filed"), DT_Result(y)("Decision Value"), DT_Result(y)("Book Value"), DT_Result(y)("Balance"), DT_Result(y)("Counsel"))
                    Next
                    If DT_Result.Rows.Count < 5 Then
                        For y As Integer = 1 To 5 - DT_Result.Rows.Count
                            DT.Rows.Add(1, "", DT_Result.Rows.Count + y & ".", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                        Next
                    End If
                Else
                    With DT
                        .Rows.Add(1, "", "1.", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                        .Rows.Add(1, "", "2.", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                        .Rows.Add(1, "", "3.", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                        .Rows.Add(1, "", "4.", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                        .Rows.Add(1, "", "5.", "", "", "", "", "", "", "", "", "", "", "", "", "", "", "")
                    End With
                End If
            Next
            .GridControl1.DataSource = DT

            If .GridView1.RowCount > 22 Then
                .GridColumn1.Width = 211 - 17
            Else
                .GridColumn1.Width = 211
            End If
            .ShowDialog()
            .Dispose()
        End With
    End Sub
End Class