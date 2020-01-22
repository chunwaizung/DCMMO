
using System;
using System.IO;
using tabtoy;

namespace DC
{
    public partial class DemoCfgMgr
    {
        public DemoCfgMgr()
        {
            using (var stream = new MemoryStream(ConfigUtil.GetBin(GetType())))
            {
                var config = this;

                var reader = new DataReader(stream);

                var result = reader.ReadHeader(config.GetBuildID());

                if (result != FileState.OK)
                {
                    Console.WriteLine("combine file crack!");
                    return;
                }

                Deserialize(config, reader);
            }
        }
    }
}
