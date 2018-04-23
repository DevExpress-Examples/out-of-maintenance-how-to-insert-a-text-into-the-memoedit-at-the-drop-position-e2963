Imports Microsoft.VisualBasic
Imports System
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.XtraEditors

Namespace MemoEditDragDropInsertText
	Partial Public Class Form1
		Inherits Form
		Private fDragPoint As Point

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnSourceEditorMouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles sourceEditor.MouseDown
			If e.Button <> MouseButtons.Left OrElse (Control.ModifierKeys And Keys.Shift) <> Keys.Shift Then
				Return
			End If
			fDragPoint = e.Location
		End Sub

		Private Sub OnSourceEditorMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles sourceEditor.MouseUp
			fDragPoint = Point.Empty
		End Sub

		Private Sub OnSourceEditorMouseMove(ByVal sender As Object, ByVal e As MouseEventArgs) Handles sourceEditor.MouseMove
			If fDragPoint = Point.Empty Then
				Return
			End If
			If Math.Abs(fDragPoint.X - e.X) < SystemInformation.DragSize.Width AndAlso Math.Abs(fDragPoint.Y - e.Y) < SystemInformation.DragSize.Height Then
				Return
			End If
			fDragPoint = Point.Empty
			sourceEditor.DoDragDrop(sourceEditor.Text, DragDropEffects.Copy)
		End Sub

		Private Sub OnTargetEditorDragOver(ByVal sender As Object, ByVal e As DragEventArgs) Handles memoEdit1.DragOver
			If e.Data.GetDataPresent(GetType(String)) AndAlso (e.AllowedEffect And DragDropEffects.Copy) = DragDropEffects.Copy Then
				e.Effect = DragDropEffects.Copy
			Else
				e.Effect = DragDropEffects.None
			End If
		End Sub

		Private Sub OnTargetEditorDragDrop(ByVal sender As Object, ByVal e As DragEventArgs) Handles memoEdit1.DragDrop
			Dim editor As TextEdit = CType(sender, TextEdit)
			Dim textBox As TextBox = editor.MaskBox
			Dim text As String = CStr(e.Data.GetData(GetType(String)))
			textBox.SelectionStart = textBox.GetCharIndexFromPosition(textBox.PointToClient(New Point(e.X, e.Y)))
			textBox.SelectionLength = 0
			textBox.Paste(text)
		End Sub
	End Class
End Namespace