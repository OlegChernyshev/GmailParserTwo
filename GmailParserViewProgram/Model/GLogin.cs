﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AE.Net.Mail;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;

using GmailParserViewProgram.Act;

namespace GmailParserViewProgram.Model
{
    public class GLogin
    {
        static private GLogin glogin = null;
        static public GLogin Glogin { get { return glogin; } private set { glogin = value; } }
        static public void Init()
        {
            glogin = new GLogin();
        }

        public GLogin()
        {

        }
        const string ApplicationName = "EmailParser.EBFI";
        const string clientId = "924776002477-2lmjf195p2ajjbshcsubeg2sr9lmordv.apps.googleusercontent.com";
        const string clientSecret = "6o1rF8fLCdzYbzmOojU6UoYn";

        const string userName = "user";

        string[] scopes = new string[]
            {
                GmailService.Scope.GmailReadonly,
                GmailService.Scope.MailGoogleCom,
                GmailService.Scope.GmailMetadata
            };

        private UserCredential credential;
        private GmailService gmailService;
        public GmailService GmailService { get { return gmailService; } private set { gmailService = value; } }

        public void CreateGmailService()
        {
<<<<<<< HEAD
             credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
=======
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
>>>>>>> 2ae205d30d9660f7d8ba0975eb374791d72f2551
             new ClientSecrets
             {
                 ClientId = clientId,
                 ClientSecret = clientSecret
             },
             new[] { GmailService.Scope.GmailModify },
             userName,
             CancellationToken.None
             ).Result;
<<<<<<< HEAD
            

            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret
                },
                new[] { GmailService.Scope.GmailModify },
                userName,
                CancellationToken.None
                ).Result;
=======
>>>>>>> 2ae205d30d9660f7d8ba0975eb374791d72f2551

            gmailService = new GmailService(new BaseClientService.Initializer
            {
                ApplicationName = "GmailParserViewProgram",
                HttpClientInitializer = credential
            });

        }

        public async Task DeleteUserAuthorization()
        {
            await credential.RevokeTokenAsync(CancellationToken.None);
        }

    }
}
