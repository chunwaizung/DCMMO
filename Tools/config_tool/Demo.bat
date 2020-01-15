REM tabtoy2.9.0.windows_x64
REM --json_out=config.json ^
REM --proto_out=.\pb\proto.proto ^

tabtoy ^
--mode=v2 ^
--csharp_out=.\csharp\Npc.cs ^
--binary_out=.\bin\Npc.bin ^
--combinename=Npc Demo.xlsx
pause