namespace week3_day4_Gnarc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ARR<int> arr= new ARR();
            arr.add(1);
            arr.add(2);
            arr.add(3);
            arr.add(4);
            arr.add(5);
            arr.add(6);
            arr.RemoveAt(3);
            arr.Display(5);
           
        }
    }
    class ARR<T>
    {
        private T[] itemes;
        public void add (T _iteme)
        {
            if (itemes is null)
            {
                itemes = new T[] { _iteme};
            }
            else
            {
                int length = itemes.Length;
                T[] temp = new T[length+1];
                for (int i=0; i< length; i++)
                {
                    temp[i] = itemes[i];
                }
                temp[temp.Length - 1] = _iteme;
                itemes = temp;
            }

        }
        public void RemoveAt(int index)
        {
            if (index < 0 || index > itemes.Length - 1)
            {
                return;
            }
            int pos = 0;
            T[] temp = new T[itemes.Length - 1];
           
            for (int i=0;i<itemes.Length;i++)
            {
                if (i == index)
                {
                    continue;
                }
                temp[pos++] = itemes[i];
            }
        }
        public bool IsEmpty => itemes is null || itemes.Length == 0;

        public int Count => itemes.Length;
        
        public void Display(T _iteme)
        {
            Console.Write("[");
            foreach (T item in itemes)
            {
                Console.Write(item + ",");
            }
                Console.WriteLine("]");
        }
    }
}