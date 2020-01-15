# -*- coding: utf-8 -*-
import subprocess, os, sys, shutil

# 保持目录结构复制满足后缀限定的文件到另一个文件夹
def copyFileTo(srcDir,dstDir,ext):
    if ext == "" :
        allFiles = getAllFiles(srcDir)
    else:
        allFiles = getAllFilesWithExt(srcDir,ext)
    for aFile in allFiles:
        shutil.copy2(aFile, getOutPutPath(srcDir, dstDir, aFile))

# 保持目录结构复制srcDir目录下所有内容到dstDir目录
def copyTree(srcDir,dstDir):
  allFiles = getAllFiles(srcDir)
  for aFile in allFiles:
    shutil.copy2(aFile, getOutPutPath(srcDir, dstDir, aFile))

# 获取输出路径
def getOutPutPath(srcDir,dstDir,filePath):
  outputPath = filePath.replace(srcDir, dstDir).replace("\\","/")
  return outputPath

# 获取输出目录
def getOutputDir(srcDir,dstDir,filePath):
  outputPath = getOutPutPath(srcDir,dstDir,filePath)
  outDir = outputPath[:outputPath.rfind('/')]
  return outDir

# 获取相对路径
def getRelativePath(srcDir, filePath):
  rPath = filePath[len(srcDir) + 1:]
  return rPath

def getAllFilesWithExt(dir, extension):
  pathList = []
  for file in os.listdir(dir):
    childFile = os.path.join(dir,file)
    if os.path.isdir(childFile):
      pathList.extend(getAllFilesWithExt(childFile, extension))
    elif os.path.splitext(childFile)[1] == extension:
      pathList.append(childFile.replace('\\','/'))
  return pathList

def getAllFiles(dir):
  pathList = []
  for file in os.listdir(dir):
    childFile = os.path.join(dir,file)
    if os.path.isdir(childFile):
      pathList.extend(getAllFiles(childFile))
    else:
      pathList.append(childFile.replace('\\','/'))
  return pathList