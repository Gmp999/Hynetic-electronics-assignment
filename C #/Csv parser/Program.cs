using System;
using System.IO;
using Microsoft.VisualBasic.FileIO;

class Program
{
    static void Main(string[] args)
    {
        
        string inputFilePath = @"D:\Hynetic-electronics-assignment\C #\Csv parser\sample_data.csv";
        string outputFilePath = @"D:\Hynetic-electronics-assignment\C #\Csv parser\output.csv";

        if (!File.Exists(inputFilePath))
        {
            Console.WriteLine("Input file not found.");
            return;
        }

        using (TextFieldParser parser = new TextFieldParser(inputFilePath))
        using (StreamWriter writer = new StreamWriter(outputFilePath))
        {
            parser.TextFieldType = FieldType.Delimited;
            parser.SetDelimiters(",");

            writer.WriteLine("Slno,Date&time,IMEI,PSLNo,Intensity,Voltage,Current,Power,MqttByte,SLCfault,Driverfault");

            if (!parser.EndOfData)
                parser.ReadFields(); 

            int slno = 1;

            while (!parser.EndOfData)
            {
                string[] fields = parser.ReadFields();

                if (fields.Length < 4)
                    continue;

                string messageType = fields[1];
                string messageField = fields[2];
                string dateTimeField = fields[3];

                messageField = messageField.Replace("\"", "");

                string[] pairs = messageField.Split(',');

                
                string imei = GetValue(pairs, 0);
                string pslNo = GetValue(pairs, 1);
                string intensity = GetValue(pairs, 2);
                string voltage = GetValue(pairs, 3);
                string current = GetValue(pairs, 4);
                string power = GetValue(pairs, 5);
                string mqttByte = GetValue(pairs, 6);
                string slcFault = GetValue(pairs, 7);
                string driverFault = GetValue(pairs, 8);

                string outputRow = $"{slno},{dateTimeField},{imei},{pslNo},{intensity},{voltage},{current},{power},{mqttByte},{slcFault},{driverFault}";

                writer.WriteLine(outputRow);
                slno++;
            }
        }

        Console.WriteLine("CSV transformation completed successfully.");
    }

    static string GetValue(string[] pairs, int index)
    {
        if (index >= pairs.Length)
            return "";

        string[] keyValue = pairs[index].Split('=');
        return keyValue.Length > 1 ? keyValue[1] : "";
    }
}
