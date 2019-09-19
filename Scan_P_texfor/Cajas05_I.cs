// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas05_I
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
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  public class Cajas05_I : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataTable co;
    private DataTable pp;
    private DataRow dr;
    private string caja_nueva;
    private string cliente;
    private string escala;
    private DataTable tp;
    private DataRow dj;
    private string ta;
    private string[] ts;
    private DateTime fecha;
    private IContainer components;

    internal virtual ComboBox corte
    {
      get
      {
        return this._corte;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.corteS_KeyPress);
        ComboBox corte1 = this._corte;
        if (corte1 != null)
          corte1.KeyPress -= pressEventHandler;
        this._corte = value;
        ComboBox corte2 = this._corte;
        if (corte2 == null)
          return;
        corte2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button si
    {
      get
      {
        return this._si;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.si_Click);
        Button si1 = this._si;
        if (si1 != null)
          si1.Click -= eventHandler;
        this._si = value;
        Button si2 = this._si;
        if (si2 == null)
          return;
        si2.Click += eventHandler;
      }
    }

    internal virtual Button Cancela
    {
      get
      {
        return this._Cancela;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Cancela_Click);
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

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid pr { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label cpo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label estilo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label colo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label seccion { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label tcortado { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label tprod { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid tt { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button Button1
    {
      get
      {
        return this._Button1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
        Button button1_1 = this._Button1;
        if (button1_1 != null)
          button1_1.Click -= eventHandler;
        this._Button1 = value;
        Button button1_2 = this._Button1;
        if (button1_2 == null)
          return;
        button1_2.Click += eventHandler;
      }
    }

    internal virtual Button G1
    {
      get
      {
        return this._G1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.G1_Click);
        Button g1_1 = this._G1;
        if (g1_1 != null)
          g1_1.Click -= eventHandler;
        this._G1 = value;
        Button g1_2 = this._G1;
        if (g1_2 == null)
          return;
        g1_2.Click += eventHandler;
      }
    }

    internal virtual Label fecha_d { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Cajas05_I()
    {
      this.Load += new EventHandler(this.Cajas05_Load);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.co = new DataTable();
      this.pp = new DataTable();
      this.tp = new DataTable();
      this.ta = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6";
      this.ts = new string[11];
      this.fecha = DateAndTime.Today;
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas05_I));
      this.ToolTip1 = new ToolTip(this.components);
      this.corte = new ComboBox();
      this.si = new Button();
      this.Cancela = new Button();
      this.G1 = new Button();
      this.Label3 = new Label();
      this.pr = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.cpo = new Label();
      this.estilo = new Label();
      this.colo = new Label();
      this.seccion = new Label();
      this.tcortado = new Label();
      this.tprod = new Label();
      this.Label6 = new Label();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.tt = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Button1 = new Button();
      this.fecha_d = new Label();
      this.pr.BeginInit();
      this.fg.BeginInit();
      this.tt.BeginInit();
      this.SuspendLayout();
      this.corte.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.corte.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.corte.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.corte.Location = new Point(201, 21);
      this.corte.Name = "corte";
      this.corte.Size = new Size(189, 28);
      this.corte.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.corte, "No. Corte");
      this.si.BackColor = Color.FromArgb(46, 196, 245);
      this.si.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.si.ForeColor = Color.Black;
      this.si.Image = (Image) componentResourceManager.GetObject("si.Image");
      this.si.Location = new Point(911, 11);
      this.si.Name = "si";
      this.si.Size = new Size(60, 40);
      this.si.TabIndex = 1;
      this.si.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.si, "Chequeo de Datos");
      this.si.UseVisualStyleBackColor = false;
      this.Cancela.BackColor = Color.FromArgb(46, 196, 245);
      this.Cancela.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Cancela.ForeColor = Color.Black;
      this.Cancela.Image = (Image) componentResourceManager.GetObject("Cancela.Image");
      this.Cancela.Location = new Point(977, 11);
      this.Cancela.Name = "Cancela";
      this.Cancela.Size = new Size(60, 40);
      this.Cancela.TabIndex = 104;
      this.Cancela.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin Grabar.");
      this.Cancela.UseVisualStyleBackColor = false;
      this.G1.BackColor = Color.FromArgb(46, 196, 245);
      this.G1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.G1.ForeColor = Color.Black;
      this.G1.Image = (Image) componentResourceManager.GetObject("G1.Image");
      this.G1.Location = new Point(911, 12);
      this.G1.Name = "G1";
      this.G1.Size = new Size(60, 40);
      this.G1.TabIndex = 124;
      this.G1.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.G1, "Actualiza la BAse de Datos.");
      this.G1.UseVisualStyleBackColor = false;
      this.G1.Visible = false;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(12, 19);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(173, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Corte:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.pr.ColumnInfo = componentResourceManager.GetString("pr.ColumnInfo");
      this.pr.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.pr.HighLight = HighLightEnum.Never;
      this.pr.KeyActionEnter = KeyActionEnum.MoveAcross;
      this.pr.KeyActionTab = KeyActionEnum.MoveDown;
      this.pr.Location = new Point(12, 305);
      this.pr.Name = "pr";
      this.pr.Rows.DefaultSize = 21;
      this.pr.Size = new Size(1048, 334);
      this.pr.StyleInfo = componentResourceManager.GetString("pr.StyleInfo");
      this.pr.TabIndex = 106;
      this.Label1.BackColor = Color.SteelBlue;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(12, 56);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(173, 32);
      this.Label1.TabIndex = 107;
      this.Label1.Text = "CPO:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.BackColor = Color.SteelBlue;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(12, 93);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(173, 32);
      this.Label2.TabIndex = 108;
      this.Label2.Text = "Estilo:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.BackColor = Color.SteelBlue;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.White;
      this.Label4.Location = new Point(12, 130);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(173, 32);
      this.Label4.TabIndex = 109;
      this.Label4.Text = "Color:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.BackColor = Color.SteelBlue;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.White;
      this.Label5.Location = new Point(633, 61);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(173, 32);
      this.Label5.TabIndex = 110;
      this.Label5.Text = "Seccion:";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.cpo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.cpo.BorderStyle = BorderStyle.Fixed3D;
      this.cpo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.cpo.Location = new Point(201, 56);
      this.cpo.Name = "cpo";
      this.cpo.Size = new Size(352, 32);
      this.cpo.TabIndex = 111;
      this.cpo.Text = " ";
      this.cpo.TextAlign = ContentAlignment.MiddleLeft;
      this.estilo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.estilo.BorderStyle = BorderStyle.Fixed3D;
      this.estilo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.estilo.Location = new Point(202, 93);
      this.estilo.Name = "estilo";
      this.estilo.Size = new Size(352, 32);
      this.estilo.TabIndex = 112;
      this.estilo.Text = " ";
      this.estilo.TextAlign = ContentAlignment.MiddleLeft;
      this.colo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.colo.BorderStyle = BorderStyle.Fixed3D;
      this.colo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.colo.Location = new Point(202, 130);
      this.colo.Name = "colo";
      this.colo.Size = new Size(352, 32);
      this.colo.TabIndex = 113;
      this.colo.Text = " ";
      this.colo.TextAlign = ContentAlignment.MiddleLeft;
      this.seccion.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.seccion.BorderStyle = BorderStyle.Fixed3D;
      this.seccion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.seccion.Location = new Point(826, 61);
      this.seccion.Name = "seccion";
      this.seccion.Size = new Size(211, 32);
      this.seccion.TabIndex = 114;
      this.seccion.Text = " ";
      this.seccion.TextAlign = ContentAlignment.MiddleLeft;
      this.tcortado.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.tcortado.BorderStyle = BorderStyle.Fixed3D;
      this.tcortado.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.tcortado.Location = new Point(849, 246);
      this.tcortado.Name = "tcortado";
      this.tcortado.Size = new Size(188, 45);
      this.tcortado.TabIndex = 115;
      this.tcortado.Text = " ";
      this.tcortado.TextAlign = ContentAlignment.MiddleRight;
      this.tprod.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.tprod.BorderStyle = BorderStyle.Fixed3D;
      this.tprod.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.tprod.Location = new Point(849, 668);
      this.tprod.Name = "tprod";
      this.tprod.Size = new Size(188, 45);
      this.tprod.TabIndex = 116;
      this.tprod.Text = " ";
      this.tprod.TextAlign = ContentAlignment.MiddleRight;
      this.Label6.BackColor = Color.SteelBlue;
      this.Label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.White;
      this.Label6.Location = new Point(633, 99);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(173, 32);
      this.Label6.TabIndex = 117;
      this.Label6.Text = "F. Producción:";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      this.fg.AllowEditing = false;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.HighLight = HighLightEnum.Never;
      this.fg.Location = new Point(12, 170);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(1048, 76);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.tt.AllowEditing = false;
      this.tt.BackColor = Color.SteelBlue;
      this.tt.ColumnInfo = componentResourceManager.GetString("tt.ColumnInfo");
      this.tt.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.tt.ForeColor = Color.White;
      this.tt.HighLight = HighLightEnum.Never;
      this.tt.Location = new Point(12, 641);
      this.tt.Name = "tt";
      this.tt.Rows.Count = 1;
      this.tt.Rows.DefaultSize = 21;
      this.tt.Rows.Fixed = 0;
      this.tt.ScrollBars = ScrollBars.None;
      this.tt.Size = new Size(1048, 24);
      this.tt.StyleInfo = componentResourceManager.GetString("tt.StyleInfo");
      this.tt.TabIndex = 122;
      this.Button1.BackColor = Color.FromArgb(46, 196, 245);
      this.Button1.Font = new Font("Comic Sans MS", 18f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.Black;
      this.Button1.Location = new Point(911, 12);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(60, 40);
      this.Button1.TabIndex = 123;
      this.Button1.Text = "C";
      this.Button1.UseVisualStyleBackColor = false;
      this.fecha_d.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.fecha_d.BorderStyle = BorderStyle.Fixed3D;
      this.fecha_d.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.fecha_d.Location = new Point(826, 99);
      this.fecha_d.Name = "fecha_d";
      this.fecha_d.Size = new Size(211, 32);
      this.fecha_d.TabIndex = 125;
      this.fecha_d.Text = " ";
      this.fecha_d.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1097, 727);
      this.Controls.Add((Control) this.fecha_d);
      this.Controls.Add((Control) this.tt);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.tprod);
      this.Controls.Add((Control) this.tcortado);
      this.Controls.Add((Control) this.seccion);
      this.Controls.Add((Control) this.colo);
      this.Controls.Add((Control) this.estilo);
      this.Controls.Add((Control) this.cpo);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.pr);
      this.Controls.Add((Control) this.Cancela);
      this.Controls.Add((Control) this.si);
      this.Controls.Add((Control) this.corte);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.G1);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas05_I);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ingreso de Producción";
      this.pr.EndInit();
      this.fg.EndInit();
      this.tt.EndInit();
      this.ResumeLayout(false);
    }

    private void Cajas05_Load(object sender, EventArgs e)
    {
      this.corte.KeyPress += new KeyPressEventHandler(this.keypressed1);
      this.fecha_d.Text = Strings.Format((object) this.fecha, "dd/MM/yyyy");
      ComboBox corte = this.corte;
      Module1.llena_combos(ref corte, "SELECT  DISTINCT CORTES.CORTE FROM CORTES WHERE CORTES.CORTE  NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND EXPORTADO <> 'S' AND TOTAL > 0 AND CORTE NOT IN (SELECT DISTINCT CORTE FROM CAJAS06)", "CORTE");
      this.corte = corte;
      Module1.llena_tablas(ref this.tp, "SELECT * FROM TIPOS_PRENDA", ref this.cnn);
      try
      {
        this.corte.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.ts = this.ta.Split('|');
      this.limpia_variables();
    }

    private void limpia_variables()
    {
      this.setea_grid();
      this.corte.Enabled = true;
      this.cpo.Text = "";
      this.estilo.Text = "";
      this.colo.Text = "";
      this.seccion.Text = "";
      this.tcortado.Text = "0";
      this.tprod.Text = "0";
      this.si.Visible = true;
      this.borra_totales();
      this.corte.Focus();
    }

    private void habilita()
    {
      this.si.Visible = false;
      this.corte.Enabled = false;
    }

    private void setea_grid()
    {
      int index1 = 1;
      this.fg.Rows.Count = 2;
      this.fg.Rows.Fixed = 1;
      this.fg.Rows[0].Height = 30;
      this.fg.Rows[1].Height = 30;
      this.pr.Rows.Count = 1;
      this.pr.Rows[0].Height = 30;
      this.pr.Rows.Count = checked (this.tp.Rows.Count + 2);
      int num = checked (this.tp.Rows.Count - 1);
      int index2 = 0;
      while (index2 <= num)
      {
        DataRow row = this.tp.Rows[index2];
        this.pr[checked (index2 + 1), 0] = RuntimeHelpers.GetObjectValue(row["CODIGO"]);
        this.pr[checked (index2 + 1), 1] = RuntimeHelpers.GetObjectValue(row["TIPO_PRENDA"]);
        checked { ++index1; }
        checked { ++index2; }
      }
      this.pr[index1, 1] = (object) "Vales";
    }

    private void si_Click(object sender, EventArgs e)
    {
      this.llena_corte();
    }

    private void llena_corte()
    {
      string Left = "";
      Module1.llena_tablas(ref this.co, "SELECT CORTES.*,CPO_D.ESCALA, E_TALLAS.* FROM CORTES LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTE = '" + this.corte.Text + "'", ref this.cnn);
      if (this.co.Rows.Count > 0)
      {
        this.dr = this.co.Rows[0];
        this.dj = this.dr;
        this.cpo.Text = Conversions.ToString(this.dr["CPO"]);
        this.estilo.Text = Conversions.ToString(this.dr["ESTILO"]);
        this.colo.Text = Conversions.ToString(this.dr["COLOR"]);
        this.seccion.Text = Conversions.ToString(this.dr["SECCION"]);
        this.tcortado.Text = Conversions.ToString(this.dr["TOTAL"]);
        this.cliente = Conversions.ToString(this.dr["CLIENTE"]);
        Left = Conversions.ToString(this.dr["ESCALA"]);
        this.fg[1, 1] = (object) "Cortado";
      }
      int index = 1;
      do
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "00", false) == 0)
          this.dj[checked (index + 24)] = (object) this.ts[index];
        this.fg[0, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 24)]);
        this.fg[1, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 5)]);
        this.pr[0, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 24)]);
        checked { ++index; }
      }
      while (index <= 10);
      this.llena_vales();
      this.habilita();
    }

    private void keypressed1(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.corte.Text), "", false) > 0U)
        this.si.Focus();
    }

    private void corteS_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox corte = this.corte;
      Module1.AutoCompletar(ref corte, e);
      this.corte = corte;
    }

    private void sigue_Click(object sender, EventArgs e)
    {
    }

    private void Cancela_Click(object sender, EventArgs e)
    {
      this.limpia_variables();
      this.corte.Focus();
    }

    private void revisa_corte(ref bool ok)
    {
      DataTable dt = new DataTable();
      ok = false;
      DateTime DateValue;
      string strSql = "SELECT * FROM CAJAS04 WHERE FECHA BETWEEN '" + Strings.Format((object) DateAndTime.DateAdd(DateInterval.Day, -3.0, DateValue), "yyyy-MM-dd") + "' AND '" + Strings.Format((object) DateAndTime.Today, "yyyy-MM-dd") + "'";
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      if (dt.Rows.Count > 0)
      {
        ok = true;
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Fechas del Corte no concuerdan !!!!", MsgBoxStyle.Critical, (object) "Por favor revise.");
      }
    }

    private void graba_datos()
    {
      string str1 = "";
      empresas empresas = new empresas();
      if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empresas.numero, "1", false) == 0)
        str1 = "JTF";
      else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(empresas.numero, "3", false) == 0)
        str1 = "ZUF";
      string str2 = Strings.Format((object) DateAndTime.Today, "yyyy-MM-dd");
      int[] numArray1 = new int[10];
      int[] numArray2 = new int[10];
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        string str3 = "INSERT INTO CAJAS06 (CORTE,FECHA,PRENDAS) VALUES ( '" + this.corte.Text + "','" + str2 + "','" + this.tprod.Text + "')";
        command.CommandText = str3;
        command.ExecuteNonQuery();
        sqlTransaction.Commit();
        int num = (int) Interaction.MsgBox((object) "Grabacion Exitosa", MsgBoxStyle.Exclamation, (object) "Grabaciones");
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

    private void Button1_Click(object sender, EventArgs e)
    {
      this.borra_totales();
      this.llena_vales();
      bool ok;
      this.calcula_totales(ref ok);
      if (!ok)
        return;
      this.pr.Enabled = false;
      this.Button1.Visible = false;
      this.G1.Visible = true;
    }

    private void borra_totales()
    {
      this.tt[0, 1] = (object) "TOTALES";
      int index = 2;
      do
      {
        this.tt[0, index] = (object) 0;
        checked { ++index; }
      }
      while (index <= 11);
    }

    private void borra_vales()
    {
      int index = 2;
      do
      {
        this.pr[14, index] = (object) "";
        checked { ++index; }
      }
      while (index <= 11);
    }

    private void llena_vales()
    {
      DataTable dt = new DataTable();
      this.borra_vales();
      Module1.llena_tablas(ref dt, "SELECT * FROM CORTES_V WHERE CORTE = '" + this.corte.Text + "'", ref this.cnn);
      IEnumerator enumerator;
      try
      {
        enumerator = dt.Rows.GetEnumerator();
label_4:
        if (!enumerator.MoveNext())
          return;
        DataRow current = (DataRow) enumerator.Current;
        int index = 1;
        do
        {
          this.pr[14, checked (index + 1)] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.pr[14, checked (index + 1)], Microsoft.VisualBasic.CompilerServices.Operators.AddObject(current[index], current[checked (index + 10)]));
          checked { ++index; }
        }
        while (index <= 10);
        goto label_4;
      }
      finally
      {
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void calcula_totales(ref bool ok)
    {
      ok = true;
      this.tprod.Text = Conversions.ToString(0);
      int index1 = 1;
      do
      {
        int index2 = 2;
        do
        {
          this.tt[0, index2] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.tt[0, index2], this.pr[index1, index2]);
          this.tprod.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.tprod.Text, this.pr[index1, index2]));
          checked { ++index2; }
        }
        while (index2 <= 11);
        checked { ++index1; }
      }
      while (index1 <= 14);
      int index3 = 2;
      do
      {
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.fg[1, index3], this.tt[0, index3], false))
        {
          int num = (int) Interaction.MsgBox(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) "Diferencia en la talla ", this.fg[0, index3]), MsgBoxStyle.Critical, (object) "Revise y corrija.");
          ok = false;
        }
        checked { ++index3; }
      }
      while (index3 <= 11);
    }

    private void G1_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, (object) "Actualizacion de Datos !!!") != MsgBoxResult.Yes || this.fg.Rows.Count <= 1)
        return;
      bool ok;
      this.revisa_corte(ref ok);
      if (ok)
      {
        this.graba_datos();
        this.Close();
      }
    }
  }
}
