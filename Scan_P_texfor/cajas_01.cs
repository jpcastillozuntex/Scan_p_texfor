// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.cajas_01
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Net.Sockets;
using System.Runtime.CompilerServices;

namespace Scan_P_texfor
{
  [StandardModule]
  internal sealed class cajas_01
  {
    private static empresas obj = new empresas();
    private static SqlConnection cnn = new SqlConnection();

    public static bool imprime_cajas(ref string inicial, string final)
    {
      bool flag1 = true;
      string hostname = "192.9.200.28";
      int port = 9100;
      DataTable dt1 = new DataTable();
      DataTable dt2 = new DataTable();
      string str1 = "";
      string str2 = "";
      TcpClient tcpClient = new TcpClient();
      tcpClient.Connect(hostname, port);
      StreamWriter streamWriter = new StreamWriter((Stream) tcpClient.GetStream());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cajas_01.obj.numero, "1", false) == 0)
        str1 = "^FO0,0^GFA,1221,1221,11,,::M07F,L01FF8,L03FFE,L07FFE,L07IF,L0JF,L0JF8,:::L0JF,L07IF,L07FFE,L03FFE,L01FF8,M07F,,::K01SFC,::::::::::::::::Q01JF8,:Q01JF8CFC,:Q01JF8IC,K01JF81JF8C0C,:K01JF81JF8E1C,K01JF81JF87F8,K01JF81JF83F,K01JF81JF8,:K01JF81JF8FFC,K01JF007IF8FFC,K01IF8001IF803C,K01IFJ0IF80F,K01FFCJ03FF83C,K01FF803801FF87,K01FF80FE01FF8FFC,K01FF01CF00FF8FFC,K01FE01C7007F8,K01FE0387007F8,K01FE01C7007F8FFC,K01FC01CE003F8FFC,K01FC01FC003F8528,K01FC00F8303F8,K01FC03F8703F81E,K01FC07BC703F87F,K01FC071C703F87F8,K01FC0F0EE03F8E1C,K01FC0F0FE03F8C0C,K01FE0F07C07F8C0C,K01FE0787C07F8C0C,K01FF07FFE0FF8FFC,K01FF03FEF0FF8FFC,K01FF807001FF8,K01FFCJ03FF8,K01FFEJ07FF800C,K01IFJ0IF807C,K01IFC003IF83F8,K01JF81JF8FA,K01JF81JF8C2,K01JF81JF8FE,K03JF81JF83FC,K03JF81JF803C,K07JF81JF8004,K0KF01JF8,J03KF01JF8,I03LF01JF871C,007MF01JF8FFC,007LFE01JF8CF,007LFE01JF8CC,:007LFC01JF8FFC,:007LF801JF8,007LF001JF8,007LF001JF8C,007KFE001JF8C,007KFC001JF8C,007KF8001JF8FFC,007JFEI01JF8FFC,007JFCI01JF8C,007JFJ01JF8C,007IF8J01JF84,007FF8K01JF8,,:::::^FS";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cajas_01.obj.numero, "3", false) == 0)
        str1 = "^FO10,10^GFA,2400,2400,24,,:::::R07FFC,Q01JF,P03KF,I0FFEJ07KF,007IFE001IFE,00KFC03FFE,03PFE,03QF,K07NF,K01NFC,K01OF,K03OF,J01LFE03F8,J0MFE001C,I03NF8,I07NFC,001LF3IF,003LF1IF,00FFDJF8IFC,00FF8JF8F3FE0FFC,03FE1JF8F8FF0IFC,03FC1JF8787F0IFEI03F,07FC3FCFF83C1F800FFC1JF,0F887FCFF83C0FC00FFE3JF,0F007F8FF00E0FC03LF7F,1E00FF0FF00F03E0LFC,1C00FF0FF00F01E1LF8,1001FE0FF00F00F3LFC,I03FC0FF007807003KFC,I03F00FE003CJ03KFE,I03E00FE003CJ07LF8,I03C00FE003EJ0MFC,I07C00FE001FI03FFDIF7F,I0F800FEI0FI03F71IF3F,I0F800FEI0FI07CF1IF1FC,I0F8007CI0FI0F8F1FDF0FC,I0FI07CI07800F0E1F8FC1E,I0EI07CI03C01E0C1F8FC0E,I0CI07EI03C01C3C1F87C,001CI07EI03C0083C0F83E,0018I03EI03EI0700F81E,001J03EI01FI0700FC0F,M03EI01FI0F00FC0F,M03EJ0FI0F00F807,M03CJ0F001E0078038,M01EJ0F003C007803C,M01EJ0F803C007003C,N0EJ0F803C00F001C,S07C03800F,S07C07800F,S07C0FI0F,:S07C0FI0E,S03E0E,S03E1E,S03E3C,::::S03F7C,S03FFC,S03FF8L0IFCN01IF,S03FF8K01IFCN03IF,S03FF8K03IF8N07FFE,S03FFL03IFO03FFC,S03FFL0107CP07F,S07FFN07C008M03EI0C,S07FFN0F003CI0CI07C007E3C0F,S07FFM01F007C001CI0FC00FF3C0F,S07FFM07C00FC303C301F803FF3F3E,S07FFM0FC01F8387C781F007FE1FFC,S07FFL01F003F0F0FCF83F00F3C1FF,S0IFL03F003F1F0IF07F00F3C0FF,S0IFL0FC007C3F3IF0FE03E380FC,S0IFK01FC00FC7E3IF0FC03C700FC,S0IFK03F030IFC3IF0FC07CE01FC,S0IFK07F070IFC7FFE1F80FCE03FC,S0IFJ01JF1IFCFC7C3F00FFE1FFE,S0IFJ03IFE3FCFCFC7C3F00FFE3IF,Q030IFJ03IFC3F0FCF87C7E00FFC7IF,Q030IFJ03IF83F0F8F07CFC00FF87C7F,Q021IFK0FF0030070C0307I0780703C,Q023IFR02U08,Q027IFE8,Q07KFC,Q0LFE,Q0MF,P01MF8,P01FDE3DFF,,:::^FS";
      Module1.llena_tablas(ref dt2, "SELECT DISTINCT CAJA FROM CAJAS01 WHERE CAJA BETWEEN '" + inicial + "' AND '" + final + "' ORDER BY CAJA", ref cajas_01.cnn);
      Module1.llena_tablas(ref dt1, "SELECT * FROM CAJAS01 LEFT JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE WHERE CAJA BETWEEN '" + inicial + "' AND '" + final + "' ORDER BY CAJA", ref cajas_01.cnn);
      string str3 = "^XA" + str1 + "^FO20,120^A0,30,20^FDCORTE^FS^FO100,120^A0,30,20^FDCPO^FS^FO250,120^A0,30,20^FDESTILO^FS^FO420,120^A0,30,20^FDCOLOR^FS^FO610,120^A0,30,20^FDTALLA^FS^FO690,120^A0,30,20^FDUNIDAD.^FS^FO770,120^A0,30,20^FDT^FS^FO15,110^GB790,40,3^FS";
      try
      {
        foreach (DataRow row in dt2.Rows)
        {
          string str4 = Conversions.ToString(row["CAJA"]);
          string str5 = str3;
          DataRow[] dataRowArray1 = dt1.Select("CAJA = '" + str4 + "'");
          int num = 160;
          string str6 = "";
          bool flag2 = true;
          DataRow[] dataRowArray2 = dataRowArray1;
          int index = 0;
          while (index < dataRowArray2.Length)
          {
            DataRow dataRow = dataRowArray2[index];
            str2 = Conversions.ToString(dataRow["CLIENTE"]);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(dataRow["UNIDADES"], (object) 0, false))
            {
              string str7 = cajas_01.recorta(Conversions.ToString(dataRow["CPO"]), 20);
              string str8 = cajas_01.recorta(Conversions.ToString(dataRow["ESTILO"]), 16);
              string str9 = cajas_01.recorta(Conversions.ToString(dataRow["COLOR"]), 15);
              if (flag2)
              {
                str6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (str6 + "^FO20," + Conversions.ToString(num) + "^A0,50,50^FD"), dataRow["CORTE"]), (object) "^FS"));
                checked { num += 50; }
                flag2 = false;
              }
              str6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (str6 + "^FO100," + Conversions.ToString(num) + "^A0,30,20^FD" + str7 + "^FS" + "^FO250," + Conversions.ToString(num) + "^A0,30,20^FD" + str8 + "^FS" + "^FO420," + Conversions.ToString(num) + "^A0,30,20^FD" + str9 + "^FS" + "^FO620," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["TALLA"]), (object) "^FS")) + "^FO700," + Conversions.ToString(num) + "^A0,30,20^FD" + Strings.Format(RuntimeHelpers.GetObjectValue(dataRow["UNIDADES"]), "######") + "^FS" + "^FO770," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["TIPO"]), (object) "^FS"));
              checked { num += 30; }
            }
            checked { ++index; }
          }
          string str10 = str5 + str6 + "^FO650,85^A0,30,20^FD" + str2 + "^FS^FX^BY5,2,120^FO75,410^BC^FD" + str4 + "^FS^XZ";
          streamWriter.Write(str10);
          streamWriter.Flush();
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      streamWriter.Close();
      tcpClient.Close();
      return flag1;
    }

    public static bool imprime_cajas_l(ref string inicial)
    {
      bool flag1 = true;
      string hostname = "192.9.200.28";
      int port = 9100;
      DataTable dt1 = new DataTable();
      DataTable dt2 = new DataTable();
      string str1 = "";
      string str2 = "";
      TcpClient tcpClient = new TcpClient();
      tcpClient.Connect(hostname, port);
      StreamWriter streamWriter = new StreamWriter((Stream) tcpClient.GetStream());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cajas_01.obj.numero, "1", false) == 0)
        str1 = "^FO0,0^GFA,1221,1221,11,,::M07F,L01FF8,L03FFE,L07FFE,L07IF,L0JF,L0JF8,:::L0JF,L07IF,L07FFE,L03FFE,L01FF8,M07F,,::K01SFC,::::::::::::::::Q01JF8,:Q01JF8CFC,:Q01JF8IC,K01JF81JF8C0C,:K01JF81JF8E1C,K01JF81JF87F8,K01JF81JF83F,K01JF81JF8,:K01JF81JF8FFC,K01JF007IF8FFC,K01IF8001IF803C,K01IFJ0IF80F,K01FFCJ03FF83C,K01FF803801FF87,K01FF80FE01FF8FFC,K01FF01CF00FF8FFC,K01FE01C7007F8,K01FE0387007F8,K01FE01C7007F8FFC,K01FC01CE003F8FFC,K01FC01FC003F8528,K01FC00F8303F8,K01FC03F8703F81E,K01FC07BC703F87F,K01FC071C703F87F8,K01FC0F0EE03F8E1C,K01FC0F0FE03F8C0C,K01FE0F07C07F8C0C,K01FE0787C07F8C0C,K01FF07FFE0FF8FFC,K01FF03FEF0FF8FFC,K01FF807001FF8,K01FFCJ03FF8,K01FFEJ07FF800C,K01IFJ0IF807C,K01IFC003IF83F8,K01JF81JF8FA,K01JF81JF8C2,K01JF81JF8FE,K03JF81JF83FC,K03JF81JF803C,K07JF81JF8004,K0KF01JF8,J03KF01JF8,I03LF01JF871C,007MF01JF8FFC,007LFE01JF8CF,007LFE01JF8CC,:007LFC01JF8FFC,:007LF801JF8,007LF001JF8,007LF001JF8C,007KFE001JF8C,007KFC001JF8C,007KF8001JF8FFC,007JFEI01JF8FFC,007JFCI01JF8C,007JFJ01JF8C,007IF8J01JF84,007FF8K01JF8,,:::::^FS";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cajas_01.obj.numero, "3", false) == 0)
        str1 = "^FO10,10^GFA,2400,2400,24,,:::::R07FFC,Q01JF,P03KF,I0FFEJ07KF,007IFE001IFE,00KFC03FFE,03PFE,03QF,K07NF,K01NFC,K01OF,K03OF,J01LFE03F8,J0MFE001C,I03NF8,I07NFC,001LF3IF,003LF1IF,00FFDJF8IFC,00FF8JF8F3FE0FFC,03FE1JF8F8FF0IFC,03FC1JF8787F0IFEI03F,07FC3FCFF83C1F800FFC1JF,0F887FCFF83C0FC00FFE3JF,0F007F8FF00E0FC03LF7F,1E00FF0FF00F03E0LFC,1C00FF0FF00F01E1LF8,1001FE0FF00F00F3LFC,I03FC0FF007807003KFC,I03F00FE003CJ03KFE,I03E00FE003CJ07LF8,I03C00FE003EJ0MFC,I07C00FE001FI03FFDIF7F,I0F800FEI0FI03F71IF3F,I0F800FEI0FI07CF1IF1FC,I0F8007CI0FI0F8F1FDF0FC,I0FI07CI07800F0E1F8FC1E,I0EI07CI03C01E0C1F8FC0E,I0CI07EI03C01C3C1F87C,001CI07EI03C0083C0F83E,0018I03EI03EI0700F81E,001J03EI01FI0700FC0F,M03EI01FI0F00FC0F,M03EJ0FI0F00F807,M03CJ0F001E0078038,M01EJ0F003C007803C,M01EJ0F803C007003C,N0EJ0F803C00F001C,S07C03800F,S07C07800F,S07C0FI0F,:S07C0FI0E,S03E0E,S03E1E,S03E3C,::::S03F7C,S03FFC,S03FF8L0IFCN01IF,S03FF8K01IFCN03IF,S03FF8K03IF8N07FFE,S03FFL03IFO03FFC,S03FFL0107CP07F,S07FFN07C008M03EI0C,S07FFN0F003CI0CI07C007E3C0F,S07FFM01F007C001CI0FC00FF3C0F,S07FFM07C00FC303C301F803FF3F3E,S07FFM0FC01F8387C781F007FE1FFC,S07FFL01F003F0F0FCF83F00F3C1FF,S0IFL03F003F1F0IF07F00F3C0FF,S0IFL0FC007C3F3IF0FE03E380FC,S0IFK01FC00FC7E3IF0FC03C700FC,S0IFK03F030IFC3IF0FC07CE01FC,S0IFK07F070IFC7FFE1F80FCE03FC,S0IFJ01JF1IFCFC7C3F00FFE1FFE,S0IFJ03IFE3FCFCFC7C3F00FFE3IF,Q030IFJ03IFC3F0FCF87C7E00FFC7IF,Q030IFJ03IF83F0F8F07CFC00FF87C7F,Q021IFK0FF0030070C0307I0780703C,Q023IFR02U08,Q027IFE8,Q07KFC,Q0LFE,Q0MF,P01MF8,P01FDE3DFF,,:::^FS";
      Module1.llena_tablas(ref dt2, "SELECT DISTINCT CAJA FROM CAJAG01 WHERE CAJA = '" + inicial + "' ORDER BY CAJA", ref cajas_01.cnn);
      Module1.llena_tablas(ref dt1, "SELECT * FROM CAJAG01 LEFT JOIN CORTES ON CAJAG01.CORTE = CORTES.CORTE WHERE CAJA = '" + inicial + "' ORDER BY CAJA", ref cajas_01.cnn);
      string str3 = "^XA" + str1 + "^FO20,120^A0,30,20^FDCORTE^FS^FO100,120^A0,30,20^FDCPO^FS^FO250,120^A0,30,20^FDESTILO^FS^FO420,120^A0,30,20^FDCOLOR^FS^FO610,120^A0,30,20^FDTALLA^FS^FO690,120^A0,30,20^FDUNIDAD.^FS^FO770,120^A0,30,20^FDT^FS^FO15,110^GB790,40,3^FS";
      try
      {
        foreach (DataRow row in dt2.Rows)
        {
          string str4 = Conversions.ToString(row["CAJA"]);
          string str5 = str3;
          DataRow[] dataRowArray1 = dt1.Select("CAJA = '" + str4 + "'");
          int num = 160;
          string str6 = "";
          bool flag2 = true;
          DataRow[] dataRowArray2 = dataRowArray1;
          int index = 0;
          while (index < dataRowArray2.Length)
          {
            DataRow dataRow = dataRowArray2[index];
            str2 = Conversions.ToString(dataRow["CLIENTE"]);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(dataRow["UNIDADES"], (object) 0, false))
            {
              string str7 = cajas_01.recorta(Conversions.ToString(dataRow["CPO"]), 20);
              string str8 = cajas_01.recorta(Conversions.ToString(dataRow["ESTILO"]), 16);
              string str9 = cajas_01.recorta(Conversions.ToString(dataRow["COLOR"]), 15);
              if (flag2)
              {
                str6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (str6 + "^FO20," + Conversions.ToString(num) + "^A0,50,50^FD"), dataRow["CORTE"]), (object) "^FS"));
                checked { num += 50; }
                flag2 = false;
              }
              str6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (str6 + "^FO100," + Conversions.ToString(num) + "^A0,30,20^FD" + str7 + "^FS" + "^FO250," + Conversions.ToString(num) + "^A0,30,20^FD" + str8 + "^FS" + "^FO420," + Conversions.ToString(num) + "^A0,30,20^FD" + str9 + "^FS" + "^FO620," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["TALLA"]), (object) "^FS")) + "^FO700," + Conversions.ToString(num) + "^A0,30,20^FD" + Strings.Format(RuntimeHelpers.GetObjectValue(dataRow["UNIDADES"]), "######") + "^FS" + "^FO770," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["TIPO"]), (object) "^FS"));
              checked { num += 30; }
            }
            checked { ++index; }
          }
          string str10 = str5 + str6 + "^FO650,85^A0,30,20^FD" + str2 + "^FS^FX^BY5,2,120^FO75,410^BC^FD" + str4 + "^FS^XZ";
          streamWriter.Write(str10);
          streamWriter.Flush();
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      streamWriter.Close();
      tcpClient.Close();
      return flag1;
    }

    public static bool imprime_cajas_t(ref string inicial, string final)
    {
      bool flag = true;
      string hostname = "192.9.200.28";
      int port = 9100;
      DataTable dt1 = new DataTable();
      DataTable dt2 = new DataTable();
      string str1 = "";
      string str2 = "";
      TcpClient tcpClient = new TcpClient();
      tcpClient.Connect(hostname, port);
      StreamWriter streamWriter = new StreamWriter((Stream) tcpClient.GetStream());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cajas_01.obj.numero, "1", false) == 0)
        str1 = "^FO0,0^GFA,1221,1221,11,,::M07F,L01FF8,L03FFE,L07FFE,L07IF,L0JF,L0JF8,:::L0JF,L07IF,L07FFE,L03FFE,L01FF8,M07F,,::K01SFC,::::::::::::::::Q01JF8,:Q01JF8CFC,:Q01JF8IC,K01JF81JF8C0C,:K01JF81JF8E1C,K01JF81JF87F8,K01JF81JF83F,K01JF81JF8,:K01JF81JF8FFC,K01JF007IF8FFC,K01IF8001IF803C,K01IFJ0IF80F,K01FFCJ03FF83C,K01FF803801FF87,K01FF80FE01FF8FFC,K01FF01CF00FF8FFC,K01FE01C7007F8,K01FE0387007F8,K01FE01C7007F8FFC,K01FC01CE003F8FFC,K01FC01FC003F8528,K01FC00F8303F8,K01FC03F8703F81E,K01FC07BC703F87F,K01FC071C703F87F8,K01FC0F0EE03F8E1C,K01FC0F0FE03F8C0C,K01FE0F07C07F8C0C,K01FE0787C07F8C0C,K01FF07FFE0FF8FFC,K01FF03FEF0FF8FFC,K01FF807001FF8,K01FFCJ03FF8,K01FFEJ07FF800C,K01IFJ0IF807C,K01IFC003IF83F8,K01JF81JF8FA,K01JF81JF8C2,K01JF81JF8FE,K03JF81JF83FC,K03JF81JF803C,K07JF81JF8004,K0KF01JF8,J03KF01JF8,I03LF01JF871C,007MF01JF8FFC,007LFE01JF8CF,007LFE01JF8CC,:007LFC01JF8FFC,:007LF801JF8,007LF001JF8,007LF001JF8C,007KFE001JF8C,007KFC001JF8C,007KF8001JF8FFC,007JFEI01JF8FFC,007JFCI01JF8C,007JFJ01JF8C,007IF8J01JF84,007FF8K01JF8,,:::::^FS";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(cajas_01.obj.numero, "3", false) == 0)
        str1 = "^FO10,10^GFA,2400,2400,24,,:::::R07FFC,Q01JF,P03KF,I0FFEJ07KF,007IFE001IFE,00KFC03FFE,03PFE,03QF,K07NF,K01NFC,K01OF,K03OF,J01LFE03F8,J0MFE001C,I03NF8,I07NFC,001LF3IF,003LF1IF,00FFDJF8IFC,00FF8JF8F3FE0FFC,03FE1JF8F8FF0IFC,03FC1JF8787F0IFEI03F,07FC3FCFF83C1F800FFC1JF,0F887FCFF83C0FC00FFE3JF,0F007F8FF00E0FC03LF7F,1E00FF0FF00F03E0LFC,1C00FF0FF00F01E1LF8,1001FE0FF00F00F3LFC,I03FC0FF007807003KFC,I03F00FE003CJ03KFE,I03E00FE003CJ07LF8,I03C00FE003EJ0MFC,I07C00FE001FI03FFDIF7F,I0F800FEI0FI03F71IF3F,I0F800FEI0FI07CF1IF1FC,I0F8007CI0FI0F8F1FDF0FC,I0FI07CI07800F0E1F8FC1E,I0EI07CI03C01E0C1F8FC0E,I0CI07EI03C01C3C1F87C,001CI07EI03C0083C0F83E,0018I03EI03EI0700F81E,001J03EI01FI0700FC0F,M03EI01FI0F00FC0F,M03EJ0FI0F00F807,M03CJ0F001E0078038,M01EJ0F003C007803C,M01EJ0F803C007003C,N0EJ0F803C00F001C,S07C03800F,S07C07800F,S07C0FI0F,:S07C0FI0E,S03E0E,S03E1E,S03E3C,::::S03F7C,S03FFC,S03FF8L0IFCN01IF,S03FF8K01IFCN03IF,S03FF8K03IF8N07FFE,S03FFL03IFO03FFC,S03FFL0107CP07F,S07FFN07C008M03EI0C,S07FFN0F003CI0CI07C007E3C0F,S07FFM01F007C001CI0FC00FF3C0F,S07FFM07C00FC303C301F803FF3F3E,S07FFM0FC01F8387C781F007FE1FFC,S07FFL01F003F0F0FCF83F00F3C1FF,S0IFL03F003F1F0IF07F00F3C0FF,S0IFL0FC007C3F3IF0FE03E380FC,S0IFK01FC00FC7E3IF0FC03C700FC,S0IFK03F030IFC3IF0FC07CE01FC,S0IFK07F070IFC7FFE1F80FCE03FC,S0IFJ01JF1IFCFC7C3F00FFE1FFE,S0IFJ03IFE3FCFCFC7C3F00FFE3IF,Q030IFJ03IFC3F0FCF87C7E00FFC7IF,Q030IFJ03IF83F0F8F07CFC00FF87C7F,Q021IFK0FF0030070C0307I0780703C,Q023IFR02U08,Q027IFE8,Q07KFC,Q0LFE,Q0MF,P01MF8,P01FDE3DFF,,:::^FS";
      Module1.llena_tablas(ref dt2, "SELECT DISTINCT CAJA FROM PROD_TER01 WHERE CAJA BETWEEN '" + inicial + "' AND '" + final + "' AND UNIDADES > 0 ORDER BY CAJA", ref cajas_01.cnn);
      Module1.llena_tablas(ref dt1, "SELECT * FROM PROD_TER01 LEFT JOIN CORTES ON PROD_TER01.CORTE = CORTES.CORTE WHERE CAJA BETWEEN '" + inicial + "' AND '" + final + "' AND UNIDADES > 0 ORDER BY CAJA", ref cajas_01.cnn);
      string str3 = "^XA" + str1 + "^FO20,120^A0,30,20^FDCORTE^FS^FO100,120^A0,30,20^FDCPO^FS^FO250,120^A0,30,20^FDESTILO^FS^FO420,120^A0,30,20^FDCOLOR^FS^FO610,120^A0,30,20^FDTALLA^FS^FO690,120^A0,30,20^FDUNIDAD.^FS^FO770,120^A0,30,20^FDT^FS^FO15,110^GB790,40,3^FS";
      try
      {
        foreach (DataRow row in dt2.Rows)
        {
          string str4 = Conversions.ToString(row["CAJA"]);
          string str5 = str3;
          DataRow[] dataRowArray1 = dt1.Select("CAJA = '" + str4 + "'");
          int num = 160;
          string str6 = "";
          DataRow[] dataRowArray2 = dataRowArray1;
          int index = 0;
          while (index < dataRowArray2.Length)
          {
            DataRow dataRow = dataRowArray2[index];
            str2 = Conversions.ToString(dataRow["CLIENTE"]);
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(dataRow["UNIDADES"], (object) 0, false))
            {
              string str7 = cajas_01.recorta(Conversions.ToString(dataRow["CPO"]), 20);
              string str8 = cajas_01.recorta(Conversions.ToString(dataRow["ESTILO"]), 15);
              string str9 = cajas_01.recorta(Conversions.ToString(dataRow["COLOR"]), 15);
              str6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) (str6 + "^FO20," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["CORTE"]), (object) "^FS")) + "^FO100," + Conversions.ToString(num) + "^A0,30,20^FD" + str7 + "^FS" + "^FO250," + Conversions.ToString(num) + "^A0,30,20^FD" + str8 + "^FS" + "^FO420," + Conversions.ToString(num) + "^A0,30,20^FD" + str9 + "^FS" + "^FO620," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["TALLA"]), (object) "^FS")) + "^FO700," + Conversions.ToString(num) + "^A0,30,20^FD" + Strings.Format(RuntimeHelpers.GetObjectValue(dataRow["UNIDADES"]), "######") + "^FS" + "^FO770," + Conversions.ToString(num) + "^A0,30,20^FD"), dataRow["TIPO"]), (object) "^FS"));
              checked { num += 30; }
            }
            checked { ++index; }
          }
          string str10 = str5 + str6 + "^FO650,85^A0,30,20^FD" + str2 + "^FS^FX^BY5,2,120^FO75,410^BC^FD" + str4 + "^FS^XZ";
          streamWriter.Write(str10);
          streamWriter.Flush();
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      streamWriter.Close();
      tcpClient.Close();
      return flag;
    }

    private static string recorta(string texto, int t)
    {
      return Strings.Mid(texto, 1, t);
    }

    public static bool modifica_caja(
      ref DataTable co,
      string caja,
      string tipo,
      string talla,
      int uni,
      ref int orden,
      ref int unidad)
    {
      bool flag = false;
      DataRow[] dataRowArray = co.Select("CAJA = '" + caja + "' AND TIPO = '" + tipo + "' AND TALLA = '" + talla + "'");
      if (dataRowArray.Length > 0)
      {
        DataRow dataRow = dataRowArray[0];
        dataRow["UNIDADES"] = Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject(dataRow["UNIDADES"], (object) uni);
        unidad = Conversions.ToInteger(dataRow["UNIDADES"]);
        orden = Conversions.ToInteger(dataRow["ORDEN"]);
      }
      return flag;
    }

    public static int saldo_caja(
      ref DataTable co,
      string caja,
      string tipo,
      string talla,
      ref string orden,
      ref string fecha)
    {
      int num = 0;
      DataRow[] dataRowArray = co.Select("CAJA ='" + caja + "' AND TIPO = '" + tipo + "' AND TALLA = '" + talla + "'");
      if (dataRowArray.Length > 0)
      {
        DataRow dataRow = dataRowArray[0];
        num = Conversions.ToInteger(dataRow["UNIDADES"]);
        orden = Conversions.ToString(dataRow["ORDEN"]);
        fecha = Strings.Format(RuntimeHelpers.GetObjectValue(dataRow["FECHAD"]), "yyyy-MM-dd HH:mm:ss");
      }
      return num;
    }
  }
}
