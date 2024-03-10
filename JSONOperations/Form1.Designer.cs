namespace JSONOperations
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            fileDialogForJSON = new OpenFileDialog();
            txtJSONFilePath = new TextBox();
            btnBrowse = new Button();
            rtxtData = new RichTextBox();
            btnProcess = new Button();
            SuspendLayout();
            // 
            // fileDialogForJSON
            // 
            fileDialogForJSON.FileName = "fileDialogForJSON";
            // 
            // txtJSONFilePath
            // 
            txtJSONFilePath.Location = new Point(12, 12);
            txtJSONFilePath.Name = "txtJSONFilePath";
            txtJSONFilePath.Size = new Size(520, 27);
            txtJSONFilePath.TabIndex = 0;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(593, 10);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(231, 29);
            btnBrowse.TabIndex = 1;
            btnBrowse.Text = "Browse";
            btnBrowse.UseMnemonic = false;
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // rtxtData
            // 
            rtxtData.Location = new Point(12, 124);
            rtxtData.Name = "rtxtData";
            rtxtData.Size = new Size(1251, 495);
            rtxtData.TabIndex = 2;
            rtxtData.Text = "";
            // 
            // btnProcess
            // 
            btnProcess.Location = new Point(449, 67);
            btnProcess.Name = "btnProcess";
            btnProcess.Size = new Size(309, 44);
            btnProcess.TabIndex = 3;
            btnProcess.Text = "Process and make comma seperated";
            btnProcess.UseVisualStyleBackColor = true;
            btnProcess.Click += btnProcess_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1275, 674);
            Controls.Add(btnProcess);
            Controls.Add(rtxtData);
            Controls.Add(btnBrowse);
            Controls.Add(txtJSONFilePath);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Json Comma Seperation";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog fileDialogForJSON;
        private TextBox txtJSONFilePath;
        private Button btnBrowse;
        private RichTextBox rtxtData;
        private Button btnProcess;
    }
}
