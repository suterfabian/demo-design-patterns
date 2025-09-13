namespace ch.px.designpattern.Behavioral.Iterator.GoodSolution;
internal interface IIterator<T>
{
    void Next();
    bool HasNext();
    T Current();
}
