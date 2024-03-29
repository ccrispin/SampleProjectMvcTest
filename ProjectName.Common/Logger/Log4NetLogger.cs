﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using log4net;
using ProjectName.Interfaces.Common;

namespace ProjectName.Common.Logger
{
    public class Log4NetLogger: ILogger
    {
        #region ILogger Members

        private ILog _logger;

        public Log4NetLogger()
        {
            _logger = LogManager.GetLogger(this.GetType());
        }

        public void Info(string message)
        {
            _logger.Info(message);
        }

        public void Warn(string message)
        {
            _logger.Warn(message);
        }

        public void Debug(string message)
        {
            _logger.Debug(message);
        }

        public void Error(string message)
        {
            _logger.Error(message);
        }

        public void Error(Exception x)
        {
            Error(LogUtility.BuildExceptionMessage(x));
        }

        public void Error(string message, Exception x)
        {
            _logger.Error(message, x);
        }

        public void Fatal(string message)
        {
            _logger.Fatal(message);
        }

        public void Fatal(Exception x)
        {
            Fatal(LogUtility.BuildExceptionMessage(x));
        }

        #endregion

        #region ILogger Members


        public void LogError(Exception ex, string source)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
