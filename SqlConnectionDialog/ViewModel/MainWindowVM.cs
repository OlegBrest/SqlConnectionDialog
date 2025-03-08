using SqlConnectionDialog.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SqlConnectionDialog.ViewModel
{
    public class MainWindowVM : NotifyUIBase
    {
        private System.Data.SqlClient.SqlConnectionStringBuilder _sqlConnectionStringBuilder = new System.Data.SqlClient.SqlConnectionStringBuilder();
        public System.Data.SqlClient.SqlConnectionStringBuilder sqlConnectionStringBuilder
        {
            get => _sqlConnectionStringBuilder;
            set
            {
                _sqlConnectionStringBuilder = value;
                onPropertyChanged(nameof(sqlConnectionStringBuilder));
                onPropertyChanged();
                UpdateAllSQL();
            }
        }
        #region SQL_properties
        public System.Data.SqlClient.ApplicationIntent ApplicationIntent
        {
            get => _sqlConnectionStringBuilder.ApplicationIntent;
            set
            {
                sqlConnectionStringBuilder.ApplicationIntent = value;
                onPropertyChanged(nameof(ApplicationIntent));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string ApplicationName
        {
            get => sqlConnectionStringBuilder.ApplicationName;
            set
            {
                sqlConnectionStringBuilder.ApplicationName = value;
                onPropertyChanged(nameof(ApplicationName));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string AttachDBFilename
        {
            get => sqlConnectionStringBuilder.AttachDBFilename;
            set
            {
                sqlConnectionStringBuilder.AttachDBFilename = value;
                onPropertyChanged(nameof(AttachDBFilename));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string ConnectionString
        {
            get => sqlConnectionStringBuilder.ConnectionString;
            set
            {
                try
                {
                    sqlConnectionStringBuilder.ConnectionString = value;
                }
                catch { }
                UpdateAllSQL();
            }
        }
        public int ConnectRetryCount
        {
            get => sqlConnectionStringBuilder.ConnectRetryCount;
            set
            {
                sqlConnectionStringBuilder.ConnectRetryCount = value;
                onPropertyChanged(nameof(ConnectRetryCount));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public int ConnectRetryInterval
        {
            get => sqlConnectionStringBuilder.ConnectRetryInterval;
            set
            {
                sqlConnectionStringBuilder.ConnectRetryInterval = value;
                onPropertyChanged(nameof(ConnectRetryInterval));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public int ConnectTimeout
        {
            get => sqlConnectionStringBuilder.ConnectTimeout;
            set
            {
                sqlConnectionStringBuilder.ConnectTimeout = value;
                onPropertyChanged(nameof(ConnectTimeout));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public int Count
        { get => sqlConnectionStringBuilder.Count; }
        public string CurrentLanguage
        {
            get => sqlConnectionStringBuilder.CurrentLanguage;
            set
            {
                sqlConnectionStringBuilder.CurrentLanguage = value;
                onPropertyChanged(nameof(CurrentLanguage));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string DataSource
        {
            get => sqlConnectionStringBuilder.DataSource;
            set
            {
                sqlConnectionStringBuilder.DataSource = value;
                onPropertyChanged(nameof(DataSource));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool Encrypt
        {
            get => sqlConnectionStringBuilder.Encrypt;
            set
            {
                sqlConnectionStringBuilder.Encrypt = value;
                onPropertyChanged(nameof(Encrypt));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool Enlist
        {
            get => sqlConnectionStringBuilder.Enlist;
            set
            {
                sqlConnectionStringBuilder.Enlist = value;
                onPropertyChanged(nameof(Enlist));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string FailoverPartner
        {
            get => sqlConnectionStringBuilder.FailoverPartner;
            set
            {
                sqlConnectionStringBuilder.FailoverPartner = value;
                onPropertyChanged(nameof(FailoverPartner));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string InitialCatalog
        {
            get => sqlConnectionStringBuilder.InitialCatalog;
            set
            {
                sqlConnectionStringBuilder.InitialCatalog = value;
                onPropertyChanged(nameof(InitialCatalog));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool IntegratedSecurity
        {
            get => sqlConnectionStringBuilder.IntegratedSecurity;
            set
            {
                sqlConnectionStringBuilder.IntegratedSecurity = value;
                onPropertyChanged(nameof(IntegratedSecurity));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool IsFixedSize
        { get => sqlConnectionStringBuilder.IsFixedSize; }
        public bool IsReadOnly
        { get => sqlConnectionStringBuilder.IsReadOnly; }
        public System.Collections.ICollection Keys
        { get => sqlConnectionStringBuilder.Keys; }
        public int LoadBalanceTimeout
        {
            get => sqlConnectionStringBuilder.LoadBalanceTimeout;
            set
            {
                sqlConnectionStringBuilder.LoadBalanceTimeout = value;
                onPropertyChanged(nameof(LoadBalanceTimeout));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public int MaxPoolSize
        {
            get => sqlConnectionStringBuilder.MaxPoolSize;
            set
            {
                sqlConnectionStringBuilder.MaxPoolSize = value;
                onPropertyChanged(nameof(MaxPoolSize));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public int MinPoolSize
        {
            get => sqlConnectionStringBuilder.MinPoolSize;
            set
            {
                sqlConnectionStringBuilder.MinPoolSize = value;
                onPropertyChanged(nameof(MinPoolSize));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool MultipleActiveResultSets
        {
            get => sqlConnectionStringBuilder.MultipleActiveResultSets;
            set
            {
                sqlConnectionStringBuilder.MultipleActiveResultSets = value;
                onPropertyChanged(nameof(MultipleActiveResultSets));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool MultiSubnetFailover
        {
            get => sqlConnectionStringBuilder.MultiSubnetFailover;
            set
            {
                sqlConnectionStringBuilder.MultiSubnetFailover = value;
                onPropertyChanged(nameof(MultiSubnetFailover));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public int PacketSize
        {
            get => sqlConnectionStringBuilder.PacketSize;
            set
            {
                sqlConnectionStringBuilder.PacketSize = value;
                onPropertyChanged(nameof(PacketSize));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string Password
        {
            get => sqlConnectionStringBuilder.Password;
            set
            {
                sqlConnectionStringBuilder.Password = value;
                onPropertyChanged(nameof(Password));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool PersistSecurityInfo
        {
            get => sqlConnectionStringBuilder.PersistSecurityInfo;
            set
            {
                sqlConnectionStringBuilder.PersistSecurityInfo = value;
                onPropertyChanged(nameof(PersistSecurityInfo));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public System.Data.SqlClient.PoolBlockingPeriod PoolBlockingPeriod
        {
            get => sqlConnectionStringBuilder.PoolBlockingPeriod;
            set
            {
                sqlConnectionStringBuilder.PoolBlockingPeriod = value;
                onPropertyChanged(nameof(PoolBlockingPeriod));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool Pooling
        {
            get => sqlConnectionStringBuilder.Pooling;
            set
            {
                sqlConnectionStringBuilder.Pooling = value;
                onPropertyChanged(nameof(Pooling));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool Replication
        {
            get => sqlConnectionStringBuilder.Replication;
            set
            {
                sqlConnectionStringBuilder.Replication = value;
                onPropertyChanged(nameof(Replication));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string TransactionBinding
        {
            get => sqlConnectionStringBuilder.TransactionBinding;
            set
            {
                sqlConnectionStringBuilder.TransactionBinding = value;
                onPropertyChanged(nameof(TransactionBinding));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool TrustServerCertificate
        {
            get => sqlConnectionStringBuilder.TrustServerCertificate;
            set
            {
                sqlConnectionStringBuilder.TrustServerCertificate = value;
                onPropertyChanged(nameof(TrustServerCertificate));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string TypeSystemVersion
        {
            get => sqlConnectionStringBuilder.TypeSystemVersion;
            set
            {
                sqlConnectionStringBuilder.TypeSystemVersion = value;
                onPropertyChanged(nameof(TypeSystemVersion));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public string UserID
        {
            get => sqlConnectionStringBuilder.UserID;
            set
            {
                sqlConnectionStringBuilder.UserID = value;
                onPropertyChanged(nameof(UserID));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public bool UserInstance
        {
            get => sqlConnectionStringBuilder.UserInstance;
            set
            {
                sqlConnectionStringBuilder.UserInstance = value;
                onPropertyChanged(nameof(UserInstance));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        public System.Collections.ICollection Values
        { get => sqlConnectionStringBuilder.Values; }
        public string WorkstationID
        {
            get => sqlConnectionStringBuilder.WorkstationID;
            set
            {
                sqlConnectionStringBuilder.WorkstationID = value;
                onPropertyChanged(nameof(WorkstationID));
                onPropertyChanged(nameof(ConnectionString));
            }
        }
        #endregion

        #region Form_properties
        private string _testResult = "Status:unknown";

        public string testResult
        {
            get => _testResult;
            set
            {
                _testResult =string.Format("Status:{0}", value);
                onPropertyChanged(nameof(testResult));
            }
        }

        private List<string> _dbLists = new List<string>();
        public List<string> dbLists
        {
            get => _dbLists;
            set
            {
                _dbLists = value;
                onPropertyChanged(nameof(dbLists));
            }
        }

        #endregion

        private void UpdateAllSQL()
        {
            onPropertyChanged(nameof(ConnectionString));
            onPropertyChanged(nameof(ApplicationIntent));
            onPropertyChanged(nameof(ApplicationName));
            onPropertyChanged(nameof(AttachDBFilename));
            onPropertyChanged(nameof(ConnectRetryCount));
            onPropertyChanged(nameof(ConnectRetryInterval));
            onPropertyChanged(nameof(ConnectTimeout));
            onPropertyChanged(nameof(CurrentLanguage));
            onPropertyChanged(nameof(DataSource));
            onPropertyChanged(nameof(Encrypt));
            onPropertyChanged(nameof(Enlist));
            onPropertyChanged(nameof(FailoverPartner));
            onPropertyChanged(nameof(InitialCatalog));
            onPropertyChanged(nameof(IntegratedSecurity));
            onPropertyChanged(nameof(LoadBalanceTimeout));
            onPropertyChanged(nameof(MaxPoolSize));
            onPropertyChanged(nameof(MinPoolSize));
            onPropertyChanged(nameof(MultipleActiveResultSets));
            onPropertyChanged(nameof(MultiSubnetFailover));
            onPropertyChanged(nameof(PacketSize));
            onPropertyChanged(nameof(Password));
            onPropertyChanged(nameof(PersistSecurityInfo));
            onPropertyChanged(nameof(PoolBlockingPeriod));
            onPropertyChanged(nameof(Pooling));
            onPropertyChanged(nameof(Replication));
            onPropertyChanged(nameof(TransactionBinding));
            onPropertyChanged(nameof(TrustServerCertificate));
            onPropertyChanged(nameof(TypeSystemVersion));
            onPropertyChanged(nameof(UserID));
            onPropertyChanged(nameof(UserInstance));
            onPropertyChanged(nameof(WorkstationID));
        }

        private DelegateCommand _testConnection;
        public ICommand testConnection => _testConnection ??= new DelegateCommand(PerformtestConnection);

        private void PerformtestConnection(object commandParameter)
        {
            using (SqlConnection testConn = new SqlConnection(ConnectionString))
            {
                try
                {
                    testConn.Open();
                    if (testConn.State == System.Data.ConnectionState.Open)
                    {
                        testResult = "Ok";
                        DataTable sqlSchema = testConn.GetSchema("Databases");
                        ListTables(sqlSchema);
                    }
                    else if (testConn.State == System.Data.ConnectionState.Broken)
                    {
                        testResult = "Broken";
                    }
                    else if (testConn.State == System.Data.ConnectionState.Connecting)
                    {
                        testResult = "Connecting";
                    }
                    else
                    {
                        testResult = "No connection";
                    }
                }
                catch (Exception ex)
                {
                    testResult = ex.Message;
                    dbLists=new List<string>();
                }
            }
        }

        public void ListTables(DataTable dt)
        {
            List<string>  tempdbLists = new List<string>();
            GC.Collect();
            foreach (DataRow row in dt.Rows)
            {
                string tablename = (string)row[0];
                tempdbLists.Add(tablename);
            }
            dbLists = tempdbLists;
            //onPropertyChanged(nameof(dbLists));
        }
    }
}
