using System;
using System.Collections.Generic;
using System.Linq;
using Modding;

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
        
        public override void Initialize()
        {
            Log("Initializing Mod...");
            
            
        }
    }
}