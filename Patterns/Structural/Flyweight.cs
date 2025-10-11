using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatternsDemo.Patterns.Structural
{
    public enum CropType
    {
        Wheat,
        Corn,
        Rice
    }

    public class Crop{
        public int X { get; set; }
        public int Y { get; set; }
        public CropIcon Icon { get; set; }


        public Crop(int x, int y, CropIcon icon)
        {
            X = x;
            Y = y;
            Icon = icon;
        }

        public void Render(){
            Console.WriteLine($"Rendering crop at ({X}, {Y}) with icon {Icon.Draw()}");
        }
    }


    public class CropIcon
    {
        private readonly CropType Type;
        private readonly byte[]? IconData;

        public CropIcon(CropType type , byte[]? data)
        {
            Type = type;
            IconData = data;
        }



        public string Draw()
        {
            return $"Drawing {Type} icon";
        }
    }


    public class CropFactory
    {
        private readonly Dictionary<CropType, CropIcon> _icons = new();

        public CropIcon GetCropIcon (CropType type)
        {
            if (!_icons.ContainsKey(type))
            {
                // Simulate loading icon data
                byte[]? iconData = LoadIconData(type);
                _icons[type] = new CropIcon(type, iconData);
            }

            return _icons[type];
        }

        private byte[]? LoadIconData(CropType type)
        {
            // Simulate loading icon data from a resource
            return new byte[] { (byte)type };
        }
    }


    public class CropList
    {
        private readonly List<Crop> _crops = new();

        public void AddCrop(Crop crop)
        {
            _crops.Add(crop);
        }
        public CropList()
        {
            //representing a database fetch of crops data and adding them to the list
            CropType type = CropType.Wheat;
            CropFactory factory = new CropFactory();
            CropIcon icon = factory.GetCropIcon(type);
            Crop crop1 = new Crop(0, 5, icon);
            Crop crop2 = new Crop(1, 2, icon);
            Crop crop3 = new Crop(3, 4, icon);
            AddCrop(crop1);
            AddCrop(crop2);
            AddCrop(crop3);
        }

        public void Render()
        {
            foreach (var crop in _crops)
            {
                crop.Render();
            }
        }
    }
}