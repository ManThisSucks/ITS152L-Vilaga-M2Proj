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
    public partial class AddItem : Form
    {
        private ItemModel _item;

        public AddItem(ItemModel item)
        {
            _item = item;
            InitializeComponent();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            _item.Code = itemCodeTextBox.Text;
            _item.Make = makeTextBox.Text;
            _item.Model = modelTextBox.Text;
            _item.Variant = variantTextBox.Text;
            _item.Description = descriptionTextBox.Text;
            _item.Msrp = float.Parse(msrpTextBox.Text);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
