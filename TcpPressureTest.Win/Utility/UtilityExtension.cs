using System;
using Microsoft.Win32;

namespace TcpPressureTest.Win.Utility
{
    public static class UtilityExtension
    {
        public static int ToInt(this string text)
        {
            int i = 0;
            return int.TryParse(text, out i) ? i : 0;
        }


        #region 读取和写入注册表
        public static bool SetValue(RegistryHive regk, string path, string theKey, string theValue, RegistryValueKind ValueKind)
        {
            try
            {
                RegistryKey root;
                if (Environment.Is64BitOperatingSystem)
                    root = RegistryKey.OpenBaseKey(regk, RegistryView.Registry64);
                else
                    root = RegistryKey.OpenBaseKey(regk, RegistryView.Registry32);

                RegistryKey key = root.OpenSubKey(path,true);

                if (key == null)
                {
                    root.CreateSubKey(path);
                    key = root.OpenSubKey(path, true);
                }

                key.SetValue(theKey, theValue, ValueKind);//修改键值
                key.Flush();
                key.Close();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public static string GetValue(RegistryHive regk, string path, string theKey, RegistryValueKind ValueKind)
        {
            try
            {

                RegistryKey key;
                if (Environment.Is64BitOperatingSystem)
                    key = RegistryKey.OpenBaseKey(regk, RegistryView.Registry64);
                else
                    key = RegistryKey.OpenBaseKey(regk, RegistryView.Registry32);

                key = key.OpenSubKey(path);

                object str = key.GetValue(theKey);

                key.Flush();
                key.Close();
                return str?.ToString();
            }
            catch
            {
                return "";
            }
        }

        public static bool DeleteKey(RegistryHive regk, string path, string theKey, out string ex)
        {
            try
            {
                RegistryKey root = null;
                switch (regk)
                {
                    case RegistryHive.ClassesRoot:
                        root = Registry.ClassesRoot;
                        break;
                    case RegistryHive.CurrentConfig:
                        root = Registry.CurrentConfig;
                        break;
                    case RegistryHive.CurrentUser:
                        root = Registry.CurrentUser;
                        break;
                    case RegistryHive.DynData:
                        root = Registry.DynData;
                        break;
                    case RegistryHive.LocalMachine:
                        root = Registry.LocalMachine;
                        break;
                    case RegistryHive.PerformanceData:
                        root = Registry.PerformanceData;
                        break;
                    case RegistryHive.Users:
                        root = Registry.Users;
                        break;
                    default:
                        ex = "注册表路径错误";
                        return false;
                }

                RegistryKey key = root.OpenSubKey(path, true);
                if (key == null)
                {
                    ex = "";
                    return true;
                }


                key.DeleteSubKey(theKey);

                key.Flush();
                key.Close();
                ex = "";
                return true;
            }
            catch (Exception e)
            {
                ex = e.Message;
                return false;
            }
        }

        public static bool DeleteValue(RegistryHive regk, string path, string theKey, out string ex)
        {
            try
            {
                RegistryKey root = null;
                switch (regk)
                {
                    case RegistryHive.ClassesRoot:
                        root = Registry.ClassesRoot;
                        break;
                    case RegistryHive.CurrentConfig:
                        root = Registry.CurrentConfig;
                        break;
                    case RegistryHive.CurrentUser:
                        root = Registry.CurrentUser;
                        break;
                    case RegistryHive.DynData:
                        root = Registry.DynData;
                        break;
                    case RegistryHive.LocalMachine:
                        root = Registry.LocalMachine;
                        break;
                    case RegistryHive.PerformanceData:
                        root = Registry.PerformanceData;
                        break;
                    case RegistryHive.Users:
                        root = Registry.Users;
                        break;
                    default:
                        ex = "注册表路径错误";
                        return false;
                }

                RegistryKey key = root.OpenSubKey(path, true);
                if (key == null)
                {
                    ex = "";
                    return true;
                }

                key.DeleteValue(theKey, true);

                key.Flush();
                key.Close();
                ex = "";
                return true;
            }
            catch (Exception e)
            {
                ex = e.Message;
                return false;
            }
        }


        #endregion
    }
}