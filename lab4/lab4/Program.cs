using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            DataSet set = loaddata();

            DataTable usersTable = set.Tables["users"];
            DataTable groupsTable = set.Tables["groups"];


            DataRelation relation = new DataRelation("group_user",
                groupsTable.Columns["groupid"],
                usersTable.Columns["groupid"]);

            set.Relations.Add(relation);

            //DataRow[] groupRows = groupsTable.Select("groupid = 2");
            //DataRow[] memberRows = groupRows[0].GetChildRows("group_user");

            //foreach(var row in memberRows)
            //{
            //    Console.WriteLine(row["userName"] +" " + row["groupid"]);
            //}

            //DataRow[] chilrow = usersTable.Select("userid = 8");

            //DataRow parentRow = chilrow[0].GetParentRow("group_user");
            //Console.WriteLine(parentRow["groupname"] + " " + parentRow["groupid"]);

            //DataColumn[] primarykey = new DataColumn[] { usersTable.Columns["userid"] };

            //usersTable.PrimaryKey = primarykey;

            //DataRow row = usersTable.Rows.Find("1");

            //Console.WriteLine(row["username"] + " " + row["userid"]);

            //Constraint constraint = new UniqueConstraint(usersTable.Columns["userid"], true);
            //usersTable.Constraints.Add(constraint);


            DataColumn parent = set.Tables["groups"].Columns["groupid"];
            DataColumn child = set.Tables["users"].Columns["groupid"];

            ForeignKeyConstraint constraint = new ForeignKeyConstraint("FK_Group_Users", parent, child);

            constraint.UpdateRule = Rule.Cascade;
            constraint.DeleteRule = Rule.SetNull;

            set.Tables["user"].Constraints.Add(constraint);
            Console.ReadLine();
        }

        private static DataSet loaddata()
        {
            var con = new SqlConnection(@"data source = DESKTOP-2V5F3CA\TUNGNH230802;
                                        database = quanly;
                                        integrated security=SSPI");

            con.Open();

            var cmd = "select * from users";
            var dataAdapter = new SqlDataAdapter(cmd, con);
            var dataset = new DataSet();

            dataAdapter.Fill(dataset, "users");

            dataAdapter.SelectCommand.CommandText = "select * from groups";
            dataAdapter.Fill(dataset, "groups");

            con.Close();

            return dataset;
        }
    }
}
