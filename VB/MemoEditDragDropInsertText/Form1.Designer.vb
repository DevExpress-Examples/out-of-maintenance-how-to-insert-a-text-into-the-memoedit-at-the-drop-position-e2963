Imports Microsoft.VisualBasic
Imports System
Namespace MemoEditDragDropInsertText
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
			Me.sourceEditor = New DevExpress.XtraEditors.TextEdit()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.sourceEditor.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' sourceEditor
			' 
			Me.sourceEditor.Location = New System.Drawing.Point(12, 12)
			Me.sourceEditor.Name = "sourceEditor"
			Me.sourceEditor.Size = New System.Drawing.Size(268, 20)
			Me.sourceEditor.TabIndex = 0
'			Me.sourceEditor.MouseUp += New System.Windows.Forms.MouseEventHandler(Me.OnSourceEditorMouseUp);
'			Me.sourceEditor.MouseMove += New System.Windows.Forms.MouseEventHandler(Me.OnSourceEditorMouseMove);
'			Me.sourceEditor.MouseDown += New System.Windows.Forms.MouseEventHandler(Me.OnSourceEditorMouseDown);
			' 
			' memoEdit1
			' 
			Me.memoEdit1.AllowDrop = True
			Me.memoEdit1.Location = New System.Drawing.Point(12, 38)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(268, 223)
			Me.memoEdit1.TabIndex = 1
'			Me.memoEdit1.DragDrop += New System.Windows.Forms.DragEventHandler(Me.OnTargetEditorDragDrop);
'			Me.memoEdit1.DragOver += New System.Windows.Forms.DragEventHandler(Me.OnTargetEditorDragOver);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(292, 273)
			Me.Controls.Add(Me.memoEdit1)
			Me.Controls.Add(Me.sourceEditor)
			Me.Name = "Form1"
			Me.Text = "Form1"
			CType(Me.sourceEditor.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents sourceEditor As DevExpress.XtraEditors.TextEdit
		Private WithEvents memoEdit1 As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace

