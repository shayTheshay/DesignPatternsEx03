using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp.DevTools.Database;
using FacebookWrapper;
using FacebookWrapper.ObjectModel;

namespace BasicFacebookFeatures
{
    public class UserSession
    {
        private static UserSession _instance = null;
        private static readonly object _lock = new object();
        public event Action LoginSuccess;
        public event Action LoginFailure;

        public static UserSession getInstance()
        {
            if(_instance == null)
            {
                lock(_lock)
                {
                    if(_instance == null)
                        _instance = new UserSession();
                }
            }

            return _instance;
        }

        private UserSession()
        {
        }

        private LoginResult r_LoginResult = null;
        public LoginResult LoginResult
        {
            get { return r_LoginResult; }
        }

        public void InitializeSession(string i_AppID)
        {
            r_LoginResult = FacebookService.Login(
                i_AppID,
                /// requested permissions:
                "email",
                "public_profile",
                "user_age_range",
                "user_birthday",
                "user_events",
                "user_friends",
                "user_gender",
                "user_hometown",
                "user_likes",
                "user_link",
                "user_location",
                "user_photos",
                "user_posts",
                "user_videos",
                "groups_show_list",
                "groups_access_member_info");
            if (r_LoginResult != null && !string.IsNullOrEmpty(r_LoginResult.AccessToken))
            {
                onLoginSuccess();
            }
            else
            {
                onLoginFailure();
            }
        }

        public User User
        {
            get { return r_LoginResult.LoggedInUser; }
        }

        public void LogOut()
        {
            _instance = null;
        }

        private void onLoginSuccess()
        {
            LoginSuccess.Invoke();
        }

        private void onLoginFailure()
        {
            LoginFailure.Invoke();
        }


    }
}
