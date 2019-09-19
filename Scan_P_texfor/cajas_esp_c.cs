// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.cajas_esp_c
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
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
  public class cajas_esp_c : Form
  {
    private IContainer components;
    private SqlConnection cnn;
    private DataRow dr;
    private DataTable mt;
    private DataTable dt;
    private string strsql;

    public cajas_esp_c()
    {
      this.Load += new EventHandler(this.cajas_esp_Load);
      this.cnn = new SqlConnection();
      this.mt = new DataTable();
      this.dt = new DataTable();
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (cajas_esp_c));
      this.ToolTip1 = new ToolTip(this.components);
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.fg.BeginInit();
      this.SuspendLayout();
      this.fg.AllowDragging = AllowDraggingEnum.None;
      this.fg.AllowEditing = false;
      this.fg.AllowFiltering = true;
      this.fg.AllowResizing = AllowResizingEnum.None;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.FocusRect = FocusRectEnum.None;
      this.fg.Font = new Font("Tahoma", 9.75f);
      this.fg.ForeColor = Color.Black;
      this.fg.HighLight = HighLightEnum.WithFocus;
      this.fg.KeyActionEnter = KeyActionEnum.MoveAcross;
      this.fg.KeyActionTab = KeyActionEnum.MoveAcross;
      this.fg.Location = new Point(8, 34);
      this.fg.Name = "fg";
      this.fg.Rows.Count = 100;
      this.fg.Rows.DefaultSize = 19;
      this.fg.Size = new Size(1000, 662);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.SubtotalPosition = SubtotalPositionEnum.BelowData;
      this.fg.TabIndex = 76;
      this.AutoScaleBaseSize = new Size(6, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1014, 707);
      this.Controls.Add((Control) this.fg);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (cajas_esp_c);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Utilización de Cajas";
      this.fg.EndInit();
      this.ResumeLayout(false);
    }

    private void cajas_esp_Load(object sender, EventArgs e)
    {
      this.setea_grid();
      this.llena_grid();
    }

    private void llena_grid()
    {
      DataTable dt = new DataTable();
      int index1 = 1;
      Module1.llena_tablas(ref dt, "SELECT * FROM MAT_EST_COL_ES LEFT JOIN MATERIALES ON MAT_EST_COL_ES.CODIGO = MATERIALES.CODIGO ORDER BY ESTILO", ref this.cnn);
      this.fg.Rows.Count = checked (dt.Rows.Count + 1);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          this.fg[index1, 1] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          this.fg[index1, 2] = RuntimeHelpers.GetObjectValue(row["CODIGO"]);
          this.fg[index1, 3] = RuntimeHelpers.GetObjectValue(row["DESCRIPCION"]);
          int index2 = 4;
          do
          {
            this.fg[index1, index2] = RuntimeHelpers.GetObjectValue(row[checked (index2 - 2)]);
            checked { ++index2; }
          }
          while (index2 <= 13);
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

    private void setea_grid()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows[0].Height = 30;
    }
  }
}
