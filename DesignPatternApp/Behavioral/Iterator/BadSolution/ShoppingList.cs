namespace ch.px.designpattern.Behavioral.Iterator.BadSolution
{
    internal class ShoppingList
    {
        private List<string> _list = [];

        public void Push(string item)
        {
            _list.Add(item);
        }

        public string Pop()
        {
            var last = _list.Last();
            _list.Remove(last);
            return last;
        }

        public List<string> GetList()
        {
            return _list;
        }
    }
}
