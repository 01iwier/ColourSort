namespace ColourSortFolder {
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    public partial class MainForm : Form {
        private string selectedFolderPath;

        public MainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
        }

        private void sortButton_Click(object sender, EventArgs e) {
            if (string.IsNullOrEmpty(selectedFolderPath) || !Directory.Exists(selectedFolderPath)) {
                MessageBox.Show("Please select a valid folder.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadingLabel.Text = "Processing...";
            loadingLabel.Visible = true;
            loadingLabel.Refresh(); // Force the label to update its display

            var imageFiles = Directory.GetFiles(selectedFolderPath, "*.*")
                                       .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                   f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase));

            foreach (var file in imageFiles) {
                var colorGroup = GetMostProminentColorCategory(file);
                RenameImageFile(file, colorGroup);
            }

            loadingLabel.Visible = false;
            MessageBox.Show("Images have been sorted.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void folderSelectButton_Click(object sender, EventArgs e) {
            using (var folderBrowser = new FolderBrowserDialog()) {
                if (folderBrowser.ShowDialog() == DialogResult.OK) {
                    selectedFolderPath = folderBrowser.SelectedPath;
                    folderPathTextBox.Text = selectedFolderPath;
                }
            }
        }

        private void RenameImageFile(string filePath, int colorGroup) {
            string directory = Path.GetDirectoryName(filePath);
            string originalName = Path.GetFileNameWithoutExtension(filePath);
            string extension = Path.GetExtension(filePath);

            string newName = $"{colorGroup:D2}_{originalName}{extension}";
            string newFilePath = Path.Combine(directory, newName);

            File.Move(filePath, newFilePath);
        }

        private int GetMostProminentColorCategory(string imagePath) {
            using (Bitmap bitmap = new Bitmap(imagePath)) {
                Bitmap resized = new Bitmap(bitmap, new Size(300, 300));  // Resize image to speed up processing
                var colorCounts = CountColorCategories(resized);
                return GetMostFrequentCategory(colorCounts);
            }
        }

        private Dictionary<int, int> CountColorCategories(Bitmap bitmap) {
            var colorCounts = new Dictionary<int, int>();
            for (int y = 0; y < bitmap.Height; y++) {
                for (int x = 0; x < bitmap.Width; x++) {
                    Color pixelColor = bitmap.GetPixel(x, y);
                    int category = ClassifyColor(pixelColor);
                    if (colorCounts.ContainsKey(category)) {
                        colorCounts[category]++;
                    } else {
                        colorCounts[category] = 1;
                    }
                }
            }

            return colorCounts;
        }

        private int GetMostFrequentCategory(Dictionary<int, int> colorCounts) {
            return colorCounts.OrderByDescending(c => c.Value).FirstOrDefault().Key;
        }

        private int ClassifyColor(Color color) {
            float hue = color.GetHue();
            float brightness = color.GetBrightness();
            float saturation = color.GetSaturation();

            if (brightness < 0.01) {
                return 1;  // Black
            } else if (saturation < 0.1) {
                if (brightness > 0.2) {
                    return 3;  // White
                } else {
                    return 2;  // Gray
                }
            } else {
                // Use hue to classify the color
                if (hue >= 0 && hue < 30) {
                    return 4;  // Red
                } else if (hue >= 30 && hue < 60) {
                    return 5;  // Orange
                } else if (hue >= 60 && hue < 120) {
                    return 6;  // Yellow
                } else if (hue >= 120 && hue < 180) {
                    return 7;  // Green
                } else if (hue >= 180 && hue < 240) {
                    return 8;  // Cyan
                } else if (hue >= 240 && hue < 270) {
                    return 9;  // Blue
                } else {
                    return 10; // Purple
                }
            }
        }
    }

    public static class BitmapExtensions {
        public static IEnumerable<Color> Pixels(this Bitmap bitmap) {
            for (int y = 0; y < bitmap.Height; y++) {
                for (int x = 0; x < bitmap.Width; x++) {
                    yield return bitmap.GetPixel(x, y);
                }
            }
        }
    }
}