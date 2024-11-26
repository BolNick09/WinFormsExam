﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace WinFormsExam
{
    public interface ISQLRequests
    {
        void Insert();
        void Update();
        void Delete();
        //void GetInfo(List<Object> itemList);


    }

    public abstract class SQLRequests : ISQLRequests
    {
        static private string strConnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=TaskManagerDB;Integrated Security=True;Connect Timeout=30";
        static protected SqlConnection sqlConnection = new SqlConnection(strConnection);
        static protected string sqlQuery = "";

        //public abstract void GetInfo(List<Object> itemList);

        public abstract void Insert();

        public abstract void Update();

        public abstract void Delete();
    }
}
