using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.IO;
using System.Data;

namespace Uchetnik
{
    class server
    {
        static string put = Environment.CurrentDirectory;
        static FileStream file = new FileStream(@"" + put + "\\server", FileMode.Open);//открытие файла, от куда брать данные для подключения к серверу MySQL, создание файлового потока
        static StreamReader reader = new StreamReader(file);//создание потоковый читатель и связывание его с файловым потоком
        static string address = reader.ReadLine(); static string login = reader.ReadLine(); static string password = reader.ReadLine(); static string database = reader.ReadLine();
        static string quere = "server=" + address + ";userid=" + login + ";password=" + password + ";database=" + database;
        static MySqlConnection connection = new MySqlConnection(quere);

        public static void openConnection()
        {
            if (connection.State == ConnectionState.Closed) // Проверяем что подключения нет
                connection.Open(); // Открываем соединение
        }
        public static void closeConnection()
        {
            if (connection.State == ConnectionState.Open) // Проверяем что подключение есть
                connection.Close(); // Закрыть соединение
        }

        public static MySqlConnection getConnection()
        {
            return connection;
        }
    }
}
