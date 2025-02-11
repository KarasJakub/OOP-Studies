using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using CsvHelper;
using CsvHelper.Configuration;
using System.Globalization;
using System.Text.RegularExpressions;

namespace LAB07
{
    public class ClientManager
    {
        private readonly string filePath = "clients.csv";
    
        public List<Client> LoadClients()
        {
            if (!File.Exists(filePath)) return new List<Client>();
            using var reader = new StreamReader(filePath);
            using var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture));
            return csv.GetRecords<Client>().ToList();
        }

        public void SaveClients(List<Client> clients)
        {
            using var writer = new StreamWriter(filePath);
            using var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture));
            csv.WriteRecords(clients);
        }

        public void AddClient(Client client)
        {
            var clients = LoadClients();
            client.Id = clients.Count > 0 ? clients.Max(c => c.Id) + 1 : 1;
            clients.Add(client);
            SaveClients(clients);
        }

        public void UpdateClient(int id, string newPhone)
        {
            var clients = LoadClients();
            var client = clients.FirstOrDefault(c => c.Id == id);
            if (client != null)
            {
                client.Phone = newPhone;
                SaveClients(clients);
            }
        }

        public void DeleteClient(int id)
        {
            var clients = LoadClients();
            clients.RemoveAll(c => c.Id == id);
            SaveClients(clients);
        }

        public void DisplayClients()
        {
            var clients = LoadClients();
            foreach (var client in clients)
            {
                Console.WriteLine($"{client.Id} {client.FirstName} {client.LastName} {client.Email} {client.Phone}");
            }
        }
    }
}