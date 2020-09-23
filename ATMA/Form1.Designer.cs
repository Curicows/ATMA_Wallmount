namespace ATMA
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.configuraçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TopPanel = new System.Windows.Forms.TableLayoutPanel();
            this.geckoWebBrowser1 = new Gecko.GeckoWebBrowser();
            this.geckoWebBrowser2 = new Gecko.GeckoWebBrowser();
            this.geckoWebBrowser5 = new Gecko.GeckoWebBrowser();
            this.BottomPanel = new System.Windows.Forms.TableLayoutPanel();
            this.geckoWebBrowser3 = new Gecko.GeckoWebBrowser();
            this.geckoWebBrowser4 = new Gecko.GeckoWebBrowser();
            this.MainPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.TopPanel.SuspendLayout();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.ColumnCount = 1;
            this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainPanel.ContextMenuStrip = this.contextMenuStrip1;
            this.MainPanel.Controls.Add(this.TopPanel, 0, 1);
            this.MainPanel.Controls.Add(this.BottomPanel, 0, 2);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.RowCount = 3;
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.MainPanel.Size = new System.Drawing.Size(949, 636);
            this.MainPanel.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraçõesToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(152, 26);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // configuraçõesToolStripMenuItem
            // 
            this.configuraçõesToolStripMenuItem.Name = "configuraçõesToolStripMenuItem";
            this.configuraçõesToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.configuraçõesToolStripMenuItem.Text = "Configurações";
            this.configuraçõesToolStripMenuItem.Click += new System.EventHandler(this.configuraçõesToolStripMenuItem_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.SystemColors.Control;
            this.TopPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TopPanel.ColumnCount = 3;
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TopPanel.Controls.Add(this.geckoWebBrowser1, 0, 0);
            this.TopPanel.Controls.Add(this.geckoWebBrowser2, 1, 0);
            this.TopPanel.Controls.Add(this.geckoWebBrowser5, 2, 0);
            this.TopPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopPanel.Location = new System.Drawing.Point(3, 13);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.RowCount = 1;
            this.TopPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TopPanel.Size = new System.Drawing.Size(943, 307);
            this.TopPanel.TabIndex = 0;
            // 
            // geckoWebBrowser1
            // 
            this.geckoWebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser1.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser1.Location = new System.Drawing.Point(1, 1);
            this.geckoWebBrowser1.Margin = new System.Windows.Forms.Padding(0);
            this.geckoWebBrowser1.Name = "geckoWebBrowser1";
            this.geckoWebBrowser1.Size = new System.Drawing.Size(313, 305);
            this.geckoWebBrowser1.TabIndex = 0;
            this.geckoWebBrowser1.UseHttpActivityObserver = false;
            this.geckoWebBrowser1.DocumentCompleted += new System.EventHandler<Gecko.Events.GeckoDocumentCompletedEventArgs>(this.geckoWebBrowser1_DocumentCompleted);
            // 
            // geckoWebBrowser2
            // 
            this.geckoWebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser2.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser2.Location = new System.Drawing.Point(315, 1);
            this.geckoWebBrowser2.Margin = new System.Windows.Forms.Padding(0);
            this.geckoWebBrowser2.Name = "geckoWebBrowser2";
            this.geckoWebBrowser2.Size = new System.Drawing.Size(313, 305);
            this.geckoWebBrowser2.TabIndex = 1;
            this.geckoWebBrowser2.UseHttpActivityObserver = false;
            // 
            // geckoWebBrowser5
            // 
            this.geckoWebBrowser5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser5.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser5.Location = new System.Drawing.Point(629, 1);
            this.geckoWebBrowser5.Margin = new System.Windows.Forms.Padding(0);
            this.geckoWebBrowser5.Name = "geckoWebBrowser5";
            this.geckoWebBrowser5.Size = new System.Drawing.Size(313, 305);
            this.geckoWebBrowser5.TabIndex = 2;
            this.geckoWebBrowser5.UseHttpActivityObserver = false;
            // 
            // BottomPanel
            // 
            this.BottomPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.BottomPanel.ColumnCount = 2;
            this.BottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.BottomPanel.Controls.Add(this.geckoWebBrowser3, 0, 0);
            this.BottomPanel.Controls.Add(this.geckoWebBrowser4, 1, 0);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomPanel.Location = new System.Drawing.Point(3, 326);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.RowCount = 1;
            this.BottomPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.BottomPanel.Size = new System.Drawing.Size(943, 307);
            this.BottomPanel.TabIndex = 2;
            // 
            // geckoWebBrowser3
            // 
            this.geckoWebBrowser3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser3.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser3.Location = new System.Drawing.Point(1, 1);
            this.geckoWebBrowser3.Margin = new System.Windows.Forms.Padding(0);
            this.geckoWebBrowser3.Name = "geckoWebBrowser3";
            this.geckoWebBrowser3.Size = new System.Drawing.Size(470, 305);
            this.geckoWebBrowser3.TabIndex = 0;
            this.geckoWebBrowser3.UseHttpActivityObserver = false;
            // 
            // geckoWebBrowser4
            // 
            this.geckoWebBrowser4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.geckoWebBrowser4.FrameEventsPropagateToMainWindow = false;
            this.geckoWebBrowser4.Location = new System.Drawing.Point(472, 1);
            this.geckoWebBrowser4.Margin = new System.Windows.Forms.Padding(0);
            this.geckoWebBrowser4.Name = "geckoWebBrowser4";
            this.geckoWebBrowser4.Size = new System.Drawing.Size(470, 305);
            this.geckoWebBrowser4.TabIndex = 1;
            this.geckoWebBrowser4.UseHttpActivityObserver = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 636);
            this.Controls.Add(this.MainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(965, 675);
            this.Name = "Form1";
            this.Text = "ATMA Digital";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.TopPanel.ResumeLayout(false);
            this.BottomPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        public System.Windows.Forms.TableLayoutPanel MainPanel;
        private System.Windows.Forms.ToolStripMenuItem configuraçõesToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel TopPanel;
        private System.Windows.Forms.TableLayoutPanel BottomPanel;
        public Gecko.GeckoWebBrowser geckoWebBrowser1;
        public Gecko.GeckoWebBrowser geckoWebBrowser2;
        public Gecko.GeckoWebBrowser geckoWebBrowser5;
        public Gecko.GeckoWebBrowser geckoWebBrowser3;
        public Gecko.GeckoWebBrowser geckoWebBrowser4;
    }
}

