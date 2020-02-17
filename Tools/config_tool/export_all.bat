rd /s/q bin
rd /s/q csharp
rd /s/q init

set excel_root="../../Configs/excels"
call export_excel.bat DemoCfgMgr %excel_root%/Demo.xlsx
call export_excel.bat MapCfgMgr %excel_root%/地图配置.xlsx
call export_excel.bat ParamsCfgMgr %excel_root%/参数配置.xlsx
call export_excel.bat LevelCfgMgr %excel_root%/关卡配置.xlsx
call export_excel.bat JobCfgMgr %excel_root%/职业配置表.xlsx
pause
