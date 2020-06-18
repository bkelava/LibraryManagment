﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class DbHandler
    {
        private SqlConnection sqlConnection = new SqlConnection();
        private SqlCommand sqlCommand = null;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private SqlDataReader sqlDataReader = null;

        private Values values = new Values();

        private void initialize()
        {
            this.sqlCommand = new SqlCommand();
            this.dataSet = new DataSet();
        }

        private string connectionString = "";
        public DbHandler(string connectionString)
        {
            this.connectionString = connectionString;
        }
        private void Connect()
        {
            this.initialize();
            this.sqlConnection.ConnectionString = this.connectionString;
            this.sqlConnection.Open();
            this.sqlCommand.Connection = this.sqlConnection;
        }

        private void Disconnect()
        {
            this.sqlConnection.Close();
        }

        public DataSet Select(string query)
        {
            this.Connect();

            this.sqlCommand.CommandText = query;

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataSet);

            this.Disconnect();

            return this.dataSet;
        }

        public void Insert(string query)
        {
            this.Connect();

            this.sqlCommand.CommandText = query;

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataSet);

            this.Disconnect();
        }

        public void Update(string query)
        {
            this.Connect();

            this.sqlCommand.CommandText = query;

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataSet);

            this.Disconnect();
        }

        public void Delete(string query)
        {
            this.Connect();

            this.sqlCommand.CommandText = query;

            sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            sqlDataAdapter.Fill(dataSet);

            this.Disconnect();
        }

        public bool RowExist(string query)
        {
            this.Connect();

            this.sqlCommand.CommandText = query;

            this.sqlDataAdapter = new SqlDataAdapter(sqlCommand);

            this.sqlDataAdapter.Fill(dataSet);

            this.sqlDataReader = sqlCommand.ExecuteReader();

            if (sqlDataReader.HasRows)
            {
                this.Disconnect();
                return true;
            }
            else
            {
                this.Disconnect();
                return false;
            }
        }

        public DataTable populateDataGridView(string query)
        {
            DataSet mDataSet = new DataSet();

            mDataSet = this.Select(query);

            return mDataSet.Tables[0];
        }

    }
}
