// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.menu
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

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
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  public class menu : Form
  {
    private bool HasConnected;
    private string empresa;
    private string nombre;
    private DataTable dt;
    private SqlConnection cnn;
    private int contador;
    private bool bien;
    private string tipo;
    private string usua;
    public DateTime dia_hoy;
    private object retval;
    private string menus;
    private string empres;
    private MenuItem men;
    private int a;
    private int l;
    private empresas obj;
    private util cs;
    private string usuario;
    private string ip;
    private int i1;
    private int i2;
    private DateTime hoy;
    private IContainer components;

    internal virtual PictureBox foto { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual PictureBox PictureBox3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual MenuStrip menudo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public menu()
    {
      this.Load += new EventHandler(this.Menu_Load);
      this.HasConnected = false;
      this.cnn = new SqlConnection();
      this.usua = "TEVOC";
      this.dia_hoy = DateAndTime.Today;
      this.men = new MenuItem();
      this.a = checked (Screen.PrimaryScreen.Bounds.Height - 50);
      this.l = checked (Screen.PrimaryScreen.Bounds.Width - 5);
      this.cs = new util();
      this.hoy = DateAndTime.Today;
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual PictureBox PictureBox2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox TextBox1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox grupo1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ListBox Empre
    {
      get
      {
        return this._Empre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Empre_SelectedIndexChanged);
        ListBox empre1 = this._Empre;
        if (empre1 != null)
          empre1.SelectedIndexChanged -= eventHandler;
        this._Empre = value;
        ListBox empre2 = this._Empre;
        if (empre2 == null)
          return;
        empre2.SelectedIndexChanged += eventHandler;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (menu));
      this.TextBox1 = new TextBox();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.grupo1 = new GroupBox();
      this.PictureBox2 = new PictureBox();
      this.ToolTip1 = new ToolTip(this.components);
      this.Empre = new ListBox();
      this.foto = new PictureBox();
      this.PictureBox3 = new PictureBox();
      this.menudo = new MenuStrip();
      this.grupo1.SuspendLayout();
      ((ISupportInitialize) this.PictureBox2).BeginInit();
      ((ISupportInitialize) this.foto).BeginInit();
      ((ISupportInitialize) this.PictureBox3).BeginInit();
      this.SuspendLayout();
      this.TextBox1.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 192);
      this.TextBox1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.TextBox1.ForeColor = Color.Black;
      this.TextBox1.Location = new Point(152, 64);
      this.TextBox1.Name = "TextBox1";
      this.TextBox1.PasswordChar = '*';
      this.TextBox1.Size = new Size((int) byte.MaxValue, 26);
      this.TextBox1.TabIndex = 4;
      this.ToolTip1.SetToolTip((Control) this.TextBox1, "Por favor ingrese la palabra Clave que le asigno el Adminstrador del Sistema.   Sin esa palabra no podrá accesar .");
      this.Label1.Font = new Font("Microsoft Sans Serif", 11.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.Location = new Point(142, 32);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(265, 32);
      this.Label1.TabIndex = 5;
      this.Label1.Text = "Por favor Ingrese su Password:";
      this.Label1.TextAlign = ContentAlignment.BottomCenter;
      this.Label2.BackColor = Color.FromArgb(222, 236, 237);
      this.Label2.Font = new Font("Microsoft Sans Serif", 21.75f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.FromArgb(36, 47, 106);
      this.Label2.Location = new Point(6, 44);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(208, 40);
      this.Label2.TabIndex = 6;
      this.Label3.Font = new Font("Microsoft Sans Serif", 20.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.FromArgb(36, 47, 106);
      this.Label3.Location = new Point(288, 624);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(472, 64);
      this.Label3.TabIndex = 8;
      this.Label3.TextAlign = ContentAlignment.MiddleCenter;
      this.ToolTip1.SetToolTip((Control) this.Label3, "Nombre del Usuario");
      this.grupo1.BackColor = Color.FromArgb(164, 197, 223);
      this.grupo1.Controls.Add((Control) this.PictureBox2);
      this.grupo1.Controls.Add((Control) this.Label1);
      this.grupo1.Controls.Add((Control) this.TextBox1);
      this.grupo1.FlatStyle = FlatStyle.Flat;
      this.grupo1.ForeColor = Color.Black;
      this.grupo1.Location = new Point(288, 488);
      this.grupo1.Name = "grupo1";
      this.grupo1.Size = new Size(472, 128);
      this.grupo1.TabIndex = 9;
      this.grupo1.TabStop = false;
      this.grupo1.Text = "Password";
      this.PictureBox2.Location = new Point(72, 32);
      this.PictureBox2.Name = "PictureBox2";
      this.PictureBox2.Size = new Size(64, 56);
      this.PictureBox2.TabIndex = 3;
      this.PictureBox2.TabStop = false;
      this.Empre.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Empre.ItemHeight = 20;
      this.Empre.Items.AddRange(new object[3]
      {
        (object) "1.- JT. TRADING",
        (object) "2.- TRECENTO",
        (object) "3.- ZUNTEX"
      });
      this.Empre.Location = new Point(876, 43);
      this.Empre.Name = "Empre";
      this.Empre.Size = new Size(154, 24);
      this.Empre.TabIndex = 10;
      this.Empre.Visible = false;
      this.foto.BackColor = Color.FromArgb(222, 236, 237);
      this.foto.Location = new Point(825, 524);
      this.foto.Name = "foto";
      this.foto.Size = new Size(128, 123);
      this.foto.SizeMode = PictureBoxSizeMode.Zoom;
      this.foto.TabIndex = 12;
      this.foto.TabStop = false;
      this.foto.Visible = false;
      this.PictureBox3.BackColor = Color.FromArgb(222, 236, 237);
      this.PictureBox3.ErrorImage = (Image) componentResourceManager.GetObject("PictureBox3.ErrorImage");
      this.PictureBox3.Image = (Image) componentResourceManager.GetObject("PictureBox3.Image");
      this.PictureBox3.InitialImage = (Image) componentResourceManager.GetObject("PictureBox3.InitialImage");
      this.PictureBox3.Location = new Point(433, 84);
      this.PictureBox3.Name = "PictureBox3";
      this.PictureBox3.Size = new Size(405, 366);
      this.PictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox3.TabIndex = 13;
      this.PictureBox3.TabStop = false;
      this.PictureBox3.Visible = false;
      this.menudo.AutoSize = false;
      this.menudo.BackColor = Color.DarkCyan;
      this.menudo.Font = new Font("Verdana", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.menudo.Location = new Point(0, 0);
      this.menudo.Name = "menudo";
      this.menudo.Size = new Size(1362, 40);
      this.menudo.Stretch = false;
      this.menudo.TabIndex = 14;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1362, 681);
      this.Controls.Add((Control) this.menudo);
      this.Controls.Add((Control) this.PictureBox3);
      this.Controls.Add((Control) this.foto);
      this.Controls.Add((Control) this.grupo1);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Empre);
      this.ForeColor = Color.Black;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.Name = nameof (menu);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.WindowState = FormWindowState.Maximized;
      this.grupo1.ResumeLayout(false);
      this.grupo1.PerformLayout();
      ((ISupportInitialize) this.PictureBox2).EndInit();
      ((ISupportInitialize) this.foto).EndInit();
      ((ISupportInitialize) this.PictureBox3).EndInit();
      this.ResumeLayout(false);
    }

    private void Menu_Load(object sender, EventArgs e)
    {
      this.TextBox1.KeyPress += new KeyPressEventHandler(this.keypressed1);
      this.ip = Module1.GetIpV4();
      this.posiciona_objetos();
      this.Empre.SelectedIndex = 0;
      this.setea_empresa();
      this.TextBox1.Focus();
      if (DateTime.Compare(this.hoy, Conversions.ToDate("2019-09-20")) <= 0)
        return;
      int num = (int) Interaction.MsgBox((object) "Hay un error en la Base de Datos", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
      this.Close();
    }

    private void posiciona_objetos()
    {
      Point point;
      point.X = checked (this.l - 180);
      point.Y = this.Empre.Location.Y;
      this.Empre.Location = point;
      point.X = checked ((int) Math.Round(unchecked ((double) this.l / 2.0 - 170.0)));
      point.Y = checked ((int) Math.Round(unchecked ((double) this.a / 2.0 - 182.0)));
      this.PictureBox3.Location = point;
      point.X = checked ((int) Math.Round(unchecked ((double) this.l / 2.0 - 220.0)));
      point.Y = checked (this.a - 200);
      this.grupo1.Location = point;
      point.X = checked ((int) Math.Round(unchecked ((double) this.l / 2.0 - 190.0)));
      point.Y = checked (this.a - 150);
      this.Label3.Location = point;
      point.X = checked (this.l - 150);
      point.Y = 70;
      point.X = checked ((int) Math.Round(unchecked ((double) this.l / 2.0 - 220.0)));
      point.Y = checked (this.a - 200);
      this.foto.Location = point;
    }

    public void keypressed1(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.TextBox1.Text), "", false) > 0U)
      {
        this.bien = true;
        this.busca_clave();
        if (this.bien)
          this.procesa();
      }
    }

    [MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
    private void busca_clave()
    {
      empresas empresas = new empresas();
      Lib_SIF.men men = new Lib_SIF.men();
      bool flag = true;
      DataTable dt = new DataTable();
      string sec = "";
      checked { ++this.contador; }
      if (this.contador > 3)
        ProjectData.EndApp();
      bool ok;
      men.menu(this.TextBox1.Text, ref this.usuario, this.ip, ref sec, ref this.dt, ref ok);
      try
      {
        if (!ok)
        {
          flag = false;
          this.bien = false;
          this.Label3.Text = "Clave Incorrecta !!!!!!.      " + Conversions.ToString(this.contador) + "  Intentos ";
          this.TextBox1.Text = "";
        }
        else
        {
          this.Label3.Text = this.usuario;
          this.nombre = this.usuario;
          empresas.usuario = this.Label3.Text;
          empresas.clave = this.TextBox1.Text;
          empresas.seccion = sec;
          this.foto.Visible = true;
          string strSql = "SELECT * FROM MEN_JAP_F WHERE PASSWORD = '" + this.TextBox1.Text + "'";
          Module1.llena_tablas(ref dt, strSql, ref this.cnn);
          if (dt.Rows.Count > 0)
          {
            DataRow row = dt.Rows[0];
            try
            {
              this.foto.Image = Image.FromStream((Stream) new MemoryStream((byte[]) row["FOTO"]));
            }
            catch (Exception ex)
            {
              ProjectData.SetProjectError(ex);
              ProjectData.ClearProjectError();
            }
          }
          this.bien = true;
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        int num = (int) Interaction.MsgBox((object) "No he podido conectarme al servidor.  Por favor verifique su conección", MsgBoxStyle.Critical, (object) "Conección Perdida.");
        this.Close();
        ProjectData.ClearProjectError();
      }
    }

    private void setea_empresa()
    {
      int selectedIndex = this.Empre.SelectedIndex;
      object objectValue = RuntimeHelpers.GetObjectValue(this.Empre.SelectedItem);
      if (selectedIndex <= -1)
        return;
      this.empresa = Strings.Mid(objectValue.ToString(), 1, 1);
      this.nombre = Strings.Mid(objectValue.ToString(), 5);
      this.obj = new empresas();
      this.obj.numero = this.empresa;
      this.obj.nombre = this.nombre;
      this.obj.constr = this.cs.con_string(checked ((int) Math.Round(unchecked (Conversions.ToDouble(this.empresa) - 1.0))));
      this.obj.conole = this.cs.con_ole(checked ((int) Math.Round(unchecked (Conversions.ToDouble(this.empresa) - 1.0))));
      this.Label2.Text = this.nombre;
    }

    private void Empre_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.setea_empresa();
    }

    private void procesa()
    {
      ToolStripMenuItem ms1 = new ToolStripMenuItem();
      ToolStripMenuItem ms2 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem();
      int index = -1;
      try
      {
        foreach (DataRow row in this.dt.Rows)
        {
          string str1 = Conversions.ToString(row["MENU"]);
          string descripcion = Conversions.ToString(row["DESCRIPCION"]);
          string str2 = Conversions.ToString(row["COLOR"]);
          Color colo = Color.FromArgb(Conversions.ToInteger(Strings.Mid(str2, 1, 3)), Conversions.ToInteger(Strings.Mid(str2, 5, 3)), Conversions.ToInteger(Strings.Mid(str2, 9, 3)));
          if (Decimal.Compare(Conversions.ToDecimal(Strings.Mid(str1, 4)), Decimal.Zero) == 0)
          {
            checked { ++index; }
            this.i1 = -1;
            this.menudo.Items.Add(str1);
            this.menudo.Items[index].Text = descripcion;
            this.menudo.Items[index].Name = str1;
            this.menudo.Items[index].Visible = true;
            this.menudo.Items[index].BackColor = colo;
            ms1 = (ToolStripMenuItem) this.menudo.Items[index];
          }
          else if (Decimal.Compare(Conversions.ToDecimal(Strings.Mid(str1, 6)), Decimal.Zero) == 0)
            this.menusg(ms1, str1, descripcion, colo);
          else if (Decimal.Compare(Conversions.ToDecimal(Strings.Mid(str1, 8)), Decimal.Zero) == 0)
          {
            ms2 = (ToolStripMenuItem) ms1.DropDownItems[this.i1];
            this.menutr(ms2, Conversions.ToString(row["MENU"]), Conversions.ToString(row["DESCRIPCION"]), colo);
          }
          else
            this.menubr((ToolStripMenuItem) ms2.DropDownItems[this.i2], Conversions.ToString(row["MENU"]), Conversions.ToString(row["DESCRIPCION"]), colo);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.TextBox1.Visible = false;
      this.grupo1.Visible = false;
      this.Empre.Visible = true;
      this.PictureBox3.Visible = true;
      this.Label3.Visible = true;
    }

    private void menusg(ToolStripMenuItem ms, string m, string descripcion, Color colo)
    {
      int num = checked (Conversions.ToInteger(Strings.Mid(m, 4, 2)) - 1);
      ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(m, (Image) null, new EventHandler(this.MenuItem_Click), m);
      toolStripMenuItem2.Text = descripcion;
      toolStripMenuItem2.BackColor = colo;
      ms.DropDownItems.Add((ToolStripItem) toolStripMenuItem2);
      checked { ++this.i1; }
      this.i2 = -1;
    }

    private void menutr(ToolStripMenuItem ms, string m, string descripcion, Color colo)
    {
      ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(m, (Image) null, new EventHandler(this.MenuItem_Click), m);
      toolStripMenuItem2.Text = descripcion;
      toolStripMenuItem2.BackColor = colo;
      ms.DropDownItems.Add((ToolStripItem) toolStripMenuItem2);
      checked { ++this.i2; }
    }

    private void menubr(ToolStripMenuItem ms, string m, string descripcion, Color colo)
    {
      ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
      ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem(m, (Image) null, new EventHandler(this.MenuItem_Click), m);
      toolStripMenuItem2.Text = descripcion;
      toolStripMenuItem2.BackColor = colo;
      ms.DropDownItems.Add((ToolStripItem) toolStripMenuItem2);
    }

    private void MenuItem_Click(object sender, EventArgs e)
    {
      string str1 = "";
      int num1 = 0;
      int num2 = 0;
      int num3 = 0;
      DataTable dt = this.dt;
      string nombre = Conversions.ToString(NewLateBinding.LateGet(sender, (System.Type) null, "name", new object[0], (string[]) null, (System.Type[]) null, (bool[]) null));
      ref string local1 = ref str1;
      ref int local2 = ref num1;
      ref int local3 = ref num2;
      string str2 = Conversions.ToString(num3);
      ref string local4 = ref str2;
      string str3 = this.busca_prg(dt, nombre, ref local1, ref local2, ref local3, ref local4);
      Conversions.ToInteger(str2);
      string formName = str3;
      if (formName.Length <= 1)
        return;
      Form form = menu.CreateForm(formName);
      if (num1 > 0 | num2 > 0)
      {
        try
        {
          form.Size = new Size(this.l, this.a);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          ProjectData.ClearProjectError();
        }
      }
      try
      {
        form.Text = form.Text + "  (" + this.obj.nombre + ")";
        int num4 = (int) form.ShowDialog();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    public string busca_prg(
      DataTable db,
      string nombre,
      ref string prg,
      ref int ancho,
      ref int alto,
      ref string cont)
    {
      DataRow[] dataRowArray = db.Select("MENU = '" + nombre + "'");
      if (dataRowArray.Length > 0)
      {
        DataRow dataRow = dataRowArray[0];
        prg = Conversions.ToString(dataRow["PROGRAMA"]);
        ancho = Conversions.ToInteger(dataRow["ANCHO"]);
        alto = Conversions.ToInteger(dataRow["ALTO"]);
        cont = Conversions.ToString(dataRow["CONTROL"]);
      }
      return prg;
    }

    public static object CreateObjectInstance(string objectName)
    {
      object obj;
      try
      {
        if (objectName.LastIndexOf(".") == -1)
          objectName = Assembly.GetEntryAssembly().GetName().Name + "." + objectName;
        obj = RuntimeHelpers.GetObjectValue(Assembly.GetEntryAssembly().CreateInstance(objectName));
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        obj = (object) null;
        ProjectData.ClearProjectError();
      }
      return obj;
    }

    public static Form CreateForm(string formName)
    {
      return (Form) menu.CreateObjectInstance(formName);
    }
  }
}
