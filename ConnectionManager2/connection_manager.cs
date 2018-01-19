using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Net.NetworkInformation;

using System.Xml;
using System.Xml.Schema;
using System.Xml.XPath;
using SimpleWifi;



namespace ConnectionManager2
{
    public partial class connection_manager : Form
    {

        private static Wifi wifi;

        public connection_manager()
        {
            InitializeComponent();
            welcome welcome = new welcome();
            welcome.Close();
        }

        private void connection_manager_Load(object sender, EventArgs e)
        {
            
        }        

        private void connect_button_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0 && password_textBox.Text.Length > 0 && true)
            {
                ListViewItem selectedItem = listView1.SelectedItems[0];

                AccessPoint ap = (AccessPoint)selectedItem.Tag;

                if (ConnectToWifi(ap, password_textBox.Text))
                {
                    password_label.Text = "You are now connected to the internet";

                }
                else
                {
                    password_label.Text = "Something went wrong try again";
                }
            }
            else
            {
                password_label.Text = "Please select a network";
            }
        }

        private bool ConnectToWifi(AccessPoint ap, string password)
        {
            AuthRequest authRequest = new AuthRequest(ap);
            authRequest.Password = password_textBox.ToString();

            return ap.Connect(authRequest);

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void password_label_Click(object sender, EventArgs e)
        {

        }

        private void password_textBox_TextChanged(object sender, EventArgs e)
        {

        }        

        private void wifi_connect_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            if (wifi_connect_checkBox.Checked)
            {            

                wifi = new Wifi();
                List<AccessPoint> aps = wifi.GetAccessPoints();              

                //check if there is an adapter active
                if (aps.Count > 0 && wifi_connect_checkBox.Checked)
                {
                    password_label.Text = "Select an Accespoint!";

                    foreach (AccessPoint ap in aps)
                    {
                        ListViewItem LvItem = new ListViewItem(ap.Name);
                        LvItem.SubItems.Add(ap.SignalStrength + "%");
                        LvItem.Tag = ap;
                        LvItem.SubItems.Add(ap.IsConnected + "!");
                        //add somelayout to keep the list item selected
                        LvItem.SubItems.Add(ap.IsSecure + "!");
                        listView1.Items.Add(LvItem);
                        if(LvItem.Selected == true){
                            password_label.Text = "";
                        }
                    }
                }
                else
                {
                    password_label.Text = "Please check internet adaptor status";                    
                }
            }
            else
            {
                password_label.Text = "Please check an connection method";
            }
        }







        private void mobile_connect_checkBox_CheckedChanged(object sender, EventArgs e)
        {
            //get connected to UMTS mobile broadband
            if (mobile_connect_checkBox.Checked)
            {
                wifi_connect_checkBox.Checked = false;

                if (wifi_connect_checkBox.Checked)
                {

                    //BroadbandDevice broadband = new BroadbandDevice();
                    //List<BroadbandDevice> aps = MobileBroadband.BroadbandDevice;

                    //check if there is an adapter active
                    //if (aps.Count > 0 && wifi_connect_checkBox.Checked)
                    //{
                    //password_label.Text = "Select an Accespoint!";

                    //foreach (AccessPoint ap in aps)
                    // {
                    //ListViewItem LvItem = new ListViewItem(ap.Name);
                    //LvItem.SubItems.Add(ap.SignalStrength + "%");
                    ////LvItem.Tag = ap;
                    //LvItem.SubItems.Add(ap.IsConnected + "!");
                    ///add somelayout to keep the list item selected
                    //LvItem.SubItems.Add(ap.IsSecure + "!");
                    //listView1.Items.Add(LvItem);
                    //}
                    //}
                    //else
                    //{
                    //    password_label.Text = "Please check internet adaptor status";
                    // }
                    //}
                    //else
                    // {
                    //     password_label.Text = "Please check an connection method";
                    //}
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
