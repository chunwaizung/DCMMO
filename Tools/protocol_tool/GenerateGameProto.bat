set dstPath="../../Client/DCMMO_Unity/Assets/DCMMO/DCProto/DCGameProtocol.cs"
lua GenerateGameProto.lua %dstPath%

set dstPath="../../Client/DCMMO_Unity/Assets/DCMMO/DCProto/DCProtocolIds.cs"
lua GenerateProtocolIds.lua %dstPath%
pause