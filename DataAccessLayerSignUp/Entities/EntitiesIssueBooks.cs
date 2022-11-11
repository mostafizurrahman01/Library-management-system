using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayerSignUp.Entities
{
    public class EntitiesIssueBooks
    {
        
        private string stdId;
        private string stdName;
        private string stdEmail;
        private string stdDept;
        private string stdSemester;
        private string stdMobileNum;
        private string bookName;
        private string bookIssueDate;

        public string StdId
        {
            set;
            get;
        }

        public string StdName
        {
            set;
            get;
        }

        public string StdEmail
        {
            set;
            get;
        }

        public string StdDept
        {
            set;
            get;
        }

        public string StdSemester
        {
            set;
            get;
        }

        public string StdMobileNum
        {
            set;
            get;
        }

        public string BookName
        {
            set;
            get;
        }

        public string BookIssueDate
        {
            set;
            get;
        }
    }
}
