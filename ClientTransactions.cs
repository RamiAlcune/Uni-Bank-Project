using CircularProgressBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using static BankProjectC_.BankProject_ManageClients;

namespace BankProjectC_
{
    public partial class ClientTransactions : Form
    {
        public ClientTransactions()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            CBfill(cbAccountNumberDeposit);
            CBfill(cbAccountNumberWithdraw);
            string TimeDate = time;
            LogsGridView.AllowUserToAddRows = false;
            StreamReader reader = new StreamReader(LogsData);
            string line;
            string[] DataAfterRemoveSab;
            while ((line = reader.ReadLine()) != null)
            {
                DataAfterRemoveSab = SplitDataToPieces(line);

                int rowIndex = LogsGridView.Rows.Add();
                for (int i = 0; i < DataAfterRemoveSab.Length; i++)
                {
                    LogsGridView.Rows[rowIndex].Cells[i].Value = DataAfterRemoveSab[i];
                }
            }
            reader.Close();


        }
        private string DateOfWeek = DateTime.Now.ToString("dddd");
        private string DateOfMonth = DateTime.Now.ToString("MMMM");
        private string DateofYear = DateTime.Now.Year.ToString();
        private string time = DateTime.Now.ToString("HH:mm tt");
        public string LogsData = @"C:\Users\RamiAlcune\source\BankProjectC#\Bank_Logs.txt";
        private void CBfill(ComboBox ComboBoxCountener)
        {
            StreamReader reader = new StreamReader(DataFile);
            string line;
            string[] DataAfterRemoveSab;
            while ((line = reader.ReadLine()) != null)
            {
                DataAfterRemoveSab = SplitDataToPieces(line);
                ComboBoxCountener.Items.Add(DataAfterRemoveSab[0]);
            }
            reader.Close();
        }
        private void AddTransactionsToLogFile(string AccountID, string FirstName, string Balance, string TypeOfLog ,string Date)
        {
            string LineOfCode = AccountID + "|" + FirstName + "|" + Balance + "|" + TypeOfLog + "|" + Date;
            StreamWriter writer = new StreamWriter(LogsData,true);
            writer.WriteLine(LineOfCode);
            writer.Close();
        }
        public struct StoreDateStructer2
        {
            public string Item1;
            public string Item2;
            public string Item3;
            public string Item4;
            public string Item5;
            public string Item6;
            public string Item7;
            public StoreDateStructer2(string item1, string item2, string item3, string item4, string item5, string item6, string item7)
            {
                Item1 = item1;
                Item2 = item2;
                Item3 = item3;
                Item4 = item4;
                Item5 = item5;
                Item6 = item6;
                Item7 = item7;

            }
        };
        private void cbAccountID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private List<StoreDateStructer2> dataList2 = new List<StoreDateStructer2>();
        private void LoadDataFromFileToStrucerList(string lin, bool UpdateLine = false)

