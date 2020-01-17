namespace DC.Net
{
    public class ManualRes
    {
        protected bool mDisposed;

        public virtual void DisposeRes()
        {
            mDisposed = true;
        }
    }
}