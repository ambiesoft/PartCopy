﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace PartCopy
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void txt_DragEnter(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void txt_DragOver(object sender, DragEventArgs e)
        {
            if(e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void txtSource_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object[] o = (object[])e.Data.GetData(DataFormats.FileDrop);
                txtSource.Text = o[0].ToString();

            }

        }

        private void txtDest_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                object[] o = (object[])e.Data.GetData(DataFormats.FileDrop);
                txtDest.Text = o[0].ToString();

            }
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                System.IO.FileStream fsr = new System.IO.FileStream(
                    txtSource.Text,
                    System.IO.FileMode.Open,
                    System.IO.FileAccess.Read);

                int startbyte = (int)udStart.Value;
                int endbyte = (int)udEnd.Value;
                int size = endbyte - startbyte;

                if (size <= 0)
                {
                    MessageBox.Show("Size is zero or minus.",
                        Application.ProductName,
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                byte[] bs = new byte[size];

                fsr.Read(bs, startbyte, size);
                fsr.Close();

                FileStream fsw = new FileStream(
                    txtDest.Text,
                    FileMode.Open,
                    FileAccess.Write);

                fsw.Write(bs, startbyte, size);
                fsw.Close();

                UpdateTitle(size);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,
                    Application.ProductName,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                Cursor.Current = Cursors.Default;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string orgTitle;
        private void FormMain_Load(object sender, EventArgs e)
        {
            orgTitle = this.Text;
        }

        private void UpdateTitle(int size)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(orgTitle);
            sb.Append(" ");
            sb.Append(size);
            sb.Append(" bytes written");

            this.Text = sb.ToString();
        }

    }
}
