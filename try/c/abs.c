#include <math.h>
#include <stdio.h>

/* turns out that absolute value doesn't always give a positive result in C */

int main (int argc, char* argv[]) {
  int x = abs(0x80000000);
  if (x < 0) printf("abs(0x80000000) is negative! (%d)\n", x);
  return 0;
}
