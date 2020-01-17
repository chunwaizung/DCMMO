function WriteToFile(path, content)
    -- body
    scriptFile = io.open(path,"w")
    scriptFile:write(content)
    scriptFile:close()
end