using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restoran3.Data.CRUD
{
    public class MejaCRUD
    {
        public static Meja selectedMeja = null;

        public static void getById(String noMeja)
        {
            selectedMeja = Repo.entities.Mejas.Where(r => r.noMeja.Equals(noMeja)).FirstOrDefault();
        }

        public static void addMeja(String noMeja, String jenis, int kapasitas, String status)
        {
            try
            {
                var meja = new Meja()
                {
                    Jenis = jenis,
                    Kapasitas = kapasitas,
                    Status = status,
                    noMeja = noMeja,
                };
                Repo.entities.Mejas.Add(meja);
                Repo.entities.SaveChanges();
            }
            catch (Exception ex) { throw; }
        }

        public static void updateMeja(Meja mejaModel)
        {
            try
            {
                Meja model = Repo.entities.Mejas.Find(mejaModel.noMeja);

                model.noMeja = mejaModel.noMeja;
                model.Jenis = mejaModel.Jenis;
                model.Kapasitas = mejaModel.Kapasitas;
                model.Status = mejaModel.Status;

                Repo.entities.SaveChanges();
            }
            catch (Exception ex) { throw; }
        }

        public static void removeMeja()
        {
            Meja entry = Repo.entities.Mejas.Find(selectedMeja.noMeja);

            if (entry != null)
            {
                Repo.entities.Mejas.Remove(entry);
                Repo.entities.SaveChanges();
            }
        }

        public static void exportMeja(DataTable dt)
        {
            Export.ekspor("Meja", dt);
        }
    }
}
