using GST.DataObjects;
using System;
using System.Collections;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace GST
{
    public partial class MainForm : Form
    {

        ArrayList purchases;
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files(*.txt) | *.txt";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK) {
                string fileName = openFileDialog.FileName;
                string line;
                purchases = new ArrayList();
                StreamReader file = new StreamReader(fileName);
                while ((line = file.ReadLine()) != null)
                {
                    purchases.Add(new Purchase(line));
                }

                file.Close();
            }
        }

        private void GenerateExcel_Click(object sender, EventArgs e)
        {
            if (purchases == null || purchases.Count == 0) {
                return;
            }

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK) {
                string folderPath = folderBrowserDialog.SelectedPath;
                if (string.IsNullOrEmpty(folderPath)) {
                    return;
                }
                folderPath = folderPath.TrimEnd('\\') + '\\';   // this gurantees we hande drives , directories properly
                MakeExcel(folderPath + "dummy.xlsx");
            }
        }

        private void MakeExcel(string fileName)
        {
            var file = new FileInfo(fileName);
            ExcelPackage package = new ExcelPackage();
            ExcelWorksheet ws = package.Workbook.Worksheets.Add("Test");
            ws.Cells["B1"].Value = "Name";
            ws.Cells["C1"].Value = "Size";
            ws.Cells["D1"].Value = "Created";
            ws.Cells["E1"].Value = "Last modified";
            ws.Cells["B1:E1"].Style.Font.Bold = true;
            package.SaveAs(file);
        }
    }
}
