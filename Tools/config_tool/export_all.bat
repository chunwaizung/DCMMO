rd /s/q bin
rd /s/q csharp
rd /s/q init

set excel_root="../../Configs/excels"
call export_excel.bat DemoCfgMgr %excel_root%/Demo.xlsx
call export_excel.bat MapCfgMgr %excel_root%/��ͼ����.xlsx
call export_excel.bat ParamsCfgMgr %excel_root%/��������.xlsx
call export_excel.bat LevelCfgMgr %excel_root%/�ؿ�����.xlsx
call export_excel.bat JobCfgMgr %excel_root%/ְҵ���ñ�.xlsx
pause
