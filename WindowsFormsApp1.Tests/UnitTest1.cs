using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace WindowsFormsApp1.Tests
{
    [TestClass]
    public class UnitTest1
    {
        // Тест додавання запису
        [TestMethod]
        public void TestAddDocument()
        {
            Form1 form = new Form1();
            int initialRowCount = form.dataGridView1.RowCount;
            form.Add_document_DataEntered(this, new DataEnteredEventArgs("1", "0050359753", "10/6/2021", "ДТЕК", "9/14/2021", "12/31/2021", "120,108.56", "Приєднання до електромережі"));
            Assert.AreEqual(initialRowCount + 1, form.dataGridView1.RowCount);
        }

        // Тест видалення запису
        [TestMethod]
        public void TestDeleteDocument()
        {
            Form1 form = new Form1();
            int initialRowCount = form.dataGridView1.RowCount;
            form.dataGridView1.Rows.Add("9", "70/21", "11/10/2021", "ФОП Ківаркова С.О.", "11/10/2021", "12/31/2021", "4,000.00", "Ролеки");
            form.dataGridView1.Rows[0].Selected = true;
            form.DeleteDocument_Click(this, EventArgs.Empty);
            Assert.AreEqual(initialRowCount, form.dataGridView1.RowCount);
        }
    }
}
