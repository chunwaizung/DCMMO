# -*- coding: utf-8 -*-
import subprocess, os, sys

def getOutputDir(srcDir,dstDir,filePath):
  outputPath = filePath.replace(srcDir, dstDir).replace("\\","/")
  outDir = outputPath[:outputPath.rfind('/')]
  return outDir

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