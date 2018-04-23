namespace MemoEditDragDropInsertText {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.sourceEditor = new DevExpress.XtraEditors.TextEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.sourceEditor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // sourceEditor
            // 
            this.sourceEditor.Location = new System.Drawing.Point(12, 12);
            this.sourceEditor.Name = "sourceEditor";
            this.sourceEditor.Size = new System.Drawing.Size(268, 20);
            this.sourceEditor.TabIndex = 0;
            this.sourceEditor.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnSourceEditorMouseUp);
            this.sourceEditor.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnSourceEditorMouseMove);
            this.sourceEditor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnSourceEditorMouseDown);
            // 
            // memoEdit1
            // 
            this.memoEdit1.AllowDrop = true;
            this.memoEdit1.Location = new System.Drawing.Point(12, 38);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(268, 223);
            this.memoEdit1.TabIndex = 1;
            this.memoEdit1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnTargetEditorDragDrop);
            this.memoEdit1.DragOver += new System.Windows.Forms.DragEventHandler(this.OnTargetEditorDragOver);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.sourceEditor);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.sourceEditor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit sourceEditor;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}

