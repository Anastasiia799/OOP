using System;
using System.Collections.Generic;
using System.Net;
using TRASH.DomainObjects;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;
using TRASH.InfrastructureServices.Gateways.Database;

namespace TRASH.ApplicationServices.Synchronization
{
    public class TRASH_Cell
    {
        public int global_id { get; set; }
        public int Number { get; set; }
        public TRASH_inf Cells { get; set; }   
    }

    public class TRASH_inf
    {
        public string YardName { get; set; }

        public string YardType { get; set; }

        public string YardArea { get; set; }

    }

    public class UseCaseTRASH
    {
        static string remoteUri = "https://apidata.mos.ru/v1/datasets/2542/rows?api_key=180a154931c715223eca25980904c000&$top=50";

        string path = @".\update_database\trash-";
        
        List<TRASH_Cell> trash_cells;

        public List<trash> trashs = new List<trash>();

        public UseCaseTRASH()
        {
            
            WebRequest request = WebRequest.Create(remoteUri);
            WebResponse response = request.GetResponse();
           
            StreamReader stream = new StreamReader(response.GetResponseStream());
            string line = stream.ReadToEnd();
            
            JArray jsonArray = JArray.Parse(line);
            
            trash_cells = JsonConvert.DeserializeObject<List<TRASH_Cell>>(jsonArray.ToString());
         
            DateTime Date_update = DateTime.Now;
            string date_update = Date_update.ToShortDateString();

            path = path + date_update + @".json";
            
            using (FileStream fs2 = new FileStream(path, FileMode.OpenOrCreate))
            {
                
                var options = new JsonSerializerOptions
                {
                    Encoder = JavaScriptEncoder.Create(UnicodeRanges.BasicLatin, UnicodeRanges.Cyrillic),
                    WriteIndented = true
                };
                
                string text = "[";
                byte[] input = Encoding.Default.GetBytes(text);
               
                fs2.Write(input, 0, input.Length);
                text = ",";

                for (int i = 0; i < trash_cells.Count; i++)
                {
                    trashs.Add(new trash()
                    {
                        YardName = trash_cells[i].Cells.YardName,
                        Id = trash_cells[i].Number,
                        YardType = trash_cells[i].Cells.YardType,
                        YardArea = trash_cells[i].Cells.YardArea,
                        
                    });

                    System.Text.Json.JsonSerializer.SerializeAsync<trash>(fs2, trashs[i], options).GetAwaiter().GetResult();

                    if (i != trash_cells.Count - 1)
                    {
                        input = Encoding.Default.GetBytes(text);
                        fs2.Write(input, 0, input.Length);
                    }
                }

                text = "]";
                input = Encoding.Default.GetBytes(text);
                fs2.Write(input, 0, input.Length);
            }   
        }
    }
}

