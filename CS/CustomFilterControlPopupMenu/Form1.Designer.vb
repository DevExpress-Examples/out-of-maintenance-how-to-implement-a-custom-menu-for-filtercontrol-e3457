Imports Microsoft.VisualBasic
Imports System
Namespace CustomFilterControlPopupMenu
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.FilterControl = New DevExpress.XtraEditors.FilterControl()
			Me.BarManager = New DevExpress.XtraBars.BarManager(Me.components)
			Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
			Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
			Me.dataSet1 = New System.Data.DataSet()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.dataColumn4 = New System.Data.DataColumn()
			Me.dataColumn5 = New System.Data.DataColumn()
			Me.dataColumn6 = New System.Data.DataColumn()
			Me.dataColumn7 = New System.Data.DataColumn()
			Me.dataColumn8 = New System.Data.DataColumn()
			Me.dataColumn9 = New System.Data.DataColumn()
			Me.dataColumn10 = New System.Data.DataColumn()
			Me.dataColumn11 = New System.Data.DataColumn()
			Me.dataColumn12 = New System.Data.DataColumn()
			Me.dataColumn13 = New System.Data.DataColumn()
			Me.dataColumn14 = New System.Data.DataColumn()
			Me.dataColumn15 = New System.Data.DataColumn()
			Me.dataColumn16 = New System.Data.DataColumn()
			Me.dataColumn17 = New System.Data.DataColumn()
			Me.dataColumn18 = New System.Data.DataColumn()
			Me.dataColumn19 = New System.Data.DataColumn()
			Me.dataColumn20 = New System.Data.DataColumn()
			Me.dataColumn21 = New System.Data.DataColumn()
			Me.dataColumn22 = New System.Data.DataColumn()
			Me.dataColumn23 = New System.Data.DataColumn()
			Me.dataColumn24 = New System.Data.DataColumn()
			Me.dataColumn25 = New System.Data.DataColumn()
			Me.dataColumn26 = New System.Data.DataColumn()
			Me.dataColumn27 = New System.Data.DataColumn()
			Me.dataColumn28 = New System.Data.DataColumn()
			Me.dataColumn29 = New System.Data.DataColumn()
			Me.dataColumn30 = New System.Data.DataColumn()
			Me.dataColumn31 = New System.Data.DataColumn()
			Me.dataColumn32 = New System.Data.DataColumn()
			Me.dataColumn33 = New System.Data.DataColumn()
			Me.dataColumn34 = New System.Data.DataColumn()
			Me.dataColumn35 = New System.Data.DataColumn()
			Me.dataColumn36 = New System.Data.DataColumn()
			Me.dataColumn37 = New System.Data.DataColumn()
			Me.dataColumn38 = New System.Data.DataColumn()
			Me.dataColumn39 = New System.Data.DataColumn()
			Me.bindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
			CType(Me.BarManager, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' FilterControl
			' 
			Me.FilterControl.Cursor = System.Windows.Forms.Cursors.Arrow
			Me.FilterControl.Dock = System.Windows.Forms.DockStyle.Fill
			Me.FilterControl.Location = New System.Drawing.Point(0, 0)
			Me.FilterControl.Name = "FilterControl"
			Me.FilterControl.Size = New System.Drawing.Size(292, 270)
			Me.FilterControl.SourceControl = Me.bindingSource1
			Me.FilterControl.TabIndex = 0
			Me.FilterControl.Text = "filterControl1"
'			Me.FilterControl.PopupMenuShowing += New DevExpress.XtraEditors.Filtering.PopupMenuShowingEventHandler(Me.OnPopupMenuShowing);
			' 
			' BarManager
			' 
			Me.BarManager.DockControls.Add(Me.barDockControlTop)
			Me.BarManager.DockControls.Add(Me.barDockControlBottom)
			Me.BarManager.DockControls.Add(Me.barDockControlLeft)
			Me.BarManager.DockControls.Add(Me.barDockControlRight)
			Me.BarManager.Form = Me
			Me.BarManager.MaxItemId = 0
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3, Me.dataColumn4, Me.dataColumn5, Me.dataColumn6, Me.dataColumn7, Me.dataColumn8, Me.dataColumn9, Me.dataColumn10, Me.dataColumn11, Me.dataColumn12, Me.dataColumn13, Me.dataColumn14, Me.dataColumn15, Me.dataColumn16, Me.dataColumn17, Me.dataColumn18, Me.dataColumn19, Me.dataColumn20, Me.dataColumn21, Me.dataColumn22, Me.dataColumn23, Me.dataColumn24, Me.dataColumn25, Me.dataColumn26, Me.dataColumn27, Me.dataColumn28, Me.dataColumn29, Me.dataColumn30, Me.dataColumn31, Me.dataColumn32, Me.dataColumn33, Me.dataColumn34, Me.dataColumn35, Me.dataColumn36, Me.dataColumn37, Me.dataColumn38, Me.dataColumn39})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Column1"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "Column2"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Column3"
			' 
			' dataColumn4
			' 
			Me.dataColumn4.ColumnName = "Column4"
			' 
			' dataColumn5
			' 
			Me.dataColumn5.ColumnName = "Column5"
			' 
			' dataColumn6
			' 
			Me.dataColumn6.ColumnName = "Column6"
			' 
			' dataColumn7
			' 
			Me.dataColumn7.ColumnName = "Column7"
			' 
			' dataColumn8
			' 
			Me.dataColumn8.ColumnName = "Column8"
			' 
			' dataColumn9
			' 
			Me.dataColumn9.ColumnName = "Column9"
			' 
			' dataColumn10
			' 
			Me.dataColumn10.ColumnName = "Column10"
			' 
			' dataColumn11
			' 
			Me.dataColumn11.ColumnName = "Column11"
			' 
			' dataColumn12
			' 
			Me.dataColumn12.ColumnName = "Column12"
			' 
			' dataColumn13
			' 
			Me.dataColumn13.ColumnName = "Column13"
			' 
			' dataColumn14
			' 
			Me.dataColumn14.ColumnName = "Column14"
			' 
			' dataColumn15
			' 
			Me.dataColumn15.ColumnName = "Column15"
			' 
			' dataColumn16
			' 
			Me.dataColumn16.ColumnName = "Column16"
			' 
			' dataColumn17
			' 
			Me.dataColumn17.ColumnName = "Column17"
			' 
			' dataColumn18
			' 
			Me.dataColumn18.ColumnName = "Column18"
			' 
			' dataColumn19
			' 
			Me.dataColumn19.ColumnName = "Column19"
			' 
			' dataColumn20
			' 
			Me.dataColumn20.ColumnName = "Column20"
			' 
			' dataColumn21
			' 
			Me.dataColumn21.ColumnName = "Column21"
			' 
			' dataColumn22
			' 
			Me.dataColumn22.ColumnName = "Column22"
			' 
			' dataColumn23
			' 
			Me.dataColumn23.ColumnName = "Column23"
			' 
			' dataColumn24
			' 
			Me.dataColumn24.ColumnName = "Column24"
			' 
			' dataColumn25
			' 
			Me.dataColumn25.ColumnName = "Column25"
			' 
			' dataColumn26
			' 
			Me.dataColumn26.ColumnName = "Column26"
			' 
			' dataColumn27
			' 
			Me.dataColumn27.ColumnName = "Column27"
			' 
			' dataColumn28
			' 
			Me.dataColumn28.ColumnName = "Column28"
			' 
			' dataColumn29
			' 
			Me.dataColumn29.ColumnName = "Column29"
			' 
			' dataColumn30
			' 
			Me.dataColumn30.ColumnName = "Column30"
			' 
			' dataColumn31
			' 
			Me.dataColumn31.ColumnName = "Column31"
			' 
			' dataColumn32
			' 
			Me.dataColumn32.ColumnName = "Column32"
			' 
			' dataColumn33
			' 
			Me.dataColumn33.ColumnName = "Column33"
			' 
			' dataColumn34
			' 
			Me.dataColumn34.ColumnName = "Column34"
			' 
			' dataColumn35
			' 
			Me.dataColumn35.ColumnName = "Column35"
			' 
			' dataColumn36
			' 
			Me.dataColumn36.ColumnName = "Column36"
			' 
			' dataColumn37
			' 
			Me.dataColumn37.ColumnName = "Column37"
			' 
			' dataColumn38
			' 
			Me.dataColumn38.ColumnName = "Column38"
			' 
			' dataColumn39
			' 
			Me.dataColumn39.ColumnName = "Column39"
			' 
			' bindingSource1
			' 
			Me.bindingSource1.DataMember = "Table1"
			Me.bindingSource1.DataSource = Me.dataSet1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 270)
			Me.Controls.Add(Me.FilterControl)
			Me.Controls.Add(Me.barDockControlLeft)
			Me.Controls.Add(Me.barDockControlRight)
			Me.Controls.Add(Me.barDockControlBottom)
			Me.Controls.Add(Me.barDockControlTop)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.BarManager, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.bindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents FilterControl As DevExpress.XtraEditors.FilterControl
		Private BarManager As DevExpress.XtraBars.BarManager
		Private barDockControlTop As DevExpress.XtraBars.BarDockControl
		Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
		Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
		Private barDockControlRight As DevExpress.XtraBars.BarDockControl
		Private bindingSource1 As System.Windows.Forms.BindingSource
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private dataColumn4 As System.Data.DataColumn
		Private dataColumn5 As System.Data.DataColumn
		Private dataColumn6 As System.Data.DataColumn
		Private dataColumn7 As System.Data.DataColumn
		Private dataColumn8 As System.Data.DataColumn
		Private dataColumn9 As System.Data.DataColumn
		Private dataColumn10 As System.Data.DataColumn
		Private dataColumn11 As System.Data.DataColumn
		Private dataColumn12 As System.Data.DataColumn
		Private dataColumn13 As System.Data.DataColumn
		Private dataColumn14 As System.Data.DataColumn
		Private dataColumn15 As System.Data.DataColumn
		Private dataColumn16 As System.Data.DataColumn
		Private dataColumn17 As System.Data.DataColumn
		Private dataColumn18 As System.Data.DataColumn
		Private dataColumn19 As System.Data.DataColumn
		Private dataColumn20 As System.Data.DataColumn
		Private dataColumn21 As System.Data.DataColumn
		Private dataColumn22 As System.Data.DataColumn
		Private dataColumn23 As System.Data.DataColumn
		Private dataColumn24 As System.Data.DataColumn
		Private dataColumn25 As System.Data.DataColumn
		Private dataColumn26 As System.Data.DataColumn
		Private dataColumn27 As System.Data.DataColumn
		Private dataColumn28 As System.Data.DataColumn
		Private dataColumn29 As System.Data.DataColumn
		Private dataColumn30 As System.Data.DataColumn
		Private dataColumn31 As System.Data.DataColumn
		Private dataColumn32 As System.Data.DataColumn
		Private dataColumn33 As System.Data.DataColumn
		Private dataColumn34 As System.Data.DataColumn
		Private dataColumn35 As System.Data.DataColumn
		Private dataColumn36 As System.Data.DataColumn
		Private dataColumn37 As System.Data.DataColumn
		Private dataColumn38 As System.Data.DataColumn
		Private dataColumn39 As System.Data.DataColumn
	End Class
End Namespace

