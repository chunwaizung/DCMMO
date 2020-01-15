set proto_exe_path="protoc-3.9.1-win64/bin/protoc.exe"
set src_dir="../../Protocol/src"
set dst_dir="csharp"
python proto_batch.py %proto_exe_path% %src_dir% %dst_dir%
pause