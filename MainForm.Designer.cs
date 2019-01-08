namespace PdfMerger
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.inputGroup = new System.Windows.Forms.GroupBox();
            this.inputFileView = new System.Windows.Forms.ListView();
            this.clearFiles = new System.Windows.Forms.Button();
            this.removeFiles = new System.Windows.Forms.Button();
            this.addFiles = new System.Windows.Forms.Button();
            this.mergeFiles = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveMergedPdfDialog = new System.Windows.Forms.SaveFileDialog();
            this.clearOnMerge = new System.Windows.Forms.CheckBox();
            this.inputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroup
            // 
            this.inputGroup.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputGroup.Controls.Add(this.clearOnMerge);
            this.inputGroup.Controls.Add(this.inputFileView);
            this.inputGroup.Controls.Add(this.clearFiles);
            this.inputGroup.Controls.Add(this.removeFiles);
            this.inputGroup.Controls.Add(this.addFiles);
            this.inputGroup.Location = new System.Drawing.Point(13, 13);
            this.inputGroup.Name = "inputGroup";
            this.inputGroup.Size = new System.Drawing.Size(775, 395);
            this.inputGroup.TabIndex = 0;
            this.inputGroup.TabStop = false;
            this.inputGroup.Text = "Input Files";
            // 
            // inputFileView
            // 
            this.inputFileView.AllowDrop = true;
            this.inputFileView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.inputFileView.Location = new System.Drawing.Point(7, 20);
            this.inputFileView.Name = "inputFileView";
            this.inputFileView.Size = new System.Drawing.Size(762, 340);
            this.inputFileView.TabIndex = 3;
            this.inputFileView.UseCompatibleStateImageBehavior = false;
            this.inputFileView.View = System.Windows.Forms.View.List;
            // 
            // clearFiles
            // 
            this.clearFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.clearFiles.Location = new System.Drawing.Point(171, 366);
            this.clearFiles.Name = "clearFiles";
            this.clearFiles.Size = new System.Drawing.Size(75, 23);
            this.clearFiles.TabIndex = 2;
            this.clearFiles.Text = "Clear";
            this.clearFiles.UseVisualStyleBackColor = true;
            this.clearFiles.Click += new System.EventHandler(this.OnClearClickedHandler);
            // 
            // removeFiles
            // 
            this.removeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeFiles.Location = new System.Drawing.Point(89, 366);
            this.removeFiles.Name = "removeFiles";
            this.removeFiles.Size = new System.Drawing.Size(75, 23);
            this.removeFiles.TabIndex = 1;
            this.removeFiles.Text = "Remove";
            this.removeFiles.UseVisualStyleBackColor = true;
            this.removeFiles.Click += new System.EventHandler(this.OnRemoveClickedHandler);
            // 
            // addFiles
            // 
            this.addFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addFiles.Location = new System.Drawing.Point(7, 366);
            this.addFiles.Name = "addFiles";
            this.addFiles.Size = new System.Drawing.Size(75, 23);
            this.addFiles.TabIndex = 0;
            this.addFiles.Text = "Add";
            this.addFiles.UseVisualStyleBackColor = true;
            this.addFiles.Click += new System.EventHandler(this.OnAddClickedHandler);
            // 
            // mergeFiles
            // 
            this.mergeFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mergeFiles.Location = new System.Drawing.Point(713, 414);
            this.mergeFiles.Name = "mergeFiles";
            this.mergeFiles.Size = new System.Drawing.Size(75, 24);
            this.mergeFiles.TabIndex = 1;
            this.mergeFiles.Text = "Merge";
            this.mergeFiles.UseVisualStyleBackColor = true;
            this.mergeFiles.Click += new System.EventHandler(this.OnMergeClickedHandler);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "PDF (*.pdf)|*.pdf;";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Select PDF files";
            // 
            // saveMergedPdfDialog
            // 
            this.saveMergedPdfDialog.Filter = "PDF (*.pdf)|*.pdf;";
            // 
            // clearOnMerge
            // 
            this.clearOnMerge.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearOnMerge.AutoSize = true;
            this.clearOnMerge.Location = new System.Drawing.Point(663, 372);
            this.clearOnMerge.Name = "clearOnMerge";
            this.clearOnMerge.Size = new System.Drawing.Size(106, 17);
            this.clearOnMerge.TabIndex = 4;
            this.clearOnMerge.Text = "Clear after merge";
            this.clearOnMerge.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mergeFiles);
            this.Controls.Add(this.inputGroup);
            this.Name = "MainForm";
            this.Text = "PDF Merger";
            this.inputGroup.ResumeLayout(false);
            this.inputGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox inputGroup;
        private System.Windows.Forms.Button addFiles;
        private System.Windows.Forms.Button removeFiles;
        private System.Windows.Forms.Button clearFiles;
        private System.Windows.Forms.ListView inputFileView;
        private System.Windows.Forms.Button mergeFiles;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveMergedPdfDialog;
        private System.Windows.Forms.CheckBox clearOnMerge;
    }
}

