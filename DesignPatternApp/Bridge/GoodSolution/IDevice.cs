namespace ch.px.designpattern.Bridge.GoodSolution;
internal interface IDevice
{
    public void TurnOn();
    public void TurnOff();
    public void SetChannel(int channel);
}
