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
    }
}
