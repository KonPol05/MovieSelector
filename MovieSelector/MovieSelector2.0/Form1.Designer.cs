namespace MovieSelector2._0
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AddMoviesToWatchedFolder = new System.Windows.Forms.Button();
            this.AddMoviesToNotWatchedFolder = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.MovieRandomizer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // AddMoviesToWatchedFolder
            // 
            this.AddMoviesToWatchedFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddMoviesToWatchedFolder.BackColor = System.Drawing.Color.Silver;
            this.AddMoviesToWatchedFolder.BackgroundImage = global::MovieSelector2._0.Properties.Resources.ButtonBackground;
            this.AddMoviesToWatchedFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddMoviesToWatchedFolder.Location = new System.Drawing.Point(381, 130);
            this.AddMoviesToWatchedFolder.Margin = new System.Windows.Forms.Padding(4);
            this.AddMoviesToWatchedFolder.Name = "AddMoviesToWatchedFolder";
            this.AddMoviesToWatchedFolder.Size = new System.Drawing.Size(237, 145);
            this.AddMoviesToWatchedFolder.TabIndex = 1;
            this.AddMoviesToWatchedFolder.Text = "ADD MOVIES YOU HAVE WATCHED";
            this.AddMoviesToWatchedFolder.UseVisualStyleBackColor = false;
            this.AddMoviesToWatchedFolder.Click += new System.EventHandler(this.AddMoviesToWatchedFolder_Click);
            // 
            // AddMoviesToNotWatchedFolder
            // 
            this.AddMoviesToNotWatchedFolder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AddMoviesToNotWatchedFolder.BackColor = System.Drawing.Color.Silver;
            this.AddMoviesToNotWatchedFolder.BackgroundImage = global::MovieSelector2._0.Properties.Resources.ButtonBackground;
            this.AddMoviesToNotWatchedFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AddMoviesToNotWatchedFolder.Location = new System.Drawing.Point(48, 132);
            this.AddMoviesToNotWatchedFolder.Margin = new System.Windows.Forms.Padding(4);
            this.AddMoviesToNotWatchedFolder.Name = "AddMoviesToNotWatchedFolder";
            this.AddMoviesToNotWatchedFolder.Size = new System.Drawing.Size(237, 140);
            this.AddMoviesToNotWatchedFolder.TabIndex = 0;
            this.AddMoviesToNotWatchedFolder.Text = "ADD MOVIES YOU HAVEN\'T WATCHED";
            this.AddMoviesToNotWatchedFolder.UseVisualStyleBackColor = false;
            this.AddMoviesToNotWatchedFolder.Click += new System.EventHandler(this.AddMoviesToNotWatchedFolder_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AllowDrop = true;
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackgroundImage = global::MovieSelector2._0.Properties.Resources.Background;
            this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.AddMoviesToNotWatchedFolder, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddMoviesToWatchedFolder, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MovieRandomizer, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.ForeColor = System.Drawing.Color.Black;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1000, 405);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // MovieRandomizer
            // 
            this.MovieRandomizer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MovieRandomizer.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.MovieRandomizer.BackColor = System.Drawing.Color.Silver;
            this.MovieRandomizer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MovieRandomizer.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.MovieRandomizer.Location = new System.Drawing.Point(714, 132);
            this.MovieRandomizer.Margin = new System.Windows.Forms.Padding(4);
            this.MovieRandomizer.Name = "MovieRandomizer";
            this.MovieRandomizer.Size = new System.Drawing.Size(237, 140);
            this.MovieRandomizer.TabIndex = 2;
            this.MovieRandomizer.Text = "PLAY RANDOM MOVIE";
            this.MovieRandomizer.UseVisualStyleBackColor = false;
            this.MovieRandomizer.Click += new System.EventHandler(this.MovieRandomizer_Click);
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1000, 405);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MovieSelector";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button AddMoviesToWatchedFolder;
        private System.Windows.Forms.Button AddMoviesToNotWatchedFolder;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button MovieRandomizer;
    }
}

