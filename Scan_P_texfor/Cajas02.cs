// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas02
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
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
  public class Cajas02 : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataTable co;
    private DataRow dr;
    private string caja_nueva;
    private string cliente;
    private string escala;
    private string tallap;
    private string seccion;
    private empresas obj;
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
          fg1.DoubleClick -= eventHandler;
        this._fg = value;
        C1.Win.C1FlexGrid.C1FlexGrid fg2 = this._fg;
        if (fg2 == null)
          return;
        fg2.DoubleClick += eventHandler;
      }
    }

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

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox cajad
    {
      get
      {
        return this._cajad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.cajad_KeyPress);
        EventHandler eventHandler = new EventHandler(this.cajad_SelectedIndexChanged);
        ComboBox cajad1 = this._cajad;
        if (cajad1 != null)
        {
          cajad1.KeyPress -= pressEventHandler;
          cajad1.SelectedIndexChanged -= eventHandler;
        }
        this._cajad = value;
        ComboBox cajad2 = this._cajad;
        if (cajad2 == null)
          return;
        cajad2.KeyPress += pressEventHandler;
        cajad2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual ComboBox tallad
    {
      get
      {
        return this._tallad;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.talla_KeyPress);
        EventHandler eventHandler = new EventHandler(this.tallad_SelectedIndexChanged);
        ComboBox tallad1 = this._tallad;
        if (tallad1 != null)
        {
          tallad1.KeyPress -= pressEventHandler;
          tallad1.SelectedIndexChanged -= eventHandler;
        }
        this._tallad = value;
        ComboBox tallad2 = this._tallad;
        if (tallad2 == null)
          return;
        tallad2.KeyPress += pressEventHandler;
        tallad2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual GroupBox GroupBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox GroupBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox tipon
    {
      get
      {
        return this._tipon;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.tipon_KeyPress);
        ComboBox tipon1 = this._tipon;
        if (tipon1 != null)
          tipon1.KeyPress -= pressEventHandler;
        this._tipon = value;
        ComboBox tipon2 = this._tipon;
        if (tipon2 == null)
          return;
        tipon2.KeyPress += pressEventHandler;
      }
    }

    internal virtual Label Label8 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label9 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Button sigue
    {
      get
      {
        return this._sigue;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.sigue_Click);
        Button sigue1 = this._sigue;
        if (sigue1 != null)
          sigue1.Click -= eventHandler;
        this._sigue = value;
        Button sigue2 = this._sigue;
        if (sigue2 == null)
          return;
        sigue2.Click += eventHandler;
      }
    }

    internal virtual TextBox unidn
    {
      get
      {
        return this._unidn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.unidn_TextChanged);
        TextBox unidn1 = this._unidn;
        if (unidn1 != null)
          unidn1.TextChanged -= eventHandler;
        this._unidn = value;
        TextBox unidn2 = this._unidn;
        if (unidn2 == null)
          return;
        unidn2.TextChanged += eventHandler;
      }
    }

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

    internal virtual Label unid { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox tipod
    {
      get
      {
        return this._tipod;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.tipod_KeyPress);
        EventHandler eventHandler = new EventHandler(this.tipod_SelectedIndexChanged);
        ComboBox tipod1 = this._tipod;
        if (tipod1 != null)
        {
          tipod1.KeyPress -= pressEventHandler;
          tipod1.SelectedIndexChanged -= eventHandler;
        }
        this._tipod = value;
        ComboBox tipod2 = this._tipod;
        if (tipod2 == null)
          return;
        tipod2.KeyPress += pressEventHandler;
        tipod2.SelectedIndexChanged += eventHandler;
      }
    }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label orden { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label10 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label fechad { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label11 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Cajas02()
    {
      this.Load += new EventHandler(this.Cortes_status);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.co = new DataTable();
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
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas02));
      this.ToolTip1 = new ToolTip(this.components);
      this.corte = new ComboBox();
      this.cajad = new ComboBox();
      this.sigue = new Button();
      this.si = new Button();
      this.Cancela = new Button();
      this.tallad = new ComboBox();
      this.tipon = new ComboBox();
      this.tipod = new ComboBox();
      this.unidn = new TextBox();
      this.graba = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label5 = new Label();
      this.GroupBox1 = new GroupBox();
      this.fechad = new Label();
      this.Label11 = new Label();
      this.orden = new Label();
      this.Label10 = new Label();
      this.Label4 = new Label();
      this.unid = new Label();
      this.GroupBox2 = new GroupBox();
      this.Label8 = new Label();
      this.Label9 = new Label();
      this.Label6 = new Label();
      this.fg.BeginInit();
      this.GroupBox1.SuspendLayout();
      this.GroupBox2.SuspendLayout();
      this.SuspendLayout();
      this.corte.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.corte.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.corte.Location = new Point(223, 19);
      this.corte.Name = "corte";
      this.corte.Size = new Size(189, 28);
      this.corte.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.corte, "No. corte.");
      this.cajad.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.cajad.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cajad.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.cajad.Location = new Point(199, 31);
      this.cajad.Name = "cajad";
      this.cajad.Size = new Size(189, 28);
      this.cajad.TabIndex = 2;
      this.ToolTip1.SetToolTip((Control) this.cajad, " No. de Caja.");
      this.sigue.BackColor = Color.FromArgb(46, 196, 245);
      this.sigue.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.sigue.ForeColor = Color.Black;
      this.sigue.Image = (Image) componentResourceManager.GetObject("sigue.Image");
      this.sigue.Location = new Point(402, 102);
      this.sigue.Name = "sigue";
      this.sigue.Size = new Size(60, 40);
      this.sigue.TabIndex = 7;
      this.sigue.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.sigue, "Chequeo de Datos");
      this.sigue.UseVisualStyleBackColor = false;
      this.si.BackColor = Color.FromArgb(46, 196, 245);
      this.si.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.si.ForeColor = Color.Black;
      this.si.Image = (Image) componentResourceManager.GetObject("si.Image");
      this.si.Location = new Point(857, 19);
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
      this.Cancela.Location = new Point(925, 19);
      this.Cancela.Name = "Cancela";
      this.Cancela.Size = new Size(60, 40);
      this.Cancela.TabIndex = 104;
      this.Cancela.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin Grabar.");
      this.Cancela.UseVisualStyleBackColor = false;
      this.tallad.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.tallad.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tallad.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.tallad.Location = new Point(199, 102);
      this.tallad.Name = "tallad";
      this.tallad.Size = new Size(189, 28);
      this.tallad.TabIndex = 4;
      this.ToolTip1.SetToolTip((Control) this.tallad, "Talla.");
      this.tipon.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.tipon.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tipon.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.tipon.Location = new Point(199, 31);
      this.tipon.Name = "tipon";
      this.tipon.Size = new Size(189, 28);
      this.tipon.TabIndex = 5;
      this.ToolTip1.SetToolTip((Control) this.tipon, "Tipo de Prenda.");
      this.tipod.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.tipod.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.tipod.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.tipod.Location = new Point(199, 66);
      this.tipod.Name = "tipod";
      this.tipod.Size = new Size(189, 28);
      this.tipod.TabIndex = 3;
      this.ToolTip1.SetToolTip((Control) this.tipod, "Tipo de Prenda.");
      this.unidn.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.unidn.Font = new Font("Microsoft Sans Serif", 12f);
      this.unidn.Location = new Point(199, 67);
      this.unidn.MaxLength = 20;
      this.unidn.Name = "unidn";
      this.unidn.Size = new Size(189, 26);
      this.unidn.TabIndex = 6;
      this.unidn.TextAlign = HorizontalAlignment.Right;
      this.graba.BackColor = Color.FromArgb(46, 196, 245);
      this.graba.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.graba.ForeColor = Color.Black;
      this.graba.Image = (Image) componentResourceManager.GetObject("graba.Image");
      this.graba.Location = new Point(857, 19);
      this.graba.Name = "graba";
      this.graba.Size = new Size(60, 40);
      this.graba.TabIndex = 9;
      this.graba.TextAlign = ContentAlignment.BottomCenter;
      this.graba.UseVisualStyleBackColor = false;
      this.fg.AllowEditing = false;
      this.fg.AllowFiltering = true;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.HighLight = HighLightEnum.Never;
      this.fg.Location = new Point(23, 326);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(962, 335);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(29, 16);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(173, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Corte:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.Label1.BackColor = Color.SteelBlue;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(6, 31);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(173, 28);
      this.Label1.TabIndex = 95;
      this.Label1.Text = "Caja:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.BackColor = Color.SteelBlue;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(6, 102);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(173, 28);
      this.Label2.TabIndex = 96;
      this.Label2.Text = "Talla:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.BackColor = Color.SteelBlue;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.White;
      this.Label5.Location = new Point(6, 173);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(173, 28);
      this.Label5.TabIndex = 98;
      this.Label5.Text = "Unidades:";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.GroupBox1.BackColor = Color.Gainsboro;
      this.GroupBox1.Controls.Add((Control) this.fechad);
      this.GroupBox1.Controls.Add((Control) this.Label11);
      this.GroupBox1.Controls.Add((Control) this.orden);
      this.GroupBox1.Controls.Add((Control) this.Label10);
      this.GroupBox1.Controls.Add((Control) this.tipod);
      this.GroupBox1.Controls.Add((Control) this.Label4);
      this.GroupBox1.Controls.Add((Control) this.unid);
      this.GroupBox1.Controls.Add((Control) this.Label1);
      this.GroupBox1.Controls.Add((Control) this.tallad);
      this.GroupBox1.Controls.Add((Control) this.Label2);
      this.GroupBox1.Controls.Add((Control) this.cajad);
      this.GroupBox1.Controls.Add((Control) this.Label5);
      this.GroupBox1.ForeColor = Color.Black;
      this.GroupBox1.Location = new Point(24, 73);
      this.GroupBox1.Name = "GroupBox1";
      this.GroupBox1.Size = new Size(468, 247);
      this.GroupBox1.TabIndex = 101;
      this.GroupBox1.TabStop = false;
      this.GroupBox1.Text = "Caja Donante";
      this.fechad.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.fechad.BorderStyle = BorderStyle.Fixed3D;
      this.fechad.Font = new Font("Microsoft Sans Serif", 12f);
      this.fechad.Location = new Point(196, 208);
      this.fechad.Name = "fechad";
      this.fechad.Size = new Size(189, 28);
      this.fechad.TabIndex = 105;
      this.fechad.TextAlign = ContentAlignment.MiddleCenter;
      this.Label11.BackColor = Color.SteelBlue;
      this.Label11.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label11.ForeColor = Color.White;
      this.Label11.Location = new Point(6, 208);
      this.Label11.Name = "Label11";
      this.Label11.Size = new Size(173, 28);
      this.Label11.TabIndex = 104;
      this.Label11.Text = "Fecha:";
      this.Label11.TextAlign = ContentAlignment.MiddleLeft;
      this.orden.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.orden.BorderStyle = BorderStyle.Fixed3D;
      this.orden.Font = new Font("Microsoft Sans Serif", 12f);
      this.orden.Location = new Point(196, 138);
      this.orden.Name = "orden";
      this.orden.Size = new Size(189, 28);
      this.orden.TabIndex = 103;
      this.orden.Text = "0";
      this.orden.TextAlign = ContentAlignment.MiddleRight;
      this.Label10.BackColor = Color.SteelBlue;
      this.Label10.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label10.ForeColor = Color.White;
      this.Label10.Location = new Point(6, 138);
      this.Label10.Name = "Label10";
      this.Label10.Size = new Size(173, 28);
      this.Label10.TabIndex = 102;
      this.Label10.Text = "Orden";
      this.Label10.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.BackColor = Color.SteelBlue;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.White;
      this.Label4.Location = new Point(6, 66);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(173, 28);
      this.Label4.TabIndex = 101;
      this.Label4.Text = "Tipo:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.unid.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.unid.BorderStyle = BorderStyle.Fixed3D;
      this.unid.Font = new Font("Microsoft Sans Serif", 12f);
      this.unid.Location = new Point(196, 173);
      this.unid.Name = "unid";
      this.unid.Size = new Size(189, 28);
      this.unid.TabIndex = 99;
      this.unid.Text = "0";
      this.unid.TextAlign = ContentAlignment.MiddleRight;
      this.GroupBox2.BackColor = Color.Gainsboro;
      this.GroupBox2.Controls.Add((Control) this.unidn);
      this.GroupBox2.Controls.Add((Control) this.sigue);
      this.GroupBox2.Controls.Add((Control) this.tipon);
      this.GroupBox2.Controls.Add((Control) this.Label8);
      this.GroupBox2.Controls.Add((Control) this.Label9);
      this.GroupBox2.ForeColor = Color.Black;
      this.GroupBox2.Location = new Point(517, 73);
      this.GroupBox2.Name = "GroupBox2";
      this.GroupBox2.Size = new Size(468, 247);
      this.GroupBox2.TabIndex = 102;
      this.GroupBox2.TabStop = false;
      this.GroupBox2.Text = "Nueva Caja";
      this.Label8.BackColor = Color.SteelBlue;
      this.Label8.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label8.ForeColor = Color.White;
      this.Label8.Location = new Point(6, 31);
      this.Label8.Name = "Label8";
      this.Label8.Size = new Size(173, 28);
      this.Label8.TabIndex = 97;
      this.Label8.Text = "Tipo:";
      this.Label8.TextAlign = ContentAlignment.MiddleLeft;
      this.Label9.BackColor = Color.SteelBlue;
      this.Label9.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label9.ForeColor = Color.White;
      this.Label9.Location = new Point(6, 67);
      this.Label9.Name = "Label9";
      this.Label9.Size = new Size(173, 28);
      this.Label9.TabIndex = 98;
      this.Label9.Text = "Unidades:";
      this.Label9.TextAlign = ContentAlignment.MiddleLeft;
      this.Label6.Location = new Point(24, 664);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(385, 18);
      this.Label6.TabIndex = 105;
      this.Label6.Text = "Double click elimina línea.";
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1007, 696);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.Cancela);
      this.Controls.Add((Control) this.GroupBox2);
      this.Controls.Add((Control) this.GroupBox1);
      this.Controls.Add((Control) this.corte);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.si);
      this.Controls.Add((Control) this.graba);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas02);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Empaque Segundas";
      this.fg.EndInit();
      this.GroupBox1.ResumeLayout(false);
      this.GroupBox2.ResumeLayout(false);
      this.GroupBox2.PerformLayout();
      this.ResumeLayout(false);
    }

    private void Cortes_status(object sender, EventArgs e)
    {
      this.corte.KeyPress += new KeyPressEventHandler(this.keypressed1);
      this.cajad.KeyPress += new KeyPressEventHandler(this.keypressed2);
      this.tipod.KeyPress += new KeyPressEventHandler(this.keypressed2_1);
      this.tallad.KeyPress += new KeyPressEventHandler(this.keypressed3);
      this.tipon.KeyPress += new KeyPressEventHandler(this.keypressed4);
      this.unidn.KeyPress += new KeyPressEventHandler(this.keypressed5);
      ComboBox tipon = this.tipon;
      Module1.llena_combos(ref tipon, "SELECT * FROM TIPOS_PRENDA", "TIPO_PRENDA");
      this.tipon = tipon;
      try
      {
        this.tipon.Items.Remove((object) "Primeras");
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.corte.SelectedIndex = 0;
        this.tipon.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.limpia_variables();
    }

    private void limpia_variables()
    {
      this.setea_fg();
      this.corte.Enabled = true;
      this.cajad.Items.Clear();
      this.tallad.Items.Clear();
      this.unid.Text = "0";
      this.unidn.Text = "0";
      this.orden.Text = "0";
      this.fechad.Text = "";
      this.si.Visible = true;
      this.graba.Visible = false;
      this.cajad.Enabled = false;
      this.tallad.Enabled = false;
      this.unid.Enabled = false;
      this.tipon.Enabled = false;
      this.unidn.Enabled = false;
      this.corte.Focus();
    }

    private void habilita()
    {
      this.si.Visible = false;
      this.graba.Visible = true;
      this.corte.Enabled = false;
      this.cajad.Enabled = true;
      this.tallad.Enabled = true;
      this.unid.Enabled = true;
      this.tipon.Enabled = true;
      this.unidn.Enabled = true;
      try
      {
        this.tipon.SelectedIndex = 0;
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
      this.cajad.Focus();
    }

    private void setea_fg()
    {
      string str = "('" + this.obj.seccion + "')";
      this.fg.Rows.Count = 1;
      this.fg.Rows.Fixed = 1;
      this.fg.Rows[0].Height = 30;
      ComboBox corte = this.corte;
      Module1.llena_combos(ref corte, "SELECT DISTINCT CORTE FROM CAJAS01 WHERE ESTADO IN ('A','P') AND SECCION IN " + str + " ORDER BY CORTE", "CORTE");
      this.corte = corte;
    }

    private void si_Click(object sender, EventArgs e)
    {
      this.llena_corte();
      this.seccion = Module1.get_seccion(this.corte.Text);
    }

    private void llena_corte()
    {
      Module1.llena_tablas(ref this.co, "SELECT CAJAS01.*, CAJAS04.FECHA AS FECHAD FROM CAJAS04 LEFT JOIN CAJAS01 ON CAJAS01.CAJA = CAJAS04.CAJA WHERE CAJAS04.CORTE = '" + this.corte.Text + "'", ref this.cnn);
      ComboBox cajad = this.cajad;
      Module1.llena_combos(ref cajad, "SELECT DISTINCT CAJA FROM CAJAS04 WHERE CORTE = '" + this.corte.Text + "' AND UNIDADES > 0 ORDER BY CAJA", "CAJA");
      this.cajad = cajad;
      if (this.co.Rows.Count > 0)
      {
        this.dr = this.co.Rows[0];
        this.cliente = Conversions.ToString(this.dr["CLIENTE"]);
        this.escala = Conversions.ToString(this.dr["ESCALA"]);
        this.tallap = Conversions.ToString(this.dr["ORDEN"]);
      }
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

    private void keypressed2(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.cajad.Text), "", false) > 0U)
        this.tipod.Focus();
    }

    private void keypressed2_1(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.tipod.Text), "", false) > 0U)
        this.tallad.Focus();
    }

    private void keypressed3(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      Label unid = this.unid;
      ref DataTable local1 = ref this.co;
      string text1 = this.cajad.Text;
      string text2 = this.tipod.Text;
      string text3 = this.tallad.Text;
      Label orden;
      string text4 = (orden = this.orden).Text;
      ref string local2 = ref text4;
      Label fechad;
      string text5 = (fechad = this.fechad).Text;
      ref string local3 = ref text5;
      int num = cajas_01.saldo_caja(ref local1, text1, text2, text3, ref local2, ref local3);
      fechad.Text = text5;
      orden.Text = text4;
      string str = Conversions.ToString(num);
      unid.Text = str;
      this.tipon.Focus();
    }

    private void keypressed4(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.tipon.Text), "", false) > 0U)
        this.unidn.Focus();
    }

    private void keypressed5(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.unidn.Text), "", false) > 0U)
        this.sigue.Focus();
    }

    private void graba_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, (object) "Actualizacion de Datos !!!") != MsgBoxResult.Yes)
        return;
      if (this.fg.Rows.Count > 1)
      {
        if (Module1.revisa_datos(this.fg, 4))
        {
          this.graba_datos();
          this.imprime_etiquetas();
          this.Close();
        }
        else
          this.Close();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "Aún no ha ingresado unidades a la nueva Caja", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
      }
    }

    private void imprime_etiquetas()
    {
      prt prt = new prt();
      int length = this.caja_nueva.Length;
      int Start = 1;
      while (Start <= length)
      {
        try
        {
          string inicial = Strings.Mid(this.caja_nueva, Start, 10);
          prt.imprime_cajas_s(ref inicial, inicial, this.obj.seccion, this.obj.numero, this.obj.constr);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
        checked { Start += 10; }
      }
    }

    private void corteS_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox corte = this.corte;
      Module1.AutoCompletar(ref corte, e);
      this.corte = corte;
    }

    private void cajad_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox cajad = this.cajad;
      Module1.AutoCompletar(ref cajad, e);
      this.cajad = cajad;
    }

    private void tipod_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox tipod = this.tipod;
      Module1.AutoCompletar(ref tipod, e);
      this.tipod = tipod;
    }

    private void tipon_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox tipon = this.tipon;
      Module1.AutoCompletar(ref tipon, e);
      this.tipon = tipon;
    }

    private void talla_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox tallad = this.tallad;
      Module1.AutoCompletar(ref tallad, e);
      this.tallad = tallad;
    }

    private void cajad_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox tipod = this.tipod;
      Module1.llena_combos(ref tipod, "SELECT DISTINCT TIPO FROM CAJAS01 WHERE CAJA = '" + this.cajad.Text + "' ORDER BY TIPO", "TIPO");
      this.tipod = tipod;
      ComboBox tallad = this.tallad;
      Module1.llena_combos(ref tallad, "SELECT DISTINCT TALLA FROM CAJAS01 WHERE CAJA = '" + this.cajad.Text + "' ORDER BY TALLA", "TALLA");
      this.tallad = tallad;
    }

    private void tallad_SelectedIndexChanged(object sender, EventArgs e)
    {
      Label unid = this.unid;
      ref DataTable local1 = ref this.co;
      string text1 = this.cajad.Text;
      string text2 = this.tipod.Text;
      string text3 = this.tallad.Text;
      Label orden;
      string text4 = (orden = this.orden).Text;
      ref string local2 = ref text4;
      Label fechad;
      string text5 = (fechad = this.fechad).Text;
      ref string local3 = ref text5;
      int num = cajas_01.saldo_caja(ref local1, text1, text2, text3, ref local2, ref local3);
      fechad.Text = text5;
      orden.Text = text4;
      string str = Conversions.ToString(num);
      unid.Text = str;
    }

    private void unidn_TextChanged(object sender, EventArgs e)
    {
      int selectionStart = this.unidn.SelectionStart;
      int num1 = 0;
      string str = "";
      int num2 = checked (this.unidn.Text.Length - 1);
      int index = 0;
      while (index <= num2)
      {
        if ("0123456789".IndexOf(this.unidn.Text[index]) != -1)
          str += Conversions.ToString(this.unidn.Text[index]);
        else if (index < selectionStart)
          checked { ++num1; }
        checked { ++index; }
      }
      this.unidn.Text = str;
      this.unidn.SelectionStart = checked (selectionStart - num1);
    }

    private void sigue_Click(object sender, EventArgs e)
    {
      if (Decimal.Compare(Conversions.ToDecimal(this.unidn.Text), Decimal.Zero) == 0)
      {
        int num1 = (int) Interaction.MsgBox((object) "El número de unidades no puede ser 0. ", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
      }
      else if (Decimal.Compare(Conversions.ToDecimal(this.unidn.Text), Conversions.ToDecimal(this.unid.Text)) > 0)
      {
        int num2 = (int) Interaction.MsgBox((object) ("El número Maximo de unidades a trasladar es de " + Strings.Trim(this.unid.Text)), MsgBoxStyle.Critical, (object) "Por favor revise !!!");
      }
      else
      {
        bool ok;
        this.agrega_fg(ref ok);
        if (!ok)
        {
          int num3 = (int) Interaction.MsgBox((object) "No pueden haber dos registros dentro una misma Caja con Talla y Tipo de Segunda repetidos.", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
        }
        else
        {
          ref DataTable local1 = ref this.co;
          string text1 = this.cajad.Text;
          string text2 = this.tipod.Text;
          string text3 = this.tallad.Text;
          int integer1 = Conversions.ToInteger(this.unidn.Text);
          Label orden;
          int integer2 = Conversions.ToInteger((orden = this.orden).Text);
          ref int local2 = ref integer2;
          Label unid;
          int integer3 = Conversions.ToInteger((unid = this.unid).Text);
          ref int local3 = ref integer3;
          int num4 = cajas_01.modifica_caja(ref local1, text1, text2, text3, integer1, ref local2, ref local3) ? 1 : 0;
          unid.Text = Conversions.ToString(integer3);
          orden.Text = Conversions.ToString(integer2);
          bool flag = num4 != 0;
          this.unidn.Text = Conversions.ToString(0);
          this.cajad.Focus();
        }
      }
    }

    private void agrega_fg(ref bool ok)
    {
      ok = true;
      if (this.fg.FindRow((object) (this.cajad.Text + this.tallad.Text + this.tipon.Text), 1, 0, false) > -1)
      {
        ok = false;
      }
      else
      {
        int index = checked (this.fg.Rows.Count++);
        this.fg[index, 0] = (object) (this.cajad.Text + this.tallad.Text + this.tipon.Text);
        this.fg[index, 1] = (object) this.cajad.Text;
        this.fg[index, 2] = (object) this.tipod.Text;
        this.fg[index, 3] = (object) this.tallad.Text;
        this.fg[index, 4] = (object) this.unid.Text;
        this.fg[index, 5] = (object) this.tipon.Text;
        this.fg[index, 6] = (object) this.unidn.Text;
        this.fg[index, 7] = (object) this.orden.Text;
        this.fg[index, 8] = (object) this.fechad.Text;
      }
    }

    private void tipod_SelectedIndexChanged(object sender, EventArgs e)
    {
      ComboBox tallad = this.tallad;
      Module1.llena_combos(ref tallad, "SELECT DISTINCT TALLA FROM CAJAS01 WHERE CAJA = '" + this.cajad.Text + "' AND TIPO = '" + this.tipod.Text + "' ORDER BY TALLA", "TALLA");
      this.tallad = tallad;
    }

    private void Cancela_Click(object sender, EventArgs e)
    {
      this.limpia_variables();
      this.corte.Focus();
    }

    private void fg_Click(object sender, EventArgs e)
    {
      this.elimina_linea();
    }

    private void elimina_linea()
    {
      int rowSel = this.fg.RowSel;
      ref DataTable local1 = ref this.co;
      string caja = Conversions.ToString(this.fg[rowSel, 1]);
      string tipo = Conversions.ToString(this.fg[rowSel, 2]);
      string talla = Conversions.ToString(this.fg[rowSel, 3]);
      int integer1 = Conversions.ToInteger(Microsoft.VisualBasic.CompilerServices.Operators.MultiplyObject(this.fg[rowSel, 6], (object) -1));
      Label orden;
      int integer2 = Conversions.ToInteger((orden = this.orden).Text);
      ref int local2 = ref integer2;
      Label unid;
      int integer3 = Conversions.ToInteger((unid = this.unid).Text);
      ref int local3 = ref integer3;
      int num = cajas_01.modifica_caja(ref local1, caja, tipo, talla, integer1, ref local2, ref local3) ? 1 : 0;
      unid.Text = Conversions.ToString(integer3);
      orden.Text = Conversions.ToString(integer2);
      bool flag = num != 0;
      this.fg.Rows.Remove(rowSel);
      this.unidn.Text = Conversions.ToString(0);
      this.cajad.Focus();
    }

    private void graba_datos()
    {
      string str1 = "";
      empresas empresas = new empresas();
      Lib_SIF.jap jap = new Lib_SIF.jap();
      string Style = "0000000";
      string String2 = "38";
      string caja = "";
      jap.crea_cajas((object) empresas, this.cnn, ref caja);
      this.caja_nueva = caja;
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
          Strings.Format(RuntimeHelpers.GetObjectValue(this.fg[index, 8]), "yyyy-MM-dd HH:mm:ss");
          int num2 = checked (this.tipon.Items.IndexOf(RuntimeHelpers.GetObjectValue(this.fg[index, 5])) + 1);
          string String1 = Conversions.ToString(num2);
          string str2 = num2 != 0 ? (Strings.InStr(String1, String2, CompareMethod.Binary) <= 0 ? "S" : "T") : "P";
          string str3 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE CAJAS01 SET UNIDADES = UNIDADES + '", this.fg[index, 6]), (object) "' WHERE CAJA = '"), (object) caja), (object) "' AND CORTE = '"), (object) this.corte.Text), (object) "' AND TALLA = '"), this.fg[index, 3]), (object) "' AND TIPO = '"), (object) str2), (object) "'"));
          command.CommandText = str3;
          int num3 = command.ExecuteNonQuery();
          string str4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE CAJAS04 SET UNIDADES = UNIDADES + '", this.fg[index, 6]), (object) "' WHERE CAJA = '"), (object) caja), (object) "' AND CORTE = '"), (object) this.corte.Text), (object) "' AND TALLA = '"), this.fg[index, 3]), (object) "' AND TIPO = '"), (object) str2), (object) "'"));
          command.CommandText = str4;
          if (command.ExecuteNonQuery() == 0)
          {
            string str5 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO CAJAS01 (CAJA,CORTE,TALLA,TIPO,UNIDADES,CLIENTE,UBICACION,FECHA,ESTADO,ESCALA,ORDEN,IMPRESO,TIPO_SEG,SECCION) VALUES ('" + caja + "','" + this.corte.Text + "','"), this.fg[index, 3]), (object) "','"), (object) str2), (object) "','"), this.fg[index, 6]), (object) "','"), (object) this.cliente), (object) "','00','"), this.fg[index, 8]), (object) "','P','"), (object) this.escala), (object) "','"), this.fg[index, 7]), (object) "','"), (object) empresas.usuario), (object) "','"), (object) num2), (object) "','"), (object) this.seccion), (object) "')"));
            command.CommandText = str5;
            int num4 = command.ExecuteNonQuery();
            try
            {
              string str6 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO CAJAS04 (CAJA,CORTE,TALLA,TIPO,UNIDADES,FECHA ,QUIEN) VALUES ( '" + caja + "','" + this.corte.Text + "','"), this.fg[index, 3]), (object) "','"), (object) str2), (object) "','"), this.fg[index, 6]), (object) "','"), this.fg[index, 8]), (object) "','"), (object) empresas.usuario), (object) "')"));
              command.CommandText = str6;
              num3 = checked (num4 + command.ExecuteNonQuery());
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          string str7 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE CAJAS01 SET UNIDADES = UNIDADES - '", this.fg[index, 6]), (object) "' WHERE CAJA = '"), this.fg[index, 1]), (object) "' AND CORTE = '"), (object) this.corte.Text), (object) "' AND TALLA = '"), this.fg[index, 3]), (object) "' AND TIPO = '"), this.fg[index, 2]), (object) "'"));
          command.CommandText = str7;
          num3 = command.ExecuteNonQuery();
          string str8 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE CAJAS04 SET UNIDADES = UNIDADES - '", this.fg[index, 6]), (object) "' WHERE CAJA = '"), this.fg[index, 1]), (object) "' AND CORTE = '"), (object) this.corte.Text), (object) "' AND TALLA = '"), this.fg[index, 3]), (object) "' AND TIPO = '"), this.fg[index, 2]), (object) "'"));
          command.CommandText = str8;
          num3 = command.ExecuteNonQuery();
          int num5;
          string str9 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "INSERT INTO CAJAS03 (TIPO,CAJA_D,CORTE_D,TALLA_D,TIPO_D,CAJA_A,CORTE_A,TALLA_A,TIPO_A,TIPO_SEG,UNIDADES,FECHA,QUIEN,ORDEN) VALUES ('S','", this.fg[index, 1]), (object) "','"), (object) this.corte.Text), (object) "','"), this.fg[index, 3]), (object) "','"), this.fg[index, 2]), (object) "','"), (object) (str1 + Strings.Format((object) checked (num5 + 1), Style))), (object) "','"), (object) this.corte.Text), (object) "','"), this.fg[index, 3]), (object) "','"), (object) str2), (object) "','"), (object) num2), (object) "','"), this.fg[index, 6]), (object) "',GETDATE(),'"), (object) empresas.usuario), (object) "','"), this.fg[index, 7]), (object) "')"));
          command.CommandText = str9;
          num3 = command.ExecuteNonQuery();
          if (Strings.InStr(Conversions.ToString(this.fg[index, 1]), this.caja_nueva, CompareMethod.Binary) == 0)
            this.caja_nueva = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) this.caja_nueva, this.fg[index, 1]));
          checked { ++index; }
        }
        sqlTransaction.Commit();
        int num6 = (int) Interaction.MsgBox((object) "Grabacion Exitosa", MsgBoxStyle.Exclamation, (object) "Grabaciones");
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

    private ComboBox talla()
    {
      throw new NotImplementedException();
    }
  }
}
