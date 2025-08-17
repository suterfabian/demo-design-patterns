namespace ch.px.designpattern.Flyweight.BadSolution;
internal class CropService
{
    public List<Crop> GetCrops()
    {
        var cropList = new List<Crop>();

        // fetch from db
        var carrot1 = new Crop(1, 4, CropType.Carrot, null);
        var carrot2 = new Crop(2, 4, CropType.Carrot, null);
        var carrot3 = new Crop(3, 4, CropType.Carrot, null);

        cropList.Add(carrot1);
        cropList.Add(carrot2);
        cropList.Add(carrot3);

        return cropList;
    }
}
