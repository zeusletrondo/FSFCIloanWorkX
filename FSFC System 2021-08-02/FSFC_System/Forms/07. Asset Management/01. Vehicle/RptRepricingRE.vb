Public Class RptRepricingRE

    Private Sub Rpt_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'USER INTERFACE
        If AllowStandardUI = False Then
            Exit Sub
        End If
        ReportLabelWithBackgroundFontSettings({XrLabel6, XrLabel33, XrLabel34, XrLabel35, XrLabel36, XrLabel37})
        ReportLabelFontSettings({XrLabel1, XrLabel2, XrLabel7, lblLand, lblLand1, dLandArea, lblLandSQM_1, dPrice_1, lblLandConservative_1, dTotal_1, lblRemarks_1, lblLand2, dLandArea_2, lblLandSQM_2, dPrice_2, lblLandConservative_2, dTotal_2, lblRemarks_2, lblLand3, dLandArea_3, lblLandSQM_3, dPrice_3, lblLandConservative_3, dTotal_3, lblRemarks_3, lblLand4, dLandArea_4, lblLandSQM_4, dPrice_4, lblLandConservative_4, dTotal_4, lblRemarks_4, lblLand5, dLandArea_5, lblLandSQM_5, dPrice_5, lblLandConservative_5, dTotal_5, lblRemarks_5, lblLand6, dLandTotal_T, lblRemarks_6, lblImprovement, lblImprovements, lblImprovement1, dImprovementArea_1, lblImprovementSQM_1, dImprovementPrice_1, lblImprovementCons_1, dImprovementTotal_1, lblImprovementRemarks_1, lblImprovement2, dImprovementArea_2, lblImprovementSQM_2, dImprovementPrice_2, lblImprovementCons_2, dImprovementTotal_2, lblImprovementRemarks_2, lblImprovement3, dImprovementArea_3, lblImprovementSQM_3, dImprovementPrice_3, lblImprovementCons_3, dImprovementTotal_3, lblImprovementRemarks_3, lblImprovement4, dImprovementArea_4, lblImprovementSQM_4, dImprovementPrice_4, lblImprovementCons_4, dImprovementTotal_4, lblImprovementRemarks_4, lblImprovement5, dImprovementArea_5, lblImprovementSQM_5, dImprovementPrice_5, lblImprovementCons_5, dImprovementTotal_5, lblImprovementRemarks_5, lblImprovement6, dImprovementTotal_T, lblImprovementRemarks_6, lblEquipment, lblEquipment1, dMachineArea_1, lblMachineSQM_1, dMachinePrice_1, lblMachineCons_1, dMachineTotal_1, lblMachineRemarks_1, lblEquipment2, dMachineArea_2, lblMachineSQM_2, dMachinePrice_2, lblMachineCons_2, dMachineTotal_2, lblMachineRemarks_2, lblEquipment3, dMachineArea_3, lblMachineSQM_3, dMachinePrice_3, lblMachineCons_3, dMachineTotal_3, lblMachineRemarks_3, lblEquipment4, dMachineArea_4, lblMachineSQM_4, dMachinePrice_4, lblMachineCons_4, dMachineTotal_4, lblMachineRemarks_4, lblEquipment5, dMachineArea_5, lblMachineSQM_5, dMachinePrice_5, lblMachineCons_5, dMachineTotal_5, lblMachineRemarks_5, lblEquipment6, dMachineTotal_T, lblMachineRemarks_6, lblTotalPHP, dTotalAmount, lblTotalRemarks, XrLabel28, XrLabel29, dPrevailingSellingPrice, XrLabel23, XrLabel31, XrLabel32, dZonalValuation, txtTCT, txtLot, dArea, txtRegisteredOwner, txtRegistryOfDeeds, XrLabel43, txtLocation, XrLabel47, XrLabel46, XrLabel60, lblStorey_R, XrLabel59, lblRoofings_R, XrLabel58, lblFloorings_R, XrLabel57, lblTandB_R, XrLabel67, lblFrames_R, XrLabel69, lblBeams_R, XrLabel63, lblDoors_R, XrLabel65, lblYear_R, XrLabel76, lblWalling_R, XrLabel84, lblCeiling_R, lblWindows_R, XrLabel78, XrLabel80, lblFloorArea_R, XrLabel49, lblPartitions_R, XrLabel52, XrLabel45, lblRemarks, XrLabel92, txtBookValue, XrLabel87, txtSellingPrice, XrLabel89, txtSuggested, XrLabel10, txtApproved, lblPrepared, XrLabel93, lblNoted, XrLabel95, lblApproved, XrLabel97})
        ReportTableCellFontSettings({XrLabel4, lblDate, XrLabel3, lblAppaiseNum, XrLabel5, lblAppraiseFor, XrLabel13, lblAppraisedBy})
        ReportCheckBoxFontSettings({cbxVacantLot, cbxResidential, cbxCommercial, cbxAgricultural, cbxTourism, cbxIndustrial, cbxOthers})
        ReportPageInfoFontSettings({XrPageInfo1, XrPageInfo2})
    End Sub
End Class