#coding:utf-8
import os,sys
import dc_file_util
import codecs

"""
扫描所有proto文件
找到带有protoid的message
输出为config
"""

rootDir = sys.argv[1]
allProtos = dc_file_util.getAllFilesWithExt(rootDir, ".proto")

idToName = {}

state_other = 0
state_message = 1
state_id = 2
cBuf = []

def processFile(file):
    c = file.read()
    while c :
        cBuf.remove()
        c = file.read()
    return 0

for protoFilePath in allProtos:
    protoFile = codecs.open(protoFilePath,"r", encoding='utf-8')
    processFile(protoFile)

    for line in open(protoFilePath,"r"):
        if line.startswith("message "):
            if len(previousLine) and previousLine.startswith("//")
                id = previousLine[2:]
                name = line[""]
            previousLine = line