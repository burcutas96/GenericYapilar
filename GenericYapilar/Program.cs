
List<string> sehirler = new List<string>();
sehirler.Add("Şanlıurfa");
Console.WriteLine(sehirler.Count);

MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Şanlıurfa");
sehirler2.Add("Gaziantep");
sehirler2.Add("Diyarbakır");
Console.WriteLine(sehirler2.Count);


class MyList<T>
{
    T[] _array;
    public MyList()
    {
        _array = new T[0];
    }
    public void Add(T item)
    {
        //Aşağıdaki kodla _arrayin referans numarasını tutmuş olduk.
        T[] tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < tempArray.Length; i++)
        {
            _array[i] = tempArray[i];
        }
        _array[_array.Length - 1] = item;
    }
    public int Count 
    {
        get
        {
            return _array.Length;
        }
    }
}



