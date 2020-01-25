set dstSrcDir="../../Client/DCMMO_Unity/Assets/DCMMO/DCProto/ProtoSrc"
python ../common_python/SyncToProject.py csharp %dstSrcDir%

set dstSrcDir="../../Server/DCMainServer/DCMainServer/DCProto/ProtoSrc"
python ../common_python/SyncToProject.py csharp %dstSrcDir%

pause