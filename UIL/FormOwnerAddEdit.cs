using BLL;
using Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UIL
{
    public partial class FormOwnerAddEdit : Form
    {
        private readonly BLLayer bll;
        private readonly FormIndex formIndex;
        private readonly int id;
        public FormOwnerAddEdit(FormIndex form, string title, int id = -1)
        {
            InitializeComponent();
            bll = new BLLayer();

            formIndex = form;
            lblTitle.Text = title;
            this.id = id;
        }

        private void FormOwnerAddEdit_Load(object sender, EventArgs e)
        {
            if (id == -1)
                return;
            Owner owner = bll.GetOwnerById(id);
            txtName.Text = owner.Name;
            if (owner.Sex == "男")
                rdoMale.Checked = true;
            else
                rdoFemale.Checked = true;
            txtPhone.Text = owner.Phone;
            cboBuildingNum.SelectedIndex = Convert.ToInt32(owner.BuildingNum - 1);
            cboUnitNum.SelectedIndex = Convert.ToInt32(owner.UnitNum - 1);
            txtRoomNum.Text = owner.RoomNum.ToString();
        }

        private void FormOwnerAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            //this.Close();
            formIndex.FindOwners();
            formIndex.Show();
        }

        private void BtnEnter_Click(object sender, EventArgs e)
        {
            if (id == -1)
                Add();
            else
                Edit();
        }
        private void Add()
        {
            Owner owner = GetOwner();
            if (owner == null)
                return;
            (string info, bool isSuccess) = bll.Add(owner);
            MessageBox.Show(info);
            if (isSuccess)
                this.Close();
        }

        private void Edit()
        {
            Owner owner = GetOwner();
            if (owner == null)
                return;
            (string info, bool isSuccess) = bll.Edit(owner);
            MessageBox.Show(info);
            if (isSuccess)
                this.Close();
        }
        private Owner GetOwner()
        {
            //string msg = "";
            Owner owner = null;
            try
            {
                owner = new Owner
                {
                    Id = id,
                    Name = txtName.Text.Trim(),
                    Sex = rdoMale.Checked ? "男" : "女",
                    Phone = txtPhone.Text.Trim(),
                    BuildingNum = cboBuildingNum.SelectedIndex + 1,
                    UnitNum = cboUnitNum.SelectedIndex + 1,
                    RoomNum = Convert.ToInt32(txtRoomNum.Text.Trim())
                };
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return owner;
        }
    }
}
