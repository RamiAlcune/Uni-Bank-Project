using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web.UI.Design;
using BankProjectC_.Properties;
using CircularProgressBar;

namespace BankProjectC_
{
    public partial class BankProject_ManageClients : Form
    {
        public BankProject_ManageClients()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            cbAccountID.DropDownStyle = ComboBoxStyle.DropDownList;
            cbAccountNumberToDelete.DropDownStyle = ComboBoxStyle.DropDownList;
            this.MaximizeBox = false;


            FullTime.Text = DateOfWeek + "," + DateOfMonth + " " + DateofYear;
            TimeDate.Text = time;







            StreamReader reader = new StreamReader(DataFile);
            string line;
            string[] DataAfterRemoveSab;
            while ((line = reader.ReadLine()) != null)
            {
                DataAfterRemoveSab = SplitDataToPieces(line);

                int rowIndex = dataGridView1.Rows.Add();
                for (int i = 0; i < DataAfterRemoveSab.Length; i++)
                {
                    dataGridView1.Rows[rowIndex].Cells[i].Value = DataAfterRemoveSab[i];
                }
            }
            reader.Close();




        }
        private string DateOfWeek = DateTime.Now.ToString("dddd");
        private string DateOfMonth = DateTime.Now.ToString("MMMM");
        private string DateofYear = DateTime.Now.Year.ToString();
        private string time = DateTime.Now.ToString("HH:mm tt");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void AllTextBoxInput(object sender, EventArgs e)
        {
            TextBox TextBoxAll = (TextBox)sender;
            TextBoxAll.BackColor = Color.LightBlue;
        }

