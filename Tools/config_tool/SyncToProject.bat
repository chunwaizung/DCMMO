set dstBinDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/bin"
python ../common_python/SyncToProject.py bin %dstBinDir%

set dstSrcDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/src"
python ../common_python/SyncToProject.py csharp %dstSrcDir%

set dstInitDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/init"
python ../common_python/SyncToProject.py init %dstInitDir%

pause