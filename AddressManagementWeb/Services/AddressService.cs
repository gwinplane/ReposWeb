using AddressManagementWeb.Data;
using AddressManagementWeb.Models;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace AddressManagementWeb.Services
{
    public class AddressService
    {
        private readonly Database _db;

        public AddressService()
        {
            _db = new Database();
        }

        // Проверка существования
        public bool AddressExists(string street, string houseNumber)
        {
            using var conn = _db.GetConnection();
            conn.Open();

            string query = "SELECT COUNT(*) FROM addresses WHERE street = @street AND house_number = @house";
            var cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@street", street);
            cmd.Parameters.AddWithValue("@house", houseNumber);

            int count = Convert.ToInt32(cmd.ExecuteScalar());

            return count > 0;
        }

        // CREATE
        public bool AddAddress(Address address)
        {
            if (AddressExists(address.Street, address.HouseNumber))
            {
                return false; // Адрес существует
            }

            try
            {
                using var conn = _db.GetConnection();
                conn.Open();

                string query = @"INSERT INTO addresses
                    (street, house_number, postal_code, city, country)
                    VALUES (@street, @house, @postal, @city, @country)";

                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@street", address.Street);
                cmd.Parameters.AddWithValue("@house", address.HouseNumber);
                cmd.Parameters.AddWithValue("@postal", address.PostalCode);
                cmd.Parameters.AddWithValue("@city", address.City);
                cmd.Parameters.AddWithValue("@country", address.Country);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }

        // READ
        public List<Address> GetAllAddresses()
        {
            var addresses = new List<Address>();

            using var conn = _db.GetConnection();
            conn.Open();

            string query = "SELECT * FROM addresses";
            var cmd = new MySqlCommand(query, conn);

            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                addresses.Add(new Address
                {
                    Id = (int)reader["id"],
                    Street = reader["street"].ToString(),
                    HouseNumber = reader["house_number"].ToString(),
                    PostalCode = reader["postal_code"].ToString(),
                    City = reader["city"].ToString(),
                    Country = reader["country"].ToString()
                });
            }

            return addresses;
        }

        // DELETE
        public bool DeleteAddress(int id)
        {
            try
            {
                using var conn = _db.GetConnection();
                conn.Open();

                string query = "DELETE FROM addresses WHERE id = @id";
                var cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", id);

                cmd.ExecuteNonQuery();

                return true;
            }
            catch (MySqlException)
            {
                return false;
            }
        }
    }
}