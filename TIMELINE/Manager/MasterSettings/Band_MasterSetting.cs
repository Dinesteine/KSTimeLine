using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TIMELINE.Manager.Database;
using TIMELINE.Model.MasterSettings;
using TIMELINE.Universal_Statics;

namespace TIMELINE.Manager.MasterSettings
{
    class Band_MasterSetting
    {
        public List<Band_Model> BandDetail()
        {

            List<Band_Model> returninglist = new List<Band_Model>();
            StoreProcedureHelper sph = new StoreProcedureHelper();
            DataSet ds = sph.getBandhDetail();
            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                Band_Model bm = new Band_Model();
                bm.Id = int.Parse(dr["id"].ToString());
                bm.BandName = dr["fldName"].ToString();
                bm.BandDate = Convert.ToDateTime(dr["fldDate"].ToString());

                returninglist.Add(bm);
            }
            return returninglist;
        }

        public void AddBand(int ID, string bandName, DateTime bandDate)
        {
            SqlConnection con = new SqlConnection(Constants.DbConstant.connectionString);
            SqlCommand cmd = new SqlCommand("sp_ADDBAND", con);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter id = new SqlParameter();
            id.ParameterName = "id";
            id.Value = ID;
            cmd.Parameters.Add(id);

            SqlParameter fldName = new SqlParameter();
            fldName.ParameterName = "fldName";
            fldName.Value = bandName;
            cmd.Parameters.Add(fldName);

            SqlParameter fldDate = new SqlParameter();
            fldDate.ParameterName = "fldDate";
            fldDate.Value = bandDate;
            cmd.Parameters.Add(fldDate);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }

}
