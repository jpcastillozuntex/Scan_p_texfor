// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas99
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Scan_P_texfor.My;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  [DesignerGenerated]
  public class Cajas99 : Form
  {
    private IContainer components;
    private DataTable dt;
    private string strsql;
    private SqlConnection cnn;
    private string[] con;
    private empresas obj;
    private string seccion;
    private string sec;

    public Cajas99()
    {
      this.Load += new EventHandler(this.Plan_costura_Load);
      this.dt = new DataTable();
      this.cnn = new SqlConnection();
      this.con = new string[4];
      this.obj = new empresas();
      this.seccion = this.obj.seccion;
      this.sec = "('" + this.obj.seccion + "','TEXFOR" + Strings.Mid(this.obj.seccion, 7) + "')";
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas99));
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.abrear = new OpenFileDialog();
      this.Label1 = new Label();
      this.caja = new TextBox();
      this.jg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label2 = new Label();
      this.fg.BeginInit();
      this.jg.BeginInit();
      this.SuspendLayout();
      this.fg.AllowDragging = AllowDraggingEnum.None;
      this.fg.AllowEditing = false;
      this.fg.AllowFiltering = true;
      this.fg.AllowMergingFixed = AllowMergingEnum.None;
      this.fg.AllowSorting = AllowSortingEnum.None;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Courier New", 8.25f);
      this.fg.HighLight = HighLightEnum.Never;
      this.fg.KeyActionTab = KeyActionEnum.MoveAcross;
      this.fg.Location = new Point(12, 73);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 19;
      this.fg.SelectionMode = SelectionModeEnum.Cell;
      this.fg.Size = new Size(833, 594);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 0;
      this.abrear.FileName = "OpenFileDialog1";
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(12, 25);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(186, 33);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Caja:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.caja.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.caja.Location = new Point(85, 28);
      this.caja.MaxLength = 10;
      this.caja.Name = "caja";
      this.caja.Size = new Size(229, 26);
      this.caja.TabIndex = 0;
      this.jg.AllowDragging = AllowDraggingEnum.None;
      this.jg.AllowEditing = false;
      this.jg.AllowFiltering = true;
      this.jg.AllowMergingFixed = AllowMergingEnum.None;
      this.jg.AllowSorting = AllowSortingEnum.None;
      this.jg.BackColor = Color.LightGreen;
      this.jg.ColumnInfo = componentResourceManager.GetString("jg.ColumnInfo");
      this.jg.Font = new Font("Courier New", 8.25f);
      this.jg.HighLight = HighLightEnum.Never;
      this.jg.KeyActionTab = KeyActionEnum.MoveAcross;
      this.jg.Location = new Point(851, 73);
      this.jg.Name = "jg";
      this.jg.Rows.Count = 1;
      this.jg.Rows.DefaultSize = 19;
      this.jg.SelectionMode = SelectionModeEnum.Cell;
      this.jg.Size = new Size(226, 594);
      this.jg.StyleInfo = componentResourceManager.GetString("jg.StyleInfo");
      this.jg.TabIndex = 12;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.Location = new Point(851, 37);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(226, 33);
      this.Label2.TabIndex = 14;
      this.Label2.Text = "TEXSUN J";
      this.Label2.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1093, 690);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.jg);
      this.Controls.Add((Control) this.caja);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.fg);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (Cajas99);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ingreso de Cajas";
      this.fg.EndInit();
      this.jg.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual OpenFileDialog abrear { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox caja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid jg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Plan_costura_Load(object sender, EventArgs e)
    {
      this.caja.KeyPress += new KeyPressEventHandler(this.keypressed1);
      Module1.conexiones(ref this.con);
      this.Label2.Text = this.seccion;
      this.setea_fg();
      this.caja.Focus();
    }

    private void setea_fg()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows[0].Height = 30;
    }

    private void limpia_caja()
    {
      this.busca_produccion();
      this.caja.Text = "";
      this.caja.Focus();
    }

    private void busca_produccion()
    {
      int index1 = 1;
      string str1 = Strings.Format((object) DateAndTime.Today, "yyyy-MM-dd");
      DataTable dataTable = new DataTable();
      string str2 = "('" + this.obj.seccion + "','TEXFOR" + Strings.Mid(this.obj.seccion, 7) + "')";
      string strSql = "SELECT SECCION,CAJAS04.CORTE,SUM(CAJAS04.UNIDADES) AS PRENDAS FROM CAJAS04 LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS04.CORTE = CAJAS01.CORTE AND CAJAS04.TIPO = CAJAS01.TIPO AND CAJAS04.TALLA = CAJAS01.TALLA WHERE CONVERT(date,CAJAS04.FECHA) = '" + str1 + "' AND SECCION IN " + str2 + " GROUP BY SECCION,CAJAS04.CORTE";
      this.jg.Rows.Count = 1;
      int index2 = 1;
      do
      {
        try
        {
          DataTable dt = new DataTable();
          this.cnn.ConnectionString = this.con[index2];
          Module1.llena_tablas_e(ref dt, strSql, ref this.cnn);
          try
          {
            foreach (DataRow row in dt.Rows)
            {
              this.jg.Rows.Count = checked (index1 + 1);
              this.jg[index1, 1] = RuntimeHelpers.GetObjectValue(row["CORTE"]);
              this.jg[index1, 2] = RuntimeHelpers.GetObjectValue(row["PRENDAS"]);
              checked { ++index1; }
            }
          }
          finally
          {
            IEnumerator enumerator;
            if (enumerator is IDisposable)
              (enumerator as IDisposable).Dispose();
          }
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index2; }
      }
      while (index2 <= 3);
    }

    private void chequea_datos()
    {
      bool ok;
      this.busca_caja(ref this.dt, ref ok);
      if (ok)
        this.actualiza(this.dt);
      else
        this.limpia_caja();
    }

    private void actualiza(DataTable dt)
    {
      int count = this.fg.Rows.Count;
      bool ok;
      this.Graba_datos(dt, ref ok);
      checked { this.fg.Rows.Count += dt.Rows.Count; }
      try
      {
        foreach (object row in dt.Rows)
        {
          object objectValue = RuntimeHelpers.GetObjectValue(row);
          this.fg[count, 1] = (object) this.caja.Text;
          this.fg[count, 2] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1]
          {
            (object) "CORTE"
          }, (string[]) null));
          this.fg[count, 3] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1]
          {
            (object) "TALLA"
          }, (string[]) null));
          this.fg[count, 4] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1]
          {
            (object) "UNIDADES"
          }, (string[]) null));
          this.fg[count, 5] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1]
          {
            (object) "SECCION"
          }, (string[]) null));
          if (ok)
            this.fg[count, 6] = (object) true;
          else
            this.fg[count, 6] = (object) false;
          this.fg[count, 7] = RuntimeHelpers.GetObjectValue(NewLateBinding.LateIndexGet(objectValue, new object[1]
          {
            (object) "FECHA"
          }, (string[]) null));
          checked { ++count; }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.fg.Sort(SortFlags.Descending, 7);
      this.limpia_caja();
    }

    private void busca_caja(ref DataTable dt, ref bool ok)
    {
      DataTable dt1 = new DataTable();
      ok = false;
      dt = new DataTable();
      string strSql = "SELECT * FROM CAJAS01 LEFT JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE WHERE CAJA = '" + this.caja.Text + "'";
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      if (dt.Rows.Count <= 0)
        return;
      DataRow row = dt.Rows[0];
      Module1.llena_tablas(ref dt1, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM UPC WHERE CLIENTE = '", row["CLIENTE"]), (object) "' AND ESTILO = '"), row["ESTILO"]), (object) "' AND COLOR = '"), row["COLOR"]), (object) "'")), ref this.cnn);
      if (dt1.Rows.Count > 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "Este Corte tiene UPC registrado. Use el programa de scan & Pack !!!", MsgBoxStyle.Critical, (object) "Por favor revise.");
      }
      else if (Strings.InStr(this.sec, Conversions.ToString(row["SECCION"]), CompareMethod.Binary) == 0)
      {
        int num2 = (int) Interaction.MsgBox((object) "Este Corte es de otra Sección. !!!", MsgBoxStyle.Critical, (object) "Por favor revise.");
      }
      else
        ok = true;
    }

    private void keypressed1(object o, KeyPressEventArgs e)
    {
      string text = this.caja.Text;
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if (text.Length == 10)
      {
        MyProject.Computer.Audio.Play("c:\\scan\\beep.wav");
        this.caja.Text = Strings.UCase(this.caja.Text);
        this.chequea_datos();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Datos incorrectos !!!!!", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
        this.limpia_caja();
      }
    }

    private void Graba_datos(DataTable dt, ref bool ok)
    {
      int num1 = 0;
      empresas empresas = new empresas();
      ok = false;
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        try
        {
          foreach (DataRow row in dt.Rows)
          {
            try
            {
              string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "INSERT INTO CAJAS04 (CAJA,CORTE,TALLA,TIPO,UNIDADES,FECHA ,QUIEN) VALUES ( '", row["CAJA"]), (object) "','"), row["CORTE"]), (object) "','"), row["TALLA"]), (object) "','"), row["TIPO"]), (object) "','"), row["UNIDADES"]), (object) "',GETDATE(),'OPERADOR')"));
              command.CommandText = str;
              checked { num1 += command.ExecuteNonQuery(); }
              ok = true;
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
        if (num1 > 0)
        {
          string str = "UPDATE CAJAS01 SET ESTADO = 'P' WHERE CAJA = '" + this.caja.Text + "'";
          command.CommandText = str;
          command.ExecuteNonQuery();
        }
        sqlTransaction.Commit();
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        try
        {
          int num2 = (int) Interaction.MsgBox((object) "Inconsistencia en Datos", MsgBoxStyle.Critical, (object) "Por favor revise !!!!");
          sqlTransaction.Rollback();
        }
        catch (SqlException ex2)
        {
          ProjectData.SetProjectError((Exception) ex2);
          SqlException sqlException = ex2;
          if (sqlTransaction.Connection != null)
          {
            int num2 = (int) Interaction.MsgBox((object) ("Ocurrió un error de tipo " + sqlException.GetType().ToString() + " se generó cuando se trato de eliminar la transacción."), MsgBoxStyle.Critical, (object) "Error");
          }
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.cnn.Close();
      }
    }
  }
}
