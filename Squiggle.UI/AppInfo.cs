﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace Squiggle.UI
{
    class AppInfo
    {
        public static string Location { get; private set; }
        public static string FilePath { get; private set; }
        public static Version Version { get; private set; }

        static AppInfo()
        {
            var assembly = Assembly.GetExecutingAssembly();
            FilePath = assembly.Location;
            Location = Path.GetDirectoryName(FilePath);
            Version = assembly.GetName().Version;
        }
    }
}
