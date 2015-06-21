﻿using System;
namespace aaLogReader
{
    interface ILogRecord
    {
        string Component { get; set; }
        DateTime EventDate { get; }
        DateTime EventDateTime { get; }
        ulong EventFileTime { get; set; }
        int EventMillisec { get; }
        string EventTime { get; }
        string HostFQDN { get; set; }
        string LogFlag { get; set; }
        string Message { get; set; }
        ulong MessageNumber { get; set; }
        int OffsetToNextRecord { get; set; }
        int OffsetToPrevRecord { get; set; }
        int ProcessID { get; set; }
        string ProcessName { get; set; }
        int RecordLength { get; set; }
        string SessionID { get; set; }
        int ThreadID { get; set; }
        string ToCSV(ExportFormat format = ExportFormat.Full);
        string ToDelimitedString(char Delimiter = ',', ExportFormat format = ExportFormat.Full);
        string ToJSON();
        string ToKVP(ExportFormat format = ExportFormat.Full);
        string ToTSV(ExportFormat format = ExportFormat.Full);
    }
}
