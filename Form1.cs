using System.Data;
using System.Data.SqlClient;


namespace P3_TanVu_Nguyen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create a new instance of class Weather infor, each instance represent for a row data in database table 
        ControlDB tempControler = new ControlDB();

        // a variable to hold index of selected row to edit
        int indexOfEditedRow = -1;

        // this function will load data from database into the datagridview when fist run the application
        private void Form1_Load(object sender, EventArgs e)
        {

            // disable auto generate column of datagrid view, just show some colum that was setup before, not all column selected from database
            //dgvListWeatherInfo.AutoGenerateColumns = false;

            // point data source of the datagridview to the datatable, which is read from database thought getDataFromDB method
            dgvListWeatherInfo.DataSource = tempControler.getDataFromDB();

            if (dgvListWeatherInfo.SelectedRows.Count > 0 || dgvListWeatherInfo.SelectedCells.Count > 0)
            {
                dgvListWeatherInfo.ClearSelection();                
            }

        }

        // this function to close the application
        private void btnClose_Click(object sender, EventArgs e)
        {
            // show the message ask for user choice
            DialogResult SaveToFile = MessageBox.Show("Do you want to Exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // when user choose yes, it mean write the data currently in the listview into text file
            if (SaveToFile == DialogResult.Yes)
            {
                // close the application
                Application.Exit();
            }
            
        }

        private void btnAddInfo_Click(object sender, EventArgs e)
        {
            try
            {
                // variable to contain input from temperature textbox
                double temperature;
                // variable to contain input from humidity textbox
                int humidity;

                // valiadte combobox require user to select a state
                if (cbxState.SelectedIndex == -1)
                {
                    // set error for combobox state                    
                    MessageBox.Show("You need to select State in the list", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // focus back to where user typing wrong
                    cbxState.Focus();
                }
                // validate input control 
                // when textbox city is empty or too short, less than 5 character then raise error
                else if (string.IsNullOrEmpty(txtCity.Text.Trim()) || txtCity.Text.Length < 5)
                {
                    // set error for city textbox                   
                    MessageBox.Show("City can not be empty or less than 5 characters", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    // focus back to where user typing wrong
                    txtCity.Focus();
                    txtCity.SelectAll();
                }
                // validate datetime picker,
                // cannot be empty
                // cannot select the day in the future
                else if (string.IsNullOrEmpty(dtpDate.Text) || dtpDate.Value > DateTime.Now)
                {
                    //set error for datetime picker  
                    MessageBox.Show("Date can not be empty or a day in the future", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // focus back to where user typing wrong
                    dtpDate.Focus();
                }
                //validate temperature input
                //temperature can not empty
                //need to be in the good format to convert into data type double
                //the range of number shoud be between -80 and 130
                else if (string.IsNullOrEmpty(txtTemp.Text) || !double.TryParse(txtTemp.Text, out temperature) || double.Parse(txtTemp.Text) < -60 || double.Parse(txtTemp.Text) > 130)
                {
                    //set error for textbox temperature
                    MessageBox.Show("Temperature cannot be empty and need to be a number in range of -60 and 130", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // focus back to where user typing wrong                   
                    txtTemp.Focus();
                    txtTemp.SelectAll();
                }
                // validate humidity input
                // humidity is number in range 0 to 100
                // can not empty, or negative number
                else if (string.IsNullOrEmpty(txtHumidity.Text) || !int.TryParse(txtHumidity.Text, out humidity) || int.Parse(txtHumidity.Text) < 0 || int.Parse(txtHumidity.Text) > 100)
                {
                    //set error for textbox Humidity
                    MessageBox.Show("Humidity cannot be empty and need to be a number in range of 0 and 100", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // focus back to where user typing wrong                   
                    txtHumidity.Focus();
                    txtHumidity.SelectAll();
                }
                // validate sunrise, sunrise input cannot be afternoon hour (which mean it alway AM)
                else if (dtpSunrise.Text.Contains("PM"))
                {
                    //set error for time picker
                    MessageBox.Show("Sunrise only in the morning, please change to AM", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // focus back to where user typing wrong                   
                    dtpSunrise.Focus();
                }
                // validate sunset, sunset input cannot be morning hour (which mean it alway PM)
                else if (dtpSunset.Text.Contains("AM"))
                {
                    //set error for time picker
                    MessageBox.Show("Sunset only in the evening, please change to PM", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    // focus back to where user typing wrong                   
                    dtpSunset.Focus();
                }
                else
                {
                                      
                    WeatherInfo tempRow = new WeatherInfo();
                    tempRow.state = cbxState.Text;
                    tempRow.city = txtCity.Text;
                    tempRow.date = dtpDate.Value;
                    tempRow.temperature = double.Parse(txtTemp.Text);
                    tempRow.humidity = int.Parse(txtHumidity.Text);
                    tempRow.sunrise = dtpSunrise.Text;
                    tempRow.sunset = dtpSunset.Text;
                    tempRow.cloudy = (chkCloudy.Checked) ? true : false;
                    tempRow.windy = (chkWindy.Checked) ? true : false;
                    tempRow.rainy = (chkRainy.Checked) ? true : false;

                    // if the information in the control box is selected from a row in the listview
                    if (indexOfEditedRow != -1)
                    {
                        tempRow.id = indexOfEditedRow;
                        if (tempControler.updateRow(tempRow))
                        {
                            MessageBox.Show("One row are updated!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // after edit, release variable or set this index variable to -1 for the next using 
                            indexOfEditedRow = -1;

                            // change button add information into save
                            // and clear button into cancel
                            btnAddInfo.Text = "Add Information";
                            btnClear.Text = "Clear";
                        }
                    }
                    else
                    {
                        if (tempControler.insertRow(tempRow))
                        {
                            MessageBox.Show("Insert a row successfully!", "INFORMATION", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }
                    }

                   
                    // point data source of the datagridview to the datatable, which is read from database thought getDataFromDB method
                    dgvListWeatherInfo.DataSource = tempControler.getDataFromDB();

                    // clear all text after insert success
                    clearControlText();

                }

            }
            catch (Exception ex)
            {
                // show error message when catching any error
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearControlText()
        {
            cbxState.SelectedIndex = -1;
            txtCity.Text = string.Empty;
            dtpDate.Value = DateTime.Now;
            txtTemp.Text = string.Empty;
            txtHumidity.Text = string.Empty;
            dtpSunrise.Value = DateTime.Now;
            dtpSunset.Value = DateTime.Now;
            chkCloudy.Checked = false;
            chkWindy.Checked = false;
            chkRainy.Checked = false;

            indexOfEditedRow = -1;

            if (dgvListWeatherInfo.SelectedRows.Count > 0 || dgvListWeatherInfo.SelectedCells.Count > 0)
            {
                dgvListWeatherInfo.ClearSelection();
            }

            cbxState.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearControlText();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            // make sure the datagrid is not empty
            if (dgvListWeatherInfo.Rows.Count > 1)
            {
                //when user select one row
                if (dgvListWeatherInfo.SelectedRows.Count == 1)
                {
                    if (MessageBox.Show("Do you want to delete this row?", "Delete a row", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        int selectedRowID = int.Parse(dgvListWeatherInfo.CurrentRow.Cells[0].Value.ToString());

                        tempControler.deteteRow(selectedRowID);

                        // reload data from database into datagridview
                        dgvListWeatherInfo.DataSource = tempControler.getDataFromDB();
                    }

                }
                // when user select multiple rows
                else if (dgvListWeatherInfo.SelectedRows.Count > 1)
                {
                    if (MessageBox.Show("Do you want to delete these rows?", "Delete multiple rows", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        foreach (DataGridViewRow tempRow in dgvListWeatherInfo.SelectedRows)
                        {
                            int selectedRowID = int.Parse(tempRow.Cells[0].Value.ToString());

                            tempControler.deteteRow(selectedRowID);
                        }
                        // reload data from database into datagridview
                        dgvListWeatherInfo.DataSource = tempControler.getDataFromDB();
                    }
                }
                else
                {
                    MessageBox.Show("You need to select a row", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                //warning user when empty data
                MessageBox.Show("Data list is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
           
        }

        private void btnRemoveAll_Click(object sender, EventArgs e)
        {
            try
            {
                // when the data in listview is not empty
                if (dgvListWeatherInfo.Rows.Count > 1)
                {
                    //loop all rows in the datagridview
                    foreach (DataGridViewRow tempRow in dgvListWeatherInfo.Rows)
                    {
                        // if see the new row then ignore it
                        if (tempRow.IsNewRow)
                            continue;
                        // get the ID of each item
                        int selectedRowID = int.Parse(tempRow.Cells[0].Value.ToString());

                        // delete a row by ID
                        tempControler.deteteRow(selectedRowID);
                    }
                    // reload data from database into datagridview
                    dgvListWeatherInfo.DataSource = tempControler.getDataFromDB();
                }
                else
                {
                    //warning user when empty data
                    MessageBox.Show("Data list is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // show message error if catching any error
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void loadRowDataToControl(ref int indexOfEditedRow)
        {

            indexOfEditedRow = int.Parse(dgvListWeatherInfo.CurrentRow.Cells[0].Value.ToString());
            dtpDate.Text = dgvListWeatherInfo.CurrentRow.Cells[3].Value.ToString();            
            cbxState.SelectedItem = dgvListWeatherInfo.CurrentRow.Cells[1].Value.ToString().Trim();
            txtCity.Text = dgvListWeatherInfo.CurrentRow.Cells[2].Value.ToString();
            txtTemp.Text = dgvListWeatherInfo.CurrentRow.Cells[4].Value.ToString();
            txtHumidity.Text = dgvListWeatherInfo.CurrentRow.Cells[5].Value.ToString();
            dtpSunrise.Text = dgvListWeatherInfo.CurrentRow.Cells[6].Value.ToString();
            dtpSunset.Text = dgvListWeatherInfo.CurrentRow.Cells[7].Value.ToString();                     

            if(Convert.ToBoolean(dgvListWeatherInfo.CurrentRow.Cells[8].Value) == true)
            {
                chkCloudy.Checked = true;               
            }
            else
            {
                chkCloudy.Checked = false;                
            }

            if (Convert.ToBoolean(dgvListWeatherInfo.CurrentRow.Cells[9].Value.ToString()) == true)
            {
                chkWindy.Checked = true;                
            }
            else
            {
                chkWindy.Checked = false;                
            }
            if (Convert.ToBoolean(dgvListWeatherInfo.CurrentRow.Cells[10].Value.ToString()) == true)
            {
                chkRainy.Checked = true;                
            }
            else
            {
                chkRainy.Checked = false;                
            }

            // change button add information into save
            // and clear button into cancel
            btnAddInfo.Text = "Save";
            btnClear.Text = "Cancel";

        }

        // this function to load data from a row in listview into control box when user select a record and then click edit button 
        private void btnEdit_Click(object sender, EventArgs e)
        {
            
            try
            {
                // when the data in listview is not empty
                if (dgvListWeatherInfo.Rows.Count > 1)
                {
                    // if user not select any record but click edit
                    if (dgvListWeatherInfo.SelectedRows.Count == 0)
                    {
                        // a message warning user that they have to select a row
                        MessageBox.Show("You need to select a record", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    // if user select a record and click the edit button
                    else
                    {
                        loadRowDataToControl(ref indexOfEditedRow);
                    }
                }
                else
                {
                    //warning user when empty data
                    MessageBox.Show("Data list is empty", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                // show message error if catching any error
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        //this function run when user typing in the textbox 
        // prevent user type other character except number, negative sign, the dot for floating point number
        private void txtTemp_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when user press any key is number, backspace, the negative sign, the dot for floating number is allowed
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 45 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            // other key is restricted and can not type
            else
            {
                e.Handled = true;
            }
        }

        //this function run when user typing in the textbox 
        // prevent user type other character except number, the dot for floating point number
        private void txtHumidity_KeyPress(object sender, KeyPressEventArgs e)
        {
            // when user press any key is number, backspace, the dot for floating number is allowed
            if ((e.KeyChar >= 48 && e.KeyChar <= 57) || e.KeyChar == 8 || e.KeyChar == 46)
            {
                e.Handled = false;
            }
            // other key is restricted and can not type
            else
            {
                e.Handled = true;
            }
        }
    }
}
