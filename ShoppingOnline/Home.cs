﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ShoppingOnline
{
    public partial class Home : Form
    {
        public static string topic;
        public static string filenameclick;
        public static PictureBox pbClick;
        public Home()
        {
            InitializeComponent();
            Functions.Connect();
            foreach (string topic in topic_list)
                loadData(topic);
            //Functions.RunSQL("delete from SANPHAMDAXEM");
        }

        string[] topic_list = { "meat", "vegetable", "noodle", "cake", "drink" };

        private void Home_Load(object sender, EventArgs e)
        {

        }

        void loadData(string topic)
        {
            string[] files = Directory.GetFiles(topic);
            foreach (string file in files)
            {
                int index = file.IndexOf("\\") + 1;
                string path = file.Substring(index, file.Length - index - 4);

                Panel p = new Panel();
                p.Size = new Size(220, 250);
                // Product Image
                Panel pn = new Panel();
                pn.Size = new Size(220, 165);
                pn.Location = new Point(0, 0);
                PictureBox pb = new PictureBox();
                pb.Size = new Size(220, 165);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackgroundImage = Image.FromFile(file);
                pb.Tag = file;
                pb.Cursor = Cursors.Hand;
                pb.MouseClick += new MouseEventHandler(this._click);
                pn.Controls.Add(pb);
                // Name label
                Label name_lb = new Label();
                name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                name_lb.TextAlign = ContentAlignment.MiddleCenter;
                name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                name_lb.AutoSize = false;
                name_lb.Width = 240;
                name_lb.Location = new Point(0, 175);
                name_lb.MouseClick += new MouseEventHandler(this._lbClick);
                // Price label
                Label price_lb = new Label();
                price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select GiaSP from SANPHAM where TenFile = N'" + path + "'")) + " đồng";
                price_lb.TextAlign = ContentAlignment.MiddleCenter;
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                price_lb.ForeColor = Color.FromArgb(193, 0, 23);
                price_lb.AutoSize = false;
                price_lb.Width = 240;
                price_lb.Location = new Point(0, 200);
                price_lb.MouseClick += new MouseEventHandler(this._lbClick);
                // Add to panel
                p.Controls.Add(pn);
                p.Controls.Add(name_lb);
                p.Controls.Add(price_lb);
                p.BackColor = Color.White;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.MouseClick += new MouseEventHandler(this._pnClick);
                p.Cursor = Cursors.Hand;
                flowLayoutPanel.Controls.Add(p);
            }
        }

        void _click(object sender, MouseEventArgs e)
        {
            pbClick = (PictureBox)sender;
            string temp = (string)pbClick.Tag;
            int index = temp.IndexOf("\\") + 1;
            string loaispclick = temp.Substring(0, index - 1);
            filenameclick = temp.Substring(index, temp.Length - index - 4);
            if (Convert.ToInt32(Functions.GetFieldValues(
                "select COUNT(FolderFile) from SANPHAMDAXEM where FolderFile = N'" + temp + "'")) == 0)
                Functions.RunSQL("insert into SANPHAMDAXEM values(N'" + temp + "')");
            ProductInfo frm = new ProductInfo();
            frm.ShowDialog();
        }

        void _lbClick(object sender, MouseEventArgs e)
        {
            Control lbClick = (Control)sender;
            Control pn = lbClick.Parent;
            Control child_pn = pn.Controls[0];
            Control pb = child_pn.Controls[0];
            this._click(pb, e);
        }

        void _pnClick(object sender, MouseEventArgs e)
        {
            Control pn = (Control)sender;
            Control child_pn = pn.Controls[0];
            Control pb = child_pn.Controls[0];
            this._click(pb, e);
        }

        private void btnThit_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData("meat");
        }
        private void btnRau_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData("vegetable");
        }
        private void btnMi_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData("noodle");
        }
        private void btnBanh_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData("cake");
        }
        private void btnNuoc_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            loadData("drink");
        }

        private void pbSearchIcon_Click(object sender, EventArgs e)
        {
            string search_string = txtTimSP.Text;
            string[] search_word_list = search_string.Split(' ');

            if (search_string.Trim().Length == 0)
            {
                MessageBox.Show("Hãy nhập tên sản phẩm");
                return;
            }

            flowLayoutPanel.Controls.Clear();
            foreach (string topic in topic_list)
            {
                string[] files = Directory.GetFiles(topic);
                foreach (string file in files)
                {
                    int index = file.IndexOf("\\") + 1;
                    string path = file.Substring(index, file.Length - index - 4);
                    string tensp = Convert.ToString(Functions.GetFieldValues(
                            "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                    bool flag = true;

                    foreach (string i in search_word_list)
                        if (tensp.ToUpper().IndexOf(i.ToUpper()) == -1)
                            flag = false;

                    if (flag)
                    {
                        Panel p = new Panel();
                        p.Size = new Size(220, 250);
                        // Product Image
                        Panel pn = new Panel();
                        pn.Size = new Size(220, 165);
                        pn.Location = new Point(0, 0);
                        PictureBox pb = new PictureBox();
                        pb.Size = new Size(220, 165);
                        pb.BackgroundImageLayout = ImageLayout.Zoom;
                        pb.BackgroundImage = Image.FromFile(file);
                        pb.Tag = file;
                        pb.Cursor = Cursors.Hand;
                        pb.MouseClick += new MouseEventHandler(this._click);
                        pn.Controls.Add(pb);
                        // Name label
                        Label name_lb = new Label();
                        name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                            "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                        name_lb.TextAlign = ContentAlignment.MiddleCenter;
                        name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                        name_lb.AutoSize = false;
                        name_lb.Width = 240;
                        name_lb.Location = new Point(0, 175);
                        name_lb.MouseClick += new MouseEventHandler(this._lbClick);
                        // Price label
                        Label price_lb = new Label();
                        price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                            "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                        price_lb.TextAlign = ContentAlignment.MiddleCenter;
                        price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                        price_lb.ForeColor = Color.FromArgb(193, 0, 23);
                        price_lb.AutoSize = false;
                        price_lb.Width = 240;
                        price_lb.Location = new Point(0, 200);
                        price_lb.MouseClick += new MouseEventHandler(this._lbClick);
                        // Add to panel
                        p.Controls.Add(pn);
                        p.Controls.Add(name_lb);
                        p.Controls.Add(price_lb);
                        p.BorderStyle = BorderStyle.FixedSingle;
                        p.BackColor = Color.White;
                        p.MouseClick += new MouseEventHandler(this._pnClick);
                        flowLayoutPanel.Controls.Add(p);
                    }
                }
            }
        }
        private void txtTimSP_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string search_string = txtTimSP.Text;
                string[] search_word_list = search_string.Split(' ');

                if (search_string.Trim().Length == 0)
                {
                    MessageBox.Show("Hãy nhập tên sản phẩm");
                    return;
                }

                flowLayoutPanel.Controls.Clear();
                foreach (string topic in topic_list)
                {
                    string[] files = Directory.GetFiles(topic);
                    foreach (string file in files)
                    {
                        int index = file.IndexOf("\\") + 1;
                        string path = file.Substring(index, file.Length - index - 4);
                        string tensp = Convert.ToString(Functions.GetFieldValues(
                                "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                        bool flag = true;

                        foreach (string i in search_word_list)
                            if (tensp.ToUpper().IndexOf(i.ToUpper()) == -1)
                                flag = false;

                        if (flag)
                        {
                            Panel p = new Panel();
                            p.Size = new Size(220, 250);
                            // Product Image
                            Panel pn = new Panel();
                            pn.Size = new Size(220, 165);
                            pn.Location = new Point(0, 0);
                            PictureBox pb = new PictureBox();
                            pb.Size = new Size(220, 165);
                            pb.BackgroundImageLayout = ImageLayout.Zoom;
                            pb.BackgroundImage = Image.FromFile(file);
                            pb.Tag = file;
                            pb.Cursor = Cursors.Hand;
                            pb.MouseClick += new MouseEventHandler(this._click);
                            pn.Controls.Add(pb);
                            // Name label
                            Label name_lb = new Label();
                            name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                                "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                            name_lb.TextAlign = ContentAlignment.MiddleCenter;
                            name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                            name_lb.AutoSize = false;
                            name_lb.Width = 240;
                            name_lb.Location = new Point(0, 175);
                            name_lb.MouseClick += new MouseEventHandler(this._lbClick);
                            // Price label
                            Label price_lb = new Label();
                            price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                                "select GiaSP from SANPHAM where TenFile = N'" + path + "'"));
                            price_lb.TextAlign = ContentAlignment.MiddleCenter;
                            price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                            price_lb.ForeColor = Color.FromArgb(193, 0, 23);
                            price_lb.AutoSize = false;
                            price_lb.Width = 240;
                            price_lb.Location = new Point(0, 200);
                            price_lb.MouseClick += new MouseEventHandler(this._lbClick);
                            // Add to panel
                            p.Controls.Add(pn);
                            p.Controls.Add(name_lb);
                            p.Controls.Add(price_lb);
                            p.BorderStyle = BorderStyle.FixedSingle;
                            p.BackColor = Color.White;
                            p.MouseClick += new MouseEventHandler(this._pnClick);
                            flowLayoutPanel.Controls.Add(p);
                        }
                    }
                }
            }
        }

        private void pbGioHang_Click(object sender, EventArgs e)
        {
            Cart frm = new Cart();
            frm.ShowDialog();
        }

        private void btnSPDaXem_Click(object sender, EventArgs e)
        {
            flowLayoutPanel.Controls.Clear();
            List<string> files = Functions.GetFieldValuesList("select FolderFile from SANPHAMDAXEM");
            foreach (string file in files)
            {
                int index = file.IndexOf("\\") + 1;
                string path = file.Substring(index, file.Length - index - 4);

                Panel p = new Panel();
                p.Size = new Size(220, 250);
                // Product Image
                Panel pn = new Panel();
                pn.Size = new Size(220, 165);
                pn.Location = new Point(0, 0);
                PictureBox pb = new PictureBox();
                pb.Size = new Size(220, 165);
                pb.BackgroundImageLayout = ImageLayout.Zoom;
                pb.BackgroundImage = Image.FromFile(file);
                pb.Tag = file;
                pb.Cursor = Cursors.Hand;
                pb.MouseClick += new MouseEventHandler(this._click);
                pn.Controls.Add(pb);
                // Name label
                Label name_lb = new Label();
                name_lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select TenSP from SANPHAM where TenFile = N'" + path + "'"));
                name_lb.TextAlign = ContentAlignment.MiddleCenter;
                name_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                name_lb.AutoSize = false;
                name_lb.Width = 240;
                name_lb.Location = new Point(0, 175);
                name_lb.MouseClick += new MouseEventHandler(this._lbClick);
                // Price label
                Label price_lb = new Label();
                price_lb.Text = Convert.ToString(Functions.GetFieldValues(
                    "select GiaSP from SANPHAM where TenFile = N'" + path + "'")) + " đồng";
                price_lb.TextAlign = ContentAlignment.MiddleCenter;
                price_lb.Font = new Font("Arial", 12, FontStyle.Regular);
                price_lb.ForeColor = Color.FromArgb(193, 0, 23);
                price_lb.AutoSize = false;
                price_lb.Width = 240;
                price_lb.Location = new Point(0, 200);
                price_lb.MouseClick += new MouseEventHandler(this._lbClick);
                // Add to panel
                p.Controls.Add(pn);
                p.Controls.Add(name_lb);
                p.Controls.Add(price_lb);
                p.BackColor = Color.White;
                p.BorderStyle = BorderStyle.FixedSingle;
                p.MouseClick += new MouseEventHandler(this._pnClick);
                p.Cursor = Cursors.Hand;
                flowLayoutPanel.Controls.Add(p);
            }
        }
    }
}