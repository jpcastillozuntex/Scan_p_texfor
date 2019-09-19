// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas35
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
  public class Cajas35 : Form
  {
    private SqlConnection cnn;
    private DataTable dt;
    private DataTable co;
    private DataTable es;
    private DataRow dr;
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
          fg1.SelChange -= eventHandler;
        this._fg = value;
        C1.Win.C1FlexGrid.C1FlexGrid fg2 = this._fg;
        if (fg2 == null)
          return;
        fg2.SelChange += eventHandler;
      }
    }

    internal virtual ComboBox cliente
    {
      get
      {
        return this._cliente;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.cliente_KeyPress);
        ComboBox cliente1 = this._cliente;
        if (cliente1 != null)
          cliente1.KeyPress -= pressEventHandler;
        this._cliente = value;
        ComboBox cliente2 = this._cliente;
        if (cliente2 == null)
          return;
        cliente2.KeyPress += pressEventHandler;
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

    public Cajas35()
    {
      this.Load += new EventHandler(this.Cajas35_Load);
      this.cnn = new SqlConnection();
      this.dt = new DataTable();
      this.co = new DataTable();
      this.es = new DataTable();
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
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas35));
      this.ToolTip1 = new ToolTip(this.components);
      this.cliente = new ComboBox();
      this.Cancela = new Button();
      this.si = new Button();
      this.graba = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.Label3 = new Label();
      this.upc = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.fg.BeginInit();
      this.upc.BeginInit();
      this.SuspendLayout();
      this.cliente.BackColor = Color.FromArgb((int) byte.MaxValue, (int) byte.MaxValue, 128);
      this.cliente.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.cliente.Items.AddRange(new object[3]
      {
        (object) "JT",
        (object) "TRECENTO",
        (object) "ZUNTEX"
      });
      this.cliente.Location = new Point(201, 21);
      this.cliente.Name = "cliente";
      this.cliente.Size = new Size(222, 28);
      this.cliente.TabIndex = 0;
      this.ToolTip1.SetToolTip((Control) this.cliente, "Cliente.");
      this.Cancela.BackColor = Color.FromArgb(46, 196, 245);
      this.Cancela.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Cancela.ForeColor = Color.Black;
      this.Cancela.Image = (Image) componentResourceManager.GetObject("Cancela.Image");
      this.Cancela.Location = new Point(814, 12);
      this.Cancela.Name = "Cancela";
      this.Cancela.Size = new Size(60, 40);
      this.Cancela.TabIndex = 104;
      this.Cancela.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Cancela, "Presione este Boton para Cancelar toda la operación y limpiar todos los datos sin Grabar.");
      this.Cancela.UseVisualStyleBackColor = false;
      this.si.BackColor = Color.FromArgb(46, 196, 245);
      this.si.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.si.ForeColor = Color.Black;
      this.si.Image = (Image) componentResourceManager.GetObject("si.Image");
      this.si.Location = new Point(814, 12);
      this.si.Name = "si";
      this.si.Size = new Size(60, 40);
      this.si.TabIndex = 1;
      this.si.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.si, "Chequeo de Datos");
      this.si.UseVisualStyleBackColor = false;
      this.graba.BackColor = Color.FromArgb(46, 196, 245);
      this.graba.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.graba.ForeColor = Color.Black;
      this.graba.Image = (Image) componentResourceManager.GetObject("graba.Image");
      this.graba.Location = new Point(1043, 593);
      this.graba.Name = "graba";
      this.graba.Size = new Size(60, 40);
      this.graba.TabIndex = 9;
      this.graba.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.graba, "Graba datos.");
      this.graba.UseVisualStyleBackColor = false;
      this.fg.AllowEditing = false;
      this.fg.AllowFiltering = true;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.fg.Location = new Point(7, 65);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 21;
      this.fg.SelectionMode = SelectionModeEnum.Row;
      this.fg.Size = new Size(1120, 371);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.TabIndex = 92;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(12, 19);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(173, 32);
      this.Label3.TabIndex = 94;
      this.Label3.Text = "Cliente:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.upc.AllowFiltering = true;
      this.upc.AutoClipboard = true;
      this.upc.ColumnInfo = componentResourceManager.GetString("upc.ColumnInfo");
      this.upc.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold);
      this.upc.HighLight = HighLightEnum.Never;
      this.upc.Location = new Point(7, 471);
      this.upc.Name = "upc";
      this.upc.Rows.DefaultSize = 21;
      this.upc.Size = new Size(1124, 92);
      this.upc.StyleInfo = componentResourceManager.GetString("upc.StyleInfo");
      this.upc.TabIndex = 130;
      this.AutoScaleBaseSize = new Size(7, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1139, 656);
      this.Controls.Add((Control) this.upc);
      this.Controls.Add((Control) this.si);
      this.Controls.Add((Control) this.cliente);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.graba);
      this.Controls.Add((Control) this.Cancela);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas35);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Revisa UPC";
      this.fg.EndInit();
      this.upc.EndInit();
      this.ResumeLayout(false);
    }

    private void Cajas35_Load(object sender, EventArgs e)
    {
      this.cliente.KeyPress += new KeyPressEventHandler(this.keypressed1);
      this.upc.DragMode = DragModeEnum.AutomaticCopy;
      this.upc.DropMode = DropModeEnum.Automatic;
      Module1.llena_tablas(ref this.es, "SELECT * FROM E_TALLAS", ref this.cnn);
      ComboBox cliente = this.cliente;
      Module1.llena_combos(ref cliente, "SELECT  DISTINCT CLIENTE FROM CLIENTES WHERE ACTIVO = 'S'", "CLIENTE");
      this.cliente = cliente;
      try
      {
        this.cliente.SelectedIndex = 0;
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
      this.cliente.Enabled = true;
      this.si.Visible = true;
      this.cliente.Focus();
    }

    private void habilita()
    {
      this.si.Visible = false;
      this.graba.Visible = true;
      this.cliente.Enabled = false;
    }

    private void setea_grid()
    {
      this.fg.Rows.Count = 1;
      this.fg.Rows.Fixed = 1;
      this.fg.Rows[0].Height = 30;
      this.upc.Rows.Count = 1;
      this.upc.Rows.Count = 2;
      this.upc.Rows[0].Height = 30;
      this.upc.Rows[1].Height = 30;
    }

    private void si_Click(object sender, EventArgs e)
    {
      this.llena_corte();
      this.si.Visible = false;
      this.cliente.Enabled = false;
      this.Cancela.Visible = true;
    }

    private void llena_corte()
    {
      int index = 1;
      Module1.llena_tablas(ref this.co, "select DISTINCT CPO_D.ESTILO + CPO_D.COLOR ,CPO_D.ESTILO,CPO_D.COLOR,CPO_D.ESCALA ,UPC.* FROM CPO_D LEFT JOIN CPO ON CPO_D.CPO = CPO.CPO LEFT JOIN UPC ON CPO.CLIENTE = UPC.CLIENTE AND CPO_D.ESTILO = UPC.ESTILO AND CPO_D.COLOR = UPC.COLOR WHERE  ESTADO = 'A' AND CPO.CLIENTE = '" + this.cliente.Text + "'", ref this.cnn);
      this.fg.Rows.Count = checked (this.co.Rows.Count + 1);
      try
      {
        foreach (DataRow row in this.co.Rows)
        {
          this.fg[index, 1] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          this.fg[index, 2] = RuntimeHelpers.GetObjectValue(row["COLOR"]);
          this.fg[index, 3] = RuntimeHelpers.GetObjectValue(row["ESCALA"]);
          int num = 0;
          do
          {
            this.fg[index, checked (num + 4)] = RuntimeHelpers.GetObjectValue(row[checked (num + 9)]);
            checked { ++num; }
          }
          while (num <= 9);
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

    private void muestra_upc()
    {
      int rowSel = this.fg.RowSel;
      DataRow dr = (DataRow) null;
      this.llena_talla(Conversions.ToString(this.fg[rowSel, 3]), ref dr);
      int index = 1;
      do
      {
        this.upc[0, index] = RuntimeHelpers.GetObjectValue(dr[checked (index + 1)]);
        this.upc[1, index] = RuntimeHelpers.GetObjectValue(this.fg[rowSel, checked (index + 3)]);
        checked { ++index; }
      }
      while (index <= 10);
    }

    private void llena_talla(string escala, ref DataRow dr)
    {
      DataRow[] dataRowArray = this.es.Select("ESCALA = '" + escala + "'");
      if (dataRowArray.Length > 0)
        dr = dataRowArray[0];
      else
        dr = (DataRow) null;
    }

    private void keypressed1(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(this.cliente.Text), "", false) > 0U)
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
          this.setea_grid();
          this.llena_corte();
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

    private void cliente_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox cliente = this.cliente;
      Module1.AutoCompletar(ref cliente, e);
      this.cliente = cliente;
    }

    private void Cancela_Click(object sender, EventArgs e)
    {
      this.limpia_variables();
      this.cliente.Focus();
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
      int rowSel = this.fg.RowSel;
      empresas empresas = new empresas();
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      string str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(this.fg[rowSel, 1], this.fg[rowSel, 2]));
      if (str1.Length > 0)
        str1 = Strings.Mid(str1, 1, 30);
      try
      {
        string str2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE UPC SET T1 ='", this.upc[1, 1]), (object) "', T2 = '"), this.upc[1, 2]), (object) "', T3 ='"), this.upc[1, 3]), (object) "', T4 ='"), this.upc[1, 4]), (object) "', T5 ='"), this.upc[1, 5]), (object) "', T6 = '"), this.upc[1, 6]), (object) "', T7 ='"), this.upc[1, 7]), (object) "', T8 ='"), this.upc[1, 8]), (object) "', T9 ='"), this.upc[1, 9]), (object) "', T0 = '"), this.upc[1, 10]), (object) "' "), (object) " WHERE CLIENTE = '"), (object) this.cliente.Text), (object) "' AND ESTILO = '"), this.fg[rowSel, 1]), (object) "' AND COLOR = '"), this.fg[rowSel, 2]), (object) "'"));
        command.CommandText = str2;
        if (command.ExecuteNonQuery() == 0)
        {
          string str3 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO UPC (CLIENTE,ESTILO,COLOR,MATERIAL,ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0,USUARIO,FECHA) VALUES ('" + this.cliente.Text + "','"), this.fg[rowSel, 1]), (object) "','"), this.fg[rowSel, 2]), (object) "','"), (object) str1), (object) "','"), this.fg[rowSel, 3]), (object) "','"), this.upc[1, 1]), (object) "','"), this.upc[1, 2]), (object) "','"), this.upc[1, 3]), (object) "','"), this.upc[1, 4]), (object) "','"), this.upc[1, 5]), (object) "','"), this.upc[1, 6]), (object) "','"), this.upc[1, 7]), (object) "','"), this.upc[1, 8]), (object) "','"), this.upc[1, 9]), (object) "','"), this.upc[1, 10]), (object) "','"), (object) empresas.usuario), (object) "',GETDATE() )"));
          command.CommandText = str3;
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

    private void fg_Click(object sender, EventArgs e)
    {
      try
      {
        this.muestra_upc();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }
  }
}
