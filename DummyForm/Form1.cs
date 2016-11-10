using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryForRegisterDB;
//using DummyWcfServiceLibrary1;
namespace DummyForm
{
    public partial class Form1 : Form
    {
        ClassLibraryForRegisterDB.DAL DAL = new ClassLibraryForRegisterDB.DAL();
        //DummyWcfServiceLibrary1.Service1 DAL = new DummyWcfServiceLibrary1.Service1();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refresh();
        }
        void refresh()
        {
            dataGridView1.DataSource = DAL.ViewDummy();
            ClearControls();
        }


        private void Btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource=  DAL.SearchDummy(Tb_Search.Text);
            ClearControls();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            DAL.AddDummy(Tb_Add.Text);
            refresh();
            ClearControls();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)// refreshBtn
        {
            refresh();
            ClearControls();
        }

        private void Tb_Delete_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            DAL.DeleteDummy(Convert.ToInt32(Tb_Delete.Text));
            refresh();
            ClearControls();
        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DAL.UpdateDummy(Convert.ToInt32(TB_SelectID.Text), Tb_NameChange.Text);
            refresh();
            ClearControls();
        }

        private void ClearControls()
        {
            Tb_Add.Text = "";
            Tb_Delete.Text = "";
            Tb_NameChange.Text = "";
            Tb_Search.Text = "";
            TB_SelectID.Text = "";
        }
    }
}
