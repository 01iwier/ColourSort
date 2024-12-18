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
            loadingLabel = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // sortButton
            // 
            sortButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            sortButton.Location = new Point(418, 114);
            sortButton.Name = "sortButton";
            sortButton.Size = new Size(106, 38);
            sortButton.TabIndex = 1;
            sortButton.Text = "Sort";
            sortButton.UseVisualStyleBackColor = true;
            sortButton.Click += sortButton_Click;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderPathTextBox.Location = new Point(12, 40);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.ReadOnly = true;
            folderPathTextBox.Size = new Size(472, 30);
            folderPathTextBox.TabIndex = 2;
            // 
            // folderSelectButton
            // 
            folderSelectButton.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            folderSelectButton.Location = new Point(490, 40);
            folderSelectButton.Name = "folderSelectButton";
            folderSelectButton.Size = new Size(34, 34);
            folderSelectButton.TabIndex = 3;
            folderSelectButton.Text = "...";
            folderSelectButton.UseVisualStyleBackColor = true;
            folderSelectButton.Click += folderSelectButton_Click;
            // 
            // loadingLabel
            // 
            loadingLabel.AutoSize = true;
            loadingLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            loadingLabel.Location = new Point(12, 77);
            loadingLabel.Name = "loadingLabel";
            loadingLabel.Size = new Size(115, 28);
            loadingLabel.TabIndex = 4;
            loadingLabel.Text = "Loading . . . ";
            loadingLabel.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(111, 28);
            label1.TabIndex = 5;
            label1.Text = "Folder Path";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(536, 164);
            Controls.Add(label1);
            Controls.Add(loadingLabel);
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
        private Label loadingLabel;
        private Label label1;
    }
}
