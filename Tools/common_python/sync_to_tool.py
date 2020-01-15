import os, sys, dc_file_util

srcDir = os.getcwd()
print srcDir

argCnt = sys.argv.count()
for i in range(1,argCnt-1):
    dc_file_util.copyFileTo(srcDir, sys.argv[i], ".py")