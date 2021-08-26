﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace HammerBatchCompiler
{
    // if by some miracle someone else wants to use this code, here's a bunch of info
    // .net's settings feature is so damn obscure writing a settings manager myself is easier than trying to figure it out
    // this settings system uses a simple key=value format like this:
    // Key1=Value1
    // Key2    = Value2
    // you can turn string trimming off if you want to use spaces in your keys and values at the start and end (i don't know why you'd ever need that though)
    // i only added string,string key/value types for my use, but you can fix that by adding templates

    static class Settings
    {
        const string SettingsName = "hbcsettings.txt";
        static string SettingsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, SettingsName);
        static Dictionary<string, string> SettingsList;
        const bool TrimKV = true; //trim keys and values

        static Dictionary<string, string> FromText(string str)
        {
            Dictionary<string, string> kvs = new Dictionary<string, string>();
            string[] lines = str.Split(Environment.NewLine.ToCharArray());

            foreach (string line in lines)
            {
                string[] kv = line.Split('=');
                if (kv.Length == 1) continue;

                kvs.Add(
                    TrimKV ? kv[0] : kv[0].Trim(),
                    TrimKV ? kv[1] : kv[1].Trim()
                );
            }

            return kvs;
        }

        static string ToText(Dictionary<string, string> kvs)
        {
            string str = "";

            foreach (KeyValuePair<string, string> kv in kvs)
            {
                str += kv.Key + "=" + kv.Value + Environment.NewLine;
            }

            str.Remove(str.Length - 1, 1); //remove newline at the end

            return str;
        }

        public static void Load()
        {
            if (!File.Exists(SettingsPath))
            {
                File.Create(SettingsPath);
                SettingsList = new Dictionary<string, string>();
            }
            else
            {
                SettingsList = FromText(File.ReadAllText(SettingsPath));
            }
        }

        public static void SetKey(string k, string v)
        {
            if (SettingsList.ContainsKey(k)) SettingsList[k] = v;
            else SettingsList.Add(k, v);
        }

        public static string GetKey(string k)
        {
            if (SettingsList.ContainsKey(k)) return SettingsList[k];
            else return null;
        }

        public static void RemoveKey(string k)
        {
            if (!SettingsList.ContainsKey(k)) return;
            else SettingsList.Remove(k);
        }

        public static void Save()
        {
            try
            {
                File.WriteAllText(SettingsPath, ToText(SettingsList));
            }
            catch(Exception e)
            {
                MessageBox.Show("ding ding ding you fucke d up " + e.Message);
            }
        }
    }
}
