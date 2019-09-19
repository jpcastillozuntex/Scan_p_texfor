// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas01_D
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
using C1Cajasf;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
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
  public class Cajas01_D : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataRow dr;
    private DataTable es;
    private string[] e;
    private int[] t;
    private object[] p;
    private string escala;
    private string inicial;
    private string final;
    private string seccion;
    private empresas obj;
    private DataTable ee;
    private string estilo;
    private int[] c;
    private IContainer components;

    internal virtual Button graba
    {
      get
      {
        return this._graba;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.graba_Click);
        Button graba1 = this._graba;
        if (graba1 != null)
          graba1.Click -= eventHandler;
        this._graba = value;
        Button graba2 = this._graba;
        if (graba2 == null)
          return;
        graba2.Click += eventHandler;
      }
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox CORTE
    {
      get
      {
        return this._CORTE;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.empresa_KeyPress);
        ComboBox corte1 = this._CORTE;
        if (corte1 != null)
          corte1.KeyPress -= pressEventHandler;
        this._CORTE = value;
        ComboBox corte2 = this._CORTE;
        if (corte2 == null)
          return;
        corte2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button S1
    {
      get
      {
        return this._S1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.S1_Click);
        Button s1_1 = this._S1;
        if (s1_1 != null)
          s1_1.Click -= eventHandler;
        this._S1 = value;
        Button s1_2 = this._S1;
        if (s1_2 == null)
          return;
        s1_2.Click += eventHandler;
      }
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid co { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Cajas01_D()
    {
      this.Load += new EventHandler(this.Cortes_status);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.es = new DataTable();
      this.e = new string[11];
      this.t = new int[11];
      this.p = new object[11];
      this.escala = "";
      this.inicial = "";
      this.final = "";
      this.seccion = "";
      this.obj = new empresas();
      this.ee = new DataTable();
      this.c = new int[11];
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas01_D));
      this.CORTE = new ComboBox();
      this.graba = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.S1 = new Button();
      this.co = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.fg.BeginInit();
      this.co.BeginInit();
      this.SuspendLayout();
      this.CORTE.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.CORTE.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CORTE.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.CORTE.Location = new Point(85, 18);
      this.CORTE.Name = "CORTE";
      this.CORTE.Size = new Size(189, 28);
      this.CORTE.TabIndex = 93;
      this.graba.BackColor = Color.FromArgb(46, 196, 245);
      this.graba.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.graba.ForeColor = Color.Black;
      this.graba.Image = (Image) componentResourceManager.GetObject("graba.Image");
      this.graba.Location = new Point(1028, 8);
      this.graba.Name = "graba";
      this.graba.Size = new Size(60, 40);
      this.graba.TabIndex = 91;
      this.graba.TextAlign = ContentAlignment.BottomCenter;
      this.graba.UseVisualStyleBackColor = false;
      this.fg.AllowFiltering = true;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.Location = new Point(11, 162);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(1167, 522);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Black;
      this.Label3.Location = new Point(13, 16);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(104, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Corte:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.S1.BackColor = Color.FromArgb(46, 196, 245);
      this.S1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.S1.ForeColor = Color.Black;
      this.S1.Image = (Image) componentResourceManager.GetObject("S1.Image");
      this.S1.Location = new Point(1028, 8);
      this.S1.Name = "S1";
      this.S1.Size = new Size(60, 40);
      this.S1.TabIndex = 95;
      this.S1.TextAlign = ContentAlignment.BottomCenter;
      this.S1.UseVisualStyleBackColor = false;
      this.co.AllowEditing = false;
      this.co.AllowFiltering = true;
      this.co.ColumnInfo = componentResourceManager.GetString("co.ColumnInfo");
      this.co.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.co.HighLight = HighLightEnum.Never;
      this.co.Location = new Point(12, 69);
      this.co.Name = "co";
      this.co.Rows.DefaultSize = 21;
      this.co.Size = new Size(1048, 76);
      this.co.StyleInfo = componentResourceManager.GetString("co.StyleInfo");
      this.co.TabIndex = 96;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1190, 696);
      this.Controls.Add((Control) this.co);
      this.Controls.Add((Control) this.S1);
      this.Controls.Add((Control) this.CORTE);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.graba);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas01_D);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Impresión de Cajas por corte";
      this.fg.EndInit();
      this.co.EndInit();
      this.ResumeLayout(false);
    }

    private void Cortes_status(object sender, EventArgs e)
    {
      Module1.llena_tablas(ref this.es, "SELECT * FROM E_TALLAS", ref this.cnn);
      ComboBox corte = this.CORTE;
      Module1.llena_combos(ref corte, "SELECT CORTE FROM CORTES WHERE CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND CORTE NOT IN (SELECT CORTE FROM CAJAS01 WHERE CORTE = CORTES.CORTE) AND TOTAL > 0 AND EXPORTADO <> 'S' ORDER BY CORTE", "CORTE");
      this.CORTE = corte;
      try
      {
        this.CORTE.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.setea_fg();
    }

    private void setea_fg()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows[0].Height = 30;
      this.co.Rows.Count = 1;
      this.co.Rows.Count = 2;
      this.co.Rows[0].Height = 30;
    }

    private void llena_fg(ref bool ok)
    {
      this.c = new int[11];
      int num1 = 0;
      ok = false;
      Module1.llena_tablas(ref this.dt, "SELECT CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,CLIENTE,CORTES.XS,CORTES.S,CORTES.M,CORTES.L,CORTES.XL,CORTES.XL2,CORTES.XL3,CORTES.XL4,CORTES.XL5,CORTES.XL6,CORTES.TOTAL,ESCALA FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CORTE = '" + this.CORTE.Text + "'", ref this.cnn);
      if (this.dt.Rows.Count == 0)
        return;
      this.dr = this.dt.Rows[0];
      this.estilo = Conversions.ToString(this.dr["ESTILO"]);
      this.chequea_estilo(ref ok);
      if (!ok)
      {
        int num2 = (int) Interaction.MsgBox((object) "Este Corte no aplica para este tipo de impresión", MsgBoxStyle.Critical, (object) "Por favor revise !!!!");
      }
      else
      {
        this.chequea_upc(this.dr, ref ok);
        if (!ok)
          return;
        int index1 = 0;
        do
        {
          this.c[index1] = Conversions.ToInteger(this.dr[checked (index1 + 5)]);
          checked { ++index1; }
        }
        while (index1 <= 9);
        this.llena_tallas_escala(this.dr);
        for (int index2 = this.suma(); index2 > 0; index2 = this.suma())
        {
          checked { ++num1; }
          int index3 = 0;
          do
          {
            if (this.c[index3] > 0 && this.c[index3] > 0)
            {
              int count = this.fg.Rows.Count;
              checked { ++this.fg.Rows.Count; }
              int num3 = !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater((object) this.c[index3], this.co[1, checked (index3 + 2)], false) ? this.c[index3] : Conversions.ToInteger(this.co[1, checked (index3 + 2)]);
              this.fg[count, 1] = (object) num1;
              this.fg[count, 2] = RuntimeHelpers.GetObjectValue(this.dr["CPO"]);
              this.fg[count, 3] = RuntimeHelpers.GetObjectValue(this.dr["ESTILO"]);
              this.fg[count, 4] = RuntimeHelpers.GetObjectValue(this.dr["COLOR"]);
              this.fg[count, 5] = RuntimeHelpers.GetObjectValue(this.dr["CLIENTE"]);
              this.fg[count, 6] = (object) this.e[index3];
              this.fg[count, 7] = (object) num3;
              this.fg[count, 8] = (object) index3;
              this.c[index3] = checked (this.c[index3] - num3);
            }
            checked { ++index3; }
          }
          while (index3 <= 9);
        }
        ok = true;
      }
    }

    private void llena_tallas_escala(DataRow dr)
    {
      this.e = new string[11];
      this.t = new int[11];
      this.escala = Conversions.ToString(dr["ESCALA"]);
      int index1 = 0;
      do
      {
        this.t[index1] = Conversions.ToInteger(dr[checked (index1 + 5)]);
        checked { ++index1; }
      }
      while (index1 <= 10);
      DataRow[] dataRowArray = this.es.Select(Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "ESCALA = '", dr["ESCALA"]), (object) "'")));
      if (dataRowArray.Length <= 0)
        return;
      dr = dataRowArray[0];
      int index2 = 0;
      do
      {
        this.e[index2] = Conversions.ToString(dr[checked (index2 + 2)]);
        this.co[0, checked (index2 + 2)] = (object) this.e[index2];
        checked { ++index2; }
      }
      while (index2 <= 9);
    }

    private void chequea_upc(DataRow dr, ref bool ok)
    {
      DataTable dt = new DataTable();
      ok = false;
      Module1.llena_tablas(ref dt, Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "SELECT * FROM UPC WHERE CLIENTE = '", dr["CLIENTE"]), (object) "' AND ESTILO = '"), dr["ESTILO"]), (object) "' AND COLOR = '"), dr["COLOR"]), (object) "'")), ref this.cnn);
      if (dt.Rows.Count > 0)
      {
        int num = (int) Interaction.MsgBox((object) "Este corte tiene UPC.", MsgBoxStyle.Critical, (object) "No se puede imprimir las Etiquetas.");
      }
      else
        ok = true;
    }

    private void graba_datos()
    {
      string str1 = "";
      empresas empresas = new empresas();
      string Style = "0000000";
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empresas.numero, "1", false) == 0)
        str1 = "JTF";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empresas.numero, "3", false) == 0)
        str1 = "ZUF";
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        string str2 = "SELECT CORRELATIVO FROM CAJAS02";
        command.CommandText = str2;
        int integer = Conversions.ToInteger(RuntimeHelpers.GetObjectValue(command.ExecuteScalar()).ToString());
        this.inicial = str1 + Strings.Format((object) checked (integer + 1), Style);
        int num1 = checked (this.fg.Rows.Count - 1);
        int index = 1;
        while (index <= num1)
        {
          string str3 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO CAJAS01 (CAJA,CORTE,TALLA,TIPO,UNIDADES,CLIENTE,UBICACION,FECHA,ESTADO,ESCALA,ORDEN,IMPRESO,TIPO_SEG,SECCION) VALUES ('" + str1 + Strings.Format(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) integer, this.fg[index, 1]), Style) + "','" + this.CORTE.Text + "','"), this.fg[index, 6]), (object) "','P','"), this.fg[index, 7]), (object) "','"), this.fg[index, 5]), (object) "','00',GETDATE(),'A','"), (object) this.escala), (object) "','"), this.fg[index, 8]), (object) "','"), (object) empresas.usuario), (object) "','0','"), (object) this.seccion), (object) "')"));
          command.CommandText = str3;
          int num2 = command.ExecuteNonQuery();
          string str4 = "UPDATE CAJAS02 SET CORRELATIVO = CORRELATIVO + 1";
          command.CommandText = str4;
          num2 = command.ExecuteNonQuery();
          this.final = str1 + Strings.Format((object) checked (integer + index), Style);
          checked { ++index; }
        }
        sqlTransaction.Commit();
        int num3 = (int) Interaction.MsgBox((object) "Grabacion Exitosa", MsgBoxStyle.Exclamation, (object) "Grabaciones");
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        try
        {
          int num = (int) Interaction.MsgBox((object) "Inconsistencia en Datos", MsgBoxStyle.Critical, (object) "Por favor revise !!!!");
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
        this.cnn.Close();
      }
    }

    private void graba_Click(object sender, EventArgs e)
    {
      prt prt = new prt();
      if (Interaction.MsgBox((object) "Seguro de Grabar las Cajas?  ", MsgBoxStyle.YesNo, (object) "Actualizacion de Datos !!!") != MsgBoxResult.Yes)
        return;
      this.graba_datos();
      prt.imprime_cajas_s(ref this.inicial, this.final, this.obj.seccion, this.obj.numero, this.obj.constr);
      this.Close();
    }

    private void empresa_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox corte = this.CORTE;
      Module1.AutoCompletar(ref corte, e);
      this.CORTE = corte;
    }

    private void S1_Click(object sender, EventArgs e)
    {
      bool ok;
      this.llena_fg(ref ok);
      if (ok)
      {
        this.seccion = Module1.get_seccion(this.CORTE.Text);
        this.CORTE.Enabled = false;
        this.S1.Visible = false;
      }
      else
      {
        this.setea_fg();
        this.CORTE.Focus();
      }
    }

    private void chequea_estilo(ref bool ok)
    {
      this.ee = new DataTable();
      string strSql = "SELECT * FROM CAJAS19 WHERE ESTILO ='" + this.estilo + "'";
      ok = false;
      Module1.llena_tablas(ref this.ee, strSql, ref this.cnn);
      try
      {
        foreach (DataRow row in this.ee.Rows)
        {
          int index = 1;
          do
          {
            this.co[1, checked (index + 1)] = RuntimeHelpers.GetObjectValue(row[index]);
            checked { ++index; }
          }
          while (index <= 10);
          ok = true;
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private int suma()
    {
      int num = 0;
      int index = 1;
      do
      {
        checked { num += this.c[index]; }
        checked { ++index; }
      }
      while (index <= 10);
      return num;
    }
  }
}
