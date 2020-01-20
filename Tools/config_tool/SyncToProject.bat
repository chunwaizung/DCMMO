set dstBinDir="../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/bin"
python SyncToProject.py bin %dstBinDir%

set dstSrcDir="../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/src"
python SyncToProject.py csharp %dstSrcDir%
pause