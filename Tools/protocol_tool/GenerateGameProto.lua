require("ProtocolConfig")
-- 遍历table使用模板生成代码
--[[
    io
    table
    string
    
]]--
local template = [[
using Google.Protobuf;

namespace Dcgameprotobuf
{
    public static partial class DCGameProtocol
    {
        public static int GetId<T>(T t) where T : IMessage<T>
        {
            int id = 0;
            switch (typeof(T).Name)
            {
%s
            }

            return id;
        }

        public static object Parse(byte[] data, out int id)
        {
            var proto_id = GetProtoId(data);
            id = proto_id;
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
    local convertBuf = ""

    local parseBuf = ""
    for k,v in pairs(ProtoConfig) do
        local convertLine = string.format( "case \"%s\": id = %d;break;", v,k)
        convertBuf = convertBuf..convertLine..'\n'

        local parseLine = string.format( "case %d: return %s.Descriptor.Parser.ParseFrom(data, offset, length);", k,v)
        parseBuf = parseBuf..parseLine..'\n'
    end
    return string.format(template, convertBuf, parseBuf)
end

function WriteToFile(path, content)
    -- body
    scriptFile = io.open(path,"w")
    scriptFile:write(content)
    scriptFile:close()
end

print("write to "..arg[1])
WriteToFile(arg[1], GenerateScript())