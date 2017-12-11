using System;
using System.Collections.Generic;
using System.Reflection;
using log4net;

namespace TicketImporter
{
    class LoggerUtil
    {
        private static readonly ILog log = LogManager.GetLogger
(MethodBase.GetCurrentMethod().DeclaringType);
        public static void WriteInLog(String currentAction)
        {
            log.Info(currentAction);
        }
    }
}
