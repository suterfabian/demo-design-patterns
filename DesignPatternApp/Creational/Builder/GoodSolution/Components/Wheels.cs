namespace ch.px.designpattern.Creational.Builder.GoodSolution.Components;

internal class Wheels
{
    private float _diameterInInches;

    public Wheels(float diameterInInches)
    {
        _diameterInInches = diameterInInches;
    }

    public float GetDiameterInInches()
    {
        return _diameterInInches;
    }
}
