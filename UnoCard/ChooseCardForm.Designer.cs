namespace UnoProject
{
    partial class ChooseCardForm
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
            this.playerPanel = new System.Windows.Forms.Panel();
            this.btPass = new System.Windows.Forms.Button();
            this.tbpMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbpMain
            // 
            this.tbpMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbpMain.BackgroundImage = global::UnoCard.Properties.Resources.MainWindowBackground01;
            this.tbpMain.ColumnCount = 2;
            this.tbpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tbpMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tbpMain.Controls.Add(this.playerPanel, 0, 0);
            this.tbpMain.Controls.Add(this.btPass, 1, 0);
            this.tbpMain.Location = new System.Drawing.Point(0, 0);
            this.tbpMain.Name = "tbpMain";
            this.tbpMain.RowCount = 1;
            this.tbpMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbpMain.Size = new System.Drawing.Size(714, 111);
            this.tbpMain.TabIndex = 1;
            // 
            // playerPanel
            // 
            this.playerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playerPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this.playerPanel.BackgroundImage = global::UnoCard.Properties.Resources.PanelBackground01;
            this.playerPanel.Location = new System.Drawing.Point(3, 3);
            this.playerPanel.Name = "playerPanel";
            this.playerPanel.Size = new System.Drawing.Size(565, 105);
            this.playerPanel.TabIndex = 0;
            // 
            // btPass
            // 
            this.btPass.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btPass.Image = global::UnoCard.Properties.Resources.btPass;
            this.btPass.Location = new System.Drawing.Point(588, 31);
            this.btPass.Name = "btPass";
            this.btPass.Size = new System.Drawing.Size(108, 48);
            this.btPass.TabIndex = 1;
            this.btPass.UseVisualStyleBackColor = true;
            this.btPass.Click += new System.EventHandler(this.btPass_Click);
            // 
            // ChooseCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 111);
            this.Controls.Add(this.tbpMain);
            this.Name = "ChooseCardForm";
            this.Text = "ChooseCardForm";
            this.tbpMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbpMain;
        private System.Windows.Forms.Panel playerPanel;
        private System.Windows.Forms.Button btPass;

    }
}