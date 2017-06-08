using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;
using System.Data.SqlClient;

namespace EventManager
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void eventBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.eventBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.eventManagerDataSet);

        }

        DatabaseConnection objConnection;
        string conString;

        DataSet ds;
        DataRow dRow;

        int MaxRows;
        int inc = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'eventManagerDataSet1.Event' table. You can move, or remove it, as needed.
            // this.eventTableAdapter1.Fill(this.eventManagerDataSet1.Event);
            this.BackColor = Color.FromArgb(204, 224, 223);
            VisualiseTimePicker(startDateTimePicker);
            VisualiseTimePicker(endDateTimePicker);
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-gb");
            labelUpdate();
            try
            {
                objConnection = new DatabaseConnection();
                conString = Properties.Settings.Default.EventManagerConnectionString;
                objConnection.connection_string = conString;
                objConnection.Sql = Properties.Settings.Default.SQL;
                ds = objConnection.GetConnection;
                MaxRows = ds.Tables[0].Rows.Count;
                BindComboBox();
                
                NavigateRecords();
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }

        }

        private void NavigateRecords()
        {
            dRow = ds.Tables[0].Rows[inc];
            nameTextBox.Text = dRow.ItemArray.GetValue(0).ToString();
            locationTextBox.Text = dRow.ItemArray.GetValue(1).ToString();
            startDateTimePicker.Text = dRow.ItemArray.GetValue(2).ToString();
            endDateTimePicker.Text = dRow.ItemArray.GetValue(3).ToString();
            comboBox1.SelectedIndex = inc;
            labelUpdate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {
                inc++;
                NavigateRecords();
            }
            else
            {
                MessageBox.Show("No more rows!");
            }
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (inc > 0)
            {

                inc--;
                NavigateRecords();

            }
            else
            {

                MessageBox.Show("First Record");

            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            if (inc != MaxRows - 1)
            {

                inc = MaxRows - 1;
                NavigateRecords();

            }
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            if (inc != 0)
            {

                inc = 0;
                NavigateRecords();

            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            nameTextBox.Clear();
            locationTextBox.Clear();
            startDateTimePicker.Value = DateTime.Now;
            endDateTimePicker.Value = DateTime.Now;

            btnAddNew.Enabled = false;
            btnSave.Enabled = true;
            btnCancel.Enabled = true;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            NavigateRecords();

            btnCancel.Enabled = false;
            btnSave.Enabled = false;
            btnAddNew.Enabled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (startDateTimePicker.Value > endDateTimePicker.Value)
            {
                MessageBox.Show("The end time cannot be before the start time!");
            }
            else if (nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please, enter a name!");
            }
            else if (locationTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please, enter a location!");
            }
            else
            {
                DataRow row = ds.Tables[0].NewRow();
                row[0] = nameTextBox.Text;
                row[1] = locationTextBox.Text;
                row[2] = startDateTimePicker.Text;
                row[3] = endDateTimePicker.Text;
                ds.Tables[0].Rows.Add(row);

                try
                {

                    objConnection.UpdateDatabase(ds);
                    BindComboBox();

                    MaxRows = MaxRows + 1;
                    inc = MaxRows - 2;

                    MessageBox.Show("Database updated");

                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message);
                }

                btnCancel.Enabled = false;
                btnSave.Enabled = false;
                btnAddNew.Enabled = true;
            }

            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            if (startDateTimePicker.Value > endDateTimePicker.Value)
            {
                MessageBox.Show("The end time cannot be before the start time!");
            }
            else if (nameTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please, enter a name!");
            }
            else if (locationTextBox.Text.Equals(""))
            {
                MessageBox.Show("Please, enter a location!");
            }
            else
            {
                DataRow row = ds.Tables[0].Rows[inc];

                row[0] = nameTextBox.Text;
                row[1] = locationTextBox.Text;
                row[2] = startDateTimePicker.Text;
                row[3] = endDateTimePicker.Text;

                try
                {

                    objConnection.UpdateDatabase(ds);
                    BindComboBox();

                    MessageBox.Show("Record Updated");

                }
                catch (Exception err)
                {

                    MessageBox.Show(err.Message);

                }
            }
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           try
            {
                if (MaxRows == 1)
                {
                    MessageBox.Show("Cannot delete all the events!");
                }
                else
                {
                    ds.Tables[0].Rows[inc].Delete();
                    objConnection.UpdateDatabase(ds);
                    BindComboBox();

                    MaxRows = ds.Tables[0].Rows.Count;
                    if (inc == 0)
                    {
                        inc = 0;
                    }
                    else
                    {
                        inc--;
                    }


                    NavigateRecords();

                    MessageBox.Show("Record Deleted");
                }
             
            }
            catch (Exception err)
            {

                MessageBox.Show(err.Message);

            }
        }

        private void VisualiseTimePicker(DateTimePicker d)
        {
            d.Format = DateTimePickerFormat.Custom;
            d.CustomFormat = "dd/MM/yyyy hh:mm:ss tt";
        }

        private void labelUpdate()
        {

            label4.Text = "Record " + (inc + 1) + " of " + MaxRows;

        }

        private void BindComboBox()
        {
            string s = Environment.CurrentDirectory + @"\EventManager.mdf";
            SqlConnection conn = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = " + s + ";Integrated Security = True");
            SqlCommand sc = new SqlCommand("select * from event", conn);
            SqlDataReader reader;
            conn.Open();
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("name", typeof(string));
            dt.Columns.Add("location", typeof(string));
            dt.Load(reader);

            //comboBox1.ValueMember = "name";
            comboBox1.DisplayMember = "name";
            comboBox1.DataSource = dt;

            conn.Close();
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            int selectedIndex = comboBox1.SelectedIndex;
            inc = selectedIndex;
            NavigateRecords();
        }
    }
}
