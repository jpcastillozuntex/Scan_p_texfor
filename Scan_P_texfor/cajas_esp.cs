// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.cajas_esp
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
  public class cajas_esp : Form
  {
    private IContainer components;
    private SqlConnection cnn;
    private DataRow dr;
    private DataTable mt;
    private DataTable dt;
    private string strsql;

    public cajas_esp()
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

    internal virtual ToolTip ToolTip1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    internal virtual Button mas
    {
      get
      {
        return this._mas;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.mas_Click);
        Button mas1 = this._mas;
        if (mas1 != null)
          mas1.Click -= eventHandler;
        this._mas = value;
        Button mas2 = this._mas;
        if (mas2 == null)
          return;
        mas2.Click += eventHandler;
      }
    }

    internal virtual Button correcto
    {
      get
      {
        return this._correcto;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.correcto_Click);
        Button correcto1 = this._correcto;
        if (correcto1 != null)
          correcto1.Click -= eventHandler;
        this._correcto = value;
        Button correcto2 = this._correcto;
        if (correcto2 == null)
          return;
        correcto2.Click += eventHandler;
      }
    }

    internal virtual C1.Win.C1FlexGrid.C1FlexGrid fg { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = (IContainer) new Container();
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (cajas_esp));
      this.ToolTip1 = new ToolTip(this.components);
      this.G1 = new Button();
      this.mas = new Button();
      this.correcto = new Button();
      this.Button2 = new Button();
      this.fg = new C1.Win.C1FlexGrid.C1FlexGrid();
      this.fg.BeginInit();
      this.SuspendLayout();
      this.G1.BackColor = Color.FromArgb(46, 196, 245);
      this.G1.FlatStyle = FlatStyle.Popup;
      this.G1.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.G1.ForeColor = Color.Black;
      this.G1.Image = (Image) componentResourceManager.GetObject("G1.Image");
      this.G1.Location = new Point(848, 8);
      this.G1.Name = "G1";
      this.G1.Size = new Size(35, 35);
      this.G1.TabIndex = 81;
      this.G1.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.G1, "Graba Datos.");
      this.G1.UseVisualStyleBackColor = false;
      this.G1.Visible = false;
      this.mas.BackColor = Color.FromArgb(46, 196, 245);
      this.mas.FlatStyle = FlatStyle.Popup;
      this.mas.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.mas.ForeColor = Color.Black;
      this.mas.Image = (Image) componentResourceManager.GetObject("mas.Image");
      this.mas.Location = new Point(928, 8);
      this.mas.Name = "mas";
      this.mas.Size = new Size(35, 35);
      this.mas.TabIndex = 86;
      this.mas.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.mas, "Agrega mas lineas.");
      this.mas.UseVisualStyleBackColor = false;
      this.correcto.BackColor = Color.FromArgb(46, 196, 245);
      this.correcto.FlatStyle = FlatStyle.Popup;
      this.correcto.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.correcto.ForeColor = Color.Black;
      this.correcto.Image = (Image) componentResourceManager.GetObject("correcto.Image");
      this.correcto.Location = new Point(888, 8);
      this.correcto.Name = "correcto";
      this.correcto.Size = new Size(35, 35);
      this.correcto.TabIndex = 87;
      this.correcto.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.correcto, "Chequea que todos los datos esten correctos.");
      this.correcto.UseVisualStyleBackColor = false;
      this.Button2.BackColor = Color.FromArgb(46, 196, 245);
      this.Button2.FlatStyle = FlatStyle.Popup;
      this.Button2.Font = new Font("Comic Sans MS", 6f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.Button2.ForeColor = Color.Black;
      this.Button2.Image = (Image) componentResourceManager.GetObject("Button2.Image");
      this.Button2.Location = new Point(968, 8);
      this.Button2.Name = "Button2";
      this.Button2.Size = new Size(35, 35);
      this.Button2.TabIndex = 88;
      this.Button2.TextAlign = ContentAlignment.BottomCenter;
      this.ToolTip1.SetToolTip((Control) this.Button2, "Presione este Boton para Borrar el Registro Seleccionado.");
      this.Button2.UseVisualStyleBackColor = false;
      this.fg.AllowDragging = AllowDraggingEnum.Both;
      this.fg.AllowFiltering = true;
      this.fg.AllowResizing = AllowResizingEnum.None;
      this.fg.ColumnInfo = componentResourceManager.GetString("fg.ColumnInfo");
      this.fg.FocusRect = FocusRectEnum.None;
      this.fg.Font = new Font("Tahoma", 9.75f);
      this.fg.ForeColor = Color.Black;
      this.fg.HighLight = HighLightEnum.WithFocus;
      this.fg.KeyActionEnter = KeyActionEnum.MoveAcross;
      this.fg.KeyActionTab = KeyActionEnum.MoveAcross;
      this.fg.Location = new Point(12, 49);
      this.fg.Name = "fg";
      this.fg.Rows.Count = 100;
      this.fg.Rows.DefaultSize = 19;
      this.fg.Size = new Size(1054, 654);
      this.fg.StyleInfo = componentResourceManager.GetString("fg.StyleInfo");
      this.fg.SubtotalPosition = SubtotalPositionEnum.BelowData;
      this.fg.TabIndex = 89;
      this.AutoScaleBaseSize = new Size(6, 15);
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(1078, 707);
      this.Controls.Add((Control) this.fg);
      this.Controls.Add((Control) this.Button2);
      this.Controls.Add((Control) this.correcto);
      this.Controls.Add((Control) this.mas);
      this.Controls.Add((Control) this.G1);
      this.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Regular, GraphicsUnit.Point, (byte) 0);
      this.ForeColor = Color.Red;
      this.FormBorderStyle = FormBorderStyle.Fixed3D;
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (cajas_esp);
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Utilización de Cajas";
      this.fg.EndInit();
      this.ResumeLayout(false);
    }

    private void cajas_esp_Load(object sender, EventArgs e)
    {
      this.strsql = "SELECT DISTINCT ESTILO FROM ESTILOS ORDER BY ESTILO";
      this.llena_combos_fg(1, this.strsql, "ESTILO", ref this.dt);
      this.setea_grid();
      this.llena_grid();
    }

    private void llena_combos_fg(int c, string strsql, string variable, ref DataTable dt)
    {
      dt = new DataTable();
      string str = "";
      Module1.llena_tablas(ref dt, strsql, ref this.cnn);
      try
      {
        foreach (DataRow row in dt.Rows)
          str = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) str, row[variable]), (object) "|"));
      }
      finally
      {
        IEnumerator enumerator;
        if (enumerator is IDisposable)
          (enumerator as IDisposable).Dispose();
      }
      this.fg.Cols[c].ComboList = str;
    }

    private void llena_grid()
    {
      DataTable dt = new DataTable();
      int index1 = 1;
      Module1.llena_tablas(ref dt, "SELECT * FROM CAJAS19 ORDER BY ESTILO", ref this.cnn);
      this.fg.Rows.Count = checked (dt.Rows.Count + 50);
      try
      {
        foreach (DataRow row in dt.Rows)
        {
          this.fg[index1, 1] = RuntimeHelpers.GetObjectValue(row["ESTILO"]);
          int index2 = 1;
          do
          {
            this.fg[index1, checked (index2 + 1)] = RuntimeHelpers.GetObjectValue(row[index2]);
            checked { ++index2; }
          }
          while (index2 <= 10);
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

    private void G1_Click(object sender, EventArgs e)
    {
      bool ok;
      this.revisa_datos(ref ok);
      if (ok)
      {
        this.graba_datos();
      }
      else
      {
        int num = (int) Interaction.MsgBox((object) "No puedo grabar.", MsgBoxStyle.Exclamation, (object) "Aun existen errores !!!");
      }
    }

    private void revisa_datos(ref bool ok)
    {
      ok = true;
      this.fg.Sort(SortFlags.Ascending, 1, 2);
      this.elimina_blancos(ref ok);
      if (this.fg.Rows.Count > 0)
        return;
      int num = (int) Interaction.MsgBox((object) "Aun no ha ingresado ningun dato!!!", MsgBoxStyle.Critical, (object) "Por favor verifique.");
      ok = false;
    }

    private void elimina_blancos(ref bool ok)
    {
      Decimal num1 = new Decimal();
      try
      {
        int num2 = checked (this.fg.Rows.Count - 1);
        int index1 = 1;
        while (index1 <= num2)
        {
          Decimal d1 = new Decimal();
          int index2 = 2;
          do
          {
            if (Decimal.Compare(Conversions.ToDecimal(this.fg[index1, index2]), Decimal.Zero) > 0)
              d1 = Decimal.Add(d1, Decimal.One);
            checked { ++index2; }
          }
          while (index2 <= 11);
          if (Conversions.ToBoolean(Microsoft.VisualBasic.CompilerServices.Operators.OrObject(Microsoft.VisualBasic.CompilerServices.Operators.CompareObjectEqual(this.fg[index1, 1], (object) null, false), (object) (Decimal.Compare(d1, Decimal.One) < 0))))
          {
            this.fg.Rows.Remove(index1);
            checked { --index1; }
          }
          checked { ++index1; }
        }
      }
      catch (Exception ex)
      {
        ProjectData.SetProjectError(ex);
        ProjectData.ClearProjectError();
      }
    }

    private void fg_rowcolchange(object sender, RowColEventArgs e)
    {
      int rowSel = this.fg.RowSel;
    }

    private void graba_datos()
    {
      int[] numArray = new int[10];
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        int num1 = checked (this.fg.Rows.Count - 1);
        int index1 = 1;
        while (index1 <= num1)
        {
          int index2 = 0;
          do
          {
            numArray[index2] = Conversions.ToInteger(this.fg[index1, checked (index2 + 2)]);
            checked { ++index2; }
          }
          while (index2 <= 9);
          string str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) ("UPDATE CAJAS19 SET T1 = '" + Conversions.ToString(numArray[0]) + "', T2 = '" + Conversions.ToString(numArray[1]) + "', T3 = '" + Conversions.ToString(numArray[2]) + "', T4 = '" + Conversions.ToString(numArray[3]) + "', T5 = '" + Conversions.ToString(numArray[4]) + "', T6 = '" + Conversions.ToString(numArray[5]) + "', T7 = '" + Conversions.ToString(numArray[6]) + "', T8 = '" + Conversions.ToString(numArray[7]) + "', T9 = '" + Conversions.ToString(numArray[8]) + "', T0 = '" + Conversions.ToString(numArray[9]) + "' WHERE ESTILO = '"), this.fg[index1, 1]), (object) "'"));
          command.CommandText = str1;
          if (command.ExecuteNonQuery() == 0)
          {
            string str2 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject((object) "INSERT INTO CAJAS19 (ESTILO,T1,T2,T3,T4,T5,T6,T7,T8,T9,T0) VALUES ('", this.fg[index1, 1]), (object) "','"), (object) numArray[0]), (object) "','"), (object) numArray[1]), (object) "','"), (object) numArray[2]), (object) "','"), (object) numArray[3]), (object) "','"), (object) numArray[4]), (object) "','"), (object) numArray[5]), (object) "','"), (object) numArray[6]), (object) "','"), (object) numArray[7]), (object) "','"), (object) numArray[8]), (object) "','"), (object) numArray[9]), (object) "')"));
            command.CommandText = str2;
            command.ExecuteNonQuery();
          }
          checked { ++index1; }
        }
        sqlTransaction.Commit();
        int num2 = (int) Interaction.MsgBox((object) "Grabación Exitosa.", MsgBoxStyle.Information, (object) "Proceso Completo.");
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

    private void elimina_datos()
    {
      int rowSel = this.fg.RowSel;
      string str1 = Conversions.ToString(this.fg[rowSel, 1]);
      Conversions.ToString(this.fg[rowSel, 2]);
      this.cnn.Open();
      SqlTransaction sqlTransaction = this.cnn.BeginTransaction();
      SqlCommand command = this.cnn.CreateCommand();
      command.Transaction = sqlTransaction;
      try
      {
        string str2 = "DELETE CAJAS19 WHERE ESTILO = '" + str1 + "'";
        command.CommandText = str2;
        command.ExecuteNonQuery();
        sqlTransaction.Commit();
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

    private void mas_Click(object sender, EventArgs e)
    {
      this.fg.Rows.Count = 150;
    }

    private void correcto_Click(object sender, EventArgs e)
    {
      bool ok;
      this.revisa_datos(ref ok);
      if (!ok)
      {
        if (this.fg.Rows.Count <= 1)
          return;
        int num = (int) Interaction.MsgBox((object) "Aun existen datos incorrectos !!!", MsgBoxStyle.Critical, (object) "Por favor verifique.");
      }
      else
        this.G1.Visible = true;
    }

    private void Button2_Click(object sender, EventArgs e)
    {
      int rowSel = this.fg.RowSel;
      if (Interaction.MsgBox((object) "Está Seguro de Eliminar la Línea?  ", MsgBoxStyle.YesNo, (object) "Eliminación de Líneas") != MsgBoxResult.Yes)
        return;
      this.elimina_datos();
      this.fg.RemoveItem(rowSel);
    }
  }
}
