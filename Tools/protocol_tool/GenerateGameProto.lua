require("ProtocolConfig")
-- 遍历table使用模板生成代码
--[[
    io
    table
    string
    
]]--
local template = [[
using System;
using Google.Protobuf;

namespace Dcgameprotobuf
{
public class DCGameProtocol
{
    private static readonly byte[] s_no = new byte[4];

    public static int GetProtoId(byte[] content)
    {
        s_no[0] = content[0];
        s_no[1] = content[1];
        s_no[2] = content[2];
        s_no[3] = content[3];
        
        if (!BitConverter.IsLittleEndian)
        {
            Array.Reverse(s_no);
        }

        BitConverter.ToInt32(s_no, 0);
        return 0;
    }

    public static T Parse<T>(byte[] data) where T : IMessage<T>
    {
        var proto_id = GetProtoId(data);
        var offset = 4;
        var length = data.Length - offset;

        switch (proto_id)
        {
            %s
        }

        return default;
    }
}
}
]]
function GenerateScript()
    -- body
    local buf = "";
    for k,v in pairs(ProtoConfig) do
        local line = string.format( "case %d: return (T)%s.Descriptor.Parser.ParseFrom(data, offset, length);", k,v)
        buf = buf..line..'\n'
    end
    return string.format(template, buf)
end

function WriteToFile(path, content)
    -- body
    scriptFile = io.open(path,"w")
    scriptFile:write(content)
    scriptFile:close()
end

print("write to "..arg[1])
WriteToFile(arg[1], GenerateScript())