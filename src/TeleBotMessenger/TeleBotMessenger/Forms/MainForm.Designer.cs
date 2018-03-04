﻿namespace TeleBotMessenger.Forms
{
    partial class MainForm
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
            this.gbConnect = new System.Windows.Forms.GroupBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.txtBotToken = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gbTools = new System.Windows.Forms.GroupBox();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddLink = new System.Windows.Forms.Button();
            this.lstMessages = new System.Windows.Forms.ListBox();
            this.pix = new System.Windows.Forms.PictureBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.rtxtText = new System.Windows.Forms.RichTextBox();
            this.btnTest = new System.Windows.Forms.Button();
            this.txtChannelName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.layout = new System.Windows.Forms.FlowLayoutPanel();
            this.gbConnect.SuspendLayout();
            this.gbTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).BeginInit();
            this.SuspendLayout();
            // 
            // gbConnect
            // 
            this.gbConnect.Controls.Add(this.btnConnect);
            this.gbConnect.Controls.Add(this.txtBotToken);
            this.gbConnect.Controls.Add(this.label2);
            this.gbConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbConnect.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbConnect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.gbConnect.Location = new System.Drawing.Point(0, 0);
            this.gbConnect.Margin = new System.Windows.Forms.Padding(2);
            this.gbConnect.Name = "gbConnect";
            this.gbConnect.Padding = new System.Windows.Forms.Padding(2);
            this.gbConnect.Size = new System.Drawing.Size(476, 62);
            this.gbConnect.TabIndex = 5;
            this.gbConnect.TabStop = false;
            this.gbConnect.Text = "Connection";
            // 
            // btnConnect
            // 
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(390, 24);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(2);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(74, 23);
            this.btnConnect.TabIndex = 7;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // txtBotToken
            // 
            this.txtBotToken.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBotToken.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBotToken.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txtBotToken.Location = new System.Drawing.Point(86, 24);
            this.txtBotToken.Margin = new System.Windows.Forms.Padding(2);
            this.txtBotToken.Name = "txtBotToken";
            this.txtBotToken.Size = new System.Drawing.Size(300, 23);
            this.txtBotToken.TabIndex = 6;
            this.txtBotToken.Text = "487322303:AAE0VfVSlJwa1-APuEKLO4lvLs4hHPmTxko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bot Token:";
            // 
            // gbTools
            // 
            this.gbTools.Controls.Add(this.layout);
            this.gbTools.Controls.Add(this.btnAddRow);
            this.gbTools.Controls.Add(this.btnEdit);
            this.gbTools.Controls.Add(this.btnAddLink);
            this.gbTools.Controls.Add(this.lstMessages);
            this.gbTools.Controls.Add(this.pix);
            this.gbTools.Controls.Add(this.btnSend);
            this.gbTools.Controls.Add(this.rtxtText);
            this.gbTools.Controls.Add(this.btnTest);
            this.gbTools.Controls.Add(this.txtChannelName);
            this.gbTools.Controls.Add(this.label1);
            this.gbTools.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbTools.Enabled = false;
            this.gbTools.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gbTools.Location = new System.Drawing.Point(0, 62);
            this.gbTools.Margin = new System.Windows.Forms.Padding(2);
            this.gbTools.Name = "gbTools";
            this.gbTools.Padding = new System.Windows.Forms.Padding(2);
            this.gbTools.Size = new System.Drawing.Size(476, 596);
            this.gbTools.TabIndex = 6;
            this.gbTools.TabStop = false;
            this.gbTools.Text = "Tools";
            // 
            // btnAddRow
            // 
            this.btnAddRow.BackgroundImage = global::TeleBotMessenger.Properties.Resources.add_row;
            this.btnAddRow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddRow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddRow.Location = new System.Drawing.Point(5, 378);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(44, 49);
            this.btnAddRow.TabIndex = 12;
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Location = new System.Drawing.Point(337, 75);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(127, 37);
            this.btnEdit.TabIndex = 11;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnAddLink
            // 
            this.btnAddLink.BackgroundImage = global::TeleBotMessenger.Properties.Resources.link_icon;
            this.btnAddLink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddLink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddLink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLink.Location = new System.Drawing.Point(5, 271);
            this.btnAddLink.Name = "btnAddLink";
            this.btnAddLink.Size = new System.Drawing.Size(44, 40);
            this.btnAddLink.TabIndex = 7;
            this.btnAddLink.UseVisualStyleBackColor = true;
            this.btnAddLink.Click += new System.EventHandler(this.btnAddLink_Click);
            // 
            // lstMessages
            // 
            this.lstMessages.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lstMessages.FormattingEnabled = true;
            this.lstMessages.ItemHeight = 15;
            this.lstMessages.Location = new System.Drawing.Point(337, 117);
            this.lstMessages.Name = "lstMessages";
            this.lstMessages.Size = new System.Drawing.Size(128, 259);
            this.lstMessages.TabIndex = 10;
            // 
            // pix
            // 
            this.pix.BackgroundImage = global::TeleBotMessenger.Properties.Resources.background;
            this.pix.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pix.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pix.Location = new System.Drawing.Point(56, 75);
            this.pix.Name = "pix";
            this.pix.Size = new System.Drawing.Size(195, 191);
            this.pix.TabIndex = 9;
            this.pix.TabStop = false;
            this.pix.Click += new System.EventHandler(this.pix_Click);
            // 
            // btnSend
            // 
            this.btnSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Location = new System.Drawing.Point(337, 548);
            this.btnSend.Margin = new System.Windows.Forms.Padding(2);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(127, 37);
            this.btnSend.TabIndex = 6;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // rtxtText
            // 
            this.rtxtText.Location = new System.Drawing.Point(56, 271);
            this.rtxtText.Margin = new System.Windows.Forms.Padding(2);
            this.rtxtText.Name = "rtxtText";
            this.rtxtText.Size = new System.Drawing.Size(195, 156);
            this.rtxtText.TabIndex = 4;
            this.rtxtText.Text = "";
            // 
            // btnTest
            // 
            this.btnTest.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTest.Location = new System.Drawing.Point(390, 25);
            this.btnTest.Margin = new System.Windows.Forms.Padding(2);
            this.btnTest.Name = "btnTest";
            this.btnTest.Size = new System.Drawing.Size(74, 23);
            this.btnTest.TabIndex = 3;
            this.btnTest.Text = "Test";
            this.btnTest.UseVisualStyleBackColor = true;
            this.btnTest.Click += new System.EventHandler(this.btnTest_Click);
            // 
            // txtChannelName
            // 
            this.txtChannelName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtChannelName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtChannelName.Location = new System.Drawing.Point(150, 25);
            this.txtChannelName.Margin = new System.Windows.Forms.Padding(2);
            this.txtChannelName.Name = "txtChannelName";
            this.txtChannelName.Size = new System.Drawing.Size(236, 23);
            this.txtChannelName.TabIndex = 2;
            this.txtChannelName.Text = "testtt11";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Channels or Groups:   @";
            // 
            // layout
            // 
            this.layout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.layout.AutoScroll = true;
            this.layout.Location = new System.Drawing.Point(2, 433);
            this.layout.Name = "layout";
            this.layout.Size = new System.Drawing.Size(279, 151);
            this.layout.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(476, 658);
            this.Controls.Add(this.gbTools);
            this.Controls.Add(this.gbConnect);
            this.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telegram Bot Messenger";
            this.gbConnect.ResumeLayout(false);
            this.gbConnect.PerformLayout();
            this.gbTools.ResumeLayout(false);
            this.gbTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pix)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbConnect;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtBotToken;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbTools;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtChannelName;
        private System.Windows.Forms.Button btnTest;
        private System.Windows.Forms.RichTextBox rtxtText;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnAddLink;
        private System.Windows.Forms.PictureBox pix;
        private System.Windows.Forms.ListBox lstMessages;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.FlowLayoutPanel layout;
    }
}
