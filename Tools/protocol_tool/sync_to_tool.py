import os, sys, dc_file_util

srcDir = dc_file_util.convertSplitSymbol(os.getcwd())
print "srcDir ", srcDir

argCnt = len(sys.argv)
print "argCnt:", argCnt

for i in range(1,argCnt):
    absDstDir = dc_file_util.convertSplitSymbol(os.path.abspath(sys.argv[i]))
    dc_file_util.copyFileTo(srcDir, absDstDir, ".py")