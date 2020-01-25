# -*- coding: utf-8 -*-
import subprocess, os, sys, shutil

def writeToFile(path,content):
  dirName = os.path.dirname(path)
  if not os.path.exists(dirName):
    os.makedirs(dirName)

  f = open(path,"w")
  f.write(content)
  f.close()

# 保持目录结构复制满足后缀限定的文件到另一个文件夹
def copyFileTo(srcDir,dstDir,ext):
    if ext == "" :
      allFiles = getAllFiles(srcDir)
    else:
      allFiles = getAllFilesWithExt(srcDir,ext)

    for aFile in allFiles:
      outPath = getOutPutPath(srcDir, dstDir, aFile)
      shutil.copy2(aFile, outPath)

# 保持目录结构复制srcDir目录下所有内容到dstDir目录
def copyTree(srcDir,dstDir):
  allFiles = getAllFiles(srcDir)
  for aFile in allFiles:
    dstPath = getOutPutPath(srcDir, dstDir, aFile)
    
    dirName = os.path.dirname(dstPath)
    if not os.path.exists(dirName):
      os.makedirs(dirName)
      
    shutil.copy2(aFile, dstPath)

def convertSplitSymbol(path):
  return path.replace("\\","/")

# 获取输出路径
def getOutPutPath(srcDir,dstDir,filePath):
  outputPath = filePath.replace(srcDir, dstDir, 1).replace("\\","/")
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