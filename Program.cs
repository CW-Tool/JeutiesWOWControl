// Decompiled with JetBrains decompiler
// Type: JeutieControl.Program
// Assembly: JeutiesRepackControl, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 2E5953BA-597D-45EC-BE8D-6CBCB16A2C42
// Assembly location: C:\Users\hands\Desktop\FOX3.2控制器.exe

using System;
using System.Windows.Forms;

namespace JeutieControl
{
  internal static class Program
  {
    [STAThread]
    private static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      Application.Run((Form) new Form1());
    }
  }
}
