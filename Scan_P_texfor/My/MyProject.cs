// Decompiled with JetBrains decompiler
// Type: Scan_P_texfor.My.MyProject
// Assembly: Scan_P_texfor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0FA0DA1E-D9F1-4EA5-97D4-609A823BC529
// Assembly location: C:\Users\Jose P. Castillo\AppData\Local\Apps\2.0\VT13K1AP.2X1\CQ8GC826.1QA\scan..tion_3b3f5ffb9b1782f5_0001.0000_6064cb4d5b1c1d18\Scan_P_texfor.exe

using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Scan_P_texfor.My
{
  [StandardModule]
  [HideModuleName]
  [GeneratedCode("MyTemplate", "11.0.0.0")]
  internal sealed class MyProject
  {
    private static readonly MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
    private static readonly MyProject.ThreadSafeObjectProvider<User> m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<User>();
    private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
    private static readonly MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();

    [HelpKeyword("My.Computer")]
    internal static MyComputer Computer
    {
      [DebuggerHidden] get
      {
        return MyProject.m_ComputerObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Application")]
    internal static MyApplication Application
    {
      [DebuggerHidden] get
      {
        return MyProject.m_AppObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.User")]
    internal static User User
    {
      [DebuggerHidden] get
      {
        return MyProject.m_UserObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.Forms")]
    internal static MyProject.MyForms Forms
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyFormsObjectProvider.GetInstance;
      }
    }

    [HelpKeyword("My.WebServices")]
    internal static MyProject.MyWebServices WebServices
    {
      [DebuggerHidden] get
      {
        return MyProject.m_MyWebServicesObjectProvider.GetInstance;
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
    internal sealed class MyForms
    {
      [ThreadStatic]
      private static Hashtable m_FormBeingCreated;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas01 m_Cajas01;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas01_D m_Cajas01_D;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas02 m_Cajas02;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas02_c m_Cajas02_c;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas03 m_Cajas03;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas04 m_Cajas04;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas05 m_Cajas05;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas05_I m_Cajas05_I;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas10 m_Cajas10;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas11 m_Cajas11;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas12 m_Cajas12;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas20 m_Cajas20;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas21 m_Cajas21;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas22 m_Cajas22;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas25 m_Cajas25;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas35 m_Cajas35;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Cajas99 m_Cajas99;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public cajas_esp m_cajas_esp;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public cajas_esp_c m_cajas_esp_c;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public menu m_menu;
      [EditorBrowsable(EditorBrowsableState.Never)]
      public Scan_P_texfor.Version m_Version;

      [DebuggerHidden]
      private static T Create__Instance__<T>(T Instance) where T : Form, new()
      {
        if ((object) Instance != null && !Instance.IsDisposed)
          return Instance;
        if (MyProject.MyForms.m_FormBeingCreated != null)
        {
          if (MyProject.MyForms.m_FormBeingCreated.ContainsKey((object) typeof (T)))
            throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
        }
        else
          MyProject.MyForms.m_FormBeingCreated = new Hashtable();
        MyProject.MyForms.m_FormBeingCreated.Add((object) typeof (T), (object) null);
        TargetInvocationException invocationException;
        try
        {
          return new T();
        }
        catch (TargetInvocationException ex) when (
        {
          // ISSUE: unable to correctly present filter
          ProjectData.SetProjectError((Exception) ex);
          invocationException = ex;
          if (invocationException.InnerException != null)
          {
            SuccessfulFiltering;
          }
          else
            throw;
        }
        )
        {
          throw new InvalidOperationException(Utils.GetResourceString("WinForms_SeeInnerException", invocationException.InnerException.Message), invocationException.InnerException);
        }
        finally
        {
          MyProject.MyForms.m_FormBeingCreated.Remove((object) typeof (T));
        }
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance) where T : Form
      {
        instance.Dispose();
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyForms()
      {
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyForms);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      public override string ToString()
      {
        return base.ToString();
      }

      public Cajas01 Cajas01
      {
        [DebuggerHidden] get
        {
          this.m_Cajas01 = MyProject.MyForms.Create__Instance__<Cajas01>(this.m_Cajas01);
          return this.m_Cajas01;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas01)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas01>(ref this.m_Cajas01);
        }
      }

      public Cajas01_D Cajas01_D
      {
        [DebuggerHidden] get
        {
          this.m_Cajas01_D = MyProject.MyForms.Create__Instance__<Cajas01_D>(this.m_Cajas01_D);
          return this.m_Cajas01_D;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas01_D)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas01_D>(ref this.m_Cajas01_D);
        }
      }

      public Cajas02 Cajas02
      {
        [DebuggerHidden] get
        {
          this.m_Cajas02 = MyProject.MyForms.Create__Instance__<Cajas02>(this.m_Cajas02);
          return this.m_Cajas02;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas02)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas02>(ref this.m_Cajas02);
        }
      }

      public Cajas02_c Cajas02_c
      {
        [DebuggerHidden] get
        {
          this.m_Cajas02_c = MyProject.MyForms.Create__Instance__<Cajas02_c>(this.m_Cajas02_c);
          return this.m_Cajas02_c;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas02_c)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas02_c>(ref this.m_Cajas02_c);
        }
      }

      public Cajas03 Cajas03
      {
        [DebuggerHidden] get
        {
          this.m_Cajas03 = MyProject.MyForms.Create__Instance__<Cajas03>(this.m_Cajas03);
          return this.m_Cajas03;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas03)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas03>(ref this.m_Cajas03);
        }
      }

      public Cajas04 Cajas04
      {
        [DebuggerHidden] get
        {
          this.m_Cajas04 = MyProject.MyForms.Create__Instance__<Cajas04>(this.m_Cajas04);
          return this.m_Cajas04;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas04)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas04>(ref this.m_Cajas04);
        }
      }

      public Cajas05 Cajas05
      {
        [DebuggerHidden] get
        {
          this.m_Cajas05 = MyProject.MyForms.Create__Instance__<Cajas05>(this.m_Cajas05);
          return this.m_Cajas05;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas05)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas05>(ref this.m_Cajas05);
        }
      }

      public Cajas05_I Cajas05_I
      {
        [DebuggerHidden] get
        {
          this.m_Cajas05_I = MyProject.MyForms.Create__Instance__<Cajas05_I>(this.m_Cajas05_I);
          return this.m_Cajas05_I;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas05_I)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas05_I>(ref this.m_Cajas05_I);
        }
      }

      public Cajas10 Cajas10
      {
        [DebuggerHidden] get
        {
          this.m_Cajas10 = MyProject.MyForms.Create__Instance__<Cajas10>(this.m_Cajas10);
          return this.m_Cajas10;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas10)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas10>(ref this.m_Cajas10);
        }
      }

      public Cajas11 Cajas11
      {
        [DebuggerHidden] get
        {
          this.m_Cajas11 = MyProject.MyForms.Create__Instance__<Cajas11>(this.m_Cajas11);
          return this.m_Cajas11;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas11)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas11>(ref this.m_Cajas11);
        }
      }

      public Cajas12 Cajas12
      {
        [DebuggerHidden] get
        {
          this.m_Cajas12 = MyProject.MyForms.Create__Instance__<Cajas12>(this.m_Cajas12);
          return this.m_Cajas12;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas12)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas12>(ref this.m_Cajas12);
        }
      }

      public Cajas20 Cajas20
      {
        [DebuggerHidden] get
        {
          this.m_Cajas20 = MyProject.MyForms.Create__Instance__<Cajas20>(this.m_Cajas20);
          return this.m_Cajas20;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas20)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas20>(ref this.m_Cajas20);
        }
      }

      public Cajas21 Cajas21
      {
        [DebuggerHidden] get
        {
          this.m_Cajas21 = MyProject.MyForms.Create__Instance__<Cajas21>(this.m_Cajas21);
          return this.m_Cajas21;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas21)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas21>(ref this.m_Cajas21);
        }
      }

      public Cajas22 Cajas22
      {
        [DebuggerHidden] get
        {
          this.m_Cajas22 = MyProject.MyForms.Create__Instance__<Cajas22>(this.m_Cajas22);
          return this.m_Cajas22;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas22)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas22>(ref this.m_Cajas22);
        }
      }

      public Cajas25 Cajas25
      {
        [DebuggerHidden] get
        {
          this.m_Cajas25 = MyProject.MyForms.Create__Instance__<Cajas25>(this.m_Cajas25);
          return this.m_Cajas25;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas25)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas25>(ref this.m_Cajas25);
        }
      }

      public Cajas35 Cajas35
      {
        [DebuggerHidden] get
        {
          this.m_Cajas35 = MyProject.MyForms.Create__Instance__<Cajas35>(this.m_Cajas35);
          return this.m_Cajas35;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas35)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas35>(ref this.m_Cajas35);
        }
      }

      public Cajas99 Cajas99
      {
        [DebuggerHidden] get
        {
          this.m_Cajas99 = MyProject.MyForms.Create__Instance__<Cajas99>(this.m_Cajas99);
          return this.m_Cajas99;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Cajas99)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Cajas99>(ref this.m_Cajas99);
        }
      }

      public cajas_esp cajas_esp
      {
        [DebuggerHidden] get
        {
          this.m_cajas_esp = MyProject.MyForms.Create__Instance__<cajas_esp>(this.m_cajas_esp);
          return this.m_cajas_esp;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_cajas_esp)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<cajas_esp>(ref this.m_cajas_esp);
        }
      }

      public cajas_esp_c cajas_esp_c
      {
        [DebuggerHidden] get
        {
          this.m_cajas_esp_c = MyProject.MyForms.Create__Instance__<cajas_esp_c>(this.m_cajas_esp_c);
          return this.m_cajas_esp_c;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_cajas_esp_c)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<cajas_esp_c>(ref this.m_cajas_esp_c);
        }
      }

      public menu menu
      {
        [DebuggerHidden] get
        {
          this.m_menu = MyProject.MyForms.Create__Instance__<menu>(this.m_menu);
          return this.m_menu;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_menu)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<menu>(ref this.m_menu);
        }
      }

      public Scan_P_texfor.Version Version
      {
        [DebuggerHidden] get
        {
          this.m_Version = MyProject.MyForms.Create__Instance__<Scan_P_texfor.Version>(this.m_Version);
          return this.m_Version;
        }
        [DebuggerHidden] set
        {
          if (value == this.m_Version)
            return;
          if (value != null)
            throw new ArgumentException("Property can only be set to Nothing");
          this.Dispose__Instance__<Scan_P_texfor.Version>(ref this.m_Version);
        }
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
    internal sealed class MyWebServices
    {
      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override bool Equals(object o)
      {
        return base.Equals(RuntimeHelpers.GetObjectValue(o));
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override int GetHashCode()
      {
        return base.GetHashCode();
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      internal new System.Type GetType()
      {
        return typeof (MyProject.MyWebServices);
      }

      [EditorBrowsable(EditorBrowsableState.Never)]
      [DebuggerHidden]
      public override string ToString()
      {
        return base.ToString();
      }

      [DebuggerHidden]
      private static T Create__Instance__<T>(T instance) where T : new()
      {
        if ((object) instance == null)
          return new T();
        return instance;
      }

      [DebuggerHidden]
      private void Dispose__Instance__<T>(ref T instance)
      {
        instance = default (T);
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public MyWebServices()
      {
      }
    }

    [EditorBrowsable(EditorBrowsableState.Never)]
    [ComVisible(false)]
    internal sealed class ThreadSafeObjectProvider<T> where T : new()
    {
      internal T GetInstance
      {
        [DebuggerHidden] get
        {
          if ((object) MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
            MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = new T();
          return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
        }
      }

      [DebuggerHidden]
      [EditorBrowsable(EditorBrowsableState.Never)]
      public ThreadSafeObjectProvider()
      {
      }
    }
  }
}
