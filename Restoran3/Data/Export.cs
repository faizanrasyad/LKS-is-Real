using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restoran3.Data
{
    public class Export
    {
        public static void ekspor(String sheetName, DataTable dt)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog())
                {
                    sfd.Filter = "Excel |*.xlsx";
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            var sheet = wb.Worksheets.Add(dt, sheetName);
                            wb.SaveAs(sfd.FileName);
                        }
                    }
                }
            } catch { }
        }
    }
}
