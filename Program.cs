// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Structural;

CropType cropType = CropType.Wheat;
CropFactory factory = new CropFactory();
CropIcon cropIcon = factory.GetCropIcon(cropType);
Crop crop = new Crop(0, 0, cropIcon);

 crop.Render();

CropList cropList = new CropList();
cropList.Render();
cropList.AddCrop(crop);
cropList.Render();