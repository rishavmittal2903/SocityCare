using SocietyCare.Enums;
using SocietyCare.Helper;
using System;
using System.Data;

namespace SocietyCare.Contracts
{
    public class UserDetails
    {
        public string userId { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
        public WorkerStatus workerStatus { get; set; }
        public UserType userType { get; set; }
        public Address address { get; set; }
        public AccountType accountType { get; set; }
        public Documents userDocuments { get; set; }
        public bool isExpire { get; set; }
        public AccountStatus accountStatus { get; set; }
        public BankAccountDetail accountDetail { get; set; }


        public void Fill(IDataRecord dataRecord)
        {
            this.userId = dataRecord.ReadValue<string>("UserId");
            this.userName = dataRecord.ReadValue<string>("userName");
            this.workerStatus = ((WorkerStatus)Enum.Parse(typeof(WorkerStatus), dataRecord.ReadValue<int>("workerStatus").ToString()));
            this.userType = ((UserType)Enum.Parse(typeof(UserType), dataRecord.ReadValue<int>("UserType").ToString()));
            //this.address = "";
            //this.accountType = ((AccountType)Enum.Parse(typeof(AccountType), dataRecord.ReadValue<int>("accountType").ToString()));
            this.userType = ((UserType)Enum.Parse(typeof(UserType), dataRecord.ReadValue<int>("UserType").ToString()));
            
            this.isExpire= dataRecord.ReadValue<bool>("isExpire");


        }
    }
}
