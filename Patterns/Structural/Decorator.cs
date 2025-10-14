using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural
{
    public interface IData
    {
        public void Save(string data);
    }

    public abstract class DecoratorData : IData
    {
        protected IData _data;

        public DecoratorData(IData data)
        {
            _data = data;
        }

        public virtual void Save(string data)
        {
            _data.Save(data);
        }
    }


    public class EncryptedData : DecoratorData
    {
        public EncryptedData(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            // Encrypt the data before saving
            var encryptedData = Encrypt(data);
            base.Save(encryptedData);
            Console.WriteLine($"Encrypted data saved: {encryptedData}");
        }

        private string Encrypt(string data)
        {
            // Implement encryption logic here
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(data));
        }
    }



    public class CompressedData : DecoratorData
    {
        public CompressedData(IData data) : base(data)
        {
        }

        public override void Save(string data)
        {
            // Compress the data before saving
            var compressedData = Compress(data);
            base.Save(compressedData);
            Console.WriteLine($"Compressed data saved: {compressedData}");
        }

        private string Compress(string data)
        {
            // Implement compression logic here
            return Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(data));
        }
    }

    public class DataStorage : IData
    {
        public void Save(string data)
        {
            // Implement the actual data storage logic here
            Console.WriteLine($"Data stored: {data}");
        }
    }
}