using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitFlyerOrderApp
{
    public partial class AppForm : Form
    {
        private Point mousePoint;
        
        public AppForm()
        {
            MouseDown += Form_MouseDown;
            MouseMove += Form_MouseMove;
        }

        protected void Form_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                //位置を記憶する
                mousePoint = new Point(e.X, e.Y);
            }
        }
        protected void Form_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Left += e.X - mousePoint.X;
                Top += e.Y - mousePoint.Y;
            }
        }

        public static List<T> GetAllControls<T>(Control top) where T : Control
        {
            List<T> buf = new List<T>();
            foreach (Control ctrl in top.Controls)
            {
                if (ctrl is T) buf.Add((T)ctrl);
                buf.AddRange(GetAllControls<T>(ctrl));
            }
            return buf;
        }

        protected void ApplyMouseMove<T>(Control top) where T : Control
        {
            var labelList = GetAllControls<T>(top);
            labelList.ForEach(ctl =>
            {
                ctl.MouseMove += Form_MouseMove;
                ctl.MouseDown += Form_MouseDown;
            });
        }

        private bool openForm = false;
        public bool IsOpen() => openForm;

        public new void Show()
        {
            openForm = true;
            base.Show();
        }

        public new void Hide()
        {
            openForm = false;
            base.Hide();
        }

        public new void Close()
        {
            openForm = false;
            base.Close();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AppForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AppForm";
            this.ShowIcon = false;
            this.TopMost = true;
            this.ResumeLayout(false);
        }
    }
}
