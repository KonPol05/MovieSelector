namespace MovieSelector2._0
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.CreateShortCut = new System.Windows.Forms.Button();
            this.CloseForm = new System.Windows.Forms.Button();
            this.ShowMessage = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateShortCut
            // 
            this.CreateShortCut.Location = new System.Drawing.Point(548, 135);
            this.CreateShortCut.Name = "CreateShortCut";
            this.CreateShortCut.Size = new System.Drawing.Size(75, 23);
            this.CreateShortCut.TabIndex = 0;
            this.CreateShortCut.Text = "Yes";
            this.CreateShortCut.UseVisualStyleBackColor = true;
            this.CreateShortCut.Click += new System.EventHandler(this.CreateShortCut_Click);
            // 
            // CloseForm
            // 
            this.CloseForm.Location = new System.Drawing.Point(645, 135);
            this.CloseForm.Name = "CloseForm";
            this.CloseForm.Size = new System.Drawing.Size(75, 23);
            this.CloseForm.TabIndex = 1;
            this.CloseForm.Text = "No";
            this.CloseForm.UseVisualStyleBackColor = true;
            this.CloseForm.Click += new System.EventHandler(this.CloseForm_Click);
            // 
            // ShowMessage
            // 
            this.ShowMessage.AutoSize = true;
            this.ShowMessage.Location = new System.Drawing.Point(12, 138);
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(223, 20);
            this.ShowMessage.TabIndex = 2;
            this.ShowMessage.Text = "Don\'t Show This Message Again";
            this.ShowMessage.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Would you like to create a shortcut?";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 176);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ShowMessage);
            this.Controls.Add(this.CloseForm);
            this.Controls.Add(this.CreateShortCut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.Text = "ShortcutCreation";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateShortCut;
        private System.Windows.Forms.Button CloseForm;
        private System.Windows.Forms.CheckBox ShowMessage;
        private System.Windows.Forms.Label label1;
    }
}