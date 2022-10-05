using InterestModuleDataControl.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterestModuleDataControl
{
    public class InterestModuleManager
    {
        private readonly string _connectionString;
        private DataAccess db = new DataAccess();
        public InterestModuleManager(string connectionStringName)
        {
            _connectionString = Helper.CnnValue(connectionStringName);
        }
        public List<Interest> GetAllInterests()
        {
            string sql = "GetAllInterests";
            return db.LoadData<Interest, dynamic>(sql, new { InterestId = (int?) null }, _connectionString);
        }

        public Interest GetInterest(int Id)
        {
            string sql = "GetAllInterests";
            return db.LoadData<Interest, dynamic>(sql, new { InterestId = Id }, _connectionString).FirstOrDefault();
        }

        public List<Status> GetUniqueStatusList()
        {
            string sql = "GetUniqueStatusList";
            return db.LoadData<Status, dynamic>(sql, new { }, _connectionString);
        }

        public List<Instrument> GetUniqueInstrumentsList()
        {
            string sql = "GetUniqueInstrumentsList";
            return db.LoadData<Instrument, dynamic>(sql, new { }, _connectionString);
        }

        public List<Interest> FilterInterestData(string instrumentCode, int? statusId, DateTime? startDateValue, DateTime? endDateValue)
        {
            string sql = "FilterInterestData";
            return db.LoadData<Interest, dynamic>(sql, new { InstrumentCode = instrumentCode, StatusId = statusId, StartDate = startDateValue, EndDate = endDateValue  }, _connectionString);
        }

        public void CreateInterestRecord(Interest interestRecord) {
            string sql = "InsertNewInterestRecord";
            db.SaveData(sql, new { InstrumentCode = interestRecord.InstrumentCode, StatusID = interestRecord.StatusID, EffectiveDate = interestRecord.EffectiveDate, InterestRate = interestRecord.InterestRate }, _connectionString);
        }
        public void UpdateInterestRecord(Interest interestRecord)
        {
            string sql = "UpdateInterestRecord";
            db.SaveData(sql, new { Id = interestRecord.Id, InstrumentCode = interestRecord.InstrumentCode, StatusID = interestRecord.StatusID, EffectiveDate = interestRecord.EffectiveDate, InterestRate = interestRecord.InterestRate }, _connectionString);
        }

        public void RemoveInterestRecord(int interestId)
        {
            string sql = "RemoveInterestRecord";
            db.SaveData(sql, new { Id = interestId}, _connectionString);
        }

        public void UpdateInterestStatus(int interestId, int statusId)
        {
            string sql = "UpdateInterestStatus";
            db.SaveData(sql, new { Id = interestId, StatusID = statusId }, _connectionString);
        }
    }
}
