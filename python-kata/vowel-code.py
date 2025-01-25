def encode(string):
  dict = {
    'a':'1',
    'e':'2',
    'i':'3',
    'o':'4',
    'u':'5'
  }

  arr = list(string)
  
  for i in range(len(arr)): # iterate through the list
    elm = arr[i]
    if elm in dict: # if array value is equal to a key in the dictionary
      arr[i] = dict[elm] # make the current value equal the the keys value
  
  return ''.join(arr)


print(encode('yikes'))

def decode(string):
  dict = {
    '1':'a',
    '2':'e',
    '3':'i',
    '4':'o',
    '5':'u'
  }

  arr = list(string)

  for i in range(len(arr)): # iterate through the list
    elm = arr[i]
    if elm in dict: # if array value is equal to a key in the dictionary
      arr[i] = dict[elm] # make the current value equal the the keys value

  return ''.join(arr)

print(decode(encode('yikes')))