using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Add_document : Form
    {
        public event EventHandler<DataEnteredEventArgs> DataEntered;
        public Add_document()
        {
            InitializeComponent();
        }

        private void add_of_document_Click(object sender, EventArgs e)
        {
            // Збираємо дані
            string contractID = Write_ID.Text;
            string contractNumber = Write_num_Document.Text;
            string contractDateTime1 = dateTimePicker1.Value.ToString("MM/dd/yyyy");
            string contractCounterparty = Write_Counterparty.Text;
            string contractDateTime2 = dateTimePicker2.Value.ToString("MM/dd/yyyy");
            string contractDateTime3 = dateTimePicker3.Value.ToString("MM/dd/yyyy");
            string contractSum = Write_sum.Text;
            string contractContent = Write_Content.Text;

            // Викликаємо подію та передаємо дані
            DataEntered?.Invoke(this, new DataEnteredEventArgs(contractID, contractNumber, contractDateTime1, contractCounterparty, contractDateTime2, contractDateTime3, contractSum, contractContent));
        }

        private void Back_to_table_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Write_status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
