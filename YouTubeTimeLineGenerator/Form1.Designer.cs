namespace YouTubeTimeLineGenerator
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonProcessSourceFile = new System.Windows.Forms.Button();
            this.textBoxSourceFileContent = new System.Windows.Forms.TextBox();
            this.richTextBoxAssResult = new System.Windows.Forms.RichTextBox();
            this.buttonConvertToAssFile = new System.Windows.Forms.Button();
            this.textBox_vttResult = new System.Windows.Forms.TextBox();
            this.radioButtonSourceFileTypeVtt = new System.Windows.Forms.RadioButton();
            this.groupBoxSourceFileType = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanelSourceFileType = new System.Windows.Forms.TableLayoutPanel();
            this.radioButtonSourceFileTypeXml = new System.Windows.Forms.RadioButton();
            this.richTextBoxSubtitleWords = new System.Windows.Forms.RichTextBox();
            this.buttonLoadWords = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonColor = new System.Windows.Forms.Button();
            this.buttonDecreaseFontSize = new System.Windows.Forms.Button();
            this.buttonIncreaseFontSize = new System.Windows.Forms.Button();
            this.tableLayoutPanelAll = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelSubtitleWordsStyling = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelOperationsAndInstructions = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanelOperations = new System.Windows.Forms.TableLayoutPanel();
            this.groupBoxSourceFileType.SuspendLayout();
            this.tableLayoutPanelSourceFileType.SuspendLayout();
            this.tableLayoutPanelAll.SuspendLayout();
            this.tableLayoutPanelSubtitleWordsStyling.SuspendLayout();
            this.tableLayoutPanelOperationsAndInstructions.SuspendLayout();
            this.tableLayoutPanelOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonProcessSourceFile
            // 
            this.buttonProcessSourceFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonProcessSourceFile.Location = new System.Drawing.Point(290, 0);
            this.buttonProcessSourceFile.Margin = new System.Windows.Forms.Padding(16, 0, 16, 18);
            this.buttonProcessSourceFile.Name = "buttonProcessSourceFile";
            this.buttonProcessSourceFile.Size = new System.Drawing.Size(242, 161);
            this.buttonProcessSourceFile.TabIndex = 30;
            this.buttonProcessSourceFile.Text = "Process VTT";
            this.buttonProcessSourceFile.UseVisualStyleBackColor = true;
            this.buttonProcessSourceFile.Click += new System.EventHandler(this.buttonProcessSourceFile_Click);
            // 
            // textBoxSourceFileContent
            // 
            this.textBoxSourceFileContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxSourceFileContent.Location = new System.Drawing.Point(30, 32);
            this.textBoxSourceFileContent.Multiline = true;
            this.textBoxSourceFileContent.Name = "textBoxSourceFileContent";
            this.textBoxSourceFileContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSourceFileContent.Size = new System.Drawing.Size(586, 529);
            this.textBoxSourceFileContent.TabIndex = 100;
            this.textBoxSourceFileContent.Text = "Drag and Drop your YouTube VTT file here.";
            this.textBoxSourceFileContent.WordWrap = false;
            this.textBoxSourceFileContent.DragDrop += new System.Windows.Forms.DragEventHandler(this.textBoxSourceFileContent_DragDrop);
            this.textBoxSourceFileContent.DragOver += new System.Windows.Forms.DragEventHandler(this.textBoxSourceFileContent_DragOver);
            // 
            // richTextBoxAssResult
            // 
            this.richTextBoxAssResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxAssResult.Location = new System.Drawing.Point(18, 203);
            this.richTextBoxAssResult.Margin = new System.Windows.Forms.Padding(18, 18, 0, 0);
            this.richTextBoxAssResult.Name = "richTextBoxAssResult";
            this.richTextBoxAssResult.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.richTextBoxAssResult.Size = new System.Drawing.Size(1360, 326);
            this.richTextBoxAssResult.TabIndex = 80;
            this.richTextBoxAssResult.Text = resources.GetString("richTextBoxAssResult.Text");
            // 
            // buttonConvertToAssFile
            // 
            this.buttonConvertToAssFile.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConvertToAssFile.Location = new System.Drawing.Point(1112, 0);
            this.buttonConvertToAssFile.Margin = new System.Windows.Forms.Padding(16, 0, 0, 18);
            this.buttonConvertToAssFile.Name = "buttonConvertToAssFile";
            this.buttonConvertToAssFile.Size = new System.Drawing.Size(260, 161);
            this.buttonConvertToAssFile.TabIndex = 50;
            this.buttonConvertToAssFile.Text = "Convert to ASS";
            this.buttonConvertToAssFile.UseVisualStyleBackColor = true;
            this.buttonConvertToAssFile.Click += new System.EventHandler(this.buttonConvertToAssFile_Click);
            // 
            // textBox_vttResult
            // 
            this.textBox_vttResult.Location = new System.Drawing.Point(825, 3);
            this.textBox_vttResult.Multiline = true;
            this.textBox_vttResult.Name = "textBox_vttResult";
            this.textBox_vttResult.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_vttResult.Size = new System.Drawing.Size(118, 31);
            this.textBox_vttResult.TabIndex = 7;
            this.textBox_vttResult.Visible = false;
            this.textBox_vttResult.WordWrap = false;
            // 
            // radioButtonSourceFileTypeVtt
            // 
            this.radioButtonSourceFileTypeVtt.AutoSize = true;
            this.radioButtonSourceFileTypeVtt.Checked = true;
            this.radioButtonSourceFileTypeVtt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSourceFileTypeVtt.Location = new System.Drawing.Point(3, 3);
            this.radioButtonSourceFileTypeVtt.Name = "radioButtonSourceFileTypeVtt";
            this.radioButtonSourceFileTypeVtt.Size = new System.Drawing.Size(236, 60);
            this.radioButtonSourceFileTypeVtt.TabIndex = 10;
            this.radioButtonSourceFileTypeVtt.TabStop = true;
            this.radioButtonSourceFileTypeVtt.Text = "Auto VTT";
            this.radioButtonSourceFileTypeVtt.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBoxSourceFileType.Controls.Add(this.tableLayoutPanelSourceFileType);
            this.groupBoxSourceFileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxSourceFileType.Location = new System.Drawing.Point(16, 0);
            this.groupBoxSourceFileType.Margin = new System.Windows.Forms.Padding(16, 0, 16, 18);
            this.groupBoxSourceFileType.Name = "groupBox1";
            this.groupBoxSourceFileType.Padding = new System.Windows.Forms.Padding(0);
            this.groupBoxSourceFileType.Size = new System.Drawing.Size(242, 161);
            this.groupBoxSourceFileType.TabIndex = 10;
            this.groupBoxSourceFileType.TabStop = false;
            this.groupBoxSourceFileType.Text = "File Type";
            // 
            // tableLayoutPanelSourceFileType
            // 
            this.tableLayoutPanelSourceFileType.ColumnCount = 1;
            this.tableLayoutPanelSourceFileType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelSourceFileType.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelSourceFileType.Controls.Add(this.radioButtonSourceFileTypeVtt, 0, 0);
            this.tableLayoutPanelSourceFileType.Controls.Add(this.radioButtonSourceFileTypeXml, 0, 1);
            this.tableLayoutPanelSourceFileType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSourceFileType.Location = new System.Drawing.Point(0, 28);
            this.tableLayoutPanelSourceFileType.Name = "tableLayoutPanelSourceFileType";
            this.tableLayoutPanelSourceFileType.RowCount = 2;
            this.tableLayoutPanelSourceFileType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceFileType.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanelSourceFileType.Size = new System.Drawing.Size(242, 133);
            this.tableLayoutPanelSourceFileType.TabIndex = 11;
            // 
            // radioButtonSourceFileTypeXml
            // 
            this.radioButtonSourceFileTypeXml.AutoSize = true;
            this.radioButtonSourceFileTypeXml.Dock = System.Windows.Forms.DockStyle.Fill;
            this.radioButtonSourceFileTypeXml.Location = new System.Drawing.Point(3, 69);
            this.radioButtonSourceFileTypeXml.Name = "radioButtonSourceFileTypeXml";
            this.radioButtonSourceFileTypeXml.Size = new System.Drawing.Size(236, 61);
            this.radioButtonSourceFileTypeXml.TabIndex = 20;
            this.radioButtonSourceFileTypeXml.Text = "Auto XML";
            this.radioButtonSourceFileTypeXml.UseVisualStyleBackColor = true;
            // 
            // richTextBoxSubtitleWords
            // 
            this.richTextBoxSubtitleWords.AutoWordSelection = true;
            this.tableLayoutPanelAll.SetColumnSpan(this.richTextBoxSubtitleWords, 2);
            this.richTextBoxSubtitleWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxSubtitleWords.Enabled = false;
            this.richTextBoxSubtitleWords.Location = new System.Drawing.Point(30, 687);
            this.richTextBoxSubtitleWords.Name = "richTextBoxSubtitleWords";
            this.richTextBoxSubtitleWords.ReadOnly = true;
            this.richTextBoxSubtitleWords.Size = new System.Drawing.Size(1970, 663);
            this.richTextBoxSubtitleWords.TabIndex = 11;
            this.richTextBoxSubtitleWords.Text = "";
            this.richTextBoxSubtitleWords.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBoxSubtitleWords_MouseUp);
            // 
            // buttonLoadWords
            // 
            this.buttonLoadWords.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonLoadWords.Enabled = false;
            this.buttonLoadWords.Location = new System.Drawing.Point(564, 0);
            this.buttonLoadWords.Margin = new System.Windows.Forms.Padding(16, 0, 16, 18);
            this.buttonLoadWords.Name = "buttonLoadWords";
            this.buttonLoadWords.Size = new System.Drawing.Size(242, 161);
            this.buttonLoadWords.TabIndex = 40;
            this.buttonLoadWords.Text = "Load Words";
            this.buttonLoadWords.UseVisualStyleBackColor = true;
            this.buttonLoadWords.Click += new System.EventHandler(this.buttonLoadWords_Click);
            // 
            // buttonColor
            // 
            this.buttonColor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonColor.Location = new System.Drawing.Point(212, 18);
            this.buttonColor.Margin = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.buttonColor.Size = new System.Drawing.Size(370, 80);
            this.buttonColor.TabIndex = 13;
            this.buttonColor.Text = "Color";
            this.buttonColor.UseVisualStyleBackColor = true;
            this.buttonColor.Visible = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // buttonDecreaseFontSize
            // 
            this.buttonDecreaseFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDecreaseFontSize.Location = new System.Drawing.Point(98, 18);
            this.buttonDecreaseFontSize.Margin = new System.Windows.Forms.Padding(0, 18, 2, 18);
            this.buttonDecreaseFontSize.Name = "buttonDecreaseFontSize";
            this.buttonDecreaseFontSize.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.buttonDecreaseFontSize.Size = new System.Drawing.Size(96, 80);
            this.buttonDecreaseFontSize.TabIndex = 70;
            this.buttonDecreaseFontSize.TabStop = false;
            this.buttonDecreaseFontSize.Text = "-";
            this.buttonDecreaseFontSize.UseVisualStyleBackColor = true;
            this.buttonDecreaseFontSize.Click += new System.EventHandler(this.buttonDecreaseFontSize_Click);
            // 
            // buttonIncreaseFontSize
            // 
            this.buttonIncreaseFontSize.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIncreaseFontSize.Location = new System.Drawing.Point(0, 18);
            this.buttonIncreaseFontSize.Margin = new System.Windows.Forms.Padding(0, 18, 2, 18);
            this.buttonIncreaseFontSize.Name = "buttonIncreaseFontSize";
            this.buttonIncreaseFontSize.Padding = new System.Windows.Forms.Padding(16, 18, 16, 18);
            this.buttonIncreaseFontSize.Size = new System.Drawing.Size(96, 80);
            this.buttonIncreaseFontSize.TabIndex = 60;
            this.buttonIncreaseFontSize.TabStop = false;
            this.buttonIncreaseFontSize.Text = "+";
            this.buttonIncreaseFontSize.UseVisualStyleBackColor = true;
            this.buttonIncreaseFontSize.Click += new System.EventHandler(this.buttonIncreaseFontSize_Click);
            // 
            // tableLayoutPanelAll
            // 
            this.tableLayoutPanelAll.AutoSize = true;
            this.tableLayoutPanelAll.ColumnCount = 2;
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanelAll.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanelAll.Controls.Add(this.richTextBoxSubtitleWords, 0, 2);
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanelSubtitleWordsStyling, 0, 1);
            this.tableLayoutPanelAll.Controls.Add(this.textBoxSourceFileContent, 0, 0);
            this.tableLayoutPanelAll.Controls.Add(this.tableLayoutPanelOperationsAndInstructions, 1, 0);
            this.tableLayoutPanelAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelAll.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanelAll.Margin = new System.Windows.Forms.Padding(27, 29, 27, 29);
            this.tableLayoutPanelAll.Name = "tableLayoutPanelAll";
            this.tableLayoutPanelAll.Padding = new System.Windows.Forms.Padding(27, 29, 27, 29);
            this.tableLayoutPanelAll.RowCount = 3;
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.44444F));
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelAll.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.55556F));
            this.tableLayoutPanelAll.Size = new System.Drawing.Size(2030, 1382);
            this.tableLayoutPanelAll.TabIndex = 19;
            // 
            // tableLayoutPanelSubtitleWordsStyling
            // 
            this.tableLayoutPanelSubtitleWordsStyling.ColumnCount = 3;
            this.tableLayoutPanelSubtitleWordsStyling.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelSubtitleWordsStyling.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 98F));
            this.tableLayoutPanelSubtitleWordsStyling.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanelSubtitleWordsStyling.Controls.Add(this.buttonIncreaseFontSize, 0, 0);
            this.tableLayoutPanelSubtitleWordsStyling.Controls.Add(this.buttonColor, 2, 0);
            this.tableLayoutPanelSubtitleWordsStyling.Controls.Add(this.buttonDecreaseFontSize, 1, 0);
            this.tableLayoutPanelSubtitleWordsStyling.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelSubtitleWordsStyling.Location = new System.Drawing.Point(30, 567);
            this.tableLayoutPanelSubtitleWordsStyling.Name = "tableLayoutPanelSubtitleWordsStyling";
            this.tableLayoutPanelSubtitleWordsStyling.RowCount = 1;
            this.tableLayoutPanelSubtitleWordsStyling.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanelSubtitleWordsStyling.Size = new System.Drawing.Size(586, 114);
            this.tableLayoutPanelSubtitleWordsStyling.TabIndex = 0;
            // 
            // tableLayoutPanelOperationsAndInstructions
            // 
            this.tableLayoutPanelOperationsAndInstructions.AutoSize = true;
            this.tableLayoutPanelOperationsAndInstructions.ColumnCount = 1;
            this.tableLayoutPanelOperationsAndInstructions.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOperationsAndInstructions.Controls.Add(this.richTextBoxAssResult, 0, 1);
            this.tableLayoutPanelOperationsAndInstructions.Controls.Add(this.tableLayoutPanelOperations, 0, 0);
            this.tableLayoutPanelOperationsAndInstructions.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOperationsAndInstructions.Location = new System.Drawing.Point(622, 32);
            this.tableLayoutPanelOperationsAndInstructions.Name = "tableLayoutPanelOperationsAndInstructions";
            this.tableLayoutPanelOperationsAndInstructions.RowCount = 2;
            this.tableLayoutPanelOperationsAndInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanelOperationsAndInstructions.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65F));
            this.tableLayoutPanelOperationsAndInstructions.Size = new System.Drawing.Size(1378, 529);
            this.tableLayoutPanelOperationsAndInstructions.TabIndex = 12;
            // 
            // tableLayoutPanelOperations
            // 
            this.tableLayoutPanelOperations.ColumnCount = 5;
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOperations.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanelOperations.Controls.Add(this.groupBoxSourceFileType, 0, 0);
            this.tableLayoutPanelOperations.Controls.Add(this.buttonProcessSourceFile, 1, 0);
            this.tableLayoutPanelOperations.Controls.Add(this.buttonConvertToAssFile, 4, 0);
            this.tableLayoutPanelOperations.Controls.Add(this.textBox_vttResult, 3, 0);
            this.tableLayoutPanelOperations.Controls.Add(this.buttonLoadWords, 2, 0);
            this.tableLayoutPanelOperations.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelOperations.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanelOperations.Name = "tableLayoutPanelOperations";
            this.tableLayoutPanelOperations.RowCount = 1;
            this.tableLayoutPanelOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelOperations.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 179F));
            this.tableLayoutPanelOperations.Size = new System.Drawing.Size(1372, 179);
            this.tableLayoutPanelOperations.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2030, 1382);
            this.Controls.Add(this.tableLayoutPanelAll);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "YouTubeTimeLineGenerator v0.0.3.5 by Sofronio";
            this.groupBoxSourceFileType.ResumeLayout(false);
            this.tableLayoutPanelSourceFileType.ResumeLayout(false);
            this.tableLayoutPanelSourceFileType.PerformLayout();
            this.tableLayoutPanelAll.ResumeLayout(false);
            this.tableLayoutPanelAll.PerformLayout();
            this.tableLayoutPanelSubtitleWordsStyling.ResumeLayout(false);
            this.tableLayoutPanelOperationsAndInstructions.ResumeLayout(false);
            this.tableLayoutPanelOperations.ResumeLayout(false);
            this.tableLayoutPanelOperations.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonProcessSourceFile;
        private System.Windows.Forms.TextBox textBoxSourceFileContent;
        //private FlickerFreeListBox listBox1;
        private System.Windows.Forms.Button buttonConvertToAssFile;
        private System.Windows.Forms.TextBox textBox_vttResult;
        private System.Windows.Forms.RichTextBox richTextBoxAssResult;
        //private FlickerFreeListBox listBox2;
        private System.Windows.Forms.RadioButton radioButtonSourceFileTypeVtt;
        private System.Windows.Forms.GroupBox groupBoxSourceFileType;
        private System.Windows.Forms.RadioButton radioButtonSourceFileTypeXml;
        private System.Windows.Forms.RichTextBox richTextBoxSubtitleWords;
        //private ExRichTextBox richTextBox2;
        private System.Windows.Forms.Button buttonLoadWords;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.Button buttonIncreaseFontSize;
        private System.Windows.Forms.Button buttonDecreaseFontSize;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelAll;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSubtitleWordsStyling;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOperationsAndInstructions;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelOperations;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanelSourceFileType;
    }
}
