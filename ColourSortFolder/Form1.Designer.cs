namespace ColourSortFolder {
    partial class MainForm {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            sortButton = new Button();
            folderPathTextBox = new TextBox();
            folderSelectButton = new Button();
            SuspendLayout();
            // 
            // sortButton
            // 
            sortButton.Location = new Point(365, 67);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(124, 37);
            sortButton.TabIndex = 1;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Location = new Point(12, 12);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(477, 27);
            folderPathTextBox.TabIndex = 2;
            // 
            // folderSelectButton
            // 
            folderSelectButton.Location = new Point(235, 67);
            folderSelectButton.Name = "folderSelectButton";
            folderSelectButton.Size = new Size(124, 37);
            folderSelectButton.TabIndex = 3;
            folderSelectButton.Text = "Select Folder";
            folderSelectButton.UseVisualStyleBackColor = true;
            folderSelectButton.Click += folderSelectButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(501, 116);
            Controls.Add(folderSelectButton);
            Controls.Add(folderPathTextBox);
            Controls.Add(sortButton);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Colour Sort";
            Load += MainForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button sortButton;
        private TextBox folderPathTextBox;
        private Button folderSelectButton;
    }
}
