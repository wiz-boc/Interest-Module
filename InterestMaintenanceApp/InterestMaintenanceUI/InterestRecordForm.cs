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
    public partial class InterestRecordForm : Form
    {
        ISaveInterest _parent;
        int _interestId;
        Interest interest = new Interest();
        private List<Instrument> instruments = new List<Instrument>();
        private BindingSource instrumentsBindingSource = new BindingSource();
        InterestModuleManager interestModule = new InterestModuleManager("InterestModuleDB");
        public InterestRecordForm(ISaveInterest parent, int interestId)
        {
            _parent = parent;
            _interestId = interestId;
            
            InitializeComponent();
            
            PopulateInstrumentDropDown();
            if (_interestId != 0)
            {
                interestHeaderLabel.Text = "Edit " + interestHeaderLabel.Text;
                GetInterestRecord();
            }
            else {
                interestHeaderLabel.Text = "New " + interestHeaderLabel.Text;
                GenerateNewRecordData();
            }

            PopulateFormFields();
        }

        private void GenerateNewRecordData() {
            interest = new Interest();
            interest.EffectiveDate = DateTime.Now;
            interest.StatusID = 1;
            interest.InstrumentCode = "";
            interest.InterestRate = 0.0;
            //interest.Status = "Pending";


        }
        private void PopulateFormFields()
        {
            errorMessageLabel.Text = "";
            if (effectiveDatePicker.CustomFormat.Trim() != "" || _interestId != 0) {
                effectiveDatePicker.Value = interest.EffectiveDate;
            }

            if (_interestId != 0)
            {
                statusLabel.Text = "Status : " + interest.Status;
            }

            interestRateSelector.Value = (decimal) interest.InterestRate;
            instrumentComboBox.SelectedItem = instruments.SingleOrDefault( x => x.InstrumentCode == interest.InstrumentCode);
        }

        private void GetInterestRecord() {
            try
            {
                interest = interestModule.GetInterest(_interestId);
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to get interest records, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void interestSaveButton_Click(object sender, EventArgs e)
        {
            if(validateForm())
            {
                if (MessageBox.Show("Are you sure you want to save this record? ", "Save record", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    UpdateInterestValue();
                    if (_interestId != 0)
                    {
                        UpdateInterestRecord();
                    }
                    else
                    {
                        SaveInterestRecord();
                    }

                    _parent.SaveInterest();
                    //(InterestDashBoard) = true;
                    this.Close();
                }
                
            }      
        }

        private void UpdateInterestRecord()
        {
            try
            {
                interestModule.UpdateInterestRecord(interest);
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to update interest records, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void SaveInterestRecord() {
            try
            {
                if (_interestId != 0)
                {
                    interestModule.UpdateInterestRecord(interest);
                }
                else
                {
                    interestModule.CreateInterestRecord(interest);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong please retry, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool validateForm() {

            if (instrumentComboBox.SelectedIndex < 1) {
                errorMessageLabel.Text = "Please select an instrument";
                instrumentComboBox.Focus();
                return false;
            }

            if (interestRateSelector.Value == 0)
            {
                errorMessageLabel.Text = "Please enter a interest rate";
                interestRateSelector.Focus();
                return false;
            }

            if (effectiveDatePicker.CustomFormat.Trim() == "")
            {
                errorMessageLabel.Text = "Please select an effective date";
                effectiveDatePicker.Focus();
                return false;
            }

            if (effectiveDatePicker.Value.Date <  DateTime.Now.Date)
            {
                errorMessageLabel.Text = "Effective date cannot be backdated";
                effectiveDatePicker.Focus();
                return false;
            }
            return true;
        }

        private void UpdateInterestValue() {
            interest.EffectiveDate = effectiveDatePicker.Value;
            interest.InstrumentCode = instrumentComboBox.SelectedValue.ToString();
            interest.InterestRate = (double)interestRateSelector.Value;
            interest.RecordDate = DateTime.Now;
            interest.StatusID = 1;
        }

        private void PopulateInstrumentDropDown()
        {
            LoadInstruments();
            instruments.Insert(0, new Instrument { InstrumentCode = "", Description = "", Status = "" });
            instrumentsBindingSource.DataSource = instruments;
            instrumentComboBox.DataSource = instrumentsBindingSource;
            instrumentComboBox.DisplayMember = "Description";
            instrumentComboBox.ValueMember = "InstrumentCode";

        }

        private void LoadInstruments()
        {
            try
            {
                instruments = interestModule.GetUniqueInstrumentsList();
            }
            catch (Exception)
            {
                MessageBox.Show("Fail to get list of instrument records, Please retry", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void effectiveDatePicker_ValueChanged(object sender, EventArgs e)
        {
            effectiveDatePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void restoreDataButton_Click(object sender, EventArgs e)
        {
            if (_interestId == 0) {
                effectiveDatePicker.CustomFormat = " ";
            }
            PopulateFormFields();
        }
    }
}
