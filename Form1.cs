using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tuan3_ThemXoaSua
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lvSV.FullRowSelect = true;
        }


        private void lvSV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count > 0)
            {
                textBox1.Text = lvSV.SelectedItems[0].SubItems[0].Text;
                textBox2.Text = lvSV.SelectedItems[0].SubItems[1].Text;
                textBox3.Text = lvSV.SelectedItems[0].SubItems[2].Text;
            }
   
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            {
                ListViewItem item = new ListViewItem();

                item.Text = textBox1.Text;
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = textBox2.Text });
                item.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = textBox3.Text });

                lvSV.Items.Add(item);

            }
        }

        private void btSua_Click(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count > 0)
            {                     
                lvSV.SelectedItems[0].SubItems[0].Text = textBox1.Text;
                lvSV.SelectedItems[0].SubItems[1].Text = textBox2.Text;
                lvSV.SelectedItems[0].SubItems[3].Text = textBox3.Text;                     
                
            }
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            if (lvSV.SelectedItems.Count > 0)
            {
                lvSV.Items.Remove(lvSV.SelectedItems[0]);
            }
           
        }
    }
}
