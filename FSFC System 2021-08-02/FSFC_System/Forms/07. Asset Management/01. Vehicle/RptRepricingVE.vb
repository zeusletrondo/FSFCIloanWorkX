Public Class RptRepricingVE

    Private Sub Rpt_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles MyBase.BeforePrint
        'USER INTERFACE
        If AllowStandardUI = False Then
            Exit Sub
        End If
        ReportLabelWithBackgroundFontSettings({XrLabel6, XrLabel9})
        ReportLabelFontSettings({XrLabel1, XrLabel2, XrLabel7, lblMake, XrLabel13, lblPlateNumber, XrLabel23, lblMotorNumber, XrLabel29, lblORNumber, XrLabel8, lblType, XrLabel15, lblTransmission, XrLabel19, lblGasoline, lblSerialNumber, XrLabel25, XrLabel33, lblGrossWeight, XrLabel18, lblRim, XrLabel11, lblEngine, XrLabel17, lblBodyColor, XrLabel20, lblYear, XrLabel27, lblRegCertNumber, XrLabel31, lblMileAge, XrLabel4, lblDate, XrLabel16, txtEngine, txtEngineR, XrLabel28, txtSteering, txtSteeringR, XrLabel39, txtClutch, txtClutchR, XrLabel43, txtHeadLight, txtHeadLightR, XrLabel51, txtSignalLight, txtSignalLightR, XrLabel55, txtShock, txtShockR, XrLabel63, txtUnderchassis, txtUnderchassisR, XrLabel67, txtUpholstery, txtUpholsteryR, XrLabel75, txtTempGauge, txtTempGaugeR, XrLabel79, txtOdometer, txtOdometerR, XrLabel86, txtAppraisersRemarks, XrLabel92, txtBookValue, XrLabel3, lblAppaiseNum, XrLabel21, txtTransmission, txtTransmissionR, XrLabel32, txtTires, txtTiresR, XrLabel38, txtAcceleration, txtAccelerationR, XrLabel45, txtParkLight, txtParkLightR, XrLabel50, txtHorn, txtHornR, XrLabel57, txtChassis, txtChassisR, XrLabel62, txtFrontBumper, txtFrontBumperR, XrLabel69, txtAmpheres, txtAmpheresR, XrLabel74, txtFuel, txtFuelR, XrLabel81, txtStarter, txtStarterR, XrLabel87, txtSellingPrice, XrLabel5, lblAppraiseFor, XrLabel24, txtDifferential, txtDifferentialR, XrLabel35, txtBrakes, txtBrakesR, XrLabel42, txtWiper, txtWiperR, XrLabel47, txtBackUp, txtBackUpR, XrLabel54, txtSideMirror, txtSideMirrorR, XrLabel59, txtBodyFlooring, txtBodyFlooringR, XrLabel66, txtRearBumper, txtRearBumperR, XrLabel71, txtOilPressure, txtOilPressureR, XrLabel78, txtSpeedometer, txtSpeedometerR, XrLabel83, txtBodyPaint, txtBodyPaintR, XrLabel89, txtSuggested, XrLabel10, txtApproved, lblPrepared, XrLabel93, lblNoted, XrLabel95, lblApproved, XrLabel97})
        ReportPageInfoFontSettings({XrPageInfo1, XrPageInfo2})
    End Sub
End Class