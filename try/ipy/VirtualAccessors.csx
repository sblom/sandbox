LoadAssembly("VirtualAccessors.dll");

var s = new SetOverride();
var g = new GetOverride();

s.Accessor = 1;
s.Accessor;
g.Accessor = 1;
g.Accessor;
