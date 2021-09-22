using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnityIntergrationApp.Common
{
    public sealed class DebugManager
    {
        private DebugManager() { }
        private static readonly Lazy<DebugManager> g_instance = new Lazy<DebugManager>();
        private static bool m_isDebug;

        public static bool IsDebug { get => m_isDebug; set => m_isDebug = value; }
        public static DebugManager Instance { get => g_instance.Value; }
    }
}
