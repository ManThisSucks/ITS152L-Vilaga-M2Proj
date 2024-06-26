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
                refreshTable();
            }
            
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshTable();
        }

        private void refreshTable()
        {
            itemListView.Items.Clear();

            List<ItemModel> items = _db.getItems();
            
            foreach (ItemModel item in items)
            {
                var listViewItem = new ListViewItem(item.Code);
                listViewItem.SubItems.Add(item.Model);
                listViewItem.SubItems.Add(item.Make);
                listViewItem.SubItems.Add(item.Variant);
                listViewItem.SubItems.Add(item.Description);
                listViewItem.SubItems.Add(item.Msrp);

                itemListView.Items.Add(listViewItem);
            }
        }
    }
}
