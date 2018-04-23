Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.XtraEditors
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Filtering

Namespace CustomFilterControlPopupMenu
	Partial Public Class Form1
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
			FilterControl.MenuManager = New CustomMenuManager(BarManager)
			FilterControl.UseMenuForOperandsAndOperators = True
		End Sub

		Private Sub OnPopupMenuShowing(ByVal sender As Object, ByVal e As PopupMenuShowingEventArgs) Handles FilterControl.PopupMenuShowing
			If e.MenuType = FilterControlMenuType.Column Then
				e.Menu.Tag = "custom"
			End If
		End Sub
	End Class
End Namespace