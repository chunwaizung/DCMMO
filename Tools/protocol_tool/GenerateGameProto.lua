require("ProtocolConfig")
require("dc_file_util")

-- 遍历table使用模板生成代码
--[[
    io
    table
    string
    
]]--
local DCGameProtocolTempl = [[
using Google.Protobuf;

namespace Dcgameprotobuf
{
    public static partial class DCGameProtocol
    {
        public static int GetId(IMessage t)
        {
            int id = 0;
            switch (t.GetType().Name)
            {
%s
            }

            return id;
        }

        public static object Parse(int proto_id, byte[] data, int offset, int length)
        {
            switch (proto_id)
            {
%s
            }

            return default;
        }
        
    }
}
]]
function GenerateDCGameProtocolScript()
    -- body
    local convertBuf = ""

    local parseBuf = ""
    for k,v in pairs(ProtoConfig) do
        local convertLine = string.format( "case \"%s\": id = %d;break;", v,k)
        convertBuf = convertBuf..convertLine..'\n'

        local parseLine = string.format( "case %d: return %s.Descriptor.Parser.ParseFrom(data, offset, length);", k,v)
        parseBuf = parseBuf..parseLine..'\n'
    end
    return string.format(DCGameProtocolTempl, convertBuf, parseBuf)
end

print("write to "..arg[1])

WriteToFile(arg[1], GenerateDCGameProtocolScript())
