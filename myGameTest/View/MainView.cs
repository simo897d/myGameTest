﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;


namespace myGameTest {
    public partial class MainView : Form {
        private ViewModel viewModel = new ViewModel();
        //public MainView() {
        //    InitializeComponent();
        //}
        private void label1_Click(object sender, EventArgs e) {

        }
        private void label2_Click(object sender, EventArgs e) {
            
        }
        private void dataGridView1_CellContentClick(object sender, EventArgs e) {

        }
        private void Btn_Attack_Click(object sender, EventArgs e) {
            viewModel.CurrentPlayer().DoDamage();
            richTextBox1.AppendText(viewModel.DidDamage());
        }

        private void label1_Click_1(object sender, EventArgs e) {

        }
        private void richTextBox1_TextChanged(object sender, EventArgs e) {
            
        }

        private void dgv_Inventory_CellContentClick(object sender, DataGridViewCellEventArgs e) {

        }
    }
}
