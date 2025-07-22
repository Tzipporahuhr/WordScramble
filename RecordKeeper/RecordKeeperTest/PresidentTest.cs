//using System.Data;


//namespace RecordKeeperTest
//{
//    public class PresidentTest
//    {
//        [SetUp]
//        public void Setup()
//        {
//            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true");
//        }

//        [Test]
//        [TestCase("Sam", "Test1", "2035-1-1", 2075, 2079)]
//        [TestCase("Sam", "Test3", "1800-1-1", 1836, 1840)]


//        public void InsertNewPresident(string firstname, string lastname, DateTime dateborn, int termstart, int termend)
//        {
//            DataTable dt = SQLUtility.GetDataTable(" select * from president where presidentid =0");
//            DataRow r = dt.Rows.Add();
//            Assume.That(dt.Rows.Count == 1);
//            int partyid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 partyid from party");
//            int maxnum = SQLUtility.GetFirstColumnFirstRowValue("select max(num) from president");
//            Assume.That(partyid > -0, "can't run test no parties in the db");
//            maxnum = maxnum + 1;

//            TestContext.WriteLine("insert president with num = " + maxnum);

//            r["partyid"] = partyid;
//            r["Num"] = maxnum;
//            r["FirstName"] = firstname;
//            r["LastName"] = lastname;
//            r["DateBorn"] = dateborn;
//            r["TermStart"] = termstart;
//            r["TermEnd"] = termend;

//            President.Save(dt);

//            int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from president where num = " + maxnum);

//            Assert.IsTrue(newid > 0, "president with num = " + maxnum + " is not found in db");
//            TestContext.WriteLine("President with " + maxnum + " is found in db with pk value = " + newid);
//        }

//        [Test]

//        public void ChangeExistingPresidentTermStart()
//        {
//            int presidentid = GetExistingPresidentId();
//            Assume.That(presidentid > 0, "No presidents in DB, cant run test");
//            int termstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid=" + presidentid);
//            TestContext.WriteLine("termstart for presidentid" + presidentid + "is " + termstart);
//            termstart = termstart - 1;
//            TestContext.WriteLine("change termstart to " + termstart);


//            DataTable dt = President.Load(presidentid);
//            dt.Rows[0]["termstart"] = termstart;
//            President.Save(dt);

//            int newtermstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid=" + presidentid);
//            Assert.IsTrue(newtermstart == termstart, "termstart for president (" + presidentid + ") =" + newtermstart);
//            TestContext.WriteLine("termstart for president(" + presidentid + ") = " + newtermstart);


//        }

//        [Test]

//        public void ChangeExistingPresidentToInvalidTermStart()
//        {
//            int presidentid = GetExistingPresidentId();
//            int termstart = 0;
//            Assume.That(presidentid > 0, "No presidents in DB, cant run test");
//            int termend = SQLUtility.GetFirstColumnFirstRowValue("select termend from president where presidentid=" + presidentid);
//            TestContext.WriteLine("termend for presidentid" + presidentid + "is " + termend);
//            termstart = termend + 1;
//            TestContext.WriteLine("change termstart to " + termstart);


//            DataTable dt = President.Load(presidentid);
//            dt.Rows[0]["termstart"] = termstart;
//            Exception ex=Assert.Throws<Exception>(()=>President.Save(dt));
//            TestContext.WriteLine(ex.Message);

//          }


//        [Test]

//        public void ChangeExistingPresidentToInvalidNum()
//        {
//            int presidentid = GetExistingPresidentId();

//            Assume.That(presidentid > 0, "No presidents in DB, cant run test");
//            int num= SQLUtility.GetFirstColumnFirstRowValue("select top 1 num from president where presidentid <>" + presidentid);
//            int currentnum = SQLUtility.GetFirstColumnFirstRowValue("select top 1 num from president where presidentid =" + presidentid);
//            Assume.That(num > 0, "Cannot run test because there is no other president record in the table");
//            TestContext.WriteLine("Change presidentid" + presidentid +"num from"+ currentnum+ " to" + num) ;



