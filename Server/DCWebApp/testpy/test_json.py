import json
import uuid

data = [ { 'a' : 1, 'b' : 2, 'c' : 3, 'd' : 4, 'e' : 5 } ]
data2 = { 'a' : 1, 'b' : 2, 'c' : 3, 'd' : 4, 'e' : 5 }

jsonStr = json.dumps(data)
print(jsonStr)

jsonStr = json.dumps(data2, sort_keys=True, indent=4, separators=(',', ': '))
print(jsonStr)

jsonData = '{"a":1,"b":2,"c":3,"d":4,"e":5}';

jsonObj = json.loads(jsonData)
print(jsonObj)

print('hello','print')