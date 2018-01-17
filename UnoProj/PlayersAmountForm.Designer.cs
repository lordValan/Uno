namespace test
{
    partial class PlayersAmountForm
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
            this.tbp = new System.Windows.Forms.TableLayoutPanel();
            this.mainNUD = new System.Windows.Forms.NumericUpDown();
            this.btNext = new System.Windows.Forms.Button();
            this.tbp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mainNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // tbp
            // 
            this.tbp.BackgroundImage = global::test.Properties.Resources.MainWindowBackground01;
            this.tbp.ColumnCount = 2;
            this.tbp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tbp.Controls.Add(this.mainNUD, 0, 0);
            this.tbp.Controls.Add(this.btNext, 1, 0);
            this.tbp.Location = new System.Drawing.Point(13, 13);
            this.tbp.Name = "tbp";
            this.tbp.RowCount = 1;
            this.tbp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbp.Size = new System.Drawing.Size(295, 62);
            this.tbp.TabIndex = 0;
            // 
            // mainNUD
            // 
            this.mainNUD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainNUD.Font = new System.Drawing.Font("Modern No. 20", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainNUD.Location = new System.Drawing.Point(3, 3);
            this.mainNUD.Maximum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.mainNUD.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.mainNUD.Name = "mainNUD";
            this.mainNUD.Size = new System.Drawing.Size(235, 59);
            this.mainNUD.TabIndex = 0;
            this.mainNUD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.mainNUD.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btNext
            // 
            this.btNext.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btNext.BackgroundImage = global::test.Properties.Resources.btNext;
            this.btNext.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btNext.Location = new System.Drawing.Point(244, 3);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(48, 56);
            this.btNext.TabIndex = 1;
            this.btNext.UseVisualStyleBackColor = true;
            // 
            // PlayersAmountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::test.Properties.Resources.MainWindowBackground01;
            this.ClientSize = new System.Drawing.Size(320, 87);
            this.Controls.Add(this.tbp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "PlayersAmountForm";
            this.Text = "PlayersAmountForm";
            this.tbp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainNUD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tbp;
        public System.Windows.Forms.NumericUpDown mainNUD;
        private System.Windows.Forms.Button btNext;
    }
}