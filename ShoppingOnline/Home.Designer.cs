﻿namespace ShoppingOnline
{
    partial class Home
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
            this.txtTimSP = new System.Windows.Forms.TextBox();
            this.lbOrder = new System.Windows.Forms.Label();
            this.btnSPDaXem = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnThit = new System.Windows.Forms.Button();
            this.btnRau = new System.Windows.Forms.Button();
            this.btnNuoc = new System.Windows.Forms.Button();
            this.btnBanh = new System.Windows.Forms.Button();
            this.btnMi = new System.Windows.Forms.Button();
            this.pbGioHang = new System.Windows.Forms.PictureBox();
            this.pbSearchIcon = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTimSP
            // 
            this.txtTimSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTimSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTimSP.ForeColor = System.Drawing.SystemColors.InfoText;
            this.txtTimSP.Location = new System.Drawing.Point(9, 11);
            this.txtTimSP.Name = "txtTimSP";
            this.txtTimSP.Size = new System.Drawing.Size(463, 27);
            this.txtTimSP.TabIndex = 5;
            this.txtTimSP.TabStop = false;
            this.txtTimSP.Enter += new System.EventHandler(this.txtTimSP_Enter);
            this.txtTimSP.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtTimSP_KeyUp);
            this.txtTimSP.Leave += new System.EventHandler(this.txtTimSP_Leave);
            // 
            // lbOrder
            // 
            this.lbOrder.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOrder.ForeColor = System.Drawing.SystemColors.Window;
            this.lbOrder.Location = new System.Drawing.Point(988, 20);
            this.lbOrder.Name = "lbOrder";
            this.lbOrder.Size = new System.Drawing.Size(125, 43);
            this.lbOrder.TabIndex = 6;
            this.lbOrder.Text = "Đơn hàng";
            this.lbOrder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbOrder.Click += new System.EventHandler(this.lbOrder_Click);
            // 
            // btnSPDaXem
            // 
            this.btnSPDaXem.BackColor = System.Drawing.SystemColors.Control;
            this.btnSPDaXem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSPDaXem.FlatAppearance.BorderSize = 0;
            this.btnSPDaXem.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnSPDaXem.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSPDaXem.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnSPDaXem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSPDaXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSPDaXem.ForeColor = System.Drawing.Color.Black;
            this.btnSPDaXem.Location = new System.Drawing.Point(12, 591);
            this.btnSPDaXem.Name = "btnSPDaXem";
            this.btnSPDaXem.Size = new System.Drawing.Size(375, 65);
            this.btnSPDaXem.TabIndex = 7;
            this.btnSPDaXem.TabStop = false;
            this.btnSPDaXem.Text = "Sản phẩm đã xem";
            this.btnSPDaXem.UseVisualStyleBackColor = false;
            this.btnSPDaXem.Click += new System.EventHandler(this.btnSPDaXem_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoScroll = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(395, 114);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(933, 612);
            this.flowLayoutPanel.TabIndex = 11;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pbGioHang);
            this.panel2.Controls.Add(this.lbOrder);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1316, 83);
            this.panel2.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(32, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(305, 83);
            this.label4.TabIndex = 16;
            this.label4.Text = "Grocery";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.Controls.Add(this.txtTimSP);
            this.panel3.Controls.Add(this.pbSearchIcon);
            this.panel3.Location = new System.Drawing.Point(383, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(559, 50);
            this.panel3.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 65);
            this.label1.TabIndex = 20;
            this.label1.Text = "MENU";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThit
            // 
            this.btnThit.BackColor = System.Drawing.SystemColors.Control;
            this.btnThit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThit.FlatAppearance.BorderSize = 0;
            this.btnThit.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnThit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThit.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnThit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThit.ForeColor = System.Drawing.Color.Black;
            this.btnThit.Image = global::ShoppingOnline.Properties.Resources._580b57fbd9996e24bc43c0cd;
            this.btnThit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThit.Location = new System.Drawing.Point(12, 179);
            this.btnThit.Name = "btnThit";
            this.btnThit.Size = new System.Drawing.Size(375, 65);
            this.btnThit.TabIndex = 15;
            this.btnThit.TabStop = false;
            this.btnThit.Text = "Thịt, cá, trứng, hải sản";
            this.btnThit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThit.UseVisualStyleBackColor = false;
            this.btnThit.Click += new System.EventHandler(this.btnThit_Click);
            // 
            // btnRau
            // 
            this.btnRau.BackColor = System.Drawing.SystemColors.Control;
            this.btnRau.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRau.FlatAppearance.BorderSize = 0;
            this.btnRau.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnRau.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRau.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnRau.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRau.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRau.ForeColor = System.Drawing.Color.Black;
            this.btnRau.Image = global::ShoppingOnline.Properties.Resources._585ea83dcb11b227491c3546;
            this.btnRau.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRau.Location = new System.Drawing.Point(12, 244);
            this.btnRau.Name = "btnRau";
            this.btnRau.Size = new System.Drawing.Size(375, 65);
            this.btnRau.TabIndex = 16;
            this.btnRau.TabStop = false;
            this.btnRau.Text = "Rau, củ, trái cây";
            this.btnRau.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRau.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRau.UseVisualStyleBackColor = false;
            this.btnRau.Click += new System.EventHandler(this.btnRau_Click);
            // 
            // btnNuoc
            // 
            this.btnNuoc.BackColor = System.Drawing.SystemColors.Control;
            this.btnNuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuoc.FlatAppearance.BorderSize = 0;
            this.btnNuoc.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnNuoc.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuoc.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNuoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuoc.ForeColor = System.Drawing.Color.Black;
            this.btnNuoc.Image = global::ShoppingOnline.Properties.Resources._587e33a39686194a55adab81;
            this.btnNuoc.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuoc.Location = new System.Drawing.Point(12, 439);
            this.btnNuoc.Name = "btnNuoc";
            this.btnNuoc.Size = new System.Drawing.Size(375, 65);
            this.btnNuoc.TabIndex = 18;
            this.btnNuoc.TabStop = false;
            this.btnNuoc.Text = "Thức uống";
            this.btnNuoc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuoc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuoc.UseVisualStyleBackColor = false;
            this.btnNuoc.Click += new System.EventHandler(this.btnNuoc_Click);
            // 
            // btnBanh
            // 
            this.btnBanh.BackColor = System.Drawing.SystemColors.Control;
            this.btnBanh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBanh.FlatAppearance.BorderSize = 0;
            this.btnBanh.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnBanh.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBanh.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnBanh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBanh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanh.ForeColor = System.Drawing.Color.Black;
            this.btnBanh.Image = global::ShoppingOnline.Properties.Resources._580b57fbd9996e24bc43c0b2;
            this.btnBanh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanh.Location = new System.Drawing.Point(12, 374);
            this.btnBanh.Name = "btnBanh";
            this.btnBanh.Size = new System.Drawing.Size(375, 65);
            this.btnBanh.TabIndex = 19;
            this.btnBanh.TabStop = false;
            this.btnBanh.Text = "Bánh, kẹo";
            this.btnBanh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBanh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBanh.UseVisualStyleBackColor = false;
            this.btnBanh.Click += new System.EventHandler(this.btnBanh_Click);
            // 
            // btnMi
            // 
            this.btnMi.BackColor = System.Drawing.SystemColors.Control;
            this.btnMi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMi.FlatAppearance.BorderSize = 0;
            this.btnMi.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.btnMi.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMi.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMi.ForeColor = System.Drawing.Color.Black;
            this.btnMi.Image = global::ShoppingOnline.Properties.Resources._589c825364b351149f22a826;
            this.btnMi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMi.Location = new System.Drawing.Point(12, 309);
            this.btnMi.Name = "btnMi";
            this.btnMi.Size = new System.Drawing.Size(375, 65);
            this.btnMi.TabIndex = 17;
            this.btnMi.TabStop = false;
            this.btnMi.Text = "Mì, miến, cháo, phở";
            this.btnMi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMi.UseVisualStyleBackColor = false;
            this.btnMi.Click += new System.EventHandler(this.btnMi_Click);
            // 
            // pbGioHang
            // 
            this.pbGioHang.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pbGioHang.BackgroundImage = global::ShoppingOnline.Properties.Resources._353439_basket_purse_shopping_cart_ecommerce_icon;
            this.pbGioHang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbGioHang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbGioHang.Location = new System.Drawing.Point(1140, 20);
            this.pbGioHang.Name = "pbGioHang";
            this.pbGioHang.Size = new System.Drawing.Size(73, 43);
            this.pbGioHang.TabIndex = 15;
            this.pbGioHang.TabStop = false;
            this.pbGioHang.Click += new System.EventHandler(this.pbGioHang_Click);
            // 
            // pbSearchIcon
            // 
            this.pbSearchIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.pbSearchIcon.BackgroundImage = global::ShoppingOnline.Properties.Resources._211817_search_strong_icon;
            this.pbSearchIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pbSearchIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbSearchIcon.Location = new System.Drawing.Point(481, 4);
            this.pbSearchIcon.Name = "pbSearchIcon";
            this.pbSearchIcon.Size = new System.Drawing.Size(73, 43);
            this.pbSearchIcon.TabIndex = 12;
            this.pbSearchIcon.TabStop = false;
            this.pbSearchIcon.Click += new System.EventHandler(this.pbSearchIcon_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(145)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 525);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(375, 65);
            this.label2.TabIndex = 21;
            this.label2.Text = "KHÁC";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlLight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(12, 661);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 65);
            this.button1.TabIndex = 22;
            this.button1.TabStop = false;
            this.button1.Text = "Thoát";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1340, 740);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSPDaXem);
            this.Controls.Add(this.btnThit);
            this.Controls.Add(this.btnRau);
            this.Controls.Add(this.btnNuoc);
            this.Controls.Add(this.btnBanh);
            this.Controls.Add(this.btnMi);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.flowLayoutPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbGioHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSearchIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtTimSP;
        private System.Windows.Forms.Label lbOrder;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.PictureBox pbSearchIcon;
        private System.Windows.Forms.Button btnSPDaXem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pbGioHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnThit;
        private System.Windows.Forms.Button btnRau;
        private System.Windows.Forms.Button btnNuoc;
        private System.Windows.Forms.Button btnBanh;
        private System.Windows.Forms.Button btnMi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}

