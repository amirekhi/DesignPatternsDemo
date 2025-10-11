// See https://aka.ms/new-console-template for more information

using DesignPatternsDemo.Patterns.Structural;

CropFactory cropFactory = new CropFactory();
CropService cropService = new CropService(cropFactory);
CropList cropList = cropService.GetCrops();
cropList.Render();