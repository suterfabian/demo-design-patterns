﻿namespace ch.px.designpattern.Composite.BadSolution;
internal class Box
{
    private List<object> items = new List<object>();

    public void Add(Object item)
    {
        items.Add(item);
    }

    public float CalculateTotalPrice()
    {
        float totalPrice = 0f;

        foreach (var item in items)
        {
            if (item is Keyboard)
            {
                totalPrice += ((Keyboard)item).Price;
            }
            else if (item is Mouse)
            {
                totalPrice += ((Mouse)item).Price;
            }
            else if (item is Microphone)
            {
                totalPrice += ((Microphone)item).Price;
            }
            else if (item is Box)
            {
                totalPrice += ((Box)item).CalculateTotalPrice();
            }
        }

        return totalPrice;
    }
}
