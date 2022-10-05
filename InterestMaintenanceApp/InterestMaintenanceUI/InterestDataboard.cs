using InterestMaintenanceUI.Extensions;
using InterestModuleDataControl;
using InterestModuleDataControl.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterestMaintenanceUI
{
    public partial class InterestDashBoard : Form, ISaveInterest
    {

        private List<Interest> interets = new List<Interest>();
        private BindingSource interetsBindingSource = new BindingSource();
        private List<Status> statuses = new List<Status>();
        private BindingSource statusesBindingSource = new BindingSource();
        private List<Instrument> instruments = new List<Instrument>();
        private BindingSource instrumentsBindingSource = new BindingSource();

        InterestModuleManager interestModule = new InterestModuleManager("InterestModuleDB");

        public InterestDashBoard()
        {
            InitializeComponent();
            LoadInterestData();
            LoadDataGridView();
            PopulateStatusDropDown();
            PopulateInstrumentDropDown();
        }

        private void newInterestButton_Click(object sender, EventArgs e)
        {
            LaundInterestForm(0);
        }
        private void LaundInterestForm(int InterestId) {
            InterestRecordForm newInterest = new InterestRecordForm(this, InterestId);
            //this.Enabled = false;
            newInterest.ShowDialog(this);
            //newInterest.Show();
        }

        private void LoadInterestData() {
            try
            {
                interets = interestModule.GetAllInterests();
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong with get data for interest. Please contact System admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadDataGridView()
        {
            interetsBindingSource.DataSource = interets;
            interestDataGridView.AutoGenerateColumns = false;
            interestDataGridView.DataSource = interetsBindingSource;
        }

        private void PopulateStatusDropDown() {
            LoadStatuses();

            statuses.Insert(0, new Status { Id = -1, StatusName = "" });
            statusesBindingSource.DataSource = statuses;
            interestStatusComboBox.DataSource = statusesBindingSource;
            interestStatusComboBox.DisplayMember = "StatusName";
            interestStatusComboBox.ValueMember = "Id";
        }

        private void PopulateInstrumentDropDown()
        {
            LoadInstruments();
            instruments.Insert(0, new Instrument { InstrumentCode = "", Description = "", Status = "" });
            instrumentsBindingSource.DataSource = instruments;
            interestIns_codeComboBox.DataSource = instrumentsBindingSource;
            interestIns_codeComboBox.DisplayMember = "Description";
            interestIns_codeComboBox.ValueMember = "InstrumentCode";


        }

        private void LoadStatuses() {
            try
            {
                statuses = interestModule.GetUniqueStatusList();
            }
            catch (Exception) {
                MessageBox.Show("Fail to get status list, Please contact system admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void LoadInstruments()
        {
            try
            {
                instruments = interestModule.GetUniqueInstrumentsList();
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to get Instrument list, Please contact system admin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void ClearFilters() {
            interestIns_codeComboBox.SelectedIndex = -1;
            interestStatusComboBox.SelectedIndex = -1;
            interestStartDateDatePicker.CustomFormat = " ";
            interestEndDateDatePicker.CustomFormat = " ";
        }

        private void clearFilterData_Click(object sender, EventArgs e)
        {
            ClearFilters();
            LoadInterestData();
            LoadDataGridView();
        }

        private void interestStartDateDatePicker_ValueChanged(object sender, EventArgs e)
        {
            interestStartDateDatePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void interestEndDateDatePicker_ValueChanged(object sender, EventArgs e)
        {
            interestEndDateDatePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void SearchFilterButton_Click(object sender, EventArgs e)
        {
            DateTime? startDateValue = null; //= interestStartDateDatePicker.CustomFormat;
            DateTime? endDateValue = null; //= interestStartDateDatePicker.CustomFormat;
            int? statusId = null;
            string instrumentCode = "";
            if (interestStartDateDatePicker.CustomFormat.Trim() != "") {
                startDateValue = interestStartDateDatePicker.Value;
            }

            if (interestEndDateDatePicker.CustomFormat.Trim() != "")
            {
                endDateValue = interestEndDateDatePicker.Value;
            }

            if (interestStatusComboBox.SelectedIndex > 0) {
                statusId = (int)interestStatusComboBox.SelectedValue;
                //statusId = statusItem.Id;
            }

            if (interestIns_codeComboBox.SelectedIndex > 0) {
                instrumentCode = interestIns_codeComboBox.SelectedValue.ToString();
            }
            try
            {
                interets = interestModule.FilterInterestData(instrumentCode, statusId, startDateValue, endDateValue);
                LoadDataGridView();
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to filter data, please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
            
        }

        private void reloadPicBox_Click(object sender, EventArgs e)
        {
            LoadInterestData();
            LoadDataGridView();
        }

        public void SaveInterest()
        {

            ClearFilters();
            LoadInterestData();
            LoadDataGridView();
        }

        public void EditinterestRecord() {

        }
        private void interestDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex < 4 || e.RowIndex < 0) { return; }
            int interestId = (int)interestDataGridView.Rows[e.RowIndex].Cells[0].Value;
            string status = interestDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            //if (MessageBox.Show("Are you sure you want to delete this record? ", "Remove record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) { 

            //}
            switch (e.ColumnIndex)
            {
                case 4:
                    if (status != "PENDING")
                    {
                        MessageBox.Show("Only pending records can be edited ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    LaundInterestForm(interestId);
                    break;
                case 5:
                    if (status != "PENDING")
                    {
                        MessageBox.Show("Only pending records can be approved ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (MessageBox.Show("Are you sure you want to approve this record? ", "Approve record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        try
                        {
                            interestModule.UpdateInterestStatus(interestId, 2);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fail to update status on the record, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        
                        LoadInterestData();
                        LoadDataGridView();
                    }
                    break;
                case 6:
                    if (status != "ACTIVE")
                    {
                        MessageBox.Show("Only active records can be canceled ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (MessageBox.Show("Are you sure you want to cancel this record? ", "Cancel record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            interestModule.UpdateInterestStatus(interestId, 3);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("fail to update interest status, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        LoadInterestData();
                        LoadDataGridView();
                    }
                    break;
                case 7:
                    if (status != "PENDING")
                    {
                        MessageBox.Show("Only pending records can be deleted ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;
                    }
                    if (MessageBox.Show("Are you sure you want to delete this record? ", "Remove record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        try
                        {
                            interestModule.RemoveInterestRecord(interestId);
                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Fail to delete interest record, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                        LoadInterestData();
                        LoadDataGridView();
                    }
                    break;
                default:
                    break;
            }
        }

        private void searchInterestTextField_Enter(object sender, EventArgs e)
        {
            if (searchInterestTextField.Text == "Search...")
            {
                searchInterestTextField.Text = "";
                searchInterestTextField.ForeColor = Color.Black;
            }
        }

        private void searchInterestTextField_Leave(object sender, EventArgs e)
        {
            if (searchInterestTextField.Text == "")
            {
                searchInterestTextField.Text = "Search...";
                searchInterestTextField.ForeColor = Color.LightGray;
            }
        }

        private void searchInterestTextField_TextChanged(object sender, EventArgs e)
        {
            searchDataGrdiView();
        }

        private void searchDataGrdiView() {

            string searchValue = searchInterestTextField.Text;
            if (searchValue != "" && searchValue != "Search...")
            {
                int number = -1;
                bool success = int.TryParse(searchValue, out number);


                List<Interest> searchedInterets = interets.Where(x => (x.Id == number && number != -1) || x.Description.ToLower().Contains(searchValue.ToLower()) || x.Status.ToLower().Contains(searchValue.ToLower()) || x.InstrumentCode.ToLower().Contains(searchValue.ToLower())).ToList();
                interetsBindingSource.DataSource = searchedInterets;
                interestDataGridView.AutoGenerateColumns = false;
                interestDataGridView.DataSource = interetsBindingSource;
            }
            else {

                LoadDataGridView();
            }
        }
    }
}
