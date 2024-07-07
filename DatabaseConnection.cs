using System;
using System.CodeDom;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace VoteSphere
{
    internal class DatabaseConnection
    {
        private string connectionString;

        public DatabaseConnection(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
            {
                throw new ArgumentException("Connection string cannot be null or empty.", nameof(connectionString));
            }
            this.connectionString = connectionString;
        }
        //Retreiving data
        public DataTable RetrieveData(string query)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    return dataTable;
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occur while retrieving data.", ex);
                }
            }
        }
        //Inserting voter information
        public void StudentRegistration(int studentID, string courseID, string firstName, string lastName, string Gender, string year)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {


                try
                {
                    connection.Open();
                    string query = "INSERT INTO StudentsInfo(StudentID, CourseID, firstName, lastName, Gender, schoolYear) " +
                                   "VALUES (@StudentID, @CourseID, @firstName, @lastName, @Gender, @schoolYear)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("Gender", Gender);
                    command.Parameters.AddWithValue("schoolYear", year);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("A database error occurred while inserting into Voters Registration.", ex);
                }
            }
        }
        //validation of candidate if they are already registered to an organization.
        public bool CandidateValidation(int StudentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {

                    string query = "SELECT COUNT(*) FROM StudentsInfo WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    command.Parameters.AddWithValue("@StudentID", StudentID);

                    int count = (int)command.ExecuteScalar();
                    connection.Close();

                    return count > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occur while validating candidate's organization", ex);
                }
            }
        }

        //register candidate as Student in StudentsInfo
        public void RegisterCandidateAsStudent(int StudentID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO StudentsInfo(StudentID) VALUES (@StudentID)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occur while registering candidate as Student", ex);
                }
            }
        }

        //inserting school organizations data
        public void InsertSchoolOrganization(string CourseID, string NameofGroup)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO SchoolOrgTable (CourseID, NameofGroup) " +
                                   "VALUES (@CourseID, @NameofGroup)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@CourseID", CourseID);
                    command.Parameters.AddWithValue("@NameofGroup", NameofGroup);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured while inserting into SchoolOrgTable", ex);
                }
            }
        }
        //inserting user/admin login data
        public void InsertLoginTable(int StudentID, string Password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO LoginTable (StudentID, Password) " +
                                   "VALUES (@StudentID, @Password)";

                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.Parameters.AddWithValue("@Password", Password);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException sqlEx)
                {
                    // Handle SQL exceptions separately if needed
                    throw new Exception("A database error occurred while inserting into StudentsInfo.", sqlEx);
                }
            }
        }
        //insert candidates information
        public void InsertCandidatesInfo(int StudentID, string RoleID, string OrganizationName, string firstName, string lastName, string year, string courseID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    int SchoolOrgID = GetSchoolOrgID(OrganizationName);
                    connection.Open();
                    string query = "INSERT INTO CandidatesInfo (StudentID, RoleID, SchoolOrgID, firstName, lastName, schoolYear, CourseID) " +
                                   "VALUES (@StudentID, @RoleID, @SchoolOrgID, @firstName, @lastName, @schoolYear, @CourseID)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@SchoolOrgID", SchoolOrgID);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.Parameters.AddWithValue("@schoolYear", year);
                    command.Parameters.AddWithValue("@CourseID", courseID);
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                catch (Exception ex)
                {
                    throw new Exception("An error occured while inserting Candidates information", ex);
                }
            }
        }


        public void InsertPollTable(int StudentID, string OrganizationName, string RoleID, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    int SchoolOrgID = GetSchoolOrgID(OrganizationName);

                    connection.Open();
                    string query = "INSERT INTO PollTable (StudentID, SchoolOrgID, RoleID, firstName, lastName) " +
                                   "VALUES  (@StudentID, @SchoolOrgID, @RoleID, @firstName, @lastName)";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.Parameters.AddWithValue("@SchoolOrgID", SchoolOrgID);
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex)
                {
                    throw new Exception("An error occur while inserting in Poll Table");
                }
            }
        }

        public int GetSchoolOrgID(string OrganizationName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT SchoolOrgID FROM SchoolOrgTable WHERE NameofGroup = @NameofGroup ";
                try
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@NameofGroup", OrganizationName);

                        connection.Open();
                        object result = command.ExecuteScalar();

                        if (result != null)
                        {
                            return Convert.ToInt32(result);
                        }
                        else
                        {

                            throw new Exception("Organization not found");
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Organization not found", ex);
                }
            }
        }

        public DataTable GetPollTableData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM PollTableView";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable pollTable = new DataTable();
                    adapter.Fill(pollTable);
                    return pollTable;
                }
            }
        }
        public void UpdatePollTable(string studentID, string roleID, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE PollTable SET RoleID = @RoleID, firstName = @firstName, lastName = @lastName WHERE StudentID = @StudentID";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("A database error occurred while updating the PollTable.", ex);
                }
            }
        }
        public DataTable GetCandidatesByRoleAndOrganization(string roleID, string SchoolOrgID)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"SELECT ci.StudentID, CONCAT(ci.FirstName, ' ', ci.LastName) AS FullName
                        FROM PollTable ci
                        JOIN SchoolOrgTable so ON ci.SchoolOrgID = so.SchoolOrgID
                        WHERE ci.RoleID = @RoleID";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    command.Parameters.AddWithValue("@SchoolOrgName", SchoolOrgID);

                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable candidatesTable = new DataTable();
                    adapter.Fill(candidatesTable);
                    return candidatesTable;
                }
            }
        }


        //validation login
        public bool ValidationLogin(int userID, out int? StudentID, out int? ProfID, string Password, out bool isProf)
        {
            StudentID = null;
            ProfID = null;
            isProf = false;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = "SELECT StudentID, ProfID FROM LoginTable WHERE (ProfID = @UserID OR StudentID = @UserID) AND Password = @Password";

                SqlCommand sqlCommand = new SqlCommand(query, connection);
                sqlCommand.Parameters.AddWithValue("@UserID", userID);
                sqlCommand.Parameters.AddWithValue("@Password", Password);
                connection.Open();

                using (SqlDataReader reader = sqlCommand.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        if (!reader.IsDBNull(reader.GetOrdinal("ProfID")))
                        {
                            ProfID = reader.GetInt32(reader.GetOrdinal("ProfID"));
                            isProf = true;
                            return true;
                        }
                        else if (!reader.IsDBNull(reader.GetOrdinal("StudentID")))
                        {
                            StudentID = reader.GetInt32(reader.GetOrdinal("StudentID"));
                            return true;
                        }
                    }

                }
            }
            return false;
        }

        public DataTable GetOrganizations()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT DISTINCT NameofGroup FROM SchoolOrgTable";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable organizationsTable = new DataTable();
                    adapter.Fill(organizationsTable);
                    return organizationsTable;
                }
            }
        }
        public DataTable GetVoteCounts()
        {

            string query = @"
            SELECT 
                V.RoleID,
                S.firstName,
                S.lastName,
                COUNT(*) AS TotalVotes
            FROM 
                VotersTable V
            INNER JOIN 
                StudentsInfo S ON V.StudentID = S.StudentID
            GROUP BY 
                V.RoleID, S.firstName, S.lastName
            ORDER BY 
                V.RoleID, TotalVotes DESC";

            DataTable voteCountsTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand( query, connection))
                try
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(voteCountsTable);
                }
                catch (Exception ex)
                {

                    throw new Exception("An error occurred while fetching vote counts.", ex);
                }
            }
            return voteCountsTable;
        }

        public void InsertVotePoll(int studentID, string organizationName, string roleID, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO VotePollTable (StudentID, NameofGroup, RoleID, FirstName, LastName) " +
                                   "VALUES (@StudentID, @NameofGroup, @RoleID, @FirstName, @LastName)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@NameofGroup", organizationName);
                    command.Parameters.AddWithValue("@RoleID", roleID);
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw new Exception("A database error occurred while inserting the poll data.", ex);
                }
            }
        }
        public void InsertVotersTable(int VoterStudentID, string SchoolOrgID, string RoleID, int StudentID, DateTime VoteTimeStamp)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    GetOrganizations();
                    connection.Open();
                    string query = "INSERT INTO VotersTable (VoterStudentID ,NameofGroup, roleID, StudentID, VoteTimeStamp) " +
                                   "VALUES (@VoterStudentID ,@NameofGroup, @RoleID, @StudentID, @VoteTimeStamp)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@VoterStudentID", VoterStudentID);
                    command.Parameters.AddWithValue("@NameofGroup", SchoolOrgID);
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@StudentID", StudentID);
                    command.Parameters.AddWithValue("@VoteTimeStamp", VoteTimeStamp);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (Exception ex) { throw new Exception(ex.Message, ex); }
            }
        }
        public bool HasVoted(int voterStudentID, string roleID)
        {
            // Query the VotersTable to check if a record exists for the specified student ID and role ID
            string query = "SELECT COUNT(*) FROM VotersTable WHERE VoterStudentID = @VoterStudentID AND RoleID = @RoleID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VoterStudentID", voterStudentID);
                    command.Parameters.AddWithValue("@RoleID", roleID);

                    connection.Open();
                    int count = (int)command.ExecuteScalar();

                    // If count is greater than 0, it means the student has already voted for this role
                    return count > 0;
                }
            }
        }
        public int GetStudentIDFromLogin(string firstName, string lastName)
        {
            int studentID = -1; // Default value indicating failure

            string query = "SELECT StudentID FROM StudentsInfo WHERE firstName = @FirstName AND lastName = @LastName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", firstName);
                    command.Parameters.AddWithValue("@LastName", lastName);

                    connection.Open();
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        studentID = Convert.ToInt32(result);
                    }
                }
            }

            return studentID;
        }
        public void MarkAsVoted(int voterStudentID, string roleID)
        {
            // Insert a record into the VotersTable to mark the student as voted for the specified role
            string query = "INSERT INTO VotersTable (VoterStudentID, RoleID, VoteTimeStamp) VALUES (@VoterStudentID, @RoleID, GETDATE())";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@VoterStudentID", voterStudentID);
                    command.Parameters.AddWithValue("@RoleID", roleID);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void DeleteCandidate(string studentID, string RoleID, string firstName, string lastName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "DELETE FROM PollTable WHERE StudentID = @StudentID AND RoleID = @RoleID AND firstName = @firstName AND lastName = @lastName";

                using (SqlCommand command = new SqlCommand(query, connection))
                {

                    connection.Open();
                    command.Parameters.AddWithValue("@StudentID", studentID);
                    command.Parameters.AddWithValue("@RoleID", RoleID);
                    command.Parameters.AddWithValue("@firstName", firstName);
                    command.Parameters.AddWithValue("@lastName", lastName);

                    command.ExecuteNonQuery();
                }
            }
        }


    }
}
