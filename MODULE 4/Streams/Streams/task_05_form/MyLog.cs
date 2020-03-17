using System.IO;
using System;

public class MyLog
{
    // log path
    public string LogPath { get; set; }
    private StreamWriter sw;
    public MyLog()
    {
        LogPath = @"..\..\myLog.txt";
        sw = File.AppendText(LogPath);
        sw.WriteLine("Session started: " + DateTime.Now.ToString());
    }
    // writes a string to log
    public void WriteToLog(string messageString)
    {
        sw.WriteLine(messageString);
        sw.Flush();
    }
    // desructor closes stream 
    ~MyLog()
    {
        sw = File.AppendText(LogPath);
        sw.WriteLine("Session closed: " + DateTime.Now.ToString());
        sw.Close();
    }
}
