// Copyright (c) 2011 Scott Blomquist
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.

using System;
using System.IO;
using System.Text;

/// <summary>
/// This program was written to clean up some old HTML files that used an MSDOS code
/// page, and convert them to UTF-8 Unicode. Probably not general purpose enough for
/// most file conversions--I only included the characters in the switch/case that I
/// encountered.
/// </summary>
class utf8boxart
{
  static void Main(string[] args)
  {
    byte[] inbytes = File.ReadAllBytes(args[0]);
    var outstring = new StringBuilder(inbytes.Length);

    foreach (byte b in inbytes)
    {
    byte[] chr = new byte[1];
    if (b < 128)
    {
      chr[0] = b;
      outstring.Append(UTF8Encoding.UTF8.GetChars(chr));
    }
    else
      switch (b)
      {
      case 0xa7: outstring.Append("§");
        break;
      case 0xa9: outstring.Append("©");
        break;
      case 0xda: outstring.Append("┌");
        break;
      case 0xd9: outstring.Append("┘");
        break;
      case 0xc5: outstring.Append("┼");
        break;
      case 0xc4: outstring.Append("─");
        break;
      case 0xc3: outstring.Append("├");
        break;
      case 0xc2: outstring.Append("┬");
        break;
      case 0xc1: outstring.Append("┴");
        break;
      case 0xc0: outstring.Append("└");
        break;
      case 0xbf: outstring.Append("┐");
        break;
      case 0xb4: outstring.Append("┤");
        break;
      case 0xb3: outstring.Append("│");
        break;
      default:
        throw new Exception("Encountered unknown upper ASCII character.");
      }
    }

    File.WriteAllText(args[0] + ".new", outstring.ToString(), UTF8Encoding.UTF8);
  }
}