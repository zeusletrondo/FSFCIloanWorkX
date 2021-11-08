Public Class RptBorrowersCorporate

    Private Sub Rpt_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'USER INTERFACE
        If AllowStandardUI = False Then
            Exit Sub
        End If
        ReportLabelWithBackgroundFontSettings({XrLabel3, XrLabel124, XrLabel16, XrLabel125, XrLabel126, XrLabel127, XrLabel128, XrLabel129, XrLabel41, XrLabel31, XrLabel33, XrLabel34, XrLabel7, XrLabel40, XrLabel44, XrLabel45, XrLabel15, XrLabel42, XrLabel43, XrLabel48, XrLabel51, XrLabel20, XrLabel59, XrLabel57, XrLabel58, XrLabel25, XrLabel68, XrLabel67, XrLabel69, XrLabel64, XrLabel35, XrLabel72, XrLabel78, XrLabel77, XrLabel37, XrLabel79, XrLabel80, XrLabel82, XrLabel83, XrLabel39, XrLabel95, XrLabel97, XrLabel98, XrLabel47, XrLabel87, XrLabel88, XrLabel84, XrLabel85, XrLabel49, XrLabel106, XrLabel110, XrLabel109, XrLabel52, XrLabel117})
        ReportLabelFontSettings({XrLabel1, XrLabel2, XrLabel4, lblBorrowerID, XrLabel5, lblLoanNumber, XrLabel6, lblTradeName, XrLabel14, lblAddress, XrLabel24, lblTIN, XrLabel26, lblSSS, XrLabel28, lblTelephone, XrLabel30, lblEmail, XrLabel10, lblFax, XrLabel8, lblWebsite, XrLabel13, lblIncorporation, XrLabel11, lblYears, XrLabel19, lblNoEmployees, XrLabel17, XrLabel21, lblGrossIncome, XrLabel23, lblNetIncome, lblBank_1, lblBranch_1, lblSA_1, lblAverage_1, lblPresent_1, lblDateOpened_1, lblBankRemarks_1, lblBank_2, lblBranch_2, lblSA_2, lblAverage_2, lblPresent_2, lblDateOpened_2, lblBankRemarks_2, lblRep_1, lblBirthdate_1, lblTIN_1, lblSSS_1, lblGMI_1, lblAddress_1, lblPosition_1, lblContact_1, lblYears_1, lblRep_2, lblBirthdate_2, lblTIN_2, lblSSS_2, lblGMI_2, lblAddress_2, lblPosition_2, lblContact_2, lblYears_2, lblRep_3, lblBirthdate_3, lblTIN_3, lblSSS_3, lblGMI_3, lblAddress_3, lblPosition_3, lblContact_3, lblYears_3, lblRep_4, lblBirthdate_4, lblTIN_4, lblSSS_4, lblGMI_4, lblAddress_4, lblPosition_4, lblContact_4, lblYears_4, lblRep_5, lblBirthdate_5, lblTIN_5, lblSSS_5, lblGMI_5, lblAddress_5, lblPosition_5, lblContact_5, lblYears_5, XrLabel206, XrLabel207, XrLabel9, lblSignature_1, lblSignature_2, lblSignature_3, lblSignature_4, lblSignature_5, XrLabel210, XrLabel212, XrLabel111, XrLabel113, XrLabel115, txtAgent, txtMarketing, txtWalkIn, txtDealer, XrLabel214, XrLabel215, XrLabel216})
        ReportCheckBoxFontSettings({cbxMicro, cbxSmall, cbxMedium, cbxLarge, cbxAgent, cbxMarketing, cbxWalkIn, cbxDealer})
        ReportTableCellFontSettings({XrTableCell4, XrTableCell5, XrTableCell6, XrTableCell1, XrTableCell2, tAmount, tTerms, tCollateral, tPurpose, tDate})
        ReportPageInfoFontSettings({XrPageInfo2})
    End Sub
End Class