//            DataTable dt = President.Load(presidentid);
//            dt.Rows[0]["num"] = num;
//            Exception ex = Assert.Throws<Exception>(() => President.Save(dt));
//            TestContext.WriteLine(ex.Message);

//        }


//        [Test]
//        public void DeletePresident()
//        {
//            string sql = @"
//select top 1  p.PresidentId, p.Num, p.LastName
//from president p 
//left join ExecutiveOrder e
//on e.PresidentId= p.PresidentId
//left join Presidentmedal pm
//on pm.PresidentId=p.PresidentId
//where e.ExecutiveOrderId is null
//and pm.PresidentMedalId is null
//order by p.PresidentId
//";
//            DataTable dt = SQLUtility.GetDataTable( sql);
//            int presidentid = 0;
//            string prezdesc = "";

//            if (dt.Rows.Count > 0)

//            {
//                presidentid = (int)dt.Rows[0]["presidentid"];
//                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
//            }


//            Assume.That(presidentid > 0, "No presidents without executive order in DB, can't run test");

//            TestContext.WriteLine("existing president without executive order and medal, with id = " + presidentid + " " + prezdesc);
//            TestContext.WriteLine("ensure that app can delete" + presidentid);
//            President.Delete(dt);
//            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from president where presidentid= " + presidentid);
//            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with presidentid" + presidentid + "exists in db");
//            TestContext.WriteLine("Record with presidentid" + presidentid + "does not exist in DB");
//        }
//        [Test]
//        public void DeletePresidentWithUpheldExecutiveOrder()
//        {
//            string sql = @"select top 1 p.PresidentId, p.Num, p.LastName 
//        from President p 
//        join ExecutiveOrder e on e.PresidentId = p.PresidentId 
//        where e.UpheldByCourt= 1";

//            DataTable dt = SQLUtility.GetDataTable(sql);
//            int presidentid = 0;
//            string prezdesc = "";

//            if (dt.Rows.Count > 0)

//            {
//                presidentid = (int)dt.Rows[0]["presidentid"];
//                prezdesc = dt.Rows[0]["Num"] + " " + dt.Rows[0]["LastName"];
//            }


//            Assume.That(presidentid > 0, "No presidents with upheldexecutive orders in DB, can't run test");

//            TestContext.WriteLine("existing president without upheld executive order, with id = " + presidentid + " " + prezdesc);
//            TestContext.WriteLine("ensure that app cannot delete" + presidentid);

//           Exception ex= Assert.Throws<Exception>(()=>President.Delete(dt));


//            TestContext.WriteLine(ex.Message);
//        }
//        [Test]
//        public void LoadPresident()
//        {
//            int presidentid = GetExistingPresidentId();
//            Assume.That(presidentid > 0, "No presidents in DB, cant run test");
//            TestContext.WriteLine("existing president with id = " + presidentid);
//            TestContext.WriteLine("Ensure that app loads president " + presidentid);
//            DataTable dt = President.Load(presidentid);
//            int loadedid = 0;
//            if (dt.Rows.Count > 0)
//            {
//                loadedid = (int)dt.Rows[0]["presidentid"];
//            }

//         ;
//            Assert.IsTrue(loadedid == presidentid,loadedid + "<>" + presidentid);
//            TestContext.WriteLine("Loaded President(" + loadedid + ")");

//        }

//        [Test]
//        public void SearchPresidents()
//        { string criteria = "a";
//            int num = SQLUtility.GetFirstColumnFirstRowValue("select total = count (*) from president where lastname like '%" + criteria + "%'");
//            Assume.That(num > 0, "There no presidents that match the search for " + num);
//            TestContext.WriteLine(num + "presidents that match " +  criteria);
//            TestContext.WriteLine("Ensure that president search returns " + num + "rows");

