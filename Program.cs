// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Structural;

DataStorage dataStorage = new DataStorage();
EncryptedData encryptedData = new EncryptedData(dataStorage);
encryptedData.Save("Sensitive Data");
CompressedData compressedData = new CompressedData(encryptedData);
compressedData.Save("Data Compressed");