# -*- coding: utf-8 -*-
import subprocess, os, sys
"""
example
protoc.exe -I=%srcDir% --csharp_out=%dstDir% %srcDir%/Person.proto

保持src目录中的文件目录结构编译到dst中

"""

proto_exe_path = sys.argv[1]
src_dir = sys.argv[2]
dst_dir = sys.argv[3]

def getOutputDir(srcDir,dstDir,filePath):
  outputPath = filePath.replace(srcDir, dstDir).replace("\\","/")
  outDir = outputPath[:outputPath.rfind('/')]
  return outDir

def getRelativePath(srcDir, filePath):
  rPath = filePath[len(srcDir) + 1:]
  return rPath

def getAllProtoFiles(dir, extension):
  pathList = []
  for file in os.listdir(dir):
    childFile = os.path.join(dir,file)
    if os.path.isdir(childFile):
      pathList.extend(getAllProtoFiles(childFile, extension))
    elif os.path.splitext(childFile)[1] == extension:
      pathList.append(childFile.replace('\\','/'))
  return pathList

def complieProto(srcDir,dstDir,filePath):
  outputDir = getOutputDir(srcDir, dstDir, filePath)
  if not os.path.exists(outputDir):
    os.makedirs(outputDir)
  cmdStr = '{0} -I={1} --csharp_out={2} {3}'.format(proto_exe_path, srcDir, outputDir, filePath).replace('/','\\')
  return cmdStr

files = getAllProtoFiles(src_dir,".proto")
print "count src files: ", len(files)
cmdFile = open("generate_complie.bat","w")
for filePath in files:
  cmdStr = complieProto(src_dir, dst_dir, filePath)
  # os.system(cmdStr)
  cmdFile.write(cmdStr)
  cmdFile.write('\n')
cmdFile.write("pause\n")
cmdFile.close()
print("generate complete!")
subprocess.call("generate_complie.bat")
