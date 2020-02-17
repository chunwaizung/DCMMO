namespace DC.Model
{
    public class BaseModel
    {
        public void Save()
        {
            DCDB.Instance.Save(this);
        }
    }
}