        private void AllTextBoxLeave(object sender, EventArgs e)
        {
            TextBox TextBoxAll = (TextBox)sender;
            TextBoxAll.BackColor = Color.White;

        }
        private string ReturnStructToLine(StoreDateStructer CurrentStruct,char sub = '|')
        {
            string line = CurrentStruct.Item1 + sub + CurrentStruct.Item2 + sub + CurrentStruct.Item3 + sub + CurrentStruct.Item4 + sub + CurrentStruct.Item5 + sub + CurrentStruct.Item6 + sub +  CurrentStruct.Item7;
            return line;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 20;
            CircleBarProgress.Text = CircleBarProgress.Value.ToString() + '%';
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 40;
            CircleBarProgress.Text = CircleBarProgress.Value.ToString() + '%';
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 60;
            CircleBarProgress.Text = CircleBarProgress.Value.ToString() + '%';
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 70;
            CircleBarProgress.Text = CircleBarProgress.Value.ToString() + '%';
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 80;
            CircleBarProgress.Text = CircleBarProgress.Value.ToString() + '%';
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 90;
            CircleBarProgress.Text = CircleBarProgress.Value.ToString() + '%';
        }
        public string DataFile = @"C:\Users\RamiAlcune\source\BankProjectC#\DataTable.txt";
        public string TempFile = @"C:\Users\RamiAlcune\source\BankProjectC#\TempTable.txt";
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
        private void SaveNewListToTheFile(List<StoreDateStructer> lst)
        {
            StreamWriter writer = new StreamWriter(TempFile,false);
            foreach (var item in lst)
            {
                writer.WriteLine(ReturnStructToLine(item, '|'));
                writer.Flush();
            }
            writer.Close();
            string contentToWrite = File.ReadAllText(TempFile);
            File.WriteAllText(DataFile, string.Empty);
            File.WriteAllText(DataFile, contentToWrite);
        }
        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text)) {
                e.Cancel = true;
                textBox1.Focus();
                errorProvider1.SetError(textBox1, "Account Number is requre!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox1, "");
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            CircleBarProgress.Value = 100;
            CircleBarProgress.Text =  CircleBarProgress.Value.ToString() + '%';
            btnAddNewClient.Enabled = true;
        }
        public struct StoreDateStructer
        {
            public string Item1;
            public string Item2;
            public string Item3;
            public string Item4;
            public string Item5;
            public string Item6;
            public string Item7;
            public StoreDateStructer(string item1, string item2, string item3, string item4, string item5, string item6,string item7)
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

        private void cbAccountID_MouseEnter(object sender, EventArgs e)
        {
            cbAccountID.BackColor = Color.WhiteSmoke;
        }

        private void cbAccountID_MouseLeave(object sender, EventArgs e)
        {
            cbAccountID.BackColor = Color.White;
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            if (cbAccountID.Items.Count < 1)
            {
                CBfill(cbAccountID);
            }
            if (cbAccountNumberToDelete.Items.Count < 1)
            {
                CBfill(cbAccountNumberToDelete);
            }
        }
        private List<StoreDateStructer> dataList = new List<StoreDateStructer>();
        private void LoadDataFromFileToStrucerList(string lin,bool UpdateLine = false)

        {
            string[] line = lin.Split('|');
            StoreDateStructer Data = new StoreDateStructer(line[0], line[1], line[2], line[3], line[4], line[5], line[6]);
            dataList.Add(Data);
        }

        private void btnUpdateClientInfo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to update the Client??", $"Updating Client ID: {cbAccountID.Text} To DataTable", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                for (int i = 0; i < dataList.Count; i++)

            {
                var item = dataList[i];
                if (item.Item1 == cbAccountID.Text)
                {
                    item.Item2 = tbUpdatePinCode.Text;
                    item.Item3 = tbUpdateFirstName.Text;
                    item.Item4 = tbUpdateLastName.Text;
                    item.Item5 = tbUpdateEmail.Text;
                    item.Item6 = tbUpdatePhoneNumber.Text;
                    item.Item7 = tbUpdateBalance.Text;
                    dataList[i] = item;
                }

            }
            SaveNewListToTheFile(dataList);
            MessageBox.Show("Client has been Added to File");
            this.Close();
        }

        private void cbAccountID_SelectedValueChanged(object sender, EventArgs e)
        {



        }
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
        private void AddNewClient_Click(object sender, EventArgs e)
        {
            string LineOfData = textBox1.Text + "|" + textBox4.Text + "|" + textBox2.Text + "|" + textBox5.Text + "|" + textBox3.Text + "|" + textBox6.Text + "|" + textBox7.Text;

            if (MessageBox.Show("Are you sure you want to add this client to DataTable?", $"Adding Client ID: {textBox1.Text} To DataTable", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(DataFile, true);    
                writer.WriteLine(LineOfData);
                writer.Close();
                MessageBox.Show("Client has been Added to File");
            }

            this.Close();

        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void cbAccountID_Click(object sender, EventArgs e)
        {

        }

        private void cbAccountID_SelectedValueChanged_1(object sender, EventArgs e)
        {

            string ID = cbAccountID.SelectedItem.ToString();
            StreamReader reader = new StreamReader(DataFile);
            string line;
            string[] cbChoosedData;

            while ((line = reader.ReadLine()) != null)
            {

                cbChoosedData = SplitDataToPieces(line);

                if (ID == cbChoosedData[0])
                {

                    tbUpdatePinCode.Text = cbChoosedData[1];
                    tbUpdateFirstName.Text = cbChoosedData[2];
                    tbUpdateLastName.Text = cbChoosedData[3];
                    tbUpdateEmail.Text = cbChoosedData[4];
                    tbUpdatePhoneNumber.Text = cbChoosedData[5];
                    tbUpdateBalance.Text = cbChoosedData[6];
                    circularProgressBar1.Value = 100;
                    circularProgressBar1.Text = "%100";
                    btnUpdateClientInfo.Enabled = true;
                    LoadDataFromFileToStrucerList(line, true);

                }
                if (ID != cbChoosedData[0])
                {
                    LoadDataFromFileToStrucerList(line);
                }

            }

            reader.Close();

        }

        private void cbAccountNumberToDelete_SelectedValueChanged(object sender, EventArgs e)
        {
            string ID = cbAccountNumberToDelete.SelectedItem.ToString();
            StreamReader reader = new StreamReader(DataFile);
            string line;
            string[] cbChoosedData;

            while ((line = reader.ReadLine()) != null)
            {

                cbChoosedData = SplitDataToPieces(line);

                if (ID == cbChoosedData[0])
                {

                    tbPinCodeDelete.Text = cbChoosedData[1];
                    tbFirstNameToDelete.Text = cbChoosedData[2];
                    tbLastNameDelete.Text = cbChoosedData[3];
                    tbEmailDelete.Text = cbChoosedData[4];
                    tbPhoneNumberDelete.Text = cbChoosedData[5];
                    tbBalanceDelete.Text = cbChoosedData[6];
                    circularProgressBar2.Value = 100;
                    circularProgressBar2.Text = "100%";
                    btnDeleteClient.Enabled = true;
                    LoadDataFromFileToStrucerList(line, true);

                }
                if (ID != cbChoosedData[0])
                {
                    LoadDataFromFileToStrucerList(line);
                }

            }

            reader.Close();
        }

        private void btnDeleteClient_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to Delete the Client??", $"Deleting Client ID: {cbAccountNumberToDelete.Text} From DataTable", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                for (int i = 0; i < dataList.Count; i++)

                {
                    var item = dataList[i];
                    if (item.Item1 == cbAccountNumberToDelete.Text)
                    {
                        dataList.RemoveAt(i);
                    }

                }
            SaveNewListToTheFile(dataList);
            MessageBox.Show("Client has been Deleted From File");
            this.Close();
        }

        private void BankProject_ManageClients_Load(object sender, EventArgs e)
        {

        }
    }
    


}
