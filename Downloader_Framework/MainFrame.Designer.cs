using System.Drawing;
using System.Windows.Forms;

namespace Downloader_Framework
{
    partial class MainFrame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.tablepnl_TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Author = new System.Windows.Forms.Label();
            this.lbl_PrgName = new System.Windows.Forms.Label();
            this.lbl_ImageStatus = new System.Windows.Forms.Label();
            this.btn_CheckCon = new System.Windows.Forms.Button();
            this.tablepnl_TopPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // tablepnl_TopPanel
            // 
            this.tablepnl_TopPanel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.tablepnl_TopPanel.ColumnCount = 4;
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.80428F));
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.19572F));
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 314F));
            this.tablepnl_TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tablepnl_TopPanel.Controls.Add(this.lbl_Author, 1, 0);
            this.tablepnl_TopPanel.Controls.Add(this.lbl_PrgName, 0, 0);
            this.tablepnl_TopPanel.Controls.Add(this.lbl_ImageStatus, 3, 0);
            this.tablepnl_TopPanel.Controls.Add(this.btn_CheckCon, 2, 0);
            this.tablepnl_TopPanel.Location = new System.Drawing.Point(14, 14);
            this.tablepnl_TopPanel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tablepnl_TopPanel.Name = "tablepnl_TopPanel";
            this.tablepnl_TopPanel.RowCount = 1;
            this.tablepnl_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tablepnl_TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tablepnl_TopPanel.Size = new System.Drawing.Size(1257, 61);
            this.tablepnl_TopPanel.TabIndex = 0;
            // 
            // lbl_Author
            // 
            this.lbl_Author.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_Author.AutoSize = true;
            this.lbl_Author.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.lbl_Author.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Author.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Author.Font = new System.Drawing.Font("Arial Narrow", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_Author.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Author.Location = new System.Drawing.Point(283, 10);
            this.lbl_Author.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Author.Name = "lbl_Author";
            this.lbl_Author.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lbl_Author.Size = new System.Drawing.Size(582, 41);
            this.lbl_Author.TabIndex = 4;
            this.lbl_Author.Text = "VADIM ELSHIN | DAW 1 | IES DOCTOR BALMIS";
            this.lbl_Author.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_PrgName
            // 
            this.lbl_PrgName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_PrgName.AutoSize = true;
            this.lbl_PrgName.BackColor = System.Drawing.Color.Navy;
            this.lbl_PrgName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_PrgName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_PrgName.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbl_PrgName.ForeColor = System.Drawing.Color.White;
            this.lbl_PrgName.Location = new System.Drawing.Point(6, 10);
            this.lbl_PrgName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_PrgName.Name = "lbl_PrgName";
            this.lbl_PrgName.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.lbl_PrgName.Size = new System.Drawing.Size(265, 41);
            this.lbl_PrgName.TabIndex = 0;
            this.lbl_PrgName.Text = "DOWNLOADER";
            this.lbl_PrgName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ImageStatus
            // 
            this.lbl_ImageStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_ImageStatus.Image = ((System.Drawing.Image)(resources.GetObject("lbl_ImageStatus.Image")));
            this.lbl_ImageStatus.Location = new System.Drawing.Point(1189, 3);
            this.lbl_ImageStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ImageStatus.Name = "lbl_ImageStatus";
            this.lbl_ImageStatus.Size = new System.Drawing.Size(64, 54);
            this.lbl_ImageStatus.TabIndex = 3;
            this.lbl_ImageStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_CheckCon
            // 
            this.btn_CheckCon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CheckCon.BackColor = System.Drawing.Color.MediumBlue;
            this.btn_CheckCon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_CheckCon.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_CheckCon.Font = new System.Drawing.Font("Arial Narrow", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_CheckCon.ForeColor = System.Drawing.Color.White;
            this.btn_CheckCon.Location = new System.Drawing.Point(880, 6);
            this.btn_CheckCon.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_CheckCon.Name = "btn_CheckCon";
            this.btn_CheckCon.Padding = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.btn_CheckCon.Size = new System.Drawing.Size(296, 48);
            this.btn_CheckCon.TabIndex = 2;
            this.btn_CheckCon.Text = "CHECK CONNECTION";
            this.btn_CheckCon.UseVisualStyleBackColor = false;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1284, 811);
            this.Controls.Add(this.tablepnl_TopPanel);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Downloader";
            this.tablepnl_TopPanel.ResumeLayout(false);
            this.tablepnl_TopPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TableLayoutPanel tablepnl_TopPanel;
        private Label lbl_Author;
        private Label lbl_PrgName;
        private Button btn_CheckCon;
        public Label lbl_ImageStatus;
    }
}

