using CefSharp;
using System;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Windows.Forms;


/**
 * Real - 127.0.0.1 bankwebsite.com
 * Fake - 127.0.0.1 bаnkwebsite.com
 */

namespace VulSimpleBrowser
{
    public partial class WindowForm : Form
    {
        public WindowForm()
        {
            InitializeComponent();
            
            // Prevent black band on web browser :
            Cef.EnableHighDPISupport();


            // Open as maximised window :
            //WindowState = FormWindowState.Maximized;


            var bitness = RuntimeInformation.ProcessArchitecture.ToString().ToLowerInvariant();
            var version = String.Format("Chromium: {0}, CEF: {1}, CefSharp: {2}, Environment: {3}", Cef.ChromiumVersion, Cef.CefVersion, Cef.CefSharpVersion, bitness);
            

            // Only perform layout when control has completly finished resizing
            ResizeBegin += (s, e) => SuspendLayout();
            ResizeEnd   += (s, e) => ResumeLayout(true);
        }



        /*************************************************************************
        * BUTTON EVENT - Search
        *************************************************************************/
        private void btn_search_Click(object sender, EventArgs e)
        {
            // Get webpage address :
            string browser_url = box_search_address.Text.Trim();


            // ---------------------------------------------------------------
            // UNSAFE NAVIGATION
            // ---------------------------------------------------------------
            // navigate_unsafely(browser_url);

            // ---------------------------------------------------------------
            // SAFE NAVIGATION (PUNY-CODE)
            // ---------------------------------------------------------------
            navigate_safely(browser_url);

        }



        /*************************************************************************
        * FUNCTION - Navigate UnSafely
        *************************************************************************/
        private void navigate_unsafely(string browser_url)
        {
            string port = "";
            if (browser_url.Equals("bankwebsite.com"))
            {
                port = ":4400";
            }

            if (browser_url.Equals("bаnkwebsite.com"))
            {
                port = ":4500";
            }

            box_WebBrowserChrome.Load(browser_url + port);
        }


        /*************************************************************************
        * FUNCTION - Navigate Safely
        *************************************************************************/
        private void navigate_safely(string browser_url)
        {
            string port = "";
            if(browser_url.Equals("bankwebsite.com"))
            {
                port = ":4400";
            }

            if (browser_url.Equals("bаnkwebsite.com"))
            {
                port = ":4500";
            }


            // Navigate to page :
            box_WebBrowserChrome.Load(browser_url + port);

            try
            {
                // Use puny-code to convert unicode chars to ascii :
                IdnMapping idn = new IdnMapping();
                browser_url = idn.GetAscii(browser_url);

                // Replace address with the punycode for the user to see and check :
                box_search_address.Text = browser_url;
            }
            catch (ArgumentException)
            {
                Console.WriteLine("{0} is not a valid domain name.", browser_url);
            }

        }


        /*************************************************************************
        * BUTTON EVENT - Go forward
        *************************************************************************/
        private void btn_forward_Click(object sender, EventArgs e)
        {
            box_WebBrowserChrome.Forward();
        }



        /*************************************************************************
        * BUTTON EVENT - Go Back
        *************************************************************************/
        private void btn_back_Click(object sender, EventArgs e)
        {
            box_WebBrowserChrome.Back();
        }



        /*************************************************************************
        * BUTTON EVENT - Refresh
        *************************************************************************/
        private void btn_refresh_Click(object sender, EventArgs e)
        {
            box_WebBrowserChrome.Refresh();
            box_WebBrowserChrome.Reload();
        }



        /*************************************************************************
        * KEY-DOWN EVENT - Press Enter in textbox
        *************************************************************************/
        private void box_search_address_KeyDown(object sender, KeyEventArgs e)
        {
            // Navigate unsafely if the user presses enter :
            if(e.KeyCode.Equals(Keys.Enter))
            {
                // Get webpage address :
                string browser_url = box_search_address.Text.Trim();


                // ---------------------------------------------------------------
                // UNSAFE NAVIGATION
                // ---------------------------------------------------------------
                //navigate_unsafely(browser_url);

                // ---------------------------------------------------------------
                // SAFE NAVIGATION (PUNY-CODE)
                // ---------------------------------------------------------------
                navigate_safely(browser_url);
            }
        }


    } // class
} // namespace




/************************************************************************************************************************************
* REFERENCES:
* 
* https://github.com/cefsharp/CefSharp
* https://learn.microsoft.com/en-us/dotnet/api/system.globalization.idnmapping.getascii?redirectedfrom=MSDN&view=net-6.0#overloads 
* https://github.com/cefsharp/CefSharp/wiki/General-Usage#high-dpi-displayssupport
* https://github.com/cefsharp/CefSharp/issues/1757
* https://www.codeproject.com/Articles/52752/Updating-Your-Form-from-Another-Thread-without-Cre
* 
*************************************************************************************************************************************/
