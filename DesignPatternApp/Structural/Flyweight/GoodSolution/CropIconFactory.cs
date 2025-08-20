namespace ch.px.designpattern.Structural.Flyweight.GoodSolution;
internal class CropIconFactory
{
    private Dictionary<CropType, CropIcon> _iconsCache = [];

    public CropIcon GetCropIcon(CropType cropType)
    {
        if (!_iconsCache.ContainsKey(cropType))
        {
            var icon = new CropIcon(cropType, null);
            _iconsCache.Add(cropType, icon);
        }

        return _iconsCache[cropType];
    }
}
