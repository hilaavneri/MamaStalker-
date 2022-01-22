namespace MamasStalker.Common
{
    public interface IDataHandler
    {
        void HandleData(int bytesRec, byte[] data);
    }
}
