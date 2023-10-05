using System;
using System.Collections.Generic;
using System.Text;

namespace GaHealthcareNurses.Helpers
{
    public class AppGlobalConstants
    {
        //To maintain user toekn..
        public static string UserToken = string.Empty;
        //To maintain user toekn..
        public static string LoginUserToken = string.Empty;
        //To maintain user toekn..
        public static string LoginUserSecret = string.Empty;
        //To maintain multiple times click...
        public static int PageCount = 0;

        //To maintain variable for image from camera/gallery
        public static string imgFilePath = string.Empty;
        //To maintain variable for Media picker selected items
        public static string PartImageBase64 = string.Empty;
        public static string LoanSubmitSms = string.Empty;


        //To maintain Registration constants
        public static bool IsVerifyToken = false;
    }
}
