require("ProtocolConfig")
require("dc_file_util")

local DCProtocolIdsTempl = [[
namespace Dcgameprotobuf
{
    public static class DCProtocolIds
    {
%s
    }
}
]]

function GeneDCProtocolIds(templ)
    -- body
    local buf = ""
    for k,v in pairs(ProtoConfig) do
        local line = string.format( "public const int %s = %d;", v,k)
        buf = buf..line..'\n'
    end
    return string.format( templ,buf)
end

print("write to "..arg[1])

WriteToFile(arg[1], GeneDCProtocolIds(DCProtocolIdsTempl))