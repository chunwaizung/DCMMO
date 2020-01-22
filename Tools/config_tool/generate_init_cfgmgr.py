# -*- coding: UTF-8 -*-

import sys
sys.path.append("../common_python")
import dc_file_util

template = """
using System;
using System.IO;
using tabtoy;

namespace DC
{
    public partial class #clsName
    {
        public #clsName()
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
"""
content = template.replace("#clsName", sys.argv[1], 2)
dc_file_util.writeToFile(sys.argv[2], content)
