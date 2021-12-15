using System;
using System.Collections.Generic;
using System.Linq;
using Modding;
using UnityEngine;

namespace UnityErrorLog
{
    public class UnityErrorLog : Mod
    {
        internal static UnityErrorLog instance;
        
        public UnityErrorLog() : base(null)
        {
            instance = this;
        }
        
		public override string GetVersion()
		{
			return "0.1";
		}

        private static readonly SimpleLogger UnityLogger = new SimpleLogger("UNITY");

        public override void Initialize()
        {
            if (ModHooks.GetMod("QoL") is Mod) return;

            Log("Initializing Mod...");

            Application.SetStackTraceLogType(LogType.Exception, StackTraceLogType.Full);
            Application.logMessageReceived += HandleLog;
        }

        private static void HandleLog(string condition, string stacktrace, LogType type)
        {
            if (type != LogType.Exception) return;

            UnityLogger.LogError(condition);
            UnityLogger.LogError(stacktrace);
        }
    }
}