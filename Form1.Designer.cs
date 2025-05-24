namespace SharpImageCompressor
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            labelStatus = new Label();
            progressBar = new ProgressBar();
            buttonStart = new Button();
            inputPathTextBox = new TextBox();
            buttonBrowseInput = new Button();
            outputPathTextBox = new TextBox();
            buttonBrowseOutput = new Button();
            qualityTrackBar = new TrackBar();
            labelJPEGQuality = new Label();
            labelInput = new Label();
            labelOutput = new Label();
            labelAppTitle = new Label();
            checkBoxConvertPNGtoJPEG = new CheckBox();
            groupBoxResults = new GroupBox();
            labelStatsTimeTaken = new Label();
            labelStatsCompressedImgs = new Label();
            labelStatsRetainedImgs = new Label();
            labelStatsRetainedPNGs = new Label();
            labelStatsConvertedPNGs = new Label();
            labelStatsReductionPercent = new Label();
            labelStatsStorage = new Label();
            comboBoxPngQuality = new ComboBox();
            labelPNGQuality = new Label();
            ((System.ComponentModel.ISupportInitialize)qualityTrackBar).BeginInit();
            groupBoxResults.SuspendLayout();
            SuspendLayout();
            // 
            // labelStatus
            // 
            labelStatus.ForeColor = Color.White;
            labelStatus.Location = new Point(12, 352);
            labelStatus.Name = "labelStatus";
            labelStatus.Size = new Size(360, 20);
            labelStatus.TabIndex = 0;
            labelStatus.Text = "Idle.....";
            labelStatus.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(12, 334);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(360, 15);
            progressBar.TabIndex = 1;
            // 
            // buttonStart
            // 
            buttonStart.BackColor = SystemColors.Highlight;
            buttonStart.FlatAppearance.BorderSize = 0;
            buttonStart.FlatStyle = FlatStyle.Flat;
            buttonStart.ForeColor = Color.White;
            buttonStart.Location = new Point(12, 277);
            buttonStart.Name = "buttonStart";
            buttonStart.Size = new Size(360, 34);
            buttonStart.TabIndex = 2;
            buttonStart.Text = "BEGIN COMPRESSION";
            buttonStart.UseVisualStyleBackColor = false;
            buttonStart.Click += button_StartCompression_Click;
            // 
            // inputPathTextBox
            // 
            inputPathTextBox.Location = new Point(12, 60);
            inputPathTextBox.Name = "inputPathTextBox";
            inputPathTextBox.Size = new Size(279, 23);
            inputPathTextBox.TabIndex = 3;
            // 
            // buttonBrowseInput
            // 
            buttonBrowseInput.BackColor = SystemColors.MenuHighlight;
            buttonBrowseInput.FlatAppearance.BorderSize = 0;
            buttonBrowseInput.FlatStyle = FlatStyle.Flat;
            buttonBrowseInput.ForeColor = Color.White;
            buttonBrowseInput.Location = new Point(297, 59);
            buttonBrowseInput.Name = "buttonBrowseInput";
            buttonBrowseInput.Size = new Size(75, 23);
            buttonBrowseInput.TabIndex = 4;
            buttonBrowseInput.Text = "Browse";
            buttonBrowseInput.UseVisualStyleBackColor = false;
            buttonBrowseInput.Click += button_BrowseInput_Click;
            // 
            // outputPathTextBox
            // 
            outputPathTextBox.Location = new Point(12, 118);
            outputPathTextBox.Name = "outputPathTextBox";
            outputPathTextBox.Size = new Size(279, 23);
            outputPathTextBox.TabIndex = 5;
            // 
            // buttonBrowseOutput
            // 
            buttonBrowseOutput.BackColor = SystemColors.Highlight;
            buttonBrowseOutput.FlatAppearance.BorderSize = 0;
            buttonBrowseOutput.FlatStyle = FlatStyle.Flat;
            buttonBrowseOutput.ForeColor = Color.White;
            buttonBrowseOutput.Location = new Point(297, 118);
            buttonBrowseOutput.Name = "buttonBrowseOutput";
            buttonBrowseOutput.Size = new Size(75, 23);
            buttonBrowseOutput.TabIndex = 6;
            buttonBrowseOutput.Text = "Browse";
            buttonBrowseOutput.UseVisualStyleBackColor = false;
            buttonBrowseOutput.Click += button_BrowseOutput_Click;
            // 
            // qualityTrackBar
            // 
            qualityTrackBar.Location = new Point(12, 179);
            qualityTrackBar.Maximum = 100;
            qualityTrackBar.Minimum = 5;
            qualityTrackBar.Name = "qualityTrackBar";
            qualityTrackBar.Size = new Size(360, 45);
            qualityTrackBar.SmallChange = 5;
            qualityTrackBar.TabIndex = 7;
            qualityTrackBar.TickFrequency = 10;
            qualityTrackBar.TickStyle = TickStyle.None;
            qualityTrackBar.Value = 80;
            qualityTrackBar.Scroll += trackBar_Quality_Scroll;
            // 
            // labelJPEGQuality
            // 
            labelJPEGQuality.AutoSize = true;
            labelJPEGQuality.ForeColor = Color.White;
            labelJPEGQuality.Location = new Point(12, 161);
            labelJPEGQuality.Name = "labelJPEGQuality";
            labelJPEGQuality.Size = new Size(101, 15);
            labelJPEGQuality.TabIndex = 8;
            labelJPEGQuality.Text = "JPEG Quality: 80%";
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.ForeColor = Color.White;
            labelInput.Location = new Point(12, 42);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(86, 15);
            labelInput.TabIndex = 9;
            labelInput.Text = "Input Directory";
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.ForeColor = Color.White;
            labelOutput.Location = new Point(12, 100);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(96, 15);
            labelOutput.TabIndex = 10;
            labelOutput.Text = "Output Directory";
            // 
            // labelAppTitle
            // 
            labelAppTitle.AutoSize = true;
            labelAppTitle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            labelAppTitle.ForeColor = Color.White;
            labelAppTitle.Location = new Point(12, 9);
            labelAppTitle.Name = "labelAppTitle";
            labelAppTitle.Size = new Size(195, 21);
            labelAppTitle.TabIndex = 11;
            labelAppTitle.Text = "Sharp Image Compressor";
            // 
            // checkBoxConvertPNGtoJPEG
            // 
            checkBoxConvertPNGtoJPEG.AutoSize = true;
            checkBoxConvertPNGtoJPEG.ForeColor = Color.White;
            checkBoxConvertPNGtoJPEG.Location = new Point(235, 232);
            checkBoxConvertPNGtoJPEG.Name = "checkBoxConvertPNGtoJPEG";
            checkBoxConvertPNGtoJPEG.Size = new Size(137, 19);
            checkBoxConvertPNGtoJPEG.TabIndex = 16;
            checkBoxConvertPNGtoJPEG.Text = "Convert PNG to JPEG";
            checkBoxConvertPNGtoJPEG.UseVisualStyleBackColor = true;
            // 
            // groupBoxResults
            // 
            groupBoxResults.Controls.Add(labelStatsTimeTaken);
            groupBoxResults.Controls.Add(labelStatsCompressedImgs);
            groupBoxResults.Controls.Add(labelStatsRetainedImgs);
            groupBoxResults.Controls.Add(labelStatsRetainedPNGs);
            groupBoxResults.Controls.Add(labelStatsConvertedPNGs);
            groupBoxResults.Controls.Add(labelStatsReductionPercent);
            groupBoxResults.Controls.Add(labelStatsStorage);
            groupBoxResults.FlatStyle = FlatStyle.Flat;
            groupBoxResults.ForeColor = Color.White;
            groupBoxResults.Location = new Point(12, 393);
            groupBoxResults.Name = "groupBoxResults";
            groupBoxResults.Size = new Size(360, 152);
            groupBoxResults.TabIndex = 17;
            groupBoxResults.TabStop = false;
            groupBoxResults.Text = "Results Information";
            // 
            // labelStatsTimeTaken
            // 
            labelStatsTimeTaken.AutoSize = true;
            labelStatsTimeTaken.Font = new Font("Segoe UI", 8.25F);
            labelStatsTimeTaken.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsTimeTaken.Location = new Point(6, 127);
            labelStatsTimeTaken.Name = "labelStatsTimeTaken";
            labelStatsTimeTaken.Padding = new Padding(0, 0, 0, 5);
            labelStatsTimeTaken.Size = new Size(89, 18);
            labelStatsTimeTaken.TabIndex = 6;
            labelStatsTimeTaken.Text = "Time Taken: N/A";
            // 
            // labelStatsCompressedImgs
            // 
            labelStatsCompressedImgs.AutoSize = true;
            labelStatsCompressedImgs.Font = new Font("Segoe UI", 8.25F);
            labelStatsCompressedImgs.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsCompressedImgs.Location = new Point(6, 109);
            labelStatsCompressedImgs.Name = "labelStatsCompressedImgs";
            labelStatsCompressedImgs.Padding = new Padding(0, 0, 0, 5);
            labelStatsCompressedImgs.Size = new Size(134, 18);
            labelStatsCompressedImgs.TabIndex = 5;
            labelStatsCompressedImgs.Text = "Images Compressed: N/A";
            // 
            // labelStatsRetainedImgs
            // 
            labelStatsRetainedImgs.AutoSize = true;
            labelStatsRetainedImgs.Font = new Font("Segoe UI", 8.25F);
            labelStatsRetainedImgs.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsRetainedImgs.Location = new Point(6, 91);
            labelStatsRetainedImgs.Name = "labelStatsRetainedImgs";
            labelStatsRetainedImgs.Padding = new Padding(0, 0, 0, 5);
            labelStatsRetainedImgs.Size = new Size(117, 18);
            labelStatsRetainedImgs.TabIndex = 4;
            labelStatsRetainedImgs.Text = "Images Retained: N/A";
            // 
            // labelStatsRetainedPNGs
            // 
            labelStatsRetainedPNGs.AutoSize = true;
            labelStatsRetainedPNGs.Font = new Font("Segoe UI", 8.25F);
            labelStatsRetainedPNGs.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsRetainedPNGs.Location = new Point(6, 73);
            labelStatsRetainedPNGs.Name = "labelStatsRetainedPNGs";
            labelStatsRetainedPNGs.Padding = new Padding(0, 0, 0, 5);
            labelStatsRetainedPNGs.Size = new Size(111, 18);
            labelStatsRetainedPNGs.TabIndex = 3;
            labelStatsRetainedPNGs.Text = "PNG's Retained: N/A";
            // 
            // labelStatsConvertedPNGs
            // 
            labelStatsConvertedPNGs.AutoSize = true;
            labelStatsConvertedPNGs.Font = new Font("Segoe UI", 8.25F);
            labelStatsConvertedPNGs.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsConvertedPNGs.Location = new Point(6, 55);
            labelStatsConvertedPNGs.Name = "labelStatsConvertedPNGs";
            labelStatsConvertedPNGs.Padding = new Padding(0, 0, 0, 5);
            labelStatsConvertedPNGs.Size = new Size(159, 18);
            labelStatsConvertedPNGs.TabIndex = 2;
            labelStatsConvertedPNGs.Text = "Converted PNG's to JPEG: N/A";
            // 
            // labelStatsReductionPercent
            // 
            labelStatsReductionPercent.AutoSize = true;
            labelStatsReductionPercent.Font = new Font("Segoe UI", 8.25F);
            labelStatsReductionPercent.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsReductionPercent.Location = new Point(6, 37);
            labelStatsReductionPercent.Name = "labelStatsReductionPercent";
            labelStatsReductionPercent.Padding = new Padding(0, 0, 0, 5);
            labelStatsReductionPercent.Size = new Size(85, 18);
            labelStatsReductionPercent.TabIndex = 1;
            labelStatsReductionPercent.Text = "Reduction: N/A";
            // 
            // labelStatsStorage
            // 
            labelStatsStorage.AutoSize = true;
            labelStatsStorage.Font = new Font("Segoe UI", 8.25F);
            labelStatsStorage.ForeColor = Color.FromArgb(224, 224, 224);
            labelStatsStorage.Location = new Point(6, 19);
            labelStatsStorage.Name = "labelStatsStorage";
            labelStatsStorage.Padding = new Padding(0, 0, 0, 5);
            labelStatsStorage.Size = new Size(72, 18);
            labelStatsStorage.TabIndex = 0;
            labelStatsStorage.Text = "Storage: N/A";
            // 
            // comboBoxPngQuality
            // 
            comboBoxPngQuality.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPngQuality.FormattingEnabled = true;
            comboBoxPngQuality.Items.AddRange(new object[] { "Max Compression", "Very High Compression", "High Compression", "Medium High Compression", "Medium Compression", "Medium Low Compression", "Light Compression", "Low Compression", "Very Low Compression", "No Compression" });
            comboBoxPngQuality.Location = new Point(12, 230);
            comboBoxPngQuality.MaxDropDownItems = 10;
            comboBoxPngQuality.MaxLength = 400;
            comboBoxPngQuality.Name = "comboBoxPngQuality";
            comboBoxPngQuality.Size = new Size(195, 23);
            comboBoxPngQuality.TabIndex = 18;
            // 
            // labelPNGQuality
            // 
            labelPNGQuality.AutoSize = true;
            labelPNGQuality.ForeColor = Color.White;
            labelPNGQuality.Location = new Point(12, 209);
            labelPNGQuality.Name = "labelPNGQuality";
            labelPNGQuality.Size = new Size(72, 15);
            labelPNGQuality.TabIndex = 19;
            labelPNGQuality.Text = "PNG Quality";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(384, 555);
            Controls.Add(labelPNGQuality);
            Controls.Add(comboBoxPngQuality);
            Controls.Add(groupBoxResults);
            Controls.Add(checkBoxConvertPNGtoJPEG);
            Controls.Add(labelAppTitle);
            Controls.Add(labelOutput);
            Controls.Add(labelInput);
            Controls.Add(labelJPEGQuality);
            Controls.Add(qualityTrackBar);
            Controls.Add(buttonBrowseOutput);
            Controls.Add(outputPathTextBox);
            Controls.Add(buttonBrowseInput);
            Controls.Add(inputPathTextBox);
            Controls.Add(buttonStart);
            Controls.Add(progressBar);
            Controls.Add(labelStatus);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            SizeGripStyle = SizeGripStyle.Hide;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sharp Image Compressor";
            ((System.ComponentModel.ISupportInitialize)qualityTrackBar).EndInit();
            groupBoxResults.ResumeLayout(false);
            groupBoxResults.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStatus;
        private ProgressBar progressBar;
        private Button buttonStart;
        private TextBox inputPathTextBox;
        private Button buttonBrowseInput;
        private TextBox outputPathTextBox;
        private Button buttonBrowseOutput;
        private TrackBar qualityTrackBar;
        private Label labelJPEGQuality;
        private Label labelInput;
        private Label labelOutput;
        private Label labelAppTitle;
        private CheckBox checkBoxConvertPNGtoJPEG;
        private GroupBox groupBoxResults;
        private Label labelStatsRetainedPNGs;
        private Label labelStatsConvertedPNGs;
        private Label labelStatsReductionPercent;
        private Label labelStatsStorage;
        private Label labelStatsTimeTaken;
        private Label labelStatsCompressedImgs;
        private Label labelStatsRetainedImgs;
        private ComboBox comboBoxPngQuality;
        private Label labelPNGQuality;
    }
}