        {
            string[] line = lin.Split('|');
            StoreDateStructer2 Data = new StoreDateStructer2(line[0], line[1], line[2], line[3], line[4], line[5], line[6]);
            dataList2.Add(Data);
        }
        private string ReturnStructToLine2(StoreDateStructer2 CurrentStruct, char sub = '|')
        {
            string line = CurrentStruct.Item1 + sub + CurrentStruct.Item2 + sub + CurrentStruct.Item3 + sub + CurrentStruct.Item4 + sub + CurrentStruct.Item5 + sub + CurrentStruct.Item6 + sub + CurrentStruct.Item7;
            return line;
        }
        private void SaveNewListToTheFile2(List<StoreDateStructer2> List1)
        {
            StreamWriter writer = new StreamWriter(TempFile, false);
            foreach (var tim02 in List1)
            {
                writer.WriteLine(ReturnStructToLine2(tim02, '|'));
                writer.Flush();
            }
            writer.Close();
            string contentToWrite = File.ReadAllText(TempFile);
            File.WriteAllText(DataFile, string.Empty);
            File.WriteAllText(DataFile, contentToWrite);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public string[] SplitDataToPieces(string LineToConvert)
        {
            int counter = 0;


            string[] Data = LineToConvert.Split('|');
            string[] StoreData = new string[Data.Length];
            foreach (string Lines in Data)
            {

                StoreData[counter] = Data[counter];
                counter++;
            }
            return StoreData;
        }
        public string DataFile = @"C:\Users\RamiAlcune\source\BankProjectC#\DataTable.txt";
        public string TempFile = @"C:\Users\RamiAlcune\source\BankProjectC#\TempTable.txt";
        public string IDforDeposit;
        private void cbAccountNumberDeposit_SelectedValueChanged(object sender, EventArgs e)
        {

            IDforDeposit =  cbAccountNumberDeposit.SelectedItem.ToString();
            StreamReader reader = new StreamReader(DataFile);
            string line;
            string[] cbChoosedData;

            while ((line = reader.ReadLine()) != null)
            {

                cbChoosedData = SplitDataToPieces(line);

                if (IDforDeposit == cbChoosedData[0])
                {

                    lbMoney.Text = '$' + cbChoosedData[6];
                    
                    LoadDataFromFileToStrucerList(line, true);

                }
                if (IDforDeposit != cbChoosedData[0])
                {
                    LoadDataFromFileToStrucerList(line);
                }

            }

            reader.Close();

        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to deposit that amount of money?", $"Deposit ${tbDepositAmount.Text} Client ID: {cbAccountNumberDeposit.Text} To DataTable", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                for (int i = 0; i < dataList2.Count; i++)

                {
                    var item2 = dataList2[i];
                    if (item2.Item1 == cbAccountNumberDeposit.Text)
                    {
                        int Value = int.Parse(tbDepositAmount.Text);
                        int Value2 = int.Parse(item2.Item7);
                        int result = (Value + Value2);
                        item2.Item7 = result.ToString();
                        AddTransactionsToLogFile(item2.Item1, item2.Item3, Value.ToString(), "Deposit", time);
                        dataList2[i] = item2;
                    }

                }
            SaveNewListToTheFile2(dataList2);
            MessageBox.Show("Money has been deposit to the account");
            this.Close();
        }

        private void btnWithdraw_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure, you want to Withdraw that amount of money?", $"Withdraw ${tbWithdrawMoney.Text} Client ID: {cbAccountNumberWithdraw.Text} To DataTable", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                for (int i = 0; i < dataList2.Count; i++)

                {
                    var item = dataList2[i];
                    if (item.Item1 == cbAccountNumberWithdraw.Text)
                    {
                        int Value = int.Parse(tbWithdrawMoney.Text);
                        int Value2 = int.Parse(item.Item7);
                        int result = (Value2 - Value);
                        item.Item7 = result.ToString();
                        AddTransactionsToLogFile(item.Item1, item.Item3, Value.ToString(), "Withdraw", time);
                        dataList2[i] = item;
                    }

                }
            SaveNewListToTheFile2(dataList2);
            MessageBox.Show("Money has been Withdraw to the account");

            this.Close();
        }

        private void cbAccountNumberWithdraw_SelectedValueChanged(object sender, EventArgs e)
        {

            string IDforWithdraw = cbAccountNumberWithdraw.SelectedItem.ToString();
            StreamReader reader = new StreamReader(DataFile);
            string line;
            string[] cbChoosedData;

            while ((line = reader.ReadLine()) != null)
            {

                cbChoosedData = SplitDataToPieces(line);

                if (IDforWithdraw == cbChoosedData[0])
                {

                    lbWithdrawMoney.Text = '$' + cbChoosedData[6];

                    LoadDataFromFileToStrucerList(line, true);

                }
                if (IDforWithdraw != cbChoosedData[0])
                {
                    LoadDataFromFileToStrucerList(line);

                }

            }

            reader.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ClientTransactions_Load(object sender, EventArgs e)
        {

        }

        private void DepositTapPage_Click(object sender, EventArgs e)
        {

        }
    }
}

