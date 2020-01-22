rd /s/q bin
rd /s/q csharp
rd /s/q init

set excel_root="../../Configs/excels"
call export_excel.bat DemoCfgMgr %excel_root%/Demo.xlsx
call export_excel.bat MapCfgMgr %excel_root%/MapConfig.xlsx
pause
