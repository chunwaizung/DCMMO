using System;

namespace DC
{
    public abstract class StringMemModel
    {
        public string Content;
        public virtual string Serialize()
        {
            return Content;
        }

        public virtual void Deserialize(string content)
        {
            Content = content;
        }
    }
}