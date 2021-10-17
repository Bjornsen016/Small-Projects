using System.Collections.Generic;


namespace Notes
{
    public interface IStore<T>
    {
        public List<T> Load();
        public void Save(List<T> list);

    }
}