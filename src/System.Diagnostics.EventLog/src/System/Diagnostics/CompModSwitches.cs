// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace System.ComponentModel
{
    internal static class CompModSwitches
    {
        private static volatile BooleanSwitch s_commonDesignerServices;
        private static volatile TraceSwitch s_eventLog;

        public static BooleanSwitch CommonDesignerServices
        {
            get
            {
                if (s_commonDesignerServices == null)
                {
                    s_commonDesignerServices = new BooleanSwitch(nameof(CommonDesignerServices), "Assert if any common designer service is not found.");
                }

                return s_commonDesignerServices;
            }
        }

        public static TraceSwitch EventLog
        {
            get
            {
                if (s_eventLog == null)
                {
                    s_eventLog = new TraceSwitch(nameof(EventLog), "Enable tracing for the EventLog component.");
                }
                
                return s_eventLog;
            }
        }
    }
}