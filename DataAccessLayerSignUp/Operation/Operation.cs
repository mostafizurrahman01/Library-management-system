using DataAccessLayerSignUp.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerSignUp.Operation
{
    public class Operation
    {
        SqlConnection connection = new SqlConnection("Data Source=DESKTOP-QL04J0F;Initial Catalog=LibraryDBConnection;Integrated Security=True");

        public int SignUp(EntitiesSignUp e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("insert into SignUpTable(ID,FirstName, LastName, MobileNum, " +
                "Email, Username, Gender, Password, ConfirmPassword) values('" +e.ID+ "','" + e.FirstName + "', " +
                "'" + e.LastName + "', '" + e.MobileNum + "', '" + e.Email + "','" + e.UserName + "'," +
                "'" + e.Gender + "','" + e.Password + "','" + e.ConfirmPass + "' )", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter CheckUsername(EntitiesSignUp e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("Select Username from SignUpTable where " +
                "Username ='" + e.UserName + "'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(command);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter Login(EntitiesSignUp e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("select * from SignUpTable where " +
                "Username = '" +e.UserName +"' and Password = '" + e.Password +"'", connection);
            SqlDataAdapter da = new SqlDataAdapter(command);
            connection.Close();
            return da;
        }

        public SqlDataAdapter checkAdmin(EntitiesSignUp e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from AdminTable where " +
                "Username = '" + e.UserName+"' and Password = '" + e.Password + "'",connection );
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            connection.Close();
            return da1;
        }

        public int addAdmin(EntitiesAdmin e)
        {
            connection.Open();
            SqlCommand cmd =  new SqlCommand("insert into AdminTable(ID, Username, Password) " +
                "values('" + e.adminID  + "', '" + e.adminUsername  + "' , '" + e.adminPassword + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter checkAdminUsername(EntitiesAdmin e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Username  from AdminTable where Username = '" + e.adminUsername + "'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public int removeAdmin(EntitiesAdmin e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete AdminTable where ID ='" + e.adminID + "' ", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public int addBooks(EntitiesBooks e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into BooksTable(BookName,BookAuthor,BookPublications," +
                "BookPurchaseDate,BookPrice,BookQuantity) values ('" + e.BookName + "', '" + e.BookAuthor + "','" 
                + e.BookPublication + "','" + e.BookPurchaseDate + "'," +
                "'" + e.BookPrice + "','" + e.BookQuantity + "') ", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter checkBookName(EntitiesBooks e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select BookName  from BooksTable where BookName = " +
                "'" + e.BookName + "'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter bookLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from BooksTable",connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter clickBookShow(int bid)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from BooksTable where BookID = '" + bid + "' ", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter bookSearch(string txtBookNameTopSearchBook)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from BooksTable where " +
                "BookName Like '" + txtBookNameTopSearchBook + "%'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public int searchBooksUpdate(EntitiesBooks e, Int64 rowId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update BooksTable set BookName='" + e.BookName + "', " +
                "BookAuthor='" + e.BookAuthor + "',BookPublications='" + e.BookPublication + "' , " +
                "BookPurchaseDate='" + e.BookPurchaseDate + "' ,BookPrice='" + e.BookPrice + "'," +
                "BookQuantity = '" + e.BookQuantity +"' where BookID='" + rowId + "' ", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public int booksDelete(Int64 rowId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete BooksTable where BookID='" + rowId + "' ", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public int addStudent(EntitiesStudent e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into StudentsTable(stdID,stdName,stdEmail," +
                "stdDept,stdSemester,stdMobileNum,stdUsername) values('"+ e.StdId + "'," +
                "'" + e.StdName + "'," +"'" + e.StdEmail +"', '" + e.StdDept +"'," +
                "'" + e.StdSemester + "', '" +e.StdMobileNum+"','" +e.StdUsername+"')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter studentLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentsTable", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter studentSearch(string txtIdTopStudentInformation)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentsTable where stdName Like '" + txtIdTopStudentInformation + "%'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }
        public SqlDataAdapter clickStudentShow(string StdId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentsTable where stdID = '" + StdId + "' ", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public int studentInformationUpdate(EntitiesStudent e, string rowId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update StudentsTable set stdID='" + e.StdId + "', " +
                "stdName='" + e.StdName + "', stdEmail='" + e.StdEmail + "' , " +
                "stdDept='" + e.StdDept + "' , stdSemester='" + e.StdSemester + "'," +
                "stdMobileNum = '" + e.StdMobileNum + "' where stdID='" + rowId + "' ", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public int studentInformationDelete(string rowId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("delete StudentsTable where stdID='" + rowId + "' ", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataReader issueBooksComboBox()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select BookName from BooksTable", connection);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
            connection.Close();
        }

        public SqlDataAdapter showStdInfoIssueBooks(string stdId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentsTable where stdID = '" + stdId+ "' ",connection);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            connection.Close();
            return DA;
        }

        public SqlDataAdapter studentIssueBooksCount(string stdId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select count(std_id) from IssueBooksTable " +
                "where std_id = '" + stdId + "' and book_return_date is null ", connection);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            connection.Close();
            return DA;
        }
        public int recordIssueBooks(EntitiesIssueBooks e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into IssueBooksTable(std_id,std_name,std_email,std_dept," +
                "std_semester, std_contact,book_name,book_issue_date) values('"+e.StdId+"', " +
                "'"+e.StdName+"','"+e.StdEmail+"','"+e.StdDept+"','"+e.StdSemester+"' , " +
                "'"+ e.StdMobileNum + "', '" +e.BookName+"', '"+e.BookIssueDate+"')" , connection);

            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter stdSearchForRtnBooks(string stdId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from IssueBooksTable where std_iD = '" + stdId + "' ", connection);
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            connection.Close();
            return DA;
        }

        public int returnBooksFixed(string book_return_date,string stdId, Int64 rowId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update IssueBooksTable set book_return_date = '" + book_return_date + "' where std_id = '"+stdId +"' and ibId = '"+ rowId +"' " , connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter studentProfile()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from StudentsTable", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter checkLibrarian(EntitiesSignUp e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from LibrarianTable where " +
                "Username = '" + e.UserName + "' and Password = '" + e.Password + "'", connection);
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            connection.Close();
            return da1;
        }

        public int addLibrarian(EntitiesLibrarian e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("insert into LibrarianTable(ID, Username, Password) " +
                "values('" + e.LibrarianID + "', '" + e.LibrarianUsername + "' , '" + e.LibrarianPassword + "')", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter checkLibrarianUsername(EntitiesLibrarian e)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select Username  from LibrarianTable where Username = '" + e.LibrarianUsername + "'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public int removeLibrarian(EntitiesLibrarian e)
        {
            connection.Open();
            SqlCommand command = new SqlCommand("delete LibrarianTable where ID ='" + e.LibrarianID + "' ", connection);
            int flag = command.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

        public SqlDataAdapter librarianLoad()
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from LibrarianTable", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public SqlDataAdapter librarianSearch(string txtIdTopViewLibrarianInformationForm)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from LibrarianTable where Username Like '" + txtIdTopViewLibrarianInformationForm + "%'", connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }
        public SqlDataAdapter clicklibrarianShow(string LibrarianID)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("select * from LibrarianTable where ID = '" + LibrarianID + "' ", 
                connection);
            SqlDataAdapter ds = new SqlDataAdapter(cmd);
            connection.Close();
            return ds;
        }

        public int librarianInfoUpdate(EntitiesLibrarian e, string rowId)
        {
            connection.Open();
            SqlCommand cmd = new SqlCommand("update LibrarianTable set ID='" + e.LibrarianID + "', " +
                "Username='" + e.LibrarianUsername + "', Password='" + e.LibrarianPassword + "' " +
                "where ID='" + rowId + "'", connection);
            int flag = cmd.ExecuteNonQuery();
            connection.Close();
            return flag;
        }

    }
}
