using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class DataEnteredEventArgs
    {
        public string ContractID { get; }
        public string ContractNumber { get; }
        public string ContractDateTime1 { get; }
        public string ContractCounterparty { get; }
        public string ContractDateTime2 { get; }
        public string ContractDateTime3 { get; }
        public string ContractSum { get; }
        public string ContractContent { get; }

        public DataEnteredEventArgs(string contractID, string contractNumber, string contractDateTime1, string contractCounterparty, string contractDateTime2, string contractDateTime3, string contractSum, string contractContent)
        {
            ContractID = contractID;
            ContractNumber = contractNumber;
            ContractDateTime1 = contractDateTime1;
            ContractCounterparty = contractCounterparty;
            ContractDateTime2 = contractDateTime2;
            ContractDateTime3 = contractDateTime3;
            ContractSum = contractSum;
            ContractContent = contractContent;
        }
    }
}