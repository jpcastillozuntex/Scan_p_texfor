// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas25
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using C1.Win.C1FlexGrid;
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
  public class Cajas25 : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataTable co;
    private DataTable pp;
    private DataRow dr;
    private string cliente;
    private DataTable tp;
    private DataRow dj;
    private string ta;
    private string[] ts;
    private string dato;
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

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label escala { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label estilo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label colo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual TextBox material { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid upc
    {
      get
      {
        return this._upc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.fg_KeyDown);
        C1.Win.C1FlexGrid.C1FlexGrid upc1 = this._upc;
        if (upc1 != null)
          upc1.KeyDown -= keyEventHandler;
        this._upc = value;
        C1.Win.C1FlexGrid.C1FlexGrid upc2 = this._upc;
        if (upc2 == null)
          return;
        upc2.KeyDown += keyEventHandler;
      }
    }

    public Cajas25()
    {
      this.Load += new EventHandler(this.Cajas05_Load);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.co = new DataTable();
      this.pp = new DataTable();
      this.tp = new DataTable();
      this.ta = "|XS|S|M|L|XL|XL2|XL3|XL4|XL5|XL6";
      this.ts = new string[11];
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas25));
      this.ToolTip1 = new ToolTip(this.components);
      this.corte = new ComboBox();
      this.si = new Button();
      this.Cancela = new Button();
      this.graba = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.escala = new Label();
      this.estilo = new Label();
      this.colo = new Label();
      this.material = new TextBox();
      this.upc = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.fg.BeginInit();
      this.upc.BeginInit();
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
      this.corte.Size = new Size(222, 28);
      this.corte.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.corte, "No. Corte.");
      this.si.BackColor = Color.FromArgb(46, 196, 245);
      this.si.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.si.ForeColor = Color.Black;
      this.si.Image = (Image) componentResourceManager.GetObject("si.Image");
      this.si.Location = new Point(909, 19);
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
      this.Cancela.Location = new Point(977, 19);
      this.Cancela.Name = "Cancela";
      this.Cancela.Size = new Size(60, 40);
      this.Cancela.TabIndex = 104;
      this.Cancela.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin Grabar.");
      this.Cancela.UseVisualStyleBackColor = false;
      this.graba.BackColor = Color.FromArgb(46, 196, 245);
      this.graba.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.graba.ForeColor = Color.Black;
      this.graba.Image = (Image) componentResourceManager.GetObject("graba.Image");
      this.graba.Location = new Point(909, 19);
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
      this.fg.Location = new Point(7, 222);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.Size = new Size(1120, 97);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(12, 19);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(173, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Corte:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.Label1.BackColor = Color.SteelBlue;
      this.Label1.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label1.ForeColor = Color.White;
      this.Label1.Location = new Point(12, 166);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(173, 32);
      this.Label1.TabIndex = 107;
      this.Label1.Text = "Material:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.BackColor = Color.SteelBlue;
      this.Label2.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(12, 56);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(173, 32);
      this.Label2.TabIndex = 108;
      this.Label2.Text = "Estilo:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.BackColor = Color.SteelBlue;
      this.Label4.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.White;
      this.Label4.Location = new Point(12, 93);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(173, 32);
      this.Label4.TabIndex = 109;
      this.Label4.Text = "Color:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.BackColor = Color.SteelBlue;
      this.Label5.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label5.ForeColor = Color.White;
      this.Label5.Location = new Point(12, 129);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(173, 32);
      this.Label5.TabIndex = 110;
      this.Label5.Text = "Escala:";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.escala.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.escala.BorderStyle = BorderStyle.Fixed3D;
      this.escala.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.escala.Location = new Point(202, 131);
      this.escala.Name = "escala";
      this.escala.Size = new Size(92, 32);
      this.escala.TabIndex = 111;
      this.escala.Text = " ";
      this.escala.TextAlign = ContentAlignment.MiddleCenter;
      this.estilo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.estilo.BorderStyle = BorderStyle.Fixed3D;
      this.estilo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.estilo.Location = new Point(202, 56);
      this.estilo.Name = "estilo";
      this.estilo.Size = new Size(428, 32);
      this.estilo.TabIndex = 112;
      this.estilo.Text = " ";
      this.estilo.TextAlign = ContentAlignment.MiddleLeft;
      this.colo.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.colo.BorderStyle = BorderStyle.Fixed3D;
      this.colo.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.colo.Location = new Point(202, 93);
      this.colo.Name = "colo";
      this.colo.Size = new Size(428, 32);
      this.colo.TabIndex = 113;
      this.colo.Text = " ";
      this.colo.TextAlign = ContentAlignment.MiddleLeft;
      this.material.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.material.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold);
      this.material.Location = new Point(201, 171);
      this.material.Name = "material";
      this.material.Size = new Size(429, 26);
      this.material.TabIndex = 129;
      this.upc.AllowFiltering = true;
      this.upc.AutoClipboard = true;
      this.upc.ColumnInfo = componentResourceManager.GetString("upc.ColumnInfo");
      this.upc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.upc.HighLight = HighLightEnum.Never;
      this.upc.Location = new Point(7, 346);
      this.upc.Name = "upc";
      this.upc.Rows.DefaultSize = 21;
      this.upc.Size = new Size(1124, 92);
      this.upc.StyleInfo = componentResourceManager.GetString("upc.StyleInfo");
      this.upc.TabIndex = 130;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1139, 603);
      this.Controls.Add((Control) this.upc);
      this.Controls.Add((Control) this.material);
      this.Controls.Add((Control) this.colo);
      this.Controls.Add((Control) this.estilo);
      this.Controls.Add((Control) this.escala);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Controls.Add((Control) this.Cancela);
      this.Controls.Add((Control) this.si);
      this.Controls.Add((Control) this.corte);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.graba);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas25);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Revisa UPC";
      this.fg.EndInit();
      this.upc.EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private void Cajas05_Load(object sender, EventArgs e)
    {
      this.corte.KeyPress += new KeyPressEventHandler(this.keypressed1);
      this.upc.DragMode = DragModeEnum.AutomaticCopy;
      this.upc.DropMode = DropModeEnum.Automatic;
      ComboBox corte = this.corte;
      Module1.llena_combos(ref corte, "SELECT  DISTINCT CORTE FROM CORTES WHERE CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) AND EXPORTADO <> 'S' ORDER BY CORTE", "CORTE");
      this.corte = corte;
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
      this.escala.Text = "";
      this.estilo.Text = "";
      this.colo.Text = "";
      this.material.Text = "";
      this.si.Visible = true;
      this.graba.Visible = false;
      this.corte.Focus();
    }

    private void habilita()
    {
      this.si.Visible = false;
      this.graba.Visible = true;
      this.corte.Enabled = false;
    }

    private void setea_grid()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows.Fixed = 1;
      this.fg.Rows.Count = 2;
      this.fg.Rows[0].Height = 30;
      this.fg.Rows[1].Height = 30;
      this.upc.Rows.Count = 1;
      this.upc.Rows.Count = 2;
      this.upc.Rows[0].Height = 30;
      this.upc.Rows[1].Height = 30;
    }

    private void si_Click(object sender, EventArgs e)
    {
      this.llena_corte();
    }

    private void llena_corte()
    {
      Module1.llena_tablas(ref this.co, "SELECT CORTES.*,CPO_D.ESCALA, E_TALLAS.*,UPC.* FROM CORTES LEFT JOIN CPO_D ON CPO_D.CPO = CORTES.CPO AND CPO_D.ESTILO = CORTES.ESTILO AND CPO_D.COLOR = CORTES.COLOR LEFT JOIN E_TALLAS ON CPO_D.ESCALA = E_TALLAS.ESCALA LEFT JOIN UPC ON CORTES.ESTILO = UPC.ESTILO AND CORTES.COLOR = UPC.COLOR AND CORTES.CLIENTE = UPC.CLIENTE WHERE CORTE = '" + this.corte.Text + "'", ref this.cnn);
      if (this.co.Rows.Count > 0)
      {
        this.dr = this.co.Rows[0];
        this.dj = this.dr;
        this.escala.Text = Conversions.ToString(this.dr["CPO"]);
        this.estilo.Text = Conversions.ToString(this.dr["ESTILO"]);
        this.colo.Text = Conversions.ToString(this.dr["COLOR"]);
        this.cliente = Conversions.ToString(this.dr["CLIENTE"]);
        this.escala.Text = Conversions.ToString(this.dr["ESCALA"]);
        try
        {
          this.material.Text = Conversions.ToString(this.dr["MATERIAL"]);
        }
        catch (Exception ex)
        {
          ProjectData.SetProjectError(ex);
          this.material.Text = this.estilo.Text + "_" + this.colo.Text;
          this.material.Text = Strings.Mid(this.material.Text, 1, 30);
          ProjectData.ClearProjectError();
        }
        this.fg[1, 1] = (object) "Cortado";
        int index = 1;
        do
        {
          if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.escala.Text, "00", false) == 0)
            this.dj[checked (index + 24)] = (object) this.ts[index];
          this.fg[0, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 24)]);
          this.upc[0, index] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 24)]);
          this.fg[1, checked (index + 1)] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 5)]);
          this.upc[1, index] = RuntimeHelpers.GetObjectValue(this.dj[checked (index + 39)]);
          checked { ++index; }
        }
        while (index <= 10);
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

    private void revisa_upc(ref bool ok)
    {
      ok = false;
      int index = 1;
      do
      {
        this.fg[1, index] = (object) Strings.Trim(Conversions.ToString(this.fg[1, index]));
        if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectNotEqual(this.fg[1, index], (object) null, false))
          ok = true;
        checked { ++index; }
      }
      while (index <= 10);
    }

    private void graba_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Seguro de Actualizar todos los Cambios Efectuados?  ", MsgBoxStyle.YesNo, (object) "Actualizacion de Datos !!!") == MsgBoxResult.Yes)
      {
        bool ok;
        this.revisa_upc(ref ok);
        if (ok)
        {
          this.graba_datos();
          this.limpia_variables();
        }
        else
        {
          int num = (int) Interaction.MsgBox((object) "Al menos debe ingresear un Código de UPC.", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
        }
      }
      else
      {
        int num1 = (int) Interaction.MsgBox((object) "Aún no ha ingresado unidades a la nueva Caja", MsgBoxStyle.Critical, (object) "Por favor revise !!!");
      }
    }

    private void corteS_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox corte = this.corte;
      Module1.AutoCompletar(ref corte, e);
      this.corte = corte;
    }

    private void Cancela_Click(object sender, EventArgs e)
    {
      this.limpia_variables();
      this.corte.Focus();
    }

    private void fg_KeyDown(object sender, KeyEventArgs e)
    {
      string[] strArray = Clipboard.GetText().Split(Conversions.ToChar(Environment.NewLine));
      if (!e.Control)
        return;
      switch (e.KeyCode)
      {
        case Keys.Insert:
        case Keys.C:
          this.dato = Conversions.ToString(this.upc[this.upc.RowSel, this.upc.ColSel]);
          break;
        case Keys.V:
          CellRange selection = this.upc.Selection;
          if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dato, "", false) > 0U)
          {
            selection.Data = (object) strArray;
            break;
          }
          break;
      }
    }

    private void graba_datos()
    {
      empresas empresas = new empresas();
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        string str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE UPC SET T1 ='", this.upc[1, 1]), (object) "', T2 = '"), this.upc[1, 2]), (object) "', T3 ='"), this.upc[1, 3]), (object) "', T4 ='"), this.upc[1, 4]), (object) "', T5 ='"), this.upc[1, 5]), (object) "', T6 = '"), this.upc[1, 6]), (object) "', T7 ='"), this.upc[1, 7]), (object) "', T8 ='"), this.upc[1, 8]), (object) "', T9 ='"), this.upc[1, 9]), (object) "', T0 = '"), this.upc[1, 10]), (object) "' "), (object) " WHERE CLIENTE = '"), (object) this.cliente), (object) "' AND ESTILO = '"), (object) this.estilo.Text), (object) "' AND COLOR = '"), (object) this.colo.Text), (object) "'"));
        command.CommandText = str1;
        if (command.ExecuteNonQuery() == 0)
        {
          string str2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO UPC (CLIENTE,ESTILO,COLOR,MATERIAL,ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0,USUARIO,FECHA) VALUES ('" + this.cliente + "','" + this.estilo.Text + "','" + this.colo.Text + "','" + this.material.Text + "','" + this.escala.Text + "','"), this.upc[1, 1]), (object) "','"), this.upc[1, 2]), (object) "','"), this.upc[1, 3]), (object) "','"), this.upc[1, 4]), (object) "','"), this.upc[1, 5]), (object) "','"), this.upc[1, 6]), (object) "','"), this.upc[1, 7]), (object) "','"), this.upc[1, 8]), (object) "','"), this.upc[1, 9]), (object) "','"), this.upc[1, 10]), (object) "','"), (object) empresas.usuario), (object) "',GETDATE() )"));
          command.CommandText = str2;
          command.ExecuteNonQuery();
        }
        sqlTransaction.Commit();
        int num = (int) Interaction.MsgBox((object) "Actualización Exitosa.", MsgBoxStyle.Exclamation, (object) "Datos Actualizados.");
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
            Console.WriteLine("Ocurrió un error de tipo " + sqlException.GetType().ToString() + " se generó cuando se trato de eliminar la transacción.");
          ProjectData.ClearProjectError();
        }
        ProjectData.ClearProjectError();
      }
      finally
      {
        this.cnn.Close();
      }
    }
  }
}
