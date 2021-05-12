using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FleetUIv1
{
    public partial class ViewServiceHistory : Form
    {
        List<Record> r = new List<Record>();
        public ViewServiceHistory(List<Record> r1)
        {
            this.r = r1;
            InitializeComponent();
            LoadViewHistory();
        }
        public void LoadViewHistory()
        {
            foreach (Record x in this.r)
            {
                ListViewItem re = new ListViewItem();
                re.Text = x.TypeOfService.ToString();
                re.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = x.Date.ToString() });
                re.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = x.Garage });
                re.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = x.Price.ToString() });
                re.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = x.MileAge.ToString() });
                listView1.Items.Add(re);
            }
            
        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
