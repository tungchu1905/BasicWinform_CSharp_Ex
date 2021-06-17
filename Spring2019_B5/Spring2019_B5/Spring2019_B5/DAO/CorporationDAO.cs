using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace Spring2019_B5.DAO
{
    class CorporationDAO
    {
        string corporationNo;
        string corporationName;
        string street;
        string regionName;

        public CorporationDAO(string corporationNo, string corporationName, string street, string regionName)
        {
            this.corporationNo = corporationNo;
            this.corporationName = corporationName;
            this.street = street;
            this.regionName = regionName;
        }

        public string CorporationNo { get => corporationNo; set => corporationNo = value; }
        public string CorporationName { get => corporationName; set => corporationName = value; }
        public string Street { get => street; set => street = value; }
        public string RegionName { get => regionName; set => regionName = value; }

        internal static List<CorporationDAO> getListCorpo()
        {
            List<CorporationDAO> list = new List<CorporationDAO>();
            DataTable data = Database.getDataSql("select corp_no, corp_name, corporation.street, region.region_name from corporation, region where corporation.region_no = region.region_no ");
            foreach (DataRow row in data.Rows)
            {
                string id = row["corp_no"].ToString();
                string name = row["corp_name"].ToString();
                string street = row["street"].ToString();
                string region = row["region_name"].ToString();
                CorporationDAO co = new CorporationDAO(id,name,street,region);
                list.Add(co);
            }
            return list;
        }

        internal static void Delete(string v)
        {
            Database.Execute("delete from corporation where corp_no = '"+v+"'");
        }
        internal static ArrayList LoadDataByName(ArrayList list, string id)
        {
            DataTable data = Database.getDataSql("select *from corporation where corp_no = '" + id + "'");
            
            list[0] = data.Rows[0]["corp_no"].ToString();
            list[1] = data.Rows[0]["corp_name"].ToString();
            list[2] = data.Rows[0]["street"].ToString();
            list[3] = data.Rows[0]["expr_dt"].ToString();
            return list;
        }
        internal static void Update(string cname, string street,DateTime date,string id)
        {
            Database.Execute("update corporation set corp_name = '" + cname + "', street = '" + street + "',expr_dt = '" + date+"' where corp_no = '"+id+"'");
        }
    }
}
