function WriteToFile(path, content)
    -- body
    local scriptFile = io.open(path,"w")
    if scriptFile == nil
    then
      print("error path: ", path)
      return
    end
    scriptFile:write(content)
    scriptFile:close()
end