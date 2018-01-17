namespace test
{
    partial class UnoGameMainWindowDialog
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
            this.tbpMain = new System.Windows.Forms.TableLayoutPanel();
            this.btExit = new System.Windows.Forms.Button();
            this.btNewLocalGame = new System.Windows.Forms.Button();
            this.btNewNetGame = new System.Windows.Forms.Button();
            this.btStatistics = new System.Windows.Forms.Button();
            this.tbpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpMain.BackgroundImage = global::test.Properties.Resources.MainWindowBackground01;
            this.tbpMain.ColumnCount = 1;
            this.tbpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpMain.Controls.Add(this.btExit, 0, 3);
            this.tbpMain.Controls.Add(this.btNewLocalGame, 0, 0);
            this.tbpMain.Controls.Add(this.btNewNetGame, 0, 1);
            this.tbpMain.Controls.Add(this.btStatistics, 0, 2);
            this.tbpMain.Location = new System.Drawing.Point(13, 13);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.RowCount = 4;
            this.tbpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tbpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbpMain.Size = new System.Drawing.Size(345, 266);
            this.tbpMain.TabIndex = 0;
            // 
            // btExit
            // 
            this.btExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btExit.Image = global::test.Properties.Resources.btExit;
            this.btExit.Location = new System.Drawing.Point(3, 202);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(339, 60);
            this.btExit.TabIndex = 3;
            this.btExit.UseVisualStyleBackColor = true;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // btNewLocalGame
            // 
            this.btNewLocalGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNewLocalGame.Image = global::test.Properties.Resources.btNewLocalGame;
            this.btNewLocalGame.Location = new System.Drawing.Point(3, 3);
            this.btNewLocalGame.Name = "btNewLocalGame";
            this.btNewLocalGame.Size = new System.Drawing.Size(339, 60);
            this.btNewLocalGame.TabIndex = 0;
            this.btNewLocalGame.UseVisualStyleBackColor = true;
            this.btNewLocalGame.Click += new System.EventHandler(this.btNewLocalGame_Click);
            // 
            // btNewNetGame
            // 
            this.btNewNetGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btNewNetGame.Image = global::test.Properties.Resources.btNewGameWithFriends;
            this.btNewNetGame.Location = new System.Drawing.Point(3, 69);
            this.btNewNetGame.Name = "btNewNetGame";
            this.btNewNetGame.Size = new System.Drawing.Size(339, 60);
            this.btNewNetGame.TabIndex = 1;
            this.btNewNetGame.UseVisualStyleBackColor = true;
            this.btNewNetGame.Click += new System.EventHandler(this.btNewNetGame_Click);
            // 
            // btStatistics
            // 
            this.btStatistics.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btStatistics.Image = global::test.Properties.Resources.btStatistics;
            this.btStatistics.Location = new System.Drawing.Point(3, 135);
            this.btStatistics.Name = "btStatistics";
            this.btStatistics.Size = new System.Drawing.Size(339, 60);
            this.btStatistics.TabIndex = 2;
            this.btStatistics.UseVisualStyleBackColor = true;
            this.btStatistics.Click += new System.EventHandler(this.btStatistics_Click);
            // 
            // UnoGameMainWindowDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.MainWindowBackground01;
            this.ClientSize = new System.Drawing.Size(370, 291);
            this.Controls.Add(this.tbpMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "UnoGameMainWindowDialog";
            this.Text = "UnoGameMainWindowDialog";
            this.tbpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpMain;
        private System.Windows.Forms.Button btNewLocalGame;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button btNewNetGame;
        private System.Windows.Forms.Button btStatistics;
    }
}