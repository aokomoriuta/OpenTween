﻿namespace OpenTween.Setting.Panel
{
    partial class ConnectionPanel
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionPanel));
            this.TwitterAPIText = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label64 = new System.Windows.Forms.Label();
            this.ConnectionTimeOut = new System.Windows.Forms.TextBox();
            this.Label63 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TwitterAPIText
            // 
            resources.ApplyResources(this.TwitterAPIText, "TwitterAPIText");
            this.TwitterAPIText.Name = "TwitterAPIText";
            // 
            // Label8
            // 
            resources.ApplyResources(this.Label8, "Label8");
            this.Label8.Name = "Label8";
            // 
            // Label64
            // 
            resources.ApplyResources(this.Label64, "Label64");
            this.Label64.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Label64.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label64.Name = "Label64";
            // 
            // ConnectionTimeOut
            // 
            resources.ApplyResources(this.ConnectionTimeOut, "ConnectionTimeOut");
            this.ConnectionTimeOut.Name = "ConnectionTimeOut";
            this.ConnectionTimeOut.Validating += new System.ComponentModel.CancelEventHandler(this.ConnectionTimeOut_Validating);
            // 
            // Label63
            // 
            resources.ApplyResources(this.Label63, "Label63");
            this.Label63.Name = "Label63";
            // 
            // ConnectionPanel
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.TwitterAPIText);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.Label64);
            this.Controls.Add(this.ConnectionTimeOut);
            this.Controls.Add(this.Label63);
            this.Name = "ConnectionPanel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox TwitterAPIText;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label64;
        internal System.Windows.Forms.TextBox ConnectionTimeOut;
        internal System.Windows.Forms.Label Label63;
    }
}
