using AudioDataLibrary.Data;
using AudioDataLibrary.Models;
using AudioProductsUI;

namespace WinFormsApp
{
    public partial class ItemListing : Form
    {
        SqlData _db;
        public ItemListing(SqlData db)
        {
            _db = db;

            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            ItemModel item = new ItemModel();
            
            AddItem addItem = new AddItem(item);

            if (addItem.ShowDialog() == DialogResult.OK)
            {
                _db.AddItem(item);
            }
        }
    }
}
