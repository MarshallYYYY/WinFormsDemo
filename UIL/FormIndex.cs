using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIL
{
    public partial class FormIndex : Form
    {
        private readonly BLLayer bll;
        public FormIndex()
        {
            InitializeComponent();

            bll = new BLLayer();
        }

        private void FormIndex_Load(object sender, EventArgs e)
        {
            //去除 DataGridView 列表头的排序功能
            foreach (DataGridViewColumn col in dgv.Columns)
                col.SortMode = DataGridViewColumnSortMode.NotSortable;

            txt.Text = "";
            FindOwners();
        }
        private void BtnFind_Click(object sender, EventArgs e)
        {
            FindOwners();
        }
        public void FindOwners()
        {
            dgv.DataSource = bll.FindOwners(txt.Text);
            for (int i = 0; i < dgv.Rows.Count; i++)
                dgv.Rows[i].Cells["colNum"].Value = (i + 1).ToString();
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            txt.Text = "";
            FindOwners();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormOwnerAddEdit form = new FormOwnerAddEdit(this, "添加业主信息");
            form.ShowDialog();
        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            int index = dgv.CurrentRow.Index;
            int id = Convert.ToInt32(dgv.Rows[index].Cells["colId"].Value);
            FormOwnerAddEdit form = new FormOwnerAddEdit(this, "修改业主信息", id);
            form.ShowDialog();
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            int index = dgv.CurrentRow.Index;
            int id = Convert.ToInt32(dgv.Rows[index].Cells["colId"].Value);
            DialogResult result = MessageBox.Show(
                "是否删除？", "",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (bll.Delete(id))
                {
                    MessageBox.Show("删除成功！");
                    FindOwners();
                }
                else
                    MessageBox.Show("删除失败！");
            }
        }
    }
}
