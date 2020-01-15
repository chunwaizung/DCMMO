set dstBinDir="../Client/DCMMO_Unity/Assets/DCConfig/bin"
REM set dstBinDir="../test/bin"
python SyncToProject.py bin %dstBinDir%

set dstSrcDir="../Client/DCMMO_Unity/Assets/DCConfig/src"
REM set dstSrcDir="../test/src"
python SyncToProject.py csharp %dstSrcDir%
pause