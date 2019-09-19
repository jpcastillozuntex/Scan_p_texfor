// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas22
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1Cajasf;
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
  public class Cajas22 : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private string seccion;
    private empresas obj;
    private IContainer components;

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
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.corte_KeyDown);
        ComboBox corte1 = this._CORTE;
        if (corte1 != null)
        {
          corte1.KeyPress -= pressEventHandler;
          corte1.KeyDown -= keyEventHandler;
        }
        this._CORTE = value;
        ComboBox corte2 = this._CORTE;
        if (corte2 == null)
          return;
        corte2.KeyPress += pressEventHandler;
        corte2.KeyDown += keyEventHandler;
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
        EventHandler eventHandler = new EventHandler(this.S1_Click_1);
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

    internal virtual Button impre
    {
      get
      {
        return this._impre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.impre_Click);
        Button impre1 = this._impre;
        if (impre1 != null)
          impre1.Click -= eventHandler;
        this._impre = value;
        Button impre2 = this._impre;
        if (impre2 == null)
          return;
        impre2.Click += eventHandler;
      }
    }

    internal virtual CheckBox CheckBox1
    {
      get
      {
        return this._CheckBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.CheckBox1_CheckedChanged);
        CheckBox checkBox1_1 = this._CheckBox1;
        if (checkBox1_1 != null)
          checkBox1_1.CheckedChanged -= eventHandler;
        this._CheckBox1 = value;
        CheckBox checkBox1_2 = this._CheckBox1;
        if (checkBox1_2 == null)
          return;
        checkBox1_2.CheckedChanged += eventHandler;
      }
    }

    public Cajas22()
    {
      this.Load += new EventHandler(this.Cortes_status);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.seccion = "";
      this.obj = new empresas();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas22));
      this.CORTE = new ComboBox();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.S1 = new Button();
      this.impre = new Button();
      this.CheckBox1 = new CheckBox();
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
      this.fg.AllowFiltering = true;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.Location = new Point(11, 66);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(1141, 618);
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
      this.S1.Location = new Point(911, 12);
      this.S1.Name = "S1";
      this.S1.Size = new Size(60, 40);
      this.S1.TabIndex = 95;
      this.S1.TextAlign = ContentAlignment.BottomCenter;
      this.S1.UseVisualStyleBackColor = false;
      this.impre.BackColor = Color.FromArgb(46, 196, 245);
      this.impre.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.impre.ForeColor = Color.Black;
      this.impre.Image = (Image) componentResourceManager.GetObject("impre.Image");
      this.impre.Location = new Point(977, 12);
      this.impre.Name = "impre";
      this.impre.Size = new Size(60, 40);
      this.impre.TabIndex = 129;
      this.impre.TextAlign = ContentAlignment.BottomCenter;
      this.impre.UseVisualStyleBackColor = false;
      this.impre.Visible = false;
      this.CheckBox1.AutoSize = true;
      this.CheckBox1.ForeColor = Color.Black;
      this.CheckBox1.Location = new Point(1080, 40);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(72, 20);
      this.CheckBox1.TabIndex = 130;
      this.CheckBox1.Text = "Todas";
      this.CheckBox1.UseVisualStyleBackColor = true;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1157, 696);
      this.Controls.Add((Control) this.CheckBox1);
      this.Controls.Add((Control) this.S1);
      this.Controls.Add((Control) this.CORTE);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.impre);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas22);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Re-impresion de Etiquetas";
      this.fg.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Cortes_status(object sender, EventArgs e)
    {
      string strsql = "SELECT CORTE FROM CORTES WHERE EXPORTADO  <> 'S' AND CORTE IN (SELECT CORTE FROM CAJAS01) ORDER BY CORTE";
      ComboBox corte = this.CORTE;
      Module1.llena_combos(ref corte, strsql, "CORTE");
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
      this.fg.Enabled = false;
    }

    private void llena_fg()
    {
      int index = 1;
      Module1.llena_tablas(ref this.dt, "SELECT CAJA,CPO,ESTILO,COLOR,TALLA,CAJAS01.CLIENTE,SUM(UNIDADES) AS UNIDADES FROM CAJAS01 LEFT JOIN CORTES ON CAJAS01.CORTE = CORTES.CORTE WHERE CAJAS01.CORTE = '" + this.CORTE.Text + "' GROUP BY CAJA,CPO,ESTILO,COLOR,TALLA,CAJAS01.CLIENTE", ref this.cnn);
      this.fg.Rows.Count = checked (this.dt.Rows.Count + 1);
      try
      {
        foreach (DataRow row in this.dt.Rows)
        {
          this.fg[index, 1] = RuntimeHelpers.GetObjectValue(row["CAJA"]);
          this.fg[index, 2] = RuntimeHelpers.GetObjectValue(row["CPO"]);
          this.fg[index, 3] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          this.fg[index, 4] = RuntimeHelpers.GetObjectValue(row["COLOR"]);
          this.fg[index, 5] = RuntimeHelpers.GetObjectValue(row["CLIENTE"]);
          this.fg[index, 6] = RuntimeHelpers.GetObjectValue(row["TALLA"]);
          this.fg[index, 7] = RuntimeHelpers.GetObjectValue(row["UNIDADES"]);
          this.fg[index, 8] = (object) false;
          checked { ++index; }
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void empresa_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox corte = this.CORTE;
      Module1.AutoCompletar(ref corte, e);
      this.CORTE = corte;
    }

    private void corte_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Delete)
        return;
      e.Handled = true;
    }

    private void impre_Click(object sender, EventArgs e)
    {
      prt prt1 = new prt();
      int num = checked (this.fg.Rows.Count - 1);
      int index1 = 1;
      while (index1 <= num)
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.fg[index1, 8], (object) true, false))
        {
          prt prt2 = prt1;
          C1.Win.C1FlexGrid.C1FlexGrid fg;
          int index2;
          string str = Conversions.ToString((fg = this.fg)[index2 = index1, 1]);
          ref string local = ref str;
          string final = Conversions.ToString(this.fg[index1, 1]);
          string seccion = this.obj.seccion;
          string numero = this.obj.numero;
          string constr = this.obj.constr;
          prt2.imprime_cajas_s(ref local, final, seccion, numero, constr);
          fg[index2, 1] = (object) str;
        }
        checked { ++index1; }
      }
      this.Close();
    }

    private void S1_Click_1(object sender, EventArgs e)
    {
      this.llena_fg();
      this.S1.Visible = false;
      this.impre.Visible = true;
      this.fg.Enabled = true;
      this.CORTE.Enabled = false;
    }

    private void CheckBox1_CheckedChanged(object sender, EventArgs e)
    {
      bool flag = false;
      if (this.CheckBox1.Checked)
        flag = true;
      int num = checked (this.fg.Rows.Count - 1);
      int index = 1;
      while (index <= num)
      {
        this.fg[index, 8] = (object) flag;
        checked { ++index; }
      }
    }
  }
}
