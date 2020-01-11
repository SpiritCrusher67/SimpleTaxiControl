﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace SimpleTaxiControlLibrary
{
    public class Order
    {
        public string AddressFrom { get; set; }

        public string NumberFrom { get; set; }

        public string AddressTo { get; set; }

        public string NumberTo { get; set; }

        public DateTime Date { get; set; }

        public string Comment { get; set; }

        public int Status { get; set; }

        public Call Call { get; set; }

        public int Id { get; private set; }

        public Order(string addressFrom, string numberFrom, string addressTo, string numberTo, DateTime date, string comment,Call call)
        {
            AddressFrom = addressFrom;

            NumberFrom = numberFrom;

            AddressTo = addressTo;

            NumberTo = numberTo;

            Date = date;

            Comment = comment;

            Status = (int)OrderStatuses.Free;

            Call = call;

            SaveOrder();
        }

        private void SaveOrder()
        {
            SqlParameter AddressFromParam = new SqlParameter("@AddressFrom", AddressFrom);

            SqlParameter NumberFromParam = new SqlParameter("@NumberFrom", NumberFrom);

            SqlParameter AddressToParam = new SqlParameter("@AddressTo", AddressTo);

            SqlParameter NumberToParam = new SqlParameter("@NumberTo", NumberTo);

            SqlParameter DateParam = new SqlParameter("@Date", Date);

            SqlParameter CommentParam = new SqlParameter("@Comment", Comment);

            SqlParameter StatusParam = new SqlParameter("@Status", Status);

            SqlParameter CallIdParam = new SqlParameter("@CallId", Call.Id);

            SqlParameter idParam = new SqlParameter
            {
                ParameterName = "@id",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.Output
            };

            string query = @"insert into Orders 
                (AddressFrom,NumberFrom,AddressTo,NumberTo,Date,Status,CallId,Comment)
                values 
                (@AddressFrom,@NumberFrom,@AddressTo,@NumberTo,@Date,@Status,@CallId,@Comment);
                set @id=SCOPE_IDENTITY()";

            using (SqlConnection connection = new SqlConnection(DBConnection.ConnectionString))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddRange(new SqlParameter[]
                {
                    AddressFromParam,
                    NumberFromParam,
                    AddressToParam,
                    NumberToParam,
                    DateParam,
                    CommentParam,
                    StatusParam,
                    CallIdParam,
                    idParam
                });

                command.ExecuteNonQuery();
            }

            Id = (int)idParam.Value;

        }
    }
}
