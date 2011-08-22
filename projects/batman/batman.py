from __future__ import division  # this is important, otherwise 1/2 will be 0
import matplotlib.pyplot
from numpy import arange
from numpy import meshgrid
from numpy import sqrt
from numpy import real

delta = 0.01
xrange = arange(-7.0, 7.0, delta)
yrange = arange(-3.0, 3.0, delta)
x, y = meshgrid(xrange,yrange)

F1 = (((x/7) ** 2) * sqrt(abs(abs(x) - 3)/(abs(x) - 3)) + ((y / 3) ** 2) * sqrt(abs(y + (3 * sqrt(33)) / 7)/(y + (3 * sqrt(33)) / 7)) - 1)
F2 = (abs(x/2) - ((3 * sqrt(33) - 7)/112) * x**2 - 3 + sqrt(1 - (abs(abs(x) - 2) - 1) ** 2 ) - y)
F3 = (9 * sqrt(abs((abs(x) - 1) * (abs(x) - 3/4))/((1 - abs(x)) * (abs(x) - 3/4))) - 8 * abs(x) - y)
F4 = (3 * abs(x) + 0.75 * sqrt(abs((abs(x) - 3/4) * (abs(x) - 1/2))/((3/4 - abs(x)) * (abs(x) - 1/2))) - y)
F5 = ((9/4) * sqrt(abs((x - 1/2) * (x + 1/2))/((1/2 - x) * (1/2 + x))) - y)
F6 = ((6 * sqrt(10)) / 7 + (3/2 - abs(x)/2) * sqrt(abs(abs(x) - 1)/(abs(x) - 1)) - ((6 * sqrt(10))/ 14) * sqrt(4 - (abs(x) - 1) ** 2 ) - y)


for f in [F1,F2,F3,F4,F5,F6]:
    matplotlib.pyplot.contour(x, y, f, [0])
matplotlib.pyplot.show()
