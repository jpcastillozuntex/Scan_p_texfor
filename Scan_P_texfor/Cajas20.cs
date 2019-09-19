// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas20
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
using C1Cajasf;
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
  public class Cajas20 : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataTable co;
    private DataTable pp;
    private DataRow dr;
    private string caja_nueva;
    private string cliente;
    private string escala;
    private int col;
    private DataTable tp;
    private DataRow dj;
    private string ta;
    private string[] ts;
    private empresas obj;
    private string user_sec;
    private Lib_SIF.jap o;
    private IContainer components;

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox corte
    {
      get
      {
        return this._corte;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.corteS_KeyPress);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.cortes_KeyDown);
        ComboBox corte1 = this._corte;
        if (corte1 != null)
        {
          corte1.KeyPress -= pressEventHandler;
          corte1.KeyDown -= keyEventHandler;
        }
        this._corte = value;
        ComboBox corte2 = this._corte;
        if (corte2 == null)
          return;
        corte2.KeyPress += pressEventHandler;
        corte2.KeyDown += keyEventHandler;
      }
    }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label cpo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label estilo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label colo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label t_uni { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox seccion
    {
      get
      {
        return this._seccion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.seccion_KeyPress);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.seccion_KeyDown);
        EventHandler eventHandler = new EventHandler(this.seccion_SelectedIndexChanged);
        ComboBox seccion1 = this._seccion;
        if (seccion1 != null)
        {
          seccion1.KeyPress -= pressEventHandler;
          seccion1.KeyDown -= keyEventHandler;
          seccion1.SelectedIndexChanged -= eventHandler;
        }
        this._seccion = value;
        ComboBox seccion2 = this._seccion;
        if (seccion2 == null)
          return;
        seccion2.KeyPress += pressEventHandler;
        seccion2.KeyDown += keyEventHandler;
        seccion2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label UPC { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label talla { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual CheckBox mixto
    {
      get
      {
        return this._mixto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.mixto_CheckedChanged);
        CheckBox mixto1 = this._mixto;
        if (mixto1 != null)
          mixto1.CheckedChanged -= eventHandler;
        this._mixto = value;
        CheckBox mixto2 = this._mixto;
        if (mixto2 == null)
          return;
        mixto2.CheckedChanged += eventHandler;
      }
    }

    internal virtual CheckBox Automatica
    {
      get
      {
        return this._Automatica;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Automatica_CheckedChanged);
        CheckBox automatica1 = this._Automatica;
        if (automatica1 != null)
          automatica1.CheckedChanged -= eventHandler;
        this._Automatica = value;
        CheckBox automatica2 = this._Automatica;
        if (automatica2 == null)
          return;
        automatica2.CheckedChanged += eventHandler;
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

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid up { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox codigo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label ucaja { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label12 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label imprime { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    public Cajas20()
    {
      this.Load += new EventHandler(this.Cajas05_Load);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.co = new DataTable();
      this.pp = new DataTable();
      this.tp = new DataTable();
      this.ta = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6";
      this.ts = new string[11];
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas20));
      this.ToolTip1 = new ToolTip(this.components);
      this.corte = new ComboBox();
      this.Cancela = new Button();
      this.seccion = new ComboBox();
      this.Button2 = new Button();
      this.si = new Button();
      this.Button1 = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.cpo = new Label();
      this.estilo = new Label();
      this.colo = new Label();
      this.t_uni = new Label();
      this.UPC = new Label();
      this.talla = new Label();
      this.Label10 = new Label();
      this.Label11 = new Label();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.mixto = new CheckBox();
      this.Automatica = new CheckBox();
      this.up = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label6 = new Label();
      this.codigo = new TextBox();
      this.ucaja = new Label();
      this.Label12 = new Label();
      this.imprime = new Label();
      this.fg.BeginInit();
      this.up.BeginInit();
      this.SuspendLayout();
      this.corte.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.corte.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.corte.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.corte.Location = new Point(201, 50);
      this.corte.Name = "corte";
      this.corte.Size = new Size(259, 28);
      this.corte.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.corte, "No. Corte.");
      this.Cancela.BackColor = Color.FromArgb(46, 196, 245);
      this.Cancela.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Cancela.ForeColor = Color.Black;
      this.Cancela.Image = (Image) componentResourceManager.GetObject("Cancela.Image");
      this.Cancela.Location = new Point(977, 19);
      this.Cancela.Name = "Cancela";
      this.Cancela.Size = new Size(60, 40);
      this.Cancela.TabIndex = 104;
      this.Cancela.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Cancela, "Otro Corte");
      this.Cancela.UseVisualStyleBackColor = false;
      this.seccion.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.seccion.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.seccion.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.seccion.Location = new Point(202, 12);
      this.seccion.Name = "seccion";
      this.seccion.Size = new Size(259, 28);
      this.seccion.TabIndex = 117;
      this.ToolTip1.SetToolTip((Control) this.seccion, "No. Sección.");
      this.Button2.BackColor = Color.FromArgb(46, 196, 245);
      this.Button2.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.Black;
      this.Button2.Image = (Image) componentResourceManager.GetObject("Button2.Image");
      this.Button2.Location = new Point(911, 601);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(60, 40);
      this.Button2.TabIndex = 128;
      this.Button2.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Button2, "Imprime la Caja");
      this.Button2.UseVisualStyleBackColor = false;
      this.Button2.Visible = false;
      this.si.BackColor = Color.FromArgb(46, 196, 245);
      this.si.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.si.ForeColor = Color.Black;
      this.si.Image = (Image) componentResourceManager.GetObject("si.Image");
      this.si.Location = new Point(911, 19);
      this.si.Name = "si";
      this.si.Size = new Size(60, 40);
      this.si.TabIndex = 1;
      this.si.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.si, "Elige corte.");
      this.si.UseVisualStyleBackColor = false;
      this.Button1.BackColor = Color.FromArgb(46, 196, 245);
      this.Button1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button1.ForeColor = Color.Black;
      this.Button1.Image = (Image) componentResourceManager.GetObject("Button1.Image");
      this.Button1.Location = new Point(977, 601);
      this.Button1.Name = "Button1";
      this.Button1.Size = new Size(60, 40);
      this.Button1.TabIndex = 135;
      this.Button1.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Button1, "Limpia el contenido de la Caja");
      this.Button1.UseVisualStyleBackColor = false;
      this.fg.AllowEditing = false;
      this.fg.AllowFiltering = true;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.HighLight = HighLightEnum.Never;
      this.fg.Location = new Point(12, 205);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(1048, 97);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(12, 48);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(173, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Corte:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.Label1.BackColor = Color.SteelBlue;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(12, 88);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(173, 32);
      this.Label1.TabIndex = 107;
      this.Label1.Text = "CPO:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.BackColor = Color.SteelBlue;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(12, 125);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(173, 32);
      this.Label2.TabIndex = 108;
      this.Label2.Text = "Estilo:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.BackColor = Color.SteelBlue;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.White;
      this.Label4.Location = new Point(12, 162);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(173, 32);
      this.Label4.TabIndex = 109;
      this.Label4.Text = "Color:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.BackColor = Color.SteelBlue;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.White;
      this.Label5.Location = new Point(12, 9);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(173, 32);
      this.Label5.TabIndex = 110;
      this.Label5.Text = "Seccion:";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.cpo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.cpo.BorderStyle = BorderStyle.Fixed3D;
      this.cpo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.cpo.Location = new Point(201, 88);
      this.cpo.Name = "cpo";
      this.cpo.Size = new Size(258, 32);
      this.cpo.TabIndex = 111;
      this.cpo.Text = " ";
      this.cpo.TextAlign = ContentAlignment.MiddleLeft;
      this.estilo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.estilo.BorderStyle = BorderStyle.Fixed3D;
      this.estilo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.estilo.Location = new Point(202, 125);
      this.estilo.Name = "estilo";
      this.estilo.Size = new Size(258, 32);
      this.estilo.TabIndex = 112;
      this.estilo.Text = " ";
      this.estilo.TextAlign = ContentAlignment.MiddleLeft;
      this.colo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.colo.BorderStyle = BorderStyle.Fixed3D;
      this.colo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.colo.Location = new Point(202, 162);
      this.colo.Name = "colo";
      this.colo.Size = new Size(258, 32);
      this.colo.TabIndex = 113;
      this.colo.Text = " ";
      this.colo.TextAlign = ContentAlignment.MiddleLeft;
      this.t_uni.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.t_uni.BorderStyle = BorderStyle.Fixed3D;
      this.t_uni.Font = new Font("Microsoft Sans Serif", 120f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.t_uni.ForeColor = Color.Black;
      this.t_uni.Location = new Point(468, 314);
      this.t_uni.Name = "t_uni";
      this.t_uni.Size = new Size(592, 264);
      this.t_uni.TabIndex = 115;
      this.t_uni.Text = "0";
      this.t_uni.TextAlign = ContentAlignment.MiddleCenter;
      this.UPC.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.UPC.BorderStyle = BorderStyle.Fixed3D;
      this.UPC.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.UPC.Location = new Point(202, 393);
      this.UPC.Name = "UPC";
      this.UPC.Size = new Size(185, 32);
      this.UPC.TabIndex = 123;
      this.UPC.Text = " ";
      this.UPC.TextAlign = ContentAlignment.MiddleLeft;
      this.talla.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.talla.BorderStyle = BorderStyle.Fixed3D;
      this.talla.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.talla.Location = new Point(201, 356);
      this.talla.Name = "talla";
      this.talla.Size = new Size(185, 32);
      this.talla.TabIndex = 122;
      this.talla.Text = " ";
      this.talla.TextAlign = ContentAlignment.MiddleLeft;
      this.Label10.BackColor = Color.SteelBlue;
      this.Label10.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.White;
      this.Label10.Location = new Point(12, 393);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(173, 32);
      this.Label10.TabIndex = 121;
      this.Label10.Text = "UPC";
      this.Label10.TextAlign = ContentAlignment.MiddleLeft;
      this.Label11.BackColor = Color.SteelBlue;
      this.Label11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.White;
      this.Label11.Location = new Point(12, 356);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(173, 32);
      this.Label11.TabIndex = 120;
      this.Label11.Text = "Talla:";
      this.Label11.TextAlign = ContentAlignment.MiddleLeft;
      this.Label8.BackColor = Color.SteelBlue;
      this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.White;
      this.Label8.Location = new Point(8, 541);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(173, 32);
      this.Label8.TabIndex = 125;
      this.Label8.Text = "Impresión Auto:";
      this.Label8.TextAlign = ContentAlignment.MiddleLeft;
      this.Label9.BackColor = Color.SteelBlue;
      this.Label9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.White;
      this.Label9.Location = new Point(8, 504);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(173, 32);
      this.Label9.TabIndex = 124;
      this.Label9.Text = "Tallas Mixtas:";
      this.Label9.TextAlign = ContentAlignment.MiddleLeft;
      this.mixto.AutoSize = true;
      this.mixto.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.mixto.Location = new Point(220, 512);
      this.mixto.Name = "mixto";
      this.mixto.Size = new Size(15, 14);
      this.mixto.TabIndex = 126;
      this.mixto.UseVisualStyleBackColor = true;
      this.Automatica.AutoSize = true;
      this.Automatica.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.Automatica.Location = new Point(220, 551);
      this.Automatica.Name = "Automatica";
      this.Automatica.Size = new Size(15, 14);
      this.Automatica.TabIndex = (int) sbyte.MaxValue;
      this.Automatica.UseVisualStyleBackColor = true;
      this.up.AllowEditing = false;
      this.up.AllowFiltering = true;
      this.up.ColumnInfo = componentResourceManager.GetString("up.ColumnInfo");
      this.up.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.up.HighLight = HighLightEnum.Never;
      this.up.Location = new Point(3, 471);
      this.up.Name = "up";
      this.up.Rows.Count = 4;
      this.up.Rows.DefaultSize = 21;
      this.up.Size = new Size(1048, 97);
      this.up.StyleInfo = componentResourceManager.GetString("up.StyleInfo");
      this.up.TabIndex = 129;
      this.up.Visible = false;
      this.Label6.BackColor = Color.SteelBlue;
      this.Label6.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label6.ForeColor = Color.White;
      this.Label6.Location = new Point(12, 317);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(173, 32);
      this.Label6.TabIndex = 130;
      this.Label6.Text = "Codigo:";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      this.codigo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.codigo.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.codigo.Location = new Point(201, 319);
      this.codigo.Name = "codigo";
      this.codigo.Size = new Size(185, 29);
      this.codigo.TabIndex = 131;
      this.ucaja.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.ucaja.BorderStyle = BorderStyle.Fixed3D;
      this.ucaja.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.ucaja.Location = new Point(202, 431);
      this.ucaja.Name = "ucaja";
      this.ucaja.Size = new Size(185, 32);
      this.ucaja.TabIndex = 133;
      this.ucaja.Text = " ";
      this.ucaja.TextAlign = ContentAlignment.MiddleLeft;
      this.Label12.BackColor = Color.SteelBlue;
      this.Label12.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label12.ForeColor = Color.White;
      this.Label12.Location = new Point(12, 431);
      this.Label12.Name = "Label12";
      this.Label12.Size = new Size(173, 32);
      this.Label12.TabIndex = 132;
      this.Label12.Text = "U.x Caja:";
      this.Label12.TextAlign = ContentAlignment.MiddleLeft;
      this.imprime.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.imprime.BorderStyle = BorderStyle.Fixed3D;
      this.imprime.Font = new Font("Microsoft Sans Serif", 14.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.imprime.ForeColor = Color.Black;
      this.imprime.Location = new Point(468, 314);
      this.imprime.Name = "imprime";
      this.imprime.Size = new Size(569, 264);
      this.imprime.TabIndex = 134;
      this.imprime.Text = "Imprimiendo Etiqueta.";
      this.imprime.TextAlign = ContentAlignment.MiddleCenter;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1097, 653);
      this.Controls.Add((Control) this.Button1);
      this.Controls.Add((Control) this.ucaja);
      this.Controls.Add((Control) this.Label12);
      this.Controls.Add((Control) this.codigo);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.t_uni);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.Automatica);
      this.Controls.Add((Control) this.mixto);
      this.Controls.Add((Control) this.Label8);
      this.Controls.Add((Control) this.Label9);
      this.Controls.Add((Control) this.UPC);
      this.Controls.Add((Control) this.talla);
      this.Controls.Add((Control) this.Label10);
      this.Controls.Add((Control) this.Label11);
      this.Controls.Add((Control) this.seccion);
      this.Controls.Add((Control) this.colo);
      this.Controls.Add((Control) this.estilo);
      this.Controls.Add((Control) this.cpo);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Cancela);
      this.Controls.Add((Control) this.si);
      this.Controls.Add((Control) this.corte);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.imprime);
      this.Controls.Add((Control) this.up);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas20);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Ingreso de Unidades";
      this.fg.EndInit();
      this.up.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Cajas05_Load(object sender, EventArgs e)
    {
      this.seccion.KeyPress += new KeyPressEventHandler(this.keypressed1);
      this.corte.KeyPress += new KeyPressEventHandler(this.keypressed2);
      this.codigo.KeyPress += new KeyPressEventHandler(this.keypressed3);
      string str = "('" + this.obj.seccion + "')";
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.obj.seccion), "", false) > 0U)
      {
        ComboBox seccion = this.seccion;
        Module1.llena_combos(ref seccion, "SELECT  SECCION FROM SECCIONES WHERE SECCION IN  " + str + " AND ACTIVA = 'S'", "SECCION");
        this.seccion = seccion;
      }
      else
      {
        ComboBox seccion = this.seccion;
        Module1.llena_combos(ref seccion, "SELECT  SECCION FROM SECCIONES WHERE SECCION LIKE 'TEX%' AND ACTIVA = 'S'", "SECCION");
        this.seccion = seccion;
      }
      this.ts = this.ta.Split('|');
      this.limpia_variables();
    }

    private void limpia_variables()
    {
      this.setea_grid();
      this.seccion.Enabled = true;
      this.corte.Enabled = true;
      this.cpo.Text = "";
      this.estilo.Text = "";
      this.colo.Text = "";
      this.talla.Text = "";
      this.UPC.Text = "";
      this.codigo.Text = "";
      this.ucaja.Text = "";
      this.t_uni.Text = "0";
      this.mixto.Checked = false;
      this.Automatica.Checked = true;
      this.UPC.Enabled = false;
      this.mixto.Enabled = false;
      this.codigo.Enabled = false;
      this.si.Visible = true;
      this.seccion.Focus();
    }

    private void habilita()
    {
      this.seccion.Enabled = false;
      this.corte.Enabled = false;
      this.UPC.Enabled = true;
      this.mixto.Enabled = true;
      this.codigo.Enabled = true;
      this.si.Visible = false;
    }

    private void setea_grid()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows.Fixed = 1;
      this.fg.Rows.Count = 3;
      this.fg.Rows[0].Height = 30;
      this.fg.Rows[1].Height = 30;
      this.up.Rows.Count = 1;
      this.up.Rows.Fixed = 1;
      this.up.Rows.Count = 4;
      this.limpia_Grids();
    }

    private void si_Click(object sender, EventArgs e)
    {
      this.llena_corte();
      this.limpia_codigo();
    }

    private void llena_corte()
    {
      Module1.llena_tablas(ref this.co, "SELECT CORTES.*,CPO_D.ESCALA, E_TALLAS.* FROM CORTES LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA WHERE CORTE = '" + this.corte.Text + "'", ref this.cnn);
      if (this.co.Rows.Count > 0)
      {
        this.dr = this.co.Rows[0];
        this.dj = this.dr;
        this.cpo.Text = Conversions.ToString(this.dr["CPO"]);
        this.estilo.Text = Conversions.ToString(this.dr["ESTILO"]);
        this.colo.Text = Conversions.ToString(this.dr["COLOR"]);
        this.seccion.Text = Conversions.ToString(this.dr["SECCION"]);
        this.cliente = Conversions.ToString(this.dr["CLIENTE"]);
        this.escala = Conversions.ToString(this.dr["ESCALA"]);
        this.fg[1, 1] = (object) "Cortado";
      }
      int index = 1;
      do
      {
        this.fg[0, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 24)]);
        this.fg[1, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 5)]);
        this.up[0, index] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 24)]);
        checked { ++index; }
      }
      while (index <= 10);
      Label estilo;
      string text = (estilo = this.estilo).Text;
      bool ok;
      this.llena_empaque(ref text, ref ok);
      estilo.Text = text;
      if (!ok)
        this.limpia_variables();
      this.producido();
      this.busca_upc(ref ok);
      if (ok)
        this.habilita();
      else
        this.limpia_variables();
    }

    private void producido()
    {
      DataTable dt = new DataTable();
      string strSql = "SELECT ORDEN, SUM(CAJAS01.UNIDADES) AS PROD FROM CAJAS01 LEFT JOIN CAJAS04 ON CAJAS01.CAJA = CAJAS04.CAJA AND CAJAS01.TALLA = CAJAS04.TALLA AND CAJAS01.TIPO = CAJAS04.TIPO WHERE CAJAS01.CORTE = '" + this.corte.Text + "' GROUP BY ORDEN";
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          this.fg[2, checked (Conversions.ToInteger(row["ORDEN"]) + 2)] = RuntimeHelpers.GetObjectValue(row["PROD"]);
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void busca_upc(ref bool ok)
    {
      DataTable dt = new DataTable();
      ok = false;
      Module1.llena_tablas(ref dt, "SELECT * FROM UPC WHERE CLIENTE = '" + this.cliente + "' AND ESTILO = '" + this.estilo.Text + "' AND COLOR = '" + this.colo.Text + "'", ref this.cnn);
      if (dt.Rows.Count == 0)
      {
        int num = (int) Interaction.MsgBox((object) "Aún no existen registrados UPC para este CORTE !!!!", MsgBoxStyle.Critical, (object) "Por favor revise.");
      }
      else
      {
        DataRow row = dt.Rows[0];
        int index = 1;
        do
        {
          this.up[1, index] = (object) Strings.Trim(Conversions.ToString(row[checked (index + 4)]));
          checked { ++index; }
        }
        while (index <= 10);
        ok = true;
      }
    }

    private void limpia_codigo()
    {
      this.codigo.Text = "";
      this.codigo.Focus();
    }

    private void llena_empaque(ref string estilo, ref bool ok)
    {
      DataTable dt = new DataTable();
      string strSql = "SELECT * FROM ESTILO_EMP WHERE ESTILO = '" + estilo + "'";
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      if (dt.Rows.Count > 0)
      {
        DataRow row = dt.Rows[0];
        int index = 1;
        do
        {
          try
          {
            this.up[2, index] = RuntimeHelpers.GetObjectValue(row[index]);
          }
          catch (Exception ex)
          {
            ProjectData.SetProjectError(ex);
            ProjectData.ClearProjectError();
          }
          checked { ++index; }
        }
        while (index <= 10);
        ok = true;
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Aún no ha ingresado el Número de unidades por Caja.", MsgBoxStyle.Critical, (object) "Por favor Revise !!!!");
        ok = false;
      }
    }

    private void keypressed1(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.seccion.Text), "", false) > 0U)
        this.corte.Focus();
    }

    private void keypressed2(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.corte.Text), "", false) > 0U)
        this.si.Focus();
    }

    private void keypressed3(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.codigo.Text), "", false) > 0U)
      {
        try
        {
          MyProject.Computer.Audio.Play("c:\\scan\\beep.wav");
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        this.procesa();
      }
    }

    private void procesa()
    {
      if (Decimal.Compare(Conversions.ToDecimal(this.t_uni.Text), Decimal.Zero) == 0)
      {
        this.llena_talla();
        if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.ucaja.Text, "0", false) == 0)
        {
          int num = (int) Interaction.MsgBox((object) ("Upc de Prenda y UPC registerado no coinciden." + this.codigo.Text), MsgBoxStyle.Critical, (object) "Por favor revisar !!!!");
          this.limpia_codigo();
          this.corte.Focus();
          return;
        }
        this.UPC.Text = this.codigo.Text;
        this.mixto.Enabled = false;
        this.Automatica.Enabled = false;
      }
      else if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.codigo.Text, this.UPC.Text, false) > 0U & !this.mixto.Checked)
      {
        int num = (int) Interaction.MsgBox((object) "No puede ingresar distntas tallas en la misma caja.", MsgBoxStyle.Critical, (object) "Por favor revise.");
        this.limpia_codigo();
        return;
      }
      this.suma_unidades();
    }

    private void suma_unidades()
    {
      this.llena_talla();
      this.up[3, this.col] = Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.up[3, this.col], (object) 1);
      this.t_uni.Text = Conversions.ToString(Conversions.ToDouble(this.t_uni.Text) + 1.0);
      if (this.Automatica.Checked && Conversions.ToInteger(this.t_uni.Text) == Conversions.ToInteger(this.ucaja.Text))
        this.imprime_Etiqueta();
      this.limpia_codigo();
    }

    private void llena_talla()
    {
      int index = 1;
      while (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(this.up[1, index], (object) this.codigo.Text, false))
      {
        this.ucaja.Text = "0";
        checked { ++index; }
        if (index > 10)
          return;
      }
      this.talla.Text = Conversions.ToString(this.up[0, index]);
      this.ucaja.Text = Conversions.ToString(this.up[2, index]);
      this.col = index;
    }

    private void imprime_Etiqueta()
    {
      string final = "";
      prt prt = new prt();
      bool ok;
      this.verifica_Tallas(ref ok);
      if (!ok)
        return;
      this.t_uni.Visible = false;
      this.imprime.Visible = true;
      this.graba_datos(ref final, ref ok);
      if (ok)
        ok = prt.imprime_cajas_s(ref final, final, this.obj.seccion, this.obj.numero, this.obj.constr);
      this.otra_caja();
    }

    private void verifica_Tallas(ref bool ok)
    {
      ok = false;
      int index = 1;
      while (!Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.up[3, index], this.fg[2, checked (index + 1)]), this.fg[1, checked (index + 1)], false))
      {
        checked { ++index; }
        if (index > 10)
        {
          ok = true;
          return;
        }
      }
      int num = (int) Interaction.MsgBox((object) ("Está tratando de ingresar " + Conversions.ToString(this.up[3, index]) + " unidades en la talla " + Conversions.ToString(this.fg[0, checked (index + 1)]) + " y solo se cortaron " + Conversions.ToString(this.fg[1, checked (index + 1)])), MsgBoxStyle.Critical, (object) "Por favor revise y corrija.");
    }

    private void otra_caja()
    {
      this.t_uni.Visible = true;
      this.t_uni.Text = "0";
      this.talla.Text = "";
      this.UPC.Text = "";
      this.ucaja.Text = "";
      this.mixto.Enabled = true;
      this.Automatica.Enabled = true;
      this.mixto.Checked = false;
      this.Automatica.Checked = true;
      int index = 1;
      do
      {
        this.up[3, index] = (object) 0;
        checked { ++index; }
      }
      while (index <= 10);
      this.llena_corte();
      this.limpia_codigo();
    }

    private void seccion_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox seccion = this.seccion;
      Module1.AutoCompletar(ref seccion, e);
      this.seccion = seccion;
    }

    private void seccion_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Delete)
        return;
      e.Handled = true;
    }

    private void corteS_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox corte = this.corte;
      Module1.AutoCompletar(ref corte, e);
      this.corte = corte;
    }

    private void cortes_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode != Keys.Delete)
        return;
      e.Handled = true;
    }

    private void Cancela_Click(object sender, EventArgs e)
    {
      this.limpia_variables();
      this.corte.Focus();
    }

    private void graba_datos(ref string caja, ref bool ok)
    {
      empresas empresas = new empresas();
      caja = "";
      this.o.crea_cajas((object) empresas, this.cnn, ref caja);
      ok = false;
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        int index = 1;
        do
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.up[3, index], (object) 0, false))
          {
            string str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO CAJAS01 (CAJA,CORTE,TALLA,TIPO,UNIDADES,CLIENTE,UBICACION,FECHA,ESTADO,ESCALA,ORDEN,IMPRESO,TIPO_SEG,SECCION) VALUES ('" + caja + "','" + this.corte.Text + "','"), this.up[0, index]), (object) "','P','"), this.up[3, index]), (object) "','"), (object) this.cliente), (object) "','00',GETDATE(),'P','"), (object) this.escala), (object) "','"), (object) Conversions.ToString(checked (index - 1))), (object) "','"), (object) empresas.usuario), (object) "','0','"), (object) this.seccion.Text), (object) "')"));
            command.CommandText = str1;
            int num = command.ExecuteNonQuery();
            string str2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO CAJAS04 (CAJA,CORTE,TALLA,TIPO,UNIDADES,FECHA,QUIEN) VALUES ('" + caja + "','" + this.corte.Text + "','"), this.up[0, index]), (object) "','P','"), this.up[3, index]), (object) "',GETDATE(),'"), (object) empresas.usuario), (object) "')"));
            command.CommandText = str2;
            num = command.ExecuteNonQuery();
          }
          checked { ++index; }
        }
        while (index <= 10);
        sqlTransaction.Commit();
        ok = true;
      }
      catch (Exception ex1)
      {
        ProjectData.SetProjectError(ex1);
        try
        {
          sqlTransaction.Rollback();
        }
        catch (SqlException ex2)
        {
          ProjectData.SetProjectError((Exception) ex2);
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.cnn.Close();
      }
      if (ok)
        return;
      int num1 = (int) Interaction.MsgBox((object) "Inconsistencia en Datos", MsgBoxStyle.Critical, (object) "Por favor revise !!!!");
    }

    private void seccion_SelectedIndexChanged(object sender, EventArgs e)
    {
      string strsql = "SELECT CORTE FROM CORTES WHERE CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND SECCION = '" + this.seccion.Text + "' AND TOTAL > 0 AND EXPORTADO <> 'S'";
      ComboBox corte = this.corte;
      Module1.llena_combos(ref corte, strsql, "CORTE");
      this.corte = corte;
    }

    private void Automatica_CheckedChanged(object sender, EventArgs e)
    {
      if (this.Automatica.Checked)
        this.Button2.Visible = false;
      else
        this.Button2.Visible = true;
    }

    private void mixto_CheckedChanged(object sender, EventArgs e)
    {
      this.Automatica.Checked = false;
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.otra_caja();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      this.imprime_Etiqueta();
    }

    private void limpia_Grids()
    {
      int index = 0;
      do
      {
        try
        {
          this.up[0, index] = (object) "";
          this.fg[0, checked (index + 1)] = (object) "";
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { ++index; }
      }
      while (index <= 10);
      this.fg[1, 1] = (object) "Cortado";
      this.fg[2, 1] = (object) "Producido";
    }
  }
}
