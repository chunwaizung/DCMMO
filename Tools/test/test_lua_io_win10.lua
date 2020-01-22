local fileA = io.open("a.txt",'w')
fileA:write("this is file a")
fileA:close()

local fileB = io.open("dir/b.txt",'w')
fileB:write("this is file b")
fileB:close()