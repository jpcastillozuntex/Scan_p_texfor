// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas12
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
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
  public class Cajas12 : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataRow dr;
    public string strsql;
    private string[] con;
    private DataTable pr;
    private IContainer components;

    public Cajas12()
    {
      this.Load += new EventHandler(this.FPO_Load);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.con = new string[4];
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
          fg1.AfterFilter -= eventHandler;
        this._fg = value;
        C1.Win.C1FlexGrid.C1FlexGrid fg2 = this._fg;
        if (fg2 == null)
          return;
        fg2.AfterFilter += eventHandler;
      }
    }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas12));
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.ToolTip1 = new ToolTip(this.components);
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
      this.fg.Location = new Point(12, 21);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 19;
      this.fg.SelectionMode = SelectionModeEnum.Row;
      this.fg.Size = new Size(991, 659);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.SubtotalPosition = SubtotalPositionEnum.BelowData;
      this.fg.TabIndex = 22;
      this.ToolTip1.SetToolTip((Control) this.fg, "Area de Datos.");
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1015, 696);
      this.Controls.Add((Control) this.fg);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas12);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Prendas producidas por Sección";
      this.ToolTip1.SetToolTip((Control) this, " ");
      this.fg.EndInit();
      this.ResumeLayout(false);
    }

    private void FPO_Load(object sender, EventArgs e)
    {
      this.setea_grid();
      this.llena_grid();
    }

    private void setea_grid()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows[0].Height = 30;
    }

    private void llena_grid()
    {
      int index1 = 1;
      Module1.conexiones(ref this.con);
      int index2 = 0;
      do
      {
        try
        {
          this.dt = new DataTable();
          this.cnn.ConnectionString = this.con[index2];
          Module1.llena_tablas_e(ref this.dt, this.strsql, ref this.cnn);
          this.pr.Merge(this.dt);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index2; }
      }
      while (index2 <= 2);
      this.fg.Rows.Count = checked (this.pr.Rows.Count + 1);
      try
      {
        foreach (DataRow row in this.pr.Rows)
        {
          this.fg[index1, 1] = RuntimeHelpers.GetObjectValue(row["CAJA"]);
          this.fg[index1, 2] = RuntimeHelpers.GetObjectValue(row["CORTE"]);
          this.fg[index1, 3] = RuntimeHelpers.GetObjectValue(row["CPO"]);
          this.fg[index1, 4] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          this.fg[index1, 5] = RuntimeHelpers.GetObjectValue(row["COLOR"]);
          this.fg[index1, 6] = RuntimeHelpers.GetObjectValue(row["TIPO"]);
          this.fg[index1, 7] = RuntimeHelpers.GetObjectValue(row["TALLA"]);
          this.fg[index1, 8] = RuntimeHelpers.GetObjectValue(row["UNIDADES"]);
          this.fg[index1, 9] = RuntimeHelpers.GetObjectValue(row["FECHA"]);
          checked { ++index1; }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.sub_total();
    }

    private void sub_total()
    {
      this.fg.Subtotal(AggregateEnum.Sum, 0, 0, 8, "Gran Total -->");
    }

    private void fg_Click(object sender, EventArgs e)
    {
      this.sub_total();
    }
  }
}
