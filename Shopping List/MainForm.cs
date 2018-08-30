using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FoodPlanner
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

         private void MainForm_Load(object sender, EventArgs e)
        {
            // Create a new ListView control.
            ListView myListView = new ListView();
            myListView.Bounds = new Rectangle(new Point(10, 10), new Size(300, 200));
            // Set the view to show details.
            myListView.View = View.Details;
            // Allow the user to edit item text.
            myListView.LabelEdit = true;
            // Allow the user to rearrange columns.
            myListView.AllowColumnReorder = true;
            // Display check boxes.
            myListView.CheckBoxes = true;
            // Select the item and subitems when selection is made.
            myListView.FullRowSelect = true;
            // Display grid lines.
            myListView.GridLines = true;
            // Sort the items in the list in ascending order.
            myListView.Sorting = SortOrder.Ascending;

            // Create three items and three sets of subitems for each item.
            ListViewItem item1 = new ListViewItem("item1", 0);
            // Place a check mark next to the item.
            item1.Checked = true;
            item1.SubItems.Add("1");
            item1.SubItems.Add("2");
            item1.SubItems.Add("3");
            ListViewItem item2 = new ListViewItem("item2", 1);
            item2.SubItems.Add("4");
            item2.SubItems.Add("5");
            item2.SubItems.Add("6");
            ListViewItem item3 = new ListViewItem("item3", 0);
            // Place a check mark next to the item.
            item3.Checked = true;
            item3.SubItems.Add("7");
            item3.SubItems.Add("8");
            item3.SubItems.Add("9");

            // Create columns for the items and subitems.
            // Width of -2 indicates auto-size.
            myListView.Columns.Add("Item Column", -2, HorizontalAlignment.Left);
            myListView.Columns.Add("Column 2", -2, HorizontalAlignment.Left);
            myListView.Columns.Add("Column 3", -2, HorizontalAlignment.Left);
            myListView.Columns.Add("Column 4", -2, HorizontalAlignment.Center);

            //Add the items to the ListView.
            myListView.Items.AddRange(new ListViewItem[] { item1, item2, item3 });

            // Create two ImageList objects.
            ImageList imageListSmall = new ImageList();
            ImageList imageListLarge = new ImageList();

            // Initialize the ImageList objects with bitmaps.
    //        imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage1.bmp"));
    //             imageListSmall.Images.Add(Bitmap.FromFile("C:\\MySmallImage2.bmp"));
//            imageListLarge.Images.Add(Bitmap.FromFile(".\\MyLargeImage1.bmp"));
//           imageListLarge.Images.Add(Bitmap.FromFile(".\\MyLargeImage2.bmp"));

            //Assign the ImageList objects to the ListView.
 //           myListView.LargeImageList = imageListLarge;
            myListView.SmallImageList = imageListSmall;
            //myListView.View = View.LargeIcon;

            // Add the ListView to the control collection.
            this.Controls.Add(myListView);
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void listView4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             
        }
    }
}
