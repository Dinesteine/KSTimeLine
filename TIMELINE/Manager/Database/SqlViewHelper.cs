using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIMELINE.Manager.Database
{
    class SqlViewHelper
    {

        public DataSet getOpeningPaidLeave()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getOpeningPaidLeave", "SELECT");
        }

        public DataSet getUnPaidLeave()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getUnPaidLeave", "SELECT");
        }

        public DataSet getAuthEmpList()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getAuthEmpList", "SELECT");
        }

        public DataSet getAuthEmpListAll()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getAuthEmpListAll", "SELECT");
        }

        public DataSet getDayCount()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getDayCount", "SELECT");
        }

        public DataSet getDepartmentList()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getDepartmentList", "SELECT");
        }

        public DataSet getEmpDetail()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getEmpDetail", "SELECT");
        }

        public DataSet getEmpWorkHour()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getDepartmentList", "SELECT");
        }

        public DataSet getEmpWorkHourDatise()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getEmpWorkHourDatise", "SELECT");
        }

        public DataSet getEmpList()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getEmpList", "SELECT");
        }

        public DataSet getEmpListAll()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getEmpListAll", "SELECT");
        }

        public DataSet EmpListAllV7()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "EmpListAllV7", "SELECT");
        }

        public DataSet getEmpNames()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getEmpNames", "SELECT");
        }

        public DataSet getExpiryLeave()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getExpiryLeave", "SELECT");
        }

        public DataSet getSalaryPaid()
        {
            // Dictionary<string, object> dicData = SqlParameters.StoreProcedure.monthalyAttadance(toDate, fromDate, eId);
            return DataBaseHelper.QueryTableOrView.executeQuery(new Dictionary<string, object>(), "getSalaryPaid", "SELECT");
        }

    }

}
