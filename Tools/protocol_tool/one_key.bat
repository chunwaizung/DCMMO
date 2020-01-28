cd ../protobuf_tool
call one_key.bat

cd ../protocol_tool_csharp/
call generate_config.bat

REM set srcDir=../../Protocol/src
REM dotnet run %srcDir% ../protocol_tool/ProtocolConfig.lua -p ../protocol_tool_csharp/prototool_csharp.csproj

cd ../protocol_tool
call GenerateGameProto.bat