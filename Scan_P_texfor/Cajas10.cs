// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas10
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
using Lib_SIF;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  public class Cajas10 : Form
  {
    private string h;
    private bool ok;
    private int si;
    private SqlConnection cnn;
    private DataTable dt;
    private int lineas;
    private string fecha;
    private string fecha1;
    private string corte;
    private string path;
    private empresas obj;
    private string constr;
    private util cnstr;
    private IContainer components;

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg
    {
      get
      {
        return this._fg;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.fg_Click);
        C1.Win.C1FlexGrid.C1FlexGrid fg1 = this._fg;
        if (fg1 != null)
          fg1.Click -= eventHandler;
        this._fg = value;
        C1.Win.C1FlexGrid.C1FlexGrid fg2 = this._fg;
        if (fg2 == null)
          return;
        fg2.Click += eventHandler;
      }
    }

    internal virtual Button excel
    {
      get
      {
        return this._excel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.excel_Click);
        Button excel1 = this._excel;
        if (excel1 != null)
          excel1.Click -= eventHandler;
        this._excel = value;
        Button excel2 = this._excel;
        if (excel2 == null)
          return;
        excel2.Click += eventHandler;
      }
    }

    public Cajas10()
    {
      this.Load += new EventHandler(this.Prod_sec);
      this.h = "#######0.00";
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.path = "c:\\estado_cliente.xls";
      this.obj = new empresas();
      this.constr = this.obj.constr;
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker fecha_i { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Cancela
    {
      get
      {
        return this._Cancela;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CANCELA_Click);
        Button cancela1 = this._Cancela;
        if (cancela1 != null)
          cancela1.Click -= eventHandler;
        this._Cancela = value;
        Button cancela2 = this._Cancela;
        if (cancela2 == null)
          return;
        cancela2.Click += eventHandler;
      }
    }

    internal virtual Button Imprime
    {
      get
      {
        return this._Imprime;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Imprime_Click);
        Button imprime1 = this._Imprime;
        if (imprime1 != null)
          imprime1.Click -= eventHandler;
        this._Imprime = value;
        Button imprime2 = this._Imprime;
        if (imprime2 == null)
          return;
        imprime2.Click += eventHandler;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas10));
      this.ToolTip1 = new ToolTip(this.components);
      this.fecha_i = new DateTimePicker();
      this.Imprime = new Button();
      this.Cancela = new Button();
      this.S1 = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.excel = new Button();
      this.Label1 = new Label();
      this.fg.BeginInit();
      this.SuspendLayout();
      this.fecha_i.CustomFormat = "MM/yyyy";
      this.fecha_i.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.fecha_i.Format = DateTimePickerFormat.Custom;
      this.fecha_i.Location = new Point(72, 9);
      this.fecha_i.Name = "fecha_i";
      this.fecha_i.ShowUpDown = true;
      this.fecha_i.Size = new Size(96, 26);
      this.fecha_i.TabIndex = 61;
      this.ToolTip1.SetToolTip((Control) this.fecha_i, "Mes");
      this.Imprime.BackColor = Color.FromArgb(46, 196, 245);
      this.Imprime.FlatStyle = FlatStyle.Popup;
      this.Imprime.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Imprime.ForeColor = Color.Black;
      this.Imprime.Image = (Image) componentResourceManager.GetObject("Imprime.Image");
      this.Imprime.Location = new Point(632, 8);
      this.Imprime.Name = "Imprime";
      this.Imprime.Size = new Size(35, 35);
      this.Imprime.TabIndex = 69;
      this.Imprime.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Imprime, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.");
      this.Imprime.UseVisualStyleBackColor = false;
      this.Imprime.Visible = false;
      this.Cancela.BackColor = Color.FromArgb(46, 196, 245);
      this.Cancela.FlatStyle = FlatStyle.Popup;
      this.Cancela.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Cancela.ForeColor = Color.Black;
      this.Cancela.Image = (Image) componentResourceManager.GetObject("Cancela.Image");
      this.Cancela.Location = new Point(584, 8);
      this.Cancela.Name = "Cancela";
      this.Cancela.Size = new Size(35, 35);
      this.Cancela.TabIndex = 66;
      this.Cancela.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin Grabar.");
      this.Cancela.UseVisualStyleBackColor = false;
      this.Cancela.Visible = false;
      this.S1.BackColor = Color.FromArgb(46, 196, 245);
      this.S1.FlatStyle = FlatStyle.Popup;
      this.S1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.S1.ForeColor = Color.Black;
      this.S1.Image = (Image) componentResourceManager.GetObject("S1.Image");
      this.S1.Location = new Point(536, 8);
      this.S1.Name = "S1";
      this.S1.Size = new Size(35, 35);
      this.S1.TabIndex = 57;
      this.S1.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.S1, "Chequeo de Datos");
      this.S1.UseVisualStyleBackColor = false;
      this.fg.AllowEditing = false;
      this.fg.AllowMerging = AllowMergingEnum.Free;
      this.fg.AllowSorting = AllowSortingEnum.None;
      this.fg.BackColor = Color.White;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.FocusRect = FocusRectEnum.None;
      this.fg.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.fg.ForeColor = Color.Black;
      this.fg.HighLight = HighLightEnum.Never;
      this.fg.Location = new Point(12, 49);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 19;
      this.fg.SelectionMode = SelectionModeEnum.Row;
      this.fg.Size = new Size(986, 635);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.SubtotalPosition = SubtotalPositionEnum.BelowData;
      this.fg.TabIndex = 70;
      this.ToolTip1.SetToolTip((Control) this.fg, "Area de Datos.");
      this.excel.BackColor = Color.FromArgb(46, 196, 245);
      this.excel.FlatStyle = FlatStyle.Popup;
      this.excel.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.excel.ForeColor = Color.Black;
      this.excel.Image = (Image) componentResourceManager.GetObject("excel.Image");
      this.excel.Location = new Point(679, 8);
      this.excel.Name = "excel";
      this.excel.Size = new Size(35, 35);
      this.excel.TabIndex = 71;
      this.excel.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.excel, "Presione este Boton si Desea  convertir a Excel los datos. ");
      this.excel.UseVisualStyleBackColor = false;
      this.excel.Visible = false;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(16, 8);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(56, 32);
      this.Label1.TabIndex = 62;
      this.Label1.Text = "Mes:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1010, 696);
      this.Controls.Add((Control) this.excel);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.Imprime);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.fecha_i);
      this.Controls.Add((Control) this.Cancela);
      this.Controls.Add((Control) this.S1);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas10);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Produccion Diaria por Seccion";
      this.fg.EndInit();
      this.ResumeLayout(false);
    }

    private void Prod_sec(object sender, EventArgs e)
    {
      this.fg.Height = checked (this.Height - 120);
      this.fg.Width = checked (this.Width - 40);
      this.fg.Rows.Count = 0;
    }

    private void setea_fg()
    {
      this.fg.Clear();
      this.fg.Rows.Count = 1;
      this.fg.Rows.Fixed = 1;
      this.fg.Cols.Fixed = 0;
      this.fg.Cols.Count = 2;
      this.fg.Cols[0].Width = 5;
      this.fg.Rows[0].Height = 30;
      this.fg.Cols[0].Name = "DIA";
      this.fg[0, 0] = (object) this.fg.Cols[0].Name;
      this.fg.Cols[0].Width = 40;
      this.fg.Cols[1].Width = 80;
    }

    private void llena_mes()
    {
      int num = 1;
      do
      {
        try
        {
          string str = Strings.UCase(Strings.Format((object) Conversions.ToDate(Strings.Mid(this.fecha_i.Text, 4) + "-" + Strings.Mid(this.fecha_i.Text, 1, 2) + "-" + Conversions.ToString(num)), "dddd"));
          int index = checked (this.fg.Rows.Count++);
          this.fg[index, 0] = (object) Strings.Format((object) num, "00");
          this.fg[index, 1] = (object) str;
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++num; }
      }
      while (num <= 31);
    }

    private void produccion(SqlConnection cnn)
    {
      string strSql = "SELECT CONVERT (date,FECHA) AS FECHA , SUM(UNIDADES) AS PRENDA, SECCION FROM CAJAS04 LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE WHERE MONTH(FECHA) = '" + Strings.Mid(this.fecha_i.Text, 1, 2) + "' AND YEAR(FECHA) ='" + Strings.Mid(this.fecha_i.Text, 4) + "' AND SECCION LIKE 'TEX%'  GROUP BY SECCION,CONVERT (date,FECHA) ORDER BY SECCION";
      this.dt = new DataTable();
      Module1.llena_tablas_e(ref this.dt, strSql, ref cnn);
      try
      {
        foreach (DataRow row in this.dt.Rows)
        {
          int integer1 = Conversions.ToInteger(Strings.Mid(Strings.Format((object) Conversions.ToDate(row["FECHA"]), "dd/MM/yyyy"), 1, 2));
          string str = Conversions.ToString(row["SECCION"]);
          int integer2 = Conversions.ToInteger(row["PRENDA"]);
          int index = this.fg.Cols.IndexOf(str);
          if (index < 1)
          {
            this.crea_columna(str);
            index = checked (this.fg.Cols.Count - 1);
          }
          this.fg[integer1, index] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[integer1, index], (object) integer2);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void crea_columna(string seccion)
    {
      int index = checked (this.fg.Cols.Count++);
      this.fg.Cols[index].Name = seccion;
      this.fg[0, index] = (object) this.fg.Cols[index].Name;
      this.fg.Cols[index].Width = 90;
      this.fg.Cols[index].DataType = typeof (int);
      this.fg.Cols[index].Format = "####,##0";
      this.fg.Cols[index].TextAlign = TextAlignEnum.RightCenter;
      this.fg.Cols[index].TextAlignFixed = TextAlignEnum.RightCenter;
    }

    private void S1_Click(object sender, EventArgs e)
    {
      this.setea_fg();
      this.llena_mes();
      this.llena_produccion();
      this.S1.Visible = false;
      this.Cancela.Visible = true;
      this.fecha_i.Enabled = false;
      this.Imprime.Visible = true;
      this.excel.Visible = true;
      new empresas().constr = this.constr;
    }

    private void llena_produccion()
    {
      util util = new util();
      int e = 0;
      do
      {
        this.cnn.ConnectionString = util.con_string(e);
        this.produccion(this.cnn);
        checked { ++e; }
      }
      while (e <= 2);
      this.crea_columna("TOTALES");
      this.totales();
    }

    private void totales()
    {
      int index1 = checked (this.fg.Cols.Count - 1);
      int count = this.fg.Rows.Count;
      checked { ++this.fg.Rows.Count; }
      this.fg[count, 1] = (object) "TOTAL MES";
      this.fg.Rows[count].Height = 30;
      int num1 = checked (count - 1);
      int index2 = 1;
      while (index2 <= num1)
      {
        int num2 = checked (index1 - 1);
        int index3 = 2;
        while (index3 <= num2)
        {
          this.fg[index2, index1] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[index2, index1], this.fg[index2, index3]);
          this.fg[count, index3] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[count, index3], this.fg[index2, index3]);
          checked { ++index3; }
        }
        this.fg[count, index1] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[count, index1], this.fg[index2, index1]);
        checked { ++index2; }
      }
      this.fg.Rows[count].Style = this.fg.Styles["amarillo"];
      this.fg.Cols[index1].Style = this.fg.Styles["amarillo"];
    }

    private void CANCELA_Click(object sender, EventArgs e)
    {
      this.Cancela.Visible = false;
      this.excel.Visible = false;
      this.S1.Visible = true;
      this.fecha_i.Enabled = true;
      this.Imprime.Visible = false;
      this.fg.Rows.Count = 0;
    }

    private void Imprime_Click(object sender, EventArgs e)
    {
      this.Print_fg();
    }

    private void Print_fg()
    {
      Strings.Format((object) DateAndTime.Today, "dd/MM/yyyy");
      PageSettings defaultPageSettings = this.fg.PrintParameters.PrintDocument.DefaultPageSettings;
      defaultPageSettings.Landscape = true;
      defaultPageSettings.Margins.Left = 20;
      defaultPageSettings.Margins.Right = 50;
      defaultPageSettings.Margins.Top = 50;
      defaultPageSettings.Margins.Bottom = 50;
      this.fg.PrintParameters.HeaderFont = new Font("Arial Narrow", 14f, FontStyle.Bold);
      this.fg.PrintParameters.FooterFont = new Font("Arial Narrow", 12f, FontStyle.Italic);
      this.fg.PrintGrid("Telas", PrintGridFlags.FitToPageWidth | PrintGridFlags.ShowPrintDialog, "Reporte de prendas producidas. del mes:  " + this.fecha_i.Text + "\t\tPagina {0}", "");
    }

    private void excel_Click(object sender, EventArgs e)
    {
      bool ok;
      Module1.a_excel(this.fg, "c:\\reportes\\prod_diaria_sec.xls", ref ok);
      if (!ok)
        return;
      this.Close();
    }

    private void fg_Click(object sender, EventArgs e)
    {
      string str1 = Conversions.ToString(this.fg[0, this.fg.ColSel]);
      string str2 = Strings.Format((object) this.fecha_i.Value, "yyyy") + "-" + Strings.Format((object) this.fecha_i.Value, "MM") + "-" + Strings.Format((object) Conversions.ToInteger(this.fg[this.fg.RowSel, 0]), "00");
      if (!(this.fg.ColSel > 1 & this.fg.ColSel < this.fg.Cols.Count) || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.fg[this.fg.RowSel, this.fg.ColSel], (object) 0, false))
        return;
      string str3 = "SELECT * FROM CAJAS04 LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE LEFT JOIN CAJAS01 ON CAJAS01.CAJA = CAJAS04.CAJA WHERE CONVERT(date,CAJAS04.FECHA) = '" + str2 + "' AND CAJAS01.SECCION = '" + str1 + "'";
      int num = (int) new Cajas12() { strsql = str3 }.ShowDialog();
    }
  }
}
