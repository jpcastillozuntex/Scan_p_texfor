// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Module1
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
using Lib_SIF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  [StandardModule]
  internal sealed class Module1
  {
    public static Hashtable _styles;

    public static void setea_empresa(int empresa)
    {
      empresas empresas = new empresas();
      util util = (util) null;
      switch (empresa)
      {
        case 1:
          empresas.conexion = "inventarios";
          break;
        case 2:
          empresas.conexion = "TRECENTO";
          break;
        default:
          empresas.conexion = "zuntex";
          break;
      }
      empresas.constr = util.con_string(checked (empresa - 1));
      empresas.conole = util.con_ole(checked (empresa - 1));
    }

    public static void def_sql(ref SqlConnection cnn)
    {
      empresas empresas = new empresas();
      cnn = new SqlConnection();
      cnn.ConnectionString = empresas.constr;
    }

    public static void Estado_Tela(object con, ComboBox C4)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT * FROM ESTADOS_TELA";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          C4.Items.Add(RuntimeHelpers.GetObjectValue(row["ESTADO_TELA"]));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      C4.Items.Add((object) "TODOS");
    }

    public static void a_excel(C1.Win.C1FlexGrid.C1FlexGrid fg, string path, ref bool ok)
    {
      try
      {
        if (System.IO.File.Exists(path))
          System.IO.File.Delete(path);
        fg.SaveGrid(path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells | FileFlags.VisibleOnly);
        Process.Start(path);
        ok = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, (object) "Atencion ");
        ok = false;
        ProjectData.ClearProjectError();
      }
      if (!ok)
        return;
      int num1 = (int) Interaction.MsgBox((object) ("Sus datos fueron trasladados a Excel en el directorio: " + path), MsgBoxStyle.OkOnly, (object) "TRASLADO DE DATOS ");
    }

    public static void con_string(int e, ref string constr)
    {
      util util = (util) null;
      constr = util.con_string(e);
    }

    public static void llena_clientes(ref ComboBox C4)
    {
      SqlConnection cnn = new SqlConnection();
      DataTable dt = new DataTable();
      string strSql = "SELECT CLIENTE FROM CLIENTES ORDER BY CLIENTE";
      C4.Items.Add((object) "TODOS");
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          C4.Items.Add((object) Strings.Trim(Conversions.ToString(row["CLIENTE"])));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    public static string get_codigo_color(string cliente, string color)
    {
      SqlConnection cnn = new SqlConnection();
      DataTable dt = new DataTable();
      string str = "";
      Module1.llena_tablas(ref dt, "SELECT * FROM COLORES WHERE CLIENTE = '" + cliente + "' AND COLOR = '" + color + "'", ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          try
          {
            str = Conversions.ToString(row["CODIGO_C"]);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return str;
    }

    public static void tallas_cortes(
      string cpo,
      string estilo,
      string colo,
      ref C1.Win.C1FlexGrid.C1FlexGrid fg,
      int fil,
      int col)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      try
      {
        Module1.llena_tablas(ref dt, "SELECT * FROM CPO_D WHERE CPO = '" + cpo + "' AND ESTILO = '" + estilo + "' AND COLOR = '" + colo + "'", ref cnn);
        if (dt.Rows.Count <= 0)
          return;
        string str = Conversions.ToString(dt.Rows[0]["ESCALA"]);
        Module1.llena_tablas(ref dt, "SELECT * FROM E_TALLAS WHERE ESCALA = '" + str + "'", ref cnn);
        if (dt.Rows.Count > 0)
        {
          DataRow row = dt.Rows[0];
          int num = 1;
          do
          {
            fg[fil, col] = RuntimeHelpers.GetObjectValue(row[checked (num + 1)]);
            checked { ++col; }
            checked { ++num; }
          }
          while (num <= 10);
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void get_escalas(ref string ge)
    {
      SqlConnection cnn = new SqlConnection();
      DataTable dt = new DataTable();
      Module1.llena_tablas(ref dt, "SELECT * FROM E_TALLAS ", ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          ge = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) ge, row["NOMBRE"]), (object) "|"));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    public static string lector_dc()
    {
      return "Data Source=JT;Initial Catalog=lector;Persist Security Info=True;User ID=user_l;Password=Lector_01";
    }

    public static DataRow get_tallas(string escala)
    {
      SqlConnection cnn = new SqlConnection();
      DataTable dt = new DataTable();
      DataRow dataRow = (DataRow) null;
      Module1.llena_tablas(ref dt, "SELECT * FROM E_TALLAS WHERE ESCALA = '" + Strings.Format((object) Conversions.ToInteger(escala), "00") + "'", ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          dataRow = row;
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return dataRow;
    }

    public static void talla_Grid(ref C1.Win.C1FlexGrid.C1FlexGrid fg, int col, bool adulto)
    {
      string[] strArray = Strings.Split("XS|S|M|L|XL|2XL|3XL|4XL|5XL|6XL", "|", -1, CompareMethod.Binary);
      int num1 = col;
      int num2 = checked (col + 9);
      int index = num1;
      while (index <= num2)
      {
        string str = !adulto ? "T" + Strings.Format((object) checked (index - col + 1), "00") : strArray[checked (index - col)];
        fg[0, index] = (object) str;
        fg.Cols[index].TextAlign = TextAlignEnum.CenterCenter;
        fg.Cols[index].TextAlignFixed = TextAlignEnum.CenterCenter;
        checked { ++index; }
      }
    }

    public static void talla_setea(C1.Win.C1FlexGrid.C1FlexGrid ta, int escala)
    {
      DataRow tallas = Module1.get_tallas(Strings.Format((object) escala, "00"));
      int index = 1;
      do
      {
        string str = Conversions.ToString(tallas[checked (index + 1)]);
        ta[0, index] = (object) str;
        ta[1, index] = (object) 0;
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(str), "", false) == 0)
          ta.Cols[index].AllowEditing = false;
        else
          ta.Cols[index].AllowEditing = true;
        checked { ++index; }
      }
      while (index <= 10);
      ta[0, 11] = (object) "TOTALES";
      ta[1, 11] = (object) 0;
      ta.SetCellStyle(1, 11, ta.Styles["amarillo"]);
      ta.Enabled = false;
    }

    public static void llena_tipos_stock(ref ComboBox C4, ref C1.Win.C1FlexGrid.C1FlexGrid tips)
    {
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = new C1.Win.C1FlexGrid.C1FlexGrid();
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT * FROM TIPO_STOCK ORDER BY TIPO";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      c1FlexGrid.Clear();
      c1FlexGrid.Rows.Count = 0;
      c1FlexGrid.Cols.Count = 2;
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          checked { ++c1FlexGrid.Rows.Count; }
          int index = checked (c1FlexGrid.Rows.Count - 1);
          C4.Items.Add(RuntimeHelpers.GetObjectValue(row["DESCRIPCION"]));
          c1FlexGrid[index, 0] = RuntimeHelpers.GetObjectValue(row["TIPO"]);
          c1FlexGrid[index, 1] = RuntimeHelpers.GetObjectValue(row["DESCRIPCION"]);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      tips = c1FlexGrid;
    }

    public static void llena_salas(ComboBox sala, SqlConnection cnn, string todas)
    {
      DataTable dt = new DataTable();
      sala.Items.Clear();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(todas, "S", false) == 0)
        sala.Items.Add((object) "TODAS");
      string strSql = "SELECT * FROM SALAS";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          sala.Items.Add(RuntimeHelpers.GetObjectValue(row["SALA"]));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (sala.Items.Count <= 0)
        return;
      sala.SelectedIndex = 0;
    }

    public static void flex_a_dt(ref C1.Win.C1FlexGrid.C1FlexGrid fg, ref DataTable dt)
    {
      dt = new DataTable();
      int num1 = checked (fg.Cols.Count - 1);
      int index1 = 1;
      while (index1 <= num1)
      {
        string columnName = Conversions.ToString(fg[0, index1]);
        dt.Columns.Add(columnName);
        new DataColumn(columnName).DataType = fg.Cols[index1].GetType();
        checked { ++index1; }
      }
      int num2 = checked (fg.Rows.Count - 1);
      int index2 = 1;
      while (index2 <= num2)
      {
        DataRow row = dt.NewRow();
        int num3 = checked (fg.Cols.Count - 1);
        int index3 = 1;
        while (index3 <= num3)
        {
          row[checked (index3 - 1)] = RuntimeHelpers.GetObjectValue(fg[index2, index3]);
          checked { ++index3; }
        }
        dt.Rows.Add(row);
        checked { ++index2; }
      }
    }

    public static void llena_combos_e(ComboBox combo, string e, string strsql, string campo)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string constr = "";
      Module1.con_string(Conversions.ToInteger(e), ref constr);
      cnn.ConnectionString = constr;
      Module1.llena_tablas_e(ref dt, strsql, ref cnn);
      combo.Items.Clear();
      combo.Text = "";
      try
      {
        try
        {
          foreach (DataRow row in dt.Rows)
            combo.Items.Add(RuntimeHelpers.GetObjectValue(row[campo]));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (combo.Items.Count <= 0)
          return;
        combo.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void llena_combos_d(ComboBox combo, DataTable dt, string campo)
    {
      combo.Items.Clear();
      combo.Text = "";
      try
      {
        try
        {
          foreach (DataRow row in dt.Rows)
            combo.Items.Add(RuntimeHelpers.GetObjectValue(row[campo]));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        if (combo.Items.Count <= 0)
          return;
        combo.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void llena_combos(ref ComboBox combo, string strsql, string campo)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      Module1.llena_tablas(ref dt, strsql, ref cnn);
      combo.Items.Clear();
      try
      {
        try
        {
          foreach (DataRow row in dt.Rows)
            combo.Items.Add(RuntimeHelpers.GetObjectValue(row[campo]));
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        combo.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void llena_tablas(ref DataTable dt, string strSql, ref SqlConnection cnn)
    {
      cnn = new SqlConnection();
      empresas empresas = new empresas();
      cnn.ConnectionString = empresas.constr;
      DataSet dataSet = new DataSet();
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSql, cnn);
      try
      {
        sqlDataAdapter.Fill(dataSet);
        dt = dataSet.Tables[0];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void llena_tablas_e(ref DataTable dt, string strSql, ref SqlConnection cnn)
    {
      DataSet dataSet = new DataSet();
      SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSql, cnn);
      try
      {
        sqlDataAdapter.Fill(dataSet);
        dt = dataSet.Tables[0];
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void llena_tablas_con(ref DataTable dt, string[] con, string strSql)
    {
      SqlConnection selectConnection = new SqlConnection();
      DataTable dataTable = new DataTable();
      DataColumn dataColumn1 = new DataColumn();
      dt = new DataTable();
      int num = checked (con.Length - 2);
      int index = 1;
      while (index <= num)
      {
        selectConnection.ConnectionString = con[index];
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSql, selectConnection);
        try
        {
          sqlDataAdapter.Fill(dataSet);
          dataTable = new DataTable();
          DataTable table = dataSet.Tables[0];
          DataColumn column = new DataColumn();
          DataColumn dataColumn2 = column;
          dataColumn2.ColumnName = "EMPRESA";
          dataColumn2.DataType = System.Type.GetType("System.String");
          dataColumn2.DefaultValue = (object) Conversions.ToString(index);
          table.Columns.Add(column);
          dt.Merge(table);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    public static void llena_tablas_con1(ref DataTable dt, string[] con, string strSql)
    {
      SqlConnection selectConnection = new SqlConnection();
      DataTable dataTable = new DataTable();
      DataColumn dataColumn1 = new DataColumn();
      int num = checked (con.Length - 2);
      int index = 1;
      while (index <= num)
      {
        selectConnection.ConnectionString = con[index];
        DataSet dataSet = new DataSet();
        SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(strSql, selectConnection);
        try
        {
          sqlDataAdapter.Fill(dataSet);
          dataTable = new DataTable();
          DataTable table = dataSet.Tables[0];
          DataColumn column = new DataColumn();
          DataColumn dataColumn2 = column;
          dataColumn2.ColumnName = "EMPRESA";
          dataColumn2.DataType = System.Type.GetType("System.String");
          dataColumn2.DefaultValue = (object) Conversions.ToString(index);
          table.Columns.Add(column);
          dt.Merge(table);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
    }

    public static void lee_cortes_pad(
      string strsql,
      ref DataRow dr,
      ref string ep,
      ref string es,
      ref string rp,
      ref string rs,
      ref bool ok)
    {
      string[] strArray1 = new string[41];
      SqlConnection cnn = new SqlConnection();
      DataTable dt = new DataTable();
      string Expression = "EP0,EP1,EP2,EP3,EP4,EP5,EP6,EP7,EP8,EP9,ES0,ES1,ES2,ES3,ES4,ES5,ES6,ES7,ES8,ES9,RP0,RP1,RP2,RP3,RP4,RP5,RP6,RP7,RP8,RP9,RS0,RS1,RS2,RS3,RS4,RS5,RS6,RS7,RS8,RS9";
      ok = false;
      ep = "";
      es = "";
      rp = "";
      rs = "";
      Module1.llena_tablas(ref dt, strsql, ref cnn);
      if (dt.Rows.Count <= 0)
        return;
      dr = dt.Rows[0];
      string[] strArray2 = Strings.Split(Expression, ",", -1, CompareMethod.Binary);
      int index1 = 0;
      do
      {
        string index2 = strArray2[index1];
        int integer = Conversions.ToInteger(dr[index2]);
        if (index1 < 10)
          ep = ep + Conversions.ToString(integer) + ",";
        else if (index1 < 20)
          es = es + Conversions.ToString(integer) + ",";
        else if (index1 < 30)
          rp = rp + Conversions.ToString(integer) + ",";
        else
          rs = rs + Conversions.ToString(integer) + ",";
        checked { ++index1; }
      }
      while (index1 <= 39);
      ep = Strings.Mid(ep, 1, checked (Strings.Len(ep) - 1));
      es = Strings.Mid(es, 1, checked (Strings.Len(es) - 1));
      rp = Strings.Mid(rp, 1, checked (Strings.Len(rp) - 1));
      rs = Strings.Mid(rs, 1, checked (Strings.Len(rs) - 1));
      ok = true;
    }

    public static void codif_tela(DataTable codt, string cod, ref string descr, ref bool ok)
    {
      string[] strArray1 = new string[5];
      descr = "";
      string[] strArray2 = Strings.Split("ORDEN,FABRIC,WEIGHT,CONTENID,FIBRA", ",", -1, CompareMethod.Binary);
      ok = true;
      if (cod.Length != 8)
      {
        descr = "MAL CODIGO";
        ok = false;
      }
      else
      {
        int Start = 1;
        do
        {
          int index = checked ((int) Math.Round(unchecked ((double) checked (Start - 1) / 2.0 + 1.0)));
          string str = Strings.Mid(cod, Start, 2);
          DataRow[] dataRowArray = codt.Select("ORDEN = '" + str + "'");
          try
          {
            string Left = Strings.Trim(Conversions.ToString(dataRowArray[0][strArray2[index]]));
            if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, (string) null, false) > 0U)
              descr = descr + Left + " ";
            else
              ok = false;
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ok = false;
            ProjectData.ClearProjectError();
          }
          checked { Start += 2; }
        }
        while (Start <= 8);
        if (!ok)
          descr = "MAL CODIGO";
      }
    }

    public static void llena_clientes_cpo(ref ComboBox C4)
    {
      SqlConnection cnn = new SqlConnection();
      DataTable dt1 = new DataTable();
      DataTable dt2 = new DataTable();
      empresas empresas = new empresas();
      C4.Items.Clear();
      string strSql1 = "SELECT * FROM USUARIO_CLIENTE WHERE USUARIO = '" + empresas.clave + "' ORDER BY CLIENTE";
      Module1.llena_tablas(ref dt1, strSql1, ref cnn);
      try
      {
        foreach (DataRow row1 in dt1.Rows)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(row1["CLIENTE"], (object) "TODOS", false))
          {
            string strSql2 = "SELECT CLIENTE FROM CLIENTES ORDER BY CLIENTE";
            Module1.llena_tablas(ref dt2, strSql2, ref cnn);
            try
            {
              foreach (DataRow row2 in dt2.Rows)
                C4.Items.Add(RuntimeHelpers.GetObjectValue(row2["CLIENTE"]));
            }
            finally
            {
              IEnumerator enumerator;
              if (enumerator is IDisposable)
                (enumerator as IDisposable).Dispose();
            }
            try
            {
              C4.SelectedIndex = 0;
              return;
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
              return;
            }
          }
          else
            C4.Items.Add(RuntimeHelpers.GetObjectValue(row1["CLIENTE"]));
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      try
      {
        C4.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void grabar_sql(string strsql, ref SqlConnection cnn, ref int afectados)
    {
      try
      {
        afectados = 0;
        empresas empresas = new empresas();
        cnn.ConnectionString = empresas.constr;
        cnn.Open();
        SqlCommand sqlCommand = new SqlCommand(strsql, cnn);
        afectados = sqlCommand.ExecuteNonQuery();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      finally
      {
        cnn.Close();
      }
    }

    public static void llena_fpos_rec(string cliente, ref DataTable fpo, ref DataTable f_rec)
    {
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT * FROM FPO WHERE CPO IN (SELECT DISTINCT CPO FROM CPO_D WHERE ESTADO = 'A') AND CLIENTE = '" + cliente + "' AND TIPO = 'TELA' ORDER BY CPO,COLOR,CODIGO";
      Module1.llena_tablas(ref fpo, strSql, ref cnn);
      string str1 = "(";
      try
      {
        foreach (DataRow row in fpo.Rows)
        {
          string str2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "'", row["FPO"]), (object) "'"));
          if (str1.IndexOf(str2) == -1)
            str1 = str1 + str2 + ",";
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string fpol = Strings.Mid(str1, 1, checked (Strings.Len(str1) - 1)) + ")";
      Module1.fecha_recepcion(ref f_rec, ref fpol);
    }

    public static void quita_caracter(ref string texto, string caracter)
    {
      for (int Length = texto.IndexOf(caracter); Length > 0; Length = texto.IndexOf(caracter))
        texto = Strings.Mid(texto, 1, Length) + Strings.Mid(texto, checked (Length + 2));
    }

    public static void adios(ref string nombre)
    {
      Module1.quita_caracter(ref nombre, "/");
      Module1.quita_caracter(ref nombre, "\\");
    }

    public static void graba_t(SqlConnection cnn, string strsql)
    {
      cnn.Open();
      SqlTransaction sqlTransaction = cnn.BeginTransaction();
      SqlCommand command = cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        command.CommandText = strsql;
        command.ExecuteNonQuery();
        sqlTransaction.Commit();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        try
        {
          int num = (int) Interaction.MsgBox((object) "Inconsistencia en Datos, no se pudo actualizar.", MsgBoxStyle.Critical, (object) "Por favor revise !!!!");
          sqlTransaction.Rollback();
        }
        catch (SqlException ex2)
        {
          ProjectData.SetProjectError((Exception) ex2);
          SqlException sqlException = ex2;
          if (sqlTransaction.Connection != null)
          {
            int num = (int) Interaction.MsgBox((object) ("Ocurrió un error de tipo " + sqlException.GetType().ToString() + " se generó cuando se trato de eliminar la transacción."), MsgBoxStyle.Critical, (object) "Error");
          }
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
      }
      finally
      {
        cnn.Close();
      }
    }

    public static void fecha_recepcion(ref DataTable f_rec, ref string fpol)
    {
      f_rec = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT DISTINCT FECHA, DMOVTO.CPO,DMOVTO.FPO, TIPO, CODIGO,COLOR, LOTE FROM DMOVTO, ROLLOS WHERE DMOVTO.BATCH = ROLLOS.BATCH AND DMOVTO.ROLLO = ROLLOS.ROLLO AND TMOVTO = '1' AND DMOVTO.FPO IN " + fpol;
      Module1.llena_tablas(ref f_rec, strSql, ref cnn);
    }

    public static void AutoCompletar(ref ComboBox cb, KeyPressEventArgs e)
    {
      int selectedIndex = cb.SelectedIndex;
      string s;
      if (e.KeyChar == '\b')
      {
        if (cb.SelectionStart <= 1)
          cb.SelectionStart = 1;
        s = cb.SelectionLength != 0 ? cb.Text.Substring(0, checked (cb.SelectionStart - 1)) : cb.Text.Substring(0, checked (cb.Text.Length - 1));
      }
      else
        s = cb.SelectionLength != 0 ? cb.Text.Substring(0, cb.SelectionStart) + Conversions.ToString(e.KeyChar) : cb.Text + Conversions.ToString(e.KeyChar);
      int num = cb.FindString(s);
      if (num != -1)
      {
        cb.SelectedText = "";
        cb.SelectedIndex = num;
        cb.SelectionStart = s.Length;
        cb.SelectionLength = cb.Text.Length;
        e.Handled = true;
      }
      else
        e.Handled = true;
    }

    public static void llena_clientes_usuario(ref ComboBox c4, string usuario, string tipo)
    {
      DataTable dt = new DataTable();
      bool flag = false;
      string str = "(";
      Module1.revisa_acceso_usuario(ref usuario, ref dt);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(row[tipo], (object) "S", false))
          {
            if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(row["CLIENTE"], (object) "TODOS", false))
              flag = true;
            else
              str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) (str + "'"), row["CLIENTE"]), (object) "',"));
          }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      string strsql;
      if (flag)
      {
        strsql = "SELECT * FROM CLIENTES ORDER BY CLIENTE";
      }
      else
      {
        if (str.Length > 0)
          str = Strings.Mid(str, 1, checked (str.Length - 1)) + ")";
        strsql = "SELECT * FROM CLIENTES WHERE CLIENTE IN " + str + " ORDER BY CLIENTE";
      }
      Module1.llena_combos(ref c4, strsql, "CLIENTE");
    }

    public static void revisa_acceso_usuario(ref string usuario, ref DataTable dt)
    {
      SqlConnection cnn = new SqlConnection();
      Module1.llena_tablas(ref dt, "SELECT * FROM USUARIO_CLIENTE WHERE USUARIO = '" + usuario + "'", ref cnn);
    }

    public static void envia_corrreo_bom(
      string cliente,
      string asunto,
      string mensaje,
      string path)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT * FROM USUARIO_CLIENTE WHERE SEGUIMIENTO_BOM = 'S' AND (CLIENTE = '" + cliente + "' OR CLIENTE = 'TODOS') ORDER BY USUARIO";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      try
      {
        Attachment attachment = new Attachment(path);
        SmtpClient smtpClient = new SmtpClient();
        MailMessage mailMessage = new MailMessage();
        string addresses = "";
        smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential("jcperez@pcs.com.gt", "Cnmrs98s");
        smtpClient.Port = 25;
        smtpClient.Host = "pop.emailsrvr.com";
        MailMessage message = new MailMessage();
        message.From = new MailAddress("jcperez@pcs.com.gt");
        message.Attachments.Add(attachment);
        try
        {
          foreach (DataRow row in dt.Rows)
          {
            try
            {
              addresses = Conversions.ToString(row["CORREO"]);
              message.To.Add(addresses);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num = (int) Interaction.MsgBox((object) ("Error al enviar a la dir'eccion " + addresses), MsgBoxStyle.Critical, (object) "Error en el envío del correo.");
              ProjectData.ClearProjectError();
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        message.Subject = asunto;
        message.Body = mensaje;
        smtpClient.Send(message);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "No puede enviar el correo de Autorización", MsgBoxStyle.Critical, (object) "Error en el envío del correo.");
        ProjectData.ClearProjectError();
      }
    }

    public static void envia_corrreo_split(string asunto, string mensaje, ref bool ok)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT * FROM CORTE_SPLIT_C ORDER BY CORREO";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      ok = false;
      try
      {
        SmtpClient smtpClient = new SmtpClient();
        MailMessage mailMessage = new MailMessage();
        string addresses = "";
        smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential("ricoh@pcs.com.gt", "Djk2e39df");
        smtpClient.Port = 25;
        smtpClient.Host = "pop.emailsrvr.com";
        MailMessage message = new MailMessage();
        message.From = new MailAddress("ricoh@pcs.com.gt", "Sistemas Integrados Server");
        try
        {
          foreach (DataRow row in dt.Rows)
          {
            try
            {
              addresses = Conversions.ToString(row["CORREO"]);
              message.To.Add(addresses);
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              int num = (int) Interaction.MsgBox((object) ("Error al enviar a la direccion " + addresses), MsgBoxStyle.Critical, (object) "Error en el envío del correo.");
              ProjectData.ClearProjectError();
            }
          }
        }
        finally
        {
          IEnumerator enumerator;
          if (enumerator is IDisposable)
            (enumerator as IDisposable).Dispose();
        }
        message.Subject = asunto;
        message.Body = mensaje;
        smtpClient.Send(message);
        ok = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "No puede enviar el correo de Autorización", MsgBoxStyle.Critical, (object) "Error en el envío del correo.");
        ProjectData.ClearProjectError();
      }
    }

    public static void envia_corrreo_estilo(string asunto, string mensaje, ref bool ok)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT * FROM CORTE_SPLIT_C ORDER BY CORREO";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      ok = false;
      try
      {
        SmtpClient smtpClient = new SmtpClient();
        MailMessage mailMessage = new MailMessage();
        smtpClient.Credentials = (ICredentialsByHost) new NetworkCredential("ricoh@pcs.com.gt", "Djk2e39df");
        smtpClient.Port = 25;
        smtpClient.Host = "pop.emailsrvr.com";
        smtpClient.Send(new MailMessage()
        {
          From = new MailAddress("ricoh@pcs.com.gt", "Sistemas Integrados Server"),
          To = {
            "amata@pcs.com.gt",
            "rbarillas@pcs.com.gt"
          },
          Subject = asunto,
          Body = mensaje
        });
        ok = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "No puede enviar el correo de Autorización", MsgBoxStyle.Critical, (object) "Error en el envío del correo.");
        ProjectData.ClearProjectError();
      }
    }

    public static void busca_descripciones(
      DataTable cu,
      string codigo,
      ref string descripcion,
      ref bool ok)
    {
      descripcion = "";
      ok = false;
      try
      {
        DataRow[] dataRowArray = cu.Select("CODIGO = '" + codigo + "'");
        if (dataRowArray.Length <= 0)
          return;
        DataRow dataRow = dataRowArray[0];
        descripcion = Conversions.ToString(dataRow["DESCRIPCION"]);
        ok = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static void busca_descripciones1(
      DataTable cu,
      string llave,
      string campo,
      string codigo,
      ref string descripcion)
    {
      try
      {
        DataRow[] dataRowArray = cu.Select(llave + " = '" + codigo + "'");
        if (dataRowArray.Length <= 0)
          return;
        DataRow dataRow = dataRowArray[0];
        descripcion = Conversions.ToString(dataRow[campo]);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        descripcion = "";
        ProjectData.ClearProjectError();
      }
    }

    public static void llena_tipos_Telas(ref DataTable cu, ref ComboBox codigo)
    {
      codigo.Items.Clear();
      try
      {
        foreach (DataRow row in cu.Rows)
          codigo.Items.Add(RuntimeHelpers.GetObjectValue(row["CODIGO"]));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      if (cu.Rows.Count <= 0)
        return;
      codigo.SelectedIndex = 0;
    }

    public static void conexiones(ref string[] con)
    {
      util util = new util();
      con = new string[3];
      int e = 0;
      do
      {
        con[e] = util.con_string(e);
        checked { ++e; }
      }
      while (e <= 2);
    }

    public static void calcula_fecha_corte(
      DataTable ec,
      string estilo,
      DateTime fcostura,
      ref DateTime fcorte)
    {
      int num = 15;
      DataRow[] dataRowArray = ec.Select("ESTILO = '" + estilo + "'");
      if (dataRowArray.Length > 0)
        num = Conversions.ToInteger(dataRowArray[0]["DIAS_CORTE"]);
      try
      {
        fcorte = fcostura.AddDays((double) checked (-num));
        switch (fcorte.DayOfWeek)
        {
          case DayOfWeek.Sunday:
            fcorte = fcorte.AddDays(-2.0);
            break;
          case DayOfWeek.Saturday:
            fcorte = fcorte.AddDays(-2.0);
            break;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        fcostura = DateAndTime.Today;
        fcorte = fcostura.AddDays((double) checked (-num));
        ProjectData.ClearProjectError();
      }
    }

    public static void determina_columna_tela(
      DateTime fei,
      DateTime fecha,
      int coli,
      int colmax,
      ref int col)
    {
      int num1 = checked ((int) DateAndTime.DateDiff(DateInterval.Day, fei, fecha, FirstDayOfWeek.Sunday, FirstWeekOfYear.Jan1));
      Decimal d1 = new Decimal((double) num1 / 7.0);
      int num2;
      if (num1 > 0)
      {
        num2 = checked ((int) unchecked ((double) num1 / 7.0));
        if (Decimal.Compare(Decimal.Subtract(d1, new Decimal(num2)), Decimal.Zero) > 0)
          checked { ++num2; }
      }
      else
        num2 = 0;
      col = checked (coli + num2);
      if (col < coli)
        col = coli;
      if (col <= colmax)
        return;
      col = colmax;
    }

    public static void ajusta_fecha_produccion(
      ref DataTable va,
      string sec,
      DateTime fechai,
      Decimal dias,
      ref DateTime fechaf)
    {
      DateTime dateTime = new DateTime();
      string Style = "yyyy-MM-dd";
      string str = "06";
      fechaf = fechai.AddDays(Convert.ToDouble(dias));
      Conversions.ToDate(Strings.Format((object) fechai, Style));
      Conversions.ToDate(Strings.Format((object) fechaf, Style));
      bool flag = true;
      while (flag)
      {
        if (va.Select("TIPO = 'D' AND FECHA = '" + Strings.Format((object) fechaf, "yyyy-MM-dd") + "' AND SECCION = '" + sec + "'").Length > 0)
        {
          fechaf = fechaf.AddDays(1.0);
        }
        else
        {
          flag = false;
          int dayOfWeek = (int) fechaf.DayOfWeek;
          if (str.IndexOf(Conversions.ToString(dayOfWeek)) > -1)
          {
            if (va.Select("TIPO = 'F' AND SECCION = '" + sec + "' AND FECHA = '" + Strings.Format((object) fechaf, "yyyy-MM-dd") + "'").Length == 0)
            {
              fechaf = fechaf.AddDays(1.0);
              flag = true;
            }
          }
        }
      }
    }

    public static void crea_sub_inventario(ref string ruta)
    {
      empresas empresas = new empresas();
      ruta = "c:\\telas\\inventarios";
      try
      {
        if (!Directory.Exists(ruta))
          Directory.CreateDirectory(ruta);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      ruta = ruta + "\\" + empresas.nombre;
      try
      {
        if (Directory.Exists(ruta))
          return;
        Directory.CreateDirectory(ruta);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public static object semana_fecha(int ano, ref int semana, ref DateTime fecha)
    {
      DateTime date = Conversions.ToDate(Strings.Format((object) ano, "0000") + "-01-01");
      int dayOfWeek = (int) date.DayOfWeek;
      if (semana == 0)
      {
        semana = 99;
        fecha = Conversions.ToDate("9999-12-31");
      }
      else
      {
        int num1 = checked (7 - dayOfWeek);
        DateTime dateTime = date.AddDays((double) num1);
        int num2 = checked (semana - 1 * 7);
        fecha = dateTime.AddDays((double) num2);
      }
      return (object) fecha;
    }

    public static void llena_combos_d(
      ComboBox combo,
      string strsql,
      ref DataTable dt,
      string dm,
      string vm)
    {
      SqlConnection cnn = new SqlConnection();
      Module1.llena_tablas(ref dt, strsql, ref cnn);
      try
      {
        combo.DataSource = (object) dt;
        combo.DisplayMember = dm;
        combo.ValueMember = vm;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      if (combo.Items.Count <= 0)
        return;
      combo.SelectedIndex = 0;
    }

    public static string d_estado(DataTable dt, string des)
    {
      DataRow[] dataRowArray = dt.Select("ESTADO_TELA = '" + des + "'");
      return dataRowArray.Length <= 0 ? "" : Conversions.ToString(dataRowArray[0]["CODIGO"]);
    }

    public static void busca_registro(
      ref DataTable dt,
      string campob,
      string busca,
      string campo,
      ref string resultado)
    {
      resultado = "";
      DataRow[] dataRowArray = dt.Select(campob + " = '" + busca + "'");
      if (dataRowArray.Length <= 0)
        return;
      DataRow dataRow = dataRowArray[0];
      resultado = Conversions.ToString(dataRow[campo]);
    }

    public static string embelishment(DataRow[] dd)
    {
      string str = "N/A";
      if (dd.Length > 0)
      {
        DataRow dataRow = dd[0];
        if (Conversions.ToBoolean(dataRow["O2"]))
          str = "BORDADO";
        else if (Conversions.ToBoolean(dataRow["O3"]))
          str = "SERIGRAFIA";
        if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.AndObject(dataRow["O2"], dataRow["O3"])))
          str = "BORDADO/SERIGRA";
      }
      return str;
    }

    public static DateTime fpo_ofecha(object cliente)
    {
      DataTable dt = new DataTable();
      DateTime dateTime = DateTime.MinValue;
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT TOP 1 FECHA FROM FPO_OFECHA ORDER BY FECHA DESC";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          dateTime = Conversions.ToDate(row["fecha"]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      return dateTime;
    }

    public static DataTable descarga_lector(int c)
    {
      SqlConnection cnn = new SqlConnection();
      DataTable dt = new DataTable();
      string[] strArray = new string[4]
      {
        "CODIGO",
        "ROLLOS_UBICA",
        "DESP_T2",
        null
      };
      cnn.ConnectionString = Module1.lector_dc();
      Module1.llena_tablas_e(ref dt, "SELECT * FROM " + strArray[c], ref cnn);
      return dt;
    }

    public static bool imprime_etiquetas_tela(
      ref string empresa,
      string batch,
      string rollo,
      string knit,
      string colort,
      string barra,
      Decimal yardas,
      Decimal libras)
    {
      bool flag = true;
      string hostname = "192.9.200.28";
      int port = 9100;
      string str1 = "";
      string Style = "##0.00";
      string Expression1 = Strings.Format((object) yardas, Style);
      string Expression2 = Strings.Format((object) libras, Style);
      string str2 = Strings.Space(checked (6 - Strings.Len(Expression1))) + Expression1;
      string str3 = Strings.Space(checked (6 - Strings.Len(Expression2))) + Expression2;
      TcpClient tcpClient = new TcpClient();
      tcpClient.Connect(hostname, port);
      StreamWriter streamWriter = new StreamWriter((Stream) tcpClient.GetStream());
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empresa, "1", false) == 0)
        str1 = "^FO10,10^GFA,2205,2205,15,,:::O03FE,O07FF8,N01IFC,N03IFE,N07JF,N07JF8,:N0KFC,::::::N0KF8,N07JF8,N07JF,N03IFE,N01IFC,O0IF8,O03FE,,:::M01WFE,:::::::::::::::::::::U03KFC,U01KFC,U03KFC,U03KFC10FE,U03KFC38FE,:U03KFC30C6,M01KFE03KFC38C6,M01KFE03KFC3806,M01KFE03KFC380E,M01KFE03KFC1C1E,M01KFE03KFC1FFC,M01KFE03KFC0FFC,M01KFE03KFC07F,M01KFE03KFC,::M01KFE03KFC3FFE,M01KF800KFC3FFE,M01JFCI01JFC183E,M01JFK0JFC007C,M01IFEK03IFC01F,M01IFCK01IFC07C,M01IF8004I0IFC1F,M01IF003F8007FFC3E,M01FFE00FFE003FFC3FFE,M01FFC00F1E003FFC3FFE,M01FFC01E0E001FFC1FFE,M01FF801E0F001FFC,M01FF801E0FI0FFC,M01FF801E1EI0FFC3FFE,M01FF001F1EI0FFC3FFE,M01FFI0F3CI07FC3FFE,M01FFI0FF8I07FC,M01FFI07E03807FC,M01FF001FE07807FC01C,M01FF003FF07807FC07F,M01FF007CF87807FC0FFC,M01FF00787CF007FC1FFC,M01FF00F87CF007FC1C1E,M01FF00F03FE007FC380E,M01FF00F81FE00FFC3806,M01FF80F80FC00FFC3006,M01FF80FC0FC00FFC3006,M01FF807F3FE01FFC3FFE,M01FFC03JF01FFC3FFE,M01FFE01FFCF83FFC3FFE,M01FFE007E0787FFC,M01IFM07FFC,M01IF8L0IFC,M01IFCK01IFCI0E,M01JFK07IFC007E,M01JF8J0JFC03FE,M01KFI07JFC1FF,M01KFC01KFC3F3,M03KFC01KFC383,M03KFC03KFC3F3,M03KFC03KFC1FF8,M03KFC03KFC03FE,M07KFC03KFC007E,M0LFC03KFCI0E,M0LFC03KFC,L03LFC03KFC,L0MF803KFC,K07MF803KFC0E0E,I0PF803KFC1F3E,I0PF803KFC1FFE,I0PF003KFC39F8,I0PF003KFC30E,I0PF003KFC30C,I0OFE003KFC38C,I0OFE003KFC3FFE,I0OFC003KFC3FFE,I0OF8003KFC1FFE,I0OF8003KFC,I0OFI03KFC,I0OFI03KFC38,I0NFEI03KFC38,I0NFCI03KFC38,I0NF8I03KFC38,I0NFJ03KFC3FFE,I0MFEJ03KFC3FFE,I0MF8J03KFC3A6E,I0MFK03KFC38,I0LF8K03KFC38,I0KFEL03KFC38,I0KFM03KFC,I0IFEN03KFC,I0FQ01KF8,,::::::^FS";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empresa, "3", false) == 0)
        str1 = "^FO15,45^GFA,1480,1480,20,,:::Q0F8,P0IFC,O07IFC,I07FE001FFD2,001JF03FF8,007MFC,I093LF8,K03LF,K01LFC,K0JFE67E,J03KF003,I01LFC,I03JF7FE,I07JF3FF,001KF9FF8,003F4IF9DFC3FC,007E1IF8E7E3FF8003,00FE3FBF8E0F01FF0IF,00F23FBF070F003KF,01C07F3F030383JF8,01007C3F03838KF,0100FC3F03819F3IF8,I01E03F01CI03JF,I01F03E01EI07F7FFC,I01C03F00E001FEIFE,I03C03E00F001ECFFDF,I03C03E007003CCFFCF8,I03801D00700718FBE5C,I03001C00380E1879E0C,I06001E00380C30F8F04,I06001F001C0830F87,I04001E001C00607838,L01E001E00E07838,L01CI0E00E07838,M0EI0E01C0380C,:M0AI0F01807004,M02I0703803,Q0783003,Q0787003,Q0787002,Q078E,:::Q079C,:Q07FCJ01FF8L03FC,Q07FCJ07FF8L0FFC,Q07F8J07FFL01FF8,Q07F8J0F3EL01FE,Q07F8K0380CK03E00C,Q07F8K0700E006003C03E706,Q07F8K0E03E00E00780FE79E,Q07F8J03C07C71C70F81CE3FC,Q07F8J07807CF3CF1F03DC3F8,Q0FF8J0F00F1E7FE1F03983F,Q0FF8I03E00F7E7FE3E0F383E,Q0FF8I07C19EFCFFE3C0F603E,Q0FF8I0FCF1FFCFBC7C1F40FE,Q0FF8001FFE3F79F3CF81F73FF,O018FF8803FFE3E79E3CF01FE7FF,P09FF8801FF07879838E01F871F,P09FF88,O02BFFC,O01JFC,O03JFE,O0LF8,,:^FS";
      string str4 = "^XA" + str1 + ("^FO290,60^A0,50,50^FDBATCH:^FS" + "^FO460,60^A0,50,50^FD" + batch + "^FS" + "^FO290,120^A0,50,50^FDROLLO:^FS" + "^FO460,120^A0,50,50^FD" + rollo + "^FS" + "^FO30,190^A0,45,45^FDKNIT:^FS" + "^FO30,230^A0,35,35^FD" + knit + "^FS" + "^FO30,290^A0,45,45^FDCOLOR:^FS" + "^FO30,330^A0,35,35^FD" + colort + "^FS" + "^FO640,290^AD,30,14^FDYds.:^FS" + "^FO730,290^AD,30,14^FD" + str2 + "^FS" + "^FO640,330^AD,30,14^FDLbs.:^FS" + "^FO730,330^AD,30,14^FD" + str3 + "^FS") + "^BY5,2,120^FO75,410^BC^FD" + barra + "^FS^XZ";
      streamWriter.Write(str4);
      streamWriter.Flush();
      streamWriter.Close();
      tcpClient.Close();
      return flag;
    }

    public static string get_seccion(string corte)
    {
      DataTable dt = new DataTable();
      string str = "";
      SqlConnection cnn = new SqlConnection();
      string strSql = "SELECT SECCION FROM CORTES WHERE CORTE =  '" + corte + "'";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      if (dt.Rows.Count > 0)
        str = Conversions.ToString(dt.Rows[0]["SECCION"]);
      return str;
    }

    public static string DefaultPrinterName()
    {
      PrinterSettings printerSettings = new PrinterSettings();
      string str;
      try
      {
        str = printerSettings.PrinterName;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        str = "";
        ProjectData.ClearProjectError();
      }
      finally
      {
      }
      return str;
    }

    public static int revisa_existencias(string caja, string tipo, string talla)
    {
      DataTable dt = new DataTable();
      SqlConnection cnn = new SqlConnection();
      int num = 0;
      string strSql = "SELECT * FROM CAJAS01 WHERE CAJA = '" + caja + "' AND TIPO = '" + tipo + "' AND TALLA = '" + talla + "'";
      Module1.llena_tablas(ref dt, strSql, ref cnn);
      if (dt.Rows.Count > 0)
        num = Conversions.ToInteger(dt.Rows[0]["UNIDADES"]);
      return num;
    }

    public static bool revisa_datos(C1.Win.C1FlexGrid.C1FlexGrid fg, int c)
    {
      bool flag = true;
      int num1 = checked (fg.Rows.Count - 1);
      int index = 1;
      while (index <= num1)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual((object) Module1.revisa_existencias(Conversions.ToString(fg[index, 1]), Conversions.ToString(fg[index, 2]), Conversions.ToString(fg[index, 3])), fg[index, c], false))
        {
          int num2 = (int) Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "Las unidades de la caja ", fg[index, 1]), (object) "Han cambiado\nNo se puede efectuar esta operacion."), MsgBoxStyle.Critical, (object) "Trate de nuevo.");
          flag = false;
        }
        checked { ++index; }
      }
      return flag;
    }

    public static string GetIpV4()
    {
      IPHostEntry hostEntry = Dns.GetHostEntry(Dns.GetHostName());
      string Left = "";
      IPAddress[] addressList = hostEntry.AddressList;
      int index = 0;
      while (index < addressList.Length)
      {
        IPAddress ipAddress = addressList[index];
        if (ipAddress.AddressFamily == AddressFamily.InterNetwork)
        {
          Left = ipAddress.ToString();
          break;
        }
        checked { ++index; }
      }
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "", false) == 0)
        throw new Exception("No 10. IP found!");
      return Left;
    }
  }
}
