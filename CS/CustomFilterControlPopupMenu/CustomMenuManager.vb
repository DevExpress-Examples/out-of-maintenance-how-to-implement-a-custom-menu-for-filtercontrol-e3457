Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraBars
Imports System.Windows.Forms
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraEditors
Imports System.Collections.Generic

Namespace CustomFilterControlPopupMenu
	Public Class CustomMenuManager
        Implements IDXMenuManager
		Private Manager As BarManager

		Public Sub New(ByVal manager As BarManager)
			Me.Manager = manager
		End Sub

		Private fPopup As PopupControlContainer
		Private ReadOnly Property Popup() As PopupControlContainer
			Get
				If fPopup Is Nothing Then
					fPopup = New PopupControlContainer()
					fPopup.Manager = Manager
					AddHandler fPopup.CloseUp, AddressOf OnPopupCloseUp
				End If
				Return fPopup
			End Get
		End Property

		Private fListBox As ListBoxControl
		Private ReadOnly Property ListBox() As ListBoxControl
			Get
				If fListBox Is Nothing Then
					fListBox = New ListBoxControl()
					fListBox.Dock = DockStyle.Fill
					fListBox.Parent = Popup
					AddHandler fListBox.MouseClick, AddressOf OnItemClick
					AddHandler fListBox.KeyDown, AddressOf OnListBoxKeyDown
					fListBox.IncrementalSearch = True
				End If
				Return fListBox
			End Get
		End Property

		Private Sub OnItemClick(ByVal sender As Object, ByVal e As EventArgs)
			CType(ListBox.SelectedItem, DXMenuItemWrapper).DoClick()
			Popup.HidePopup()
		End Sub

		Private Sub OnPopupCloseUp(ByVal sender As Object, ByVal e As EventArgs)
			For Each d As IDisposable In ListBox.Items
				d.Dispose()
			Next d
			ListBox.Items.Clear()
		End Sub

		Private Sub OnListBoxKeyDown(ByVal sender As Object, ByVal e As KeyEventArgs)
			If e.KeyCode = Keys.Enter Then
				OnItemClick(fListBox, EventArgs.Empty)
			End If
		End Sub

		Private Class DXMenuItemWrapper
			Implements IDisposable
			Private Item As DXMenuItem

			Public Sub New(ByVal item As DXMenuItem)
				Me.Item = item
			End Sub

			Public Overrides Function ToString() As String
				Return Item.Caption
			End Function

			Public Sub DoClick()
				Item.GenerateClickEvent()
			End Sub

			#Region "IDisposable"
			Private Sub Dispose() Implements IDisposable.Dispose
				Item = Nothing
				GC.SuppressFinalize(Me)
			End Sub
			#End Region
		End Class

		#Region "IDXMenuManager"
		Private Function Clone(ByVal newForm As Form) As IDXMenuManager Implements IDXMenuManager.Clone
			Return Me
		End Function

		Private Sub DisposeManager() Implements IDXMenuManager.DisposeManager
			fPopup.Dispose()
			Manager = Nothing
		End Sub

		Private Sub ShowPopupMenu(ByVal menu As DXPopupMenu, ByVal control As Control, ByVal pos As Point) Implements IDXMenuManager.ShowPopupMenu
			If menu.Tag Is Nothing Then
				CType(New DXPopupStandardOwnerDrawMenu(New DXMenuItemPainter(), menu), DXPopupStandardOwnerDrawMenu).Show(control, pos)
			Else
				ListBox.BeginUpdate()
				Try
					For Each i As DXMenuItem In menu.Items
						ListBox.Items.Add(New DXMenuItemWrapper(i))
					Next i
				Finally
					ListBox.EndUpdate()
				End Try
				Popup.ShowPopup(control.PointToScreen(pos))
				ListBox.Focus()
			End If
		End Sub
		#End Region
	End Class
End Namespace
