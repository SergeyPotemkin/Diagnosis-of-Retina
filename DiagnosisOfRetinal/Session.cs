using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagnosisOfRetinal
{
    class Session
    {
        public static Dictionary<string, Object> sessionObjects = new Dictionary<string, Object>();

        public static void setSessionItem<T>(string sessionName, T sessionObject){

            sessionObjects[sessionName] = sessionObject;
        }
        public static T getSessionItem<T>(string sessionName)
        {
            return (T)sessionObjects[sessionName];
        }

        public static bool isHaveSession(string sessionName)
        {
            return sessionObjects.ContainsKey(sessionName);
        }

        public static void removeSessionItem(string sessionName)
        {
            sessionObjects.Remove(sessionName);
        }

        public static void removeSessionAll()
        {
            sessionObjects.Clear();
        }
    }
}
