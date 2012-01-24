#include <iostream>
#include <cmath>

#include <Carbon/Carbon.h>

using namespace std;

// This code was written to test the performance of an algorithm I suggested on StackOverflow.
// http://stackoverflow.com/a/8991238/63225

int main (void) {
  UnsignedWide startTime, endTime;

  double result;

  Microseconds(&startTime);

  for (int i = 0; i < 1000000; ++i) {
    result = floor(log2(i)) + 1;
  }

  Microseconds(&endTime);

  printf("%d\n", endTime.lo - startTime.lo);

  uint32_t v; // find the log base 2 of 32-bit v
  int r;      // result goes here

  static const int MultiplyDeBruijnBitPosition[32] = 
  {
    0, 9, 1, 10, 13, 21, 2, 29, 11, 14, 16, 18, 22, 25, 3, 30,
    8, 12, 20, 28, 15, 17, 24, 7, 19, 27, 23, 6, 26, 5, 4, 31
  };

  Microseconds(&startTime);

  for (int i = 0; i < 1000000; ++i) {
    v = i;
    v |= v >> 1; // first round down to one less than a power of 2 
    v |= v >> 2;
    v |= v >> 4;
    v |= v >> 8;
    v |= v >> 16;

    result = MultiplyDeBruijnBitPosition[(uint32_t)(v * 0x07C4ACDDU) >> 27];
  }

  Microseconds(&endTime);
  printf("%d\n", endTime.lo - startTime.lo);
  return 0;
}
