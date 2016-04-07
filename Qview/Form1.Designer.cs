namespace Qview
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.pBox = new System.Windows.Forms.PictureBox();
            this.pLabel = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ファイルToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開くOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fileMenu_FileNameBox = new System.Windows.Forms.ToolStripTextBox();
            this.終了CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.変換CToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.色を反転ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ｒＧＢを抽出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ｒToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ｇToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ｂToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.グレースケール化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.二値化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convMenu_BinBox = new System.Windows.Forms.ToolStripTextBox();
            this.セピアToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.階調処理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convMenuPostalBox = new System.Windows.Forms.ToolStripTextBox();
            this.フィルタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ラプラシアンフィルタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ラプラシアン４ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ラプラシアン８ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTT = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTR = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTB = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTL = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTRT = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTRB = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTLB = new System.Windows.Forms.ToolStripMenuItem();
            this.filterItemSobelTLT = new System.Windows.Forms.ToolStripMenuItem();
            this.平均化ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重みなしToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重み２ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ガウシアンフィルタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メディアンフィルタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.平均移動フィルタToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.setOrgBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pBox
            // 
            this.pBox.Location = new System.Drawing.Point(22, 58);
            this.pBox.Name = "pBox";
            this.pBox.Size = new System.Drawing.Size(576, 454);
            this.pBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pBox.TabIndex = 0;
            this.pBox.TabStop = false;
            // 
            // pLabel
            // 
            this.pLabel.Location = new System.Drawing.Point(22, 518);
            this.pLabel.Name = "pLabel";
            this.pLabel.Size = new System.Drawing.Size(576, 19);
            this.pLabel.TabIndex = 1;
            this.pLabel.Text = "Picture Name";
            this.pLabel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ファイルToolStripMenuItem,
            this.変換CToolStripMenuItem,
            this.フィルタToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(610, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ファイルToolStripMenuItem
            // 
            this.ファイルToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.開くOToolStripMenuItem,
            this.toolStripMenuItem1,
            this.終了CToolStripMenuItem});
            this.ファイルToolStripMenuItem.Name = "ファイルToolStripMenuItem";
            this.ファイルToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.ファイルToolStripMenuItem.Text = "ファイル(&F)";
            // 
            // 開くOToolStripMenuItem
            // 
            this.開くOToolStripMenuItem.Name = "開くOToolStripMenuItem";
            this.開くOToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.開くOToolStripMenuItem.Text = "開く";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu_FileNameBox});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(184, 24);
            this.toolStripMenuItem1.Text = "名前をつけて保存";
            // 
            // fileMenu_FileNameBox
            // 
            this.fileMenu_FileNameBox.Name = "fileMenu_FileNameBox";
            this.fileMenu_FileNameBox.Size = new System.Drawing.Size(100, 27);
            this.fileMenu_FileNameBox.Text = "ファイル名を入力";
            this.fileMenu_FileNameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fileMenu_FileNameBox_KeyDown);
            this.fileMenu_FileNameBox.Click += new System.EventHandler(this.fileMenu_FileNameBox_Click);
            // 
            // 終了CToolStripMenuItem
            // 
            this.終了CToolStripMenuItem.Name = "終了CToolStripMenuItem";
            this.終了CToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.終了CToolStripMenuItem.Text = "終了";
            this.終了CToolStripMenuItem.Click += new System.EventHandler(this.FileMenu_CloseClick);
            // 
            // 変換CToolStripMenuItem
            // 
            this.変換CToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.色を反転ToolStripMenuItem,
            this.ｒＧＢを抽出ToolStripMenuItem,
            this.グレースケール化ToolStripMenuItem,
            this.二値化ToolStripMenuItem,
            this.セピアToolStripMenuItem,
            this.階調処理ToolStripMenuItem});
            this.変換CToolStripMenuItem.Name = "変換CToolStripMenuItem";
            this.変換CToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.変換CToolStripMenuItem.Text = "変換(&C)";
            // 
            // 色を反転ToolStripMenuItem
            // 
            this.色を反転ToolStripMenuItem.Name = "色を反転ToolStripMenuItem";
            this.色を反転ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.色を反転ToolStripMenuItem.Text = "色を反転";
            this.色を反転ToolStripMenuItem.Click += new System.EventHandler(this.ConvMenu_InverseClick);
            // 
            // ｒＧＢを抽出ToolStripMenuItem
            // 
            this.ｒＧＢを抽出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ｒToolStripMenuItem,
            this.ｇToolStripMenuItem,
            this.ｂToolStripMenuItem});
            this.ｒＧＢを抽出ToolStripMenuItem.Name = "ｒＧＢを抽出ToolStripMenuItem";
            this.ｒＧＢを抽出ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.ｒＧＢを抽出ToolStripMenuItem.Text = "ＲＧＢ";
            // 
            // ｒToolStripMenuItem
            // 
            this.ｒToolStripMenuItem.Name = "ｒToolStripMenuItem";
            this.ｒToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ｒToolStripMenuItem.Tag = "1";
            this.ｒToolStripMenuItem.Text = "Ｒ";
            this.ｒToolStripMenuItem.Click += new System.EventHandler(this.ConvMenu_RGBClick);
            // 
            // ｇToolStripMenuItem
            // 
            this.ｇToolStripMenuItem.Name = "ｇToolStripMenuItem";
            this.ｇToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ｇToolStripMenuItem.Tag = "2";
            this.ｇToolStripMenuItem.Text = "Ｇ";
            this.ｇToolStripMenuItem.Click += new System.EventHandler(this.ConvMenu_RGBClick);
            // 
            // ｂToolStripMenuItem
            // 
            this.ｂToolStripMenuItem.Name = "ｂToolStripMenuItem";
            this.ｂToolStripMenuItem.Size = new System.Drawing.Size(93, 24);
            this.ｂToolStripMenuItem.Tag = "3";
            this.ｂToolStripMenuItem.Text = "Ｂ";
            this.ｂToolStripMenuItem.Click += new System.EventHandler(this.ConvMenu_RGBClick);
            // 
            // グレースケール化ToolStripMenuItem
            // 
            this.グレースケール化ToolStripMenuItem.Name = "グレースケール化ToolStripMenuItem";
            this.グレースケール化ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.グレースケール化ToolStripMenuItem.Text = "グレースケール";
            this.グレースケール化ToolStripMenuItem.Click += new System.EventHandler(this.ConvMenu_GrayClick);
            // 
            // 二値化ToolStripMenuItem
            // 
            this.二値化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convMenu_BinBox});
            this.二値化ToolStripMenuItem.Name = "二値化ToolStripMenuItem";
            this.二値化ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.二値化ToolStripMenuItem.Text = "二値化";
            // 
            // convMenu_BinBox
            // 
            this.convMenu_BinBox.Name = "convMenu_BinBox";
            this.convMenu_BinBox.Size = new System.Drawing.Size(100, 27);
            this.convMenu_BinBox.Text = "閾値を入力";
            this.convMenu_BinBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.convMenu_BinBox_KeyDown);
            this.convMenu_BinBox.Click += new System.EventHandler(this.convMenu_BinBox_Click);
            // 
            // セピアToolStripMenuItem
            // 
            this.セピアToolStripMenuItem.Name = "セピアToolStripMenuItem";
            this.セピアToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.セピアToolStripMenuItem.Text = "セピア";
            this.セピアToolStripMenuItem.Click += new System.EventHandler(this.ConvMenu_SepiaClick);
            // 
            // 階調処理ToolStripMenuItem
            // 
            this.階調処理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.convMenuPostalBox});
            this.階調処理ToolStripMenuItem.Name = "階調処理ToolStripMenuItem";
            this.階調処理ToolStripMenuItem.Size = new System.Drawing.Size(177, 24);
            this.階調処理ToolStripMenuItem.Text = "ポスタリゼーション";
            // 
            // convMenuPostalBox
            // 
            this.convMenuPostalBox.AccessibleDescription = "階調数を入力";
            this.convMenuPostalBox.Name = "convMenuPostalBox";
            this.convMenuPostalBox.Size = new System.Drawing.Size(100, 27);
            this.convMenuPostalBox.Text = "レベルを入力";
            this.convMenuPostalBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.convMenuPostalBox_KeyDown);
            this.convMenuPostalBox.Click += new System.EventHandler(this.convMenuPostalBox_Click);
            // 
            // フィルタToolStripMenuItem
            // 
            this.フィルタToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ラプラシアンフィルタToolStripMenuItem,
            this.toolStripMenuItem2,
            this.平均化ToolStripMenuItem,
            this.ガウシアンフィルタToolStripMenuItem,
            this.メディアンフィルタToolStripMenuItem,
            this.平均移動フィルタToolStripMenuItem});
            this.フィルタToolStripMenuItem.Name = "フィルタToolStripMenuItem";
            this.フィルタToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.フィルタToolStripMenuItem.Text = "フィルタ(&O)";
            // 
            // ラプラシアンフィルタToolStripMenuItem
            // 
            this.ラプラシアンフィルタToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ラプラシアン４ToolStripMenuItem,
            this.ラプラシアン８ToolStripMenuItem});
            this.ラプラシアンフィルタToolStripMenuItem.Name = "ラプラシアンフィルタToolStripMenuItem";
            this.ラプラシアンフィルタToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.ラプラシアンフィルタToolStripMenuItem.Text = "ラプラシアンフィルタ";
            // 
            // ラプラシアン４ToolStripMenuItem
            // 
            this.ラプラシアン４ToolStripMenuItem.Name = "ラプラシアン４ToolStripMenuItem";
            this.ラプラシアン４ToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.ラプラシアン４ToolStripMenuItem.Tag = " 4";
            this.ラプラシアン４ToolStripMenuItem.Text = "ラプラシアン４";
            this.ラプラシアン４ToolStripMenuItem.Click += new System.EventHandler(this.FilterMenu_LapClick);
            // 
            // ラプラシアン８ToolStripMenuItem
            // 
            this.ラプラシアン８ToolStripMenuItem.Name = "ラプラシアン８ToolStripMenuItem";
            this.ラプラシアン８ToolStripMenuItem.Size = new System.Drawing.Size(159, 24);
            this.ラプラシアン８ToolStripMenuItem.Tag = "8";
            this.ラプラシアン８ToolStripMenuItem.Text = "ラプラシアン８";
            this.ラプラシアン８ToolStripMenuItem.Click += new System.EventHandler(this.FilterMenu_LapClick);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.filterItemSobelTT,
            this.filterItemSobelTR,
            this.filterItemSobelTB,
            this.filterItemSobelTL,
            this.filterItemSobelTRT,
            this.filterItemSobelTRB,
            this.filterItemSobelTLB,
            this.filterItemSobelTLT});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(185, 24);
            this.toolStripMenuItem2.Text = "ソーベルフィルタ";
            // 
            // filterItemSobelTT
            // 
            this.filterItemSobelTT.Name = "filterItemSobelTT";
            this.filterItemSobelTT.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTT.Text = "↑";
            this.filterItemSobelTT.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTR
            // 
            this.filterItemSobelTR.Name = "filterItemSobelTR";
            this.filterItemSobelTR.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTR.Text = "→";
            this.filterItemSobelTR.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTB
            // 
            this.filterItemSobelTB.Name = "filterItemSobelTB";
            this.filterItemSobelTB.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTB.Text = "↓";
            this.filterItemSobelTB.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTL
            // 
            this.filterItemSobelTL.Name = "filterItemSobelTL";
            this.filterItemSobelTL.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTL.Text = "←";
            this.filterItemSobelTL.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTRT
            // 
            this.filterItemSobelTRT.Name = "filterItemSobelTRT";
            this.filterItemSobelTRT.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTRT.Text = "右上";
            this.filterItemSobelTRT.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTRB
            // 
            this.filterItemSobelTRB.Name = "filterItemSobelTRB";
            this.filterItemSobelTRB.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTRB.Text = "右下";
            this.filterItemSobelTRB.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTLB
            // 
            this.filterItemSobelTLB.Name = "filterItemSobelTLB";
            this.filterItemSobelTLB.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTLB.Text = "左下";
            this.filterItemSobelTLB.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // filterItemSobelTLT
            // 
            this.filterItemSobelTLT.Name = "filterItemSobelTLT";
            this.filterItemSobelTLT.Size = new System.Drawing.Size(108, 24);
            this.filterItemSobelTLT.Text = "左上";
            this.filterItemSobelTLT.Click += new System.EventHandler(this.convMenu_SobelClick);
            // 
            // 平均化ToolStripMenuItem
            // 
            this.平均化ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重みなしToolStripMenuItem,
            this.重み２ToolStripMenuItem});
            this.平均化ToolStripMenuItem.Name = "平均化ToolStripMenuItem";
            this.平均化ToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.平均化ToolStripMenuItem.Text = "スムージング";
            // 
            // 重みなしToolStripMenuItem
            // 
            this.重みなしToolStripMenuItem.Name = "重みなしToolStripMenuItem";
            this.重みなしToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.重みなしToolStripMenuItem.Tag = " 0";
            this.重みなしToolStripMenuItem.Text = "重みなし";
            this.重みなしToolStripMenuItem.Click += new System.EventHandler(this.FilterMenu_SmoothClick);
            // 
            // 重み２ToolStripMenuItem
            // 
            this.重み２ToolStripMenuItem.Name = "重み２ToolStripMenuItem";
            this.重み２ToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.重み２ToolStripMenuItem.Tag = "2";
            this.重み２ToolStripMenuItem.Text = "重み２";
            this.重み２ToolStripMenuItem.Click += new System.EventHandler(this.FilterMenu_SmoothClick);
            // 
            // ガウシアンフィルタToolStripMenuItem
            // 
            this.ガウシアンフィルタToolStripMenuItem.Name = "ガウシアンフィルタToolStripMenuItem";
            this.ガウシアンフィルタToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.ガウシアンフィルタToolStripMenuItem.Text = "ガウシアンフィルタ";
            this.ガウシアンフィルタToolStripMenuItem.Click += new System.EventHandler(this.filterMenu_GaussianClick);
            // 
            // メディアンフィルタToolStripMenuItem
            // 
            this.メディアンフィルタToolStripMenuItem.Name = "メディアンフィルタToolStripMenuItem";
            this.メディアンフィルタToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.メディアンフィルタToolStripMenuItem.Text = "メディアンフィルタ";
            this.メディアンフィルタToolStripMenuItem.Click += new System.EventHandler(this.filterMenu_MedianClick);
            // 
            // 平均移動フィルタToolStripMenuItem
            // 
            this.平均移動フィルタToolStripMenuItem.Name = "平均移動フィルタToolStripMenuItem";
            this.平均移動フィルタToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.平均移動フィルタToolStripMenuItem.Text = "平均移動フィルタ";
            this.平均移動フィルタToolStripMenuItem.Click += new System.EventHandler(this.filterMenu_AverageClick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(523, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "元に戻す";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Restore_BtnClick);
            // 
            // setOrgBtn
            // 
            this.setOrgBtn.Location = new System.Drawing.Point(12, 29);
            this.setOrgBtn.Name = "setOrgBtn";
            this.setOrgBtn.Size = new System.Drawing.Size(75, 23);
            this.setOrgBtn.TabIndex = 4;
            this.setOrgBtn.Text = "続けて処理";
            this.setOrgBtn.UseVisualStyleBackColor = true;
            this.setOrgBtn.Click += new System.EventHandler(this.setOrgBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 549);
            this.Controls.Add(this.setOrgBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pLabel);
            this.Controls.Add(this.pBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Qview";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBox;
        private System.Windows.Forms.TextBox pLabel;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ファイルToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開くOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 終了CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 変換CToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 色を反転ToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem ｒＧＢを抽出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ｒToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ｇToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ｂToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem グレースケール化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 二値化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem セピアToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem フィルタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ラプラシアンフィルタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ラプラシアン４ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ラプラシアン８ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均化ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重みなしToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重み２ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 階調処理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox convMenuPostalBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox fileMenu_FileNameBox;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.Button setOrgBtn;
        private System.Windows.Forms.ToolStripMenuItem ガウシアンフィルタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メディアンフィルタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 平均移動フィルタToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTT;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTR;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTB;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTL;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTRT;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTRB;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTLB;
        private System.Windows.Forms.ToolStripMenuItem filterItemSobelTLT;
        private System.Windows.Forms.ToolStripTextBox convMenu_BinBox;
    }
}

