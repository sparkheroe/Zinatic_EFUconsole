using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Zinatic_EFUweb.Models;
using Excel = Microsoft.Office.Interop.Excel;

namespace Zinatic_EFUweb.Controllers.ExcelFE
{
    public class ExcelFeController : Controller
    {
        //Metodo de Carga de Datos
        private Excel.Worksheet worksheet = null;
        private Excel.Workbook workbook = null;
        
        // GET: ExcelFe
        public ActionResult Index()
        {
            Excel.Application excel = new Excel.Application();
            Excel.Workbook workbook = excel.Workbooks.Open("C:\\Users\\DitaMonster\\Documents\\Visual Studio 2017\\Projects\\Zinatic_UED\\Zinatic_EFUconsole\\Zinatic_EFUweb\\Zinatic_EFUweb\\Controllers\\ExcelFE\\FormatosExcel\\RevisionDesempeno\\formatorevision1.xlsx");
            excel.Visible = false;
            excel.DisplayAlerts = false;
            worksheet = (Excel.Worksheet)workbook.ActiveSheet;
            agregarDato("B8:I8", "APELLIDOS Y NOMBRES: KEYNER JARA",1);
            agregarDato("J8:O8", "ÁREA: SISTEMAS", 1);
            agregarDato("L21:N21", "4", 1);
            String timeStamp = GetTimestamp(DateTime.Now);
            workbook.SaveAs("C:\\Users\\DitaMonster\\Documents\\Visual Studio 2017\\Projects\\Zinatic_UED\\Zinatic_EFUconsole\\Zinatic_EFUweb\\Zinatic_EFUweb\\Controllers\\ExcelFE\\ReporteExportacion\\" + timeStamp + ".xlsx");
            workbook.Close(true);
            excel.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excel);
            return View();
        }
        public static String GetTimestamp(DateTime value)
        {
            return value.ToString("yyyyMMddHHmmssffff");
        }

        //Metodo para agregar datos a Excel
        public void agregarDato(string rango, string data, int seccion)
        {
            switch (seccion)
            {
                case 1:
                    Excel.Range rangoe = (Excel.Range)worksheet.Range[rango];
                    rangoe.Merge();
                    worksheet.Cells.Font.Size = 8;
                    rangoe.Value = data;
                    break;

                case 2:

                    break;
            }

            
        }

        public void CargarDatosReporte()
        {
            SeccionModels obj = new SeccionModels();
        }



    }
}