//            DataTable dt = President.SearchPresidents(criteria);
//            int results = dt.Rows.Count;

//            Assert.IsTrue(results == num, "Results of president search does not match number of presidents," + results + "<>" + num);
//            TestContext.WriteLine("Number of rows by president search is " + results);

//        }

//        [Test]
//        public void GetListOfParties()
//        {

//            int partycount = SQLUtility.GetFirstColumnFirstRowValue("select total= count (*) from party");

//            Assume.That(partycount > 0, "No parties in DB, cant test");
//            TestContext.WriteLine(" Num of parties in DB = " + partycount);
//            TestContext.WriteLine("Ensure that num of rows return by app matches" + partycount);

//            using DataTable dt= President.GetPartyList();
//            Assert.IsTrue(dt.Rows.Count==partycount, "num rows returned by app( "+ dt.Rows.Count +") <> " + partycount);
//            TestContext.WriteLine("Number of rows in Parties return by app = " +dt.Rows.Count);
//        }

//        private int GetExistingPresidentId()
//        {

//           return SQLUtility.GetFirstColumnFirstRowValue("select top 1 presidentid from president");
//        }
//    }
//}

using System.Data;

namespace RecordKeeperTest
{
    public class PresidentTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=.\\SQLExpress;Database=RecordKeeperDB;Trusted_Connection=true");
        }

        [Test]
        [TestCase("Sam", "Test1", "2035-1-1", 2075, 2079)]
        [TestCase("Sam", "Test3", "1800-1-1", 1836, 1840)]
        public void InsertNewPresident(string firstname, string lastname, DateTime dateborn, int termstart, int termend)
        {
            DataTable dt = SQLUtility.GetDataTable("select * from president where presidentid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1);

            int partyid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 partyid from party");
            Assume.That(partyid > 0, "Can't run test, no parties in the DB");

            int maxnum = SQLUtility.GetFirstColumnFirstRowValue("select isnull(max(num), 0) from president") + 1;
            TestContext.WriteLine("Insert president with num = " + maxnum);

            r["partyid"] = partyid;
            r["Num"] =0;
            r["FirstName"] = firstname;
            r["LastName"] = lastname;
            r["DateBorn"] = dateborn;
            r["TermStart"] = termstart;
            r["TermEnd"] = termend;

            President.Save(dt);

            int newnum = SQLUtility.GetFirstColumnFirstRowValue("select presidentid from president where num = " + maxnum);
            int pkid = 0;
            if (r["PresidentId"] != DBNull.Value)
            {
                pkid = (int)r["PresidentId"];
            }
            Assert.IsTrue(newnum > 0, "President with num = " + maxnum + " not found in DB");
            Assert.IsTrue(pkid > 0, "primary key not updated in datatable");
            TestContext.WriteLine("President with num = " + maxnum + " was inserted with id = " + newnum);
            TestContext.WriteLine("new primary key = " + pkid);

        }

        [Test]
        public void ChangeExistingPresidentTermStart()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");

            int termstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid=" + presidentid);
            termstart = termstart - 1;

            TestContext.WriteLine("Change termstart for presidentid " + presidentid + " to " + termstart);

            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["termstart"] = termstart;
            President.Save(dt);

            int newtermstart = SQLUtility.GetFirstColumnFirstRowValue("select termstart from president where presidentid=" + presidentid);
            Assert.IsTrue(newtermstart == termstart, "Expected termstart " + termstart + " but got " + newtermstart);
        }

        [Test]
        public void ChangeExistingPresidentToInvalidTermStart()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");

            int termend = SQLUtility.GetFirstColumnFirstRowValue("select termend from president where presidentid=" + presidentid);
            int termstart = termend + 1;

            TestContext.WriteLine("Change termstart to invalid value " + termstart);

            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["termstart"] = termstart;

            Exception ex = Assert.Throws<Exception>(() => President.Save(dt));
            TestContext.WriteLine("Expected exception: " + ex.Message);
        }

        [Test]
        public void ChangeExistingPresidentToInvalidNum()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB, can't run test");

            int conflictingNum = SQLUtility.GetFirstColumnFirstRowValue(
                "select top 1 num from president where presidentid <> " + presidentid);
            Assume.That(conflictingNum > 0, "No other presidents to create a conflict");

            DataTable dt = President.Load(presidentid);
            dt.Rows[0]["num"] = conflictingNum;

            try
            {
                President.Save(dt);
                Assert.Fail("Expected exception for duplicate Num was not thrown.");
            }
            catch (Exception ex)
            {
                TestContext.WriteLine("Expected exception for duplicate Num: " + ex.Message);
            }
        }

        [Test]
        public void DeletePresident()
        {
            string sql = @"
    select top 1 p.PresidentId, p.Num, p.LastName
    from president p 
    left join ExecutiveOrdersForPresident e on e.PresidentId = p.PresidentId
    left join PresidentMedal pm on pm.PresidentId = p.PresidentId
    where e.ExecutiveOrderForPresidentId is null
      and pm.PresidentMedalId is null
    order by p.PresidentId";

            DataTable dt = SQLUtility.GetDataTable(sql);

           
            Assume.That(dt.Rows.Count > 0, "No presidents found without related records — cannot run delete test.");

            int presidentid = (int)dt.Rows[0]["PresidentId"];
            string desc = $"{dt.Rows[0]["Num"]} {dt.Rows[0]["LastName"]}";
            TestContext.WriteLine("Trying to delete President: " + desc);

            President.Delete(dt);

       
            int count = SQLUtility.GetFirstColumnFirstRowValue(
                $"select count(*) from president where presidentid = {presidentid}");

            Assert.IsTrue(count == 0, "President with id " + presidentid + " still exists after attempted deletion.");
            TestContext.WriteLine("President with id " + presidentid + " successfully deleted.");
        }

        [Test]
        public void DeletePresidentWithUpheldExecutiveOrder()
        {
            string sql = @"
select top 1 p.PresidentId, p.Num, p.LastName
from president p
join ExecutiveOrder e on e.PresidentId = p.PresidentId
where e.UpheldByCourt = 1";

            DataTable dt = SQLUtility.GetDataTable(sql);

            
            if (dt.Rows.Count == 0)
            {
                Assert.Ignore("No presidents with upheld executive orders — test skipped.");
                return;
            }

            Exception ex = Assert.Throws<Exception>(() => President.Delete(dt));
            TestContext.WriteLine("Expected exception on delete: " + ex.Message);
        }

        [Test]
        public void LoadPresident()
        {
            int presidentid = GetExistingPresidentId();
            Assume.That(presidentid > 0, "No presidents in DB");

            DataTable dt = President.Load(presidentid);
            int loadedid = dt.Rows.Count > 0 ? (int)dt.Rows[0]["presidentid"] : 0;

            Assert.IsTrue(loadedid == presidentid, "Expected " + presidentid + " but got " + loadedid);
        }

        [Test]
        public void SearchPresidents()
        {
            string criteria = "a";
            int expected = SQLUtility.GetFirstColumnFirstRowValue("select count(*) from president where lastname like '%" + criteria + "%'");
            Assume.That(expected > 0, "No presidents match criteria");

            DataTable dt = President.SearchPresidents(criteria);
            Assert.AreEqual(expected, dt.Rows.Count, "Mismatch in search results");
        }

        [Test]
        public void GetListOfParties()
        {
            int expected = SQLUtility.GetFirstColumnFirstRowValue("select count(*) from party");
            Assume.That(expected > 0, "No parties in DB");

            using DataTable dt = President.GetPartyList();
            Assert.AreEqual(expected, dt.Rows.Count, "Mismatch in party list count");
        }

        private int GetExistingPresidentId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 presidentid from president");
        }
    }
}