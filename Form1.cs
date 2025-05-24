using System.Diagnostics;

namespace SharpImageCompressor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            comboBoxPngQuality.SelectedIndex = 0;
        }

        private void button_BrowseInput_Click(object sender, EventArgs e)
        {
            string selectedPath = BrowseForFolder();
            if (selectedPath != string.Empty)
            {
                inputPathTextBox.Text = selectedPath;
            }
        }

        private void button_BrowseOutput_Click(object sender, EventArgs e)
        {
            string selectedPath = BrowseForFolder();
            if (selectedPath != string.Empty)
            {
                outputPathTextBox.Text = selectedPath;
            }
        }

        private string BrowseForFolder()
        {
            using var dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                return dialog.SelectedPath;
            }
            return string.Empty;
        }

        private void trackBar_Quality_Scroll(object sender, EventArgs e)
        {
            qualityTrackBar.Value = (qualityTrackBar.Value / 5) * 5;
            labelJPEGQuality.Text = $"JPEG Quality: {qualityTrackBar.Value}%";
        }

        private async void button_StartCompression_Click(object sender, EventArgs e)
        {
            if (!ValidateDirectories(out string inputDir, out string outputDir)) return;

            ClearOutputFolder();
            ToggleUIEnabledState(false);
            ResetGroupBoxStats();
            progressBar.Value = 0;
            progressBar.Maximum = 100;

            var compressor = new ImageCompressor
            {
                InputFolder = inputDir,
                OutputFolder = outputDir,
                JpegCompressionQuality = qualityTrackBar.Value,
                PngCompressionQuality = comboBoxPngQuality.Text,
                ConvertPngToJpeg = checkBoxConvertPNGtoJPEG.Checked
            };

            var stopwatch = Stopwatch.StartNew();

            await compressor.CompressAllAsync(new Progress<(int completed, int total)>(UpdateProgress));

            stopwatch.Stop();
            ShowSummary(inputDir, outputDir, stopwatch.Elapsed, compressor.PngsConverted, compressor.PngsRetained, compressor.ImgsRetained, compressor.ImgsConverted);
            ToggleUIEnabledState(true);
        }

        private bool ValidateDirectories(out string inputDir, out string outputDir)
        {
            inputDir = inputPathTextBox.Text.Trim();
            outputDir = outputPathTextBox.Text.Trim();

            if (string.IsNullOrWhiteSpace(inputDir) || !Directory.Exists(inputDir))
            {
                MessageBox.Show("Please select an input folder", "Invalid Input Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(outputDir))
            {
                MessageBox.Show("Please select an output folder", "Invalid Output Folder", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void ToggleUIEnabledState(bool state)
        {
            inputPathTextBox.Enabled = state;
            outputPathTextBox.Enabled = state;
            buttonBrowseOutput.Enabled = state;
            buttonBrowseInput.Enabled = state;
            buttonStart.Enabled = state;
            qualityTrackBar.Enabled = state;
            checkBoxConvertPNGtoJPEG.Enabled = state;
        }

        private void UpdateProgress((int completed, int total) progress)
        {
            int percent = (int)((progress.completed / (double)progress.total) * 100);
            progressBar.Value = percent;
            labelStatus.Text = $"Compressed {progress.completed} of {progress.total} images...";
        }

        private void ClearOutputFolder()
        {
            string folderPath = outputPathTextBox.Text.Trim();

            bool hasContent = Directory.EnumerateFileSystemEntries(folderPath).Any();

            if (hasContent)
            {
                var result = MessageBox.Show("The output folder contains files or folders.\r\nDo you want to delete all contents?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    try
                    {
                        foreach (string file in Directory.GetFiles(folderPath))
                            File.Delete(file);

                        foreach (string dir in Directory.GetDirectories(folderPath))
                            Directory.Delete(dir, recursive: true);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error clearing folder:\n{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }           
        }

        private long GetFolderSize(string path)
        {
            long size = 0;
            var allowedExtensions = new HashSet<string>(StringComparer.OrdinalIgnoreCase)
            {
                ".jpg", ".jpeg", ".png"
            };

            try
            {
                foreach (var file in Directory.GetFiles(path, "*.*", SearchOption.AllDirectories))
                {
                    try
                    {
                        string ext = Path.GetExtension(file);
                        if (allowedExtensions.Contains(ext))
                        {
                            size += new FileInfo(file).Length;
                        }
                    }
                    catch (UnauthorizedAccessException) { }
                }
            }
            catch (UnauthorizedAccessException) { }

            return size;
        }

        private string FormatBytes(long bytes)
        {
            string[] sizes = { "B", "KB", "MB", "GB", "TB" };
            double len = bytes;
            int order = 0;
            while (len >= 1024 && order < sizes.Length - 1)
            {
                order++;
                len /= 1024;
            }
            return $"{len:0.##} {sizes[order]}";
        }

        private string FormatElapsedTime(TimeSpan elapsed)
        {
            return elapsed.TotalSeconds < 60 ? $"{elapsed.TotalSeconds:0.##} seconds" : $"{(int)elapsed.TotalMinutes} min {elapsed.Seconds} sec";
        }

        private void ResetGroupBoxStats()
        {
            labelStatsStorage.Text = $"Storage: N/A";
            labelStatsReductionPercent.Text = $"Reduction: N/A";
            labelStatsConvertedPNGs.Text = $"Converted PNG's to JPEG: N/A";
            labelStatsRetainedPNGs.Text = $"PNG's Retained: N/A";
            labelStatsRetainedImgs.Text = $"Images Retained: N/A";
            labelStatsCompressedImgs.Text = $"Images Compressed: N/A";
            labelStatsTimeTaken.Text = $"Time Taken: N/A";
        }

        private void ShowSummary(string inputDir, string outputDir, TimeSpan elapsed, int PngsConverted, int PngsRetained, int ImgsRetained, int ImgsCompressed)
        {
            long inputSize = GetFolderSize(inputDir);
            long outputSize = GetFolderSize(outputDir);
            long bytesSaved = inputSize - outputSize;
            double reduction = inputSize == 0 ? 0 : (1 - (outputSize / (double)inputSize)) * 100;
            string savedFormatted = FormatBytes(bytesSaved);
            string elapsedFormatted = FormatElapsedTime(elapsed);

            labelStatsStorage.Text = $"Storage: Before: {FormatBytes(inputSize)} → After: {FormatBytes(outputSize)}";
            labelStatsReductionPercent.Text = $"Reduction: {savedFormatted} → {reduction:0.##}%";
            labelStatsConvertedPNGs.Text = $"Converted PNG's to JPEG: {PngsConverted}";
            labelStatsRetainedPNGs.Text = $"PNG's Retained: {PngsRetained}";
            labelStatsRetainedImgs.Text = $"Images Retained: {ImgsRetained}";
            labelStatsCompressedImgs.Text = $"Images Compressed: {ImgsCompressed}";
            labelStatsTimeTaken.Text = $"Time Taken: {elapsedFormatted}";
        }
    }
}