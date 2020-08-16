import sys
try:
	file = open(file_name,"w")
except IOError:
	print("File name:",file_name)
	sys.exit()