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
    public partial class Edit_document : Form
    {
        public event EventHandler<DataEnteredEventArgs> DataEntered;
        public string ContractID { get; set; }
        public string ContractNumber { get; set; }
        public string ContractDateTime1 { get; set; }
        public string ContractCounterparty { get; set; }
        public string ContractDateTime2 { get; set; }
        public string ContractDateTime3 { get; set; }
        public string ContractSum { get; set; }
        public string ContractContent { get; set; }
        public Edit_document()
        {
            InitializeComponent();
        }

        private void Edit_document_Load(object sender, EventArgs e)
        {
            Write_ID.Text = ContractID;
            Write_num_Document.Text = ContractNumber;

            DateTime dateTime;
            if (DateTime.TryParse(ContractDateTime1, out dateTime))
            {
                dateTimePicker1.Value = dateTime;
            }

            Write_Counterparty.Text = ContractCounterparty;

            if (DateTime.TryParse(ContractDateTime2, out dateTime))
            {
                dateTimePicker2.Value = dateTime;
            }

            if (DateTime.TryParse(ContractDateTime3, out dateTime))
            {
                dateTimePicker3.Value = dateTime;
            }

            Write_sum.Text = ContractSum;
            Write_Content.Text = ContractContent;
        }

        private void saveChanges_Click(object sender, EventArgs e)
        {
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
            this.Close();
        }

        private void Back_to_table_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
