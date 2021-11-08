﻿Public Class RptAccountsPayable

    Private Sub Rpt_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'USER INTERFACE
        If AllowStandardUI = False Then
            Exit Sub
        End If
        ReportLabelWithBackgroundFontSettings({XrLabel41, XrLabel17, XrLabel2, XrLabel1, XrLabel8, XrLabel5, XrLabel15, XrLabel13})
        ReportLabelFontSettings({lblTitle, XrLabel7, lblPayee, XrLabel6, iOthersD, XrLabel3, lblBank, XrLabel16, lblDocumentDate, XrLabel9, lblPostingDate, XrLabel11, lblDelivery, XrLabel10, lblDocumentNumber, XrLabel12, lblReferenceNumber, lblExplanation, lblNet, lblAccount, lblBusinessCenter, lblDepartment, lblDebit, lblCredit, lblRemarks, lblDebitT, lblCreditT, XrLabel42, lblPreparedBy, XrLabel46, XrLabel28, lblCheckedBy, XrLabel26, XrLabel29, lblApprovedBy, XrLabel31})
        ReportCheckBoxFontSettings({cbxCOD, cbx30D, cbx60D, cbx90D, cbxOthersT})
        ReportPageInfoFontSettings({XrPageInfo2})
    End Sub

    Private Sub LabelX_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles lblDebit.BeforePrint, lblCredit.BeforePrint
        Dim LabelX As DevExpress.XtraReports.UI.XRLabel = sender
        With LabelX
            .Text = If(.Text = "", "", FormatNumber(CDbl(.Text), 2))
        End With
    End Sub
End Class