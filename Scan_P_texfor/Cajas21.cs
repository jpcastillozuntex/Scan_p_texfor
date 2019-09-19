// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Cajas21
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
  public class Cajas21 : Form
  {
    private string cliente;
    private string escala;
    private int fila;
    private DataTable dt;
    private DataTable mt;
    private DataTable es;
    private DataRow dr;
    private SqlConnection cnn;
    private int lineas;
    private empresas empre;
    private string clave;
    private DataTable ac;
    private IContainer components;

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid ec
    {
      get
      {
        return this._ec;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.ec_Click);
        KeyEventHandler keyEventHandler = new KeyEventHandler(this.ec_KeyDown);
        C1.Win.C1FlexGrid.C1FlexGrid ec1 = this._ec;
        if (ec1 != null)
        {
          ec1.Click -= eventHandler;
          ec1.KeyDown -= keyEventHandler;
        }
        this._ec = value;
        C1.Win.C1FlexGrid.C1FlexGrid ec2 = this._ec;
        if (ec2 == null)
          return;
        ec2.Click += eventHandler;
        ec2.KeyDown += keyEventHandler;
      }
    }

    internal virtual Label estil { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label colo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    public Cajas21()
    {
      this.Load += new EventHandler(this.BOM_Load);
      this.dt = new DataTable();
      this.mt = new DataTable();
      this.es = new DataTable();
      this.cnn = new SqlConnection();
      this.empre = new empresas();
      this.ac = new DataTable();
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && this.components != null)
        this.components.Dispose();
      base.Dispose(disposing);
    }

    internal virtual Button graba
    {
      get
      {
        return this._graba;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button1_Click);
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

    internal virtual Button quita
    {
      get
      {
        return this._quita;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.Button2_Click);
        Button quita1 = this._quita;
        if (quita1 != null)
          quita1.Click -= eventHandler;
        this._quita = value;
        Button quita2 = this._quita;
        if (quita2 == null)
          return;
        quita2.Click += eventHandler;
      }
    }

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

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual GroupBox grupo { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual ComboBox material
    {
      get
      {
        return this._material;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        KeyPressEventHandler pressEventHandler = new KeyPressEventHandler(this.mate_KeyPress);
        EventHandler eventHandler = new EventHandler(this.material_SelectedIndexChanged);
        ComboBox material1 = this._material;
        if (material1 != null)
        {
          material1.KeyPress -= pressEventHandler;
          material1.SelectedIndexChanged -= eventHandler;
        }
        this._material = value;
        ComboBox material2 = this._material;
        if (material2 == null)
          return;
        material2.KeyPress += pressEventHandler;
        material2.SelectedIndexChanged += eventHandler;
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Cajas21));
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.graba = new Button();
      this.quita = new Button();
      this.Button3 = new Button();
      this.grupo = new GroupBox();
      this.estil = new Label();
      this.colo = new Label();
      this.material = new ComboBox();
      this.Label4 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.ToolTip1 = new ToolTip(this.components);
      this.ec = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.fg.BeginInit();
      this.grupo.SuspendLayout();
      this.ec.BeginInit();
      this.SuspendLayout();
      this.fg.AllowDragging = AllowDraggingEnum.None;
      this.fg.AllowEditing = false;
      this.fg.AllowResizing = AllowResizingEnum.None;
      this.fg.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.fg.FocusRect = FocusRectEnum.None;
      this.fg.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.fg.ForeColor = Color.Black;
      this.fg.HighLight = HighLightEnum.WithFocus;
      this.fg.Location = new Point(8, 543);
      this.fg.Name = "fg";
      this.fg.Rows.DefaultSize = 19;
      this.fg.SelectionMode = SelectionModeEnum.Row;
      this.fg.Size = new Size(1027, 88);
      this.fg.TabIndex = 22;
      this.ToolTip1.SetToolTip((Control) this.fg, "Area de Datos.");
      this.graba.BackColor = Color.FromArgb(46, 196, 245);
      this.graba.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.graba.ForeColor = Color.Black;
      this.graba.Location = new Point(837, 19);
      this.graba.Name = "graba";
      this.graba.Size = new Size(60, 40);
      this.graba.TabIndex = 8;
      this.graba.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.graba, "Presione este Boton para Grabar o Actualizar los Datos de la FPO.");
      this.graba.UseVisualStyleBackColor = false;
      this.quita.BackColor = Color.FromArgb(46, 196, 245);
      this.quita.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.quita.ForeColor = Color.Black;
      this.quita.Location = new Point(837, 19);
      this.quita.Name = "quita";
      this.quita.Size = new Size(60, 40);
      this.quita.TabIndex = 21;
      this.quita.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.quita, "Presione este Boton para Borrar el Registro Seleccionado.");
      this.quita.UseVisualStyleBackColor = false;
      this.Button3.BackColor = Color.FromArgb(46, 196, 245);
      this.Button3.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button3.ForeColor = Color.Black;
      this.Button3.Location = new Point(903, 19);
      this.Button3.Name = "Button3";
      this.Button3.Size = new Size(60, 40);
      this.Button3.TabIndex = 19;
      this.Button3.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Button3, "Presione este Boton para Refrescar la pantalla sin efectuar modificaciones.");
      this.Button3.UseVisualStyleBackColor = false;
      this.grupo.BackColor = Color.White;
      this.grupo.Controls.Add((Control) this.estil);
      this.grupo.Controls.Add((Control) this.colo);
      this.grupo.Controls.Add((Control) this.material);
      this.grupo.Controls.Add((Control) this.Label4);
      this.grupo.Controls.Add((Control) this.Label2);
      this.grupo.Controls.Add((Control) this.Label3);
      this.grupo.Controls.Add((Control) this.Button3);
      this.grupo.Controls.Add((Control) this.graba);
      this.grupo.Controls.Add((Control) this.quita);
      this.grupo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.grupo.ForeColor = Color.Black;
      this.grupo.Location = new Point(8, 414);
      this.grupo.Name = "grupo";
      this.grupo.Size = new Size(1027, 122);
      this.grupo.TabIndex = 1;
      this.grupo.TabStop = false;
      this.estil.BackColor = Color.White;
      this.estil.BorderStyle = BorderStyle.FixedSingle;
      this.estil.Location = new Point(168, 16);
      this.estil.Name = "estil";
      this.estil.Size = new Size(273, 24);
      this.estil.TabIndex = 54;
      this.estil.TextAlign = ContentAlignment.MiddleLeft;
      this.colo.BackColor = Color.White;
      this.colo.BorderStyle = BorderStyle.FixedSingle;
      this.colo.Location = new Point(167, 45);
      this.colo.Name = "colo";
      this.colo.Size = new Size(275, 24);
      this.colo.TabIndex = 53;
      this.colo.TextAlign = ContentAlignment.MiddleLeft;
      this.material.Location = new Point(168, 83);
      this.material.MaxLength = 25;
      this.material.Name = "material";
      this.material.Size = new Size(273, 21);
      this.material.TabIndex = 4;
      this.ToolTip1.SetToolTip((Control) this.material, "Color");
      this.Label4.BackColor = Color.SteelBlue;
      this.Label4.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label4.ForeColor = Color.White;
      this.Label4.Location = new Point(16, 80);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(144, 24);
      this.Label4.TabIndex = 46;
      this.Label4.Text = "Material:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.BackColor = Color.SteelBlue;
      this.Label2.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label2.ForeColor = Color.White;
      this.Label2.Location = new Point(16, 45);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(144, 24);
      this.Label2.TabIndex = 45;
      this.Label2.Text = "Color:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.BackColor = Color.SteelBlue;
      this.Label3.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.Label3.ForeColor = Color.White;
      this.Label3.Location = new Point(16, 16);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(144, 24);
      this.Label3.TabIndex = 44;
      this.Label3.Text = "Estilo:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.ec.AllowDragging = AllowDraggingEnum.None;
      this.ec.AllowEditing = false;
      this.ec.AllowResizing = AllowResizingEnum.None;
      this.ec.ColumnInfo = "10,1,0,0,0,95,Columns:";
      this.ec.FocusRect = FocusRectEnum.None;
      this.ec.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.ec.Location = new Point(8, 12);
      this.ec.Name = "ec";
      this.ec.Rows.DefaultSize = 19;
      this.ec.SelectionMode = SelectionModeEnum.Row;
      this.ec.Size = new Size(1027, 396);
      this.ec.TabIndex = 44;
      this.ToolTip1.SetToolTip((Control) this.ec, "Area de Datos.");
      this.AutoScaleBaseSize = new Size(6, 13);
      this.BackColor = Color.White;
      this.ClientSize = new Size(1059, 696);
      this.Controls.Add((Control) this.ec);
      this.Controls.Add((Control) this.grupo);
      this.Controls.Add((Control) this.fg);
      this.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Black;
      this.FormBorderStyle = FormBorderStyle.FixedSingle;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Cajas21);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Maestro de UPC";
      this.fg.EndInit();
      this.grupo.ResumeLayout(false);
      this.ec.EndInit();
      this.ResumeLayout(false);
    }

    private void BOM_Load(object sender, EventArgs e)
    {
      this.material.KeyPress += new KeyPressEventHandler(this.keypressed1);
      Module1.llena_tablas(ref this.es, "SELECT * FROM E_TALLAS", ref this.cnn);
      ComboBox material = this.material;
      Module1.llena_combos(ref material, "select DISTINCT MATERIAL FROM UPC_C", "MATERIAL");
      this.material = material;
      this.setea_ec();
      try
      {
        this.selecciona_ec(1);
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void setea_ec()
    {
      this.ec.Rows.Count = 1;
      this.ec.Rows[0].Height = 30;
      this.llena_ec();
    }

    private void llena_ec()
    {
      DataTable dt = new DataTable();
      string strSql = "SELECT DISTINCT CORTES.ESTILO+CORTES.COLOR, CORTES.CLIENTE,CORTES.ESTILO,CORTES.COLOR, CPO_D.ESCALA, MATERIAL FROM CORTES LEFT JOIN CPO_D ON CORTES.CPO = CPO_D.CPO AND CORTES.ESTILO = CPO_D. ESTILO AND CORTES.COLOR = CPO_D.COLOR LEFT JOIN UPC ON CORTES.ESTILO = UPC.ESTILO AND CORTES.COLOR =UPC.COLOR AND CPO_D.ESCALA = UPC.ESCALA WHERE CORTE NOT IN (SELECT DISTINCT CORTE FROM PROD_DIARIA) ORDER BY CORTES.CLIENTE,CORTES.ESTILO,CORTES.COLOR";
      int index = 1;
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      this.ec.Rows.Count = checked (dt.Rows.Count + 1);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          this.ec[index, 1] = RuntimeHelpers.GetObjectValue(row["CLIENTE"]);
          this.ec[index, 2] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          this.ec[index, 3] = RuntimeHelpers.GetObjectValue(row["COLOR"]);
          this.ec[index, 4] = RuntimeHelpers.GetObjectValue(row["ESCALA"]);
          this.ec[index, 5] = RuntimeHelpers.GetObjectValue(row["MATERIAL"]);
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

    private void setea_grid()
    {
      this.fg.Rows.Count = 2;
      this.fg.Rows[0].Height = 30;
      int index1 = 0;
      do
      {
        int index2 = 1;
        do
        {
          this.fg[index1, index2] = (object) "";
          checked { ++index2; }
        }
        while (index2 <= 10);
        checked { ++index1; }
      }
      while (index1 <= 1);
      this.llena_grid();
    }

    private void llena_grid()
    {
      DataTable dt = new DataTable();
      string str = "|";
      string[] array = (string[]) null;
      DataRow[] dataRowArray = this.es.Select("ESCALA = '" + this.escala + "'");
      if (dataRowArray.Length > 0)
      {
        DataRow dataRow = dataRowArray[0];
        int index = 1;
        do
        {
          str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.AddObject(Microsoft.VisualBasic.CompilerServices.Operators.AddObject((object) str, dataRow[checked (index + 1)]), (object) "|"));
          this.fg[0, index] = RuntimeHelpers.GetObjectValue(dataRow[checked (index + 1)]);
          checked { ++index; }
        }
        while (index <= 10);
        array = Strings.Split(Strings.Mid(str, 1, checked (str.Length - 1)), "|", -1, CompareMethod.Binary);
      }
      string strSql = "SELECT * FROM UPC_C WHERE MATERIAL = '" + this.material.Text + "'";
      Module1.llena_tablas(ref dt, strSql, ref this.cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          string Left = Conversions.ToString(row["TALLA"]);
          int index = Array.IndexOf<string>(array, Left);
          if (index > 0)
            this.fg[1, index] = RuntimeHelpers.GetObjectValue(row["UPC"]);
          else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Left, "XXL", false) == 0 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.escala, "00", false) == 0)
            this.fg[1, 6] = RuntimeHelpers.GetObjectValue(row["UPC"]);
        }
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
    }

    private void keypressed1(object o, KeyPressEventArgs e)
    {
      if (e.KeyChar != '\r')
        return;
      e.Handled = true;
      this.setea_grid();
    }

    private void mensaje(string var)
    {
      int num = (int) Interaction.MsgBox((object) ("Por favor revise " + var), MsgBoxStyle.OkOnly, (object) (var + " NO VALIDO !!!! "));
    }

    private void Button1_Click(object sender, EventArgs e)
    {
      this.graba_registros();
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      if (Interaction.MsgBox((object) "Seguro de Querer Eliminar?  ", MsgBoxStyle.YesNo, (object) "Eliminando Registro !!!") != MsgBoxResult.Yes)
        return;
      this.elimina();
    }

    private void mate_KeyPress(object sender, KeyPressEventArgs e)
    {
      ComboBox material = this.material;
      Module1.AutoCompletar(ref material, e);
      this.material = material;
    }

    private void Colo_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.llena_grid();
    }

    private void graba_registros()
    {
      empresas empresas = new empresas();
      string str1 = Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd hh:mm:ss") + ".000";
      string str2 = Conversions.ToString(this.ec[this.ec.RowSel, 1]);
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        string str3 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "UPDATE UPC SET T1 ='", this.fg[1, 1]), (object) "', T2 = '"), this.fg[1, 2]), (object) "', T3 ='"), this.fg[1, 3]), (object) "', T4 ='"), this.fg[1, 4]), (object) "', T5 ='"), this.fg[1, 5]), (object) "', T6 = '"), this.fg[1, 6]), (object) "', T7 ='"), this.fg[1, 7]), (object) "', T8 ='"), this.fg[1, 8]), (object) "', T9 ='"), this.fg[1, 9]), (object) "', T0 = '"), this.fg[1, 10]), (object) "' "), (object) " WHERE CLIENTE = '"), (object) str2), (object) "' AND ESTILO = '"), (object) this.estil.Text), (object) "' AND COLOR = '"), (object) this.colo.Text), (object) "'"));
        command.CommandText = str3;
        if (command.ExecuteNonQuery() == 0)
        {
          string str4 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("INSERT INTO UPC (CLIENTE,ESTILO,COLOR,MATERIAL,ESCALA,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0,USUARIO,FECHA) VALUES ('" + str2 + "','" + this.estil.Text + "','" + this.colo.Text + "','" + this.material.Text + "','" + this.escala + "','"), this.fg[1, 1]), (object) "','"), this.fg[1, 2]), (object) "','"), this.fg[1, 3]), (object) "','"), this.fg[1, 4]), (object) "','"), this.fg[1, 5]), (object) "','"), this.fg[1, 6]), (object) "','"), this.fg[1, 7]), (object) "','"), this.fg[1, 8]), (object) "','"), this.fg[1, 9]), (object) "','"), this.fg[1, 10]), (object) "','"), (object) empresas.usuario), (object) "',GETDATE() )"));
          command.CommandText = str4;
          command.ExecuteNonQuery();
        }
        sqlTransaction.Commit();
        this.ec[this.ec.RowSel, 5] = (object) this.material.Text;
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

    private void elimina()
    {
      empresas empresas = new empresas();
      Strings.Format((object) DateAndTime.Now, "yyyy-MM-dd hh:mm:ss");
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        string str = "DELETE UPC WHERE CLIENTE = '" + this.cliente + "' AND ESTILO = '" + this.estil.Text + "' AND COLOR = '" + this.colo.Text + "'";
        command.CommandText = str;
        command.ExecuteNonQuery();
        sqlTransaction.Commit();
        this.ec[this.ec.RowSel, 5] = (object) "";
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

    private void ec_Click(object sender, EventArgs e)
    {
      this.selecciona_ec(this.ec.RowSel);
    }

    private void ec_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Up)
        this.selecciona_ec(checked (this.ec.Row - 1));
      if (e.KeyCode != Keys.Down)
        return;
      this.selecciona_ec(checked (this.ec.Row + 1));
    }

    private void selecciona_ec(int f)
    {
      if (f <= 0)
        return;
      try
      {
        this.cliente = Conversions.ToString(this.ec[f, 1]);
        this.estil.Text = Conversions.ToString(this.ec[f, 2]);
        this.colo.Text = Conversions.ToString(this.ec[f, 3]);
        this.escala = Conversions.ToString(this.ec[f, 4]);
        this.material.FindString(Conversions.ToString(this.ec[f, 5]));
        if ((uint) Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Strings.Trim(Conversions.ToString(this.ec[f, 5])), "", false) > 0U)
        {
          this.material.SelectedIndex = this.material.FindString(Conversions.ToString(this.ec[f, 5]));
          this.graba.Visible = false;
          this.quita.Visible = true;
        }
        else
        {
          this.graba.Visible = true;
          this.quita.Visible = false;
        }
        this.setea_grid();
        this.llena_grid();
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void material_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.setea_grid();
    }

    private void Button3_Click(object sender, EventArgs e)
    {
      this.graba.Visible = true;
      this.quita.Visible = false;
    }
  }
}
