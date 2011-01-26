using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.IO.IsolatedStorage;
using System.Xml.Serialization;

namespace RefuCate_WP7
{
    public class Utils
    {
        public enum LoginStatus { SUCCESS, AUTH_ERROR, CON_ERROR };

        public static void clearUserSettings()
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                if (isf.FileExists("user.dat"))
                {
                    isf.DeleteFile("user.dat");
                }
            }
        }

        public static void saveUserSettings(Settings settings)
        {
            using (IsolatedStorageFile isf = IsolatedStorageFile.GetUserStoreForApplication())
            {
                //If user choose to save, create a new file
                using (IsolatedStorageFileStream fs = isf.CreateFile("user.dat"))
                {
                    //and serialize data
                    XmlSerializer ser = new XmlSerializer(typeof(Settings));
                    ser.Serialize(fs, settings);
                }
            }
        }

        public static LoginStatus login(Settings settings)
        {
            //TODO: Login code + encryption
            return LoginStatus.SUCCESS;
        }

        public static bool dbConnect()
        {
            return false;
        }

    }
}