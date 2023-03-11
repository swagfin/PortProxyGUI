﻿namespace PortProxyGUI
{
    partial class PortProxyGUI
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PortProxyGUI));
            this.listViewProxies = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader4 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader5 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader6 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader7 = new System.Windows.Forms.ColumnHeader();
            this.contextMenuStrip_RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Enable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Disable = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_Refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_FlushDnsCache = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_New = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Modify = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_More = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Import = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Export = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_ResetWindowSize = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem_About = new System.Windows.Forms.ToolStripMenuItem();
            this.imageListProxies = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog_Export = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog_Import = new System.Windows.Forms.OpenFileDialog();
            this.toolStripMenuItem_RestartIpHlpSvc = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // listViewProxies
            // 
            this.listViewProxies.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewProxies.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewProxies.ContextMenuStrip = this.contextMenuStrip_RightClick;
            resources.ApplyResources(this.listViewProxies, "listViewProxies");
            this.listViewProxies.FullRowSelect = true;
            this.listViewProxies.Name = "listViewProxies";
            this.listViewProxies.SmallImageList = this.imageListProxies;
            this.listViewProxies.UseCompatibleStateImageBehavior = false;
            this.listViewProxies.View = System.Windows.Forms.View.Details;
            this.listViewProxies.ColumnClick += listView1_ColumnClick;
            this.listViewProxies.ColumnWidthChanged += listViewProxies_ColumnWidthChanged;
            this.listViewProxies.DoubleClick += listView1_DoubleClick;
            this.listViewProxies.KeyUp += listViewProxies_KeyUp;
            this.listViewProxies.MouseUp += listView1_MouseUp;
            // 
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            this.columnHeader4.Tag = "";
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // columnHeader5
            // 
            resources.ApplyResources(this.columnHeader5, "columnHeader5");
            // 
            // columnHeader6
            // 
            this.columnHeader6.Tag = "";
            resources.ApplyResources(this.columnHeader6, "columnHeader6");
            // 
            // columnHeader7
            // 
            resources.ApplyResources(this.columnHeader7, "columnHeader7");
            // 
            // contextMenuStrip_RightClick
            // 
            this.contextMenuStrip_RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Enable,
            this.toolStripMenuItem_Disable,
            this.toolStripSeparator3,
            this.toolStripMenuItem_Refresh,
            this.toolStripMenuItem_FlushDnsCache,
            this.toolStripMenuItem_RestartIpHlpSvc,
            this.toolStripSeparator2,
            this.toolStripMenuItem_New,
            this.toolStripMenuItem_Modify,
            this.toolStripMenuItem_Delete,
            this.toolStripSeparator1,
            this.toolStripMenuItem_More,
            this.toolStripSeparator4,
            this.toolStripMenuItem_About});
            this.contextMenuStrip_RightClick.Name = "contextMenuStrip1";
            resources.ApplyResources(this.contextMenuStrip_RightClick, "contextMenuStrip_RightClick");
            this.contextMenuStrip_RightClick.MouseClick += contextMenuStrip_RightClick_MouseClick;
            // 
            // toolStripMenuItem_Enable
            // 
            this.toolStripMenuItem_Enable.Name = "toolStripMenuItem_Enable";
            resources.ApplyResources(this.toolStripMenuItem_Enable, "toolStripMenuItem_Enable");
            // 
            // toolStripMenuItem_Disable
            // 
            this.toolStripMenuItem_Disable.Name = "toolStripMenuItem_Disable";
            resources.ApplyResources(this.toolStripMenuItem_Disable, "toolStripMenuItem_Disable");
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // toolStripMenuItem_Refresh
            // 
            this.toolStripMenuItem_Refresh.Name = "toolStripMenuItem_Refresh";
            resources.ApplyResources(this.toolStripMenuItem_Refresh, "toolStripMenuItem_Refresh");
            // 
            // toolStripMenuItem_FlushDnsCache
            // 
            this.toolStripMenuItem_FlushDnsCache.Name = "toolStripMenuItem_FlushDnsCache";
            resources.ApplyResources(this.toolStripMenuItem_FlushDnsCache, "toolStripMenuItem_FlushDnsCache");
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // toolStripMenuItem_New
            // 
            this.toolStripMenuItem_New.Name = "toolStripMenuItem_New";
            resources.ApplyResources(this.toolStripMenuItem_New, "toolStripMenuItem_New");
            // 
            // toolStripMenuItem_Modify
            // 
            this.toolStripMenuItem_Modify.Name = "toolStripMenuItem_Modify";
            resources.ApplyResources(this.toolStripMenuItem_Modify, "toolStripMenuItem_Modify");
            // 
            // toolStripMenuItem_Delete
            // 
            this.toolStripMenuItem_Delete.Name = "toolStripMenuItem_Delete";
            resources.ApplyResources(this.toolStripMenuItem_Delete, "toolStripMenuItem_Delete");
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // toolStripMenuItem_More
            // 
            this.toolStripMenuItem_More.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Import,
            this.toolStripMenuItem_Export,
            this.toolStripSeparator5,
            this.toolStripMenuItem_ResetWindowSize});
            this.toolStripMenuItem_More.Name = "toolStripMenuItem_More";
            resources.ApplyResources(this.toolStripMenuItem_More, "toolStripMenuItem_More");
            // 
            // toolStripMenuItem_Import
            // 
            this.toolStripMenuItem_Import.Name = "toolStripMenuItem_Import";
            resources.ApplyResources(this.toolStripMenuItem_Import, "toolStripMenuItem_Import");
            toolStripMenuItem_Import.Click += toolStripMenuItem_Import_Click;

            // 
            // toolStripMenuItem_Export
            // 
            this.toolStripMenuItem_Export.Name = "toolStripMenuItem_Export";
            resources.ApplyResources(this.toolStripMenuItem_Export, "toolStripMenuItem_Export");
            toolStripMenuItem_Export.Click += toolStripMenuItem_Export_Click;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            resources.ApplyResources(this.toolStripSeparator5, "toolStripSeparator5");
            // 
            // toolStripMenuItem_ResetWindowSize
            // 
            this.toolStripMenuItem_ResetWindowSize.Name = "toolStripMenuItem_ResetWindowSize";
            resources.ApplyResources(this.toolStripMenuItem_ResetWindowSize, "toolStripMenuItem_ResetWindowSize");
            toolStripMenuItem_ResetWindowSize.Click += toolStripMenuItem_ResetWindowSize_Click;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // toolStripMenuItem_About
            // 
            this.toolStripMenuItem_About.Name = "toolStripMenuItem_About";
            resources.ApplyResources(this.toolStripMenuItem_About, "toolStripMenuItem_About");
            // 
            // imageListProxies
            // 
            this.imageListProxies.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageListProxies.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageListProxies.ImageStream")));
            this.imageListProxies.TransparentColor = System.Drawing.Color.Transparent;
            this.imageListProxies.Images.SetKeyName(0, "disable.png");
            this.imageListProxies.Images.SetKeyName(1, "enable.png");
            // 
            // saveFileDialog_Export
            // 
            resources.ApplyResources(this.saveFileDialog_Export, "saveFileDialog_Export");
            // 
            // openFileDialog_Import
            // 
            this.openFileDialog_Import.FileName = "openFileDialog1";
            resources.ApplyResources(this.openFileDialog_Import, "openFileDialog_Import");
            // 
            // toolStripMenuItem_RestartIpHlpSvc
            // 
            this.toolStripMenuItem_RestartIpHlpSvc.Name = "toolStripMenuItem_RestartIpHlpSvc";
            resources.ApplyResources(this.toolStripMenuItem_RestartIpHlpSvc, "toolStripMenuItem_RestartIpHlpSvc");
            // 
            // PortProxyGUI
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listViewProxies);
            this.Name = "PortProxyGUI";
            FormClosing += PortProxyGUI_FormClosing;
            Load += PortProxyGUI_Load;
            Shown += PortProxyGUI_Shown;
            Resize += PortProxyGUI_Resize;
            this.contextMenuStrip_RightClick.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_RightClick;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_New;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Delete;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Refresh;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_About;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Modify;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ImageList imageListProxies;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Enable;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Disable;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        internal System.Windows.Forms.ListView listViewProxies;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_FlushDnsCache;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_More;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Export;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_Import;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.SaveFileDialog saveFileDialog_Export;
        private System.Windows.Forms.OpenFileDialog openFileDialog_Import;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_ResetWindowSize;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem_RestartIpHlpSvc;
    }
}

