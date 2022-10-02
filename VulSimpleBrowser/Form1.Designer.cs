namespace VulSimpleBrowser
{
    partial class WindowForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowForm));
            this.box_search_address = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_forward = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.box_WebBrowserChrome = new CefSharp.WinForms.ChromiumWebBrowser();
            this.SuspendLayout();
            // 
            // box_search_address
            // 
            this.box_search_address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_search_address.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_search_address.Location = new System.Drawing.Point(319, 16);
            this.box_search_address.Name = "box_search_address";
            this.box_search_address.Size = new System.Drawing.Size(1442, 50);
            this.box_search_address.TabIndex = 0;
            this.box_search_address.Text = "http://bаnkwebsite.com:4400";
            this.box_search_address.KeyDown += new System.Windows.Forms.KeyEventHandler(this.box_search_address_KeyDown);
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(174, 16);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(130, 49);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(12, 16);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(48, 49);
            this.btn_back.TabIndex = 2;
            this.btn_back.Text = "<";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_forward
            // 
            this.btn_forward.Location = new System.Drawing.Point(66, 16);
            this.btn_forward.Name = "btn_forward";
            this.btn_forward.Size = new System.Drawing.Size(48, 49);
            this.btn_forward.TabIndex = 3;
            this.btn_forward.Text = ">";
            this.btn_forward.UseVisualStyleBackColor = true;
            this.btn_forward.Click += new System.EventHandler(this.btn_forward_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(120, 16);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(48, 49);
            this.btn_refresh.TabIndex = 4;
            this.btn_refresh.Text = "⟳";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // box_WebBrowserChrome
            // 
            this.box_WebBrowserChrome.ActivateBrowserOnCreation = false;
            this.box_WebBrowserChrome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.box_WebBrowserChrome.Location = new System.Drawing.Point(12, 88);
            this.box_WebBrowserChrome.Name = "box_WebBrowserChrome";
            this.box_WebBrowserChrome.Size = new System.Drawing.Size(1749, 1048);
            this.box_WebBrowserChrome.TabIndex = 6;

            // WindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1773, 1148);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_forward);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.box_search_address);
            this.Controls.Add(this.box_WebBrowserChrome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WindowForm";
            this.Text = "  Vulnerable Browser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox box_search_address;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_forward;
        private System.Windows.Forms.Button btn_refresh;
        private CefSharp.WinForms.ChromiumWebBrowser box_WebBrowserChrome;
    }
}

