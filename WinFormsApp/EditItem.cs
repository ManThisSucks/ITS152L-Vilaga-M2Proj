using AudioDataLibrary.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioProductsUI
{
    public partial class EditItem : Form
    {
        private ItemModel _item;
        public EditItem(ItemModel item)
        {
            _item = item;
            InitializeComponent();

            itemCodeTextBox.Text = _item.Code;
            makeTextBox.Text = _item.Make;
            modelTextBox.Text = _item.Model;
            variantTextBox.Text = _item.Variant;
            descriptionTextBox.Text = _item.Description;
            msrpTextBox.Text = _item.Msrp;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            _item.Code = itemCodeTextBox.Text;
            _item.Make = makeTextBox.Text;
            _item.Model = modelTextBox.Text;
            _item.Variant = variantTextBox.Text;
            _item.Description = descriptionTextBox.Text;
            _item.Msrp = msrpTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
