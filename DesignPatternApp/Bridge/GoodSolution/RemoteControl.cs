﻿namespace ch.px.designpattern.Bridge.GoodSolution;
internal class RemoteControl
{
    private IDevice _device;

    public RemoteControl(IDevice device)
    {
        _device = device;
    }

    public void TurnOn()
    {
        _device.TurnOn();
    }

    public void TurnOff()
    {
        _device.TurnOff();
    }
}
