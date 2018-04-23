using System;
using System.Windows.Forms;
using System.Drawing;
using DevExpress.XtraEditors;

namespace MemoEditDragDropInsertText {
    public partial class Form1 :Form {
        Point fDragPoint;

        public Form1() {
            InitializeComponent();
        }

        private void OnSourceEditorMouseDown(object sender, MouseEventArgs e) {
            if (e.Button != MouseButtons.Left || 
                (Control.ModifierKeys & Keys.Shift) != Keys.Shift) 
                return;
            fDragPoint = e.Location;
        }

        private void OnSourceEditorMouseUp(object sender, MouseEventArgs e) {
            fDragPoint = Point.Empty;
        }

        private void OnSourceEditorMouseMove(object sender, MouseEventArgs e) {
            if (fDragPoint == Point.Empty) return;
            if (Math.Abs(fDragPoint.X - e.X) < SystemInformation.DragSize.Width &&
                Math.Abs(fDragPoint.Y - e.Y) < SystemInformation.DragSize.Height)
                return;
            fDragPoint = Point.Empty;
            sourceEditor.DoDragDrop(sourceEditor.Text, DragDropEffects.Copy);
        }

        private void OnTargetEditorDragOver(object sender, DragEventArgs e) {
            e.Effect = e.Data.GetDataPresent(typeof(string)) &&
                (e.AllowedEffect & DragDropEffects.Copy) == DragDropEffects.Copy ?
                DragDropEffects.Copy : DragDropEffects.None;
        }

        private void OnTargetEditorDragDrop(object sender, DragEventArgs e) {
            TextEdit editor = (TextEdit)sender;
            TextBox textBox = editor.MaskBox;
            string text = (string)e.Data.GetData(typeof(string));
            textBox.SelectionStart = textBox.GetCharIndexFromPosition(textBox.PointToClient(new Point(e.X, e.Y)));
            textBox.SelectionLength = 0;
            textBox.Paste(text);
        }
    }
}