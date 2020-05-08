﻿using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace crtcpl
{
    public static class Program
    {
        public const byte SUPPORTED_EEPROM_VERSION = 0x01;

        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool result;
            Mutex m = new Mutex(true, "crtcpl", out result);

            if (!result)
            {
                try
                {
#if !MONO
                    // Best effort switch to active instance
                    Process[] procs = Process.GetProcessesByName(Path.GetFileNameWithoutExtension(Application.ExecutablePath));
                    foreach (Process p in procs)
                    {
                        if (p.Id == Process.GetCurrentProcess().Id)
                            continue;

                        if (p.MainWindowHandle == IntPtr.Zero)
                            continue;

                        const int SW_SHOW = 5;

                        NativeMethods.SetForegroundWindow(p.MainWindowHandle);
                        NativeMethods.ShowWindow(p.MainWindowHandle, SW_SHOW);

                        break;
                    }
#else
                    // Sorry, don't know what to do.
                    MessageBox.Show(StringRes.StringRes.AlreadyRunning, StringRes.StringRes.AlreadyRunningTitle,
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif
                }
                catch (Exception)
                {
#if DEBUG
                    throw;
#endif
                }

                return;
            }

            try
            {
                if (Settings.Default.NeedsUpgrade)
                {
                    Settings.Default.Upgrade();
                    Settings.Default.NeedsUpgrade = false;
                    Settings.Default.Save();
                }

                if (!string.IsNullOrWhiteSpace(Settings.Default.SerialPort))
                {
                    bool bad = false;
                    try
                    {
                        UCCom.Open(Settings.Default.SerialPort);
                        byte[] ret = UCCom.SendCommand(1, 0, 0);

                        if (ret == null || ret.Length != 1 || ret[0] != SUPPORTED_EEPROM_VERSION)
                        {
                            bad = true;
                        }
                    }
                    catch (UCComException)
                    {
                        bad = true;
                    }

                    if (bad)
                    {
                        Settings.Default.SerialPort = null;
                    }
                }

                using (AppletForm a = new AppletForm())
                {
                    Application.Run(a);
                }
            }
            finally
            {
                m.ReleaseMutex();
                m.Dispose();
            }
        }
    }
}