import sys, os

print 'sys.argv[0] =', sys.argv[0]      # script name   (for testing)
print 'os.getcwd() =', os.getcwd()      # where we are  (for testing)

print 'script running from', os.path.dirname(sys.argv[0])
