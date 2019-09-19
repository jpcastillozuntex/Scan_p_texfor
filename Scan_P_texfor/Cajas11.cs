// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas11
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
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
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  public class Cajas11 : Form
  {
    private bool ok;
    private SqlConnection cnn;
    private DataTable dt;
    private DataRow dr;
    private string fecha;
    private string fecha1;
    private string path;
    private DataTable pr;
    private IContainer components;

    internal virtual ComboBox seccion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Cajas11()
    {
      this.Load += new EventHandler(this.FPO_Load);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.path = "c:\\reportes\\empacadas.xls";
      this.pr = new DataTable();
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

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

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker fecha_i { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual DateTimePicker fecha_f { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button3
    {
      get
      {
        return this._Button3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button3_Click);
        Button button3_1 = this._Button3;
        if (button3_1 != null)
          button3_1.Click -= eventHandler;
        this._Button3 = value;
        Button button3_2 = this._Button3;
        if (button3_2 == null)
          return;
        button3_2.Click += eventHandler;
      }
    }

    internal virtual Button Button2
    {
      get
      {
        return this._Button2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button button2_1 = this._Button2;
        if (button2_1 != null)
          button2_1.Click -= eventHandler;
        this._Button2 = value;
        Button button2_2 = this._Button2;
        if (button2_2 == null)
          return;
        button2_2.Click += eventHandler;
      }
    }

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

    internal virtual Button CANCELA
    {
      get
      {
        return this._CANCELA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CANCELA_Click);
        Button cancela1 = this._CANCELA;
        if (cancela1 != null)
          cancela1.Click -= eventHandler;
        this._CANCELA = value;
        Button cancela2 = this._CANCELA;
        if (cancela2 == null)
          return;
        cancela2.Click += eventHandler;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas11));
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.ToolTip1 = new ToolTip(this.components);
      this.fecha_i = new DateTimePicker();
      this.fecha_f = new DateTimePicker();
      this.S1 = new Button();
      this.Button3 = new Button();
      this.Button2 = new Button();
      this.CANCELA = new Button();
      this.seccion = new ComboBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.fg.BeginInit();
      this.SuspendLayout();
      this.fg.AllowEditing = false;
      this.fg.AllowFiltering = true;
      this.fg.AllowMerging = AllowMergingEnum.Free;
      this.fg.AllowSorting = AllowSortingEnum.None;
      this.fg.BackColor = Color.White;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.FocusRect = FocusRectEnum.None;
      this.fg.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.fg.ForeColor = Color.Black;
      this.fg.HighLight = HighLightEnum.Never;
      this.fg.Location = new Point(16, 75);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 19;
      this.fg.SelectionMode = SelectionModeEnum.Row;
      this.fg.Size = new Size(976, 605);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.SubtotalPosition = SubtotalPositionEnum.BelowData;
      this.fg.TabIndex = 22;
      this.ToolTip1.SetToolTip((Control) this.fg, "Area de Datos.");
      this.fg.VisualStyle = VisualStyle.Office2007Blue;
      this.fecha_i.CustomFormat = "dd/MM/yyyy";
      this.fecha_i.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.fecha_i.Format = DateTimePickerFormat.Short;
      this.fecha_i.Location = new Point(150, 8);
      this.fecha_i.Name = "fecha_i";
      this.fecha_i.Size = new Size(136, 26);
      this.fecha_i.TabIndex = 8;
      this.ToolTip1.SetToolTip((Control) this.fecha_i, "Fecha de la Produccion");
      this.fecha_f.CustomFormat = "dd/MM/yyyy";
      this.fecha_f.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.fecha_f.Format = DateTimePickerFormat.Short;
      this.fecha_f.Location = new Point(150, 41);
      this.fecha_f.Name = "fecha_f";
      this.fecha_f.Size = new Size(136, 26);
      this.fecha_f.TabIndex = 46;
      this.ToolTip1.SetToolTip((Control) this.fecha_f, "Fecha de la Produccion");
      this.S1.BackColor = Color.FromArgb(46, 196, 245);
      this.S1.FlatStyle = FlatStyle.Popup;
      this.S1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.S1.ForeColor = Color.Black;
      this.S1.Image = (Image) componentResourceManager.GetObject("S1.Image");
      this.S1.Location = new Point(783, 16);
      this.S1.Name = "S1";
      this.S1.Size = new Size(35, 35);
      this.S1.TabIndex = 58;
      this.S1.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.S1, "Chequeo de Datos");
      this.S1.UseVisualStyleBackColor = false;
      this.Button3.BackColor = Color.FromArgb(46, 196, 245);
      this.Button3.FlatStyle = FlatStyle.Popup;
      this.Button3.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button3.ForeColor = Color.Black;
      this.Button3.Image = (Image) componentResourceManager.GetObject("Button3.Image");
      this.Button3.Location = new Point(880, 16);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(35, 35);
      this.Button3.TabIndex = 53;
      this.Button3.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Button3, "Presione este Boton si Desea enviar a Excel  los Datos mostrados en la Pantalla.");
      this.Button3.UseVisualStyleBackColor = false;
      this.Button3.Visible = false;
      this.Button2.BackColor = Color.FromArgb(46, 196, 245);
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.Black;
      this.Button2.Image = (Image) componentResourceManager.GetObject("Button2.Image");
      this.Button2.Location = new Point(824, 16);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(35, 35);
      this.Button2.TabIndex = 52;
      this.Button2.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Button2, "Presione este Boton si Desea Imprimir los Datos mostrados en la Pantalla.");
      this.Button2.UseVisualStyleBackColor = false;
      this.Button2.Visible = false;
      this.CANCELA.BackColor = Color.FromArgb(46, 196, 245);
      this.CANCELA.FlatStyle = FlatStyle.Popup;
      this.CANCELA.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.CANCELA.ForeColor = Color.Black;
      this.CANCELA.Image = (Image) componentResourceManager.GetObject("CANCELA.Image");
      this.CANCELA.Location = new Point(783, 16);
      this.CANCELA.Name = "CANCELA";
      this.CANCELA.Size = new Size(35, 35);
      this.CANCELA.TabIndex = 60;
      this.CANCELA.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.CANCELA, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin Grabar.");
      this.CANCELA.UseVisualStyleBackColor = false;
      this.CANCELA.Visible = false;
      this.seccion.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.seccion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.seccion.Location = new Point(481, 10);
      this.seccion.Name = "seccion";
      this.seccion.Size = new Size(249, 28);
      this.seccion.TabIndex = 95;
      this.ToolTip1.SetToolTip((Control) this.seccion, "No. Sección.");
      this.Label1.BackColor = Color.SteelBlue;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(18, 5);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(120, 32);
      this.Label1.TabIndex = 44;
      this.Label1.Text = "Fecha Inicial:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.BackColor = Color.SteelBlue;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(18, 40);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(120, 32);
      this.Label2.TabIndex = 45;
      this.Label2.Text = "Fecha Final:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(310, 7);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(154, 32);
      this.Label3.TabIndex = 96;
      this.Label3.Text = "Sección:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1002, 696);
      this.Controls.Add((Control) this.seccion);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.S1);
      this.Controls.Add((Control) this.Button3);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.fecha_f);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.fecha_i);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.CANCELA);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas11);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Prendas producidas por Sección";
      this.ToolTip1.SetToolTip((Control) this, " ");
      this.fg.EndInit();
      this.ResumeLayout(false);
    }

    private void FPO_Load(object sender, EventArgs e)
    {
      this.fg.Height = checked (this.Height - 150);
      this.fg.Width = checked (this.Width - 40);
      ComboBox seccion = this.seccion;
      Module1.llena_combos(ref seccion, "SELECT SECCION FROM SECCIONES WHERE SECCION LIKE 'TEXFOR %'", "SECCION");
      this.seccion = seccion;
      this.setea_grid();
      try
      {
        this.seccion.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void setea_grid()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows[0].Height = 30;
    }

    private void llena_grid()
    {
      DataTable dataTable1 = new DataTable();
      string[] con = new string[4];
      DataTable dataTable2 = new DataTable();
      string strSql = "SELECT CONVERT (date,CAJAS04.FECHA) AS FECHA ,CAJAS04.CORTE,CAJAS04.TALLA,CAJAS04.TIPO,CPO,ESTILO,COLOR, ORDEN ,ESCALA, SUM(CAJAS04.UNIDADES) AS UNIDADES FROM CAJAS04 LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA AND CAJAS04.TALLA = CAJAS01.TALLA WHERE CAJAS01.SECCION = '" + this.seccion.Text + "' AND CONVERT(date,CAJAS04.FECHA) BETWEEN '" + this.fecha + "' AND '" + this.fecha1 + "' GROUP BY CONVERT (date,CAJAS04.FECHA)  ,CAJAS04.CORTE,CAJAS04.TALLA,CAJAS04.TIPO,CPO,ESTILO,COLOR,ORDEN,ESCALA";
      Module1.conexiones(ref con);
      int index1 = 0;
      do
      {
        try
        {
          this.dt = new DataTable();
          this.cnn.ConnectionString = con[index1];
          Module1.llena_tablas_e(ref this.dt, strSql, ref this.cnn);
          dataTable2.Merge(this.dt);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index1; }
      }
      while (index1 <= 3);
      try
      {
        foreach (DataRow row in dataTable2.Rows)
        {
          string str1 = Strings.Format(RuntimeHelpers.GetObjectValue(row["FECHA"]), "yyyy-MM-dd");
          string str2 = Conversions.ToString(row["CORTE"]);
          string str3 = Conversions.ToString(row["TIPO"]);
          int integer = Conversions.ToInteger(row["UNIDADES"]);
          string str4 = Conversions.ToString(row["ORDEN"]);
          string str5 = str1 + str2 + str3;
          int index2 = this.fg.FindRow((object) str5, 1, 0, false);
          if (index2 < 0)
          {
            index2 = checked (this.fg.Rows.Count++);
            int index3 = 7;
            do
            {
              this.fg[index2, index3] = (object) 0;
              checked { ++index3; }
            }
            while (index3 <= 17);
            this.fg[index2, 0] = (object) str5;
          }
          this.fg[index2, 1] = RuntimeHelpers.GetObjectValue(row["fecha"]);
          this.fg[index2, 2] = RuntimeHelpers.GetObjectValue(row["CORTE"]);
          this.fg[index2, 3] = RuntimeHelpers.GetObjectValue(row["TIPO"]);
          this.fg[index2, 4] = RuntimeHelpers.GetObjectValue(row["CPO"]);
          this.fg[index2, 5] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          this.fg[index2, 6] = RuntimeHelpers.GetObjectValue(row["COLOR"]);
          this.fg[index2, checked (Conversions.ToInteger(str4) + 7)] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[index2, checked (Conversions.ToInteger(str4) + 7)], (object) integer);
          this.fg[index2, 17] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[index2, 17], (object) integer);
          this.fg[index2, 18] = RuntimeHelpers.GetObjectValue(row["ESCALA"]);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.subtotales();
    }

    private void subtotales()
    {
      C1.Win.C1FlexGrid.C1FlexGrid c1FlexGrid = this.fg;
      int totalOn = 7;
      do
      {
        this.fg.Subtotal(AggregateEnum.Sum, 1, 1, totalOn, "Gran Total -->");
        this.fg.Subtotal(AggregateEnum.Sum, -1, -1, totalOn, "Gran Total -->");
        checked { ++totalOn; }
      }
      while (totalOn <= 17);
      c1FlexGrid = (C1.Win.C1FlexGrid.C1FlexGrid) null;
    }

    private void chequea_fechas(ref bool ok)
    {
      ok = true;
      this.fecha = Strings.Format((object) Conversions.ToDate(this.fecha_i.Text), "yyyy-MM-dd");
      this.fecha1 = Strings.Format((object) Conversions.ToDate(this.fecha_f.Text), "yyyy-MM-dd");
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.fecha1, this.fecha, false) >= 0)
        return;
      this.fecha = this.fecha1;
      ok = false;
      int num = (int) Interaction.MsgBox((object) "Error en las Fechas", MsgBoxStyle.Critical, (object) "Por favor verifique !!");
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.Print_fg();
    }

    private void Print_fg()
    {
      empresas empresas = new empresas();
      Strings.Format((object) DateAndTime.Today, "dd/MM/yyy");
      string str = empresas.nombre + "  Reporte de Prendas Empacadas desde " + Strings.Format((object) Conversions.ToDate(this.fecha_i.Text), "dd/MM/yyyy") + " al " + Strings.Format((object) Conversions.ToDate(this.fecha_f.Text), "dd/MM/yyyy");
      PageSettings defaultPageSettings = this.fg.PrintParameters.PrintDocument.DefaultPageSettings;
      defaultPageSettings.Landscape = true;
      defaultPageSettings.Margins.Left = 20;
      defaultPageSettings.Margins.Right = 50;
      defaultPageSettings.Margins.Top = 80;
      defaultPageSettings.Margins.Bottom = 80;
      this.fg.PrintParameters.HeaderFont = new Font("Arial Narrow", 14f, FontStyle.Bold);
      this.fg.PrintParameters.FooterFont = new Font("Arial Narrow", 12f, FontStyle.Italic);
      this.fg.PrintGrid("Empaque", PrintGridFlags.FitToPageWidth | PrintGridFlags.ShowPrintDialog, str + "\t\tPagina {0}", "");
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      bool si;
      this.datos_excel(ref si);
      if (!si)
        return;
      int num = (int) Interaction.MsgBox((object) ("Sus datos fueron trasladados a Excel en el directorio: " + this.path), MsgBoxStyle.OkOnly, (object) "TRASLADO DE DATOS ");
      this.Close();
    }

    private void datos_excel(ref bool si)
    {
      try
      {
        if (File.Exists(this.path))
          File.Delete(this.path);
        this.fg.Subtotal(AggregateEnum.Clear);
        this.fg.SaveGrid(this.path, FileFormatEnum.Excel, FileFlags.IncludeFixedCells);
        Process.Start(this.path);
        si = true;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "Por favor cierre todas sus Hojas de Excel y vuelva a tratar. Gracias", MsgBoxStyle.OkOnly, (object) "Atencion ");
        si = false;
        ProjectData.ClearProjectError();
      }
    }

    private void S1_Click(object sender, EventArgs e)
    {
      this.chequea_fechas(ref this.ok);
      if (!this.ok)
        return;
      this.setea_grid();
      this.llena_grid();
      this.S1.Visible = false;
      this.CANCELA.Visible = true;
      this.fecha_i.Enabled = false;
      this.fecha_f.Enabled = false;
      this.Button2.Visible = true;
      this.Button3.Visible = true;
    }

    private void CANCELA_Click(object sender, EventArgs e)
    {
      this.CANCELA.Visible = false;
      this.S1.Visible = true;
      this.fecha_i.Enabled = true;
      this.fecha_f.Enabled = true;
      this.Button2.Visible = false;
      this.Button3.Visible = false;
      this.setea_grid();
    }

    private void fg_Click(object sender, EventArgs e)
    {
      int rowSel = this.fg.RowSel;
      if (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.fg[rowSel, 2], (object) "", false))
        return;
      string str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("SELECT * FROM CAJAS04 LEFT JOIN CORTES ON CAJAS04.CORTE = CORTES.CORTE LEFT JOIN CAJAS01 ON CAJAS04.CAJA = CAJAS01.CAJA WHERE CONVERT(date,CAJAS04.FECHA) = '" + Strings.Format(RuntimeHelpers.GetObjectValue(this.fg[rowSel, 1]), "yyyy-MM-dd") + "' AND CAJAS04.CORTE = '"), this.fg[rowSel, 2]), (object) "' AND CAJAS04.TIPO = '"), this.fg[rowSel, 3]), (object) "' AND CAJAS01.SECCION = '"), (object) this.seccion.Text), (object) "'"));
      int num = (int) new Cajas12() { strsql = str }.ShowDialog();
    }
  }
}
