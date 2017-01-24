namespace Factorio_Image_Converter
{
    partial class Imageconverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imageconverter));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListUnmatched = new System.Windows.Forms.CheckBox();
            this.Select = new System.Windows.Forms.Button();
            this.SaveScript = new System.Windows.Forms.Button();
            this.DefaultTiles = new System.Windows.Forms.TextBox();
            this.scriptpart2 = new System.Windows.Forms.TextBox();
            this.scriptpart1 = new System.Windows.Forms.TextBox();
            this.Progress = new System.Windows.Forms.ProgressBar();
            this.FilePath = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Code = new Factorio_Image_Converter.RichEdit50();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListUnmatched);
            this.panel1.Controls.Add(this.Select);
            this.panel1.Controls.Add(this.SaveScript);
            this.panel1.Controls.Add(this.DefaultTiles);
            this.panel1.Controls.Add(this.scriptpart2);
            this.panel1.Controls.Add(this.scriptpart1);
            this.panel1.Controls.Add(this.Progress);
            this.panel1.Controls.Add(this.FilePath);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(684, 59);
            this.panel1.TabIndex = 0;
            // 
            // ListUnmatched
            // 
            this.ListUnmatched.AutoSize = true;
            this.ListUnmatched.Location = new System.Drawing.Point(5, 20);
            this.ListUnmatched.Name = "ListUnmatched";
            this.ListUnmatched.Size = new System.Drawing.Size(125, 17);
            this.ListUnmatched.TabIndex = 1;
            this.ListUnmatched.Text = "List Unmatched Tiles";
            this.ListUnmatched.UseVisualStyleBackColor = true;
            // 
            // Select
            // 
            this.Select.Location = new System.Drawing.Point(129, 16);
            this.Select.Name = "Select";
            this.Select.Size = new System.Drawing.Size(141, 23);
            this.Select.TabIndex = 2;
            this.Select.Text = "Open and Process Image";
            this.Select.UseVisualStyleBackColor = true;
            this.Select.Click += new System.EventHandler(this.Select_Click);
            // 
            // SaveScript
            // 
            this.SaveScript.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveScript.Location = new System.Drawing.Point(606, 16);
            this.SaveScript.Name = "SaveScript";
            this.SaveScript.Size = new System.Drawing.Size(75, 23);
            this.SaveScript.TabIndex = 3;
            this.SaveScript.Text = "Save Script";
            this.SaveScript.UseVisualStyleBackColor = true;
            this.SaveScript.Click += new System.EventHandler(this.SaveScript_Click);
            // 
            // DefaultTiles
            // 
            this.DefaultTiles.Location = new System.Drawing.Point(214, 40);
            this.DefaultTiles.Multiline = true;
            this.DefaultTiles.Name = "DefaultTiles";
            this.DefaultTiles.Size = new System.Drawing.Size(100, 20);
            this.DefaultTiles.TabIndex = 7;
            this.DefaultTiles.TabStop = false;
            this.DefaultTiles.Text = resources.GetString("DefaultTiles.Text");
            this.DefaultTiles.Visible = false;
            // 
            // scriptpart2
            // 
            this.scriptpart2.Location = new System.Drawing.Point(108, 40);
            this.scriptpart2.Multiline = true;
            this.scriptpart2.Name = "scriptpart2";
            this.scriptpart2.Size = new System.Drawing.Size(100, 20);
            this.scriptpart2.TabIndex = 6;
            this.scriptpart2.TabStop = false;
            this.scriptpart2.Text = "game.player.surface.set_tiles(tiles);\r\n";
            this.scriptpart2.Visible = false;
            // 
            // scriptpart1
            // 
            this.scriptpart1.Location = new System.Drawing.Point(2, 40);
            this.scriptpart1.Multiline = true;
            this.scriptpart1.Name = "scriptpart1";
            this.scriptpart1.Size = new System.Drawing.Size(100, 20);
            this.scriptpart1.TabIndex = 5;
            this.scriptpart1.TabStop = false;
            this.scriptpart1.Text = "/silent-command\r\ntiles = {};\r\nposx = game.player.position.x;\r\nposy = game.player." +
    "position.y;";
            this.scriptpart1.Visible = false;
            // 
            // Progress
            // 
            this.Progress.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Progress.Location = new System.Drawing.Point(0, 39);
            this.Progress.Name = "Progress";
            this.Progress.Size = new System.Drawing.Size(684, 20);
            this.Progress.TabIndex = 3;
            this.Progress.Value = 100;
            // 
            // FilePath
            // 
            this.FilePath.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FilePath.Dock = System.Windows.Forms.DockStyle.Top;
            this.FilePath.Location = new System.Drawing.Point(0, 0);
            this.FilePath.Name = "FilePath";
            this.FilePath.ReadOnly = true;
            this.FilePath.Size = new System.Drawing.Size(684, 13);
            this.FilePath.TabIndex = 0;
            this.FilePath.TabStop = false;
            this.FilePath.WordWrap = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Code);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(684, 402);
            this.panel2.TabIndex = 1;
            // 
            // Code
            // 
            this.Code.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Code.DetectUrls = false;
            this.Code.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Code.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Code.Location = new System.Drawing.Point(0, 0);
            this.Code.Name = "Code";
            this.Code.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedBoth;
            this.Code.Size = new System.Drawing.Size(684, 402);
            this.Code.TabIndex = 0;
            this.Code.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Image Files|*.bmp; *.gif; *.png;";
            this.openFileDialog1.InitialDirectory = "C:\\";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text File|*.txt";
            this.saveFileDialog1.Title = "Save LUA Script";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Imageconverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 500);
            this.Name = "Imageconverter";
            this.Text = "Factorio Image Converter";
            this.Load += new System.EventHandler(this.Imageconverter_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Select;
        private System.Windows.Forms.TextBox FilePath;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ProgressBar Progress;
        private System.Windows.Forms.Button SaveScript;
        private System.Windows.Forms.TextBox scriptpart2;
        private System.Windows.Forms.TextBox scriptpart1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.TextBox DefaultTiles;
        private System.Windows.Forms.CheckBox ListUnmatched;
        private RichEdit50 Code;

    }
}

