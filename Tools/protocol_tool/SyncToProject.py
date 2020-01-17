# -*- coding: utf-8 -*-
import sys
import dc_file_util

src = sys.argv[1]
dst = sys.argv[2]

dc_file_util.copyTree(src,dst)
