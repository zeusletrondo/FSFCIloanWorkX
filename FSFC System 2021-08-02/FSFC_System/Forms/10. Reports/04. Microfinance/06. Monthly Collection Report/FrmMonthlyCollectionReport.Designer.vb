﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMonthlyCollectionReport
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim SerializableAppearanceObject1 As DevExpress.Utils.SerializableAppearanceObject = New DevExpress.Utils.SerializableAppearanceObject()
        Me.ContextMenuBar3 = New DevComponents.DotNetBar.ContextMenuBar()
        Me.ButtonItem5 = New DevComponents.DotNetBar.ButtonItem()
        Me.iLedger = New DevComponents.DotNetBar.ButtonItem()
        Me.iSOA = New DevComponents.DotNetBar.ButtonItem()
        Me.iViewOR = New DevComponents.DotNetBar.ButtonItem()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemCheckEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.PanelEx19 = New DevComponents.DotNetBar.PanelEx()
        Me.cbxAccountOfficer = New DevExpress.XtraEditors.CheckedComboBoxEdit()
        Me.cbxAll = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbxAllAO = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.LabelX4 = New DevComponents.DotNetBar.LabelX()
        Me.cbxDisplay = New SergeUtils.EasyCompletionComboBox()
        Me.LabelX40 = New DevComponents.DotNetBar.LabelX()
        Me.dtpTo = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.LabelX41 = New DevComponents.DotNetBar.LabelX()
        Me.dtpFrom = New DevComponents.Editors.DateTimeAdv.DateTimeInput()
        Me.lblFrom = New DevComponents.DotNetBar.LabelX()
        Me.cbxBusinessCenter = New SergeUtils.EasyCompletionComboBox()
        Me.btnPrintCustomized = New DevComponents.DotNetBar.ButtonX()
        Me.cbxAllB = New DevComponents.DotNetBar.Controls.CheckBoxX()
        Me.cbxBranch = New SergeUtils.EasyCompletionComboBox()
        Me.LabelX1 = New DevComponents.DotNetBar.LabelX()
        Me.btnSearch = New DevComponents.DotNetBar.ButtonX()
        Me.btnPrint = New DevComponents.DotNetBar.ButtonX()
        Me.btnCancel = New DevComponents.DotNetBar.ButtonX()
        Me.PanelEx1 = New DevComponents.DotNetBar.PanelEx()
        Me.lblTitle = New DevComponents.DotNetBar.LabelX()
        Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
        Me.btnLogs = New DevComponents.DotNetBar.ButtonX()
        CType(Me.ContextMenuBar3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx19.SuspendLayout()
        CType(Me.cbxAccountOfficer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEx1.SuspendLayout()
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ContextMenuBar3
        '
        Me.ContextMenuBar3.AntiAlias = True
        Me.ContextMenuBar3.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ContextMenuBar3.Items.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.ButtonItem5})
        Me.ContextMenuBar3.Location = New System.Drawing.Point(31, 288)
        Me.ContextMenuBar3.Name = "ContextMenuBar3"
        Me.ContextMenuBar3.Size = New System.Drawing.Size(114, 25)
        Me.ContextMenuBar3.Stretch = True
        Me.ContextMenuBar3.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.ContextMenuBar3.TabIndex = 1768
        Me.ContextMenuBar3.TabStop = False
        Me.ContextMenuBar3.Text = "ContextMenuBar3"
        '
        'ButtonItem5
        '
        Me.ButtonItem5.AutoExpandOnClick = True
        Me.ButtonItem5.Name = "ButtonItem5"
        Me.ButtonItem5.SubItems.AddRange(New DevComponents.DotNetBar.BaseItem() {Me.iLedger, Me.iSOA, Me.iViewOR})
        '
        'iLedger
        '
        Me.iLedger.Name = "iLedger"
        Me.iLedger.Text = "Account Ledger"
        '
        'iSOA
        '
        Me.iSOA.Name = "iSOA"
        Me.iSOA.Text = "Statement of Account"
        '
        'iViewOR
        '
        Me.iViewOR.Name = "iViewOR"
        Me.iViewOR.Text = "View Official Receipt"
        '
        'GridControl1
        '
        Me.ContextMenuBar3.SetContextMenuEx(Me.GridControl1, Me.ButtonItem5)
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.White
        Me.GridControl1.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Black
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me.GridControl1.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        Me.GridControl1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridControl1.Location = New System.Drawing.Point(0, 195)
        Me.GridControl1.LookAndFeel.SkinMaskColor = System.Drawing.Color.White
        Me.GridControl1.LookAndFeel.SkinMaskColor2 = System.Drawing.Color.White
        Me.GridControl1.LookAndFeel.SkinName = "The Asphalt World"
        Me.GridControl1.LookAndFeel.UseDefaultLookAndFeel = False
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemCheckEdit1})
        Me.GridControl1.Size = New System.Drawing.Size(1167, 504)
        Me.GridControl1.TabIndex = 1767
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.ColumnFilterButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButton.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.ColumnFilterButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseFont = True
        Me.GridView1.Appearance.ColumnFilterButton.Options.UseForeColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.ColumnFilterButtonActive.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.ColumnFilterButtonActive.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBackColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseBorderColor = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseFont = True
        Me.GridView1.Appearance.ColumnFilterButtonActive.Options.UseForeColor = True
        Me.GridView1.Appearance.CustomizationFormHint.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.CustomizationFormHint.Options.UseFont = True
        Me.GridView1.Appearance.DetailTip.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.DetailTip.Options.UseFont = True
        Me.GridView1.Appearance.Empty.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.Empty.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.Empty.Options.UseBackColor = True
        Me.GridView1.Appearance.Empty.Options.UseFont = True
        Me.GridView1.Appearance.EvenRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.EvenRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.EvenRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.EvenRow.Options.UseBackColor = True
        Me.GridView1.Appearance.EvenRow.Options.UseFont = True
        Me.GridView1.Appearance.EvenRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterCloseButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.FilterCloseButton.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.FilterCloseButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseFont = True
        Me.GridView1.Appearance.FilterCloseButton.Options.UseForeColor = True
        Me.GridView1.Appearance.FilterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.FilterPanel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.FilterPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FilterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FilterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FilterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.FixedLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.FixedLine.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.FixedLine.Options.UseBackColor = True
        Me.GridView1.Appearance.FixedLine.Options.UseFont = True
        Me.GridView1.Appearance.FocusedCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.FocusedCell.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.FocusedCell.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FocusedCell.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedCell.Options.UseFont = True
        Me.GridView1.Appearance.FocusedCell.Options.UseForeColor = True
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseFont = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.FooterPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Italic)
        Me.GridView1.Appearance.FooterPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.FooterPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Appearance.FooterPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.GroupButton.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.GroupButton.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupButton.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupButton.Options.UseFont = True
        Me.GridView1.Appearance.GroupButton.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupFooter.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.GroupFooter.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.GroupFooter.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupFooter.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(181, Byte), Integer), CType(CType(216, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.GridView1.Appearance.GroupPanel.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.GroupPanel.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.GroupPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupPanel.Options.UseFont = True
        Me.GridView1.Appearance.GroupPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.GroupRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.GroupRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.GroupRow.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.GroupRow.Options.UseBackColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseBorderColor = True
        Me.GridView1.Appearance.GroupRow.Options.UseFont = True
        Me.GridView1.Appearance.GroupRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.BorderColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.HeaderPanel.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold)
        Me.GridView1.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.White
        Me.GridView1.Appearance.HeaderPanel.Options.UseBackColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseBorderColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseFont = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseForeColor = True
        Me.GridView1.Appearance.HeaderPanel.Options.UseTextOptions = True
        Me.GridView1.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
        Me.GridView1.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap
        Me.GridView1.Appearance.HideSelectionRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.HideSelectionRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.HideSelectionRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.HideSelectionRow.Options.UseBackColor = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseFont = True
        Me.GridView1.Appearance.HideSelectionRow.Options.UseForeColor = True
        Me.GridView1.Appearance.HorzLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.HorzLine.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.HorzLine.Options.UseBackColor = True
        Me.GridView1.Appearance.HorzLine.Options.UseFont = True
        Me.GridView1.Appearance.OddRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.OddRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.OddRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.OddRow.Options.UseBackColor = True
        Me.GridView1.Appearance.OddRow.Options.UseFont = True
        Me.GridView1.Appearance.OddRow.Options.UseForeColor = True
        Me.GridView1.Appearance.Preview.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(253, Byte), Integer), CType(CType(246, Byte), Integer))
        Me.GridView1.Appearance.Preview.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.Preview.ForeColor = System.Drawing.Color.Navy
        Me.GridView1.Appearance.Preview.Options.UseBackColor = True
        Me.GridView1.Appearance.Preview.Options.UseFont = True
        Me.GridView1.Appearance.Preview.Options.UseForeColor = True
        Me.GridView1.Appearance.Row.BackColor = System.Drawing.Color.FromArgb(CType(CType(238, Byte), Integer), CType(CType(247, Byte), Integer), CType(CType(230, Byte), Integer))
        Me.GridView1.Appearance.Row.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.Row.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.Row.Options.UseBackColor = True
        Me.GridView1.Appearance.Row.Options.UseFont = True
        Me.GridView1.Appearance.Row.Options.UseForeColor = True
        Me.GridView1.Appearance.RowSeparator.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.RowSeparator.BackColor2 = System.Drawing.Color.White
        Me.GridView1.Appearance.RowSeparator.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.RowSeparator.Options.UseBackColor = True
        Me.GridView1.Appearance.RowSeparator.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(176, Byte), Integer), CType(CType(226, Byte), Integer), CType(CType(240, Byte), Integer))
        Me.GridView1.Appearance.SelectedRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.SelectedRow.ForeColor = System.Drawing.Color.Black
        Me.GridView1.Appearance.SelectedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.SelectedRow.Options.UseFont = True
        Me.GridView1.Appearance.SelectedRow.Options.UseForeColor = True
        Me.GridView1.Appearance.TopNewRow.BackColor = System.Drawing.Color.White
        Me.GridView1.Appearance.TopNewRow.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.TopNewRow.Options.UseBackColor = True
        Me.GridView1.Appearance.TopNewRow.Options.UseFont = True
        Me.GridView1.Appearance.VertLine.BackColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.GridView1.Appearance.VertLine.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.VertLine.Options.UseBackColor = True
        Me.GridView1.Appearance.VertLine.Options.UseFont = True
        Me.GridView1.Appearance.ViewCaption.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.GridView1.Appearance.ViewCaption.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7, Me.GridColumn8, Me.GridColumn9})
        Me.GridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.GroupPanelText = "General Requirements"
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsLayout.StoreAllOptions = True
        Me.GridView1.OptionsLayout.StoreAppearance = True
        Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.GridView1.OptionsSelection.MultiSelect = True
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
        Me.GridView1.OptionsView.EnableAppearanceEvenRow = True
        Me.GridView1.OptionsView.EnableAppearanceOddRow = True
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        Me.GridView1.PaintStyleName = "Style3D"
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "Credit Number"
        Me.GridColumn1.FieldName = "Credit Number"
        Me.GridColumn1.Name = "GridColumn1"
        Me.GridColumn1.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Borrower"
        Me.GridColumn2.FieldName = "Borrower"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 253
        '
        'GridColumn3
        '
        Me.GridColumn3.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn3.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn3.Caption = "Posting Date"
        Me.GridColumn3.FieldName = "Posting Date"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 1
        Me.GridColumn3.Width = 128
        '
        'GridColumn4
        '
        Me.GridColumn4.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn4.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.GridColumn4.Caption = "OR Number"
        Me.GridColumn4.FieldName = "OR Number"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 2
        Me.GridColumn4.Width = 128
        '
        'GridColumn5
        '
        Me.GridColumn5.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn5.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn5.Caption = "Principal"
        Me.GridColumn5.DisplayFormat.FormatString = "n2"
        Me.GridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn5.FieldName = "Principal"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 3
        Me.GridColumn5.Width = 128
        '
        'GridColumn6
        '
        Me.GridColumn6.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn6.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn6.Caption = "Interest"
        Me.GridColumn6.DisplayFormat.FormatString = "n2"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn6.FieldName = "Interest"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 4
        Me.GridColumn6.Width = 128
        '
        'GridColumn7
        '
        Me.GridColumn7.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn7.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn7.Caption = "Penalty"
        Me.GridColumn7.DisplayFormat.FormatString = "n2"
        Me.GridColumn7.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn7.FieldName = "Penalty"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 5
        Me.GridColumn7.Width = 128
        '
        'GridColumn8
        '
        Me.GridColumn8.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn8.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn8.Caption = "Interest after Maturity"
        Me.GridColumn8.DisplayFormat.FormatString = "n2"
        Me.GridColumn8.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn8.FieldName = "Interest after Maturity"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 6
        Me.GridColumn8.Width = 128
        '
        'GridColumn9
        '
        Me.GridColumn9.AppearanceCell.Options.UseTextOptions = True
        Me.GridColumn9.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
        Me.GridColumn9.Caption = "Total Collections"
        Me.GridColumn9.DisplayFormat.FormatString = "n2"
        Me.GridColumn9.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.GridColumn9.FieldName = "Total Collections"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsFilter.AutoFilterCondition = DevExpress.XtraGrid.Columns.AutoFilterCondition.Contains
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 7
        Me.GridColumn9.Width = 128
        '
        'RepositoryItemCheckEdit1
        '
        Me.RepositoryItemCheckEdit1.Appearance.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.RepositoryItemCheckEdit1.Appearance.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AppearanceDisabled.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.RepositoryItemCheckEdit1.AppearanceDisabled.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AppearanceFocused.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.RepositoryItemCheckEdit1.AppearanceFocused.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AppearanceReadOnly.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.RepositoryItemCheckEdit1.AppearanceReadOnly.Options.UseFont = True
        Me.RepositoryItemCheckEdit1.AutoHeight = False
        Me.RepositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Style1
        Me.RepositoryItemCheckEdit1.Name = "RepositoryItemCheckEdit1"
        Me.RepositoryItemCheckEdit1.ValueChecked = "True"
        Me.RepositoryItemCheckEdit1.ValueUnchecked = "False"
        '
        'PanelEx19
        '
        Me.PanelEx19.AutoScroll = True
        Me.PanelEx19.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx19.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx19.Controls.Add(Me.cbxAccountOfficer)
        Me.PanelEx19.Controls.Add(Me.cbxAll)
        Me.PanelEx19.Controls.Add(Me.cbxAllAO)
        Me.PanelEx19.Controls.Add(Me.LabelX4)
        Me.PanelEx19.Controls.Add(Me.cbxDisplay)
        Me.PanelEx19.Controls.Add(Me.LabelX40)
        Me.PanelEx19.Controls.Add(Me.dtpTo)
        Me.PanelEx19.Controls.Add(Me.LabelX41)
        Me.PanelEx19.Controls.Add(Me.dtpFrom)
        Me.PanelEx19.Controls.Add(Me.lblFrom)
        Me.PanelEx19.Controls.Add(Me.cbxBusinessCenter)
        Me.PanelEx19.Controls.Add(Me.btnPrintCustomized)
        Me.PanelEx19.Controls.Add(Me.cbxAllB)
        Me.PanelEx19.Controls.Add(Me.cbxBranch)
        Me.PanelEx19.Controls.Add(Me.LabelX1)
        Me.PanelEx19.Controls.Add(Me.btnSearch)
        Me.PanelEx19.Controls.Add(Me.btnPrint)
        Me.PanelEx19.Controls.Add(Me.btnCancel)
        Me.PanelEx19.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx19.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx19.Location = New System.Drawing.Point(0, 66)
        Me.PanelEx19.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.PanelEx19.Name = "PanelEx19"
        Me.PanelEx19.Size = New System.Drawing.Size(1167, 129)
        Me.PanelEx19.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx19.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx19.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx19.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx19.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx19.Style.BorderSide = DevComponents.DotNetBar.eBorderSide.Left
        Me.PanelEx19.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx19.Style.GradientAngle = 90
        Me.PanelEx19.TabIndex = 1766
        '
        'cbxAccountOfficer
        '
        Me.cbxAccountOfficer.Location = New System.Drawing.Point(71, 36)
        Me.cbxAccountOfficer.Name = "cbxAccountOfficer"
        Me.cbxAccountOfficer.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxAccountOfficer.Properties.Appearance.Options.UseFont = True
        Me.cbxAccountOfficer.Properties.AppearanceDisabled.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxAccountOfficer.Properties.AppearanceDisabled.Options.UseFont = True
        Me.cbxAccountOfficer.Properties.AppearanceDropDown.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxAccountOfficer.Properties.AppearanceDropDown.Options.UseFont = True
        Me.cbxAccountOfficer.Properties.AppearanceFocused.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxAccountOfficer.Properties.AppearanceFocused.Options.UseFont = True
        Me.cbxAccountOfficer.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxAccountOfficer.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.cbxAccountOfficer.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.HotFlat
        SerializableAppearanceObject1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SerializableAppearanceObject1.Options.UseFont = True
        Me.cbxAccountOfficer.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo, "", -1, True, True, False, DevExpress.XtraEditors.ImageLocation.MiddleCenter, Nothing, New DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), SerializableAppearanceObject1, "", Nothing, Nothing, True)})
        Me.cbxAccountOfficer.Properties.DropDownRows = 15
        Me.cbxAccountOfficer.Properties.LookAndFeel.SkinName = "Visual Studio 2013 Blue"
        Me.cbxAccountOfficer.Properties.LookAndFeel.UseDefaultLookAndFeel = False
        Me.cbxAccountOfficer.Properties.PopupSizeable = False
        Me.cbxAccountOfficer.Size = New System.Drawing.Size(379, 26)
        Me.cbxAccountOfficer.TabIndex = 15
        '
        'cbxAll
        '
        Me.cbxAll.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.cbxAll.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxAll.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAll.Location = New System.Drawing.Point(456, 68)
        Me.cbxAll.Name = "cbxAll"
        Me.cbxAll.Size = New System.Drawing.Size(45, 23)
        Me.cbxAll.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxAll.TabIndex = 40
        Me.cbxAll.Text = "All"
        '
        'cbxAllAO
        '
        Me.cbxAllAO.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.cbxAllAO.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxAllAO.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAllAO.Location = New System.Drawing.Point(456, 37)
        Me.cbxAllAO.Name = "cbxAllAO"
        Me.cbxAllAO.Size = New System.Drawing.Size(45, 23)
        Me.cbxAllAO.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxAllAO.TabIndex = 30
        Me.cbxAllAO.Text = "All"
        '
        'LabelX4
        '
        Me.LabelX4.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX4.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.LabelX4.Location = New System.Drawing.Point(9, 37)
        Me.LabelX4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX4.Name = "LabelX4"
        Me.LabelX4.Size = New System.Drawing.Size(56, 23)
        Me.LabelX4.TabIndex = 1710
        Me.LabelX4.Text = "AO :"
        Me.LabelX4.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cbxDisplay
        '
        Me.cbxDisplay.DisplayMember = "PREFIX"
        Me.cbxDisplay.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxDisplay.FormattingEnabled = True
        Me.cbxDisplay.Items.AddRange(New Object() {"Today", "This Week", "This Month", "This Year", "Range", "As Of"})
        Me.cbxDisplay.Location = New System.Drawing.Point(71, 68)
        Me.cbxDisplay.Name = "cbxDisplay"
        Me.cbxDisplay.Size = New System.Drawing.Size(379, 25)
        Me.cbxDisplay.TabIndex = 35
        Me.cbxDisplay.ValueMember = "ID"
        '
        'LabelX40
        '
        Me.LabelX40.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX40.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX40.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX40.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.LabelX40.Location = New System.Drawing.Point(9, 68)
        Me.LabelX40.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX40.Name = "LabelX40"
        Me.LabelX40.Size = New System.Drawing.Size(56, 23)
        Me.LabelX40.TabIndex = 1709
        Me.LabelX40.Text = "Display :"
        Me.LabelX40.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtpTo
        '
        '
        '
        '
        Me.dtpTo.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpTo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTo.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpTo.ButtonDropDown.Visible = True
        Me.dtpTo.CustomFormat = "MMMM dd, yyyy"
        Me.dtpTo.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpTo.ForeColor = System.Drawing.Color.Black
        Me.dtpTo.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtpTo.IsPopupCalendarOpen = False
        Me.dtpTo.Location = New System.Drawing.Point(289, 99)
        '
        '
        '
        Me.dtpTo.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTo.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTo.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpTo.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpTo.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTo.MonthCalendar.DisplayMonth = New Date(2016, 12, 1, 0, 0, 0, 0)
        Me.dtpTo.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpTo.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpTo.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpTo.MonthCalendar.TodayButtonVisible = True
        Me.dtpTo.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpTo.Name = "dtpTo"
        Me.dtpTo.Size = New System.Drawing.Size(161, 23)
        Me.dtpTo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpTo.TabIndex = 50
        Me.dtpTo.Value = New Date(2016, 12, 2, 13, 44, 54, 0)
        '
        'LabelX41
        '
        Me.LabelX41.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX41.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX41.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX41.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.LabelX41.Location = New System.Drawing.Point(237, 99)
        Me.LabelX41.Name = "LabelX41"
        Me.LabelX41.Size = New System.Drawing.Size(46, 23)
        Me.LabelX41.TabIndex = 1708
        Me.LabelX41.Text = "To :"
        Me.LabelX41.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'dtpFrom
        '
        '
        '
        '
        Me.dtpFrom.BackgroundStyle.Class = "DateTimeInputBackground"
        Me.dtpFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFrom.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown
        Me.dtpFrom.ButtonDropDown.Visible = True
        Me.dtpFrom.CustomFormat = "MMMM dd, yyyy"
        Me.dtpFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFrom.ForeColor = System.Drawing.Color.Black
        Me.dtpFrom.Format = DevComponents.Editors.eDateTimePickerFormat.Custom
        Me.dtpFrom.IsPopupCalendarOpen = False
        Me.dtpFrom.Location = New System.Drawing.Point(71, 99)
        '
        '
        '
        Me.dtpFrom.MonthCalendar.AnnuallyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFrom.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFrom.MonthCalendar.CalendarDimensions = New System.Drawing.Size(1, 1)
        Me.dtpFrom.MonthCalendar.ClearButtonVisible = True
        '
        '
        '
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1
        Me.dtpFrom.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFrom.MonthCalendar.DisplayMonth = New Date(2016, 12, 1, 0, 0, 0, 0)
        Me.dtpFrom.MonthCalendar.MarkedDates = New Date(-1) {}
        Me.dtpFrom.MonthCalendar.MonthlyMarkedDates = New Date(-1) {}
        '
        '
        '
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground
        Me.dtpFrom.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.dtpFrom.MonthCalendar.TodayButtonVisible = True
        Me.dtpFrom.MonthCalendar.WeeklyMarkedDays = New System.DayOfWeek(-1) {}
        Me.dtpFrom.Name = "dtpFrom"
        Me.dtpFrom.Size = New System.Drawing.Size(161, 23)
        Me.dtpFrom.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.dtpFrom.TabIndex = 45
        Me.dtpFrom.Value = New Date(2016, 12, 2, 13, 44, 54, 0)
        '
        'lblFrom
        '
        Me.lblFrom.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblFrom.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblFrom.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFrom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lblFrom.Location = New System.Drawing.Point(9, 99)
        Me.lblFrom.Name = "lblFrom"
        Me.lblFrom.Size = New System.Drawing.Size(56, 23)
        Me.lblFrom.TabIndex = 1707
        Me.lblFrom.Text = "From :"
        Me.lblFrom.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'cbxBusinessCenter
        '
        Me.cbxBusinessCenter.DisplayMember = "PREFIX"
        Me.cbxBusinessCenter.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxBusinessCenter.FormattingEnabled = True
        Me.cbxBusinessCenter.Location = New System.Drawing.Point(289, 6)
        Me.cbxBusinessCenter.Name = "cbxBusinessCenter"
        Me.cbxBusinessCenter.Size = New System.Drawing.Size(161, 25)
        Me.cbxBusinessCenter.TabIndex = 10
        Me.cbxBusinessCenter.ValueMember = "ID"
        '
        'btnPrintCustomized
        '
        Me.btnPrintCustomized.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrintCustomized.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnPrintCustomized.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrintCustomized.Image = Global.FSFC_System.My.Resources.Resources.Print
        Me.btnPrintCustomized.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnPrintCustomized.Location = New System.Drawing.Point(846, 6)
        Me.btnPrintCustomized.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrintCustomized.Name = "btnPrintCustomized"
        Me.btnPrintCustomized.Size = New System.Drawing.Size(107, 30)
        Me.btnPrintCustomized.TabIndex = 1689
        Me.btnPrintCustomized.Text = "Customize"
        '
        'cbxAllB
        '
        Me.cbxAllB.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.cbxAllB.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.cbxAllB.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbxAllB.Location = New System.Drawing.Point(456, 6)
        Me.cbxAllB.Name = "cbxAllB"
        Me.cbxAllB.Size = New System.Drawing.Size(45, 23)
        Me.cbxAllB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.cbxAllB.TabIndex = 15
        Me.cbxAllB.Text = "All"
        '
        'cbxBranch
        '
        Me.cbxBranch.DisplayMember = "PREFIX"
        Me.cbxBranch.Font = New System.Drawing.Font("Century Gothic", 9.75!)
        Me.cbxBranch.FormattingEnabled = True
        Me.cbxBranch.Items.AddRange(New Object() {"Today", "This Week", "This Month", "This Year", "Range"})
        Me.cbxBranch.Location = New System.Drawing.Point(71, 6)
        Me.cbxBranch.Name = "cbxBranch"
        Me.cbxBranch.Size = New System.Drawing.Size(212, 25)
        Me.cbxBranch.TabIndex = 5
        Me.cbxBranch.ValueMember = "ID"
        '
        'LabelX1
        '
        Me.LabelX1.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.LabelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.LabelX1.Font = New System.Drawing.Font("Century Gothic", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelX1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.LabelX1.Location = New System.Drawing.Point(9, 6)
        Me.LabelX1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelX1.Name = "LabelX1"
        Me.LabelX1.Size = New System.Drawing.Size(56, 23)
        Me.LabelX1.TabIndex = 1033
        Me.LabelX1.Text = "Branch :"
        Me.LabelX1.TextAlignment = System.Drawing.StringAlignment.Far
        '
        'btnSearch
        '
        Me.btnSearch.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnSearch.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnSearch.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Image = Global.FSFC_System.My.Resources.Resources.Search
        Me.btnSearch.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnSearch.Location = New System.Drawing.Point(507, 6)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(107, 30)
        Me.btnSearch.TabIndex = 50
        Me.btnSearch.Text = "Generate"
        '
        'btnPrint
        '
        Me.btnPrint.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnPrint.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnPrint.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPrint.Image = Global.FSFC_System.My.Resources.Resources.Print
        Me.btnPrint.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnPrint.Location = New System.Drawing.Point(733, 6)
        Me.btnPrint.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(107, 30)
        Me.btnPrint.TabIndex = 1025
        Me.btnPrint.Text = "&Print"
        '
        'btnCancel
        '
        Me.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnCancel.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancel.Image = Global.FSFC_System.My.Resources.Resources.Cancel
        Me.btnCancel.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnCancel.Location = New System.Drawing.Point(620, 6)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(107, 30)
        Me.btnCancel.TabIndex = 1020
        Me.btnCancel.Text = "Close"
        '
        'PanelEx1
        '
        Me.PanelEx1.AutoScroll = True
        Me.PanelEx1.CanvasColor = System.Drawing.SystemColors.Control
        Me.PanelEx1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled
        Me.PanelEx1.Controls.Add(Me.btnLogs)
        Me.PanelEx1.Controls.Add(Me.lblTitle)
        Me.PanelEx1.Controls.Add(Me.PictureEdit1)
        Me.PanelEx1.DisabledBackColor = System.Drawing.Color.Empty
        Me.PanelEx1.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanelEx1.Location = New System.Drawing.Point(0, 0)
        Me.PanelEx1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.PanelEx1.Name = "PanelEx1"
        Me.PanelEx1.Size = New System.Drawing.Size(1167, 66)
        Me.PanelEx1.Style.Alignment = System.Drawing.StringAlignment.Center
        Me.PanelEx1.Style.BackColor1.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.BackColor2.Color = System.Drawing.Color.White
        Me.PanelEx1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine
        Me.PanelEx1.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder
        Me.PanelEx1.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText
        Me.PanelEx1.Style.GradientAngle = 90
        Me.PanelEx1.TabIndex = 1765
        '
        'lblTitle
        '
        Me.lblTitle.BackColor = System.Drawing.Color.White
        '
        '
        '
        Me.lblTitle.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square
        Me.lblTitle.Font = New System.Drawing.Font("Century Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.ForeColor = System.Drawing.Color.FromArgb(CType(CType(13, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(165, Byte), Integer))
        Me.lblTitle.Location = New System.Drawing.Point(320, 20)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(591, 26)
        Me.lblTitle.TabIndex = 6
        Me.lblTitle.Text = "LIST OF COLLECTIONS"
        Me.lblTitle.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'PictureEdit1
        '
        Me.PictureEdit1.Location = New System.Drawing.Point(9, 1)
        Me.PictureEdit1.Margin = New System.Windows.Forms.Padding(3, 7, 3, 7)
        Me.PictureEdit1.Name = "PictureEdit1"
        Me.PictureEdit1.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.PictureEdit1.Properties.Appearance.Font = New System.Drawing.Font("Century Gothic", 8.25!)
        Me.PictureEdit1.Properties.Appearance.Options.UseBackColor = True
        Me.PictureEdit1.Properties.Appearance.Options.UseFont = True
        Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.PictureEdit1.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me.PictureEdit1.Size = New System.Drawing.Size(263, 64)
        Me.PictureEdit1.TabIndex = 3
        '
        'btnLogs
        '
        Me.btnLogs.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton
        Me.btnLogs.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground
        Me.btnLogs.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnLogs.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogs.Image = Global.FSFC_System.My.Resources.Resources.History
        Me.btnLogs.ImageFixedSize = New System.Drawing.Size(32, 32)
        Me.btnLogs.Location = New System.Drawing.Point(1131, 0)
        Me.btnLogs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLogs.Name = "btnLogs"
        Me.btnLogs.Size = New System.Drawing.Size(36, 66)
        Me.btnLogs.TabIndex = 1033
        Me.btnLogs.Tooltip = "Transaction Logs"
        '
        'FrmMonthlyCollectionReport
        '
        Me.Appearance.BackColor = System.Drawing.Color.White
        Me.Appearance.ForeColor = System.Drawing.Color.Black
        Me.Appearance.Options.UseBackColor = True
        Me.Appearance.Options.UseFont = True
        Me.Appearance.Options.UseForeColor = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1167, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.ContextMenuBar3)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.PanelEx19)
        Me.Controls.Add(Me.PanelEx1)
        Me.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "FrmMonthlyCollectionReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ContextMenuBar3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemCheckEdit1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx19.ResumeLayout(False)
        CType(Me.cbxAccountOfficer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dtpFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEx1.ResumeLayout(False)
        CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ContextMenuBar3 As DevComponents.DotNetBar.ContextMenuBar
    Friend WithEvents ButtonItem5 As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents iLedger As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents iSOA As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemCheckEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents PanelEx19 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents cbxAccountOfficer As DevExpress.XtraEditors.CheckedComboBoxEdit
    Friend WithEvents cbxAll As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbxAllAO As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents LabelX4 As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbxDisplay As SergeUtils.EasyCompletionComboBox
    Friend WithEvents LabelX40 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpTo As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents LabelX41 As DevComponents.DotNetBar.LabelX
    Friend WithEvents dtpFrom As DevComponents.Editors.DateTimeAdv.DateTimeInput
    Friend WithEvents lblFrom As DevComponents.DotNetBar.LabelX
    Friend WithEvents cbxBusinessCenter As SergeUtils.EasyCompletionComboBox
    Friend WithEvents btnPrintCustomized As DevComponents.DotNetBar.ButtonX
    Friend WithEvents cbxAllB As DevComponents.DotNetBar.Controls.CheckBoxX
    Friend WithEvents cbxBranch As SergeUtils.EasyCompletionComboBox
    Friend WithEvents LabelX1 As DevComponents.DotNetBar.LabelX
    Friend WithEvents btnSearch As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnPrint As DevComponents.DotNetBar.ButtonX
    Friend WithEvents btnCancel As DevComponents.DotNetBar.ButtonX
    Friend WithEvents PanelEx1 As DevComponents.DotNetBar.PanelEx
    Friend WithEvents lblTitle As DevComponents.DotNetBar.LabelX
    Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents iViewOR As DevComponents.DotNetBar.ButtonItem
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnLogs As DevComponents.DotNetBar.ButtonX
End Class
