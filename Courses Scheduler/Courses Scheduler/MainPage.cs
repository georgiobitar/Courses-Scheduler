using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Courses_Scheduler
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            List<string> courses = new List<string>
            {
                "Circuit Logique","Electro Technique","Electro Magnetism","OOP","Systeme Lineaire"
            };
            CourseCB.DataSource = courses;
            DataGridViewLinkColumn Link = new DataGridViewLinkColumn();
            Grid.Columns.Add(Link);
            Link.HeaderText = "Link Data";
            Link.Name = "Http://google.com";
            Link.Text = "Http://google.com";
            Link.UseColumnTextForLinkValue = true;

            Grid.Rows.Add("Magenito","2/2/2020","3/2/2020","www.outlook.com");
            Grid.Rows.Add("Magenito", "2/2/2020", "3/2/2020", "www.google.com");

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CloseIcon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Maximize_Click(object sender, EventArgs e)
        {

        }

        private void Category_Click(object sender, EventArgs e)
        {

        }

        private void CategoryCB_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")] 
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]   
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void ScheduleBT_Click(object sender, EventArgs e)
        {
            Schedule S = new Schedule();
            S.Show();
        }

        private void RefreshBT_Click(object sender, EventArgs e)
        {
           // Grid.DataSource = CLASS.GetData(CourseCB.Text);
        }
    }
}
