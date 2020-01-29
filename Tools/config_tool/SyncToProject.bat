
set dstBinDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCAssets/cfgbin"
python ../common_python/SyncToProject.py cfgbin %dstBinDir%

set dstBinDir="../../Server/DCMainServer/DCMainServer/DCConfig/cfgbin"
python ../common_python/SyncToProject.py cfgbin %dstBinDir%

set dstSrcDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/src"
python ../common_python/SyncToProject.py csharp %dstSrcDir%

set dstSrcDir="../../Server/DCMainServer/DCMainServer/DCConfig/src"
python ../common_python/SyncToProject.py csharp %dstSrcDir%

set dstInitDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCConfig/init"
python ../common_python/SyncToProject.py init %dstInitDir%

set dstInitDir="../../Server/DCMainServer/DCMainServer/DCConfig/init"
python ../common_python/SyncToProject.py init %dstInitDir%

pause