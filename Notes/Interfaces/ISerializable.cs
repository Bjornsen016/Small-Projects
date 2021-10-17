namespace Notes
{
    public interface ISerializable
    {
        public string ObjectToString();
        public void FillObjectFromString(string text);
    }
}