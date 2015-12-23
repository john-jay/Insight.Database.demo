using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insight.Database.demo
{
    class PersonTest
    {
        public void Run()
        {
            SqlInsightDbProvider.RegisterProvider();
            var connectionString = ConfigurationManager.ConnectionStrings["AdventureDb"].ConnectionString;
            var conn = new SqlConnection(connectionString);

            var dude = new Person()
            {
                //BusinessEntityID = 2001,
                FirstName = "George",
                LastName = "Washington",
                PersonType = "EM"
            };
            conn.Execute("Person.PersonSave", dude);
        }
    }
}
