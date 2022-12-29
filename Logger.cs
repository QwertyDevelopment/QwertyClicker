using System;

namespace QwertyClicker
{
    public partial class Logger
    {

        // DO NOT CALL DIRECTLY!
        private static void writeFile(string text)
        {
            File.AppendAllText(Directory.GetCurrentDirectory() + "\\QwertyClicker-" + DateTime.Now.ToString("MM-dd-yy")  + ".log", text + Environment.NewLine);
        }

        public static void info(string message) => Logger.writeFile(DateTime.Now.ToString("HH:mm:ss.ff MM/dd/yyyy") + " [INFO] " + message);

        public static void warning(string message) => Logger.writeFile(DateTime.Now.ToString("HH:mm:ss.ff MM/dd/yyyy") + " [WARN] " + message);

        public static void error(string message) => Logger.writeFile(DateTime.Now.ToString("HH:mm:ss.ff MM/dd/yyyy") + " [ERROR] " + message);

        public static void emergency(string message) => Logger.writeFile(DateTime.Now.ToString("HH:mm:ss.ff MM/dd/yyyy") + " [EMERGENCY] " + message);

        public static void notice(string message) => Logger.writeFile(DateTime.Now.ToString("HH:mm:ss.ff MM/dd/yyyy") + " [NOTICE] " + message);

        public static void debug(string message) => Logger.writeFile(DateTime.Now.ToString("HH:mm:ss.ff MM/dd/yyyy") + " [DEBUG] " + message);
    }
}