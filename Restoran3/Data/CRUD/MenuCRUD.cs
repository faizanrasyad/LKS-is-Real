using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran3.Data.CRUD
{
    public class MenuCRUD
    {
        public static Menu selectedMenu = null;

        public static Menu getById(String idMenu)
        {
            return Repo.entities.Menus.Where(r => r.idMenu.Equals(idMenu)).FirstOrDefault();
        }
        public static void addMenu(String idMenu, String jenis, String nama, int harga)
        {
            try
            {
                var menu = new Menu()
                {
                    idMenu = idMenu,
                    Jenis = jenis,
                    Nama = nama,
                    Harga = harga,
                };
                Repo.entities.Menus.Add(menu);
                Repo.entities.SaveChanges();
            }
            catch (Exception ex) { throw; }
        }

        public static void updateMenu(Menu menuModel)
        {
            try
            {
                Menu model = Repo.entities.Menus.Find(menuModel.idMenu);

                model.idMenu = menuModel.idMenu;
                model.Jenis = menuModel.Jenis;
                model.Harga = menuModel.Harga;
                model.Nama = menuModel.Nama;

                Repo.entities.SaveChanges();
            }
            catch (Exception ex) { throw; }
        }

        public static void removeMenu()
        {
            Menu entry = Repo.entities.Menus.Find(selectedMenu.idMenu);

            if (entry != null)
            {
                Repo.entities.Menus.Remove(entry);
                Repo.entities.SaveChanges();
            }
        }

        public static void exportMenu(DataTable dt)
        {
            Export.ekspor("Menu", dt);
        }
    }
}
