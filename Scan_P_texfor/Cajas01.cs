// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas01
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1Cajasf;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  public class Cajas01 : Form
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
    private Lib_SIF.jap o;
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

    public Cajas01()
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
      this.o = new Lib_SIF.jap();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas01));
      this.CORTE = new ComboBox();
      this.graba = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.S1 = new Button();
      this.fg.BeginInit();
      this.SuspendLayout();
      this.CORTE.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.CORTE.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CORTE.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.CORTE.Location = new Point(92, 18);
      this.CORTE.Name = "CORTE";
      this.CORTE.Size = new Size(189, 28);
      this.CORTE.TabIndex = 93;
      this.graba.BackColor = Color.FromArgb(46, 196, 245);
      this.graba.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.graba.ForeColor = Color.Black;
      this.graba.Image = (Image) componentResourceManager.GetObject("graba.Image");
      this.graba.Location = new Point(1035, 8);
      this.graba.Name = "graba";
      this.graba.Size = new Size(60, 40);
      this.graba.TabIndex = 91;
      this.graba.TextAlign = ContentAlignment.BottomCenter;
      this.graba.UseVisualStyleBackColor = false;
      this.fg.AllowFiltering = true;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.Location = new Point(11, 66);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(1167, 618);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.Black;
      this.Label3.Location = new Point(20, 16);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(104, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Corte:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.S1.BackColor = Color.FromArgb(46, 196, 245);
      this.S1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.S1.ForeColor = Color.Black;
      this.S1.Image = (Image) componentResourceManager.GetObject("S1.Image");
      this.S1.Location = new Point(1035, 7);
      this.S1.Name = "S1";
      this.S1.Size = new Size(60, 40);
      this.S1.TabIndex = 95;
      this.S1.TextAlign = ContentAlignment.BottomCenter;
      this.S1.UseVisualStyleBackColor = false;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1190, 696);
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
      this.Name = nameof (Cajas01);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Impresión de Cajas por corte";
      this.fg.EndInit();
      this.ResumeLayout(false);
    }

    private void Cortes_status(object sender, EventArgs e)
    {
      string str = "('" + this.obj.seccion + "','TEXFOR" + Strings.Mid(this.obj.seccion, 7) + "')";
      Module1.llena_tablas(ref this.es, "SELECT * FROM E_TALLAS", ref this.cnn);
      ComboBox corte = this.CORTE;
      Module1.llena_combos(ref corte, "SELECT CORTE FROM CORTES WHERE CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND CORTE NOT IN (SELECT DISTINCT CORTE FROM CAJAS01) AND SECCION IN " + str + " AND TOTAL > 0 AND EXPORTADO <> 'S' ORDER BY CORTE", "CORTE");
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
    }

    private void llena_fg(ref DataRow dr)
    {
      Module1.llena_tablas(ref this.dt, "SELECT CORTE,CORTES.CPO,CORTES.ESTILO,CORTES.COLOR,CLIENTE,CORTES.XS,CORTES.S,CORTES.M,CORTES.L,CORTES.XL,CORTES.XL2,CORTES.XL3,CORTES.XL4,CORTES.XL5,CORTES.XL6,CORTES.TOTAL,ESCALA,CORTES.* FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D.ESTILO AND CORTES.COLOR = CPO_D.COLOR WHERE CORTE = '" + this.CORTE.Text + "'", ref this.cnn);
      if (this.dt.Rows.Count == 0)
        return;
      dr = this.dt.Rows[0];
      this.llena_tallas_escala(dr);
      DataRow dataRow;
      string estilo = Conversions.ToString((dataRow = dr)["ESTILO"]);
      bool ok;
      this.llena_empaque(ref estilo, ref ok);
      dataRow["ESTILO"] = (object) estilo;
      if (ok)
      {
        int index = 0;
        do
        {
          if (this.t[index] > 0)
          {
            int integer1 = Conversions.ToInteger(Conversion.Fix(Microsoft.VisualBasic.CompilerServices.Operators.DivideObject((object) this.t[index], this.p[index])));
            int integer2 = Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.SubtractObject((object) this.t[index], Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject((object) integer1, this.p[index])));
            int num1 = integer1;
            if (integer2 > 0)
              checked { ++num1; }
            int count = this.fg.Rows.Count;
            this.fg.Rows.Count = checked (count + num1);
            int num2 = integer1;
            int num3 = 1;
            while (num3 <= num2)
            {
              this.fg[count, 1] = (object) count;
              this.fg[count, 2] = RuntimeHelpers.GetObjectValue(dr["CPO"]);
              this.fg[count, 3] = RuntimeHelpers.GetObjectValue(dr["ESTILO"]);
              this.fg[count, 4] = RuntimeHelpers.GetObjectValue(dr["COLOR"]);
              this.fg[count, 5] = RuntimeHelpers.GetObjectValue(dr["CLIENTE"]);
              this.fg[count, 6] = (object) this.e[index];
              this.fg[count, 7] = RuntimeHelpers.GetObjectValue(this.p[index]);
              this.fg[count, 8] = (object) index;
              checked { ++count; }
              checked { ++num3; }
            }
            if (integer2 > 0)
            {
              this.fg[count, 1] = (object) count;
              this.fg[count, 2] = RuntimeHelpers.GetObjectValue(dr["CPO"]);
              this.fg[count, 3] = RuntimeHelpers.GetObjectValue(dr["ESTILO"]);
              this.fg[count, 4] = RuntimeHelpers.GetObjectValue(dr["COLOR"]);
              this.fg[count, 5] = RuntimeHelpers.GetObjectValue(dr["CLIENTE"]);
              this.fg[count, 6] = (object) this.e[index];
              this.fg[count, 7] = (object) integer2;
              this.fg[count, 8] = (object) index;
            }
          }
          checked { ++index; }
        }
        while (index <= 9);
      }
      else
        this.Close();
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
        checked { ++index2; }
      }
      while (index2 <= 9);
    }

    private void llena_empaque(ref string estilo, ref bool ok)
    {
      DataTable dt = new DataTable();
      this.p = new object[11];
      string strSql = "SELECT * FROM ESTILO_EMP WHERE ESTILO = '" + estilo + "'";
      ok = false;
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      if (dt.Rows.Count > 0)
      {
        DataRow row = dt.Rows[0];
        int index = 0;
        do
        {
          this.p[index] = RuntimeHelpers.GetObjectValue(row[checked (index + 1)]);
          checked { ++index; }
        }
        while (index <= 9);
        ok = true;
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Aún no han ingresado el número de unidades por Caja.", MsgBoxStyle.Critical, (object) "Por favor ingresar Empaque por Estilo!!!");
      }
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
      empresas empresas = new empresas();
      string caja = "";
      SqlConnection cnn = new SqlConnection();
      cnn.ConnectionString = this.cnn.ConnectionString;
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        int num1 = checked (this.fg.Rows.Count - 1);
        int index = 1;
        while (index <= num1)
        {
          this.o.crea_cajas((object) empresas, cnn, ref caja);
          string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO CAJAS01 (CAJA,CORTE,TALLA,TIPO,UNIDADES,CLIENTE,UBICACION,FECHA,ESTADO,ESCALA,ORDEN,IMPRESO,TIPO_SEG,SECCION) VALUES ('" + caja + "','" + this.CORTE.Text + "','"), this.fg[index, 6]), (object) "','P','"), this.fg[index, 7]), (object) "','"), this.fg[index, 5]), (object) "','00',GETDATE(),'A','"), (object) this.escala), (object) "','"), this.fg[index, 8]), (object) "','"), (object) empresas.usuario), (object) "','0','"), (object) this.seccion), (object) "')"));
          command.CommandText = str;
          command.ExecuteNonQuery();
          if (index == 1)
            this.inicial = caja;
          this.final = caja;
          checked { ++index; }
        }
        sqlTransaction.Commit();
        int num2 = (int) Interaction.MsgBox((object) "Grabacion Exitosa", MsgBoxStyle.Exclamation, (object) "Grabaciones");
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
      DataRow dr = (DataRow) null;
      this.llena_fg(ref dr);
      bool ok;
      this.chequea_upc(dr, ref ok);
      if (ok)
      {
        this.seccion = Module1.get_seccion(this.CORTE.Text);
        this.S1.Visible = false;
      }
      else
      {
        this.setea_fg();
        this.CORTE.Focus();
      }
    }
  }
}
