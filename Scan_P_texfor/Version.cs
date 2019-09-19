// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.Version
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace Scan_P_texfor
{
  [DesignerGenerated]
  public class Version : Form
  {
    private IContainer components;

    public Version()
    {
      this.Load += new EventHandler(this.Version_Load);
      this.InitializeComponent();
    }

    [DebuggerNonUserCode]
    protected override void Dispose(bool disposing)
    {
      try
      {
        if (!disposing || this.components == null)
          return;
        this.components.Dispose();
      }
      finally
      {
        base.Dispose(disposing);
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (Version));
      this.Label1 = new Label();
      this.Label2 = new Label();
      this.Label3 = new Label();
      this.Label4 = new Label();
      this.Label5 = new Label();
      this.nombre = new Label();
      this.empresa = new Label();
      this.marca = new Label();
      this.versiones = new Label();
      this.autor = new Label();
      this.Label6 = new Label();
      this.copyw = new Label();
      this.SuspendLayout();
      this.Label1.Location = new Point(12, 20);
      this.Label1.Name = "Label1";
      this.Label1.Size = new Size(100, 23);
      this.Label1.TabIndex = 0;
      this.Label1.Text = "Nombre Software:";
      this.Label1.TextAlign = ContentAlignment.MiddleLeft;
      this.Label2.Location = new Point(12, 45);
      this.Label2.Name = "Label2";
      this.Label2.Size = new Size(100, 23);
      this.Label2.TabIndex = 1;
      this.Label2.Text = "Empresa:";
      this.Label2.TextAlign = ContentAlignment.MiddleLeft;
      this.Label3.Location = new Point(12, 70);
      this.Label3.Name = "Label3";
      this.Label3.Size = new Size(100, 23);
      this.Label3.TabIndex = 2;
      this.Label3.Text = "Trademark:";
      this.Label3.TextAlign = ContentAlignment.MiddleLeft;
      this.Label4.Location = new Point(12, 95);
      this.Label4.Name = "Label4";
      this.Label4.Size = new Size(100, 23);
      this.Label4.TabIndex = 3;
      this.Label4.Text = "Version:";
      this.Label4.TextAlign = ContentAlignment.MiddleLeft;
      this.Label5.Location = new Point(12, 120);
      this.Label5.Name = "Label5";
      this.Label5.Size = new Size(100, 23);
      this.Label5.TabIndex = 4;
      this.Label5.Text = "Autor:";
      this.Label5.TextAlign = ContentAlignment.MiddleLeft;
      this.nombre.BackColor = Color.White;
      this.nombre.BorderStyle = BorderStyle.FixedSingle;
      this.nombre.Location = new Point(136, 20);
      this.nombre.Name = "nombre";
      this.nombre.Size = new Size(222, 23);
      this.nombre.TabIndex = 5;
      this.nombre.Text = "Scan & Pack  (TEXFOR)";
      this.nombre.TextAlign = ContentAlignment.MiddleLeft;
      this.empresa.BackColor = Color.White;
      this.empresa.BorderStyle = BorderStyle.FixedSingle;
      this.empresa.Location = new Point(136, 45);
      this.empresa.Name = "empresa";
      this.empresa.Size = new Size(222, 23);
      this.empresa.TabIndex = 6;
      this.empresa.Text = " ";
      this.empresa.TextAlign = ContentAlignment.MiddleLeft;
      this.marca.BackColor = Color.White;
      this.marca.BorderStyle = BorderStyle.FixedSingle;
      this.marca.Location = new Point(136, 70);
      this.marca.Name = "marca";
      this.marca.Size = new Size(222, 23);
      this.marca.TabIndex = 7;
      this.marca.Text = " Jap Software  TF. (Autor Jesús Acosta)";
      this.marca.TextAlign = ContentAlignment.MiddleLeft;
      this.versiones.BackColor = Color.White;
      this.versiones.BorderStyle = BorderStyle.FixedSingle;
      this.versiones.Location = new Point(136, 95);
      this.versiones.Name = "versiones";
      this.versiones.Size = new Size(222, 23);
      this.versiones.TabIndex = 8;
      this.versiones.TextAlign = ContentAlignment.MiddleLeft;
      this.autor.BackColor = Color.White;
      this.autor.BorderStyle = BorderStyle.FixedSingle;
      this.autor.Location = new Point(136, 120);
      this.autor.Name = "autor";
      this.autor.Size = new Size(222, 23);
      this.autor.TabIndex = 9;
      this.autor.Text = "Jesus Acosta Paiz";
      this.autor.TextAlign = ContentAlignment.MiddleLeft;
      this.Label6.Location = new Point(12, 145);
      this.Label6.Name = "Label6";
      this.Label6.Size = new Size(100, 23);
      this.Label6.TabIndex = 10;
      this.Label6.Text = "Copyright:";
      this.Label6.TextAlign = ContentAlignment.MiddleLeft;
      this.copyw.BackColor = Color.White;
      this.copyw.BorderStyle = BorderStyle.FixedSingle;
      this.copyw.Location = new Point(136, 145);
      this.copyw.Name = "copyw";
      this.copyw.Size = new Size(222, 23);
      this.copyw.TabIndex = 11;
      this.copyw.Text = " 2019";
      this.copyw.TextAlign = ContentAlignment.MiddleLeft;
      this.AutoScaleDimensions = new SizeF(6f, 13f);
      this.AutoScaleMode = AutoScaleMode.Font;
      this.BackColor = Color.FromArgb(222, 236, 237);
      this.ClientSize = new Size(376, 180);
      this.Controls.Add((Control) this.copyw);
      this.Controls.Add((Control) this.Label6);
      this.Controls.Add((Control) this.autor);
      this.Controls.Add((Control) this.versiones);
      this.Controls.Add((Control) this.marca);
      this.Controls.Add((Control) this.empresa);
      this.Controls.Add((Control) this.nombre);
      this.Controls.Add((Control) this.Label5);
      this.Controls.Add((Control) this.Label4);
      this.Controls.Add((Control) this.Label3);
      this.Controls.Add((Control) this.Label2);
      this.Controls.Add((Control) this.Label1);
      this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = nameof (Version);
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "Sistema de Scan & Pack";
      this.ResumeLayout(false);
    }

    internal virtual Label Label1 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label2 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label3 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label4 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label5 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label nombre
    {
      get
      {
        return this._nombre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)] set
      {
        EventHandler eventHandler = new EventHandler(this.nombre_Click);
        Label nombre1 = this._nombre;
        if (nombre1 != null)
          nombre1.Click -= eventHandler;
        this._nombre = value;
        Label nombre2 = this._nombre;
        if (nombre2 == null)
          return;
        nombre2.Click += eventHandler;
      }
    }

    internal virtual Label empresa { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label marca { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label versiones { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label autor { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label Label6 { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    internal virtual Label copyw { get; [MethodImpl(MethodImplOptions.Synchronized)] set; }

    private void Version_Load(object sender, EventArgs e)
    {
      this.obtiene_version();
    }

    private void obtiene_version()
    {
      this.versiones.Text = Application.ProductVersion;
      this.empresa.Text = "Texfor S.A.";
      this.copyw.Text = "2019";
    }

    private void nombre_Click(object sender, EventArgs e)
    {
    }
  }
}
