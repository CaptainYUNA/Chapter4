using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();

            var cityList = new List<string>
            {
                "오스트리아, 빈", "호주, 멜버른", "일본, 오사카", "캐나다, 밴쿠버", "호주, 시드니", "캐나다, 토론토", "덴마크, 코펜하겐"
            };

            wellCityListBox.DataSource = cityList;

            foreach (var item in cityList)
            {
                checkedListBox1.Items.Add(item);
            }

            checkedItems.SelectionMode = SelectionMode.MultiExtended;

            InitializeListView();
        }

        private void InitializeListView()
        {
            myListView.GridLines = true;
            myListView.FullRowSelect = true;

            var item1 = new ListViewItem("Access", 0);
            var item2 = new ListViewItem("Excel", 1);
            var item3 = new ListViewItem("PowerPoint", 2);
            var item4 = new ListViewItem("Word", 3);

            item1.SubItems.Add("22,000");
            item1.SubItems.Add("30");
            item1.SubItems.Add("660,000");

            item2.SubItems.Add("11,000");
            item2.SubItems.Add("30");
            item2.SubItems.Add("330,000");

            item3.SubItems.Add("10,000");
            item3.SubItems.Add("30");
            item3.SubItems.Add("300,000");

            item4.SubItems.Add("12,000");
            item4.SubItems.Add("20");
            item4.SubItems.Add("240,000");

            myListView.Items.AddRange(new ListViewItem[]
            {
                item1, item2, item3, item4
            });

            var smallImageList = new ImageList();
            smallImageList.ImageSize = new Size(24, 24);

            var largeImageList = new ImageList
            {
                ImageSize = new Size(64, 64)
            };

            myListView.SmallImageList = (smallImageList);
            myListView.LargeImageList = largeImageList;

            smallImageList.Images.Add(Bitmap.FromFile(@"..\..\Images\1.jpg"));
            smallImageList.Images.Add(Bitmap.FromFile(@"..\..\Images\2.jpg"));
            smallImageList.Images.Add(Bitmap.FromFile(@"..\..\Images\3.jpg"));
            smallImageList.Images.Add(Bitmap.FromFile(@"..\..\Images\4.jpg"));

            largeImageList.Images.Add(Image.FromFile(@"..\..\Images\1.jpg"));
            largeImageList.Images.Add(Image.FromFile(@"..\..\Images\2.jpg"));
            largeImageList.Images.Add(Bitmap.FromFile(@"..\..\Images\3.jpg"));
            largeImageList.Images.Add(Bitmap.FromFile(@"..\..\Images\4.jpg"));
        }

        private void Handler_GDPListBoxSelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;

            gdpIndex.Text = listBox.SelectedIndex.ToString();
            gdpCityName.Text = listBox.SelectedItem.ToString();
        }
        private void Handler_WellCityListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var listBox = sender as ListBox;

            wellIndex.Text = listBox.SelectedIndex.ToString();
            wellName.Text = listBox.SelectedItem.ToString();
        }

        private void Handler_ComboBox1SelectedIndexChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            result.Text = "이번 주 모임 장소는: " + comboBox.SelectedItem.ToString();
        }

        private void Handler_AddButtonClick(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(restaurantComboBox.Text))
            {
                if (restaurantComboBox.Items.Contains(restaurantComboBox.Text))
                {
                    MessageBox.Show("이미 존재하는 식당입니다.");
                    return;
                }
                else
                {
                    restaurantComboBox.Items.Add(restaurantComboBox.Text);
                    //result.Text = restaurantComboBox.Text + " Added!";
                    MessageBox.Show($"{restaurantComboBox.Text} Added!");
                }
            }
        }

        private void Handler_DeleteButtonClick(object sender, EventArgs e)
        {
            if (restaurantComboBox.SelectedIndex >= 0)
            {
                MessageBox.Show($"{restaurantComboBox.Text} Deleted!");
                restaurantComboBox.Items.Remove(restaurantComboBox.SelectedItem);
            }
        }

        private void Handler_CheckedListBox1SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Handler_MoveRightClick(object sender, EventArgs e)
        {
            var selectedItems = checkedListBox1.CheckedItems;

            foreach (var item in selectedItems)
            {
                checkedItems.Items.Add(item);
            }

            checkedListBox1.Items.Remove(checkedListBox1.CheckedItems);
        }

        private void Handler_AllMoveRightClick(object sender, EventArgs e)
        {
            var selectedItems = checkedListBox1.Items;

            foreach (var item in selectedItems)
            {
                checkedItems.Items.Add(item);
            }
        }

        private void Handler_MoveLeftClick(object sender, EventArgs e)
        {
            var removeItems = new List<string>();
            var selectedItems = checkedItems.SelectedItems;
            var originalItems = checkedListBox1.Items;

            foreach (var item in selectedItems)
            {
                removeItems.Add(item.ToString());
            }

            foreach (var city in removeItems)
            {
                checkedItems.Items.Remove(city);

                if (originalItems.Contains(city))
                {
                    return;
                }
                else
                {
                    checkedListBox1.Items.Add(city);
                }
            }

        }

        private void Handler_DetailCheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.Details;
        }

        private void Handler_ListCheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.List;
        }

        private void Handler_SmallCheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.SmallIcon;
        }

        private void Handler_LargeCheckedChanged(object sender, EventArgs e)
        {
            myListView.View = View.LargeIcon;
        }

        private void Handler_MyListViewSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedView.Text = "";

            var selected = myListView.SelectedItems.Cast<ListViewItem>();

            foreach (var item in selected)
            {
                for (int i = 0; i < 4; i++)
                {
                    selectedView.Text += item.SubItems[i].Text + '\t';
                }
            }
        }
    }
}
