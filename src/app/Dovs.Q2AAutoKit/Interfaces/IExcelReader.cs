﻿using System.Collections.Generic;

namespace Dovs.Q2AAutoKit.Interfaces
{
    // Interface to abstract Excel reading functionality
    public interface IExcelReader
    {
        List<UserData> ReadUserData(string filePath);
    }
}
