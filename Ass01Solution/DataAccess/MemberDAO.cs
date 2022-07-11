using System.Data;
using BusinessObject;
using Microsoft.Data.SqlClient;

namespace DataAccess
{
    public class MemberDAO : BaseDAL
    {
        private static MemberDAO instance = null;
        private static readonly object instanceLock = new object();
        private MemberDAO() { }
        private static List<Member> MemberList = new List<Member>()
        {
            new Member{MemberID=1, MemberName="Manh", Email="manh@gmail.com",City="HCM", Country="VietNam", Password="123" },
            new Member{MemberID=2, MemberName="Minh", Email="minh@gmail.com",City="HCM", Country="VietNam", Password="123" },
            new Member{MemberID=3, MemberName="Huy", Email="huy@gmail.com",City="HCM", Country="VietNam", Password="123" },


        };
        public static MemberDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new MemberDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Member> GetMemberList1() => MemberList;
        public IEnumerable<Member> GetMemberList()
        {
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID,MemberName,Email,Password,City,Country From Members";
            var members = new List<Member>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
        public Member GetMemberByID(int MemberID)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID,MemberName,Email,Password,City,Country " + " from Members where MemberID=@MemberID ";
            try
            {

                var param = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                dataReader = dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, param);
                if (dataReader.Read())
                {
                    member = new Member
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
        public Member GetMemberByIDandName(int MemberID, string MemberName)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelectIDandNAME = "Select MemberID,MemberName,Email,Password,City,Country" + "From Members where MemberID=@MemberID AND MemberName=@MemberName";
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32));
                parameters.Add(dataProvider.CreateParameter("@MemberName", 50, MemberName, DbType.String));
                dataReader = dataProvider.GetDataReader(SQLSelectIDandNAME, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        member = new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5)
                        };
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }

            return member;
        }
        public void AddNew(Member member)
        {
            try
            {
                Member pro = GetMemberByID(member.MemberID);
                if (pro == null)
                {
                    string SQLInsert = "Insert Members values(@MemberID,@MemberName,@Email,@Password,@City,@Country)";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    dataProvider.Insert(SQLInsert, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The car is already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                CloseConnection();
            }
        }
        public void Update(Member member)
        {
            try
            {
                Member c = GetMemberByID(member.MemberID);
                if (c != null)
                {
                    string SQLUpdate = "Update Members set MemberName=@MemberName,Email=@Email,Password=@Password,City=@City,Country=@Country where MemberID=@MemberID";
                    var parameters = new List<SqlParameter>();
                    parameters.Add(dataProvider.CreateParameter("@MemberID", 4, member.MemberID, DbType.Int32));
                    parameters.Add(dataProvider.CreateParameter("@MemberName", 50, member.MemberName, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Email", 50, member.Email, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Password", 50, member.Password, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@City", 50, member.City, DbType.String));
                    parameters.Add(dataProvider.CreateParameter("@Country", 50, member.Country, DbType.String));
                    dataProvider.Update(SQLUpdate, CommandType.Text, parameters.ToArray());
                }
                else
                {
                    throw new Exception("The member does not already exist.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {

                CloseConnection();
            }

        }
        public void Remove(int MemberID)
        {
            try
            {
                Member member = GetMemberByID(MemberID);
                if (member != null)
                {
                    string SQLDelete = "Delete Members where MemberID=@MemberID";
                    var parameters = dataProvider.CreateParameter("@MemberID", 4, MemberID, DbType.Int32);
                    dataProvider.Delete(SQLDelete, CommandType.Text, parameters);
                }
                else
                {
                    throw new Exception("The car does not exist");
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
        public IEnumerable<Member> MemberListDesc()
        {
            IDataReader dataReader = null;
            string SQLSortDesc = "Select MemberID,MemberName,Email,Password,City,Country From Members ORDER BY MemberName DESC";
            var members = new List<Member>();
            try
            {
                dataReader = dataProvider.GetDataReader(SQLSortDesc, CommandType.Text, out connection);
                {
                    while (dataReader.Read())
                    {
                        members.Add(new Member
                        {
                            MemberID = dataReader.GetInt32(0),
                            MemberName = dataReader.GetString(1),
                            Email = dataReader.GetString(2),
                            Password = dataReader.GetString(3),
                            City = dataReader.GetString(4),
                            Country = dataReader.GetString(5),
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;
        }
        public IEnumerable<Member> GetMemberByCityAndCountry(string city, string country)
        {
            

            Member member = null;
            var members = new List<Member>();
            IDataReader dataReader = null;
            string SQLSelect =
                "DECLARE @CityVar VARCHAR(50), @CountryVar VARCHAR(50); " +
                "SET @CityVar = '%' + @City + '%'; " +
                "SET @CountryVar = '%' + @Country + '%'; " +
                "Select * from Members " +
                "WHERE ((City like @CityVar) OR  @CityVar IS NULL) " +
                "And " +
                "((Country like @CountryVar) OR @CountryVar IS NULL)";

            try
            {
                //Prepare value before putting into connection string
                city = (city != "All city" && city != "City") ? city : null;
                country = (country != "All country" && country != "Country") ? country : null;
                //Prepare statement
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@City", 50, (object)city ?? DBNull.Value, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Country", 50, (object)country ?? DBNull.Value, DbType.String));
                dataReader=dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    members.Add(new Member
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                    });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return members;

        }
        public Member FindCityAndCountry(string city, string country)
        {
            Member member = null;
            IDataReader dataReader = null;
            string SQLSelect = "Select MemberID,MemberName,Email,Password,City,Country From Members" + "City=@City And Country=@Country";
            
            try
            {
                var parameters = new List<SqlParameter>();
                parameters.Add(dataProvider.CreateParameter("@City", 50, city, DbType.String));
                parameters.Add(dataProvider.CreateParameter("@Country", 50, country, DbType.String));
                dataProvider.GetDataReader(SQLSelect, CommandType.Text, out connection, parameters.ToArray());
                while (dataReader.Read())
                {
                    member = new Member
                    {
                        MemberID = dataReader.GetInt32(0),
                        MemberName = dataReader.GetString(1),
                        Email = dataReader.GetString(2),
                        Password = dataReader.GetString(3),
                        City = dataReader.GetString(4),
                        Country = dataReader.GetString(5),
                    };
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                dataReader.Close();
                CloseConnection();
            }
            return member;
        }
    }
}

