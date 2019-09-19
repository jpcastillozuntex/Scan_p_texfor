// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.empresas
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

namespace Scan_P_texfor
{
  public class empresas
  {
    private static string empresan;
    private static string nomempre;
    private static string conecstr;
    private static string strconec;
    private static string strconol;
    private static string usuario_sistema;
    private static string clave_sistema;
    private static string seccion_c;

    public string numero
    {
      get
      {
        return empresas.empresan;
      }
      set
      {
        empresas.empresan = value;
      }
    }

    public string nombre
    {
      get
      {
        return empresas.nomempre;
      }
      set
      {
        empresas.nomempre = value;
      }
    }

    public string conexion
    {
      get
      {
        return empresas.conecstr;
      }
      set
      {
        empresas.conecstr = value;
      }
    }

    public string constr
    {
      get
      {
        return empresas.strconec;
      }
      set
      {
        empresas.strconec = value;
      }
    }

    public string conole
    {
      get
      {
        return empresas.strconol;
      }
      set
      {
        empresas.strconol = value;
      }
    }

    public string usuario
    {
      get
      {
        return empresas.usuario_sistema;
      }
      set
      {
        empresas.usuario_sistema = value;
      }
    }

    public string clave
    {
      get
      {
        return empresas.clave_sistema;
      }
      set
      {
        empresas.clave_sistema = value;
      }
    }

    public string seccion
    {
      get
      {
        return empresas.seccion_c;
      }
      set
      {
        empresas.seccion_c = value;
      }
    }
  }
}
