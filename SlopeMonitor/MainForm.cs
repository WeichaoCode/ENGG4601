using SlopeMonitor.Common;
using SlopeMonitor.UserControlTools;
using SlopeMonitor.UserControlTools.NetworkTool;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// This is the Mainform and the software should run from this page
/// </summary>
namespace SlopeMonitor
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //panel3.Controls.Add(new Visulization());
        }
        // Use these codes to resize the window 
        [DllImport("user32")]
        private static extern int SendMessage(IntPtr hwnd, int wMsg, int wParam, IntPtr lParam);
        private const int WM_SETREDRAW = 0xB;
        /**
         * Handles the Load event of the MainForm.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the MainForm is loaded. It performs the following actions:
         * Attaches an event handler to the Resize event of the MainForm, using the MainForm_Resize method.
         * Sets the initial values of the AutoSizeChange object's X and Y properties to the current 
         * width and height of the MainForm, respectively.
         * Calls the setTag method of the AutoSizeChange object, passing the MainForm as an argument.
         * Invokes the MainForm_Resize method to handle the initial resizing of the MainForm.
         * Note: The AutoSizeChange object and the MainForm_Resize method are assumed to be defined 
         * and accessible within the scope of this method.
         */
        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Resize += new EventHandler(MainForm_Resize);
            AutoSizeChange.X = this.Width;
            AutoSizeChange.Y = this.Height;
            AutoSizeChange.setTag(this);
            MainForm_Resize(new object(), new EventArgs());
        }
        /**
         * Handles the Resize event of the MainForm.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when the MainForm is resized. It 
         * performs the following actions:
         * Sends a Windows message to the MainForm to suspend drawing while 
         * resizing, using the SendMessage function and the WM_SETREDRAW message.
         * Calculates the ratio of the new width and height of the MainForm to the
         * initial width and height stored in the AutoSizeChange object.
         * Calls the setControls method of the AutoSizeChange object, passing the 
         * new width and height ratios and the MainForm as arguments.
         * This method adjusts the size and position of the controls on the MainForm 
         * based on the resizing ratio.
         * Sends a Windows message to the MainForm to resume drawing, using the SendMessage
         * function and the WM_SETREDRAW message.
         * Invalidates the MainForm, causing it to be redrawn with the updated control positions and sizes.
         * Note: The AutoSizeChange object, SendMessage function, WM_SETREDRAW message, and setControls
         * method are assumed to be defined and accessible within the scope of this method.
         */
        private void MainForm_Resize(object sender, EventArgs e)
        {
            SendMessage(this.Handle, WM_SETREDRAW, 0, IntPtr.Zero);
            float newx = (this.Width) / AutoSizeChange.X;
            float newy = (this.Height) / AutoSizeChange.Y;
            AutoSizeChange.setControls(newx, newy, this);
            SendMessage(this.Handle, WM_SETREDRAW, 1, IntPtr.Zero);
            this.Invalidate(true);
        }
        /**
         * Handles the Click event of Button2.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when Button2 is clicked. It performs the following actions:
         * Shows the selected profile by adding a new instance of the Visulization control to 
         * the panel3 control.
         * Brings the added Visulization control to the front, making it visible.
         * Note: The Visulization control and panel3 control are assumed to be defined and 
         * accessible within the scope of this method.
         */
        private void button2_Click(object sender, EventArgs e)
        {
            // Show the selected profile
            panel3.Controls.Add(new Visulization());
            panel3.Controls.Find("Visulization", false)[0].BringToFront();
        }
        /**
         * Handles the Click event of Button5.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when Button5 is clicked. It performs the following actions:
         * Creates a new instance of the Network form.
         * Displays the Network form by calling the Show method.
         * Note: The Network form is assumed to be defined and accessible within the scope of this method.
         */
        private void button5_Click(object sender, EventArgs e)
        {
            Network network = new Network();
            network.Show();
        }
        /**
         * Handles the Click event of Button3.
         * @param sender The object that raised the event.
         * @param e An EventArgs object that contains the event data.
         * This method is triggered when Button3 is clicked. It performs the following actions:
         * Adds a new instance of the MapPosition control to the panel3 control.
         * Brings the added MapPosition control to the front, making it visible.
         * Note: The MapPosition control and panel3 control are assumed to be defined and 
         * accessible within the scope of this method.
         */
        private void button3_Click(object sender, EventArgs e)
        {
            panel3.Controls.Add(new MapPosition());
            panel3.Controls.Find("MapPosition", false)[0].BringToFront();
        }
    }
}
