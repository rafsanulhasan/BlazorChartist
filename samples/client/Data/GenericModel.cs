using System.Collections.Generic;

namespace Client.Data
{
    public class GenericModel<T>
    {
        public string Name { get; private set; }
        public List<T> Values { get; private set; }
        public double Scale { get; set; } = 1.0;
        public bool Show { get; set; }

        public GenericModel(string name, NextData generator, int n)
        {
            Name = name;
            Values = new List<T>();
            Initialize(generator, n);
        }

        public delegate T NextData(int n, double scale);

        private void Initialize(NextData generator, int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Values.Add(generator(i, Scale));
            }
        }

        public void Add(NextData generator)
        {
            Values.Add(generator(Values.Count + 1, Scale));
        }

        public void Remove()
        {
            Values.RemoveAt(Values.Count - 1);
        }

        public void Reset(NextData generator, int n)
        {
            Values.Clear();
            Initialize(generator, n);
        }

        public void Update(NextData generator, int n)
        {
            Values.Clear();
            Initialize(generator, n);
        }
    }
}