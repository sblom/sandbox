import sys

import clr
clr.AddReference("./VirtualAccessors.dll")
import SetOverride, GetOverride

s = SetOverride()
g = GetOverride()

try:
  s.Accessor = 1
except:
  print >>sys.stderr, "SetOverride setter failed."

try:
  s.Accessor
except:
  print >>sys.stderr, "SetOverride getter failed."

try:
  g.Accessor = 1
except:
  print >>sys.stderr, "GetOverride setter failed."

try:
  g.Accessor
except:
  print >>sys.stderr, "SetOverride getter failed."
