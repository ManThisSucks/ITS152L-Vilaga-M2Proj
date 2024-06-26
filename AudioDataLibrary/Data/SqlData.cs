using AudioDataLibrary.Models;
using BlogDataLibrary.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDataLibrary.Data
{
    public class SqlData
    {
        private ISqlDataAccess _db;
        private const string connectionStringName = "SqlDb";

        public SqlData(ISqlDataAccess db)
        {
            _db = db;
        }

        public void AddItem(string code, string model, string make, string variant, string description, string msrp)
        {
            _db.SaveData<dynamic>(
                "dbo.spItems_Add",
                new { code, model, make, variant, description, msrp },
                connectionStringName,
                true);
        }

        public void AddItem(ItemModel item)
        {
            _db.SaveData<dynamic>(
                "dbo.spItems_Add",
                new { item.Code, item.Model, item.Make, item.Variant, item.Description, item.Msrp },
                connectionStringName,
                true);
        }

        public List<ItemModel> getItems()
        {
            return _db.LoadData<ItemModel, dynamic>("dbo.spItems_List", new { },
                connectionStringName, true).ToList();
        }
    }
}
