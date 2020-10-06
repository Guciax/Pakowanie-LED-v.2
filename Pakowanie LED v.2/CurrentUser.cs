using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MST.MES;

namespace Pakowanie_LED_v._2
{
    public class CurrentUser
    {
        private static UsersDataBase.DataStructures.UserStructure _UserData;
        private static DateTime LastAcceddTime = DateTime.MinValue;
        public static Label lCurrentUser;
        public static MST.MES.UsersDataBase.DataStructures.UserStructure UserData
        {
            get
            {
                if ((DateTime.Now - LastAcceddTime).TotalMinutes >= 15)
                {
                    _UserData = null;
                }
                if (_UserData == null)
                {
                    using (NgRegistration.Forms.ScanUser scanUserForm = new NgRegistration.Forms.ScanUser())
                    {
                        if (scanUserForm.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            if (scanUserForm.User != null)
                            {
                                _UserData = scanUserForm.User;
                            }
                        }
                    }
                }
                if (_UserData != null)
                {
                    lCurrentUser.Text = $"Operator pakowania: {_UserData.Name}";
                }
                else
                {
                    lCurrentUser.Text = $"Operator pakowania: BRAK";
                }
                LastAcceddTime = DateTime.Now;
                return _UserData;
            }
            set
            {
                _UserData = value;
            }
        }
        internal static void LogoutUser()
        {
            _UserData = null;
            lCurrentUser.Text = $"Aktualny użytkownik: BRAK";
        }
    }
}