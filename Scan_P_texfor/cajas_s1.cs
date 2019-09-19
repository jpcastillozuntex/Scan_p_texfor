// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.cajas_s1
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices;

namespace Scan_P_texfor
{
  [StandardModule]
  internal sealed class cajas_s1
  {
    private static empresas obj = new empresas();
    private static SqlConnection cnn = new SqlConnection();

    private static string recorta(string texto, int t)
    {
      return Strings.Mid(texto, 1, t);
    }

    public class RawPrinterHelper
    {
      [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, ref IntPtr hPrinter, IntPtr pd);

      [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool ClosePrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool StartDocPrinter(
        IntPtr hPrinter,
        int level,
        [MarshalAs(UnmanagedType.LPStruct), In] cajas_s1.RawPrinterHelper.DOCINFOA di);

      [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool EndDocPrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool StartPagePrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool EndPagePrinter(IntPtr hPrinter);

      [DllImport("winspool.Drv", CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool WritePrinter(
        IntPtr hPrinter,
        IntPtr pBytes,
        int dwCount,
        ref int dwWritten);

      [DllImport("winspool.Drv", EntryPoint = "OpenPrinterW", CharSet = CharSet.Unicode, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
      public static extern bool OpenPrinter(string src, ref IntPtr hPrinter, long pd);

      public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, int dwCount)
      {
        int num = 0;
        int dwWritten = 0;
        IntPtr hPrinter = new IntPtr(0);
        cajas_s1.RawPrinterHelper.DOCINFOA di = new cajas_s1.RawPrinterHelper.DOCINFOA();
        bool flag = false;
        di.pDocName = "My C#.NET RAW Document";
        di.pDataType = "RAW";
        if (cajas_s1.RawPrinterHelper.OpenPrinter(szPrinterName.Normalize(), ref hPrinter, IntPtr.Zero))
        {
          if (cajas_s1.RawPrinterHelper.StartDocPrinter(hPrinter, 1, di))
          {
            if (cajas_s1.RawPrinterHelper.StartPagePrinter(hPrinter))
            {
              flag = cajas_s1.RawPrinterHelper.WritePrinter(hPrinter, pBytes, dwCount, ref dwWritten);
              cajas_s1.RawPrinterHelper.EndPagePrinter(hPrinter);
            }
            cajas_s1.RawPrinterHelper.EndDocPrinter(hPrinter);
          }
          cajas_s1.RawPrinterHelper.ClosePrinter(hPrinter);
        }
        if (!flag)
          num = Marshal.GetLastWin32Error();
        return flag;
      }

      public static bool SendFileToPrinter(string szPrinterName, string szFileName)
      {
        FileStream fileStream = new FileStream(szFileName, FileMode.Open);
        BinaryReader binaryReader = new BinaryReader((Stream) fileStream);
        byte[] numArray = new byte[checked ((int) (fileStream.Length - 1L) + 1)];
        IntPtr num1 = new IntPtr(0);
        int int32 = Convert.ToInt32(fileStream.Length);
        byte[] source = binaryReader.ReadBytes(int32);
        IntPtr num2 = Marshal.AllocCoTaskMem(int32);
        Marshal.Copy(source, 0, num2, int32);
        bool printer = cajas_s1.RawPrinterHelper.SendBytesToPrinter(szPrinterName, num2, int32);
        Marshal.FreeCoTaskMem(num2);
        return printer;
      }

      public static bool SendStringToPrinter(string szPrinterName, string szString)
      {
        int length = szString.Length;
        IntPtr coTaskMemAnsi = Marshal.StringToCoTaskMemAnsi(szString);
        cajas_s1.RawPrinterHelper.SendBytesToPrinter(szPrinterName, coTaskMemAnsi, length);
        Marshal.FreeCoTaskMem(coTaskMemAnsi);
        return true;
      }

      [StructLayout(LayoutKind.Sequential)]
      public class DOCINFOA
      {
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDocName;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pOutputFile;
        [MarshalAs(UnmanagedType.LPStr)]
        public string pDataType;
      }

      [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
      public struct DOCINFOW
      {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDocName;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pOutputFile;
        [MarshalAs(UnmanagedType.LPWStr)]
        public string pDataType;
      }
    }
  }
}
