using System;
using System.Drawing;
using System.Windows.Forms;
using System.Reflection;
using Qview.Naoya.Imaging;

namespace Qview
{

    public partial class Form1 : Form
    {
        private Bitmap originalBmp;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String[] cmd = System.Environment.GetCommandLineArgs();

            if (cmd.Length > 1)
            {
                try
                {
                    originalBmp = new Bitmap(cmd[1]);
                    showImage(originalBmp);
                    pLabel.Text = cmd[1];

                    setSobelTag();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("画像ファイルを指定してください。");
                Close();
            }
        }

        private void setSobelTag ()
        {
            filterItemSobelTT.Tag = IMGFilter.SobelTT;
            filterItemSobelTR.Tag = IMGFilter.SobelTR;
            filterItemSobelTB.Tag = IMGFilter.SobelTB;
            filterItemSobelTL.Tag = IMGFilter.SobelTL;

            filterItemSobelTRT.Tag = IMGFilter.SobelTRT;
            filterItemSobelTRB.Tag = IMGFilter.SobelTRB;
            filterItemSobelTLB.Tag = IMGFilter.SobelTLB;
            filterItemSobelTLT.Tag = IMGFilter.SobelTLT;
        }

        private void showImage(Image img)
        {
            pBox.Image = img;
        }

        private void FileMenu_CloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Restore_BtnClick(object sender, EventArgs e)
        {
            pBox.Image = originalBmp;
        }

        private void ConvMenu_InverseClick(object sender, EventArgs e)
        {
            var nbmp = new NBitmap(originalBmp);
            showImage(nbmp.Effect(IMGProc.ToNega));
        }

        private void ConvMenu_RGBClick(object sender, EventArgs e)
        {
            var nbmp = new NBitmap(originalBmp);
            switch(int.Parse(((ToolStripMenuItem)sender).Tag.ToString())){
                case 1: showImage(nbmp.Effect(IMGProc.ToRedOnly)); break;
                case 2: showImage(nbmp.Effect(IMGProc.ToGreenOnly)); break;
                case 3: showImage(nbmp.Effect(IMGProc.ToBlueOnly)); break;
            }
        }

        private void ConvMenu_GrayClick(object sender, EventArgs e)
        {
            var nbmp = new NBitmap(originalBmp);
            showImage(nbmp.Effect(IMGProc.ToMono));
        }

        private void ConvMenu_SepiaClick(object sender, EventArgs e)
        {
            var nbmp = new NBitmap(originalBmp);
            showImage(nbmp.Effect(IMGProc.ToSepia));
        }

        private void StartWithWaitCursor(Action proc){
             try {
                this.Cursor = Cursors.WaitCursor;
                proc();
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            } finally {
                this.Cursor = Cursors.Default;
            }
        }

        private void  FilterMenu_LapClick(object sender, EventArgs e)
        {
            StartWithWaitCursor(
                () =>{
                    switch (int.Parse(((ToolStripMenuItem)sender).Tag.ToString())) {
                        case 4: showImage(IMGFilter.Lap4(originalBmp)); break;
                        case 8: showImage(IMGFilter.Lap8(originalBmp)); break;
                    }
                });
                
        }

        private void FilterMenu_SmoothClick(object sender, EventArgs e)
        {
            StartWithWaitCursor(
                () =>
                {
                    var nbmp = new NBitmap(originalBmp);
                    switch (int.Parse(((ToolStripMenuItem)sender).Tag.ToString())) {
                        case 0: showImage(nbmp.Effect(IMGFilter.Smooth(0))); break;
                        case 2: showImage(nbmp.Effect(IMGFilter.Smooth(2))); break;
                    }
                });
        }

        private void convMenuPostalBox_Click (object sender, EventArgs e)
        {
            convMenuPostalBox.Clear();
        }

        private void convMenuPostalBox_KeyDown (object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter ) {
                int level;
                if ( int.TryParse(convMenuPostalBox.Text, out level) ) {
                    StartWithWaitCursor(
                        () => {
                            var nbmp = new NBitmap(originalBmp);
                            var pr = new Posterizer(level);
                            showImage(nbmp.Effect(pr));
                        });
                } else {
                    convMenuPostalBox.Clear();
                    MessageBox.Show("数値を入力してください。");
                }
            }
        }

        private void fileMenu_FileNameBox_Click (object sender, EventArgs e)
        {
            fileMenu_FileNameBox.Clear();
        }

        private void fileMenu_FileNameBox_KeyDown (object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter ) {
                if ( String.IsNullOrEmpty(fileMenu_FileNameBox.Text) == false) {
                    pBox.Image.Save(fileMenu_FileNameBox.Text + ".bmp");
                    MessageBox.Show("保存が完了しました。");
                }
            }
        }

        private void convMenu_SobelClick (object sender, EventArgs e)
        {
            var menu = (ToolStripMenuItem)sender;
            var func = (Func<Bitmap,Bitmap>)menu.Tag;
            var nbmp = new NBitmap(originalBmp);

            StartWithWaitCursor(
                () => {
                    showImage(nbmp.Effect(func));
                });
        }


        private void setOrgBtn_Click (object sender, EventArgs e)
        {
            originalBmp = (Bitmap)pBox.Image;
        }

        private void filterMenu_GaussianClick (object sender, EventArgs e)
        {
            StartWithWaitCursor(
                () => {
                    var nBmp = new NBitmap(originalBmp);
                    showImage(nBmp.Effect(IMGFilter.Gaussian));
                });
        }

        private void filterMenu_MedianClick (object sender, EventArgs e)
        {
            StartWithWaitCursor(
                () => {
                    var nBmp = new NBitmap(originalBmp);
                    showImage(nBmp.Effect(IMGFilter.Median));
                });
        }

        private void filterMenu_AverageClick (object sender, EventArgs e)
        {
            StartWithWaitCursor(
                () => {
                    var nbmp = new NBitmap(originalBmp);
                    showImage(nbmp.Effect(IMGFilter.Average));
                });
        }

        private void convMenu_BinBox_Click (object sender, EventArgs e)
        {
            convMenu_BinBox.Clear();
        }

        private void convMenu_BinBox_KeyDown (object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter ) {
                float threshold;
                if (float.TryParse(convMenu_BinBox.Text,out threshold)){
                    var nbmp = new NBitmap(originalBmp);
                    showImage(nbmp.Effect(IMGProc.ToBin(threshold)));
                }
            }
        }

        private void button2_Click (object sender, EventArgs e)
        {
            var analyzeSize = new Size(50, 50);
            var canvas = new Bitmap(originalBmp);
            var g = Graphics.FromImage(canvas);

            IMGUtil.TrvRect(canvas,analyzeSize,
                (RectData rd) => {
                    g.DrawRectangle(Pens.Black, rd.Rect);
                });
            showImage(canvas);
            g.Dispose();
        }

    }
}
