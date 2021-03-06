﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FlashCards.DAL.Encje
{
    class User
    {
        #region Własności
        public sbyte? Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        #endregion

        #region Konstruktory
        public User(MySqlDataReader reader)
        {
            Id = sbyte.Parse(reader["ID"].ToString());
            Name = reader["Name"].ToString();
            Surname = reader["Surname"].ToString();
        }

        public User(string name, string surname)
        {
            Id = null;
            Name = name;
            Surname = surname;
        }
        #endregion

        #region Metody
        public string ToInsert()
        {
            return $"('{Name}', '{Surname}')";
        }
        #endregion
    }
}
