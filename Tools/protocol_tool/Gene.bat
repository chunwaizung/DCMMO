set dstPath="../../Client/DCMMO_Unity/Assets/DCProto/DCGameProtocol.cs"
lua GenerateGameProto.lua %dstPath%

set dstPath="../../Client/DCMMO_Unity/Assets/DCProto/DCProtocolIds.cs"
lua GenerateProtocolIds.lua %dstPath%
pause