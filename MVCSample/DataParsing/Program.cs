﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataParsing
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<EanData> lstEanData = new List<EanData>();
                var list = File.ReadAllLines(@"E:\ean-data.txt");
                char[] delimiters = new char[] { '~', '|', '~' };
                bool isHeading = true;
                foreach (string line in list)
                {

                    if (isHeading == false)
                    {
                        string txt = line.Replace("~", "");
                        string[] data = txt.Split(delimiters);
                        if (data != null)
                        {
                            EanData eadData = new EanData();
                            eadData.Column = data[0];
                            eadData.Distributor_id = data[1];
                            eadData.Fact_count = data[2];
                            lstEanData.Add(eadData);
                        }
                    }
                    else
                        isHeading = false;


                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }
            Console.WriteLine("Data parsing completed successfully");
            Console.ReadKey();
        }
    }
    public class EanData
    {
        public string Column { get; set; }
        public string Distributor_id { get; set; }
        public string Fact_count { get; set; }
    }
}
