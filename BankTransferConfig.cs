using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text.Json.Serialization;
using System.Text.Json;
using System.Text.Json.Nodes;
using System.Diagnostics.SymbolStore;
using static modul8_103022300126.BankTransferConfig.Config.transfer;
using static modul8_103022300126.BankTransferConfig.Config;



namespace modul8_103022300126
}
public class BankTransferConfig
{
    public class Config
    {
        public string lang { get; set; }
        public Transfer transfer { get; set; }
        public confirmation confirmation { get; set; }
        public List<string> method { get; set; }

        public class Transfer
        {
            public int threshold { get; set; }
            public int low_fee { get; set; }
            public int high_fee
            {
                get; set;


            }





        }
        public class confirmation
        {
            public string en { get; set; }
            public string id { get; set; }
        }


    }

    public Config config;
    public BankTransferConfig() { }

    public BankTransferConfig readJson()
    {
        string jsonString = File.ReadAllText("bank_transfer_config.json");
        var options = new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true
        };


        BankTransferConfig? json = JsonSerializer.Deserialize<BankTransferConfig>(jsonString, options);
        if (json == null)
        {
            throw new Exception("Gagal membaca File");
        }
        return json;
    }
    public void writeNewConfig()
    {
        JsonSerializerOptions options = new JsonSerializerOptions
        {
            WriteIndented = true
        };
        string jsonString = JsonSerializer.Serialize(BankTransferConfig, options);
        File.WriteAllText(filepath, jsonString);
    }
    public void setDefault()
    {
        lang = "en";
        methods = new List<string> { "bank_transfer" };
        transfer = new transfer
        {
            threshold = 25000000,
            low_fee = 6500,
            high_fee = 15000
        };

        confirmation = new confirmation
        {
            en = "yes",
            id = "ya"
        };
    }

    public void UbahBahasa()
    {

        if (lang == "en")
        {
            lang = "id";
            confirmation.en = "ya";
        }
        else
        {
            lang = "en";
            confirmation.en = "yes";
        }
    }
}

