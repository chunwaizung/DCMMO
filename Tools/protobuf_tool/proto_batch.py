# -*- coding: utf-8 -*-
import sys
sys.path.append("../common_python")

import subprocess, os
import dc_file_util
# from ..common_python import dc_file_util
# from DCFileUtil import *

"""
example
protoc.exe -I=%srcDir% --csharp_out=%dstDir% %srcDir%/Person.proto

保持src目录中的文件目录结构编译到dst中

"""

proto_exe_path = sys.argv[1]
src_dir = sys.argv[2]
dst_dir = sys.argv[3]

def getComplieProtoCommand(srcDir,dstDir,filePath):
  outputDir = dc_file_util.getOutputDir(srcDir, dstDir, filePath)
  if not os.path.exists(outputDir):
    os.makedirs(outputDir)
  cmdStr = '{0} -I={1} --csharp_out={2} {3}'.format(proto_exe_path, srcDir, outputDir, filePath).replace('/','\\')
  return cmdStr

files = dc_file_util.getAllFilesWithExt(src_dir,".proto")
print("count src files: ", len(files))
cmdFile = open("generate_complie.bat","w")
for filePath in files:
  cmdStr = getComplieProtoCommand(src_dir, dst_dir, filePath)
  # os.system(cmdStr)
  cmdFile.write(cmdStr)
  cmdFile.write('\n')
cmdFile.close()
print("generate complete!")
subprocess.call("generate_complie.bat")
