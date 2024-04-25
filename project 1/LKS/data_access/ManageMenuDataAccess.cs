using LKS.lib;
using LKS.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LKS.data_access
{
    public class ManageMenuDataAccess
    {
        Database db = new Database();

        public List<MenuModel> GetListMenu()
        {
            var result = new List<MenuModel>();
            
            //translate hasil dari db ke data model
            var dt = db.Read("select * from Msmenu");

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var data = dt.Rows[i];

                result.Add(new MenuModel
                {
                    MenuID = data["MenuID"].ToString(),
                    Name = data["Name"].ToString(),
                    Price = double.Parse(data["Price"].ToString()),
                    Photo = data["Photo"].ToString(),
                });
            }

            return result;
        }

        public void InsertMenu(MenuModel newMenu) {
            db.Execute($@"
                insert into Msmenu
	                (
	                 Name,
	                 Price,
	                 Photo
	                )
	                values 
	                (
	                '{newMenu.Name}',
	                '{newMenu.Price}',
	                '{newMenu.Photo}'
	                )
            ");
        
        }

        public void UpdateMenu(MenuModel updatedMenu) {
            db.Execute($@"
                update Msmenu set
	                Name = '{updatedMenu.Name}',
	                Price = {updatedMenu.Price},
	                Photo = '{updatedMenu.Photo}'
                where
	                MenuID = '{updatedMenu.MenuID}'
            ");
        }
        public void DeleteMenu(string menuID) {
            db.Execute($"delete from Msmenu where MenuID = '{menuID}'");
        }
    }
}
