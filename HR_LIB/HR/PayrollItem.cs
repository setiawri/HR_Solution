using System;
using System.Data;
using System.Collections.Generic;
using System.Data.SqlClient;
using LIBUtil;
using LOGGING;

namespace HR_LIB.HR
{
    public class PayrollItem
    {
        /*******************************************************************************************************/
        #region PUBLIC VARIABLES

        public Guid Id;
        public Guid Payrolls_Id;        
        public Guid RefId;
        public string Description;
        public decimal Amount;
        public string Notes;

        public String Payrolls_No;
        public Guid Employee_UserAccounts_Id;
        public DateTime Attendance_TimestampIn;

        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region DATABASE FIELDS

        public const string COL_DB_Id = "Id";
        public const string COL_DB_Payrolls_Id = "Payrolls_Id";
        public const string COL_DB_RefId = "RefId";
        public const string COL_DB_Description = "Description";
        public const string COL_DB_Amount = "Amount";
        public const string COL_DB_Notes = "Notes";
        public const string ARRAY_Payrolls_Id = "ARRAY_Payrolls_Id";

        public const string COL_Payrolls_No = "Payrolls_No";
        public const string COL_Employee_UserAccounts_Id = "Employee_UserAccounts_Id";
        public const string COL_DescriptionAndNotes = "DescriptionAndNotes";
        public const string COL_Attendances_TimestampIn = "Attendances_TimestampIn";


        #endregion PUBLIC VARIABLES
        /*******************************************************************************************************/
        #region CONSTRUCTOR METHODS

        public PayrollItem() { }

        #endregion CONSTRUCTOR METHODS
        /*******************************************************************************************************/
        #region DATABASE METHODS

        public static DataTable addRow(DataTable datatable, Guid? employee_UserAccounts_Id, Guid? refId, string description, decimal amount, string notes)
        {
            DataRow row;

            //populate using random id to get columns structure with no rows
            if (datatable == null)
            {
                datatable = get(Guid.NewGuid());
                Util.setDataTablePrimaryKey(datatable, COL_DB_Id);
            }

            row = datatable.NewRow();

            //create row
            row[COL_DB_Id] = Guid.NewGuid();
            row[COL_Employee_UserAccounts_Id] = employee_UserAccounts_Id;
            row[COL_DB_RefId] = refId;
            row[COL_DB_Description] = description;
            row[COL_DB_Amount] = amount;
            row[COL_DB_Notes] = notes;
            row[COL_DescriptionAndNotes] = Util.append(row[COL_DB_Description].ToString(), notes, Environment.NewLine);

            datatable.Rows.Add(row);

            return datatable;
        }

        public static DataTable get(Guid Payrolls_Id)
        {
            return get(new List<Guid?>() { Payrolls_Id});
        }

        public static DataTable get(List<Guid?> Payrolls_Id)
        {
            DataTable datatable;
            using (SqlConnection sqlConnection = new SqlConnection(DBConnection.ConnectionString))
                datatable = get(sqlConnection, Payrolls_Id);
            return datatable;
        }
        public static DataTable get(SqlConnection sqlConnection, List<Guid?> Payrolls_Id)
        {
            if (Payrolls_Id == null)
            {
                Payrolls_Id = new List<Guid?>();
                Payrolls_Id.Add(new Guid());
            }

            SqlQueryResult result = DBConnection.query(
                QueryTypes.FillByAdapter,
                "PayrollItems_get",
                    DBConnection.createTableParameters(
                        new SqlQueryTableParameterGuid(ARRAY_Payrolls_Id, Payrolls_Id.ToArray())
                    )
                );

            return result.Datatable;
        }


        
        #endregion DATABASE METHODS
        /*******************************************************************************************************/
        #region CLASS METHODS
       
        #endregion CLASS METHODS
        /*******************************************************************************************************/
    }
}

