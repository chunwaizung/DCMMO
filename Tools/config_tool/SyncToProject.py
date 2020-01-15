# -*- coding: utf-8 -*-
import subprocess, os, sys
import shutil
import distutils

src = sys.argv[1]
dst = sys.argv[2]

distutils.dir_util.copy_tree(src,dst)
# shutil.copytree(src,dst)

def getDstFilePath(srcDirRoot, dstDirRoot, filePath):
    return ""

def copyTreeOverride(srcDir,dstDir):
    all = os.listdir(srcDir)