set clsName=%1
set excelPath=%2
tabtoy ^
--mode=v2 ^
--csharp_out=.\csharp\%clsName%.cs ^
--binary_out=.\bin\%clsName%.bytes ^
--combinename=%clsName% %excelPath%

python generate_init_cfgmgr.py %clsName% init/%clsName%.cs