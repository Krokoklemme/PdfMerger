// Copyright © 2019 Henning Hoppe
// This work is free.You can redistribute it and/or modify it under the
// terms of the Do What The Fuck You Want To Public License, Version 2,
// as published by Sam Hocevar.See the COPYING file or http://www.wtfpl.net/
// for more details.

namespace PdfMerger
{
    using System;
    using System.IO;
    using System.Windows.Forms;

    using Patagames.Pdf.Net;

    using PdfMerger.Windows.Forms;
    using PdfMerger.Properties;

    public partial class MainForm : Form
    {
        public MainForm()
        {
            PdfCommon.Initialize();
            InitializeComponent();

            inputFileView.DragEnter += (o, e) => e.Effect = DragDropEffects.Copy;
            inputFileView.DragDrop += OnInputFileDragDropHandler;

            clearOnMerge.CheckedChanged += (o, e) =>
            {
                Settings.Default.ClearOnMerge = clearOnMerge.Checked;
                Settings.Default.Save();
            };

            saveMergedPdfDialog.FileName = Settings.Default.LastTargetName;
        }

        private void OnInputFileDragDropHandler(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                var files = (string[])e.Data.GetData(DataFormats.FileDrop);

                foreach (var file in files)
                {
                    if (Path.GetExtension(file) == ".pdf")
                    {
                        inputFileView.Items.AddUniqueInvariant(Path.GetFullPath(file));
                    }
                }
            }
        }

        private void OnAddClickedHandler(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (var file in openFileDialog.FileNames)
                {
                    inputFileView.Items.AddUniqueInvariant(Path.GetFullPath(file));
                }
            }
        }

        private void OnRemoveClickedHandler(object sender, EventArgs e)
        {
            foreach (ListViewItem item in inputFileView.SelectedItems)
            {
                inputFileView.Items.Remove(item);
            }
        }

        private void OnClearClickedHandler(object sender, EventArgs e)
        {
            inputFileView.Items.Clear();
        }

        private void OnMergeClickedHandler(object sender, EventArgs e)
        {
            if (saveMergedPdfDialog.ShowDialog() == DialogResult.OK)
            {
                using (var targetDoc = PdfDocument.CreateNew())
                {
                    foreach (ListViewItem pdf in inputFileView.Items)
                    {
                        using (var doc = PdfDocument.Load(pdf.Text))
                        {
                            targetDoc.Pages.ImportPages(doc, $"1-{doc.Pages.Count}", targetDoc.Pages.Count);
                        }
                    }

                    var file = saveMergedPdfDialog.FileName;
                    targetDoc.Save(file, Patagames.Pdf.Enums.SaveFlags.NoIncremental);
                    Settings.Default.LastTargetDir = Path.GetDirectoryName(file);
                    Settings.Default.LastTargetName = Path.GetFileName(file);
                    Settings.Default.Save();
                }

                if (clearOnMerge.Checked)
                {
                    OnClearClickedHandler(null, EventArgs.Empty);
                }
            }
        }
    }
}
