using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Todo ListBox & Combobox
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            //добавление элементов
            string[] countries = { "Франция", "Чехия", "Польша", "с. Искровка" };
            listBox1.Items.AddRange(countries);
            comboBox1.Items.AddRange(countries);
            listBox1.Items.Add("Германия");
            //вставка элементов списка
            listBox1.Items.Insert(1, "Парагвай");
            //удаление элементов по значению
            listBox1.Items.Remove("Парагвай");
            //удаление элементов по id
            listBox1.Items.RemoveAt(0);
            //полная очистка
            //listBox1.Items.Clear();
            //получить доступ к элементам списка
            string firstElement = listBox1.Items[0] as string;
            MessageBox.Show(firstElement);
            //количество элементов списка
            int count = listBox1.Items.Count;
            MessageBox.Show($"first element = {firstElement}, общее количество = {count}");
            //выделение элементов (SelectedIndex, SelectedIndices, SelectedItem, SelectedItems
            listBox1.SetSelected(2, true);
            //событие для списков (SelectedIndexChenged)
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            //привязка данных
            List<Phone> phones = new List<Phone> {
                new Phone { Id = 11, Name = "Rodjer Federer", Age = 40},
                new Phone { Id = 12, Name = "Rafael Nadal", Age = 40},
                new Phone { Id = 13, Name = "Novak Jocovich", Age = 40},
                new Phone { Id = 14, Name = "Serena Williams", Age = 40},
                new Phone {Id = 15, Name = "Anton Bubon", Age = 40} };
            listBox1.DataSource = phones;
            listBox1.DisplayMember = "Name";
            listBox1.ValueMember = "Id";
            checkedListBox1.DataSource = phones;
            checkedListBox1.DisplayMember = "Name";
            checkedListBox1.ValueMember = "Id";
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged1;
        }

        private void ListBox1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            Phone phone = listBox1.SelectedItem as Phone;
            MessageBox.Show($"{phone.Id} {phone.Name} {phone.Age}");
        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCountry = listBox1.SelectedItem.ToString();
            MessageBox.Show(selectedCountry);
        }
    }
}
