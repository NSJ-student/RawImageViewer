namespace RawImageViewer
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.spltContainer = new System.Windows.Forms.SplitContainer();
            this.pResult = new System.Windows.Forms.Panel();
            this.tlpControl = new System.Windows.Forms.TableLayoutPanel();
            this.btnPixelSet = new System.Windows.Forms.Button();
            this.btnOpen = new System.Windows.Forms.Button();
            this.lblPixelSet = new System.Windows.Forms.Label();
            this.lblFileOpen = new System.Windows.Forms.Label();
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tbWidth = new System.Windows.Forms.TextBox();
            this.lblX = new System.Windows.Forms.Label();
            this.tbHeight = new System.Windows.Forms.TextBox();
            this.lblPixelSize = new System.Windows.Forms.Label();
            this.tbPixelSize = new System.Windows.Forms.TextBox();
            this.flpPixelButton = new System.Windows.Forms.FlowLayoutPanel();
            this.progressRawImage = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).BeginInit();
            this.spltContainer.Panel1.SuspendLayout();
            this.spltContainer.Panel2.SuspendLayout();
            this.spltContainer.SuspendLayout();
            this.tlpControl.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // spltContainer
            // 
            this.spltContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spltContainer.Location = new System.Drawing.Point(0, 0);
            this.spltContainer.Name = "spltContainer";
            this.spltContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // spltContainer.Panel1
            // 
            this.spltContainer.Panel1.Controls.Add(this.pResult);
            // 
            // spltContainer.Panel2
            // 
            this.spltContainer.Panel2.Controls.Add(this.tlpControl);
            this.spltContainer.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.spltContainer.Panel2MinSize = 100;
            this.spltContainer.Size = new System.Drawing.Size(800, 466);
            this.spltContainer.SplitterDistance = 361;
            this.spltContainer.TabIndex = 1;
            // 
            // pResult
            // 
            this.pResult.AutoScroll = true;
            this.pResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pResult.Location = new System.Drawing.Point(0, 0);
            this.pResult.Name = "pResult";
            this.pResult.Size = new System.Drawing.Size(800, 361);
            this.pResult.TabIndex = 0;
            this.pResult.Paint += new System.Windows.Forms.PaintEventHandler(this.pResult_Paint);
            // 
            // tlpControl
            // 
            this.tlpControl.ColumnCount = 3;
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlpControl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tlpControl.Controls.Add(this.lblSize, 0, 0);
            this.tlpControl.Controls.Add(this.lblFileOpen, 0, 2);
            this.tlpControl.Controls.Add(this.tbImagePath, 1, 2);
            this.tlpControl.Controls.Add(this.btnOpen, 2, 2);
            this.tlpControl.Controls.Add(this.lblPixelSet, 0, 1);
            this.tlpControl.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.tlpControl.Controls.Add(this.flpPixelButton, 1, 1);
            this.tlpControl.Controls.Add(this.btnPixelSet, 2, 0);
            this.tlpControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlpControl.Location = new System.Drawing.Point(3, 3);
            this.tlpControl.Name = "tlpControl";
            this.tlpControl.RowCount = 3;
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tlpControl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlpControl.Size = new System.Drawing.Size(794, 95);
            this.tlpControl.TabIndex = 0;
            // 
            // btnPixelSet
            // 
            this.btnPixelSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPixelSet.Location = new System.Drawing.Point(697, 4);
            this.btnPixelSet.Name = "btnPixelSet";
            this.btnPixelSet.Size = new System.Drawing.Size(94, 23);
            this.btnPixelSet.TabIndex = 0;
            this.btnPixelSet.Text = "Set";
            this.btnPixelSet.UseVisualStyleBackColor = true;
            this.btnPixelSet.Click += new System.EventHandler(this.btnPixelSet_Click);
            // 
            // btnOpen
            // 
            this.btnOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpen.Location = new System.Drawing.Point(697, 67);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(94, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // lblPixelSet
            // 
            this.lblPixelSet.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPixelSet.AutoSize = true;
            this.lblPixelSet.Location = new System.Drawing.Point(3, 40);
            this.lblPixelSet.Name = "lblPixelSet";
            this.lblPixelSet.Size = new System.Drawing.Size(94, 12);
            this.lblPixelSet.TabIndex = 2;
            this.lblPixelSet.Text = "Pixel Setting";
            // 
            // lblFileOpen
            // 
            this.lblFileOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFileOpen.AutoSize = true;
            this.lblFileOpen.Location = new System.Drawing.Point(3, 72);
            this.lblFileOpen.Name = "lblFileOpen";
            this.lblFileOpen.Size = new System.Drawing.Size(94, 12);
            this.lblFileOpen.TabIndex = 3;
            this.lblFileOpen.Text = "Raw File";
            // 
            // tbImagePath
            // 
            this.tbImagePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbImagePath.Location = new System.Drawing.Point(103, 68);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.ReadOnly = true;
            this.tbImagePath.Size = new System.Drawing.Size(588, 21);
            this.tbImagePath.TabIndex = 4;
            // 
            // lblSize
            // 
            this.lblSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(3, 9);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(94, 12);
            this.lblSize.TabIndex = 5;
            this.lblSize.Text = "Size";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.tbWidth);
            this.flowLayoutPanel1.Controls.Add(this.lblX);
            this.flowLayoutPanel1.Controls.Add(this.tbHeight);
            this.flowLayoutPanel1.Controls.Add(this.lblPixelSize);
            this.flowLayoutPanel1.Controls.Add(this.tbPixelSize);
            this.flowLayoutPanel1.Controls.Add(this.progressRawImage);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(103, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(588, 25);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // tbWidth
            // 
            this.tbWidth.Location = new System.Drawing.Point(3, 3);
            this.tbWidth.Name = "tbWidth";
            this.tbWidth.Size = new System.Drawing.Size(70, 21);
            this.tbWidth.TabIndex = 0;
            this.tbWidth.Text = "1312";
            // 
            // lblX
            // 
            this.lblX.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(79, 0);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(13, 27);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            this.lblX.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbHeight
            // 
            this.tbHeight.Location = new System.Drawing.Point(98, 3);
            this.tbHeight.Name = "tbHeight";
            this.tbHeight.Size = new System.Drawing.Size(70, 21);
            this.tbHeight.TabIndex = 2;
            this.tbHeight.Text = "977";
            // 
            // lblPixelSize
            // 
            this.lblPixelSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblPixelSize.AutoSize = true;
            this.lblPixelSize.Location = new System.Drawing.Point(181, 0);
            this.lblPixelSize.Margin = new System.Windows.Forms.Padding(10, 0, 3, 0);
            this.lblPixelSize.Name = "lblPixelSize";
            this.lblPixelSize.Size = new System.Drawing.Size(68, 27);
            this.lblPixelSize.TabIndex = 3;
            this.lblPixelSize.Text = "pixel size: ";
            this.lblPixelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbPixelSize
            // 
            this.tbPixelSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPixelSize.Location = new System.Drawing.Point(255, 3);
            this.tbPixelSize.Name = "tbPixelSize";
            this.tbPixelSize.Size = new System.Drawing.Size(38, 21);
            this.tbPixelSize.TabIndex = 4;
            this.tbPixelSize.Text = "16";
            this.tbPixelSize.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPixelSize_KeyPress);
            // 
            // flpPixelButton
            // 
            this.tlpControl.SetColumnSpan(this.flpPixelButton, 2);
            this.flpPixelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPixelButton.Location = new System.Drawing.Point(103, 34);
            this.flpPixelButton.Name = "flpPixelButton";
            this.flpPixelButton.Size = new System.Drawing.Size(688, 25);
            this.flpPixelButton.TabIndex = 7;
            // 
            // progressRawImage
            // 
            this.progressRawImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.progressRawImage.Location = new System.Drawing.Point(306, 3);
            this.progressRawImage.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.progressRawImage.Name = "progressRawImage";
            this.progressRawImage.Size = new System.Drawing.Size(243, 21);
            this.progressRawImage.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 466);
            this.Controls.Add(this.spltContainer);
            this.Name = "Form1";
            this.Text = "Raw Image Viewer";
            this.spltContainer.Panel1.ResumeLayout(false);
            this.spltContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spltContainer)).EndInit();
            this.spltContainer.ResumeLayout(false);
            this.tlpControl.ResumeLayout(false);
            this.tlpControl.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer spltContainer;
        private System.Windows.Forms.Panel pResult;
        private System.Windows.Forms.TableLayoutPanel tlpControl;
        private System.Windows.Forms.Button btnPixelSet;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Label lblPixelSet;
        private System.Windows.Forms.Label lblFileOpen;
        private System.Windows.Forms.TextBox tbImagePath;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox tbWidth;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.TextBox tbHeight;
        private System.Windows.Forms.Label lblPixelSize;
        private System.Windows.Forms.TextBox tbPixelSize;
        private System.Windows.Forms.FlowLayoutPanel flpPixelButton;
        private System.Windows.Forms.ProgressBar progressRawImage;
    }
}

